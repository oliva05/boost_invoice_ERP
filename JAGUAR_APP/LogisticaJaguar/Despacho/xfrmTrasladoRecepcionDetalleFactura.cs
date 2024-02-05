using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Despachos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static ACS.Classes.DataOperations;
using static JAGUAR_APP.Clases.Conf_TablesID;

namespace JAGUAR_APP.LogisticaJaguar.Despacho
{
    public partial class xfrmTrasladoRecepcionDetalleFactura : DevExpress.XtraEditors.XtraForm
    {
        Conf_TablesID tableID = new Conf_TablesID();
        Clases.Traslado Traslado = new Clases.Traslado();

        UserLogin usuarioLogueado = new UserLogin();
        int id_traslado;
        DataOperations dp;
        Int64 idFacturaH;
        PDV PuntoVentaActual;

        public xfrmTrasladoRecepcionDetalleFactura(int pidTraslado, UserLogin pUserLogin, int pIdPuntoVenta)
        {
            InitializeComponent();
            dp = new DataOperations();
            usuarioLogueado = pUserLogin;
            PuntoVentaActual = new PDV();
            PuntoVentaActual.RecuperaRegistro(pIdPuntoVenta);
            //if (Traslado.RecuperaRegistro(pidTraslado))
            //    txtObservacion.Text = Traslado.Observacion;

            id_traslado = pidTraslado;
            Traslado = new Traslado();
            //if (Traslado.RecuperaRegistro(id_traslado))
            //    txtCodigo.Text = Traslado.CodigoTraslado;

            ObtenerPDVs();

            //gleDestino.EditValue = pIdPuntoVenta;
            //gleDestino.ReadOnly = true;

            //txtCodigo.Text = Traslado.CodigoTraslado;
            CargarDetalle(id_traslado);

        }

        public xfrmTrasladoRecepcionDetalleFactura(UserLogin pUserLogin, int pIdPuntoVenta, string ptituloVentana)
        {
            InitializeComponent();
            dp = new DataOperations();
            usuarioLogueado = pUserLogin;
            this.Text = ptituloVentana;
            lblTitulo.Text = ptituloVentana;

            PuntoVentaActual = new PDV();
            PuntoVentaActual.RecuperaRegistro(pIdPuntoVenta);

            //if (Traslado.RecuperaRegistro(pidTraslado))
            //    txtObservacion.Text = Traslado.Observacion;

            //id_traslado = pidTraslado;
            Traslado = new Traslado();
            //if (Traslado.RecuperaRegistro(id_traslado))
            //    txtCodigo.Text = Traslado.CodigoTraslado;
            Traslado.RecuperaRegistro(id_traslado);

            ObtenerPDVs();

            //gleDestino.EditValue = pIdPuntoVenta;
            //gleDestino.ReadOnly = true;

            //txtCodigo.Text = Traslado.CodigoTraslado;
            CargarDetalle(id_traslado);

        }

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.Traslados))
                    txtCodigo.Text = tableID.Codigo;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmTrasladoRecepcionDetalleFactura_Load(object sender, EventArgs e){}
        private void labelControl3_Click(object sender, EventArgs e){}
        private void btnAdd_Click(object sender, EventArgs e){}

        private void cmdDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void gvDespacho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }

        private void cmdAddLinea_Click(object sender, EventArgs e)
        {
        }

        SqlTransaction transaccion;

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            decimal cant = 0;
            foreach (dsDespacho.Despacho_DRow row in dsDespacho1.Despacho_D)
            {
                cant += row.cantidad;
            }

            if (cant <= 0)
            {
                CajaDialogo.Error("Es necesario recepcionar al menos un producto con cantidad mayor a cero para guardar un avance!");
                return;
            }
        }

        private void CargarClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter("uspObtenerClientesFacturacion", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dsDespacho1.Cliente.Clear();
                da.Fill(dsDespacho1.Cliente);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDetalle(Int64 id)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                SqlDataAdapter da = new SqlDataAdapter("[dbo].[uspGetTraslado_D]", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id", id);
                dsDespacho1.Despacho_D.Clear();
                da.Fill(dsDespacho1.Despacho_D);


                da = new SqlDataAdapter("dbo.sp_get_detalle_recepcion_traslado_pt", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_traslado_h", id);
                dsDespacho1.recepcion_traslado.Clear();
                da.Fill(dsDespacho1.recepcion_traslado);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsMode_Toggled(object sender, EventArgs e)
        {
        }

        private void ObtenerPDVs()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    dsDespacho1.PDV.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetPDV", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    da.Fill(dsDespacho1.PDV);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRecepcionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }

        private void cmdCopiarDesdeFactura_Click(object sender, EventArgs e)
        {
            frmBuscarFactura frm = new frmBuscarFactura(this.PuntoVentaActual.ID, true);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDetalleFactura(frm.IdFacturaSelected);
                if (frm.IdEstado == 6)
                    errorProvider1.SetError(txtNumFactura, "Esta factura ya fue entregad!");
                else
                    errorProvider1.Clear();
            }
            else
            {
                txtNumFactura.Text = "";
                txtClienteNombre.Text = "";
            }
        }

        private void LoadDetalleFactura(long idFacturaSelected)
        {
            try
            {
                Factura Fact1 = new Factura();
                if (Fact1.RecuperarRegistro(idFacturaSelected))
                {
                    idFacturaH = idFacturaSelected;
                    txtNumFactura.Text = Fact1.NumeroDocumento;
                    txtClienteNombre.Text = Fact1.ClienteNombre;
                }

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                SqlDataAdapter da = new SqlDataAdapter("[dbo].[sp_get_avance_entrega_facturas]", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_factura", idFacturaSelected);
                dsDespacho1.detalle_factura.Clear();
                da.Fill(dsDespacho1.detalle_factura);

                da = new SqlDataAdapter("dbo.sp_get_avance_entrega_facturas_detalle_transacciones", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_factura", idFacturaSelected);
                dsDespacho1.detalle_transacciones.Clear();
                da.Fill(dsDespacho1.detalle_transacciones);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "entregar_todo":
                    bool seleccion = Convert.ToBoolean(e.Value);
                    if (seleccion)
                    {
                        var row = (dsDespacho.detalle_facturaRow)gridView2.GetFocusedDataRow();
                        decimal pendiente = row.cantidad - row.cant_recepcionado;
                        row.cant_a_entregar = pendiente;
                        row.diferencia = (row.cantidad - (row.cant_recepcionado + pendiente));
                    }
                    break;
                case "cant_a_entregar":
                    var row2 = (dsDespacho.detalle_facturaRow)gridView2.GetFocusedDataRow();
                    decimal CantidadDigitada = 0;

                    try
                    {
                        CantidadDigitada = Convert.ToDecimal(e.Value);
                    }
                    catch 
                    {
                        CantidadDigitada = -545454;
                    }

                    if (CantidadDigitada == (-545454))
                        return;

                    decimal CantPendiente = row2.cantidad - row2.cant_recepcionado;

                    if (CantidadDigitada <= 0)
                    {
                        CajaDialogo.Error("Solo se permite entregar cantidades mayores a cero!");
                        row2.SetColumnError("cant_a_entregar", "Solo se permite entregar cantidades mayores a cero!");
                        return;
                    }

                    if(CantidadDigitada > CantPendiente)
                    {
                        CajaDialogo.Error("No se permite entregar mas de la cantidad original en el documento o factura!");
                        row2.SetColumnError("cant_a_entregar", "No se permite entregar mas de la cantidad original en el documento o factura!");
                        return;
                    }

                    row2.ClearErrors();

                    row2.diferencia = row2.cantidad - row2.cant_recepcionado - CantidadDigitada;
                    row2.entregar_todo = true;
                    //row2.diferencia = (row2.cantidad - (row2.cant_recepcionado + pendiente2));
                    break;
            }

        }

        private void cmdGuardar_Click_1(object sender, EventArgs e)
        {
            int conta = 0;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.sp_set_insert_transaccion_recepcion_producto";
                command.CommandType = CommandType.StoredProcedure;

                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    foreach (dsDespacho.detalle_facturaRow row in dsDespacho1.detalle_factura)
                    {
                        if (row.entregar_todo)
                        {
                            if (row.cant_a_entregar > 0)
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_detalle_factura", row.id);
                                command.Parameters.AddWithValue("@cantidad_ingresada", row.cant_a_entregar);
                                command.Parameters.AddWithValue("@id_user", this.usuarioLogueado.Id);
                                command.Parameters.AddWithValue("@fecha", dp.NowSetDateTime());
                                command.ExecuteNonQuery();
                                conta++;
                            }
                        }
                    }

                    //Validamos si se completo la entrega o fue algo parcial
                    command.CommandText = "dbo.sp_set_estado_factura_segun_avance_entrega";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id_factura", idFacturaH);
                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ec)
                {
                    try
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                    }
                    catch (Exception ex2)
                    {
                        CajaDialogo.Error("MSJ 1: " + ec.Message + "\nMSJ 2: " + ex2.Message);
                    }                    
                }
            }

            if(conta > 0)
            {
                CajaDialogo.Information("Se han registrado correctamente " + conta.ToString() + " lineas!");
                //Recargar lineas del documento
                LoadDetalleFactura(idFacturaH);
            }

        }
    }
}