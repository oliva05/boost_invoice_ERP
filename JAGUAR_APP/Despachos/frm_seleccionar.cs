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
    public partial class frm_seleccionar : DevExpress.XtraEditors.XtraForm
    {

        public int docentry;
        public int DocNUm=0;
        DataOperations dp = new DataOperations();
        public frm_seleccionar()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data() 
        {
            try
            {
                string query = @"sp_load_informacion_oc";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {

                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.orden_de_ventaRow)gridView.GetFocusedDataRow();
                docentry = row.DocEntry;
                DocNUm = row.docnum;
                this.DialogResult = DialogResult.OK;
                this.Close();
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
                var row = (ds_despachos.orden_de_ventaRow)gridView.GetFocusedDataRow();
                docentry = row.DocEntry;
                DocNUm = row.docnum;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}