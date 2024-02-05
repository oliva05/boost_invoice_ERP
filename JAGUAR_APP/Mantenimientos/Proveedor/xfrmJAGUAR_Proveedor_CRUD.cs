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

namespace JAGUAR_APP.Mantenimientos.Proveedor
{
    public partial class xfrmJAGUAR_Proveedor_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoTransaccion
        {
            Nuevo=1,
            Editar=2
        }
        int tipoTransaccion;
            Conf_TablesID tableID = new Conf_TablesID();
        UserLogin UsuarioLogin = new UserLogin();

        JAGUAR_Proveedor proveedor = new JAGUAR_Proveedor();

        public delegate void get_inserted(int Id_inserted);
        public event get_inserted EventoPasarId_inserted;

        public xfrmJAGUAR_Proveedor_CRUD(int TipoTransaccionP,JAGUAR_Proveedor pProveedor,UserLogin pUser)
        {
            InitializeComponent();
            proveedor = pProveedor;
            tipoTransaccion = TipoTransaccionP;
            UsuarioLogin = pUser; 
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                int idInsertado;

                switch (tipoTransaccion)
                {
                    case (int)TipoTransaccion.Nuevo:

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.usp_Insert_JAGUAR_Proveedor_V2", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtProveedor.Text;
                            cmd.Parameters.Add("@rtn", SqlDbType.VarChar).Value = txtRTN.Text;
                            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text;
                            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCod.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = UsuarioLogin.Id;
                            cmd.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;


                            idInsertado=(int) cmd.ExecuteScalar();



                            foreach (var item in dsMantenimiento.JAGUAR_ProveedorContacto)
                            {
                                SqlCommand cmd3 = new SqlCommand("dbo.usp_UpSert_JAGUAR_ProveedorContacto", cnx);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Parameters.Add("@nombre", SqlDbType.VarChar).Value = item.nombre;
                                cmd3.Parameters.Add("@correo", SqlDbType.VarChar).Value = item.correo;
                                cmd3.Parameters.Add("@telefono", SqlDbType.VarChar).Value = item.telefono;
                                cmd3.Parameters.Add("@id_proveedor", SqlDbType.VarChar).Value = idInsertado;
                                cmd3.Parameters.Add("@id", SqlDbType.VarChar).Value = 0;

                                cmd3.ExecuteNonQuery();

                            }

                            CajaDialogo.Information("DATOS GUARDADOS");
                            EventoPasarId_inserted(idInsertado);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }            



                        break;

                    case (int)TipoTransaccion.Editar:

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("dbo.usp_Update_JAGUAR_Proveedor_V2", cnx);

                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtProveedor.Text;
                            cmd2.Parameters.Add("@rtn", SqlDbType.VarChar).Value = txtRTN.Text;
                            cmd2.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text;
                            //cmd2.Parameters.Add("@codigo", SqlDbType.Int).Value = txtCod.Text;
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = proveedor.ID;
                            cmd2.Parameters.Add("@usuario_modificacion_id", SqlDbType.Int).Value = UsuarioLogin.Id;
                            cmd2.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;

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


        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.Proveedores))
                {
                    txtCod.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void xfrmJAGUAR_Proveedor_CRUD_Load(object sender, EventArgs e)
        {
            if (tipoTransaccion==(int)TipoTransaccion.Editar)
            {
                txtCod.Text = proveedor.Codigo;
                txtProveedor.Text = proveedor.Nombre;
                txtDireccion.Text = proveedor.Direccion;
                txtRTN.Text = proveedor.RTN;

                ObtenerContactos();
            }
            else
            {
                GetIDTable();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerContactos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.JAGUAR_ProveedorContacto.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetJAGUAR_ProveedorContactos", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = proveedor.ID;

                    da.Fill(dsMantenimiento.JAGUAR_ProveedorContacto);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvContacto_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (tipoTransaccion == (int)TipoTransaccion.Editar)
                {
                    var row = (dsMantenimiento.JAGUAR_ProveedorContactoRow)gvContacto.GetFocusedDataRow();
                    DataOperations dp = new DataOperations();

                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                    {
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("dbo.usp_UpSert_JAGUAR_ProveedorContacto", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = row.nombre;
                        cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = row.correo;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = row.telefono;
                        cmd.Parameters.Add("@id_proveedor", SqlDbType.VarChar).Value = proveedor.ID;
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = row.id;


                        if (row.id==0)
                        {
                          row.id= (int)cmd.ExecuteScalar();
                        }
                        else
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
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
                        var row = (dsMantenimiento.JAGUAR_ProveedorContactoRow)gvContacto .GetFocusedDataRow();

                        if (row.id!=0)
                        {

                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DisableProveedorContacto", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerContactos();
                        }
                        }
                        else
                        {
                            gvContacto.DeleteRow(gvContacto.FocusedRowHandle);
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
    }
}