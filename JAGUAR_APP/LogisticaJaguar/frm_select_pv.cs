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
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.LogisticaJaguar
{
    public partial class frm_select_pv : DevExpress.XtraEditors.XtraForm
    {

        public string pv;
        public string Cardcode;
        DataOperations dp = new DataOperations();
        public frm_select_pv()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data() 
        {
            string query = @"sp_obtener_pv";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsRecepcionMP.proveedores);
                cn.Close();
                  

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsRecepcionMP.proveedoresRow)gridView.GetFocusedDataRow();
                pv = row.cardname;
                Cardcode = row.carcode;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message); ;
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsRecepcionMP.proveedoresRow)gridView.GetFocusedDataRow();
                pv = row.cardname;
                Cardcode = row.carcode;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message); ;
            }
        }
    }
}