using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Calidad.LoteConfConsumo;
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

namespace LOSA.Calidad.LoteConfConsumo
{
    public partial class frmConfigLoteConsumoFirst : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmConfigLoteConsumoFirst(UserLogin puser)
        {
            InitializeComponent();
            UsuarioLogeado = puser;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MateriaPrima);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadLotesMP(frm.ItemSeleccionado.id);
                textEdit1.Text = frm.ItemSeleccionado.ItemCode + " " + frm.ItemSeleccionado.ItemName;
            }
        }

        private void LoadLotesMP(int pidRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                //SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_configurados_por_mpv2", con);
                SqlCommand cmd = new SqlCommand("sp_get_obtener_inventario_general_por_lote_y_mp_vencimiento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_materia_prima", pidRM);
                dsConfigLoteConsumo1.config_lote.Clear();
                //dsPresupuesto1.estados.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigLoteConsumo1.config_lote);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void repositoryEditarFechaVenc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsConfigLoteConsumo.config_loteRow)gridView.GetFocusedDataRow();

            if (row.id_mp == 1101 || row.id_mp == 1110)
            {
                frmEditFechaVencimientoIngreso frm = new frmEditFechaVencimientoIngreso(row.id_mp, row.lote, row.fecha_vence, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadLotesMP(row.id_mp);
                }
            }
            else
            {

                frmEditFechaVencimientoIngreso frm = new frmEditFechaVencimientoIngreso(row.id_mp, row.numero_transaccion, row.lote, row.fecha_vence, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadLotesMP(row.id_mp);
                }
            }

        }
    }
}