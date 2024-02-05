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
    public partial class frmNotasSearchPDV : DevExpress.XtraEditors.XtraForm
    {

        public int id_pdv = 0;
        public string pdv = "";
        public frmNotasSearchPDV()
        {
            InitializeComponent();
            load();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            id_pdv = Convert.ToInt32(luePDV.EditValue);
            pdv = luePDV.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void load()
        {
            DataOperations dp = new DataOperations();

            SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            string query = @"SELECT id,codigo,nombre_local,nombre_legal
                                FROM dbo.Facturacion_PuntoVenta
                            WHERE enable=1";


            using (SqlDataAdapter da = new SqlDataAdapter(query,cnx))
            {
                cnx.Open();

                dsMantenimientosFacturacion.PDV.Clear();
                da.Fill(dsMantenimientosFacturacion.PDV);

                cnx.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}