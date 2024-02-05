using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class frmvertodasMPinbodega : DevExpress.XtraEditors.XtraForm
    {
        public string bodega = "";
        public string CodigoBodega = "";
        DataOperations dp = new DataOperations();
        public frmvertodasMPinbodega(string pBodega, string pCodigo)
        {
            InitializeComponent();
            bodega = pBodega;
            CodigoBodega = pCodigo;
            txtBodega.Text = CodigoBodega;
            txtbodegaName.Text = bodega; 
            load_data_con_parametro();
        }
        public void load_data_con_parametro()
        {
            
            string query = @"sp_load_lotes_bodega_externa";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bodega", CodigoBodega);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.controlBodegaExterna.Clear();
                da.Fill(dsReporteAlmacenExterno.controlBodegaExterna);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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