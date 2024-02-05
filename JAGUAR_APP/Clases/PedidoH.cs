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
    public class PedidoH
    {
        public PedidoH()
        {
            Recuperado = false;
        }

        public int id;
        public DateTime Fecha;
        public DateTime FechaRow;
        public int id_user;
        public bool enable;
        public string Comentario;
        //public int DocNum;
        public string DocNum;
        public int ClienteID;
        public int ID_Estado;
        public string EstadoName;
        public bool Recuperado;

        public bool RecuperarRegistro(int pidH)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.jaguar_sp_get_class_pedido_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pidH);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = pidH;
                    Fecha = dr.GetDateTime(1);
                    FechaRow = dr.GetDateTime(2);
                    id_user = dr.GetInt32(3);
                    enable = dr.GetBoolean(4);
                    if (!dr.IsDBNull(dr.GetOrdinal("comentario")))
                        Comentario = dr.GetString(5);
                    
                    //DocNum = dr.GetInt32(6);
                    ClienteID = dr.GetInt32(7);
                    ID_Estado = dr.GetInt32(8);
                    EstadoName = dr.GetString(9);
                    DocNum = dr.GetString(10);
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
