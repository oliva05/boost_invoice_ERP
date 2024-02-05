using ACS.Classes;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Facturacion.Notas;
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
using static JAGUAR_APP.Clases.Conf_TablesID;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmNotaCRUD : DevExpress.XtraEditors.XtraForm
    {
        NumeracionFiscal NumDocumentoFiscal = new NumeracionFiscal();
        PDV punto_venta = new PDV();
        Cliente cliente = new Cliente();

        int tipoNotaId = 0;
        
        public enum SourceSolicitud
        {
            FacturaEmitida=1,
            AutorizacionDirecta=2,
            FromCRUD=3
        }

        public enum TipoNota
        {
            Credito=1,
            Debito=2
        }

        public enum EstadoSolicitud
        {
            Pendiente = 1,
            Aprobada = 2,
            Rechazada = 3
        }

        SourceSolicitud solicitudActual;
        long factura_id;
        //Factura factura1 = new Factura();

        Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
        long solicitud_id = 0;
        UserLogin userLog = new UserLogin();
        public frmNotaCRUD(SourceSolicitud request,long p_solicitud_id,UserLogin pUser)
        {
            InitializeComponent();
            solicitudActual = request;
            //factura_id = factura_id_p;
            solicitud_id = p_solicitud_id;
            userLog = pUser;
        }

        public frmNotaCRUD(SourceSolicitud request, UserLogin pUser, int PuntVentaId, int ptipoNotaId, Factura_SolicitudAutorizacion pSolicitud)
        {
            InitializeComponent();
            solicitudActual = request;
            userLog = pUser;
            punto_venta.RecuperaRegistro(PuntVentaId);
            tipoNotaId = ptipoNotaId;
            solicitud = pSolicitud;
            cliente.RecuperarRegistro(pSolicitud.ClienteId);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {

            Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();

            try
            {
                

                if (SourceSolicitud.AutorizacionDirecta==solicitudActual || SourceSolicitud.FromCRUD == solicitudActual)
                {
                    this.Close();
                }
                else
                {


                    DialogResult res = MessageBox.Show("Desea Rechazar la solicitud?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        if (solicitud.RechazarSolicitud_NotaCredito_NotaDebito(solicitud_id, (int)EstadoSolicitud.Rechazada, userLog.Id))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    if (res == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                CajaDialogo.Error(exc.Message);
            }
            
        }

        SqlTransaction transaccion;

        [Obsolete]
        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id_numeracion = NumDocumentoFiscal.ID;
                var correlativoSiguiente = NumDocumentoFiscal.Correlative;
                string doc_num="";
                //decimal Monto = Convert.ToDecimal( coltotal_line.SummaryItem.SummaryValue);
                total = 0;

               

                bool encontrar_seleccionados = false;

                foreach (var item in dsFacturasGestion.NotaD)
                {
                    if (item.seleccion == true)
                    {
                        encontrar_seleccionados = true;
                    }
                }


                if (encontrar_seleccionados == false)
                {
                    CajaDialogo.Error("Debe seleccionar las facturas a aplicarle la nota de crédito o débito");
                    return;
                }

                foreach (var nota in dsFacturasGestion.NotaD)
                {
                    if (nota.seleccion == true)
                    {
                        total = total + nota.total_line;
                    }
                }

                if (NumDocumentoFiscal.RecuperarRegistro(NumDocumentoFiscal.ID))
                {
                    string sCorrelativo = correlativoSiguiente.ToString();

                    //Rellenar ceros a la izquierda
                    while (sCorrelativo.Length < 8)
                    {
                        sCorrelativo = "0" + sCorrelativo;
                    }

                    doc_num = NumDocumentoFiscal.Leyenda + sCorrelativo;
                }

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                cnx.Open();
                transaccion = cnx.BeginTransaction();

                SqlCommand cmd = new SqlCommand("dbo.uspInsertNotaH", cnx);
                cmd.Transaction = transaccion;
                cmd.CommandType = CommandType.StoredProcedure;

                if (SourceSolicitud.FromCRUD==solicitudActual)
                {
                    cmd.Parameters.Add("@credito", Convert.ToInt32(tsNotaCD.EditValue) == (int)TipoNota.Credito ? total : 0);
                    cmd.Parameters.Add("@debito", Convert.ToInt32(tsNotaCD.EditValue) == (int)TipoNota.Debito ? total : 0);
                    cmd.Parameters.Add("@id_punto_venta",punto_venta.ID);
                    cmd.Parameters.Add("@id_tipo_nota", Convert.ToInt32(tsNotaCD.EditValue));
                    cmd.Parameters.Add("@solicitud_id", -1);
                    cmd.Parameters.Add("@id_cliente", cliente.Id);
                }
                else
                {
                    cmd.Parameters.Add("@credito", solicitud.TipoNotaId == (int)TipoNota.Credito ? total : 0);
                    cmd.Parameters.Add("@debito", solicitud.TipoNotaId == (int)TipoNota.Debito ? total : 0);
                    cmd.Parameters.Add("@id_punto_venta", solicitud.PuntoDeVenta_Id);
                    cmd.Parameters.Add("@id_tipo_nota", solicitud.TipoNotaId);
                    cmd.Parameters.Add("@solicitud_id", solicitud_id);
                    cmd.Parameters.Add("@id_cliente", solicitud.ClienteId);
                }

                cmd.Parameters.Add("@created_date", DateTime.Now);
                cmd.Parameters.Add("@cai", txtCAI.Text);
                    
                cmd.Parameters.Add("@num_documento", doc_num);
                cmd.Parameters.Add("@rtn", txtClienteRTN.Text);
                cmd.Parameters.Add("@fecha_documento", deFecha.EditValue);
                cmd.Parameters.Add("@id_doc_fiscal", NumDocumentoFiscal.ID);
                //cmd.Parameters.Add("@factura_id",factura1.Id);
                //cmd.Parameters.Add("@due_date",);
                cmd.Parameters.Add("@concepto", txtConcepto.Text);
                long id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                //Detalle

                foreach (var item in dsFacturasGestion.NotaD)
                {
                    if (item.seleccion == true)
                    {

                        SqlCommand cmd2 = new SqlCommand("dbo.uspInsertNotaD_v2", cnx);
                        cmd2.Transaction = transaccion;
                        cmd2.CommandType = CommandType.StoredProcedure;

                        cmd2.Parameters.Add("@id_nota", id_inserted);
                        cmd2.Parameters.Add("@id_factura", item.id_factura);
                        cmd2.Parameters.Add("@cuenta", "");
                        //cmd2.Parameters.Add("@price",item.price);
                        cmd2.Parameters.Add("@total_line", item.total_line);
                        cmd2.Parameters.Add("@descripcion", item.descripcion);
                        cmd2.Parameters.Add("@num_doc", item.num_doc);
                        cmd2.Parameters.Add("@id_pt", item.id_pt);
                        cmd2.Parameters.Add("@cantidad", item.cantidad);
                        cmd2.Parameters.Add("@precio", item.precio);
                        cmd2.Parameters.Add("@factura_d_id", item.id_factura_d);

                        cmd2.ExecuteNonQuery();
                    }
                }


                transaccion.Commit();

                CajaDialogo.Information("Datos Guardados");
                cnx.Close();
                this.DialogResult = DialogResult.OK;


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
            }
        }

        private void frmNotaCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                deFecha.EditValue = DateTime.Now;
                switch (solicitudActual)
                {
                    case SourceSolicitud.FacturaEmitida:
                        

                        DataOperations dp = new DataOperations();
                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        solicitud.RecuperaRegistro(solicitud_id);
                        punto_venta.RecuperaRegistro(solicitud.PuntoDeVenta_Id);
                
                        txtCliente.Text = solicitud.Cliente;
                        txtClienteRTN.Text = solicitud.Cliente_RTN;
                        deFecha.EditValue = DateTime.Now;
                        txtPDV.Text = punto_venta.NombreLegal;
                        txtRTN.Text = punto_venta.RTN;
                        txtConcepto.Text = solicitud.Justificacion;

                        //Cargar las lineas de la facturas para crear la nota de credito o debito
                        SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetLineasToCreate_NC_ND", cnx);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@id_autorizacion_h", solicitud_id);

                        dsFacturasGestion.NotaD.Clear();
                        da.Fill(dsFacturasGestion.NotaD);

                        NumDocumentoFiscal = new NumeracionFiscal();

                        

                        if (solicitud.TipoNotaId == (int)TipoNota.Credito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las "+NumDocumentoFiscal.TipoDoc+" para este punto de venta se ha vencido.");
                                    this.Close();
                                }

                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Crédito";
                            }

                        }

                        if (solicitud.TipoNotaId == (int)TipoNota.Debito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + "para este punto de venta se ha vencido.");
                                    return;
                                }
                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Débito";
                            }
                        }

                        break;
                    case SourceSolicitud.AutorizacionDirecta:
                        //punto_venta.RecuperaRegistro(solicitud.PuntoDeVenta_Id);
    
                        txtPDV.Text = punto_venta.NombreLegal;
                        txtRTN.Text = punto_venta.RTN;
                        txtCliente.Text = solicitud.Cliente;
                        txtClienteRTN.Text = solicitud.Cliente_RTN;
                        txtConcepto.ReadOnly = false;
                        txtConcepto.Text = "Nota de Crédito/Débito autorizada de forma directa";

                        if (tipoNotaId == (int)TipoNota.Credito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(punto_venta.ID, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + " para este punto de venta se ha vencido.");
                                    this.Close();
                                }

                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Crédito";
                            }

                        }

                        if (tipoNotaId == (int)TipoNota.Debito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(punto_venta.ID, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + "para este punto de venta se ha vencido.");
                                    return;
                                }
                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Débito";
                            }
                        }
                        FacturaDetalle factura_detalle = new FacturaDetalle();

                        foreach (var item in solicitud.Facturas_seleccionadas)
                        {
                            factura_detalle = new FacturaDetalle();

                            if (factura_detalle.RecuperaDetallFactura(item.FacturaId))
                            {

                                foreach (var detalle in factura_detalle.factura_detalle)
                                {

                                dsFacturasGestion.NotaD.Rows.Add(0,item.FacturaId, "", detalle.TotalLinea, item.NumeroFactura,detalle.Descripcion,detalle.Cantidad,detalle.ProductoTerminadoId, detalle.Precio,false,detalle.FacturaDetalleId);
                                    
                                }
                            }
                        }
                        break;

                    case SourceSolicitud.FromCRUD:
                        cmdSearchCliente.Visible = true;
                        cmdSearchPDV.Visible = true;
                        cmdSearchFacturas.Visible = true;
                        txtConcepto.ReadOnly = false;
                        tsNotaCD.Visible = true;
                        

                        break;

                }

                

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            try
            {
                NumDocumentoFiscal = new NumeracionFiscal();

                if (solicitud.TipoNotaId==(int)TipoNota.Credito)
                {

                    if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                        txtCAI.Text = NumDocumentoFiscal.CAI;
                    lblNota.Text = "Nota de Crédito";
                }

                if (solicitud.TipoNotaId == (int)TipoNota.Debito)
                {
                    if(NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                        txtCAI.Text = NumDocumentoFiscal.CAI;
                    lblNota.Text = "Nota de Débito";
                }




            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        Decimal total = 0;
        private void grd_data_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                total = 0;

                if (e.Column.FieldName=="cantidad")
                {
                  decimal cantidad= Convert.ToDecimal(    grd_data.GetRowCellValue(e.RowHandle,grd_data.Columns[6]));
                  decimal precio= Convert.ToDecimal(grd_data.GetRowCellValue(e.RowHandle,grd_data.Columns[8]));

                    var row = (dsFacturasGestion.NotaDRow)grd_data.GetDataRow(e.RowHandle);

                    row.total_line = cantidad * precio;

                    //grd_data.SetRowCellValue(e.RowHandle, grd_data.Columns[3], (cantidad * precio));
                }

                foreach (var item in dsFacturasGestion.NotaD)
                {
                    if (item.seleccion==true)
                    {
                        total = total + item.total_line;
                    }
                }

                lblTotal.Text = "Total: L "+ total.ToString("N2");
            }
            catch (Exception exc)
            {
                CajaDialogo.Error(exc.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSearchPDV_Click(object sender, EventArgs e)
        {
            frmNotasSearchPDV frm = new frmNotasSearchPDV();



            if (frm.ShowDialog()== DialogResult.OK)
            {
                txtPDV.Text = frm.pdv;

                punto_venta.RecuperaRegistro(frm.id_pdv);

                txtPDV.Text = punto_venta.NombreLegal;
                txtRTN.Text = punto_venta.RTN;

                if ( (int)TipoNota.Debito== Convert.ToInt32( tsNotaCD.EditValue))
                {
                    txtCAI.Text = punto_venta.CAI_NotaCredido;

                }
                else
                {
                    txtCAI.Text = punto_venta.CAI_NotaDebito;

                }

                if (Convert.ToInt32(tsNotaCD.EditValue) == (int)TipoNota.Credito)
                {
                    if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(punto_venta.ID, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                    {
                        if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                        {
                            CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + " para este punto de venta se ha vencido.");
                            this.Close();
                        }

                        txtCAI.Text = NumDocumentoFiscal.CAI;
                        lblNota.Text = "Nota de Crédito";
                    }

                }

                if (Convert.ToInt32(tsNotaCD.EditValue) == (int)TipoNota.Debito)
                {
                    if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(punto_venta.ID, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                    {
                        if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                        {
                            CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + "para este punto de venta se ha vencido.");
                            return;
                        }
                        txtCAI.Text = NumDocumentoFiscal.CAI;
                        lblNota.Text = "Nota de Débito";
                    }
                }

            }
        }

        private void tsNotaCD_Toggled(object sender, EventArgs e)
        {

            if (punto_venta.ID!=0)
            {

            if ((int)TipoNota.Debito == Convert.ToInt32(tsNotaCD.EditValue))
            {
                txtCAI.Text = punto_venta.CAI_NotaCredido;

            }
            else
            {
                txtCAI.Text = punto_venta.CAI_NotaDebito;

            }
            }
        }

        private void cmdSearchCliente_Click(object sender, EventArgs e)
        {
            frmNotasSearchClientes frm = new frmNotasSearchClientes();
            cliente = new Cliente();
            if (frm.ShowDialog()== DialogResult.OK)
            {
                if (cliente.RecuperarRegistro(frm.id_cliente))
                {
                    txtCliente.Text = string.IsNullOrEmpty(cliente.NombreCorto) ? cliente.Nombre : cliente.NombreCorto ;
                }
            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmNotasSearchFacturas frm = new frmNotasSearchFacturas(punto_venta.ID,cliente.Id);

            if (punto_venta.ID==0)
            {
                CajaDialogo.Error("DEBE DE SELECCIONAR UN PUNTO DE VENTA");
                return;
            }

            if (cliente.Id == 0)
            {
                CajaDialogo.Error("DEBE DE SELECCIONAR UN CLIENTE");
                return;
            }

            if (frm.ShowDialog() == DialogResult.OK)
            {

                foreach (var item in frm.facturasSeleccionadas)
                {
                    dsFacturasGestion.NotaD.Rows.Add(0,item.FacturaId,"",item.TotalLinea,item.NumeroDocumento,item.Descripcion,item.Cantidad,item.ProductoTerminadoId,item.Precio,false,0);
                }
            }
        }

        private void grd_data_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.IsTotalSummary)// && (e.Item as GridSummaryItem).FieldName == "Length")
            {
                GridSummaryItem item = e.Item as GridSummaryItem;

                //if (item.FieldName == "Length")
                {
                    switch (e.SummaryProcess)
                    {
                        case CustomSummaryProcess.Start:
                            //sum = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            bool shouldSum = (bool)view.GetRowCellValue(e.RowHandle, "seleccionar");
                            if (shouldSum)
                            {
                                //sum += (double)e.FieldValue;
                            }
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = 0;
                            break;
                    }
                }
            }
        }
    }
}