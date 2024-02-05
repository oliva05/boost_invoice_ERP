using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Clientes.Models;
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

namespace JAGUAR_APP.Mantenimientos.Clientes
{
    public partial class xfrmJAGUAR_Clientes : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        UserLogin usuarioLogueado = new UserLogin();

        public xfrmJAGUAR_Clientes(UserLogin userLogged)
        {
            InitializeComponent();
            ObtenerClientes();
            usuarioLogueado = userLogged;
        }

        private void ObtenerClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.JAGUAR_Clientes.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_JAGUAR_LoadClientes", cnx);
                    da.Fill(dsMantenimiento.JAGUAR_Clientes);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_Clientes_CRUD frm = new xfrmJAGUAR_Clientes_CRUD((int)DataOperations.TipoTransaccionesCRUD.Nuevo,null);
            frm.EventoPasarId_cliente_inserted += new xfrmJAGUAR_Clientes_CRUD.get_cliente_inserted(Ejecutar);

            frm.ShowDialog();
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Deseas eliminar este registro?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        var row = (dsMantenimiento.JAGUAR_ClientesRow)gvClientes.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_Disable_JAGUAR_Clientes", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerClientes();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimiento.JAGUAR_ClientesRow)gvClientes.GetFocusedDataRow();

                Models.JAGUAR_Clientes cliente = new Models.JAGUAR_Clientes();

                cliente.ID = row.id;
                cliente.Nombre = row.nombre;
                cliente.Contacto = row.contacto;
                cliente.Correo = row.correo;
                cliente.Codigo = row.codigo;
                cliente.Telefono = row.telefono;

                xfrmJAGUAR_Clientes_CRUD frm = new xfrmJAGUAR_Clientes_CRUD((int)DataOperations.TipoTransaccionesCRUD.Editar,cliente);
                if (frm.ShowDialog()== DialogResult.OK)
                {
                    ObtenerClientes();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerClientes();
        }

        public void Ejecutar(int pIdLataInserted)
        {
            JAGUAR_Clientes cliente = new JAGUAR_Clientes();
            if (cliente.RecuperarRegistro(pIdLataInserted))
            {
                dsMantenimiento.JAGUAR_ClientesRow row1 = dsMantenimiento.JAGUAR_Clientes.NewJAGUAR_ClientesRow();
                row1.id = pIdLataInserted;
                row1.nombre = cliente.Nombre;
                row1.codigo = cliente.Codigo;
                row1.contacto = cliente.Contacto;
                row1.correo = cliente.Correo;
              

                dsMantenimiento.JAGUAR_Clientes.AddJAGUAR_ClientesRow(row1);
                dsMantenimiento.AcceptChanges();
            }
        }
    }
}