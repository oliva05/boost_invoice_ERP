using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ACS.Classes;
using System.Windows.Forms;

namespace JAGUAR_APP.MigracionACS.Classes
{
    class OrdenesCombustible
    {
        #region Miembros    
        public bool recuperado;
        public int id;
        public string name;
        public string car;
        public string license_plate;
        public DateTime creation_date;
        public int fuel;
        public bool enable;
        #endregion
        string operacion = "";
        #region FuncionRecuperarDatos
        public bool RecuperarRegistos(int pid)
        {
            operacion = "select";
            recuperado = false;
            try
            {

                DataOperations dp = new DataOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                //conn.Open();

                //SqlCommand cmd = new SqlCommand("FuelOrderLoadPerfil", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@operacion", operacion);
                //cmd.Parameters.AddWithValue("@id", pid);

                string sql = @"SELECT [id] --0
                                     ,[name] --1
		                             ,[car] --2
		                             ,[license_plate] --3
		                             ,[creation_date] --4
                                     ,[enable] --5
		                             ,[fuel] --6
	                            FROM[dbo].[FuelOrders_Perfiles]
                                        where[id] = " + pid;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    name = dr.GetString(1);
                    car = dr.GetString(2);
                    license_plate = dr.GetString(3);
                    creation_date = dr.GetDateTime(4);
                    enable = dr.GetBoolean(5);
                    fuel = dr.GetInt32(6);
                    recuperado = true;
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return recuperado;
        }
        #endregion

        #region FuncionActualizar
        public bool ActualizarsiRegistros(int pid)
        {
            operacion = "update";
            bool actualizar;
            id = pid;

            actualizar = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("FuelOrderLoadPerfil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@operacion", operacion);
                cmd.Parameters.AddWithValue("@id", pid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@car", car);
                cmd.Parameters.AddWithValue("@license_plate", license_plate);
                cmd.Parameters.AddWithValue("@creation_date", creation_date);
                cmd.Parameters.AddWithValue("@fuel", fuel);
                cmd.Parameters.AddWithValue("@enable", enable);
                cmd.ExecuteNonQuery();
                conn.Close();


                actualizar = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return actualizar;
        }

        #endregion
    }
}
