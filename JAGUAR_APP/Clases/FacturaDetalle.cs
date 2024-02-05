using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ACS.Classes;

namespace JAGUAR_APP.Clases
{

    public class FacturaDetalle
    {
        public long Id { get; set; }
        public long IdFacturaH { get; set; }
        public int IdPt { get; set; }
        public string ItemCode { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal Impuesto3 { get; set; }
        public decimal TotalLinea { get; set; }
        public bool Enable { get; set; }
        public bool Recuperado { get; set; }
        DataOperations Dp;

        public FacturaDetalle() 
        {
            Dp = new DataOperations();
        }


        public bool RecuperarRegistro(Int64 pIdDetalle)
        {
            bool success = false;

            string connectionString = Dp.ConnectionStringJAGUAR_DB;
            string query = "dbo.sp_get_factura_detalle_class_from_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pIdDetalle", pIdDetalle);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            Id = reader.GetInt64(reader.GetOrdinal("id"));
                            IdFacturaH = (long)(reader.IsDBNull(reader.GetOrdinal("id_facturaH")) ? 0 : (long?)reader.GetInt64(reader.GetOrdinal("id_facturaH")));
                            IdPt = (int)(reader.IsDBNull(reader.GetOrdinal("id_pt")) ? 0 : (int?)reader.GetInt32(reader.GetOrdinal("id_pt")));
                            ItemCode = reader.IsDBNull(reader.GetOrdinal("item_code")) ? "N/D" : reader.GetString(reader.GetOrdinal("item_code"));
                            Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? "N/D" : reader.GetString(reader.GetOrdinal("descripcion"));
                            Cantidad = (decimal)(reader.IsDBNull(reader.GetOrdinal("cantidad")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("cantidad")));
                            Precio = (decimal)(reader.IsDBNull(reader.GetOrdinal("precio")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("precio")));
                            Descuento = (decimal)(reader.IsDBNull(reader.GetOrdinal("descuento")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("descuento")));
                            Impuesto1 = (decimal)(reader.IsDBNull(reader.GetOrdinal("impuesto1")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("impuesto1")));
                            Impuesto2 = (decimal)(reader.IsDBNull(reader.GetOrdinal("impuesto2")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("impuesto2")));
                            Impuesto3 = (decimal)(reader.IsDBNull(reader.GetOrdinal("impuesto3")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("impuesto3")));
                            TotalLinea = (decimal)(reader.IsDBNull(reader.GetOrdinal("total_linea")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("total_linea")));
                            Enable = (bool)(reader.IsDBNull(reader.GetOrdinal("enable")) ? false : (bool?)reader.GetBoolean(reader.GetOrdinal("enable")));
                            
                            success = true;
                        }
                        reader.Close();
                    }
                }
            }
            Recuperado = success;
            return success;
        }

        public List<FacturaDetallePropiedades> factura_detalle = new List<FacturaDetallePropiedades>(); 
        public bool RecuperaDetallFactura(long FacturaId)
        {

            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            factura_detalle = new List<FacturaDetallePropiedades>();

            using (SqlCommand cmd = new SqlCommand("ObtenerDetalleFacturaByIdFactura", cnx))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_factura",FacturaId);
                cnx.Open();
                factura_detalle = new List<FacturaDetallePropiedades>();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    factura_detalle.Add(new FacturaDetallePropiedades
                    {
                        FacturaId = Convert.ToInt64(dr["id"].ToString()),
                        FacturaDetalleId = Convert.ToInt64(dr["id_facturaH"].ToString()),
                        Cantidad = Convert.ToDecimal(dr["cantidad"].ToString()),
                        Precio = Convert.ToDecimal(dr["precio"].ToString()),
                        TotalLinea = Convert.ToDecimal(dr["total_linea"].ToString()),
                        Descripcion = dr["descripcion"].ToString(),
                        NumeroDocumento = dr["numero_documento"].ToString(),
                        ProductoTerminadoId = Convert.ToInt32(dr["id_pt"].ToString())
                    }) ;
                }


                cnx.Close();
            }

            if (factura_detalle.Count>0)
            {
            return true;

            }
            else
            {
                return false;
            }
        }


        public class FacturaDetallePropiedades
        {
            public long FacturaId { get; set; }
            public long FacturaDetalleId { get; set; }
            public decimal TotalLinea { get; set; }
            public decimal Cantidad { get; set; }
            public int ProductoTerminadoId { get; set; }
            public decimal Precio { get; set; }
            public string Descripcion { get; set; }
            public string NumeroDocumento { get; set; }
        }
    }

    

}
