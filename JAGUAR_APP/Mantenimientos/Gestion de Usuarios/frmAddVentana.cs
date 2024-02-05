using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraSplashScreen;
using System.Threading;
using JAGUAR_APP.Clases;

namespace ACS.IT_Managment
{
    public partial class frmAddVentana : Form
    {
        DataOperations dp;
        int IdSiguiente;
        int IdVentanaSeleccionada;
        UserLogin UsuarioLogeado;
        public frmAddVentana(Accion pAccion, int pIdVentana, UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            AccionActual = pAccion;
            IdVentanaSeleccionada = pIdVentana;
            dp = new DataOperations();
            if (AccionActual == Accion.editar)
            {
                chkNula.Visible = true;
                CargarDatosVentanaFromID(pIdVentana);
            }
            else
            {
                CargarDatos();
            }
        }

        private void CargarDatosVentanaFromID(int pIdVentana)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = @"SELECT      [nombre]
                                          ,[codigo]
                                          ,[descripcion]
                                          ,[habilitada]
                                      FROM [JAGUAR_DB].[ACS].[conf_ventanas]vv
                                      where vv.id_ventana = " + pIdVentana.ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombre.Text = dr.GetString(0);
                    txtCodigo.Text = dr.GetString(1);
                    txtDescripcion.Text = dr.GetString(2);
                    chkNula.Checked = dr.GetBoolean(3);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        Accion AccionActual = Accion.nuevo;

        public enum Accion
        {
            nuevo = 0,
            editar = 1
        }

        private void CargarDatos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = "exec ft_cargar_codigo_siguiente_ventana";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdSiguiente = dr.GetInt32(1);
                    txtCodigo.Text = dr.GetString(2);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            switch (AccionActual)
            {
                case Accion.nuevo:
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        string sql = @"INSERT INTO [JAGUAR_DB].[ACS].[conf_ventanas]
                                                   ([nombre]
                                                   ,[codigo]
                                                   ,[descripcion])
                                             VALUES
                                                   ('" + txtNombre.Text + "', '" +
                                                            txtCodigo.Text + "', '" +
                                                           txtDescripcion.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        string sql1 = @"UPDATE [ACS].[conf_tables_id]
                                    SET [siguiente] = " + (IdSiguiente + 1).ToString() +
                                        "WHERE id = 1;";
                        SqlCommand cmd1 = new SqlCommand(sql1, conn);
                        cmd1.ExecuteNonQuery();
                        //SplashScreenManager.ShowForm(typeof(WaitForm1));
                        //Thread.Sleep(500);
                        conn.Close();
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                        //SplashScreenManager.CloseForm();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case Accion.editar:
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        string sql = @"UPDATE [JAGUAR_DB].[ACS].[conf_ventanas]
                                       SET [nombre] = '" + txtNombre.Text + "'"+
                                          ", [codigo] = '" + txtCodigo.Text +"'" +
                                          ", [descripcion] = '" + txtDescripcion.Text + "'" +
                                          ", [habilitada] = '"+ chkNula.Checked.ToString() + "'"+
                                     " WHERE id_ventana = " + IdVentanaSeleccionada.ToString();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        //SplashScreenManager.ShowForm(typeof(WaitForm_GMReport));
                        //SplashScreenManager.ShowForm(typeof(WaitForm1));
                        //Thread.Sleep(500);
                        conn.Close();
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                        //SplashScreenManager.CloseForm();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                default:
                    CajaDialogo.Error("Ha ocurrido un error en el sistema! \n");
                    break;
            }
            
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }


    }
}
