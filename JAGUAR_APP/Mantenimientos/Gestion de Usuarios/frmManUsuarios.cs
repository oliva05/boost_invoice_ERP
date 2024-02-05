using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using PRININ.Gestion_de_Usuarios;
using JAGUAR_APP.Clases;
using ACS.Classes;

namespace PRININ.Gestion_de_Usuarios
{
    public partial class frmManUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public UserLogin UsuarioLogueado;
        DataOperations dp;
        public frmManUsuarios(UserLogin pUsersLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUsersLogin;
            dp = new DataOperations();

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            if (UsuarioLogueado.IsSuperUser == true)
            {
                try
                {
                    string sql = @"SELECT [id]
                                  ,[usuario]
                                  ,[password]
                                  ,[habilitado]
                                  ,[nombre]
                                  ,[super_user]
                              FROM [ACS].[conf_usuarios]";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    //cmd.Parameters.Add("id_user", PgSqlType.Int).Value = ;
                    dsUsers.Usuarios.Clear();
                    adat.Fill(dsUsers.Usuarios);
                    conn.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show("No se pudo cargar la lista de usuarios!" + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    string sql = @"SELECT [id]
                                  ,[usuario]
                                  ,[password]
                                  ,[habilitado]
                                  ,[nombre]
                                  ,[super_user]
                              FROM [dbo].[USUARIOS_CONFIG]
                              where id = " + UsuarioLogueado.UserId;
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    //cmd.Parameters.Add("id_user", PgSqlType.Int).Value = ;
                    dsUsers.Usuarios.Clear();
                    adat.Fill(dsUsers.Usuarios);
                    conn.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show("No se pudo cargar la lista de usuarios!" + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            //Nivel de Permiso Crear Usuario
            if (UsuarioLogueado.ValidarNivelPermisos(10))
            {
                UserLogin usx = new UserLogin();
                frmUser fx = new frmUser(frmUser.TipoEdicion.Nuevo, usx,0);
                if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #10");
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void repositoryEditar_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UserLogin usx = new UserLogin();
            var gridView = (GridView)gridControl1.FocusedView;
            DataRow row = (DataRow)gridView.GetFocusedDataRow();
            usx.RecuperarRegistroJAGUAR(row["alias"].ToString());

            frmUser fx = new frmUser(frmUser.TipoEdicion.Editar, this.UsuarioLogueado, usx.Id);
            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarUsuarios();
            }
        }




    }
}