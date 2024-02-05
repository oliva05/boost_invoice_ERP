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

namespace JAGUAR_APP.Facturacion.Notas
{
    public partial class frmNotasSearchClientes : DevExpress.XtraEditors.XtraForm
    {

        public int id_cliente = 0;
        public string pdv = "";
        public frmNotasSearchClientes()
        {
            InitializeComponent();
            ObtenerClientes();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            id_cliente = Convert.ToInt32(lueCliente.EditValue);


            this.DialogResult = DialogResult.OK;
        }

    
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimientosFacturacion.Cliente.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerClientesFacturacion", cnx);
                    da.Fill(dsMantenimientosFacturacion.Cliente);

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