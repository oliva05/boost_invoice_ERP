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

namespace JAGUAR_APP.Reportes
{
    public partial class frmReporteIngreso_v2 : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmReporteIngreso_v2()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            string Query = @"sp_obtener_year_tarimas";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsReportes.year.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.year);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }

        private void grdYEAR_EditValueChanged(object sender, EventArgs e)
        {
            load_report();
        }

        public void load_report()
        {
            string Query = @"sp_load_reporte_de_ingreso_por_lm_v2";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dateanio", grdYEAR.EditValue);
                dsReportes.rpt_ingreso.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.rpt_ingreso);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dsReportes.rpt_ingreso.Rows.Count != 0)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data.ExportToXlsx(dialog.FileName);
                }
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar un año para exportar el reporte.");
                grdYEAR.ShowPopup();
                return;
            }
        }
    }
}