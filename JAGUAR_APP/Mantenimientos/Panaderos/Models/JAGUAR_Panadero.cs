using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Mantenimientos.Panaderos.Models
{
   public class JAGUAR_Panadero
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioCreacionID { get; set; }
        public string UsuarioCreacion { get; set; }
        public int UsuarioModificacionID { get; set; }
        public string UsuarioModificacion { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_panadero", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = pId;
                    Nombre = dr.GetString(1);
                    Codigo = dr.GetString(2); //dr.GetDouble(5);
                    FechaCreacion = dr.GetDateTime(3);
                    FechaModificacion = dr.GetDateTime(4);
                    UsuarioCreacionID = dr.GetInt32(5);
                    UsuarioCreacion = dr.GetString(6);
                    UsuarioModificacionID = dr.GetInt32(7);
                    UsuarioModificacion = dr.GetString(8);
                    Recuperado = true;
                }
                dr.Close();
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
