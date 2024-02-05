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
    public class PresentacionX
    {
        public PresentacionX()
        {

        }

        int id;
        string descripcion;
        bool enable;
        DateTime fecha;
        decimal factor;
        bool _Recuperado;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Enable { get => enable; set => enable = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Factor { get => factor; set => factor = value; }
        public bool Recuperado { get => _Recuperado; set => _Recuperado = value; }

        public bool RecuperarRegistro(int pId)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_presentacion_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = pId;
                    descripcion = dr.GetString(1);
                    enable = dr.GetBoolean(2);
                    fecha = dr.GetDateTime(3);
                    factor = dr.GetDecimal(4);
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

        public decimal Factor_conversion(int pIdPresentacionOrigen, int pIdPresentacionDestino)
        {
            decimal factor = 1;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_get_factor_conversion_ud_jaguar_recepcion_facturas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_presentacion_origen", pIdPresentacionOrigen);
                cmd.Parameters.AddWithValue("@id_presentacion_destino", pIdPresentacionDestino);
                factor = dp.ValidateNumberDecimal(cmd.ExecuteScalar());

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return factor;
        }



    }
}
