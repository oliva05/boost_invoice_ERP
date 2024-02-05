using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Despachos;
using ACS.Classes;

namespace JAGUAR_APP.Despachos
{
    public partial class rpt_despacho : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public int Id_despacho;
        public rpt_despacho(int Pid)
        {
            InitializeComponent();
            Id_despacho = Pid;
            load_informacion();
            load_informacion_detalle();
            load_informacion_resumen();
        }
        public void load_informacion()
        {
            string query = @"rpt_load_data_despacho_header";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", Id_despacho);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtfecha.Text = dr.IsDBNull(0) ? "" : string.Format("{0:MM/dd/yyyy}", dr.GetDateTime(0));
                    txtmotorista.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    txtcedula.Text = dr.IsDBNull(2) ? "" : dr.GetString(2);
                    txtplaca.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    txtfurgon.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                    txttransporte.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    txtdestino.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    txtoc.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
                    txttotalUD.Text = dr.IsDBNull(8) ? 0.ToString() : dr.GetInt32(8).ToString();
                    txtunidades.Text = dr.IsDBNull(8) ? 0.ToString() : dr.GetInt32(8).ToString();
                    //txtfactor.Text = dr.IsDBNull(9) ? 0.ToString() : dr.GetInt32(9).ToString();
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_informacion_detalle()
        {
            string query = @"rpt_load_data_despacho_detalleV2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", Id_despacho);
                SqlDataAdapter da = new SqlDataAdapter(cmd);    
                ds_despachos1.lineas_despacho_rpt.Clear();
                da.Fill(ds_despachos1.lineas_despacho_rpt);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_informacion_resumen()
        {
            string query = @"rpt_load_data_despacho_resumenV2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", Id_despacho);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos1.resumen_despacho_rpt.Clear();
                da.Fill(ds_despachos1.resumen_despacho_rpt);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
