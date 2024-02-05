using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class OrdenProduccionH
    {
        DataOperations dp;
        public OrdenProduccionH()
        {
            dp = new DataOperations();
        }

        public Int64 Id;
        public int acs_id;
        public string OrderNumber;
        public int line_id; 
        public int fp_lot_number; 
		public int fp_id; 
		public int ext_fp_id; 
		public int ext_fml_id; 
		public string fml_code; 
		public int fml_version; 
		public DateTime created_date; 
		public int status; 
		public int plan_batch;
        public bool Recuperado;


        public bool RecuperarRegistro()
        {
            bool r = false; 
            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            try
            {
                string sql = @"";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt64(0);
                    acs_id = dr.GetInt32(1);
                    OrderNumber = dr.GetString(2);
                    line_id = dr.GetInt32(3);
                    fp_lot_number = dr.GetInt32(4);
                    fp_id = dr.GetInt32(5);
                    ext_fp_id = dr.GetInt32(6);
                    ext_fml_id = dr.GetInt32(7);
                    fml_code = dr.GetString(8);
                    fml_version = dr.GetInt32(9);
                    created_date = dr.GetDateTime(10);
                    status = dr.GetInt32(11);
                    plan_batch = dr.GetInt32(12);

                    Recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                conn.Close();
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }

       


    }
}
