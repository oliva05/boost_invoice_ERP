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
    public class BinGranel
    {
        public string LoteMP;
        public int IdLote;
        public int IdLoteBinGranel;


        public enum TipoBin
        {
            Modulo = 1,
            Silo = 2
        }

        public enum Bin
        {
            Silo1 = 180,
	        Silo2 = 181,
            Silo3 = 182,
            Silo4 = 183,
            Modulo1 = 184,
	        Modulo2	= 185,
	        Modulo3	= 186,
        	Modulo4	= 187
        }

        public Bin BinIdActual;
        public TipoBin TipoBinActual;
        public bool Recuperado;

        public BinGranel()
        {

        }

        public bool RecuperaRegistro(TipoBin pTipo, Bin pBin)
        {
            TipoBinActual = pTipo;
            BinIdActual = pBin;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_datos_bin_granel_LOSA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ubicacion", (int)pBin);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdLoteBinGranel = dr.GetInt32(0);
                    IdLote = dr.GetInt32(1);
                    LoteMP = dr.GetString(2);
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
