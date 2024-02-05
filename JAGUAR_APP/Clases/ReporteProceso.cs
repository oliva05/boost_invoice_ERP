using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class ReporteProceso
    {
        public ReporteProceso()
        {

        }

        public int id;
        public string Name;
        public string StoredProcedure;
        public bool enable;
        public int tipo;
        public bool Recuperado;

        public bool RecuperarRegistro(int pid)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_row_reporte_proceso", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    Name = dr.GetString(1);
                    StoredProcedure = dr.GetString(2);
                    enable = dr.GetBoolean(3);
                    tipo = dr.GetInt32(4);
                    Recuperado = true;
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }





    }
}
