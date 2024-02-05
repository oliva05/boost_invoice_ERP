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

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class frmShowResum : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_externo;
        public UserLogin UsuarioLogeado;
        public frmShowResum(UserLogin Puser, int id_selected)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_externo = id_selected;
            load_Data();
            load_detalle();
        }
        public void load_Data()
        {
            string Query = @"sp_get_resumen_of_ingreso_to_rebajar_externo";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_externo", id_externo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtingreso.Text = dr.GetInt32(1).ToString();
                    txtmateriaprima.Text = dr.GetString(3);
                    txtproveedor.Text = dr.GetString(5);
                    txtpeso.Text = dr.GetDecimal(8).ToString();
                    txtunidades.Text = dr.GetDecimal(7).ToString();
                    
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        public void load_detalle()
        {
            string Query = @"sp_get_detalle_lote_salida_externa";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_externo", id_externo);
                dsAlmacenesExternos.detalle_salida.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsAlmacenesExternos.detalle_salida);
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

        private void frmShowResum_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpeso.Text == "")
                {
                    CajaDialogo.Error("Debe registrar al menos 1 kg. para hacer esta operacion");
                    return;
                     
                }
                if (MessageBox.Show("Desea terminar esta transaccion?", "Desea terminar esta transaccion?",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.Cancel)
                {
                    return;
                }

                string query = @"sp_set_up_traslado_of_ingreso";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_externo", id_externo);
                cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                int id_inserted = Convert.ToInt32(cmd.ExecuteScalar());
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsAlmacenesExternos.detalle_salidaRow)gridView.GetFocusedDataRow();
                foreach (dsAlmacenesExternos.detalle_salidaRow detalleLote in dsAlmacenesExternos.detalle_salida.Rows)
                {//
                    query = @"sp_set_up_traslado_detalle";
                    cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_externo", id_externo);
                    cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@id_traslado_h", id_inserted);
                    cmd.Parameters.AddWithValue("@itemcode", detalleLote.itemcode);
                    cmd.Parameters.AddWithValue("@peso", detalleLote.peso);
                    cmd.Parameters.AddWithValue("@unidades", detalleLote.cantidad);
                    cmd.Parameters.AddWithValue("@lote", detalleLote.lote);
                    cmd.ExecuteNonQuery();

                }

                query = @"sp_set_close_traslado_of_ingreso";
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_externo", id_externo);
                cmd.Parameters.AddWithValue("@id_traslado", id_inserted);
                cmd.ExecuteNonQuery();
                cn.Close();

                CajaDialogo.Information("Rebaja existosa");
                // Bien parece que todo esta good. entonces actualizamos el ingreso.


                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}