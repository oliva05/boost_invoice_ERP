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
using JAGUAR_APP.Clases;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Despachos.Reportes;
using DevExpress.XtraReports.UI;

namespace JAGUAR_APP.Despachos
{
    public partial class frm_view_entrega_despacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int Pid;
        UserLogin UsuarioLogeado;
        public frm_view_entrega_despacho(int id_despacho, UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            Pid = id_despacho;
            load_informacion();
            load_filas();
            load_filasPlanDespacho();
        }

        private void load_filasPlanDespacho()
        {
            string query = @"sp_data_load_rpt_plan_detalle_v1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporte1.detalle.Clear();
                da.Fill(dsReporte1.detalle);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_filas()
        {
            string query = @"sp_load_tarimas_to_orden_despacho";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", Pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.producto_carga.Clear();
                da.Fill(ds_despachos.producto_carga);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
       
        public void load_informacion()
        {
            string query = @"sp_load_informacion_despacho_entregado";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", Pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dtFecha.EditValue = dr.IsDBNull(1) ? DateTime.Now : dr.GetDateTime(1);
                    txtplaca.Text = dr.IsDBNull(3) ? " " : dr.GetString(3);
                    txtfurgon.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                    txtoc.Text = dr.IsDBNull(5) ? " " : dr.GetString(5);
                    txtconductor.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);

                    if (!dr.IsDBNull(dr.GetOrdinal("NumDespacho")))
                        txtNumDoc.Text = dr.GetInt32(7).ToString();
                    else
                        txtNumDoc.Text = "";

                    if (!dr.IsDBNull(dr.GetOrdinal("NumBoleta")))
                        txtNumBoleta.Text = dr.GetInt32(8).ToString();
                    else
                        txtNumBoleta.Text = "";
                }
                dr.Close();
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

        public void recalcularSql(int id1, int id2, int Fila1, int Fila2 )
        {
            try
            {
               

                string query = @"sp_ordenar_despacho";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id1", id1);
                cmd.Parameters.AddWithValue("@id2", id2);   
                cmd.Parameters.AddWithValue("@Fila1", Fila1);
                cmd.Parameters.AddWithValue("@Fila2", Fila2);
                cmd.ExecuteNonQuery();
                cn.Close();   
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea Eliminar esta tarima de este Despacho?La tarima volvera a Bodega.");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;
           
            var gridView = (GridView)grd_data.FocusedView;
            var row = (ds_despachos.producto_cargaRow)gridView.GetFocusedDataRow();

            int contaBoleta = 0;

            try
            {

                string query = @"sp_get_validar_si_boleta_salio";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@boleta",Convert.ToInt32(txtNumBoleta.Text));
                //cmd.ExecuteNonQuery();
                contaBoleta = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (contaBoleta == 0) //Si es 0! ya existe un registro de salida de este vehiculo y furgon.
            {
                CajaDialogo.Error("No puede eliminar el despacho por que ya existe un Registro de Salida del Vehículo!");
                return;
            }

            try
            {
                string query = @"sp_deshabilitar_row_of_despachos_tarimaV2";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                cn.Close();
                load_filas();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void recalcular_fila()
        {
            int fila = 1;
            foreach (ds_despachos.producto_cargaRow row in ds_despachos.producto_carga.Rows)
            {
                row.fila = fila;
                fila++;
            }
            ds_despachos.producto_carga.AcceptChanges();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.producto_cargaRow)gridView.GetFocusedDataRow();
                DataRow dr1;
                DataRow dr2;
                foreach (var index in grdv_data.GetSelectedRows())
                {
                    if (index == 0)
                    {
                        // Cannot move up any further  
                        break;
                    }

                    var row1 = grdv_data.GetDataRow(index); // This returns null  
                    var row2 = grdv_data.GetDataRow(index - 1); // This also returns null  
                    dr1 = grdv_data.GetDataRow(index);
                    dr2 = grdv_data.GetDataRow(index - 1);
                    object[] value = row1.ItemArray; 
                    
                    row1.ItemArray = row2.ItemArray;
                    row2.ItemArray = value; 
                    recalcularSql(Convert.ToInt32(dr1["id"]),
                                  Convert.ToInt32(dr2["id"]),
                                  Convert.ToInt32(dr2["fila"]) ,
                                  Convert.ToInt32(dr1["fila"]) );
                    recalcular_fila();
                }

                ds_despachos.producto_carga.AcceptChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr1;
                DataRow dr2;
                foreach (var index in grdv_data.GetSelectedRows())
                {
                    if (index == ds_despachos.producto_carga.Count)
                    {
                        // Cannot move up any further  
                        break;
                    }

                    var row1 = grdv_data.GetDataRow(index); // This returns null  
                    var row2 = grdv_data.GetDataRow(index + 1); // This also returns null  
                    dr1 = grdv_data.GetDataRow(index);
                    dr2 = grdv_data.GetDataRow(index + 1);
                    object[] value = row1.ItemArray;

                    row1.ItemArray = row2.ItemArray;
                    row2.ItemArray = value;
                    ds_despachos.producto_carga.AcceptChanges();
                    recalcularSql(Convert.ToInt32(dr1["id"]),
                                  Convert.ToInt32(dr2["id"]),
                                  Convert.ToInt32(dr2["fila"]),
                                  Convert.ToInt32(dr1["fila"]));
                    recalcular_fila();
                }
                ds_despachos.producto_carga.AcceptChanges();    

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsReporte.detalleRow)gridView.GetFocusedDataRow();
            Despachos.Reportes.frm_plan cp = new Despachos.Reportes.frm_plan(dp.ValidateNumberInt32(txtNumDoc.Text), this.UsuarioLogeado);

            cp.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(cp);
            printReport.ShowPreview();
        }
    }
}