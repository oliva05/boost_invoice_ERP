using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using JAGUAR_APP.Clases;
using System.Data.SqlClient;

namespace JAGUAR_APP.Reportes
{
    
    public partial class rpt_cartillaMicro : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public string id_lote;

        public rpt_cartillaMicro(string Pid)
        {
            InitializeComponent();
            id_lote = Pid;
            load_data();
        }
        
        public void load_data()
        {
            string query = @"sp_load_rpt_cartilla";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", id_lote);
                SqlDataReader dr = cmd.ExecuteReader();     
                if (dr.Read())
                {
                    txtlote.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    //lotecopia.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    txtmp.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    //mpcopia.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    txtfechaIngreso.Text = dr.IsDBNull(7) ? "" : dr.GetDateTime(7).ToString("dd/MM/yyyy");
                    //fechaingresocopia.Text = dr.IsDBNull(7) ? "" : dr.GetDateTime(7).ToString("dd/MM/yyyy");
                    txtingreso.Text = dr.IsDBNull(4) ? "" : dr.GetInt32(4).ToString();
                    //txtingresoCopia.Text = dr.IsDBNull(4) ? "" : dr.GetInt32(4).ToString();
                    txtinicioconsumo.Text = dr.IsDBNull(8)  ? "" : dr.GetDateTime(8).ToString("dd/MM/yyyy");
                    //fechaconsumocopia.Text = dr.IsDBNull(8) ? "" : dr.GetDateTime(8).ToString("dd/MM/yyyy");
                    tolva.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    txttolva2.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    //tolvaCopia.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    txttolva2.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    txtfechavencimiento.Text = dr.IsDBNull(10) ? "" : dr.GetDateTime(10).ToString("dd/MM/yyyy");
                    //fechavenciminetocopia.Text = dr.IsDBNull(10) ? "" : dr.GetDateTime(10).ToString("dd/MM/yyyy");
                    //fechafinalconsumocopia.Text = dr.IsDBNull(9) ? "" : dr.GetDateTime(9).ToString("dd/MM/yyyy");
                    txtfinconsumo.Text = dr.IsDBNull(9) ? "" : dr.GetDateTime(9).ToString("dd/MM/yyyy");
                    txtsacos.Text = dr.IsDBNull(3) ? "" : dr.GetDecimal(3).ToString();
                    //cantidadcopia.Text = dr.IsDBNull(3) ? "" : dr.GetDecimal(3).ToString();
                    txtproveedor.Text = dr.IsDBNull(2) ? "" : dr.GetString(2);
                    //codigoCopia.Text = dr.IsDBNull(2) ? "" : dr.GetString(2);

                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

    }
}
