using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using ACS.Classes;

namespace JAGUAR_APP.Despachos
{
    public partial class frm_viewEntrega : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        DataOperations dp = new DataOperations(); 
        public frm_viewEntrega(int id_carga)
        {
            InitializeComponent();
            id = id_carga;
            load_data();
        }
        public void load_data() 
        {
            string query = @"sp_load_avance_orden_carga_pt";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                ds_despachos.rpt_avance.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds_despachos.rpt_avance);
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