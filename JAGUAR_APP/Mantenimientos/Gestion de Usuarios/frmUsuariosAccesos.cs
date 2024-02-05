using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Gestion_de_Usuarios;
using PRININ.Gestion_de_Usuarios;
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

namespace ACS.IT_Managment
{
    public partial class frmUsuariosAccesos : Form
    {
        UserLogin UsuarioLogeado ;
        public frmUsuariosAccesos(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMant_IT.usuariosRow)gridView.GetFocusedDataRow();
            frmViewUser frm = new frmViewUser(row.id, row.nombre, row.activo);
            frm.Show();
        }

        private void frmUsuariosAccesos_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();

                //Variable para filtrar los user
                int iVer = 0;
                if (toggleVista.IsOn)
                    iVer = 1;

                string sql = @"SELECT [id]
                                      ,[nombre]
                                      ,[ADUser] as 'ad_user'
	                                  ,activo,
	                                  fecha_posteo
                                      ,coalesce(aqf_code,' ') as aqf_code
                                      ,usuario as alias
                              FROM [JAGUAR_DB].[ACS].[conf_usuarios]
                              where activo = " + iVer + @"
                              order by [nombre] asc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsMant_IT1.usuarios.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMant_IT1.usuarios);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void toggleVista_Toggled(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            //Agregar un nuevo user
            frmUser frmU = new frmUser(frmUser.TipoEdicion.Nuevo, this.UsuarioLogeado,0);
            if(frmU.ShowDialog() == DialogResult.OK)
            {
                CargarUsuarios();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsMant_IT.usuariosRow)gridView.GetFocusedDataRow();

                //frmAddUserACS frm = new frmAddUserACS(row.id);
                frmUser frm = new frmUser(frmUser.TipoEdicion.Editar, this.UsuarioLogeado, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
