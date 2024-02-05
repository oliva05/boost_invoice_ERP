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
    public class IngresoExternoH
    {
        public int id;
        public decimal peso;
        public string cardcode;
        public DateTime fecha_ingreso;
        public int id_user_creador;
        public bool enable;
        public int id_estado;
        public DateTime fecha_documento;
        public int DocEntrySAP;
        public decimal unidades;
        public string factura;
        public bool Recuperado;
        
        public IngresoExternoH()
        {
        }

        public bool RecuperarRegistro(int pIdH)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_ingreso_externo_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso_h", pIdH);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    peso = dr.GetDecimal(1);

                    if (!dr.IsDBNull(dr.GetOrdinal("cardcode")))
                        cardcode = dr.GetString(2);

                    fecha_ingreso = dr.GetDateTime(3);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_user_creador")))
                        id_user_creador = dr.GetInt32(4);
                    enable = dr.GetBoolean(5);

                    fecha_documento = dr.GetDateTime(6);

                    if (!dr.IsDBNull(dr.GetOrdinal("DocEntrySAP")))
                        DocEntrySAP = dr.GetInt32(7);

                    unidades = dr.GetDecimal(8);

                    if (!dr.IsDBNull(dr.GetOrdinal("factura")))
                        factura = dr.GetString(9);
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
