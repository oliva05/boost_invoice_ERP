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
    public class PlantaPrvTrz
    {
        int id_;
		string nombre_;
        string direccion_;
	    string comentario_;
		DateTime fechac_;
		bool enable_;
		int id_user_;
        string UsuarioName_;
        bool Recuperado_;

        public PlantaPrvTrz()
        {

        }

        public int Id { get => id_; set => id_ = value; }
        public string Nombre { get => nombre_; set => nombre_ = value; }
        public string Direccion { get => direccion_; set => direccion_ = value; }
        public string Comentario { get => comentario_; set => comentario_ = value; }
        public DateTime FechaCreado { get => fechac_; set => fechac_ = value; }
        public bool Enable { get => enable_; set => enable_ = value; }
        public int Id_user { get => id_user_; set => id_user_ = value; }
        public string UsuarioName { get => UsuarioName_; set => UsuarioName_ = value; }
        public bool Recuperado { get => Recuperado_; set => Recuperado_ = value; }

        public bool RecuperarRegistro(int pId)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_planta_prv_trz_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    nombre_ = dr.GetString(1);
                    direccion_ = dr.GetString(2);
                    comentario_ = dr.GetString(3);
                    fechac_ = dr.GetDateTime(4);
                    id_user_ = dr.GetInt32(5);
                    UsuarioName = dr.GetString(6);
                    Recuperado = r = true;
                }
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }
        public bool GuardarRegistro(string pCardCode)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_set_insert_planta_prv_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre_);
                cmd.Parameters.AddWithValue("@direccion", direccion_);
                cmd.Parameters.AddWithValue("@comentario", comentario_);
                cmd.Parameters.AddWithValue("@id_user", id_user_);
                cmd.Parameters.AddWithValue("@cardcode", pCardCode);
                cmd.ExecuteNonQuery();
                r = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }
        public bool UpdateRegistro(int pId)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_set_update_planta_prv_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre_);
                cmd.Parameters.AddWithValue("@direccion", direccion_);
                cmd.Parameters.AddWithValue("@comentario", comentario_);
                cmd.Parameters.AddWithValue("@id", pId);
                cmd.ExecuteNonQuery();
                r = true;
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
