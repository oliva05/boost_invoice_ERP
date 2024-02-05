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
   public class NotificacionesGenerales
    {
        public bool Recuperado { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Revision { get; set; }


        public bool ValidarVersionBuild(int major, int minor, int build, int revision ,int id_user)
        {
            try
            {
                string sql = "dbo.sp_get_versionBuild_notificacionesV2";
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand(sql, cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@major", System.Data.SqlDbType.Int).Value = major;
                    cmd.Parameters.Add("@minor", System.Data.SqlDbType.Int).Value = minor;
                    cmd.Parameters.Add("@build", System.Data.SqlDbType.Int).Value = build;
                    cmd.Parameters.Add("@revision", System.Data.SqlDbType.Int).Value = revision;
                    cmd.Parameters.Add("@id_user", System.Data.SqlDbType.Int).Value = id_user;

                    Recuperado = (bool)cmd.ExecuteScalar();
                    cnx.Close();
                }

                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        public bool ValidarNotificacionesSinLeer(int id_user)
        {

            try
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("sp_ALOSY_getNewNotificaciones", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = id_user;

                    Recuperado = (bool)cmd.ExecuteScalar();

                    cnx.Close();

                }

                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }

        }

        public void MarcarComoLeido(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_set_notificaciones_marcar_como_leido", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
