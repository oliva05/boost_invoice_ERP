using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
//using JAGUAR_APP.RecepcionMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Reportes
{
    public partial class frmtarimasporbodega : DevExpress.XtraEditors.XtraForm
    {
        //int IdBodega;
        //string BodegaNombre;
        DataOperations dp = new DataOperations();
        public frmtarimasporbodega()
        {
            InitializeComponent();
            navigationFrame1.SelectedPage = navigationPage2;
            LoadBodegas();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {


            this.Close();
        }
        void LoadBodegas()
        {
            try
            {
                //IdBodega = 0;
                //SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                //string SQL = @"exec sp_get_bodegas_enable";

                //dsRecepcionMPx.bodegas.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                //dsRecepcionMPx.bodegas.Clear();
                ////adat.SelectCommand.Parameters.AddWithValue("@codigo_barra", "");


                //adat.Fill(dsRecepcionMPx.bodegas);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e){}

        public void Load_Report()
        {
            //try
            //{

            //    SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            //    string SQL = @"sp_report_tarimas_por_bodega";
            //    cn.Open();
            //    dsRecepcionMPx.bodegas.Clear();
            //    SqlCommand cmd = new SqlCommand(SQL, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_bodega", IdBodega);
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);

            //    //adat.SelectCommand.Parameters.AddWithValue("@codigo_barra", "");
            //    dsReportes.TarimasPorBodega.Clear();

            //    adat.Fill(dsReportes.TarimasPorBodega);
            //    cn.Close();
            //    string cantidad = "";
            //    foreach (DataRow item in dsReportes.TarimasPorBodega.Rows)
            //    {
            //        cantidad = item["TotalTm"].ToString();
            //        break;
            //    }
            //    lbltotalTM.Text = cantidad;
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e){}

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //
            SeleccionoUnaBodega();
        }

        public void SeleccionoUnaBodega()
        {
            //var gridView = (GridView)grd_bodegas.FocusedView;
            //var row = (dsRecepcionMPx.bodegasRow)gridView.GetFocusedDataRow();

            //IdBodega = row.id;
            //BodegaNombre = row.descripcion;
            //lblnombrebodega.Text = BodegaNombre;

            //if (IdBodega > 0)
            //{
            //    this.navigationFrame1.SelectNextPage();
            //}
            //Load_Report();
        }

        private void grdv_bodegas_DoubleClick(object sender, EventArgs e)
        {
            SeleccionoUnaBodega();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectNextPage();
            LoadBodegas();
            lblnombrebodega.Text = "Escoja una bodega..";
            lbltotalTM.Text = "00";
        }
    }
}