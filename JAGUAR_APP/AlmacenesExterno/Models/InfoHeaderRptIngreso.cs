using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.AlmacenesExterno.Models
{
    public class InfoHeaderRptIngreso
    {
        public InfoHeaderRptIngreso()
        {

        }

        #region miembros
        public string Proveedor;
        public string Direccion;
        public string Ciudad;
        public string Pais;
        public DateTime FechaIngreso;
        public bool Recuperado;
        #endregion

        public bool RecuperarRegistro(int Pid_h_ingreso)
        {
            try
            {
                DataOperations dp = new DataOperations();
               


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("sp_almacenes_externos_info_header_rpt", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_h", Pid_h_ingreso);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Proveedor = dr.GetString(0);
                        Direccion = dr.GetString(1);
                        Ciudad = dr.GetString(2);
                        Pais = dr.GetString(3);
                        FechaIngreso = dr.GetDateTime(4);
                        Recuperado = true;
                    }
                    dr.Close();
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }
    }

}
