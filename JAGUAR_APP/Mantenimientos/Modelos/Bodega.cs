using ACS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace JAGUAR_APP.Mantenimientos.Modelos
{
    public class Bodega
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public bool Enable { get; set; }
        public DateTime Fecha { get; set; }
        public bool Recuperado { get; set; }

        public Bodega()
        {
            Enable = true;
            Fecha = DateTime.Now;
        }

        public bool RecuperarRegistro(int pIdBod)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_dato_maestro_bodega", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_bodega", pIdBod);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Descripcion = dr.GetString(1);
                    DescripcionCorta = dr.GetString(2);
                    Enable = dr.GetBoolean(3);
                    Fecha = dr.GetDateTime(4);
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