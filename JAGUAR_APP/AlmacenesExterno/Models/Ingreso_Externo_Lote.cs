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
    public class Ingreso_Externo_Lote
    {
        public int ID { get; set; }
        public string Lote { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Unidades { get; set; }
        public int NumLine { get; set; }
        public int Row_ { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaProduccion { get; set; }

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
                cmd.Parameters.AddWithValue("@id_detalle", DBNull.Value);
                cmd.Parameters.AddWithValue("@lote", Lote);
                cmd.Parameters.AddWithValue("@fecha_vencimiento", FechaVencimiento);
                cmd.Parameters.AddWithValue("@fecha_produccion", FechaProduccion);

                ID = Convert.ToInt32(cmd.ExecuteScalar());
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
