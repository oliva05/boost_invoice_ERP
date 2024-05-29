using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.Classes;

namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string RTN { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int UserId { get; set; }
        public string Usuario { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }
        public int IdCliente { get; set; }
        public int PuntoVentaId { get; set; }
        public string NumCotizacion { get; set; }
        public bool RecuperarRegistro(int id)
        {
            bool Recuperado = false;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_cotizaciones_clases", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Cliente = dr.GetString(1);
                    RTN = dr.GetString(2);
                    Direccion = dr.GetString(3);
                    Contacto = dr.GetString(4);
                    Email = dr.GetString(5);
                    Telefono = dr.GetString(6);
                    FechaEmision = dr.GetDateTime(7);
                    FechaVencimiento = dr.GetDateTime(8);
                    UserId = dr.GetInt32(9);
                    Usuario = dr.GetString(10);
                    IdEstado = dr.GetInt32(11);
                    Estado = dr.GetString(12);
                    SubTotal = dr.GetDecimal(13);
                    Descuento = dr.GetDecimal(14);
                    ISV = dr.GetDecimal(15);
                    Total = dr.GetDecimal(16);
                    NumCotizacion = dr.GetString(17);
                    PuntoVentaId = dr.GetInt32(18);
                    IdCliente = dr.GetInt32(19);
                    Recuperado = true;
                    
                }
                conn.Close();
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                Recuperado = false;
            }

            return Recuperado;
        }
    }

    


}
