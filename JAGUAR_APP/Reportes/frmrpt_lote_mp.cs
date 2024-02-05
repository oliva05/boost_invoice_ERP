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
using JAGUAR_APP.Clases;           


namespace JAGUAR_APP.Reportes
{

    public partial class frmrpt_lote_mp : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmrpt_lote_mp()
        {
            InitializeComponent();
            load_informacion();
        }
        public void load_informacion()
        {
            string query = @"sp_load_materia_prima_existencia";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes.lote_existencia_mp.Clear();
                da.Fill(dsReportes.lote_existencia_mp);
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

        private void btnExcel_Click(object sender, EventArgs e)
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