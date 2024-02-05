using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ACS.Classes;

namespace JAGUAR_APP.Clases
{
    public class APMS_OrderProduction
    {
        public APMS_OrderProduction()
        {
            dp = new DataOperations();
        }
        DataOperations dp;
        public string order_code;
        public int line_id;
        public int fp_lot_number;
        public int fml_code;
        public int fml_version;
        public string prod_name;

        public bool RecupearRegistroFromLote(int pLote)
        {
            bool val = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();

                string sql = @"SELECT [order_code]
                                      ,[line_id]
                                      ,cast([fp_lot_number]as int)
                                      ,[fml_code]
                                      ,[fml_version]
                                      ,(select [long_name]
	                                    from [dbo].[MD_Finished_Products] A
		                                where A.id = [fp_id])as prod
                              FROM [APMS].[dbo].[OP_Production_Orders_Main]
                              where fp_lot_number = @lote";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", pLote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    order_code = dr.GetString(0);
                    line_id= dr.GetInt32(1);
                    fp_lot_number = dr.GetInt32(2);
                    fml_code = dr.GetInt32(3);
                    fml_version = dr.GetInt32(4);
                    prod_name = dr.GetString(5);
                    val = true;
                }
                dr.Close();
                conn.Close();
                return val;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                return false;
            }
        }

        public decimal GetHorasMaquinaFromId(int pidMaquina, int pIdRH)
        {
            decimal val = 0;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();

                string sql = @"SELECT [cant]
                                FROM [APMS].[dbo].[EQ_Maquinas_Horas_Periodo]
                                where acs_id_registro_detalle = @idh
		                            and id_maquina = @idlinea";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", pIdRH);
                cmd.Parameters.AddWithValue("@idlinea", pidMaquina);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    val = dr.GetDecimal(0);
                }
                dr.Close();
                conn.Close();
                return val;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                return 0;
            }
        }









    }

}
