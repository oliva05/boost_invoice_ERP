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

namespace JAGUAR_APP.Reportes
{
    public partial class frmReporteProductoTerminado : DevExpress.XtraEditors.XtraForm
    {
        DateTime F_inicio;
        DateTime F_Final;
        int Especie;
        int Default_value = 0;
        int id_pt;
        string descripcion;
        string codigo;
        string sap;
        DataOperations dp = new DataOperations();
        public frmReporteProductoTerminado()
        {
            InitializeComponent();
            Especie = 2;
            id_pt = Default_value;
        }
        public void get_inventario()
        {
            try
            {
                string query = @"sp_get_inventario_existencia_pt";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario.inventario.Clear();
                da.Fill(dsReportesInventario.inventario);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            if (can_get_report())
            {  // Podemos obtener
                get_ordenes_venta();

                imprimir_despachos();
            }

        }
        public void imprimir_despachos()
        {
            if (dt_final.EditValue != null && dt_inicio.EditValue != null && id_pt != Default_value)
            {
                try
                {
                    string query = @"sp_get_donde_fue_despachado_por_lote";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@inicial", F_inicio);
                    cmd.Parameters.AddWithValue("@final", F_Final);
                    cmd.Parameters.AddWithValue("@id_pt", id_pt);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsReportesInventario.despachado.Clear();
                    da.Fill(dsReportesInventario.despachado);
                    cn.Close();
                    
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0) // Camaron
            {
                Especie = 2;
                txtprodcamaron.Text = "";
                id_pt = Default_value;
                dsReportesInventario.inventario.Clear();
                dsReportesInventario.despachado.Clear();
            }
            else
            {

                Especie = 1;

                txtprodtilapia.Text = "";
                id_pt = Default_value;
                dsReportesInventario.inventario.Clear();
                dsReportesInventario.despachado.Clear();
            }
            if (can_get_report())
            {  // Podemos obtener
                get_ordenes_venta();
            }

        }

        public void get_ordenes_venta()
        {
            try
            {
                string query = @"sp_get_orden_venta_in_semana";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@especie", Especie);
                cmd.Parameters.AddWithValue("@inicial", F_inicio);
                cmd.Parameters.AddWithValue("@final", F_Final);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario.OC.Clear();
                da.Fill(dsReportesInventario.OC);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public bool can_get_report()
        {
            if (dt_inicio.EditValue != null && dt_final.EditValue != null )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validad_producto()
        {
            if (id_pt != Default_value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void get_producto()
        {
            frm_getfinish frm = new frm_getfinish(Especie);
            if (frm.ShowDialog() == DialogResult.OK)
            {

                 id_pt = frm.Id_producto;
                 descripcion = frm.Producto;
                 codigo = frm.Codigo;
                 sap =  frm.Sap;
                if (Especie == 2)
                {
                    txtprodcamaron.Text = descripcion;
                }
                else
                {
                    txtprodtilapia.Text = descripcion;
                }
                get_inventario();
                if (can_get_report())
                {  // Podemos obtener
                    get_ordenes_venta();
                    imprimir_despachos();
                }
            }
        }
        private void btn_setpt_camaron_Click(object sender, EventArgs e)
        {
            
            get_producto();

            imprimir_despachos();

        }
        

        private void btn_setpt_tilapia_Click(object sender, EventArgs e)
        {
            get_producto();

            imprimir_despachos();
        }

        private void dt_final_EditValueChanged(object sender, EventArgs e)
        {
            if (dt_inicio.DateTime > dt_final.DateTime)
            {
                CajaDialogo.Error("La fecha de inicio no puede ser menor que la fecha final.");
                return;
            }
            F_inicio = dt_inicio.DateTime;
            F_Final = dt_final.DateTime;
            if (can_get_report())
            {  // Podemos obtener
                get_ordenes_venta();

                imprimir_despachos();
            }
        }
    }
}