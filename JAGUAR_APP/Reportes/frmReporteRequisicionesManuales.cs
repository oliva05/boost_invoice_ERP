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
    public partial class frmReporteRequisicionesManuales : DevExpress.XtraEditors.XtraForm
    {
        public frmReporteRequisicionesManuales()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(dtDesde.Text))
            {
                CajaDialogo.Error("Es necesario establecer una fecha de Inicio!");
                return;
            }

            if (string.IsNullOrEmpty(dtHasta.Text))
            {
                CajaDialogo.Error("Es necesario establecer una fecha de Fin!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_man_data_for_req_manuals_detalle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                dsReportesRequisicionesManuales1.reporte_requisiciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesRequisicionesManuales1.reporte_requisiciones);
                con.Close();

                if (dsReportesRequisicionesManuales1.reporte_requisiciones.Count > 0)
                    errorProvider1.Clear();
                else
                    errorProvider1.SetError(btnFiltrar, "No se obtuvieron resultados!");
                
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }
    }
}