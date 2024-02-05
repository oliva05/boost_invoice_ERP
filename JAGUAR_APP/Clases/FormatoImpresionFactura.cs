using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{

    public class FacturacionFormatoImpresion
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool enable { get; set; }
        public int order_force { get; set; }
        public bool Recuperado { get; set; }

        DataOperations dp { get; set; }

        // Constructor vacío
        public FacturacionFormatoImpresion() 
        {
            dp = new DataOperations();
        }

        // Constructor que toma valores iniciales
        public FacturacionFormatoImpresion(int id, string descripcion, bool enable, int order_force)
        {
            dp = new DataOperations();
            this.id = id;
            this.descripcion = descripcion;
            this.enable = enable;
            this.order_force = order_force;
        }

        // Función para recuperar un registro por ID
        public bool RecuperarRegistro(int id)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringJAGUAR_DB; // Reemplaza con tu cadena de conexión a la base de datos

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [dbo].[Facturacion_formatos_impresion] WHERE [id] = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["id"]);
                            descripcion = reader["descripcion"].ToString();
                            enable = Convert.ToBoolean(reader["enable"]);
                            order_force = Convert.ToInt32(reader["order_force"]);
                            Recuperado = true;
                        }
                    }
                }
            }

            return Recuperado; // Si no se encuentra un registro con el ID dado
        }
    }
}
