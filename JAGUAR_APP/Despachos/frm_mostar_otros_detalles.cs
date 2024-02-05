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
using System.Data.SqlClient;
using ACS.Classes;
using JAGUAR_APP.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Despachos
{
    public partial class frm_mostar_otros_detalles : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int ParId;
        public int LineNUm;
        public int DocEntry;
        public frm_mostar_otros_detalles(int DocEntry)
        {
            InitializeComponent();
            ParId = DocEntry;
            exe_sp_get_plan();
        }
        public void exe_sp_get_plan()
        {
            string query = @"EXECUTE [dbo].[sp_cargar_detalle_orden_de_venta] 
                               @DocEntry = @DocEntryy";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@DocEntryy", SqlDbType.Int).Value = ParId;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.plan_despacho.Clear();
                da.Fill(ds_despachos.plan_despacho);
                cn.Close();         

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.plan_despachoRow)gridView.GetFocusedDataRow();
                LineNUm = row.iddetalle;
                this.DocEntry = row.DocNum;
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
                var row = (ds_despachos.plan_despachoRow)gridView.GetFocusedDataRow();
                LineNUm = row.iddetalle;
                this.DocEntry = row.DocNum;
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