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
using ACS.Classes;
using JAGUAR_APP.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Despachos
{
    public partial class frm_despachos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public frm_despachos()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string query = @"sp_load_info_operador_pt_despachos";
            SqlConnection CN = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(query,CN);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.op_despachos.Clear();
                da.Fill(ds_despachos.op_despachos);
                CN.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_activas()
        {
            string query = @"sp_load_info_operador_pt_despachos_todos";
            SqlConnection CN = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(query, CN);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.op_despachos.Clear();
                da.Fill(ds_despachos.op_despachos);
                CN.Close();
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            var gridView = (GridView)grd_data.FocusedView;
            var row = (ds_despachos.op_despachosRow)gridView.GetFocusedDataRow();

            frm_entregarTarimaPT frm = new frm_entregarTarimaPT(row.id,row.DespachoN);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (ds_despachos.op_despachosRow)gridView.GetFocusedDataRow();

            frm_viewEntrega frm = new frm_viewEntrega(row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
            
        }

        private void tgg_ver_Toggled(object sender, EventArgs e)
        {
            if (tgg_ver.IsOn)
            {    //ver todas
                load_activas();
            }
            else
            {  //ver solo activas
                load_data();
            }
        }

        private void grdv_data_RowStyle(object sender, RowStyleEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (ds_despachos.op_despachosRow)gridView.GetDataRow(e.RowHandle);
            if (e.RowHandle >= 0)
            {

                if (row.activo)
                {
                    e.Appearance.BackColor = Color.FromArgb(240, 240, 240);

                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                }
            }
        }
    }
}