using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
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

namespace JAGUAR_APP.RecuentoInventario
{
    public partial class frmReporteInvPorLoteA_LaFecha : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmReporteInvPorLoteA_LaFecha(UserLogin puser)
        {
            InitializeComponent();
            UsuarioLogeado = puser;
            dtFechaHasta.EditValue = dp.NowSetDateTime();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_inventario_por_lote_por_fecha", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dtFechaHasta.DateTime);
                dsReportesRecuentosINV1.InventarioA_LaFecha.Clear();
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd);
                adat1.Fill(dsReportesRecuentosINV1.InventarioA_LaFecha);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void frmReporteInvPorLoteA_LaFecha_Activated(object sender, EventArgs e)
        {
            dtFechaHasta.Focus();
        }
    }
}