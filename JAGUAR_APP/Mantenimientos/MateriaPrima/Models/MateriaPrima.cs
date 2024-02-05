using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Mantenimientos.MateriaPrima.Models
{
   public class MateriaPrima
    {
        public int ID { get; set; }
        public string NombreComercial { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaCreado { get; set; }
        public int TipoID { get; set; }
        public string TipoMP { get; set; }
        public int EstadoID { get; set; }
        public string Estado { get; set; }
        public int TipoPresentacionID { get; set; }
        public string TipoPresentacionNombre { get; set; }
        public bool AplicaCosto { get; set; }
        public int UserID { get; set; }
        public string User { get; set; }
        public decimal  Factor { get; set; }
        public bool Recuperado { get; set; }


        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_MP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = pId;
                    NombreComercial = dr.GetString(1);
                    AplicaCosto= dr.GetBoolean(2);
                    FechaCreado= dr.GetDateTime(3);
                    UserID= dr.GetInt32(4);
                    User= dr.GetString(5);
                    Nombre = dr.GetString(6);
                    Codigo = dr.GetString(7); //dr.GetDouble(5);
                    TipoID = dr.GetInt32(8);
                    TipoMP = dr.GetString(9);
                    EstadoID = dr.GetInt32(10);
                    Estado = dr.GetString(11);
                    TipoPresentacionID = dr.GetInt32(12);
                    TipoPresentacionNombre = dr.GetString(13);
                    Factor = dr.GetDecimal(14);
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
