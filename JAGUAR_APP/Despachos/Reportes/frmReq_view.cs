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

namespace JAGUAR_APP.Despachos.Reportes
{
    public partial class frmReq_view : DevExpress.XtraEditors.XtraForm
    {
        public int id_requisa;
        DataOperations dp = new DataOperations();
        public frmReq_view()
        {
            InitializeComponent();
            load_informacion();
        }

        public void load_informacion() 
        {
            string query = @"sp_load_opciones_requisa_pt";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.requisa_pt.Clear();
                da.Fill(ds_despachos.requisa_pt);
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
                var row = (ds_despachos.requisa_ptRow)gridView.GetFocusedDataRow();
                id_requisa = row.id;
                if (CajaDialogo.Pregunta("Desea seleccionar esta requisa para cargar en los andenes?") == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }

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
                var row = (ds_despachos.requisa_ptRow)gridView.GetFocusedDataRow();
                id_requisa = row.id;
                if (CajaDialogo.Pregunta("Desea seleccionar esta requisa para cargar en los andenes?") == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}