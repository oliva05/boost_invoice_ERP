using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class MicroIngrediente
    {
        public MicroIngrediente() 
        {
            LoadConfig();
        }

        public decimal SetPointMezcladora;
        public void LoadConfig()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = "sp_get_config_micro_ingredientes";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SetPointMezcladora = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
