using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Mantenimientos.Gestion_de_Usuarios;
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
    public partial class frmViewUser : Form
    {
        int IdUsuarioSeleccionado;
        string Nombre;
        bool Activo;
        //string ADuser;
        public frmViewUser(int pidUsuario, string pNombre, bool pActivo)
        {
            InitializeComponent();
            IdUsuarioSeleccionado = pidUsuario;
            txtId.Text = IdUsuarioSeleccionado.ToString();
            txtNombreUsuario.Text = Nombre = pNombre;
            chkActivo.Checked = Activo = pActivo;
            //txtUsuarioAD.Text = ADuser = pADuser;
            CargarVentanasUsuario(pidUsuario);
        }

        private void CargarVentanasUsuario(int pidUsuario)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();

                string query;
                query = @"SELECT top 1 
                                coalesce(aqf_code,' ') as aqf_code
                                FROM [JAGUAR_DB].[ACS].[conf_usuarios]
                                where id =" + pidUsuario;
                SqlCommand cmd = new SqlCommand(query, conn);
                txtaqfcode.Text = Convert.ToString(cmd.ExecuteScalar());

                string sql = @"SELECT vv.[id_ventana]
		                                ,[nombre]
		                                ,[codigo]
		                                ,[descripcion]
		                                ,[habilitada]
		                                ,[fecha_vinculo]
		                                ,[select_]
		                                ,[update_]
		                                ,[insert_]
		                                ,[delete_]
                                FROM [JAGUAR_DB].[ACS].[conf_ventanas] vv join
	                                 [JAGUAR_DB].[ACS].[conf_usuario_ventanas] uu 
	                                 on vv.id_ventana = uu.id_ventana
                                where uu.id_usuario = " + pidUsuario.ToString();
                cmd = new SqlCommand(sql, conn);
                dsMant_IT1.view_user.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMant_IT1.view_user);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void frmViewUser_Load(object sender, EventArgs e){}

        private void button_funciones_Click(object sender, EventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsMant_IT.view_userRow)gridView.GetFocusedDataRow();
            ////clic en ver funciones asignadas
            //frmMantFuncionesUser frm = new frmMantFuncionesUser(row.nombre, 
            //                                                    row.id_ventana, 
            //                                                    IdUsuarioSeleccionado, 
            //                                                    chkActivo.Checked, 
            //                                                    txtUsuarioAD.Text);
            //frm.Show();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            //click en boton eliminar

            DialogResult r = CajaDialogo.Pregunta("Realmente desea eliminar este permiso?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMant_IT.view_userRow)gridView.GetFocusedDataRow();

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = @"DELETE FROM [ACS].[conf_usuario_ventana_funciones]
                                WHERE id_usuario = " + IdUsuarioSeleccionado.ToString() +
                                    " and id_ventana = " + row.id_ventana.ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                string sql2 = @"DELETE FROM [ACS].[conf_usuario_ventanas]
                                  WHERE [id_ventana] = " + row.id_ventana.ToString() +
                              " and id_usuario = " + IdUsuarioSeleccionado.ToString();
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            CargarVentanasUsuario(IdUsuarioSeleccionado);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmAddWindowToUser frm = new frmAddWindowToUser(IdUsuarioSeleccionado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarVentanasUsuario(IdUsuarioSeleccionado);
            }
            
        }
    }
}
