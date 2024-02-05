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
   public class Proveedor_CAI
    {
        public int ID { get; set; }
        public int CorrelativoInicia { get; set; }
        public int CorrelativoTermina { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Leyenda { get; set; }
        public string CAI { get; set; }
        public int ProveedorID { get; set; }
        public string Proveedor { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_CAI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = pId;
                    CAI = dr.GetString(1);
                    FechaInicio = dr.GetDateTime(2);
                    FechaFin = dr.GetDateTime(3);
                    CorrelativoInicia = dr.GetInt32(4); //dr.GetDouble(5);
                    CorrelativoTermina = dr.GetInt32(5); //dr.GetDouble(5);
                    Leyenda = dr.GetString(6);
                    ProveedorID = dr.GetInt32(7);
                    Proveedor = dr.GetString(8);
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
