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
    public partial class frmReporteConsumoMPPorDia : DevExpress.XtraEditors.XtraForm
    {
        public frmReporteConsumoMPPorDia()
        {
            InitializeComponent();
        }

      private void  load_data()
        {
            try
            {

                if (string.IsNullOrEmpty(dtDesde.Text))
                {
                    CajaDialogo.Error("DEBE DE SELECCIONAR UNA FECHA DE INICIO");
                    return;
                }

                if (string.IsNullOrEmpty(dtHasta.Text))
                {
                    CajaDialogo.Error("DEBE DE SELECCIONAR UNA FECHA FINAL");
                    return;
                }

                DataOperations dp = new DataOperations();

            SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            using (SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getReporteConsumoMPPorFechas", cnx))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@fecha_inicio", dtDesde.EditValue);
                da.SelectCommand.Parameters.Add("@fecha_fin", dtDesde.EditValue);

                cnx.Open();
                dsReportes.ReporteConsumoMPPorFecha.Clear();
                da.Fill(dsReportes.ReporteConsumoMPPorFecha);
                cnx.Close();
            }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}