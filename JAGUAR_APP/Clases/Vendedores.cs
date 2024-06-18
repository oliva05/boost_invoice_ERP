using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class Vendedores
    {
        DataOperations dp = new DataOperations();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool? Enable { get; set; }
        public decimal? ComisionPorcentaje { get; set; }
        public int? UserIdCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UserIdLastModi { get; set; }
        public DateTime? FechaLastModi { get; set; }
        public bool Recuperado { get; set; }
        public string RTN { get; set; }

        public bool RecuperarRegistro(int pIdVendedor)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_vendedores_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVendedor", pIdVendedor);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id"));
                    Nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? null : reader.GetString(reader.GetOrdinal("nombre"));
                    Telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? null : reader.GetString(reader.GetOrdinal("telefono"));
                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString(reader.GetOrdinal("email"));
                    Enable = Convert.ToBoolean(reader.GetOrdinal("enable"));
                    ComisionPorcentaje = reader.IsDBNull(reader.GetOrdinal("comision_porcentaje")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("comision_porcentaje"));
                    UserIdCreacion = reader.IsDBNull(reader.GetOrdinal("user_id_creacion")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("user_id_creacion"));
                    FechaCreacion = reader.IsDBNull(reader.GetOrdinal("fecha_creacion")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("fecha_creacion"));
                    UserIdLastModi = reader.IsDBNull(reader.GetOrdinal("user_id_last_modi")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("user_id_last_modi"));
                    FechaLastModi = reader.IsDBNull(reader.GetOrdinal("fecha_last_modi")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("fecha_last_modi"));
                    RTN = reader.IsDBNull(reader.GetOrdinal("RTN")) ? null : reader.GetString(reader.GetOrdinal("RTN"));
                    Recuperado = true;
                }
            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }
    }
}
