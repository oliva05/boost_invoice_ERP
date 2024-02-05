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
    public class IngresoExternoD
    {
        public string BodegaIn;
        public int DocEntrySAP;

        public IngresoExternoD()
        {
            BodegaIn = "";
            DocEntrySAP = 0;
        }


        public bool RecuperaRegistroInFromIdIngresoH_and_MP_Code(int pidh)
        {
            bool val = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmdh = new SqlCommand("sp_get_clase_IngresoExternoD", cn);
                cmdh.CommandType = CommandType.StoredProcedure;
                //cmdh.Transaction = transaction;
                cmdh.Parameters.AddWithValue("@id_ingreso_h", pidh);
                //cmdh.Parameters.AddWithValue("@itemCode", pItemCode);
                SqlDataReader dr = cmdh.ExecuteReader();
                if (dr.Read())
                {
                    val = true;
                    if (!dr.IsDBNull(dr.GetOrdinal("bodega_in")))
                        BodegaIn = dr.GetString(0);

                    if (!dr.IsDBNull(dr.GetOrdinal("DocEntrySAP")))
                        DocEntrySAP = dr.GetInt32(1);
                    else
                        DocEntrySAP = 0;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }







    }


   
}
