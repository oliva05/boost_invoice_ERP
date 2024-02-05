using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Facturacion.Mantenimientos.Models
{
   public class NumeracionFiscal
    {
        public int Id { get; set; }
        public int PDV_ID { get; set; }
        public string   PDV { get; set; }
        public string CAI { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVence { get; set; }
        public string NumeracionInicial { get; set; }
        public string NumeracionFinal { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreadoPorId { get; set; }
        public string  CreadoPor { get; set; }
        public int TipoDocumentoId { get; set; }
        public string TipoDocumento { get; set; }
        public bool GenCorr { get; set; }
        public int Correlativo { get; set; }
        public string Leyenda { get; set; }

        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int id) {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                using (SqlCommand cmd = new SqlCommand("dbo.uspGetNumeracionFiscalById", cnx))
                {
                    cnx.Open();

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value=id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Id = id;
                        PDV_ID = dr.GetInt32(1);
                        PDV = dr.GetString(2);
                        CAI = dr.GetString(3);
                        FechaEmision = dr.GetDateTime(4);
                        FechaVence = dr.GetDateTime(5);
                        NumeracionInicial = dr.GetString(6);
                        NumeracionFinal = dr.GetString(7);
                        EstadoId = dr.GetInt32(8);
                        Estado = dr.GetString(9);
                        FechaCreacion = dr.GetDateTime(10);
                        CreadoPorId = dr.GetInt32(11);
                        CreadoPor = dr.GetString(12);
                        TipoDocumentoId = dr.GetInt32(13);
                        TipoDocumento = dr.GetString(14);
                        GenCorr = dr.GetBoolean(15);
                        Correlativo = dr.GetInt32(16);
                        Leyenda = dr.GetString(17);
                        Recuperado = true;
                    }

                    cnx.Close();

                    return Recuperado;
                }

            }
            catch (Exception e)
            {
                CajaDialogo.Error(e.Message);
                return false;
            }
        
        
        }
    }
}
