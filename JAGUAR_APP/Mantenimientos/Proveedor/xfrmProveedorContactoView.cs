using ACS.Classes;
using DevExpress.XtraEditors;
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
    public partial class xfrmProveedorContactoView : DevExpress.XtraEditors.XtraForm
    {
        int IdProveedor;
        string proveedor;
        public xfrmProveedorContactoView(int IDProveedorP,string pProveedor)
        {
            InitializeComponent();
            IdProveedor = IDProveedorP;
            proveedor = pProveedor;

            ObtenerContactos();

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
                    da.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = IdProveedor;

                    da.Fill(dsMantenimiento.JAGUAR_ProveedorContacto);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xfrmProveedorContactoView_Load(object sender, EventArgs e)
        {
            lblContactos.Text = proveedor;
        }
    }
}