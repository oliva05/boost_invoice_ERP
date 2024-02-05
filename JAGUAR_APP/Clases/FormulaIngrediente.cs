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
    public class FormulaIngrediente
    {
        public FormulaIngrediente()
        {
        }

        public int id;
        public int id_formula_h;
        public int id_mp;
        public int id_me;
        public string ItemCode;
        public string ItemName;
        public decimal inclusion;
        public decimal peso_batch;
        public int tipo;
        public bool enable;
        public int id_presentacion;
        public string PresentacionName;
        public bool Recuperado;

        public bool Validar_MP_InFormula(int pIdFormula, int pIdIngrediente)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_validar_si_mp_ya_esta_en_formula", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_formula", pIdFormula);
                cmd.Parameters.AddWithValue("@id_mp", pIdIngrediente);
                int val = Convert.ToInt32(cmd.ExecuteScalar());
                if (val > 0)
                    r = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }

        public bool RecuperarRegistro(int pIdIngrediente)
        {
            Recuperado = false;
            string sql = @"	SELECT A.id 
                                ,id_formula_h
                                ,id_mp
	                            ,case when D.tipo = 8 then
		                            coalesce(E.[nombre],'N/D')
	                            else 
		                            coalesce(B.nombre,'N/D')
	                            end as nombre
                                ,coalesce(inclusion,0)as inclusion
                                ,peso_batch
                                ,coalesce(A.tipo,0)as tipo
                                ,A.enable 
	                            ,A.[id_presentacion]
	                            ,coalesce(C.descripcion,'N/D')as descripcion
	                            ,case when D.tipo = 8 then
		                            coalesce(E.[codigo],'N/D')
	                            else 
		                            coalesce(B.[code],'N/D')
	                            end as codigo
                                ,A.id_me
                            FROM JAGUAR_DB.codesahn.FML_Formulas_D A left join
	                            [ACS].[MP_MateriasPrimas]B 
	                            on A.id_mp = B.id left join
	                            [dbo].[LOSA_tipo_presentacion]C
	                            on C.id = A.id_presentacion
	                            join [codesahn].[FML_Formulas_H] D
	                            on D.id = A.id_formula_h
	                            left join [dbo].[JAGUAR_MaterialEmpaque] E
	                            on A.id_me = E.id
                            where A.id = @id_ingrediente;";

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id_ingrediente", pIdIngrediente);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = pIdIngrediente;
                    id_formula_h = dr.GetInt32(1);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_mp")))
                        id_mp = dr.GetInt32(2);

                    ItemName = dr.GetString(3);
                    inclusion = dr.GetDecimal(4);
                    peso_batch = dr.GetDecimal(5);
                    tipo = dr.GetInt32(6);
                    enable = dr.GetBoolean(7);
                    id_presentacion = dr.GetInt32(8);
                    PresentacionName = dr.GetString(9);
                    ItemCode = dr.GetString(10);
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("id_me")))
                        id_me = dr.GetInt32(11);

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

    }
}
