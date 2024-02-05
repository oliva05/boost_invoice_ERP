using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
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
    public partial class xfrmTrasladoRecepcionDetalle : DevExpress.XtraEditors.XtraForm
    {
        Conf_TablesID tableID = new Conf_TablesID();
        Clases.Traslado Traslado = new Clases.Traslado();

        UserLogin usuarioLogueado = new UserLogin();
        int id_traslado;
        DataOperations dp;

        public xfrmTrasladoRecepcionDetalle(int pidTraslado, UserLogin pUserLogin, int pIdPuntoVenta)
        {
            InitializeComponent();
            dp = new DataOperations();
            usuarioLogueado = pUserLogin;
            
            //if (Traslado.RecuperaRegistro(pidTraslado))
            //    txtObservacion.Text = Traslado.Observacion;

            id_traslado = pidTraslado;
            Traslado = new Traslado();
            if (Traslado.RecuperaRegistro(id_traslado))
                txtCodigo.Text = Traslado.CodigoTraslado;

            ObtenerPDVs();

            gleDestino.EditValue = pIdPuntoVenta;
            gleDestino.ReadOnly = true;

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

        private void xfrmTrasladoRecepcionDetalle_Load(object sender, EventArgs e){}
        private void labelControl3_Click(object sender, EventArgs e){}
        private void btnAdd_Click(object sender, EventArgs e){}

        private void cmdDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void gvDespacho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{
            //    if (e.Column.FieldName=="cantidad")
            //    {
            //        var row = (dsDespacho.Despacho_DRow)gvDespacho.GetFocusedDataRow();
            //        if (row!=null)
            //        {
            //            if (row.existencia_actual<row.cantidad)
            //            {
            //                CajaDialogo.Error("No existe en inventario la cantidad ingresada");
            //                row.cantidad = 0;
            //                return;
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //    throw;
            //}
        }

        private void cmdAddLinea_Click(object sender, EventArgs e)
        {
            //    xfrmSelectPT frm = new xfrmSelectPT();
            //    switch (TipoTransaccionActual)
            //    {
            //        case TipoTransaccion.Insert:
            //            if (frm.ShowDialog() == DialogResult.OK)
            //            {
            //                foreach (var item in frm.seleccionados)
            //                {
            //                    dsDespacho.Despacho_DRow row1 = dsDespacho.Despacho_D.NewDespacho_DRow();

            //                    var existe_pt = from rows in dsDespacho.Despacho_D.AsEnumerable()
            //                                    group rows by new { PT_ID = rows["id_pt"], Lote = rows["lote"] } into grp
            //                                    where Convert.ToInt32(grp.Key.PT_ID) == item.PT_ID && grp.Key.Lote.ToString() == item.Lote
            //                                    select new { Count = grp.Count() };

            //                    if (existe_pt.Count() == 0)
            //                    {

            //                        row1.id_pt = item.PT_ID;
            //                        row1.pt = item.PT_Name;
            //                        row1.lote = item.Lote;
            //                        row1.ItemCode = item.Codigo;
            //                        row1.id_presentacion = item.PresentacionID;
            //                        row1.presentacion = item.Presentacion;
            //                        row1.existencia_actual = item.Existencia;
            //                        row1.cantidad = item.Cantidad_Despachar;
            //                        dsDespacho.Despacho_D.AddDespacho_DRow(row1);
            //                        dsDespacho.AcceptChanges();
            //                    }
            //                    else
            //                    {
            //                        CajaDialogo.Error("Ya se agregó el PT:" + item.PT_Name + " Lote:" + item.Lote);
            //                    }
            //                }
            //            }
            //            break;
            //        case TipoTransaccion.Update:
            //            if (frm.ShowDialog() == DialogResult.OK)
            //            {
            //                foreach (var item in frm.seleccionados)
            //                {
            //                    dsDespacho.Despacho_DRow row1 = dsDespacho.Despacho_D.NewDespacho_DRow();

            //                    var existe_pt = from rows in dsDespacho.Despacho_D.AsEnumerable()
            //                                    group rows by new { PT_ID = rows["id_pt"], Lote = rows["lote"] } into grp
            //                                    where Convert.ToInt32(grp.Key.PT_ID) == item.PT_ID && grp.Key.Lote.ToString() == item.Lote
            //                                    select new { Count = grp.Count() };

            //                    if (existe_pt.Count() == 0)
            //                    {
            //                        try
            //                        {
            //                            row1.id_pt = item.PT_ID;
            //                            row1.pt = item.PT_Name;
            //                            row1.lote = item.Lote;
            //                            row1.ItemCode = item.Codigo;
            //                            row1.id_presentacion = item.PresentacionID;
            //                            row1.presentacion = item.Presentacion;
            //                            row1.existencia_actual = item.Existencia;
            //                            row1.cantidad = item.Cantidad_Despachar;


            //                            DataOperations dp = new DataOperations();
            //                            SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            //                            cnx.Open();
            //                            SqlCommand cmd = new SqlCommand("dbo.uspInsertDespacho_D_ById", cnx);
            //                            cmd.CommandType = CommandType.StoredProcedure;
            //                            cmd.Parameters.Add("@id_h", SqlDbType.Int).Value = id_traslado;
            //                            cmd.Parameters.Add("@id_pt", SqlDbType.Int).Value = row1.id_pt;
            //                            cmd.Parameters.Add("@ItemCode", SqlDbType.VarChar).Value = row1.ItemCode;
            //                            cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = row1.lote;
            //                            cmd.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = row1.cantidad;
            //                            cmd.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = DateTime.Now;


            //                            row1.id = Convert.ToInt32(cmd.ExecuteScalar());

            //                            dsDespacho.Despacho_D.AddDespacho_DRow(row1);
            //                            dsDespacho.AcceptChanges();
            //                            cnx.Close();
            //                        }
            //                        catch (Exception ex)
            //                        {
            //                            CajaDialogo.Error(ex.Message);
            //                            CargarDetalle(id_traslado);
            //                        }
            //                    }
            //                    else
            //                    {
            //                        CajaDialogo.Error("Ya se agregó el PT:" + item.PT_Name + " Lote:" + item.Lote);
            //                    }
            //                }
            //            }
            //            break;
            //    }
        }

        SqlTransaction transaccion;

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            decimal cant = 0;
            foreach (dsDespacho.Despacho_DRow row in dsDespacho.Despacho_D)
            {
                cant += row.cantidad;
            }

            if (cant <= 0)
            {
                CajaDialogo.Error("Es necesario recepcionar al menos un producto con cantidad mayor a cero para guardar un avance!");
                return;
            }

            //try
            //{
            //    switch (TipoTransaccionActual)
            //    {
            //        case TipoTransaccion.Insert:
            //            DataOperations dp = new DataOperations();
            //            SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //            int id_inserted = 0;
            //            cnx.Open();

            //            transaccion = cnx.BeginTransaction();

            //            using (SqlCommand cmd = new SqlCommand("dbo.[uspInsert_traslado_h]", transaccion.Connection))
            //            {
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Transaction = transaccion;
            //                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
            //                cmd.Parameters.Add("@observacion", SqlDbType.VarChar).Value = txtObservacion.Text;
            //                cmd.Parameters.AddWithValue("@id_punto_venta", gleDestino.EditValue);
            //                cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuarioLogueado.Id;
            //                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dp.NowSetDateTime();

            //                id_inserted = (int)cmd.ExecuteScalar();
            //            }

            //            foreach (var item in dsDespacho.Despacho_D)
            //            {
            //                SqlCommand cmd2 = new SqlCommand("dbo.[uspInsert_traslado_d]", transaccion.Connection);
            //                cmd2.CommandType = CommandType.StoredProcedure;
            //                cmd2.Transaction = transaccion;
            //                cmd2.Parameters.Add("@id_h", SqlDbType.Int).Value = id_inserted;
            //                cmd2.Parameters.Add("@id_pt", SqlDbType.Int).Value = item.id_pt;
            //                cmd2.Parameters.Add("@itemCode", SqlDbType.VarChar).Value = item.ItemCode;
            //                cmd2.Parameters.Add("@lote", SqlDbType.VarChar).Value = item.lote;
            //                cmd2.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = item.cantidad;
            //                cmd2.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dp.NowSetDateTime();
            //                cmd2.ExecuteNonQuery();
            //            }

            //            transaccion.Commit();
            //            cnx.Close();
            //            //CajaDialogo.Information("DATOS GUARDADOS");
            //            this.DialogResult = DialogResult.OK;
            //            break;
            //        case TipoTransaccion.Update:
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    transaccion.Rollback();
            //    CajaDialogo.Error(ex.Message);
            //}
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
                dsDespacho.Cliente.Clear();
                da.Fill(dsDespacho.Cliente);
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
                dsDespacho.Despacho_D.Clear();
                da.Fill(dsDespacho.Despacho_D);


                da = new SqlDataAdapter("dbo.sp_get_detalle_recepcion_traslado_pt", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_traslado_h", id);
                dsDespacho.recepcion_traslado.Clear();
                da.Fill(dsDespacho.recepcion_traslado);
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
                    dsDespacho.PDV.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetPDV", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    da.Fill(dsDespacho.PDV);
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
            var row = (dsDespacho.Despacho_DRow)gvDespacho.GetFocusedDataRow();

            frmRecepcionItem frm = new frmRecepcionItem(row.cantidad, row.CantidadIngresada, row.ItemCode, row.pt);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TrasladoRecepcion Recepcion1 = new TrasladoRecepcion();
                Recepcion1.IdDetalleTraslado = row.id;
                Recepcion1.Cantidad = frm.CantActual;
                Recepcion1.Enable = true;
                DateTime FechaActual = dp.NowSetDateTime();
                Recepcion1.Fecha = FechaActual;
                Recepcion1.IdUser = this.usuarioLogueado.Id;
                long id_inserted = Recepcion1.InsertNewRow();

                if (id_inserted > 0)
                {
                    dsDespacho.recepcion_trasladoRow row1 = dsDespacho.recepcion_traslado.Newrecepcion_trasladoRow();

                    row1.id = id_inserted;
                    row1.cantidad = frm.CantActual;
                    row1.id_detalle_traslado = row.id;
                    row1.enable = true;
                    row1.fecha = FechaActual;
                    row1.id_user = this.usuarioLogueado.Id;
                    row1.user_name = this.usuarioLogueado.Nombre;
                    row.CantidadIngresada += frm.CantActual;

                    dsDespacho.recepcion_traslado.Addrecepcion_trasladoRow(row1);
                    dsDespacho.AcceptChanges();

                    //Iteramos y si todo esta ok cerramos el traslado en automatico
                    bool HayPendientes = false;
                    foreach (dsDespacho.Despacho_DRow rowH in dsDespacho.Despacho_D)
                    {
                        if ((rowH.cantidad - rowH.CantidadIngresada) > 0)
                        {
                            HayPendientes = true;
                            break;
                        }
                    }

                    if (!HayPendientes)
                    {
                        //Vamos a cerrar el traslado
                        Traslado TrasladoH = new Traslado();
                        //Borrador = 1,
                        //En_Recepcion = 2,
                        //Completado = 3,
                        //Cancelad = 4
                        if (TrasladoH.UpdateIdEstadoById(row.id_h, 3))
                        {
                            //CargarDetalle(row.id_h);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }

                }
            }
        }
    }
}