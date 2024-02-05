using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;

namespace JAGUAR_APP.Reportes
{

    public partial class rptIngresoHoja : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        int Id;
        int Id_mp;
        //int id_lote;
        int isTraslado;
        int isGranel;
        int isLiquidoTanque;
        int id_transaccion;
        string itemcode;

        public rptIngresoHoja(int Pid, int Pid_mp)
        {
            InitializeComponent();
            id_ingreso.Value = Id = Pid;

            Id_mp = Pid_mp;
            validar_tipoingreso();

            if (isGranel == 1)
            {
                load_data_granel();
                load_detalle_granel();
                //load_lote_granel();
            }
            else
            {
                load_data();
                load_detalle();
                //load_lote();
            }
            load_lote();

            id_ingreso.Value = Pid;
            id_materia_prima.Value = Pid_mp;
            is_granel.Value = isGranel;

            if (isTraslado > 0)
            {
                xrLabel1.Text = @"TRASLADO DE MATERIA PRIMA";
                xrLabel6.Visible = true;
                txtNTransferencia.Visible = true;

                Transferencia transf = new Transferencia();
                transf.RecuperarHeaderTransf(Convert.ToInt32(txtingreso.Text));

                txtNTransferencia.Text = Convert.ToString(transf.Id_transferencia);
            }

        }


        public rptIngresoHoja(int Pid_transaccion, string Pitemcode, int pisLiquidoTanque, int pid_mp)
        {
            InitializeComponent();
            isLiquidoTanque = pisLiquidoTanque;
            id_transaccion = Pid_transaccion;
            Id_mp = pid_mp;
            itemcode = Pitemcode;
            load_data_liquido();
            load_detalle_ingreso_liquidos();
            isGranel = 3;
            id_ingreso.Value = Pid_transaccion;
            id_materia_prima.Value = pid_mp;
            is_granel.Value = isGranel;

            load_lote();

        }

        private void load_detalle_ingreso_liquidos()
        {
            try
            {
                string query = @"[sp_load_main_data_rpt_ingreso_liquidos_tanque_externos]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", id_transaccion);
                dsReportes1.IngresoDetalle.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes1.IngresoDetalle);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void load_data_liquido()
        {
            string query = @"[sp_load_data_informacion_ingreso_liquido]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@num_transaccion", id_transaccion);
            cmd.Parameters.AddWithValue("@itemcode", itemcode);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtingreso.Text = dr.IsDBNull(1) ? "" : dr.GetInt32(1).ToString();
                dtingreso.Text = dr.IsDBNull(2) ? "" : dr.GetDateTime(2).ToString("dd/MM/yyyy");
                txtUserIngreso.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                txtproveedor.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                txtboleta.Text = dr.IsDBNull(6) ? "" : dr.GetInt32(6).ToString();
                txtfactura.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
                txtunidades.Text = dr.IsDBNull(8) ? "" : dr.GetDecimal(8).ToString();
                txtplaca.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);
                txtransporte.Text = dr.IsDBNull(10) ? "" : dr.GetString(10).ToString();
                txtconductor.Text = dr.IsDBNull(11) ? "" : dr.GetString(11);
                txtoc.Text = dr.IsDBNull(12) ? "" : dr.GetString(12).ToString();
                txtsap.Text = dr.IsDBNull(12) ? "" : dr.GetString(12).ToString();
                xrLabel5.Text = dr.IsDBNull(13) ? "" : dr.GetString(13).ToString();
            }
            dr.Close();
            cn.Close();
        }

        public void load_data_granel()
        {
            try
            {
                string query = @"sp_load_data_informacion_ingreso_granel";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtoc.Text = dr.IsDBNull(12) ? "" : dr.GetString(12).ToString();
                    txtsap.Text = dr.IsDBNull(12) ? "" : dr.GetString(12).ToString();
                    txtingreso.Text = dr.IsDBNull(1) ? "" : dr.GetInt32(1).ToString();
                    dtingreso.Text = dr.IsDBNull(2) ? "" : dr.GetDateTime(2).ToString("dd/MM/yyyy");
                    txtUserIngreso.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    txtproveedor.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    txtboleta.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    txtfactura.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
                    txtunidades.Text = dr.IsDBNull(8) ? "" : dr.GetInt32(8).ToString();
                    txtransporte.Text = dr.IsDBNull(10) ? "" : dr.GetString(10).ToString();
                    txtconductor.Text = dr.IsDBNull(11) ? "" : dr.GetString(11);
                    txtplaca.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void validar_tipoingreso()
        {
            string query = @"sp_get_informacion_sobre_tipo_ingreso_and_traslado";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    isTraslado = dr.GetInt32(0);
                    isGranel = dr.GetInt32(1);
                }
                dr.Close();
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data()
        {
            string query = @"sp_load_informacion_ingreso_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_ingreso", Id );
            cmd.Parameters.AddWithValue("@Id_mp", Id_mp);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtoc.Text = dr.IsDBNull(12) ? "" : dr.GetString(12).ToString();
                txtsap.Text = dr.IsDBNull(12) ? "" : dr.GetString(12).ToString();
                txtingreso.Text = dr.IsDBNull(1) ? "" : dr.GetInt32(1).ToString();
                dtingreso.Text = dr.IsDBNull(2) ? "" : dr.GetDateTime(2).ToString("dd/MM/yyyy");
                txtUserIngreso.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                txtproveedor.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                txtboleta.Text = dr.IsDBNull(6) ? "" : dr.GetInt32(6).ToString();
                txtfactura.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
                txtunidades.Text = dr.IsDBNull(8) ? "" : dr.GetDecimal(8).ToString();
                txtransporte.Text = dr.IsDBNull(10) ? "" : dr.GetString(10).ToString();
                txtconductor.Text = dr.IsDBNull(11) ? "" : dr.GetString(11);
                txtplaca.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);
            }
            dr.Close();
            cn.Close();
        }
         public void load_detalle()
        {
            try
            {
                string query = @"sp_load_main_data_rpt_ingreso_v2";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id);
                cmd.Parameters.AddWithValue("@Id_mp", Id_mp);
                dsReportes1.IngresoDetalle.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes1.IngresoDetalle);
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void load_detalle_granel()
        {
            try
            {
                string query = @"sp_load_main_data_rpt_ingreso_granel";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id);
                dsReportes1.IngresoDetalle.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes1.IngresoDetalle);
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void load_lote()
        {
            try
            {
                if (isLiquidoTanque == 1)
                {
                    string query = @"sp_rpt_print_detalle_lote_tarima_granel";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ingreso", id_transaccion);
                    cmd.Parameters.AddWithValue("@Id_mp", Id_mp);
                    cmd.Parameters.AddWithValue("@isgranel", 3);
                    dsReportes1.Lote.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsReportes1.Lote);
                    cn.Close();
                }
                else
                {
                    string query = @"sp_rpt_print_detalle_lote_tarima_granel";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ingreso", Id);
                    cmd.Parameters.AddWithValue("@Id_mp", Id_mp);
                    cmd.Parameters.AddWithValue("@isgranel", isGranel);
                    dsReportes1.Lote.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsReportes1.Lote);
                    cn.Close();
                }


                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            //if (isGranel == 1)
            //{
            //    try
            //    {
            //        string query = @"[sp_rpt_print_detalle_lote_tarima_granel]";
            //        SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //        cn.Open();
            //        SqlCommand cmd = new SqlCommand(query, cn);
            //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@id_ingreso", Id);
            //        dsReportes1.Lote.Clear();
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        da.Fill(dsReportes1.Lote);
            //        cn.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        CajaDialogo.Error(ex.Message);
            //    }
            //}
            //else
            //{
               
            //}
            
        }

        public void load_lote_granel()
        {
            
        }
        private void ReportHeader1_BeforePrint(object sender, CancelEventArgs e)
        {
             

        }
    }
}
