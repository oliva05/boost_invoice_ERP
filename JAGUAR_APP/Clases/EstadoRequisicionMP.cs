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
    public class EstadoRequisicionMP
    {

        public int id;
        public string Descripcion;
        public bool Enable;
        public bool Recuperado;

        public EstadoRequisicionMP()
        {

        }
        
        public bool RecuperarRegistro(int pid)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_class_estado_requisicion_master_data", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (!dr.IsDBNull(dr.GetOrdinal("id")))
                        id = dr.GetInt32(0);

                    if (!dr.IsDBNull(dr.GetOrdinal("descripcion")))
                        Descripcion = dr.GetString(1);

                    if (!dr.IsDBNull(dr.GetOrdinal("enable")))
                        Enable = dr.GetBoolean(2);

                    Recuperado = true;
                }
                dr.Read();
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
