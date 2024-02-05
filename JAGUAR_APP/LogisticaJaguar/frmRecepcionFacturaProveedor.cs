using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.Clases;
using JAGUAR_APP.LogisticaJaguar.Models;
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

namespace JAGUAR_APP.LogisticaJaguar
{
    public partial class frmRecepcionFacturaProveedor : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmRecepcionFacturaProveedor(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            //LoadFacturasList();
            LoadDatos();
        }

        private void LoadFacturasList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddFacturaProveedor frm = new frmAddFacturaProveedor(this.UsuarioLogeado);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void LoadFacturas()
        {
            
        }

        private void cmdPrintFromGrid_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Imprimir el reporte
            try
            {
                RecepcionFacturasProveedor factura_h = new RecepcionFacturasProveedor();

                var row = (dsLogisticaJaguar.home_list_fact_inRow)gridView1.GetFocusedDataRow();

                factura_h.Proveedor=  row.Proveedor_Nombre;
                factura_h.DocNum = row.DocNum;
                factura_h.ID = row.id;
                factura_h.Fecha = row.fecha_factura;
                factura_h.NumeroFactura = row.factura;
                factura_h.EntregadoPor = row.entregado_por_nombre;
                factura_h.EntregadoPorIdentidad = row.entregado_por_identidad;
                factura_h.EntregadoPorTelefono = row.entregado_por_telefono;
                factura_h.EntregadoPorHora = row.entregado_por_hora;
                factura_h.RecibidoPor = row.Usuario_Recibio;
                factura_h.RecibidoPorHora = row.fecha_registro;
                factura_h.RevisadoPor = row.Usuario_Revisado;
                factura_h.RevisadoPorHora = row.hora_revisado;
                factura_h.Observaciones = row.observaciones;

                xrptRecepcionFacturas report = new xrptRecepcionFacturas(factura_h);
                report.DisplayName = row.DocNum.ToString();

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    // Send the report to the default printer.
                    printTool.ShowPreviewDialog();
                }



            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void toggleSwitchVerTodas_Toggled(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_detalle_facturas_recibidas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todas", toggleSwitchVerTodas.IsOn);
                dsLogisticaJaguar1.home_list_fact_in.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.home_list_fact_in);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void cmdVer_Editar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsLogisticaJaguar.home_list_fact_inRow)gridView.GetFocusedDataRow();
            frmAddFacturaProveedor frm = new frmAddFacturaProveedor(this.UsuarioLogeado, frmAddFacturaProveedor.TipoAccionVentana.Update, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }
    }
}