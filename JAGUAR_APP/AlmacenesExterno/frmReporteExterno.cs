using DevExpress.XtraEditors;
//using JAGUAR_APP.RecepcionMP;
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
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.AlmacenesExterno.AjusteInvAlmaExterno;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class frmReporteExterno : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public string itemcode = "";
        public string wshcode = "";
        public string namewhs = "";

        UserLogin UsuarioLogeado;
        public frmReporteExterno(UserLogin pUserLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogeado;
            load_Almacenes_ext_init();
        }
       

        public void load_ordenes_en_transito()
        {
            string query = @"sp_load_oc_transito";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.comprasTransito.Clear();
                da.Fill(dsReporteAlmacenExterno.comprasTransito);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_InventarioAlmacenExterno_x_MP()
        {
            string query = @"sp_get_existencia_almacen_externo";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.InventarioEx.Clear();
                da.Fill(dsReporteAlmacenExterno.InventarioEx);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_Almacenes_ext_init()
        {

            string query = @"sp_get_existencia_almacen_externo_init";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.InventarioEx.Clear();
                da.Fill(dsReporteAlmacenExterno.InventarioEx);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //frmMP frm = new frmMP();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    txtcodigoMP.Text = frm.ItemCode;
            //    txtmp.Text = frm.MateriaPrima;
            //    itemcode = frm.ItemCode;
            //    load_InventarioAlmacenExterno_x_MP();
            //    load_ordenes_en_transito();
            //    load_data_con_parametro();
            //}
        }

        private void frmReporteExterno_Load(object sender, EventArgs e)
        {
        
        }

        private void grdv_resumen_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_resumen.FocusedView;
                var row = (dsReporteAlmacenExterno.InventarioExRow)gridView.GetFocusedDataRow();
                wshcode = row.codigobog;
                namewhs = row.descripcionbog;
                foreach  (var RowBodega in dsReporteAlmacenExterno.InventarioEx)
                {
                    RowBodega.selected = false;
                }
                dsReporteAlmacenExterno.InventarioEx.AcceptChanges();
                row.selected = true;
                row.AcceptChanges();
                txtBodega.Text = wshcode;
                txtbodegaName.Text = namewhs;
                load_data_con_parametro();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void load_data_con_parametro()
        {
            if (itemcode == "" || wshcode == "")
            {
                return;
            }
            string query = @"sp_load_lotes_bodega_externa_con_parametro";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bodega", wshcode);
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.controlBodegaExterna.Clear();
                da.Fill(dsReporteAlmacenExterno.controlBodegaExterna);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void grdv_resumen_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_resumen.FocusedView;
                var row = (dsReporteAlmacenExterno.InventarioExRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {

                    if (row.selected)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0, 178, 148);

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void btnvertodas_Click(object sender, EventArgs e)
        {
            if (wshcode == "")
            {
                CajaDialogo.Error("Seleccione de Inventario de Boodegas Externas una bodega externa.");
                return;
            }
            frmvertodasMPinbodega frm = new frmvertodasMPinbodega(namewhs, wshcode);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdAjusteInv_Click(object sender, EventArgs e)
        {
            int conta = 0;
            var gridView = (GridView)grd_data.FocusedView;
            dsReporteAlmacenExterno.controlBodegaExternaRow row =null;
            //var row = (dsReporteAlmacenExterno.controlBodegaExternaRow)gridView.GetFocusedDataRow();
            foreach (dsReporteAlmacenExterno.controlBodegaExternaRow rowy in dsReporteAlmacenExterno.controlBodegaExterna)
            {
                if (rowy.seleccion)
                {
                    conta++;
                    row = rowy;
                }
            }
            if (conta <= 0)
            {
                CajaDialogo.Error("Debe seleccionar un lote!");
                return;
            }

           

            if (row.totalkg > 0)
            {
                //Permitimos seguir al ajuste
                LoteAlmacenExternoD Lote1 = new LoteAlmacenExternoD();
                Lote1.oc = row.oc;
                Lote1.factura = row.factura;
                Lote1.fingreso = row.fingreso;
                Lote1.lote = row.lote;
                Lote1.totalkg = row.totalkg;
                Lote1.udtotal = row.udtotal;
                Lote1.fvencimiento = row.fvencimiento;
                Lote1.diastovencimiento = row.diastovencimiento;
                Lote1.diasalmacenado = row.diasalmacenado;
                Lote1.mpNombre = row.mpNombre;
                Lote1.codigoMp = row.codigoMp;
                Lote1.producCodigo = row.producCodigo;
                Lote1.fechaproduccion = row.fechaproduccion;
                Lote1.id_mp = row.id_mp;
                Lote1.id_lote_externo = row.id_lote_externo;
                Lote1.id_presentacion = row.id_presentacion;
                Lote1.id_ingreso_lote = row.id_ingreso_lote;
                Lote1.BodegaIn = row.bodega_in;
                Lote1.id_detalle = row.id_detalle;
                frmAddAjusteAlmacenExterno frm = new frmAddAjusteAlmacenExterno(Lote1, this.UsuarioLogeado.Id);
                if(frm.ShowDialog()== DialogResult.OK)
                {
                    load_data_con_parametro();
                    load_InventarioAlmacenExterno_x_MP();
                }
            }
            else
            {
                CajaDialogo.Error("No se puede hacer una salida, la cantidad actual es Cero (0)!");
                return;
            }
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int conta = 0;
            foreach (dsReporteAlmacenExterno.controlBodegaExternaRow rowy in dsReporteAlmacenExterno.controlBodegaExterna)
            {
                if (rowy.seleccion)
                {
                    conta++;
                }
            }

            if (conta > 0)
            {
                foreach (dsReporteAlmacenExterno.controlBodegaExternaRow rowy in dsReporteAlmacenExterno.controlBodegaExterna)
                {
                    rowy.seleccion = false;
                }
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsReporteAlmacenExterno.controlBodegaExternaRow)gridView.GetDataRow(e.RowHandle);
                row.seleccion = true;
            }
        }
    }
}