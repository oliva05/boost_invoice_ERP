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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.AlmacenesExterno.Reporteria;
using DevExpress.XtraReports.UI;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmAlmacenesExternos_Main : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;

        public xfrmAlmacenesExternos_Main(UserLogin pUser)
        {
            InitializeComponent();
            LoadIngresosExternos();
            UsuarioLogueado = pUser;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            xfrmRevisarOC frm = new xfrmRevisarOC(UsuarioLogueado);
            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadIngresosExternos();
            }
        }


        private void LoadIngresosExternos()
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                cnx.Open();

                dsAlmacenesExternos.ingreso_externo_h.Clear();

                SqlDataAdapter da = new SqlDataAdapter("sp_get_ingresos_almacenes_externos", cnx);
                da.Fill(dsAlmacenesExternos.ingreso_externo_h);
                cnx.Close();

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnver_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_ingreso.FocusedView;
            var row = (dsAlmacenesExternos.ingreso_externo_hRow)gv.GetDataRow(gv.FocusedRowHandle);

            xfrmDetalleIngresoAlmacenExterno frm = new xfrmDetalleIngresoAlmacenExterno(row.id);

            frm.Show();
        }

        private void btnprint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gv = (GridView)grd_ingreso.FocusedView;
            //var row = (dsAlmacenesExternos.ingreso_externo_hRow)gv.GetDataRow(gv.FocusedRowHandle);
            var gridView = (GridView)grd_ingreso.FocusedView;
            var row = (dsAlmacenesExternos.ingreso_externo_hRow)gridView.GetFocusedDataRow();

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_almacenes_externos_rpt_info_ingreso", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", row.id);
                dsSalidasAlmacenesExternos1.reporte_ingreso_h_almacen_externo.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSalidasAlmacenesExternos1.reporte_ingreso_h_almacen_externo);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            xrptAlmacenesExternos report = new xrptAlmacenesExternos(row.id) { DataSource = dsSalidasAlmacenesExternos1,DataMember = "reporte_ingreso_h_almacen_externo"};

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }
    }
}