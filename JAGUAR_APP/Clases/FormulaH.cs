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
    public class FormulaH
    {
        public FormulaH() { }

        public int id;
        public string codigo;
        public int version;
        public int tipo;
        public string tipo_nombre;
        public string nombre;
        public DateTime fecha_creado;
        public int id_user_creado;
        public string usuario_nombre;
        public string commentario;
        public int estado_id;
        public string estado_nombre;
        public DateTime available_date;
        public DateTime due_date;
        public bool Enable;
        public decimal Latas;
        public decimal Bolsas;

        public bool Recuperado;

        public string GenerarNextCodigo()
        {
            string val = "";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_codigo_for_formula_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", 2);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string prefijo = dr.GetString(0);
                    int id_siguiente = dr.GetInt32(1);
                    string numero = id_siguiente.ToString();
                    while (numero.Length < 3)
                    {
                        numero = "0" + numero;
                    }
                    val = prefijo + numero;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }

        public bool RecuperarRegistro(int pIdFormula)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_recuperar_registro_formula_H_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdFormula);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    codigo = dr.GetString(1);
                    version = dr.GetInt32(2);
                    tipo = dr.GetInt32(3);
                    tipo_nombre = dr.GetString(4);
                    nombre = dr.GetString(5);
                    fecha_creado = dr.GetDateTime(6);
                    id_user_creado = dr.GetInt32(7);
                    usuario_nombre = dr.GetString(8);
                    commentario = dr.GetString(9);
                    estado_id = dr.GetInt32(10);
                    estado_nombre = dr.GetString(11);
                    available_date = dr.GetDateTime(12);
                    due_date = dr.GetDateTime(13);
                    this.Enable = dr.GetBoolean(14);
                    Latas = dr.GetDecimal(15);
                    Bolsas = dr.GetDecimal(16);
                    //Boolean a = dr.GetBoolean(14);
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool FN_Update_cant_latas_Bolsas()
        {
            bool Res = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_set_update_formula_h_latas_bolsas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_formula_h", id);
                cmd.Parameters.AddWithValue("@cant_bolsas_por_lata", Bolsas);
                cmd.Parameters.AddWithValue("@cant_latas", Latas);
                cmd.ExecuteNonQuery();
                Res = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Res;
        }


    }
}
