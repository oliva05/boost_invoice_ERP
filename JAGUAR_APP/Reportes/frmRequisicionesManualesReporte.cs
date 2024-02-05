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

namespace JAGUAR_APP.Reportes
{
    public partial class frmRequisicionesManualesReporte : DevExpress.XtraEditors.XtraForm
    {
        public frmRequisicionesManualesReporte()
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            dtDesde.EditValue = dp.NowSetDateTime().AddDays(-3);
            dtHasta.EditValue = dp.NowSetDateTime();
        }

        private void LoadDatos()
        {
            if (dtDesde.EditValue == null || dtHasta.EditValue == null)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_requisiciones_adicionales_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsReportes1.rpt_requisiciones_manuales.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportes1.rpt_requisiciones_manuales);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void dtDesde_EditValueChanged(object sender, EventArgs e)
        {
            //
            LoadDatos();
        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridDetalleReq.ExportToXlsx(dialog.FileName);
                //Impresion().ExportToXlsx(dialog.FileName);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}