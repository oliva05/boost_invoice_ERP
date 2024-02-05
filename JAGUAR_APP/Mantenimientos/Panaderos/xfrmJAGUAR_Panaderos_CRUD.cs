using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Proveedor.Model;
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
using static JAGUAR_APP.Clases.Conf_TablesID;

namespace JAGUAR_APP.Mantenimientos.Panaderos
{
    public partial class xfrmJAGUAR_Panaderos_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public delegate void get_panadero_inserted(int Id_inserted);
        public event get_panadero_inserted EventoPasarId_inserted;

        public enum Transacciones
        {
            Nuevo=1,
            Editar=2
        }

        Conf_TablesID tableID = new Conf_TablesID();

        int tipoTransaccion = 0;
        string panadero;
        int panadero_id = 0;

        UserLogin usuarioLogueado = new UserLogin();

        public xfrmJAGUAR_Panaderos_CRUD(int pTransaccion,string pPanadero,int pPanaderoID,UserLogin pUser)
        {
            InitializeComponent();
            ObtenerProveedores();
            tipoTransaccion = pTransaccion;
            panadero = pPanadero;
            panadero_id = pPanaderoID;
            usuarioLogueado = pUser;
        }

              private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerProveedores()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.JAGUAR_Proveedor.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetProveedores", cnx);
                    da.Fill(dsMantenimiento.JAGUAR_Proveedor);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       private void cmdNew_Click(object sender, EventArgs e)
        { //dbo.usp_JAGUAR_InsertNewProveedorCAI
           
           

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("DEBE INGRESAR UN CAI VALIDO");
                return;
            }


            try
            {
                DataOperations dp = new DataOperations();
                int id_inserted = 0;

                switch (tipoTransaccion)
                {
                    case (int)Transacciones.Nuevo:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.usp_InsertJAGUAR_Panadero_V2", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCod.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuarioLogueado.Id;

                            id_inserted= Convert.ToInt32( cmd.ExecuteScalar());

                            CajaDialogo.Information("DATOS GUARDADOS");
                            EventoPasarId_inserted(id_inserted);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;

                    case (int)Transacciones.Editar:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("[dbo].[usp_UpdateJAGUAR_Panadero]", cnx);

                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = panadero_id;
                            cmd2.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text ;
                            cmd2.Parameters.Add("@user_id", SqlDbType.Int).Value = usuarioLogueado.Id;


                            cmd2.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS ACTUALIZADOS");
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmProveedorCAI_CRUD_Load(object sender, EventArgs e)
        {
            if (tipoTransaccion==(int)Transacciones.Editar)
            {
                txtNombre.Text = panadero;              
            }
            else
            {
                GetIDTable();
            }
           
        }

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.Panaderos,3))
                {
                    txtCod.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }
    }
}