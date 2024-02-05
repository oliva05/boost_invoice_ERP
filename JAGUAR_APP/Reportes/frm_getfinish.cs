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
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Reportes
{
    public partial class frm_getfinish : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        string codigo;
        string sap;
        string producto;
        int id_producto;
        int especie;
        public frm_getfinish(int especie)
        {
            InitializeComponent();
            Especie = especie;
            load_data();

        }
        public frm_getfinish()
        {
            InitializeComponent();
            Especie = especie;
            load_data_no_importa_la_especie();

        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Sap { get => sap; set => sap = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Especie { get => especie; set => especie = value; }

        public void load_data()
        {
            string query = @"sp_get_finish_product";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@especie", Especie);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario.pickproduct.Clear();
                da.Fill(dsReportesInventario.pickproduct);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            
        }
        public void load_data_no_importa_la_especie()
        {
            string query = @"sp_get_finish_product_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario.pickproduct.Clear();
                da.Fill(dsReportesInventario.pickproduct);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsReportesInventario.pickproductRow)gridView.GetFocusedDataRow();
                Codigo = row.codigo;
                Sap = row.sap;
                Producto = row.descripcion;
                Id_producto = row.id;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsReportesInventario.pickproductRow)gridView.GetFocusedDataRow();
                Codigo = row.codigo;
                Sap = row.sap;
                Producto = row.descripcion;
                Id_producto = row.id;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}