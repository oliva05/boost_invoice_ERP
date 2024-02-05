using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.Classes;
using JAGUAR_APP.Clases;
using System.Data.SqlClient;

namespace JAGUAR_APP.Clases
{                  
    class SelectorFor
    {
        private int camino;
        private int iD_Formulario;
        DataOperations dp = new DataOperations();
        public SelectorFor(int ID) 
        {
            iD_Formulario = ID;
            Obtener_path();

        }
         public void Obtener_path()
        {
            string query = @"sp_get_camino_configurado";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID_Formulario);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Camino = dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        

        public int Camino { get => camino; set => camino = value; }
        public int ID_Formulario { get => iD_Formulario; set => iD_Formulario = value; }
    }
}
