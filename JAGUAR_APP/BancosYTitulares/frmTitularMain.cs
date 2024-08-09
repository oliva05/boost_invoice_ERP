using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAGUAR_APP.BancosYTitulares;
using JAGUAR_APP.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.BancosYTitulares
{
    public partial class frmTitularMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        PDV PuntoVentaActual;
        int IdTitular;

        public frmTitularMain(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;
            tsActivo.IsOn = true;
            CargarTitulares();
        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            frmTitularOP frm = new frmTitularOP(frmTitularOP.TipoOperacion.Insert, 0, UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTitulares();
            }
        }

        private void CargarTitulares()
        {
            try
            {
                string query = @"sp_finanzas_get_titulares";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@activo",tsActivo.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsBancos1.lista_titulares.Clear();
                adat.Fill(dsBancos1.lista_titulares);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCloseHeader_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsBancos.lista_titularesRow)gridview.GetFocusedDataRow();

            frmTitularOP frm = new frmTitularOP(frmTitularOP.TipoOperacion.Update, row.id_titular, UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTitulares();
            }

        }

        private void tsActivo_Toggled(object sender, EventArgs e)
        {
            CargarTitulares();
        }
    }
}