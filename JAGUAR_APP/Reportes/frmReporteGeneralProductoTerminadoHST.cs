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

namespace JAGUAR_APP.Reportes
{
    public partial class frmReporteGeneralProductoTerminadoHST : DevExpress.XtraEditors.XtraForm
    {
       
        int Especie=0;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        //bool VerCostos =false;
        public frmReporteGeneralProductoTerminadoHST(UserLogin pUserLogin)
        {
            InitializeComponent();

            UsuarioLogeado = pUserLogin;
            Especie = 2;
            //VerCostos = false;

            DateTime FechaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime FechaFinal = FechaInicial.AddHours(23);
            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;

            grdv_inventario.OptionsMenu.EnableColumnMenu = false;
            grdv_inventario.Columns["costo"].Visible = false;

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    accesoprevio = false;
                    cmdAjuste.Visible = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    //Accesso a costos
                    grdv_inventario.OptionsMenu.EnableColumnMenu = true;
                    grdv_inventario.Columns["costo"].Visible = true;
                    //VerCostos = true;
                    break;
                default:
                    grdv_inventario.OptionsMenu.EnableColumnMenu = false;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(7))
                {
                    grdv_inventario.OptionsMenu.EnableColumnMenu = true;
                    grdv_inventario.Columns["costo"].Visible = true;
                    //VerCostos = true;
                }
                else
                {
                    //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }


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
                string query = @"dbo.rpt_kardex_pt_historico_V3";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todas", toggleSwitchVerTodas.IsOn);
                cmd.Parameters.AddWithValue("@fecha_i", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario1.inventario_kardex_historico.Clear();
                da.Fill(dsReportesInventario1.inventario_kardex_historico);
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
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                dialog.ShowDialog();

               grd_inventario.ExportToXlsx(dialog.FileName);
                    
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

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            get_inventario();
        }

        private void toggleSwitchVerTodas_Toggled(object sender, EventArgs e)
        {
            get_inventario();
        }
    }
}