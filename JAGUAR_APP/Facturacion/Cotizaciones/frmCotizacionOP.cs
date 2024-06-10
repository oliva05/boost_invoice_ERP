using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAGUAR_APP.Clases;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Calidad.LoteConfConsumo;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    public partial class frmCotizacionOP : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        FacturacionEquipo EquipoActual;
        DataOperations dp = new DataOperations();
        int IdCotizacion;
        int ProIdCliente;
        PDV PuntoVentaActual;
        ClienteFacturacion ClienteFactura;
        int IdEstadoOrdenCompra;
        public enum TipoOperacion
        {
            Insert =1,
            Update = 2
        }

        TipoOperacion tipoOP;

        public frmCotizacionOP(frmCotizacionOP.TipoOperacion tipoOperacion, UserLogin pUserLog, PDV pPuntoVentaActual ,int idH)
        {
            InitializeComponent();

            tipoOP = tipoOperacion;
            UsuarioLogeado = pUserLog;
            PuntoVentaActual = pPuntoVentaActual;

            switch (tipoOP)
            {
                case TipoOperacion.Insert:
                    txtNumCoti.Visible = false; 
                    dtFechaVencimiento.Value = dp.Now().AddDays(15);

                    break;
                case TipoOperacion.Update:
                    txtNumCoti.Visible = true;

                    IdCotizacion = idH;
                    Cotizacion coti = new Cotizacion();
                    coti.RecuperarRegistro(IdCotizacion);
                    txtNombreCliente.Text = coti.Cliente;
                    txtRTN.Text = coti.RTN;
                    txtDireccion.Text = coti.Direccion;
                    txtTelefono.Text = coti.Telefono;
                    txtEmail.Text = coti.Email;
                    txtNumCoti.Text = coti.NumCotizacion;
                    txtContacto.Text = coti.Contacto;
                    dtFechaRegistro.Value = coti.FechaEmision;
                    dtFechaVencimiento.Value = coti.FechaVencimiento;
                    IdEstadoOrdenCompra = coti.IdEstado;
                    ProIdCliente = coti.IdCliente;
                    txtISV.EditValue = coti.ISV;
                    txtSubTotalBruto.EditValue = coti.SubTotal;
                    txtTotal.EditValue = coti.Total;

                    CargarDetalle(IdCotizacion);

                    break;
                default:
                    break;
            }

        }

        private void CargarDetalle(int pidh)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_cotizacion_detalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;;
                cmd.Parameters.AddWithValue("@id_h", pidh);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFactCotizacion1.detalle_cotizacion.Clear();
                adat.Fill(dsFactCotizacion1.detalle_cotizacion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAbrirBusqueda_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch(frmSearch.TipoBusqueda.Clientes);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ProIdCliente = frm.ItemSeleccionado.id;
                if (ClienteFactura == null)
                    ClienteFactura = new ClienteFacturacion();

                if (ClienteFactura.RecuperarRegistro(frm.ItemSeleccionado.id))
                {
                    //txtNombreCliente.Text = ClienteFactura.Nombre;
                    //txtRTN.Text = ClienteFactura.rtn
                    ClienteEmpresa clienteEmpresa1 = new ClienteEmpresa();
                    if (clienteEmpresa1.RecuperarRegistro(frm.EmpresaID, ClienteFactura.Id))
                    {
                        txtNombreCliente.Text = clienteEmpresa1.NombreLargo;
                        txtRTN.Text = clienteEmpresa1.RTN;
                        txtDireccion.Text = clienteEmpresa1.Direccion;
                        
                    }
                    else
                    {
                        txtNombreCliente.Text = ClienteFactura.NombreCliente;
                        txtDireccion.Text = ClienteFactura.Direccion;
                        txtRTN.Text = "";
                    }

                }
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminado, PuntoVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ProductoTerminado pt1 = new ProductoTerminado();
                if (pt1.Recuperar_producto(frm.ItemSeleccionado.id))
                {
                    decimal valor_total = 0;
                    decimal valor_isv = 0;

                    bool AgregarNuevo = true;
                    foreach (dsFactCotizacion.detalle_cotizacionRow rowF in dsFactCotizacion1.detalle_cotizacion)
                    {
                        if (rowF.id_pt == frm.ItemSeleccionado.id)
                        {
                            //Sumar cantidad nada mas
                            rowF.cantidad = rowF.cantidad + 1;
                            rowF.total = rowF.cantidad * rowF.precio_original;
                            rowF.isv = (rowF.cantidad * rowF.precio_original) * Convert.ToDecimal(0.15);
                            AgregarNuevo = false;
                        }
                        //valor_total += (rowF.total_linea + rowF.isv1);
                        valor_total += rowF.total;
                        valor_isv += rowF.isv;
                        txtSubTotalBruto.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));
                        txtISV.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_isv, 2));
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total + valor_isv, 2));
                    }

                    if (AgregarNuevo)
                    {
                        dsFactCotizacion.detalle_cotizacionRow row1 = dsFactCotizacion1.detalle_cotizacion.Newdetalle_cotizacionRow();
                        //dsCompras.oc_d_normalRow row1 = dsCompras1.oc_d_normal.Newoc_d_normalRow();
                        row1.codigo = frm.ItemSeleccionado.ItemCode;
                        row1.descripcion = frm.ItemSeleccionado.ItemName;
                        row1.cantidad = 1;
                        row1.precio_original = 0;
                        row1.descuento_unitario = 0;
                        row1.isv = 0;
                        row1.total = 0;
                        row1.id_pt = frm.ItemSeleccionado.id;
                        row1.id = 0;
                        row1.id_h = 0;
                        #region Calculo del precio base mas ISV
                        //if (row1.precio == 0)
                        //{
                        //    SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                        //}

                        //row1.descuento = 0;
                        //row1.itemcode = frm.ItemSeleccionado.ItemCode;
                        //row1.itemname = frm.ItemSeleccionado.ItemName;
                        //row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id);

                        //row1.isv1 = row1.isv2 = row1.isv3 = 0;
                        //Impuesto impuesto = new Impuesto();
                        //decimal tasaISV = 0;

                        //if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                        //{
                        //    tasaISV = impuesto.Valor / 100;
                        //    row1.isv1 = ((row1.cantidad * row1.precio) - row1.descuento) * tasaISV;
                        //    row1.tasa_isv = tasaISV;
                        //    row1.id_isv_aplicable = impuesto.Id;
                        //}
                        //else
                        //{
                        //    row1.tasa_isv = 0;
                        //    row1.id_isv_aplicable = 0;
                        //}

                        //row1.total_linea = (row1.cantidad * row1.precio) - row1.descuento + row1.isv1 + row1.isv2 + row1.isv3;
                        #endregion

                        //if (row1.precio_original == 0)
                        //{
                        //    CajaDialogo.Error("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                        //    return;
                        //}

                        Impuesto impuesto = new Impuesto();
                        decimal tasaISV = 0;

                        //if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                        //{
                        //    tasaISV = impuesto.Valor / 100;
                        //    row1.isv1 = ((row1.precio - row1.descuento) / 100) * impuesto.Valor;
                        //    row1.precio = (row1.precio - row1.descuento) - row1.isv1;

                        //    row1.tasa_isv = tasaISV;
                        //    row1.id_isv_aplicable = impuesto.Id;
                        //}
                        //else
                        //{
                        //    row1.tasa_isv = 0;
                        //    row1.id_isv_aplicable = 0;
                        //    row1.precio = (row1.precio - row1.descuento);
                        //}

                        //row1.total_linea = (row1.cantidad * row1.precio) + (row1.cantidad * row1.isv1) + (row1.cantidad * row1.isv2) + (row1.cantidad * row1.isv3);


                        //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                        dsFactCotizacion1.detalle_cotizacion.Adddetalle_cotizacionRow(row1);
                        valor_total += (row1.total);// + row1.isv1);
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));

                        if (dsFactCotizacion1.detalle_cotizacion.Count > 0)
                            gridView1.FocusedRowHandle = dsFactCotizacion1.detalle_cotizacion.Count - 1;
                        else
                            gridView1.FocusedRowHandle = 0;

                        gridView1.FocusedColumn = colcantidad;
                        gridView1.ShowEditor();
                    }
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsFactCotizacion.detalle_cotizacionRow)gridView.GetFocusedDataRow();

            try
            {
                switch (e.Column.FieldName)
                {
                    case "cantidad":

                        Impuesto isv = new Impuesto();
                        isv.RecuperarRegistro(1);

                        row.total = (row.cantidad * row.precio_original);
                        row.isv = (row.cantidad * row.precio_original) * Convert.ToDecimal(0.15);

                        break;

                    case "precio_original":

                        row.total = (row.cantidad * row.precio_original);
                        row.isv = (row.cantidad * row.precio_original) * Convert.ToDecimal(0.15);

                        break;

                    default:
                        break;
                }

                CalcularTotal();
            }
            catch (Exception x)
            {
                CajaDialogo.Error(x.Message);
            }

        }

        private void CalcularTotal()
        {
            decimal Subtotal = 0;
            decimal ISV = 0;

            foreach (dsFactCotizacion.detalle_cotizacionRow item in dsFactCotizacion1.detalle_cotizacion.Rows)
            {
                Subtotal += item.total;
                ISV += item.isv;

            }

            txtSubTotalBruto.Text = string.Format("{0:##,###,##0.##}", Subtotal);

            txtSubTotalNeto.Text = string.Format("{0:##,###,##0.##}", Subtotal - Convert.ToDecimal(txtDescuento.EditValue));

            txtISV.Text = string.Format("{0:##,###,##0.##}", ISV);

            txtTotal.Text = string.Format("{0:##,###,##0.##}", Convert.ToDecimal(txtSubTotalNeto.EditValue) + Convert.ToDecimal(txtISV.EditValue));
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtNumCoti.Clear();
            txtNombreCliente.Clear();
            txtRTN.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            ProIdCliente = 0;
            dsFactCotizacion1.detalle_cotizacion.Clear();

            txtSubTotalBruto.EditValue = 0.00;
            txtDescuento.EditValue = 0.00;
            txtSubTotalNeto.EditValue = 0.00;
            txtISV.EditValue = 0.00;
            txtTotal.EditValue = 0.00;
        }


        private void reposDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (IdEstadoOrdenCompra)
            {
                case 1://Habilitada
                    break;

                case 2://Cerrada
                    CajaDialogo.Error("No se pueden realizar modificaciones en una Cotizacion Cerrada!");
                    break;

                default:
                    break;
            }

            DialogResult r = CajaDialogo.Pregunta("Confirma que desea elminar este registro?");
            if (r != DialogResult.Yes)
            {
                return;
            }

            var grdvDetalle = (GridView)gridControl1.FocusedView;
            var row = (dsFactCotizacion.detalle_cotizacionRow)grdvDetalle.GetFocusedDataRow();


            if (row.id > 0 || string.IsNullOrEmpty(row.id.ToString()))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_cotizacion_delete_linea_detalle", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalle_oc", row.id);
                    cmd.ExecuteNonQuery();

                    grdvDetalle.DeleteRow(grdvDetalle.FocusedRowHandle);
                    dsFactCotizacion1.AcceptChanges();
                    CalcularTotal();

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

            }
            else
            {
                try
                {
                    grdvDetalle.DeleteRow(grdvDetalle.FocusedRowHandle);
                    dsFactCotizacion1.AcceptChanges();
                    CalcularTotal();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void cmdFacturar_Click(object sender, EventArgs e)
        {
            switch (IdEstadoOrdenCompra)
            {
                case 1: //Habilitado

                    break;

                case 2: //Cerrado

                    CajaDialogo.Error("No se puede Editar una Cotizacion Cerrada!");

                    break;
                default:
                    break;
            }

            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                CajaDialogo.Error("Debe seleccionar el Cliente!");
                return;
            }

            if (dtFechaRegistro.Value > dtFechaVencimiento.Value)
            {
                CajaDialogo.Error("La Fecha de Registro no puede ser mayor que la de Vencimiento!");
                return;
            }

            if (gridView1.DataRowCount == 0)
            {
                CajaDialogo.Error("Debe Seleccionar por lo Menos un Item!");
                return;
            }


            foreach (dsFactCotizacion.detalle_cotizacionRow item in dsFactCotizacion1.detalle_cotizacion)
            {
                if (string.IsNullOrEmpty(item.descripcion) || string.IsNullOrWhiteSpace(item.descripcion))
                {
                    CajaDialogo.Error("No puede dejar Vacia la descripcion!");
                    return;
                }

                if (item.cantidad <= 0)
                {
                    CajaDialogo.Error("La Cantidad no puede ser 0");
                    return;
                }

                if (item.total <= 0)
                {
                    CajaDialogo.Error("El Total no puede ser 0");
                    return;
                }

                if (item.precio_original <= 0)
                {
                    CajaDialogo.Error("El Precio Unitario no puede ser 0");
                    return;
                }
            }

            if (Convert.ToDecimal(txtTotal.EditValue) == 0)
            {
                CajaDialogo.Error("El Total de la Cotizacion no puede ser 0!");
                return;
            }

            switch (tipoOP)
            {
                case TipoOperacion.Insert:
                    bool Guardar = false;
                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_cotizacion_insert_headerV2]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cliente", txtNombreCliente.Text.Trim());
                       
                        if(string.IsNullOrEmpty(txtRTN.Text))
                            cmd.Parameters.AddWithValue("@rtn", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@rtn", txtRTN.Text);

                        if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                            cmd.Parameters.AddWithValue("@direccion", "N/D");
                        else
                            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);

                        if (string.IsNullOrWhiteSpace(txtContacto.Text))
                            cmd.Parameters.AddWithValue("@contacto", "N/D");
                        else
                            cmd.Parameters.AddWithValue("@contacto", txtContacto.Text);

                        if (string.IsNullOrWhiteSpace(txtEmail.Text))
                            cmd.Parameters.AddWithValue("@email", "N/D");
                        else
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                        if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                            cmd.Parameters.AddWithValue("@telefono", "N/D");
                        else
                            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@fecha_emision", dtFechaRegistro.Value);
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.Value);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_estado", 1);
                        cmd.Parameters.AddWithValue("@sub_total", dp.ValidateNumberDecimal( txtSubTotalNeto.EditValue));
                        cmd.Parameters.AddWithValue("@descuento", dp.ValidateNumberDecimal(txtDescuento.EditValue));
                        cmd.Parameters.AddWithValue("@isv", dp.ValidateNumberDecimal(txtISV.EditValue));
                        cmd.Parameters.AddWithValue("@total", dp.ValidateNumberDecimal(txtTotal.EditValue));
                        cmd.Parameters.AddWithValue("@punto_venta", PuntoVentaActual.ID);
                        cmd.Parameters.AddWithValue("@IdCliente", ProIdCliente);

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsFactCotizacion.detalle_cotizacionRow row in dsFactCotizacion1.detalle_cotizacion.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_cotizacion_insert_detalle";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h", id_header);
                            cmd.Parameters.AddWithValue("@codigo", row.codigo);
                            cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                            cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmd.Parameters.AddWithValue("@precio_original", row.precio_original);
                            cmd.Parameters.AddWithValue("@isv", row.isv);//Referencia de Solicitud de Compra
                            cmd.Parameters.AddWithValue("@fecha_creacion", dp.NowSetDateTime());
                            cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                            cmd.Parameters.AddWithValue("@punto_venta", PuntoVentaActual.ID);
                            cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@fecha_hora", dp.NowSetDateTime());
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;
                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Cotizacion Creada!");
                        LimpiarControles();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }


                    break;
                case TipoOperacion.Update:

                    SqlTransaction transactionUpdate = null;

                    SqlConnection connUpdate = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    bool GuardarUpdate = false;

                    try
                    {
                        connUpdate.Open();
                        transactionUpdate = connUpdate.BeginTransaction("Transaction Order");
                        SqlCommand cmdUpdate = connUpdate.CreateCommand();
                        cmdUpdate.CommandText = "[sp_cotizacion_update_header]";
                        cmdUpdate.Connection = connUpdate;
                        cmdUpdate.Transaction = transactionUpdate;
                        cmdUpdate.CommandType = CommandType.StoredProcedure;
                        cmdUpdate.Parameters.AddWithValue("@id_h", IdCotizacion);
                        cmdUpdate.Parameters.AddWithValue("@cliente", txtNombreCliente.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@rtn", txtRTN.Text);
                        cmdUpdate.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        if (string.IsNullOrEmpty(txtContacto.Text))
                            cmdUpdate.Parameters.AddWithValue("@contacto", "N/D");
                        else
                            cmdUpdate.Parameters.AddWithValue("@contacto", txtContacto.Text);

                        if (string.IsNullOrEmpty(txtEmail.Text))
                            cmdUpdate.Parameters.AddWithValue("@email", "N/D");
                        else
                            cmdUpdate.Parameters.AddWithValue("@email", txtEmail.Text); 
                        
                        if (string.IsNullOrEmpty(txtTelefono.Text))
                            cmdUpdate.Parameters.AddWithValue("@telefono", "N/D");
                        else
                            cmdUpdate.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                        cmdUpdate.Parameters.AddWithValue("@fecha_emision", dtFechaRegistro.Value);
                        cmdUpdate.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.Value);
                        cmdUpdate.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmdUpdate.Parameters.AddWithValue("@sub_total",Convert.ToDecimal(txtSubTotalBruto.EditValue));
                        cmdUpdate.Parameters.AddWithValue("@isv", Convert.ToDecimal(txtISV.EditValue));
                        cmdUpdate.Parameters.AddWithValue("@descuento", Convert.ToDecimal(txtDescuento.EditValue));
                        cmdUpdate.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.EditValue));
                        cmdUpdate.Parameters.AddWithValue("@IdCliente", ProIdCliente);
                        cmdUpdate.ExecuteNonQuery();

                        foreach (dsFactCotizacion.detalle_cotizacionRow row in dsFactCotizacion1.detalle_cotizacion.Rows)
                        {
                            cmdUpdate.Parameters.Clear();
                            cmdUpdate.CommandText = "[sp_cotizacion_update_detalle]";
                            cmdUpdate.Connection = connUpdate;
                            cmdUpdate.Transaction = transactionUpdate;
                            cmdUpdate.CommandType = CommandType.StoredProcedure;
                            cmdUpdate.Parameters.AddWithValue("@id_detalle", row.id);
                            cmdUpdate.Parameters.AddWithValue("@id_h", IdCotizacion);
                            cmdUpdate.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmdUpdate.Parameters.AddWithValue("@descripcion", row.descripcion);
                            cmdUpdate.Parameters.AddWithValue("@precio_original", row.precio_original);
                            cmdUpdate.Parameters.AddWithValue("@isv", row.isv);
                            cmdUpdate.Parameters.AddWithValue("@fecha_creacion", dp.Now());
                            cmdUpdate.Parameters.AddWithValue("@id_pt", row.id_pt);
                            cmdUpdate.Parameters.AddWithValue("@codigo", row.codigo);
                            //cmdUpdate.Parameters.AddWithValue("@idEstadoCompra", IdEstadoOrdenCompra);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        transactionUpdate.Commit();
                        GuardarUpdate = true;

                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                        GuardarUpdate = false;
                    }

                    if (GuardarUpdate)
                    {
                        CajaDialogo.Information("Cotizacion actualizada!");
                        LimpiarControles();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    break;
                default:
                    CajaDialogo.Error("No se pudo definir una Operacion de Tipo(INSERT-UPDATE)\nContacte su Proveedor de Sistemas");
                    break;
            }
        }

        private void dtFechaRegistro_ValueChanged(object sender, EventArgs e)
        {
            //switch (tipoOP)
            //{
            //    case TipoOperacion.Insert:
            //        dtFechaVencimiento.Value = dp.Now().AddDays(15);

            //        break;
            //    case TipoOperacion.Update:
            //        break;
            //    default:
            //        break;
            //}
            
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}