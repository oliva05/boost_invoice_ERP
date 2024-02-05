using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Mantenimientos.Proveedor.Model
{
   public class FacturaProveedor
    {
        public int ID { get; set; }
        public int ProveedorID { get; set; }
        public string Proveedor { get; set; }
        public int CAI_ID { get; set; }
        public string CAI { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
        public string NumeroFactura { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_factura_proveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID = pId;
                    ProveedorID = dr.GetInt32(1);
                    Proveedor = dr.GetString(2);
                    NumeroFactura = dr.GetString(3);
                    CAI_ID = dr.GetInt32(4);
                    CAI = dr.GetString(5);
                    Fecha = dr.GetDateTime(6);
                    UserId = dr.GetInt32(7); //dr.GetDouble(5);
                    User = dr.GetString(8); //dr.GetDouble(5);
                    FechaInicio = dr.GetDateTime(9); //dr.GetDouble(5);
                    FechaFin = dr.GetDateTime(10); //dr.GetDouble(5);
                    Recuperado = true;
                }
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
