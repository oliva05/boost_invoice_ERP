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
    public class BannerTV_Tab
    {

        public bool Visible = false;
        public bool Recuperado = false;
        public int Id = 0;
        public int IdNextTab = 0;
        public int Interval = 0;
        public BannerTV_Tab()
        {

        }

        public bool RecuperarRegistro(int pIdTab)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_tab_banner_tv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tab", pIdTab);
                //cmd.Parameters.AddWithValue("@fecha_f", ultimoDia);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) 
                {
                    Id = dr.GetInt32(0);//Id
                    Visible = dr.GetBoolean(1);//visible
                    Id = dr.GetInt32(2);//Id tab
                    IdNextTab = dr.GetInt32(3);//id_tab_next
                    Interval = dr.GetInt32(4);//Interval
                    Recuperado = true;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }



    }
}
