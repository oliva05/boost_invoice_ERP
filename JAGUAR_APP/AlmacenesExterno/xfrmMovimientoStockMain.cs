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
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.AlmacenesExterno.Models;
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_APP.AlmacenesExterno.Salida_Almacen.Models;
using JAGUAR_APP.AlmacenesExterno.Salida_Almacen;
using JAGUAR_APP.Clases;
using JAGUAR_APP.AlmacenesExterno.Reporteria;
using DevExpress.XtraReports.UI;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmMovimientoStockMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public xfrmMovimientoStockMain(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            switch (UsuarioLogeado.Idnivel)
            {
                case 1://Basic View
                    btnTransferencia.Visible = false;
                    break;
                case 2://Basic No Autorization
                    btnTransferencia.Visible = false;
                    break;
                case 3://Medium Autorization

                    break;
                case 4://Depth With Delta
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }
            load_data();
        }

        public void load_data()
        {
            DataOperations dp = new DataOperations();
            string query = @"sp_load_salida_externa_headerV2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsSalidasAlmacenesExternos1.Salida_Almacen_Header.Clear();
                da.Fill(dsSalidasAlmacenesExternos1.Salida_Almacen_Header);
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

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            xfrmMovimientoStock frm = new xfrmMovimientoStock(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void repositoryPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview1 = (GridView)gcTransferencia.FocusedView;
            var row = (dsSalidasAlmacenesExternos.Salida_Almacen_HeaderRow)gridview1.GetFocusedDataRow();

            xrpt_Main_traslado_almacen report = new xrpt_Main_traslado_almacen();
            report.Parameters["id_h"].Value = row.id;
            report.Parameters["tipo_id_reporte"].Value = 1;//PLAN


            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void repositoryVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview1 = (GridView)gcTransferencia.FocusedView;
            var row = (dsSalidasAlmacenesExternos.Salida_Almacen_HeaderRow)gridview1.GetFocusedDataRow();

            xfrmMovimientoStockDetalle frm = new xfrmMovimientoStockDetalle(row.id, row.bodega_in, row.bodega_out, row.fecha, row.numero_transaccion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void cmdPrintIngresado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview1 = (GridView)gcTransferencia.FocusedView;
            var row = (dsSalidasAlmacenesExternos.Salida_Almacen_HeaderRow)gridview1.GetFocusedDataRow();

            xrpt_Main_traslado_almacen report = new xrpt_Main_traslado_almacen();
            report.Parameters["id_h"].Value = row.id;
            report.Parameters["tipo_id_reporte"].Value = 2;//Real Ingresado


            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }
    }
}