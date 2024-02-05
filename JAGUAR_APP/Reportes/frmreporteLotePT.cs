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
using JAGUAR_APP.Clases;
using System.Data.SqlClient;

namespace JAGUAR_APP.Reportes
{
    public partial class frmreporteLotePT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmreporteLotePT()
        {
            InitializeComponent();
            Load_data();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Load_data()
        {
            string Query = @"sp_get_report_pt_por_lotes";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsReportes.lotespt.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.lotespt);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (CajaDialogo.Pregunta("Desea imprimir el Inventario?") == DialogResult.Yes)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data.ExportToXlsx(dialog.FileName);
                }
            }
        }
    }
}