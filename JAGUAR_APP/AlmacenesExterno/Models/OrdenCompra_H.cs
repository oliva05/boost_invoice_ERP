using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.AlmacenesExterno.Models
{
    public class OrdenCompra_H
    {
        public int ID { get; set; }
        public int DocNum { get; set; }
        public string CodProv { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Comentario { get; set; }
        public decimal Peso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int UserID { get; set; }
        public int DocEntrySAP { get; set; }
        public decimal Unidades { get; set; }
        public string Factura { get; set; }


        public bool RecuperarRegistro(int pDocNum)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_DocEntry_Pedido_by_DocNum", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocNum", pDocNum);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DocEntrySAP = dr.GetInt32(0);
                    r = true;
                }
                dr.Close();
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
