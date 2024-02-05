using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Clientes.Models;
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

namespace JAGUAR_APP.Mantenimientos.Clientes
{
    public partial class xfrmJAGUAR_Clientes_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum Transacciones
        {
            Nuevo=1,
            Editar=2
        }

        int tipoTransaccion = 0;
        Conf_TablesID tableID = new Conf_TablesID();
        JAGUAR_Clientes cliente = new JAGUAR_Clientes();

        public delegate void get_cliente_inserted(int Id_cliente_inserted);
        public event get_cliente_inserted EventoPasarId_cliente_inserted;


        public xfrmJAGUAR_Clientes_CRUD(int pTransaccion,JAGUAR_Clientes pclientes)
        {
            InitializeComponent();
            tipoTransaccion = pTransaccion;
            cliente = pclientes;

        }

              private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.Clientes))
                {
                    txtCodigo.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }





        private void cmdNew_Click(object sender, EventArgs e)
        {          
           

            if (string.IsNullOrEmpty(txtCliente.Text))
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
                            SqlCommand cmd = new SqlCommand("dbo.usp_Insert_JAGUAR_Clientes_V2", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtCliente.Text;
                            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTelefono.Text;
                            cmd.Parameters.Add("@contacto", SqlDbType.VarChar).Value = txtContacto.Text;
                            cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = txtCorreo.Text;

                            id_inserted= Convert.ToInt32( cmd.ExecuteScalar());

                            CajaDialogo.Information("DATOS GUARDADOS");
                            EventoPasarId_cliente_inserted(id_inserted);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;

                    case (int)Transacciones.Editar:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("dbo.usp_Update_JAGUAR_Clientes", cnx);

                            cmd2.CommandType = CommandType.StoredProcedure;


                            cmd2.Parameters.Add("@id", SqlDbType.VarChar).Value = cliente.ID;
                            cmd2.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtCliente.Text;
                            cmd2.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTelefono.Text;
                            cmd2.Parameters.Add("@contacto", SqlDbType.VarChar).Value = txtContacto.Text;
                            cmd2.Parameters.Add("@correo", SqlDbType.VarChar).Value = txtCorreo.Text;


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
                txtCliente.Text = cliente.Nombre;
                txtCorreo.Text = cliente.Correo;
                txtContacto.Text = cliente.Contacto;
                txtTelefono.Text = cliente.Telefono;
                txtCodigo.Text = cliente.Codigo;
                txtCodigo.Enabled = false;
            }
            else
            {
                GetIDTable();
            }
           
        }
    }
}