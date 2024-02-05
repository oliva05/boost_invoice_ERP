using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
//using JAGUAR_APP.RecepcionMP;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System.Threading;
namespace JAGUAR_APP.Reportes
{
    public partial class frmprint__tarimas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmprint__tarimas()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string Query = @"sp_load_data_tarimas_to_print";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                SqlCommand cmd = new SqlCommand(Query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes.tmprint.Clear();
                da.Fill(dsReportes.tmprint);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dsReportes.tmprint.Rows)
            {
                //rptReporteIngresoTarima boleta = new rptReporteIngresoTarima(Convert.ToInt32(row["id"].ToString()));
                //boleta.ShowPrintMarginsWarning = false;
                //boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                //boleta.Print();
                //Thread.Sleep(400);
            }
        }

        private void btnprint_only1_Click(object sender, EventArgs e)
        {
            try
            {
                //var gridview = (GridView)grd_tarimas.FocusedView;
                //var row = (dsReportes.tmprintRow)gridview.GetFocusedDataRow();
                //rptReporteIngresoTarima boleta = new rptReporteIngresoTarima(row.id);
                //boleta.ShowPrintMarginsWarning = false;
                //boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                //boleta.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void btnPrintIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                int ingreso = 0;
                var gridview = (GridView)grd_tarimas.FocusedView;
                var row = (dsReportes.tmprintRow)gridview.GetFocusedDataRow();
                ingreso = row.numero_transaccion;
                foreach (DataRow item in dsReportes.tmprint.Rows)
                {
                    //if (ingreso.ToString() == item["numero_transaccion"].ToString())
                    //{
                    //    rptReporteIngresoTarima boleta = new rptReporteIngresoTarima(Convert.ToInt32(item["id"].ToString()));
                    //    boleta.ShowPrintMarginsWarning = false;
                    //    boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    //    boleta.Print();
                    //}
                }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}