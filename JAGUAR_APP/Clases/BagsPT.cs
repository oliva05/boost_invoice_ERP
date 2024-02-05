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
    public class BagsPT
    {
        public bool recuperado;
        public string Descripcion;
        public decimal net;

        public BagsPT()
        {

        }


        public bool RecuperarRegistro(int pid)
        {
            recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_bags_pt_from_acs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Descripcion = dr.GetString(0);
                    net = dr.GetDecimal(1);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return recuperado;
        }
        public bool RecuperarRegistro_v2(int pid)
        {
            recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_load_pt_bags_v3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Descripcion = dr.GetString(0);
                    net = dr.GetDecimal(1);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return recuperado;
        }



    }
}
