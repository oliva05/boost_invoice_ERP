using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class FacturacionReciboH
    {
        public long IdRecibo { get; set; }
        public string NumDoc { get; set; }
        public bool? Enable { get; set; }
        public int? IdUsuarioCreated { get; set; }
        public int? IdUsuarioUpdated { get; set; }
        public string Concepto { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? FechaCreated { get; set; }
        public DateTime? FechaUpdated { get; set; }
        public int? IdPuntoVenta { get; set; }
        public decimal? Valor { get; set; }
        public int? IdTipoPago { get; set; }

        private readonly string connectionString;

        public FacturacionReciboH(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Insert()
        {
            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                string insertQuery = @"
                INSERT INTO [dbo].[Facturacion_ReciboH]
                ([num_doc], [enable], [id_usuario_created], [id_usuario_updated], [concepto],
                 [id_cliente], [fecha_created], [fecha_updated], [id_punto_venta], [valor], [id_tipo_pago])
                VALUES
                (@NumDoc, @Enable, @IdUsuarioCreated, @IdUsuarioUpdated, @Concepto,
                 @IdCliente, @FechaCreated, @FechaUpdated, @IdPuntoVenta, @Valor, @IdTipoPago);
                SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@NumDoc", NumDoc);
                    command.Parameters.AddWithValue("@Enable", Enable);
                    command.Parameters.AddWithValue("@IdUsuarioCreated", IdUsuarioCreated);
                    command.Parameters.AddWithValue("@IdUsuarioUpdated", IdUsuarioUpdated);
                    command.Parameters.AddWithValue("@Concepto", Concepto);
                    command.Parameters.AddWithValue("@IdCliente", IdCliente);
                    command.Parameters.AddWithValue("@FechaCreated", FechaCreated);
                    command.Parameters.AddWithValue("@FechaUpdated", FechaUpdated);
                    command.Parameters.AddWithValue("@IdPuntoVenta", IdPuntoVenta);
                    command.Parameters.AddWithValue("@Valor", Valor);
                    command.Parameters.AddWithValue("@IdTipoPago", IdTipoPago);

                    IdRecibo = Convert.ToInt64(command.ExecuteScalar());
                }
            }
        }

        public static FacturacionReciboH RecuperarRegistro(long id)
        {
            FacturacionReciboH recibo = null;
            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM [dbo].[Facturacion_ReciboH] WHERE [id_recibo] = @IdRecibo;";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdRecibo", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            recibo = new FacturacionReciboH(dp.ConnectionStringJAGUAR_DB)
                            {
                                IdRecibo = Convert.ToInt64(reader["id_recibo"]),
                                NumDoc = reader["num_doc"] != DBNull.Value ? reader["num_doc"].ToString() : null,
                                Enable = reader["enable"] != DBNull.Value ? (bool)reader["enable"] : (bool?)null,
                                IdUsuarioCreated = reader["id_usuario_created"] != DBNull.Value ? (int)reader["id_usuario_created"] : (int?)null,
                                IdUsuarioUpdated = reader["id_usuario_updated"] != DBNull.Value ? (int)reader["id_usuario_updated"] : (int?)null,
                                Concepto = reader["concepto"] != DBNull.Value ? reader["concepto"].ToString() : null,
                                IdCliente = reader["id_cliente"] != DBNull.Value ? (int)reader["id_cliente"] : (int?)null,
                                FechaCreated = reader["fecha_created"] != DBNull.Value ? (DateTime)reader["fecha_created"] : (DateTime?)null,
                                FechaUpdated = reader["fecha_updated"] != DBNull.Value ? (DateTime)reader["fecha_updated"] : (DateTime?)null,
                                IdPuntoVenta = reader["id_punto_venta"] != DBNull.Value ? (int)reader["id_punto_venta"] : (int?)null,
                                Valor = reader["valor"] != DBNull.Value ? (decimal)reader["valor"] : (decimal?)null,
                                IdTipoPago = reader["id_tipo_pago"] != DBNull.Value ? (int)reader["id_tipo_pago"] : (int?)null
                            };
                        }
                    }
                }
            }

            return recibo;
        }

        public void Update()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = @"
                UPDATE [dbo].[Facturacion_ReciboH]
                SET [num_doc] = @NumDoc, [enable] = @Enable, [id_usuario_created] = @IdUsuarioCreated,
                    [id_usuario_updated] = @IdUsuarioUpdated, [concepto] = @Concepto,
                    [id_cliente] = @IdCliente, [fecha_created] = @FechaCreated, [fecha_updated] = @FechaUpdated,
                    [id_punto_venta] = @IdPuntoVenta, [valor] = @Valor, [id_tipo_pago] = @IdTipoPago
                WHERE [id_recibo] = @IdRecibo;";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@NumDoc", NumDoc);
                    command.Parameters.AddWithValue("@Enable", Enable);
                    command.Parameters.AddWithValue("@IdUsuarioCreated", IdUsuarioCreated);
                    command.Parameters.AddWithValue("@IdUsuarioUpdated", IdUsuarioUpdated);
                    command.Parameters.AddWithValue("@Concepto", Concepto);
                    command.Parameters.AddWithValue("@IdCliente", IdCliente);
                    command.Parameters.AddWithValue("@FechaCreated", FechaCreated);
                    command.Parameters.AddWithValue("@FechaUpdated", FechaUpdated);
                    command.Parameters.AddWithValue("@IdPuntoVenta", IdPuntoVenta);
                    command.Parameters.AddWithValue("@Valor", Valor);
                    command.Parameters.AddWithValue("@IdTipoPago", IdTipoPago);
                    command.Parameters.AddWithValue("@IdRecibo", IdRecibo);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
