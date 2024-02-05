using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using ACS.Classes;
using System.Data;

namespace JAGUAR_APP.Clases
{
    class Plan_Semanal
    {
        int id;
        int year;
        int week;
        DateTime date_begin;
        DateTime date_end;
        bool enable;
        DateTime date_created;
        int user_sing;
        DataOperations dp = new DataOperations();
        bool Obtuvimos_plan = false;
        DateTime date_to_create;
        bool cargado = false;
        int Default_value = 0;

        public int Id { get => id; set => id = value; }
        public int Year { get => year; set => year = value; }
        public int Week { get => week; set => week = value; }
        public DateTime Date_begin { get => date_begin; set => date_begin = value; }
        public DateTime Date_end { get => date_end; set => date_end = value; }
        public bool Enable { get => enable; set => enable = value; }
        public DateTime Date_created { get => date_created; set => date_created = value; }
        public int User_sing { get => user_sing; set => user_sing = value; }
        public DateTime Date_to_create { get => date_to_create; set => date_to_create = value; }
        public bool Cargado { get => cargado; set => cargado = value; }

        public Plan_Semanal(int id_semana)
        {
            Id = id_semana;
            if (Obtuvimos_plan = GET_Plan_Semanal())
            {    //obtivimos el plan ok. entonces vamos a obtener el detalle, pero en el formulario, por que aqui seria mucho relajo.
                Cargado = true;
            }
            else
            {
                CajaDialogo.Error("No se ha encontrado el plan en cuestion.");
            }

        }
        public Plan_Semanal()
        {
            Id = Default_value;
            Year = Default_value;
            Week = Default_value;
            User_sing = Default_value;
        }

        public bool Get_Week_Before_set(DateTime Date_propuesta)
        {
            Date_to_create = Date_propuesta;
            if (GET_Week_of_day())
            {
                LoadFechasSemana();
                return true;
            }
            else
            {
                CajaDialogo.Error("Ya existe una semana definida para esta fecha.");
                return false;
            }
        }

         private bool GET_Week_of_day()
        {
            string query = @"sp_get_week_of_day";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date_propost", Date_to_create);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Week = dr.GetInt32(0);
                Year = dr.GetInt32(1);
                return true;
            }

            dr.Close();
            cn.Close();
            return false;
        }

        private void LoadFechasSemana()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_inicio_and_fin_date_from_week", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@semana", Week);
                cmd.Parameters.AddWithValue("@anio", Year);
                //dsPlanMantoPrev1.distribucion_prev_manto.Clear();
                SqlDataReader dr = cmd.ExecuteReader();
                int conta = 0;
                while (dr.Read())
                {
                    if (conta == 0)
                        Date_begin = dr.GetDateTime(0);
                    else
                        Date_end = dr.GetDateTime(0);
                    conta++;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public bool GET_Plan_Semanal()
        {
            string Query = @"sp_get_plan_semanal";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query,cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_plan", Id);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Id = dr.GetInt32(0);
                Week = dr.GetInt32(1);
                Year = dr.GetInt32(2);
                date_begin = dr.GetDateTime(3);
                date_end = dr.GetDateTime(4);
                Enable = dr.GetBoolean(5);
                date_created = dr.GetDateTime(6);
                User_sing = dr.GetInt32(7);

                Obtuvimos_plan = true;
            }

            return Obtuvimos_plan;
        }

        public bool SetNewProductInWeek(int tipo, int id_pt)
        {
            string query = @"sp_set_new_product_into_week";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                cmd.Parameters.AddWithValue("@id_h", Id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                     
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
       
        public int set_new_plan()
        {
            string query = @"sp_set_new_week_plan";
            int id = 0;
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@week", Week);
                cmd.Parameters.AddWithValue("@year", Year);
                cmd.Parameters.AddWithValue("@date_begin", date_begin);
                cmd.Parameters.AddWithValue("@date_end", date_end);
                cmd.Parameters.AddWithValue("@user_creador", User_sing);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                return id;
            }
        }
    }
}
