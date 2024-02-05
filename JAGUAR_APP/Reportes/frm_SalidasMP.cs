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
    public partial class frm_SalidasMP : DevExpress.XtraEditors.XtraForm
    {
        public frm_SalidasMP()
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            dtDesde.EditValue = dp.NowSetDateTime().AddDays(-3);
            dtHasta.EditValue = dp.NowSetDateTime();
        }

        private void dtDesde_Validated(object sender, EventArgs e)
        {
            //LoadDatos();
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

                SqlCommand cmd = new SqlCommand("sp_get_detalle_mp_entregada_from_bod_mpV2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsReportes1.salida_mpV2.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportes1.salida_mpV2);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void dtDesde_EditValueChanged(object sender, EventArgs e)
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
                gridControl1.ExportToXlsx(dialog.FileName);
                //Impresion().ExportToXlsx(dialog.FileName);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}