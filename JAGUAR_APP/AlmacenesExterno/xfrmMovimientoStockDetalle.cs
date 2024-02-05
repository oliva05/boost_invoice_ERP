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
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.AlmacenesExterno.Models;
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_APP.AlmacenesExterno.Salida_Almacen.Models;
using JAGUAR_APP.AlmacenesExterno.Salida_Almacen;
using JAGUAR_APP.Clases;


namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmMovimientoStockDetalle : DevExpress.XtraEditors.XtraForm
    {
        int id_header_salida;
        int numero_transaccion;
        string bodega_origen;
        string bodega_destino;
        DateTime fecha;

        public xfrmMovimientoStockDetalle(int pid, string pbodega_in, string pbodega_out, DateTime pfecha, int pnum_transa)
        {
            InitializeComponent();
            id_header_salida = pid;
            lblNumTrans.Text = Convert.ToString(id_header_salida);
            bodega_origen = pbodega_in;
            bodega_destino = pbodega_out;
            fecha = pfecha;
            numero_transaccion = pnum_transa;

            load_data_detalle_salida_externa();
            load_data_lote_salida_externa();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void load_data_detalle_salida_externa()
        {
            DataOperations dp = new DataOperations();
            //string query = @"sp_get_detalle_salida_externa";
            string query = @"sp_get_detalle_salida_externav2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id_header", id_header_salida);
                dsSalidasAlmacenesExternos1.Salida_Almacen_Detalle.Clear();
                da.Fill(dsSalidasAlmacenesExternos1.Salida_Almacen_Detalle);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data_lote_salida_externa()
        {
            int id_detalle = 0;

            foreach (dsSalidasAlmacenesExternos.Salida_Almacen_DetalleRow row in dsSalidasAlmacenesExternos1.Salida_Almacen_Detalle.Rows)
            {
                id_detalle = row.id;
            }

            DataOperations dp = new DataOperations();
            
            string query = @"sp_get_lote_salida_externav2"; //Ingreso Planificado
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id_detalle", id_detalle);
                dsSalidasAlmacenesExternos1.Salida_Almacen_D_Lote.Clear();
                da.Fill(dsSalidasAlmacenesExternos1.Salida_Almacen_D_Lote);
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

            try
            {
                string query2 = @"sp_get_lote_salida_externa_planta_realV2"; //Ingreso Planta Real
                SqlCommand cmd2 = new SqlCommand(query2, cn);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd2);
                cmd2.Parameters.AddWithValue("@id_salida_header", id_header_salida);
                dsSalidasAlmacenesExternos1.Salida_Almacen_D_Lote_Ingreso.Clear();
                adat.Fill(dsSalidasAlmacenesExternos1.Salida_Almacen_D_Lote_Ingreso);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}