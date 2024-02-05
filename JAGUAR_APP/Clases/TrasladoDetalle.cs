using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class TrasladoDetalle
    {
        public long Id { get; set; }
        public long IdH { get; set; }
        public int? IdPt { get; set; }
        public string ItemCode { get; set; }
        public string Lote { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool Enable { get; set; }
        public bool Recuperado { get; set; }
        DataOperations dp;
        // Constructor por defecto
        public TrasladoDetalle() 
        {
            dp = new DataOperations();
        }

        // Método para llenar las propiedades desde un query a la tabla usando el campo id
        public bool RecuperarRegistro(long id)
        {
            Recuperado = false;

            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                string query = "SELECT * FROM dbo.JAGUAR_traslado_d WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        Id = (long)reader["id"];
                        IdH = (long)reader["id_h"];
                        IdPt = reader["id_pt"] as int?;
                        ItemCode = reader["ItemCode"] as string;
                        Lote = reader["lote"] as string;
                        Cantidad = reader["cantidad"] as decimal?;
                        CreateDate = reader["create_date"] as DateTime?;
                        Enable = (bool)reader["enable"];
                        Recuperado = true;
                    }
                }
            }

            return Recuperado;
        }
    }
}
