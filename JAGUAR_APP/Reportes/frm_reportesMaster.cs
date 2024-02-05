using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using JAGUAR_APP.Clases;

namespace JAGUAR_APP.Reportes
{
    public partial class frm_reportesMaster : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        string RQuery = "";
        bool dobleF = false;
        public enum Reporte
        {
                  ExistenciaHastaLaFecha = 1     ,
                    IngresoRangoDeFechas= 2   ,
                    RptFechaVencimiento = 3    ,
                    ReporteSalidasPT = 4
        }

        public Reporte rpt;
        public frm_reportesMaster(Reporte pRpt)
        {
            InitializeComponent();
            rpt = pRpt;
            GetQry(rpt);
            if (!dobleF)
            {
                label2.Visible = false;
                dt_desde.Visible = false;
            }
        }
        public void load_data() 
        {
            string query = RQuery;
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dthasta", Convert.ToDateTime(dt_hasta.EditValue));
                if (dobleF)
                {

                    cmd.Parameters.AddWithValue("@dtdesde", Convert.ToDateTime(dt_desde.EditValue));
                }
                DataTable Result = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Result);
                cn.Close();
                grd_data.DataSource = Result;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void GetQry(Reporte Parametro) 
        {
            string query = @"sp_get_query_rpt_master";
            string Result = @"";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Enum", Parametro);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Result = dr.GetString(0);
                    dobleF = dr.GetBoolean(1);
                }
                RQuery= Result;

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

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (dt_hasta.Text == "")
            {
                CajaDialogo.Error("Debe seleccionar una fecha.");
                return;
            }
            if (dobleF)
            {
                if (dt_desde.EditValue == null)
                {
                    CajaDialogo.Error("Debe ingresar una fecha inicial.");
                    return;
                }
                if (Convert.ToDateTime(dt_desde.EditValue) > Convert.ToDateTime(dt_hasta.EditValue) )
                {

                }
            }
            load_data();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_data.ExportToXlsx(dialog.FileName);
            }
        }
    }
}