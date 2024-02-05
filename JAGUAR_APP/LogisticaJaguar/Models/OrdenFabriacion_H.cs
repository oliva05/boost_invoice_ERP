using ACS.Classes;
using DevExpress.Xpo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace JAGUAR_APP.LogisticaJaguar.Models
{
    public class OrdenFabriacion_H : XPObject
    {

        public long ID { get; set; }
        public int PT_ID { get; set; }
        public string DocNum { get; set; }
        public int GrupoPanaderoID { get; set; }
        public string GrupoPanadero { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Presentacion { get; set; }
        public int EstadoID { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaFila { get; set; }
        public decimal CantidadArrobas { get; set; }
        public decimal CantidadBolsasPlan { get; set; }
        public decimal CantidadLatasPlan { get; set; }  
        public decimal CantidadBolsasReal { get; set; }
        public decimal CantidadLatasReal { get; set; }
        public decimal CostoPorBolsa { get; set; }
        public decimal CostoTotal { get; set; }
        public decimal CostoMO { get; set; }
        public int UserID { get; set; }
        public string Usuario { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(long pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_get_selected_orden_fabricacion_V3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = pId;
                    Fecha = dr.GetDateTime(1); //dr.GetDouble(5);
                    PT_ID = dr.GetInt32(2);
                    ItemCode = dr.GetString(3);
                    ItemName = dr.GetString(4);
                    CantidadArrobas = dr.GetDecimal(6);
                    GrupoPanaderoID = dr.GetInt32(7);
                    GrupoPanadero = dr.GetString(8);
                    FechaFila = dr.GetDateTime(11);
                    UserID = dr.GetInt32(12);
                    Usuario = dr.GetString(13);
                    EstadoID = dr.GetInt32(14);
                    Estado = dr.GetString(15);
                    CantidadLatasPlan = dr.GetDecimal(16);
                    CantidadBolsasPlan = dr.GetDecimal(17);
                    DocNum = dr.GetString(18);
                    CantidadBolsasReal= dr.GetDecimal(20);
                    CantidadLatasReal= dr.GetDecimal(21);
                    Presentacion= dr.GetString(22);
                    CostoPorBolsa= dr.GetDecimal(23);
                    //CostoTotal= dr.GetDecimal(24);
                    CostoMO = dr.GetDecimal(25);
                    CostoTotal = dr.GetDecimal(26);
                    Recuperado = true;
                }
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