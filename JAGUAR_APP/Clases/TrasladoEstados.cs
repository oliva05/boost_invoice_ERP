using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class TrasladoEstados
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool enable { get; set; }
        public bool Recuperado { get; set; }
        DataOperations dp;

        public enum EstadosTrasladosEnum
        {
            Borrador = 1,
            En_Recepcion = 2,
            Completado = 3,
            Cancelad = 4
        }

        // Constructor vacío
        public TrasladoEstados() 
        {
            dp = new DataOperations();
        }

        // Constructor que toma valores iniciales
        public TrasladoEstados(int id, string descripcion, bool enable)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.enable = enable;
        }

        // Función para recuperar un registro por ID
        public bool RecuperaRegistro(int id)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringJAGUAR_DB; // Reemplaza con tu cadena de conexión a la base de datos

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [dbo].[JAGUAR_traslado_h_estados] WHERE [id] = @id";

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

                            Recuperado = true;
                        }
                    }
                }
            }

            return Recuperado; // Si no se encuentra un registro con el ID dado
        }





    }
}
