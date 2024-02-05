using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
  public  class Traslado
    {
        public Int64 ID { get; set; }
        public int IdPuntoVenta { get; set; }
        public string CodigoPuntoVenta { get; set; }
        public string CodigoTraslado { get; set; }
        public string NombrePuntoVenta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
        public bool Recuperado { get; set; }
        DataOperations dp;

        public Traslado()
        {
            dp = new DataOperations();
        }

        public bool UpdateIdEstadoById(Int64 pIdTraslado, int pIdEstado)
        {
            bool res = false;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                string query = "UPDATE dbo.JAGUAR_traslado_h SET id_estado = @IdEstado WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdEstado", pIdEstado);
                cmd.Parameters.AddWithValue("@Id", pIdTraslado);

                cmd.ExecuteNonQuery();
                res = true;
            }
            return res;
        }

        public  bool RecuperaRegistro(Int64 Id)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                cnx.Open();
                SqlCommand cmd = new SqlCommand("dbo.[uspGetTraslado_H]", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Id;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ID = Id;
                    CodigoTraslado = dr.GetString(1);
                    IdPuntoVenta = dr.GetInt32(2);
                    CodigoPuntoVenta = dr.GetString(3);
                    NombrePuntoVenta = dr.GetString(4);
                    FechaCreacion = dr.GetDateTime(5);
                    Observacion = dr.GetString(6);
                    Recuperado = true;
                }
                cnx.Close();
                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            return false;
            }
        }
    }
}
