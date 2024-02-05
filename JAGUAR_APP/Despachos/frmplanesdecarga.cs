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
using System.Data.SqlClient;
using ACS.Classes;
using JAGUAR_APP.Clases;

namespace JAGUAR_APP.Despachos
{
    public partial class frmplanesdecarga : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmplanesdecarga(UserLogin UsuarioLogeado)
        {
            InitializeComponent();
            this.UsuarioLogeado = UsuarioLogeado;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_verifica_diponibilidad_tarima_entrega_listado_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                ds_despachos.entregacomp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(ds_despachos.entregacomp);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void beIdTarima_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void beIdTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                frmEntregaTarimaReqPT frm = new frmEntregaTarimaReqPT(UsuarioLogeado, beIdTarima.Text);
                beIdTarima.Text = "";
                beIdTarima.Focus();
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();

            }
        }
    }
}