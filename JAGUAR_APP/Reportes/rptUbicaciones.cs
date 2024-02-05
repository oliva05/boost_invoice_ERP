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
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Reportes
{
    public partial class rptUbicaciones : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int Id_bodega;
        public rptUbicaciones()
        {
            InitializeComponent();
            load_data();

        }
        public void load_data()
        {
            string Qry = @"[dbo].[sp_get_bodegas_enable]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Qry, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsReportes.bodegas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.bodegas);
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

        private void grd_bodegas_EditValueChanged(object sender, EventArgs e)
        {
            Id_bodega = Convert.ToInt32(grd_bodegas.EditValue);
            InitializeReporte();
        }
        public void InitializeReporte()
        {
            string Qry = @"[dbo].[sp_get_ubicacion_from_bodega]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Qry, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idbodega", Id_bodega);
                dsReportes.Ubicaciones.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.Ubicaciones);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnrpt1_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_ubicaciones.FocusedView;
                var row = (dsReportes.UbicacionesRow)gridView.GetFocusedDataRow();
                frm_Reporte_Ubicaciones_Logistica frm = new frm_Reporte_Ubicaciones_Logistica(row.idUb1, row.Descripcion1);
                frm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnrpt2_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_ubicaciones.FocusedView;
                var row = (dsReportes.UbicacionesRow)gridView.GetFocusedDataRow();
                frm_Reporte_Ubicaciones_Logistica frm = new frm_Reporte_Ubicaciones_Logistica(row.idUb2, row.Descripcion2);
                frm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}