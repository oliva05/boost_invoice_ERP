using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using ACS.Classes;

namespace JAGUAR_APP.Requisiciones.Reportes
{
    public partial class lblNumeroReq : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        int ID; 
        public lblNumeroReq(int Pid, int pLote)
        {
            InitializeComponent();
            lblLotePT.Text = pLote.ToString();
            ID = Pid;
            load_data();
        }
        public void load_data()
        {
            string query = @"[dbo].[rpt_load_requisicion_header]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbldate.Text = dr.GetDateTime(2).ToString("dd/MM/yyyy"); 
                    lblnumeroSAP.Text = lblnumeroSAP.Text + dr.GetInt32(8).ToString();
                    lblNombreProducto.Text = "(" + dr.GetString(6) + ") - " + dr.GetString(7);
                    lblNumero.Text = lblNumero.Text + dr.GetInt32(0).ToString();
                    BarCode1.Text = dr.GetString(5);
                }
                dr.Close();
                cn.Close();
                cn.Open();
                query = @"[dbo].[rpt_load_data_requisicion_detalle]";
                cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                dSReportes1.requisicion_d.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dSReportes1.requisicion_d);
                cn.Close();

            }
            catch (Exception EX)
            {

                CajaDialogo.Error(EX.Message);
            }
            
        }
    }
}
