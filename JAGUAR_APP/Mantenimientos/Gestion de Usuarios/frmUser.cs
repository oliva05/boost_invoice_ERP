using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using ACS.Classes;

namespace PRININ.Gestion_de_Usuarios
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoEdicion
        {
            Nuevo = 1,
            Editar = 2
        }

        private bool ValidoContrasenia;

        //private SqlConnection conn;
        //DBOperations op;
        DataOperations op = new DataOperations();
        private TipoEdicion vTipoEdition;
        private UserLogin UserParametro;
        private UserLogin UserEdicion;

        public frmUser(TipoEdicion pTipo, UserLogin pUser, int pIdUserEditar)
        {
            InitializeComponent();
            vTipoEdition = pTipo;
            op = new DataOperations();
            UserParametro = pUser;
            LoadGroup();
            LoadTurnos();

            switch (vTipoEdition)
            {
                case TipoEdicion.Nuevo:
                    txtAlias.Text = "";
                    txtNombre.Text = "";
                    //txtApellido.Text = "";
                    chkUsuarioHabilitado.Checked = true;
                    chkSuperUsuario.Checked = false;
                    ValidoContrasenia = false;
                    txtPass.Text = "";
                    txtConfirmar.Text = "";
                    break;
                case TipoEdicion.Editar:
                    UserEdicion = new UserLogin();
                    if (UserEdicion.RecuperarRegistroJAGUAR(pIdUserEditar))
                    {
                        txtAlias.Text = UserEdicion.Usuario;
                        txtNombre.Text = UserEdicion.Nombre;
                        lueGrupo.EditValue = UserEdicion.IdGrupo;
                        chkUsuarioHabilitado.Checked = UserEdicion.Habilitado;
                        txtPass.Text = UserParametro.DecryptPassword(UserEdicion.Pass);
                        txtConfirmar.Text = UserParametro.DecryptPassword(UserEdicion.Pass);
                        chkSuperUsuario.Checked = UserEdicion.IsSuperUser;
                        lueTurno.EditValue = UserEdicion.TurnoId;
                        ValidoContrasenia = true;
                    }
                    break;
            }
        }

        private void cmdSAve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlias.Text) 
                //|| string.IsNullOrEmpty(txtApellido.Text) 
                || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Los campos: Usuario, Nombre y Apellidos no pueden quedar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(lueGrupo.Text))
            {
                MessageBox.Show("DEBE DE SELECCIONAR UN GRUPO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtConfirmar.Text != txtPass.Text)
            {
                ValidoContrasenia = false;
            }
            else
            {
                ValidoContrasenia = true;
            }

            if (ValidoContrasenia)
            {
                switch (vTipoEdition)
                {
                    case TipoEdicion.Nuevo:
                        UserEdicion = new UserLogin();
                        UserEdicion.Usuario = txtAlias.Text.Trim();
                        UserEdicion.Nombre = txtNombre.Text.Trim();
                        UserEdicion.NombreUser = txtNombre.Text.Trim();
                        //UserParametro.apellido = txtApellido.Text.Trim();
                        UserEdicion.Habilitado = chkUsuarioHabilitado.Checked;
                        UserEdicion.IsSuperUser = chkSuperUsuario.Checked;
                        UserEdicion.Pass = txtPass.Text;
                        UserEdicion.IdGrupo =Convert.ToInt32( lueGrupo.EditValue);
                        UserEdicion.TurnoId = Convert.ToInt32(lueTurno.EditValue);
                        
                        if (UserEdicion.GuardarNuevoUsuario())
                        {
                            CajaDialogo.Information("Guardado con exito!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }


                        break;
                    case TipoEdicion.Editar:
                        //UserEdicion = new UserLogin();
                        UserEdicion.Usuario = txtAlias.Text.Trim();
                        UserEdicion.Nombre = txtNombre.Text.Trim();
                        UserEdicion.NombreUser = txtNombre.Text.Trim();
                        UserEdicion.Habilitado = chkUsuarioHabilitado.Checked;
                        UserEdicion.IsSuperUser = chkSuperUsuario.Checked;
                        UserEdicion.Pass = txtPass.Text;
                        UserEdicion.IdGrupo = Convert.ToInt32(lueGrupo.EditValue);
                        UserEdicion.TurnoId = Convert.ToInt32(lueTurno.EditValue);

                        if (UserEdicion.ModificarUsuario())
                        {
                            CajaDialogo.Information("Guardado con exito!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;
                }
            }
            else
            {
                CajaDialogo.Error("Las contraseñas no coinciden!");
                return;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void LoadGroup()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    string sql = @"SELECT id,
                                       grupo
	                                FROM ACS.conf_grupos_losa
                                WHERE enable=1";

                    SqlDataAdapter da = new SqlDataAdapter(sql,cnx);

                    dsAccesos.Acceso_Grupo.Clear();
                    da.Fill(dsAccesos.Acceso_Grupo);

                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadTurnos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    string sql = @"SELECT id,
                                       descripcion
	                                FROM dbo.JAGUAR_Usuarios_Turnos
                                WHERE enable=1";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnx);

                    dsAccesos.Turno.Clear();
                    da.Fill(dsAccesos.Turno);

                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}