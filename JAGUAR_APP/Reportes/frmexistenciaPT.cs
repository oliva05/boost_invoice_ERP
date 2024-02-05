using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using ACS.Classes;
using System.Data.SqlClient;

namespace JAGUAR_APP.Reportes
{
    
    public partial class frmexistenciaPT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmexistenciaPT()
        {
            InitializeComponent();
            load_data();
        }
         public void load_data()
        {
            string Query = @"sp_get_cantidad_producto_terminado";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsReportes.ProductoPT.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.ProductoPT);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}