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

                    break;
                case TipoOperacion.Update:
                    txtNumCoti.Visible = true;

                    IdCotizacion = idH;
                    Cotizacion coti = new Cotizacion();
                    coti.RecuperarRegistro(IdCotizacion);
                    txtNombreCliente.Text = coti.Cliente;
                    txtRTN.Text = coti.RTN;
                    txtDireccion.Text = coti.Direccion;
                    txtEmail.Text = coti.Email;
                    txtNumCoti.Text = coti.NumCotizacion;
                    IdEstadoOrdenCompra = coti.IdEstado;


                    txtTotal.EditValue = coti.Total;
                    txtSubTotalNeto.EditValue = coti.SubTotal;
                    txtDescuento.EditValue = coti.Descuento;
                    txtSubTotalBruto.EditValue = coti.SubTotal + coti.Descuento;


                    CargarDetalle();

                    break;
                default:
                    break;
            }

        }

        private void CargarDetalle()
        {
            try
            {
                
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

                    bool AgregarNuevo = true;
                    foreach (dsFactCotizacion.detalle_cotizacionRow rowF in dsFactCotizacion1.detalle_cotizacion)
                    {
                        if (rowF.id_pt == frm.ItemSeleccionado.id)
                        {
                            //Sumar cantidad nada mas
                            rowF.cantidad = rowF.cantidad + 1;
                            rowF.precio_original = rowF.precio_original + rowF.precio_original;
                            AgregarNuevo = false;
                        }
                        //valor_total += (rowF.total_linea + rowF.isv1);
                        valor_total += rowF.total;
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));
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

        private void txtDescuento_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
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
                CajaDialogo.Error("Debe seleccionar/escribir el Cliente que aprobará la orden de compra!");
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
                        cmd.CommandText = "sp_cotizacion_insert_header";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cliente", txtNombreCliente.Text.Trim());
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
                        cmd.Parameters.AddWithValue("@sub_total", txtSubTotalNeto.EditValue);
                        cmd.Parameters.AddWithValue("@descuento", txtDescuento.EditValue);
                        cmd.Parameters.AddWithValue("@isv", txtISV.EditValue);
                        cmd.Parameters.AddWithValue("@total", txtTotal.EditValue);
                        cmd.Parameters.AddWithValue("@punto_venta", PuntoVentaActual.ID);

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
                            cmd.Parameters.AddWithValue("@fecha_creacion", dp.Now());
                            cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
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
                    }


                    break;
                case TipoOperacion.Update:

                    //SqlTransaction transactionUpdate = null;

                    //SqlConnection connUpdate = new SqlConnection(dp.ConnectionStringLOSA);
                    //bool GuardarUpdate = false;

                    //try
                    //{
                    //    connUpdate.Open();
                    //    transactionUpdate = connUpdate.BeginTransaction("Transaction Order");
                    //    SqlCommand cmdUpdate = connUpdate.CreateCommand();
                    //    cmdUpdate.CommandText = "[sp_CM_update_ordencompra_hV2]";
                    //    cmdUpdate.Connection = connUpdate;
                    //    cmdUpdate.Transaction = transactionUpdate;
                    //    cmdUpdate.CommandType = CommandType.StoredProcedure;
                    //    cmdUpdate.Parameters.AddWithValue("@idOrdenCompraH", IdOrdenCompraActual);
                    //    cmdUpdate.Parameters.AddWithValue("@CardCode", txtCodProv.Text.Trim());
                    //    cmdUpdate.Parameters.AddWithValue("@CardName", txtProveedor.Text);
                    //    cmdUpdate.Parameters.AddWithValue("@Address", direccion);
                    //    if (string.IsNullOrEmpty(txtNumAtCard.Text))
                    //        cmdUpdate.Parameters.AddWithValue("@NumAtCard", "N/D");
                    //    else
                    //        cmdUpdate.Parameters.AddWithValue("@NumAtCard", txtNumAtCard.Text);

                    //    cmdUpdate.Parameters.AddWithValue("@DocDate", dtFechaRegistro.Value);
                    //    cmdUpdate.Parameters.AddWithValue("@DocDueDate", dtFechaContabilizacion.DateTime.AddDays(15));
                    //    cmdUpdate.Parameters.AddWithValue("@TaxDate", dtFechaContabilizacion.EditValue);
                    //    cmdUpdate.Parameters.AddWithValue("@U_TipoOrden", grdTipoOrden.EditValue);
                    //    cmdUpdate.Parameters.AddWithValue("@U_AquaExoneracion", txtExoneracion.Text);
                    //    cmdUpdate.Parameters.AddWithValue("@U_FechaExoneracion", dtFechaRegistro.Value);
                    //    cmdUpdate.Parameters.AddWithValue("@Comments", txtComentarios.Text);
                    //    cmdUpdate.Parameters.AddWithValue("@ISV", Convert.ToDecimal(txtImpuesto.EditValue));
                    //    cmdUpdate.Parameters.AddWithValue("@DocTotal", Convert.ToDecimal(txtTotal.EditValue));
                    //    cmdUpdate.Parameters.AddWithValue("@CurSource", CurSource);//C=BP Currency, L=Local Currency, S=System Currency
                    //    cmdUpdate.Parameters.AddWithValue("@DocCur", txtMoneda.Text.Trim());
                    //    cmdUpdate.Parameters.AddWithValue("@DocRate", TasaCambio);
                    //    if (IdSolicitud == 0)
                    //        cmdUpdate.Parameters.AddWithValue("@DocNumSolicitud", DBNull.Value);
                    //    else
                    //        cmdUpdate.Parameters.AddWithValue("@DocNumSolicitud", IdSolicitud);
                    //    cmdUpdate.Parameters.AddWithValue("@ContactCode", ContactCode);
                    //    cmdUpdate.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                    //    cmdUpdate.Parameters.AddWithValue("@id_ruta", glRutaAprobacionOC.EditValue);
                    //    if (string.IsNullOrEmpty(comboBoxIntercom.Text))
                    //        cmdUpdate.Parameters.AddWithValue("@U_incoterm", DBNull.Value);
                    //    else
                    //        cmdUpdate.Parameters.AddWithValue("@U_incoterm", comboBoxIntercom.Text.Trim());
                    //    cmdUpdate.Parameters.AddWithValue("@idEstadoCompra", IdEstadoOrdenCompra);

                    //    cmdUpdate.ExecuteNonQuery();

                    //    foreach (dsCompras.oc_detalle_exoneradaRow row in dsCompras1.oc_detalle_exonerada.Rows)
                    //    {
                    //        cmdUpdate.Parameters.Clear();
                    //        cmdUpdate.CommandText = "sp_compras_ordenes_detalle_update_insert";
                    //        cmdUpdate.Connection = connUpdate;
                    //        cmdUpdate.Transaction = transactionUpdate;
                    //        cmdUpdate.CommandType = CommandType.StoredProcedure;
                    //        cmdUpdate.Parameters.AddWithValue("@id_detalle", row.id_d_orden);
                    //        cmdUpdate.Parameters.AddWithValue("@id_orden_h", IdOrdenCompraActual);
                    //        cmdUpdate.Parameters.AddWithValue("@ItemCode", row.itemcode);
                    //        cmdUpdate.Parameters.AddWithValue("@Description", row.descripcion_articulo);
                    //        if (string.IsNullOrWhiteSpace(row.capitulo))
                    //            cmdUpdate.Parameters.AddWithValue("@Capitulo_Codigo", DBNull.Value);
                    //        else
                    //            cmdUpdate.Parameters.AddWithValue("@Capitulo_Codigo", row.capitulo);
                    //        if (string.IsNullOrWhiteSpace(row.partida_arancelaria))
                    //            cmdUpdate.Parameters.AddWithValue("@Partida_Arancelaria", DBNull.Value);
                    //        else
                    //            cmdUpdate.Parameters.AddWithValue("@Partida_Arancelaria", row.partida_arancelaria);
                    //        cmdUpdate.Parameters.AddWithValue("@Quantity", row.cantidad);
                    //        cmdUpdate.Parameters.AddWithValue("@Unite_Price", row.precio_por_unidad);
                    //        cmdUpdate.Parameters.AddWithValue("@Currency", txtMoneda.Text.Trim());
                    //        cmdUpdate.Parameters.AddWithValue("@DiscPrcnt", 0);
                    //        cmdUpdate.Parameters.AddWithValue("@TaxCode", row.indicador_impuesto);
                    //        cmdUpdate.Parameters.AddWithValue("@WhsCode", row.bodega.Trim());
                    //        cmdUpdate.Parameters.AddWithValue("@isv", row.isv);
                    //        cmdUpdate.Parameters.AddWithValue("@base_ref", row.referencia_base);
                    //        cmdUpdate.Parameters.AddWithValue("@num_linea_solicitud_d", row.num_linea_solicitud_d);
                    //        cmdUpdate.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                    //        //cmdUpdate.Parameters.AddWithValue("@idEstadoCompra", IdEstadoOrdenCompra);
                    //        cmdUpdate.ExecuteNonQuery();
                    //    }

                    //    string file_name;
                    //    //Seccion para agregar los archivos
                    //    foreach (var row in dsCompras1.ordenes_compras_archivos)
                    //    {
                    //        string ext = Path.GetExtension(row.file_name);
                    //        file_name = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
                    //        //Luego de subir el archivo al FTP, que se guarde el registro
                    //        if (Upload(row.path, file_name, row.id))
                    //        {
                    //            cmdUpdate.Parameters.Clear();
                    //            cmdUpdate.CommandText = "usp_UploadFileFromOrdenesCompras";
                    //            cmdUpdate.Connection = connUpdate;
                    //            cmdUpdate.Transaction = transactionUpdate;
                    //            cmdUpdate.CommandType = CommandType.StoredProcedure;
                    //            cmdUpdate.Parameters.AddWithValue("@id_orden_compra_h", IdOrdenCompraActual);
                    //            cmdUpdate.Parameters.AddWithValue("@path", dp.FTP_Tickets_LOSA_Compras + file_name);
                    //            cmdUpdate.Parameters.AddWithValue("@file_name", row.file_name);
                    //            cmdUpdate.Parameters.AddWithValue("@id_user", UsuarioLogueado.Id);
                    //            cmdUpdate.Parameters.AddWithValue("@id", row.id);
                    //            cmdUpdate.ExecuteNonQuery();
                    //        }

                    //    }

                    //    transactionUpdate.Commit();
                    //    GuardarUpdate = true;

                    //}
                    //catch (Exception ec)
                    //{
                    //    CajaDialogo.Error(ec.Message);
                    //    GuardarUpdate = false;
                    //}

                    //if (GuardarUpdate)
                    //{
                    //    CajaDialogo.Information("Orden de Compra Modificada!");
                    //    LimpiarControles();
                    //}

                    break;
                default:
                    CajaDialogo.Error("No se pudo definir una Operacion de Tipo(INSERT-UPDATE)\nContacte al Dpto. IT");
                    break;
            }
        }

        private void dtFechaRegistro_ValueChanged(object sender, EventArgs e)
        {
            //dtFechaVencimiento.Value = dp.Now().AddDays(15);
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}