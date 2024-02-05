using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.Clases;
using JAGUAR_APP.JaguarProduccion;
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
    public partial class frmProductionOrdersHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        int idNivel=0;

        public frmProductionOrdersHome(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            dp = new DataOperations();
            DateTime FechaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime FechaFinal = FechaInicial.AddHours(23);
            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;
            //LoadFacturasList();
            LoadOrders();

            //Validamos si puede ver informacion de costos
            gridView1.OptionsMenu.EnableColumnMenu = false;
            gridView1.Columns["costo"].Visible = false;
            gridView1.Columns["CostoMoPorArroba"].Visible = false;
            gridView1.Columns["CostoTotal"].Visible = false;

            bool accesoprevio = false;
            idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    gridView1.OptionsMenu.EnableColumnMenu = true;
                    gridView1.Columns["costo"].Visible = true;
                    gridView1.Columns["CostoMoPorArroba"].Visible = true;
                    gridView1.Columns["CostoTotal"].Visible = true;
                    break;
                default:
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(7))
                {
                    gridView1.OptionsMenu.EnableColumnMenu = true;
                    gridView1.Columns["costo"].Visible = true;
                    gridView1.Columns["CostoMoPorArroba"].Visible = true;
                    gridView1.Columns["CostoTotal"].Visible = true;
                }
                else
                {
                    //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }
            //gridControl1.Refresh();
            //gridView1.BeginDataUpdate();
            //try
            //{
            //    gridView1.ClearSorting();
            //    gridView1.Columns["costo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //    gridView1.Columns["CostoMoPorArroba"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //    gridView1.Columns["CostoTotal"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //}
            //finally
            //{
            //    gridView1.EndDataUpdate();
            //}
            for (int i = 0; i < gridView1.Columns.Count-1; i++)
                gridView1.Columns[i].Visible = false;
            gridView1.Columns["costo"].VisibleIndex = 0;
            gridView1.Columns["CostoMoPorArroba"].VisibleIndex = 1;
            gridView1.Columns["CostoTotal"].VisibleIndex = 2;
            gridView1.Columns["fecha"].VisibleIndex = 3;
            gridView1.Columns["DocNum"].VisibleIndex = 4;
            gridView1.Columns["ItemCode"].VisibleIndex = 5;
            gridView1.Columns["ItemName"].VisibleIndex = 6;
            gridView1.Columns["cant_arrobas"].VisibleIndex = 7;
            gridView1.Columns["cant_latas"].VisibleIndex = 8;
            gridView1.Columns["cant_latas_real"].VisibleIndex = 9;
            gridView1.Columns["cant_bolsas"].VisibleIndex = 10;
            gridView1.Columns["cant_bolsas_real"].VisibleIndex = 11;
            gridView1.Columns["Grupo Panaderos"].VisibleIndex = 12;
            gridView1.Columns["Estado"].VisibleIndex = 13;
            gridView1.Columns["Imprimir"].VisibleIndex = 14;
            gridView1.Columns["Finalizar"].VisibleIndex = 15;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddOrderProductionV2 frm = new frmAddOrderProductionV2(this.UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadOrders();
            }
        }

        private void toggleSwitchVerTodas_Toggled(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_detalle_production_orders_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todas", toggleSwitchVerTodas.IsOn);
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsLogisticaJaguar1.Home_Production_orders.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.Home_Production_orders);

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

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void cmdPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Imprimir Orden de Fabricacion
            try
            {
                OrdenFabriacion_H ordenFabricacion = new OrdenFabriacion_H();
                var row = (dsLogisticaJaguar.Home_Production_ordersRow)gridView1.GetFocusedDataRow();

                if (ordenFabricacion.RecuperarRegistro(row.id))
                {
                    xrptOrdenFabricacion report = new xrptOrdenFabricacion(ordenFabricacion, idNivel, this.UsuarioLogeado);
                    report.DisplayName = row.id.ToString();

                    using (ReportPrintTool printTool = new ReportPrintTool(report))
                    {
                        // Send the report to the default printer.
                        printTool.ShowPreviewDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdFinalizar__ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsLogisticaJaguar.Home_Production_ordersRow)gridView1.GetFocusedDataRow();
            if (row.id_estado == 2)//Cerrada
            {
                CajaDialogo.Error("La Orden de Fabracación ya esta cerrada!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Confirme que desea cerrar esta orden de fabricación?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_set_estado_orden_fabricacion_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.Parameters.AddWithValue("@id_estado", 2);//Cerrado
                cmd.Parameters.AddWithValue("@id_user_finalizado", this.UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                con.Close();

                row.id_estado = 2;
                row.Estado = "Cerrada";
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}