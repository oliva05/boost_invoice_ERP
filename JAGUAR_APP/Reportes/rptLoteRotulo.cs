using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using System.Data.SqlClient;

namespace JAGUAR_APP.Reportes
{
    public partial class rptLoteRotulo : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public int Id_detalle, numero_transaccion;
        public string lote;
        bool isganel = false;
        public rptLoteRotulo(int pId)
        {
            InitializeComponent();
            isganel = false;
            Id_detalle = pId;
            load_data();

        }

        public rptLoteRotulo(int pnumero_transaccion, string plote)
        {
            InitializeComponent();
            isganel = false;
            //Id_detalle = pId;
            numero_transaccion = pnumero_transaccion;
            lote = plote;
            load_data_for_lote();

        }

        private void load_data_for_lote()
        {
            
            string query = @"rpt_load_informacion_ingreso_loteV2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@iddetalle", Id_detalle);
                cmd.Parameters.AddWithValue("@numero_transaccion", numero_transaccion);
                cmd.Parameters.AddWithValue("@lote", lote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    txtmp.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    txtproveedor.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    txtfechaIng.Text = dr.IsDBNull(2) ? "" : dr.GetDateTime(2).ToString("dd/MM/yyyy");
                    txtingreso.Text = dr.IsDBNull(3) ? "" : dr.GetInt32(3).ToString();
                    txtsacos.Text = dr.IsDBNull(4) ? "" : dr.GetDecimal(4).ToString();
                    txtfproduccion.Text = dr.IsDBNull(5) ? "" : dr.GetDateTime(5).ToString("dd/MM/yyyy");
                    txtfvencimiento.Text = dr.IsDBNull(6) ? "" : dr.GetDateTime(6).ToString("dd/MM/yyyy");
                    txtrack.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
                    txtlote.Text = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    txtCodigos.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public rptLoteRotulo(int pId, bool granel)
        {
            InitializeComponent();
            isganel = granel;
            Id_detalle = pId;
            load_data();

        }

        private void rptLoteRotulo_AfterPrint(object sender, EventArgs e)
        {
            this.ClosePreview();
        }

        public void load_data()
        {
            string query = @"rpt_load_informacion_ingreso_lote";
            if (isganel)
            {
                query = @"rpt_load_informacion_ingreso_lote_granel";
            }
            else
            {
                query = @"rpt_load_informacion_ingreso_lote";
            }       
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddetalle", Id_detalle);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                     txtmp.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                     txtproveedor.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                     txtfechaIng.Text = dr.IsDBNull(2) ? "" : dr.GetDateTime(2).ToString("dd/MM/yyyy");
                     txtingreso.Text = dr.IsDBNull(3) ? "" : dr.GetInt32(3).ToString();
                     txtsacos.Text = dr.IsDBNull(4) ? "" : dr.GetDecimal(4).ToString(); 
                      txtfproduccion.Text = dr.IsDBNull(5) ? "" : dr.GetDateTime(5).ToString("dd/MM/yyyy");
                     txtfvencimiento.Text = dr.IsDBNull(6) ? "" : dr.GetDateTime(6).ToString("dd/MM/yyyy");
                    txtrack.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
                    txtlote.Text = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    txtCodigos.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex) 
            {

                CajaDialogo.Error(ex.Message);
            }

        }

    }
}
