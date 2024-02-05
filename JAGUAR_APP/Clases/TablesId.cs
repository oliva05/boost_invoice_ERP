using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraRichEdit.Export.Doc;

namespace JAGUAR_APP.Clases
{
    public  class TablesId
    {
        public int Id { get; set; }
        public string NameTableOrSecuence { get; set; }
        public string NextCode { get; set; }
        public TablesId() { }
        public bool RecuperarSiguienteCodigoFromId_table(int pIdTable) 
        {
            bool r = false;
            string codigo_var = "N/D";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_siguiente_codigo_tables_id]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_table", pIdTable);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = pIdTable;
                    NameTableOrSecuence = dr.GetString(0);
                    NextCode = codigo_var = dr.GetString(1);
                    r = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }
    }
}
