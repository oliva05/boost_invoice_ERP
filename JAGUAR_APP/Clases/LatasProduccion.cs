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
    public class LatasProduccion
    {
        public Int64 id;
        public Int64 id_orden;
        public int id_pt;
        public string ItemCode;
        public string ItemName;
        public double cantidad_latas;
        public bool enable;
        public DateTime fecha_hora;
        public int id_user;
        public string UsuarioName;
        public string DocNum;
        public bool Recuperado;

        public LatasProduccion()
        {
        }

        public bool RecuperarRegistro(Int64 pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_select_class_latas_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = pId;
                    id_orden = dr.GetInt64(1);
                    id_pt = dr.GetInt32(2);
                    ItemCode = dr.GetString(3);
                    ItemName = dr.GetString(4);
                    cantidad_latas = (double)dr.GetDecimal(5); //dr.GetDouble(5);
                    enable = dr.GetBoolean(6);
                    fecha_hora = dr.GetDateTime(7);
                    id_user = dr.GetInt32(8);
                    UsuarioName = dr.GetString(9);
                    DocNum = dr.GetString(10);
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


        public bool InsertRegistro()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_set_insert_class_latas_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden", id_orden);
                cmd.Parameters.AddWithValue("@cantidad_latas", cantidad_latas);
                cmd.Parameters.AddWithValue("@id_user", id_user);
                id = Convert.ToInt64(cmd.ExecuteScalar());
                con.Close();

                if (id > 0)
                {
                    RecuperarRegistro(id);
                }
                
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }



    }
}
