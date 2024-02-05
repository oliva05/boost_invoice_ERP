using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Clases
{
    public class ItemMP_Lote
    {
        public string ItemCode;
        public string Card_Name;
        public string Lote;
        public int IdLote;
        public DateTime FechaProd;
        public DateTime FechaVence;
        public int DocEntry;
        public string factura;
        public ItemMP_Lote()
        {
        }
        
        public bool RecuperarRegistro(int pId)
        {
            bool a = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();

                string SQL = @"sp_get_lote_activo_granel_from_id";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    FechaProd = dr.GetDateTime(8);
                    FechaVence = dr.GetDateTime(9);
                    a = true;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return a;
        }

        
        public bool RecuperarRegistroForID_Lote_Externo(int pId)
        {
            bool a = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();

                string SQL = @"sp_get_granel_en_ingreso_externo";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote_externo", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    FechaProd = dr.GetDateTime(0);
                    FechaVence = dr.GetDateTime(1);
                    Lote = dr.GetString(2);
                    DocEntry = dr.GetInt32(3);
                    factura = dr.GetString(4);
                    a = true;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return a;
        }
    }
}
