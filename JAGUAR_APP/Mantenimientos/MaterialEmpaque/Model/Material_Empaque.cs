using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Mantenimientos.MaterialEmpaque.Model
{
   public class Material_Empaque
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Material { get; set; }
        public int PresentacionID { get; set; }
        public string Presentacion { get; set; }
        public decimal Factor { get; set; }
        public int UserID { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Recuperado  { get; set; }

        public bool RecuperaRegistroFromItemCode(string pItemCode)
        {
            DataOperations dp = new DataOperations();

            try
            {

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.[usp_get_selected_JAGUAR_MaterialEmpaqueFromItemCode]", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@itemCode", pItemCode);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = dr.GetInt32(0);
                        if (!dr.IsDBNull(dr.GetOrdinal("codigo")))
                            Codigo = dr.GetString(1);

                        if (!dr.IsDBNull(dr.GetOrdinal("nombre")))
                            Material = dr.GetString(2);

                        if (!dr.IsDBNull(dr.GetOrdinal("id_presentacion")))
                            PresentacionID = dr.GetInt32(3);

                        if (!dr.IsDBNull(dr.GetOrdinal("presentacion")))
                            Presentacion = dr.GetString(4);

                        if (!dr.IsDBNull(dr.GetOrdinal("factor")))
                            Factor = dr.GetDecimal(5);

                        if (!dr.IsDBNull(dr.GetOrdinal("id_user")))
                            UserID = dr.GetInt32(6);

                        if (!dr.IsDBNull(dr.GetOrdinal("usuario")))
                            Usuario = dr.GetString(7);

                        if (!dr.IsDBNull(dr.GetOrdinal("FechaCreacion")))
                            FechaCreacion = dr.GetDateTime(8);

                        if (!dr.IsDBNull(dr.GetOrdinal("FechaModificacion")))
                            FechaModificacion = dr.GetDateTime(9);

                        Recuperado = true;
                    }

                    cnx.Close();

                    return Recuperado;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        public bool RecuperaRegistro(int id)
        {
            DataOperations dp = new DataOperations();

            try
            {

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_JAGUAR_MaterialEmpaque", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value=id;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID = id;
                    Codigo = dr.GetString(1);
                    Material = dr.GetString(2);
                    PresentacionID = dr.GetInt32(3);
                    Presentacion = dr.GetString(4);
                    Factor = dr.GetDecimal(5);
                    UserID = dr.GetInt32(6);
                    Usuario = dr.GetString(7);
                    FechaCreacion = dr.GetDateTime(8);
                    FechaModificacion = dr.GetDateTime(9);
                    Recuperado = true;
                }
                
                cnx.Close();

                return Recuperado;
            }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }





    }
}
