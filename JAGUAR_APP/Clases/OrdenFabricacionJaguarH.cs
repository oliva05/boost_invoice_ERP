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
    public class OrdenFabricacionJaguarH
    {
        public Int64 id;
        public DateTime fecha;
        public int id_pt;
        public string ItemCode;
        public string ItemName;
        public int id_formula;
        public decimal cant_arrobas;
        public int id_grupo_panaderos;
        public string PanaderoName;
        public string lote;
        public bool enable;
        public DateTime date_row;
        public int id_user;
        public string UserName;
        public int id_estado;
        public string EstadoName;
        public decimal cant_latas;
        public decimal cant_bolsas;
        public string DocNum;
        public bool Recuperado;

        public OrdenFabricacionJaguarH()
        {
            Recuperado = false;
        }

        public bool RecuperarRegistro(int pIdOrdeFabricacion)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_clase_orden_fabricacion_jaguar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden_fabricacion", pIdOrdeFabricacion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt64(0);
                    fecha = dr.GetDateTime(1);
                    id_pt = dr.GetInt32(2);
                    ItemCode = dr.GetString(3);
                    ItemName = dr.GetString(4);
                    id_formula = dr.GetInt32(5);
                    cant_arrobas = dr.GetDecimal(6);
                    id_grupo_panaderos = dr.GetInt32(7);
                    PanaderoName = dr.GetString(8);
                    lote = dr.GetString(9);
                    enable = dr.GetBoolean(10);
                    date_row = dr.GetDateTime(11);
                    id_user = dr.GetInt32(12);
                    UserName = dr.GetString(13);
                    id_estado = dr.GetInt32(14);
                    EstadoName = dr.GetString(15);
                    cant_latas = dr.GetDecimal(16);
                    cant_bolsas = dr.GetDecimal(17);
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
