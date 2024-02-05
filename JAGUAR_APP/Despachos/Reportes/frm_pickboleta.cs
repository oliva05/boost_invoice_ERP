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

namespace JAGUAR_APP.Despachos.Reportes
{
    public partial class frm_pickboleta : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();   
        public string Vehiculo;
        public string conductor;
        public string Furgon;
        public string codigo;

        public int id_serie;
        public frm_pickboleta()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string query = @"sp_load_boletas_pt_in_predio";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;         
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.boletas.Clear();
                da.Fill(ds_despachos.boletas);
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

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.boletasRow)gridView.GetFocusedDataRow();
                id_serie = row.id;
                Vehiculo = row.vehiculo;
                Furgon = row.furgon;
                conductor = row.conductorin;
                codigo = row.carcode;
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
                var row = (ds_despachos.boletasRow)gridView.GetFocusedDataRow();
                id_serie = row.id;
                Vehiculo = row.vehiculo;
                Furgon = row.furgon;
                conductor = row.conductorin;
                codigo = row.carcode;
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