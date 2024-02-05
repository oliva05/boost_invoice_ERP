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
    class Ubicacion_Tarima
    {
        int _id;
        int _idTarima;
        //int _idUbicacion;
        string _pasillo;
        string _profundidad;
        string _altura;
        string _rack;
        int _idBodega;
        //int id_estado;
        bool _recuperado;

        public Ubicacion_Tarima()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Pasillo { get => _pasillo; set => _pasillo = value; }
        public string Profundidad { get => _profundidad; set => _profundidad = value; }
        public string Altura { get => _altura; set => _altura = value; }
        public string Rack { get => _rack; set => _rack = value; }
        public bool Recuperado { get => _recuperado; set => _recuperado = value; }
        public int IdTarima { get => _idTarima; set => _idTarima = value; }
        public int IdBodega { get => _idBodega; set => _idBodega = value; }

        public bool RecuperarRegistro(int pidTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ubicacion_tarima_from_idTarima", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTarima", pidTarima);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdTarima = dr.GetInt32(0);
                    //Pasillo = dr.GetString(1);
                    Rack = dr.GetString(1);
                    //Altura = dr.GetString(3);
                    //Profundidad = dr.GetString(4);
                    Id = dr.GetInt32(2);
                    IdBodega = dr.GetInt32(3);

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
        public bool RecuperarRegistro_2(int pidTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ubicacion_tarima_from_idTarima_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTarima", pidTarima);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdTarima = dr.GetInt32(0);
                    Rack = dr.GetString(1);
                    Id = dr.GetInt32(2);
                    IdBodega = dr.GetInt32(3);

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
