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

namespace JAGUAR_APP.Mantenimientos.Proveedor
{
    public partial class xfrmJAGUAR_Proveedor_Admin : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogin = new UserLogin();

        public xfrmJAGUAR_Proveedor_Admin(UserLogin pUser)
        {
            InitializeComponent();
            ObtenerProveedores();
            usuarioLogin = pUser;
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

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetProveedores_V2", cnx);
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
        {
            xfrmJAGUAR_Proveedor_CRUD frm = new xfrmJAGUAR_Proveedor_CRUD((int)xfrmJAGUAR_Proveedor_CRUD.TipoTransaccion.Nuevo,null,usuarioLogin);
            frm.EventoPasarId_inserted += new xfrmJAGUAR_Proveedor_CRUD.get_inserted(Ejecutar);

            frm.ShowDialog();
            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    ObtenerProveedores();
            //}
        }

        public void Ejecutar(int pIdInserted)
        {
            JAGUAR_Proveedor proveedor = new JAGUAR_Proveedor();
            if (proveedor.RecuperarRegistro(pIdInserted))
            {
                dsMantenimiento.JAGUAR_ProveedorRow row1 = dsMantenimiento.JAGUAR_Proveedor.NewJAGUAR_ProveedorRow();
                row1.id = pIdInserted;
                row1.nombre = proveedor.Nombre;
                row1.codigo = proveedor.Codigo;
                row1.RTN = proveedor.RTN;
                row1.direccion = proveedor.Direccion;


                dsMantenimiento.JAGUAR_Proveedor.AddJAGUAR_ProveedorRow(row1);
                dsMantenimiento.AcceptChanges();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimiento.JAGUAR_ProveedorRow)gvProveedor.GetFocusedDataRow();
                JAGUAR_Proveedor proveedor = new JAGUAR_Proveedor();

                proveedor.ID = row.id;
                proveedor.Nombre = row.nombre;
                proveedor.Codigo = row.codigo;
                proveedor.Direccion = row.direccion;
                proveedor.RTN = row.RTN;

                xfrmJAGUAR_Proveedor_CRUD frm = new xfrmJAGUAR_Proveedor_CRUD((int)xfrmJAGUAR_Proveedor_CRUD.TipoTransaccion.Editar, proveedor,usuarioLogin);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    ObtenerProveedores();
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
                        var row = (dsMantenimiento.JAGUAR_ProveedorRow)gvProveedor.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DisableProveedor", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerProveedores();
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
            }
        }

        private void cmdContact_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsMantenimiento.JAGUAR_ProveedorRow)gvProveedor.GetFocusedDataRow();
            xfrmProveedorContactoView frm = new xfrmProveedorContactoView(row.id,row.nombre);

            frm.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerProveedores();
        }
    }
}