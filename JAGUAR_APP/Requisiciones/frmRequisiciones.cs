using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_APP;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Reportes;
using JAGUAR_APP.Requisiciones;
using JAGUAR_APP.Requisiciones.Reportes;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmRequisiciones : Form
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public frmRequisiciones(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            dp = new DataOperations();
            DateTime FechaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime FechaFinal = FechaInicial.AddHours(23);
            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal; 

            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_requisiciones_pendientes_h_v3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_solo_enable_true", tggView.IsOn);
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dSReportes1.requisiciones_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dSReportes1.requisiciones_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        //private void LoadDatos_Finalizadas()
        //{
        //    try
        //    {

        //        SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
        //        con.Open();

        //        SqlCommand cmd = new SqlCommand("sp_get_requisiciones_pendientes_h_show_finalizadas", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
        //        dSReportes1.requisiciones_h.Clear();
        //        SqlDataAdapter adat = new SqlDataAdapter(cmd);
        //        adat.Fill(dSReportes1.requisiciones_h);
        //        con.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}

        private void btnVerD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dSReportes.requisiciones_hRow)gridView.GetFocusedDataRow();

            frmRequisicionesDetalle frm = new frmRequisicionesDetalle(UsuarioLogeado, row.id, row.Lote, row.id_estado,row.Asignado_a, row.ItemNamePT, row.cant_arrobas, row.DocEntry);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            //var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dSReportes.requisiciones_hRow)gvRequisicion.GetFocusedDataRow();

            //Requisiciones.Reportes.lblNumeroReq report = new Requisiciones.Reportes.lblNumeroReq(row.id, row.Lote);
            //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //report.ShowPrintMarginsWarning = false;
            ////report.ShowPreview();
            //report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
            //report.Print();

            xrptRequisicionProduccion report1 = new xrptRequisicionProduccion(row.id);
            xrptRequisicionProduccionAdmin report2 = new xrptRequisicionProduccionAdmin(row.id);
            report1.DisplayName = "Requisición de MP #" + row.DocEntry.ToString();

            if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
            {
                using (ReportPrintTool printTool = new ReportPrintTool(report2))
                {
                    // Send the report to the default printer.
                    printTool.ShowPreviewDialog();
                }
            }
            else
            {
                using (ReportPrintTool printTool = new ReportPrintTool(report1))
                {
                    // Send the report to the default printer.
                    printTool.ShowPreviewDialog();
                }
            }

        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            #region codigo ALOSY
            //try
            //{
            //    var gridView = (GridView)grRequisicoinesMP.FocusedView;
            //    var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();

            //    switch (row.id_estado)
            //    {
            //        case 1://Habilitada
            //        case 2://Seleccion de Lotes
            //        case 3://En Proceso
            //            break;
            //        case 4://Cerrada
            //            Utileria.frmMensajeCalidad frm1 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
            //                                         "Esta requisición ya se encuentra en estado: Cerrada!");
            //            if (frm1.ShowDialog() == DialogResult.Cancel)
            //            {
            //                return;
            //            }
            //            break;
            //        case 5://Nueva
            //            Utileria.frmMensajeCalidad frm2 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
            //                                         "No se puede finalizar una requisición en estado: Nuevo!");
            //            if (frm2.ShowDialog() == DialogResult.Cancel)
            //            {
            //                return;
            //            }
            //            break;
            //        default:
            //            break;
            //    }


            //    #region codigo anterior
            //    //if (row.finalizado)
            //    //{
            //    //    if (MessageBox.Show("Desea Abrir de nuevo la requisa en cuestion?","Pregunta" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question ) == DialogResult.OK)
            //    //    {
            //    //        string query = "sp_reactivar_requisa";
            //    //        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            //    //        cn.Open();
            //    //        SqlCommand cmd = new SqlCommand(query, cn);
            //    //        cmd.CommandType = CommandType.StoredProcedure;
            //    //        cmd.Parameters.AddWithValue("@req", row.id);
            //    //        cmd.ExecuteNonQuery();
            //    //        cn.Close();


            //    //        if (tggView.IsOn)
            //    //        {
            //    //            LoadDatos();
            //    //        }
            //    //        else
            //    //        {
            //    //            LoadDatos_Finalizadas();
            //    //        }
            //    //    }

            //    //}
            //    //else
            //    //{
            //    //    if (MessageBox.Show("Desea finalizar la requisa? No podra seguir enviando materia prima despues de esta accion", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //    //    {

            //    //        string query = "sp_finalizar_requisa_v2";
            //    //        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            //    //        cn.Open();
            //    //        SqlCommand cmd = new SqlCommand(query, cn);
            //    //        cmd.CommandType = CommandType.StoredProcedure;
            //    //        cmd.Parameters.AddWithValue("@req", row.id);
            //    //        cmd.Parameters.AddWithValue("@user_end", UsuarioLogeado.Id);
            //    //        cmd.ExecuteNonQuery();
            //    //        cn.Close();


            //    //        if (tggView.IsOn)
            //    //        {
            //    //            LoadDatos();
            //    //        }
            //    //        else
            //    //        {
            //    //            LoadDatos_Finalizadas();
            //    //        }
            //    //    }
            //    //}
            //    #endregion

            //    RequisicionesValidaciones val1 = new RequisicionesValidaciones();
            //    if (val1.PermitirCerrarRequisicionMP(row.id))
            //    {
            //        if (CajaDialogo.Pregunta("Confirme si desea Cerrar la Requisición?") == DialogResult.Yes)
            //        {
            //            string query = "sp_finalizar_requisa_v2";
            //            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            //            cn.Open();
            //            SqlCommand cmd = new SqlCommand(query, cn);
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            cmd.Parameters.AddWithValue("@req", row.id);
            //            cmd.Parameters.AddWithValue("@user_end", UsuarioLogeado.Id);
            //            cmd.ExecuteNonQuery();
            //            cn.Close();

            //            if (tggView.IsOn)
            //                LoadDatos();
            //            else
            //                LoadDatos_Finalizadas();
            //        }
            //    }
            //    else
            //    {
            //        //Hay materia prima pendiente de entregar.
            //        //No se permite cerrar una requisicion si hay materia prima pendiente de entregar
            //        Utileria.frmMensajeCalidad frm2 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
            //                                         "No se puede finalizar esta requisición, no se han entregado completamente!\n" +
            //                                         "Ejemplo: ItemName: " + val1.NameMP+
            //                                         "\nCantidad Pendiente en Kg: " + string.Format("{0:###,##0.00}", val1.CantidadPendiente));
            //        if (frm2.ShowDialog() == DialogResult.Cancel)
            //        {
            //            return;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    CajaDialogo.Error(ex.Message);
            //}
            #endregion

        }

        private void tggView_Toggled(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void btnend_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Finalizar la requisicion.
            var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dSReportes.requisiciones_hRow)gridView.GetFocusedDataRow();
            decimal valor = GetEntregaParcialRequisicion(row.id);

            if(valor == 0)
            {
                CajaDialogo.Error("No se ha entregado ningun material de esta requisicion, no se puede finalizar!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de finalizar esta requisición?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_update_estado_requisicion_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisicion", row.id);
                cmd.Parameters.AddWithValue("@id_estado", 3);//Estamos mandando a finalizar
                valor = dp.ValidateNumberDecimal(cmd.ExecuteScalar());

                row.id_estado = 3;
                EstadoRequisicionMP estado1 = new EstadoRequisicionMP();
                if (estado1.RecuperarRegistro(3))
                {
                    row.estado = estado1.Descripcion;
                }

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        decimal GetEntregaParcialRequisicion(Int64 pIdRequisicion)
        {
            decimal valor = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_cant_mp_entregada_por_requisicion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisicion", pIdRequisicion);
                valor = dp.ValidateNumberDecimal(cmd.ExecuteScalar());

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }
    }
}
