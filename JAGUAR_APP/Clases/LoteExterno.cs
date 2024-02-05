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
    public class LoteExterno
    {
        public LoteExterno() { }

        int IdLote = 0;
        int Unidades = 0;
        string Lote = "";
        int Cantidad = 0;
        //int id_detalle = 0;
        DateTime FechaProduccion = DateTime.Now;
        DateTime FechaVencimiento = DateTime.Now;


        public bool GuardarLoteExterno()
        {
            bool val = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                cnx.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_lote_almacenes_externos", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@unidades", Unidades);
                cmd.Parameters.AddWithValue("@id_detalle", 0);
                cmd.Parameters.AddWithValue("@lote", Lote);
                cmd.Parameters.AddWithValue("@fecha_vencimiento", FechaVencimiento);
                cmd.Parameters.AddWithValue("@fecha_produccion", FechaProduccion);

                IdLote = Convert.ToInt32(cmd.ExecuteScalar());
                cnx.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }
    }
}
