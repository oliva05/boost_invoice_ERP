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
    public class Cuentas
    {
        public Cuentas()
        { 
        
        }
        DataOperations dp = new DataOperations();
        public int IdTitular { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Identidad { get; set; }
        public string RTN { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UserCreador { get; set; }
        public bool Activo { get; set; }
        public string Usuario { get; set; }

        bool Recuperado;

        public bool RecuperarRegistrosTitualarById(int pIdTitular) 
        {
            Recuperado = false;


            try
            {
                string query = @"sp_get_titular_cuenta_byId";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTitular", pIdTitular);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdTitular = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    Telefono = dr.IsDBNull(2) ? "" : dr.GetString(2);
                    Correo = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    Identidad = dr.IsDBNull(4) ? "" : dr.GetString(4);
                    RTN = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    FechaCreacion = dr.GetDateTime(6);
                    UserCreador = dr.GetInt32(7);
                    Activo = dr.IsDBNull(8) ? false : dr.GetBoolean(8);
                    Usuario = dr.GetString(9);
                    
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Recuperado;
        }


    }
}
