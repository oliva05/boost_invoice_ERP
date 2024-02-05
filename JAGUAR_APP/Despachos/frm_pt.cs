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
using ACS.Classes;
using JAGUAR_APP.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Despachos
{
    
    public partial class frm_pt : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public string Itemcode;
        public string Articulo;
        public frm_pt()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data() 
        {
            string query = @"sp_load_productos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.productos.Clear();
                da.Fill(ds_despachos.productos);
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

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.productosRow)gridView.GetFocusedDataRow();
                Itemcode = row.itemcode;
                Articulo = row.dscripcion;
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.productosRow)gridView.GetFocusedDataRow();
                Itemcode = row.itemcode;
                Articulo = row.dscripcion;
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}