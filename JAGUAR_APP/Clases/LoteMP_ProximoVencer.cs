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
    public class LoteMP_ProximoVencer
    {
        public LoteMP_ProximoVencer() { }
        public Int64 Linea;
        public string ItemCode;
        public string NombreComercial;
        public DateTime FechaVence;
        public int id_mp;
        public string LoteMP;
        public int Dias_para_Vencer;
        public bool Recuperado;


        public bool RecuperarRegistro(int pidmp)
        {
            bool val = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lista_lotes_mp_proximos_a_vencer_primeros_en_consumir", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pidmp);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Linea = dr.GetInt64(0);
                    if (!dr.IsDBNull(dr.GetOrdinal("itemcode")))
                        ItemCode = dr.GetString(1);

                    NombreComercial = dr.GetString(2);
                    FechaVence = dr.GetDateTime(3);
                    id_mp = pidmp;//4
                    LoteMP = dr.GetString(5);
                    Dias_para_Vencer = dr.GetInt32(6);

                    Recuperado= val = true;
                }
                dr.Close();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                val = false;
            }
            return val;
        }

    }
}
