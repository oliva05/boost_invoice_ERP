using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class Boleta
    {
        int id;
        int _NumID;
        bool recuperado;
        string _furgon;
        string _placa_vehiculo;
        public Boleta()
        {
        }

        public int Id { get => id; set => id = value; }
        public int NumID { get => _NumID; set => _NumID = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public string Furgon { get => _furgon; set => _furgon = value; }
        public string Placa_vehiculo { get => _placa_vehiculo; set => _placa_vehiculo = value; }

        public bool RecuperarRegistro(int pIdSerial)
        {
            try
            {
                id = pIdSerial;
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                string sql = @"SELECT [id]
                                     ,[NumID]
                                     ,furgon
                                     ,vehiculo--placa cabezal o vehiculo
                                FROM [BASCULA].[dbo].[TS_in_and_out]tt
                                where tt.id = " + pIdSerial;
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this._NumID = dr.GetInt32(1);
                    this.Furgon = dr.GetString(2);
                    this.Placa_vehiculo = dr.GetString(3);
                }
                dr.Close();
                con.Close();
                recuperado = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return recuperado;
        }

        public bool RecuperarRegistroFromNumBoleta(int pNumBoleta)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                string sql = @"sp_get_numero_serie_from_num_boleta_pt";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_boleta", pNumBoleta);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                }
                dr.Close();
                con.Close();
                recuperado = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return recuperado;
        }



    }
}
