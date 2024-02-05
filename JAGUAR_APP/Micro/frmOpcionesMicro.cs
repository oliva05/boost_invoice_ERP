using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Reportes;
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

namespace JAGUAR_APP.Micro
{
    public partial class frmOpcionesMicro : DevExpress.XtraEditors.XtraForm
    {
        //UserLogin UsuarioLogeado;

        public frmOpcionesMicro()
        {
            InitializeComponent();
            LoadLotes();
            DataOperations dp = new DataOperations();
            dtFechaDesde.EditValue = dp.NowSetDateTime().AddDays(-1);
            dtFechaHasta.EditValue = dp.NowSetDateTime();
            LoadHeader();
        }

        private void LoadLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_micro_ingredientes_V3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMicro1.informacionPRD.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.informacionPRD);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnNavegacionLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsMicro.lotesRow)gridView.GetFocusedDataRow();

            //rpt_cartillaMicro report = new rpt_cartillaMicro(row.lote_materia_prima);
            //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //ReportPrintTool printReport = new ReportPrintTool(report);
            //printReport.ShowPreview();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoadHeader();
        }

        private void LoadHeader()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_sacos_generados_micros", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHasta.EditValue);
                dsMicro1.sacosh.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.sacosh);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            //Row
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsMicro.sacoshRow)gridView.GetFocusedDataRow();

            LoadDetalle(row.id);
        }

        private void LoadDetalle(int pIdh)
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_sacos_micros_rm_V2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", pIdh);
                dsMicro1.sacos_detail.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.sacos_detail);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleSearch(int pCode)
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_sacos_micros_rm_search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idh", pIdh);
                cmd.Parameters.AddWithValue("@idcode", pCode);
                dsMicro1.sacosd1.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.sacosd1);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void spinCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadDetalleSearch(Convert.ToInt32(spinCodigo.EditValue));
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            LoadDetalleSearch(Convert.ToInt32(spinCodigo.EditValue));
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}