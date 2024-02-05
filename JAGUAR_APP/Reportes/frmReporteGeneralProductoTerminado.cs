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
using JAGUAR_APP.TransaccionesPT;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace JAGUAR_APP.Reportes
{
    public partial class frmReporteGeneralProductoTerminado : DevExpress.XtraEditors.XtraForm
    {
       
        int Especie=0;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        bool VerCostos;
        public frmReporteGeneralProductoTerminado(UserLogin pUserLogin)
        {
            InitializeComponent();

            UsuarioLogeado = pUserLogin;
            Especie = 2;
            VerCostos = false;

            //switch (pUserLogin.Idnivel)
            //{
            //    case 1://Basic View
            //        cmdAjuste.Visible = false;
            //        break;
            //    case 2://Basic No Autorization
            //        cmdAjuste.Visible = false;
            //        break;
            //    case 3://Medium Autorization

            //        break;
            //    case 4://Depth With Delta
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}



            grdv_inventario.OptionsMenu.EnableColumnMenu = false;
            grdv_inventario.Columns["costo"].Visible = false;

            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //    case 2://Basic No Autorization
            //    case 3://Medium Autorization
            //        accesoprevio = false;
            //        cmdAjuste.Visible = false;
            //        break;
            //    case 4://Depth With Delta
            //    case 5://Depth Without Delta
            //        accesoprevio = true;
            //        //Accesso a costos
            //        grdv_inventario.OptionsMenu.EnableColumnMenu = true;
            //        grdv_inventario.Columns["costo"].Visible = true;
            //        VerCostos = true;
            //        break;
            //    default:
            //        grdv_inventario.OptionsMenu.EnableColumnMenu = false;
            //        break;
            //}

            //if (!accesoprevio)
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(7))
            //    {
            //        grdv_inventario.OptionsMenu.EnableColumnMenu = true;
            //        grdv_inventario.Columns["costo"].Visible = true;
            //        VerCostos = true;
            //    }
            //    else
            //    {
            //        //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
            //    }
            //}


            get_inventario();

        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void get_inventario()
        {
            try
            {
                //string query = @"dbo.sp_get_kardex_pt";
                //string query = @"dbo.sp_get_kardex_pt_version_costos_v2";
                string query = @"dbo.[sp_get_kardex_pt_version_costos_V3]"; 
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@cargar_costos",VerCostos);
                cmd.Parameters.AddWithValue("@ver_valores_en_cero", tggVerSoloMayorA_Cero.IsOn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario1.inventario_kardex_pt.Clear();
                da.Fill(dsReportesInventario1.inventario_kardex_pt);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //SaveFileDialog dialog = new SaveFileDialog();
                //dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                //dialog.FilterIndex = 0;
                //dialog.FileName = "InventarioPT__" + dp.NowSetDateTime().ToString();
                //grd_inventario.ExportToXlsx(dialog.FileName);

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path="Inventario PT Ovejita";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (grd_inventario.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from Ovejita";

                    grd_inventario.ExportToXlsx(path, advOptions);
                    // Open the created XLSX file with the default application.
                    Process.Start(path);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAjuste_Click(object sender, EventArgs e)
        {
            frmAjusteIKardexPT frm = new frmAjusteIKardexPT(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Especie = 2;
                get_inventario();
            }
        }

        private void cmdRecargar_Click(object sender, EventArgs e)
        {
            get_inventario();
        }

        private void tggVerSoloMayorA_Cero_Toggled(object sender, EventArgs e)
        {
            get_inventario();
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_inventario.FocusedView;
            var row = (dsReportesInventario.inventario_kardex_ptRow)gridView.GetFocusedDataRow();

            frmVerDetalleKardexTransactions frm = new frmVerDetalleKardexTransactions(row.id_pt);
            frm.ShowDialog();
        }
    }
}