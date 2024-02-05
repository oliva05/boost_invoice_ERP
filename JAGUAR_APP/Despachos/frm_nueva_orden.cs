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
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Despachos.Reportes;

namespace JAGUAR_APP.Despachos
{
    public partial class frm_nueva_orden : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        string codigo_selected = "";
        public frm_nueva_orden(UserLogin user)
        {
            InitializeComponent();
            UsuarioLogeado = user;
            load_clientes();
            load_data();
            load_presentacion();
        }

        public void load_presentacion() 
        {
            string query = @"sp_load_presentacion_pt";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.presentacion.Clear();
                da.Fill(ds_despachos.presentacion);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data()
        {
            string query = @"sp_load_productos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.productos.Clear();
                da.Fill(ds_despachos.productos);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_clientes() 
        {
            string query = @"sp_load_clientes";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.clientes.Clear();
                da.Fill(ds_despachos.clientes);
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
        public DataRow NuevaRow(string Itemcode)
        {
            DataRow Data;
            Data = ds_despachos.lineas_orden_carga.NewRow();
            Data[0]= 0;
            Data[1] = Itemcode;
            Data[2] = 1;
            Data[3] = 1;
            Data[4] = 12;
            return Data;
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frm_pt frm = new frm_pt();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ds_despachos.lineas_orden_carga.Rows.Add(NuevaRow(frm.Itemcode));
                ds_despachos.lineas_orden_carga.AcceptChanges();
            }
        }

        private void grdv_data_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
                        var gridView = (GridView)grd_data.FocusedView;
                        var row = (ds_despachos.lineas_orden_cargaRow)gridView.GetFocusedDataRow();
                switch (e.Column.Name)
                {
                    case "colid_presentacion":
                        decimal factor = 0;
                        foreach (ds_despachos.presentacionRow Dt in ds_despachos.presentacion.Rows)
                        {
                            if (Dt.id == row.id_presentacion)
                            {
                                factor = Dt.factor;
                            }
                        }
                        row.peso = row.unidades * factor;
                        row.AcceptChanges();

                        break;
                    case "colunidades":

                        factor = 0;
                        foreach (ds_despachos.presentacionRow Dt in ds_despachos.presentacion.Rows)
                        {
                            if (Dt.id == row.id_presentacion)
                            {
                                factor = Dt.factor;
                            }
                        }
                        row.peso = row.unidades * factor;
                        row.AcceptChanges();
                        break;
                    default:
                        break;
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.lineas_orden_cargaRow)gridView.GetFocusedDataRow();
                decimal factor = 0;

                switch (e.Column.Name)
                {
                    case "colid_presentacion":

                        foreach (ds_despachos.presentacionRow Dt in ds_despachos.presentacion.Rows)
                        {
                            if (Dt.id == Convert.ToInt32(e.Value))
                            {
                                factor = Dt.factor;
                            }
                        }
                        row.peso = row.unidades * factor;
                        row.AcceptChanges();
                        break;

                 

                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_pickboleta frm = new frm_pickboleta();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtboleta.Text = Convert.ToString(frm.id_serie);
                txtvehiculo.Text = frm.Vehiculo;
                txtconductor.Text = frm.conductor;

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.lineas_orden_cargaRow)gridView.GetFocusedDataRow();
                if (MessageBox.Show("Desea eliminar esta linea?", "Desea eliminar esta linea", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                {
                    grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                    ds_despachos.lineas_orden_carga.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnNuevoOrdenCarga_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid_cardcode.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar el Cliente al cual se le desea cargar estos productos.");
                    return;
                }
                if (txtboleta.Text == "")
                {
                    CajaDialogo.Error("Cuando se hace una orden de carga manual no se puede generar sin boleta.");
                    return;
                }
                if (grdv_data.RowCount < 0)
                {
                    CajaDialogo.Error("Debe agregar un producto al menos a la carga.");
                    return;
                }
                if (codigo_selected == "CL00009" || codigo_selected == "CL00002")
                {
                    if (grd_destino.EditValue == null)
                    {
                        CajaDialogo.Error("Debe seleccionar el destino antes del vehiculo para generar el arribo.");
                        return;
                    }
                }
                string query = @"sp_insert_orden_carga_sin_ov_v2";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode", grid_cardcode.EditValue);
                cmd.Parameters.AddWithValue("@iduser", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@id_serie", txtboleta.Text);
                cmd.Parameters.AddWithValue("@id_destino", grd_destino.EditValue == null ? 0 : grd_destino.EditValue);
                int id_inserted = Convert.ToInt32(cmd.ExecuteScalar());

                query = @"sp_insert_despacho_detalle_lotes";
                foreach (ds_despachos.lineas_orden_cargaRow row in ds_despachos.lineas_orden_carga.Rows)
                {
                     cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                    cmd.Parameters.AddWithValue("@peso", row.peso);
                    cmd.Parameters.AddWithValue("@unidades", row.unidades);
                    cmd.Parameters.AddWithValue("@id_h", id_inserted);
                    cmd.Parameters.AddWithValue("@id_presentacion", id_inserted);
                    cmd.ExecuteNonQuery();

                }
                cn.Close();
                CajaDialogo.Information("Se ha generado la orden de carga Adicional.");
                this.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_destinos(string cod)
        {
            try
            {
                string query = @"sp_load_clientes_clientes_to_select";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cliente", cod);
                ds_despachos.cliente_despacho.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds_despachos.cliente_despacho);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void grid_cardcode_EditValueChanged(object sender, EventArgs e)
        {
            grd_destino.Enabled = true;
            codigo_selected = Convert.ToString(grid_cardcode.EditValue);
            load_destinos(codigo_selected);
        }
    }
}