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
using DevExpress.XtraGrid.Views.Grid;
using ACS.Classes;

namespace PRININ.Gestion_de_Usuarios
{
    public partial class frmPermisosEdit : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int idUsuarioSelec;
        string alias;
        string nombre;
        string apellido; 

        public frmPermisosEdit(int pidusuario, string palias, string pnombre, string papellido)
        {
            InitializeComponent();

            idUsuarioSelec = pidusuario;

            alias = palias;
            txtUser.Text = palias;

            nombre = pnombre;
            apellido = papellido;
            txtNombre.Text = pnombre + " " + papellido;

            CargarVentanasUsuario(pidusuario);

        }

        private void CargarVentanasUsuario(int pidusuario)
        {
            try
            {
                string sql = @"SELECT 
                                  t1.id,
                                  codigo,
                                  descripcion,
                                  nombre,
                                  t1.enable	

                                FROM 
                                  [dbo].[USUARIOS_VENTANAS] t1 JOIN 
                                  [dbo].[USUARIOS_VENT_CONF] t2
                                  ON t1.id = t2.id_venta	
                                  where t2.id_usuario = @id
                                  order by codigo ASC";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = idUsuarioSelec;
                dsUsers.permisos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsUsers.permisos);
                conn.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsUsers.permisosRow)gridview.GetFocusedDataRow();

            switch (e.Column.Name)
            {
                case "colcheckcolumn":
                    if (Convert.ToBoolean(e.Value))
                    {
                        foreach (DataRow item in dsUsers.permisos.Rows)
                        {
                            if (row.id.ToString() == item["id"].ToString())
                            {
                                item["checkcolumn"] = e.Value;
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow item in dsUsers.permisos.Rows)
                        {
                            if (row.id.ToString() == item["id"].ToString())
                            {
                                item["checkcolumn"] = e.Value;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void repositoryItemButtonEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar acceso 
            DialogResult r = CajaDialogo.Pregunta("Realmente desea eliminar este permiso?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsUsers.permisosRow)gridView.GetFocusedDataRow();

            try
            {
                string sql = @"DELETE FROM 
                                  [ACS].[conf_usuarios]
                                WHERE 
                                  id_usuario = " + idUsuarioSelec.ToString() +
                                  " and id_venta = " + row.id.ToString();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            CargarVentanasUsuario(idUsuarioSelec);
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            //agregar nuevos accesos
            frmPermisosAdd conf_Nuevo = new frmPermisosAdd(idUsuarioSelec);
            if (conf_Nuevo.ShowDialog() == DialogResult.OK)
            {
                CargarVentanasUsuario(idUsuarioSelec);
            }
        }
    }
}