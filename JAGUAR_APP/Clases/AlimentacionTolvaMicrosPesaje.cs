using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    class AlimentacionTolvaMicrosPesaje
    {
        public string CodigoPT { get; set; }
        public string Fecha { get; set; }
        public int BatchReal { get; set; }
        public int BatchPesados { get; set; }
        public int Lot { get; set; }
        public string Turno { get; set; }
        public string FML_Code { get; set; }
        public string Producto { get; set; }
        public int CodigoPesaje { get; set; }
        public int AMI_ID { get; set; }
        public int Id_orden { get; set; }
        public int Id_pesajeIndividualConf { get; set; }
        public int IdMP { get; set; }
        public bool Enable_ { get; set; }
        public decimal KgPorBatch { get; set; }
        public string CodigoBarra { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    string query = @"sp_get_class_micros_pesaje_individual_conf";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                    //cmd.Parameters.AddWithValue("@idmp", pIdMP);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Id_pesajeIndividualConf = dr.GetInt32(0);
                        Id_orden = dr.GetInt32(1);
                        if (!dr.IsDBNull(dr.GetOrdinal("idmp")))
                            IdMP = dr.GetInt32(2);
                        Enable_ = dr.GetBoolean(3);
                        KgPorBatch = dr.GetDecimal(4);
                        if (!dr.IsDBNull(dr.GetOrdinal("lote")))
                            Lot = dr.GetInt32(7);
                        CodigoBarra = pCodigoBarra;
                        Recuperado = true;
                    }
                    cnx.Close();
                }
                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                Recuperado = false;
                return Recuperado;
            }
        }

        public bool RecuperaRegistro(int ami_id, long order_id)
        {

            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx =  new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    string query = @"sp_load_op_reporte_detalle_micro_ingrediente";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ami_id", ami_id);
                    cmd.Parameters.AddWithValue("@id_orden", order_id);
                    //cmd.Parameters.AddWithValue("@id_orden", 1169);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        AMI_ID= dr.GetInt32(0);
                        //Fecha = string.Format("{0:dd/MM/yyyy}", dr.GetDateTime(1));
                        //Lot = dr.GetInt32(2);
                        //CodigoPT= dr.GetString(5);
                        //Turno = dr.GetString(7);
                        //FML_Code = dr.GetString(6);
                        //Producto = dr.GetString(4);
                        //CodigoPesaje = dr.GetInt32(9);
                        //BatchPesados = dr.GetInt32(8);
                        //txtnumero.Text = Pid.ToString();
                        Recuperado = true;
                    }

                    cnx.Close();
                }
            return Recuperado;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                Recuperado = false;
                return Recuperado;

            }

        }
    }


}
