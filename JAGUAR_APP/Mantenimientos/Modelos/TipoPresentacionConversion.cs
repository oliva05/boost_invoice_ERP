using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Mantenimientos.Modelos
{
   public class TipoPresentacionConversion
    {
        public int ConversacionId { get; set; }
        public int PresentacionOrigenID { get; set; }
        public string PresentacionOrigen { get; set; }
        public int PresentacionDestinoID { get; set; }
        public string PresentacionDestino { get; set; }
        public decimal Factor { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_tipo_conversion_kardex", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ConversacionId = pId;
                    PresentacionOrigenID = dr.GetInt32(1); //dr.GetDouble(5);
                    PresentacionOrigen = dr.GetString(2);
                    PresentacionDestinoID = dr.GetInt32(3);
                    PresentacionDestino = dr.GetString(4);
                    Factor = dr.GetDecimal(5);
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
