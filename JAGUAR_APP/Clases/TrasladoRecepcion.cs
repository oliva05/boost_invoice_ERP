using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class TrasladoRecepcion
    {
        public long Id { get; set; }
        public long? IdDetalleTraslado { get; set; }
        public decimal? Cantidad { get; set; }
        public bool? Enable { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdUser { get; set; }
        public bool Recuperado { get;set; }
        DataOperations dp;

        // Constructor por defecto
        public TrasladoRecepcion() 
        {
            dp = new DataOperations();
        }

        // Método para llenar las propiedades desde la tabla filtrando por id_detalle_traslado
        public bool RecuperarRegistro(long idDetalleTraslado)
        {
            Recuperado = false;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                string query = "SELECT * " +
                                "FROM dbo.JAGUAR_traslado_d_recepcion " +
                                "WHERE id_detalle_traslado = @IdDetalleTraslado";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdDetalleTraslado", idDetalleTraslado);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id = (long)reader["id"];
                        IdDetalleTraslado = (long?)reader["id_detalle_traslado"];
                        Cantidad = (decimal?)reader["cantidad"];
                        Enable = (bool?)reader["enable"];
                        Fecha = (DateTime?)reader["fecha"];
                        IdUser = (int?)reader["id_user"];
                        Recuperado = true;
                    }
                }
            }
            return Recuperado;
        }

        // Método para actualizar un registro por id_detalle_traslado
        public bool UpdateByIdDetalleTraslado(long idDetalleTraslado)
        {
            bool res = false;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                string query = "UPDATE dbo.JAGUAR_traslado_d_recepcion " +
                                    "SET cantidad = @Cantidad, " +
                                    "enable = @Enable, " +
                                    "fecha = @Fecha, " +
                                    "id_user = @IdUser " +
                                "WHERE id_detalle_traslado = @IdDetalleTraslado";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@Enable", Enable);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@IdUser", IdUser);
                cmd.Parameters.AddWithValue("@IdDetalleTraslado", idDetalleTraslado);

                cmd.ExecuteNonQuery();
                res = true;
            }
            return res;
        }

        // Método para insertar un nuevo registro en la tabla
        //Poner una transaccion, postear salida de kardex pt y entrada en kardex facturacion !!!!!!!
        public long InsertNewRow()
        {
            long idInserted=0;
            //using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            //{
            //    connection.Open();

            //    string query = "INSERT INTO dbo.JAGUAR_traslado_d_recepcion " +
            //                                "(id_detalle_traslado, cantidad, enable, fecha, id_user) " +
            //                                "VALUES (@IdDetalleTraslado, @Cantidad, @Enable, @Fecha, @IdUser)SELECT SCOPE_IDENTITY();";
            //    SqlCommand cmd = new SqlCommand(query, connection);
            //    cmd.Parameters.AddWithValue("@IdDetalleTraslado", IdDetalleTraslado);
            //    cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            //    cmd.Parameters.AddWithValue("@Enable", Enable);
            //    cmd.Parameters.AddWithValue("@Fecha", Fecha);
            //    cmd.Parameters.AddWithValue("@IdUser", IdUser);

            //    idInserted = Convert.ToInt64(cmd.ExecuteScalar());
            //}

            try
            {
                // //////////////////transaction
                DataOperations dp = new DataOperations();
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;

                    // Start a local transaction.
                    transaction = connection.BeginTransaction("SampleTransaction");

                    // Must assign both transaction object and connection
                    // to Command object for a pending local transaction
                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                        command.CommandText  = "INSERT INTO dbo.JAGUAR_traslado_d_recepcion " +
                                                    "(id_detalle_traslado, cantidad, enable, fecha, id_user) " +
                                               "VALUES (@IdDetalleTraslado, @Cantidad, @Enable, @Fecha, @IdUser)SELECT SCOPE_IDENTITY();";
                        
                        command.Parameters.AddWithValue("@IdDetalleTraslado", IdDetalleTraslado);
                        command.Parameters.AddWithValue("@Cantidad", Cantidad);
                        command.Parameters.AddWithValue("@Enable", Enable);
                        command.Parameters.AddWithValue("@Fecha", Fecha);
                        command.Parameters.AddWithValue("@IdUser", IdUser);

                        idInserted = Convert.ToInt64(command.ExecuteScalar());
                        TrasladoDetalle Detalle1 = new TrasladoDetalle();
                        if (Detalle1.RecuperarRegistro(Convert.ToInt64(IdDetalleTraslado)))
                        {
                            Traslado Traslado1 = new Traslado();
                            if (Traslado1.RecuperaRegistro(Detalle1.IdH)) 
                            {
                                //salida PT
                                command.CommandText = "dbo.sp_set_insert_salida_pt_por_venta_o_traslado";
                                command.CommandType = System.Data.CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_pt", Detalle1.IdPt);
                                command.Parameters.AddWithValue("@id_usuario", IdUser);
                                command.Parameters.AddWithValue("@fecha_doc", Fecha);
                                command.Parameters.AddWithValue("@ItemCode", Detalle1.ItemCode);
                                command.Parameters.AddWithValue("@entrada", 0);
                                command.Parameters.AddWithValue("@salida", Cantidad);
                                command.Parameters.AddWithValue("@lote", Detalle1.Lote);
                                command.ExecuteNonQuery();



                                //Entrada Facturacion
                                command.CommandText = "dbo.sp_set_insert_entrada_kardex_facturacion_para_punto_venta";
                                command.CommandType = System.Data.CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@fecha", Fecha);
                                command.Parameters.AddWithValue("@itemcode", Detalle1.ItemCode);
                                command.Parameters.AddWithValue("@user_id", IdUser);
                                command.Parameters.AddWithValue("@ud_entrada", Cantidad);
                                command.Parameters.AddWithValue("@entrada", Cantidad);
                                command.Parameters.AddWithValue("@lote", Detalle1.Lote);
                                command.Parameters.AddWithValue("@id_punto_facturacion", Traslado1.IdPuntoVenta);
                                command.Parameters.AddWithValue("@id_pt", Detalle1.IdPt);
                                command.ExecuteNonQuery();
                                // Attempt to commit the transaction.
                                transaction.Commit();
                            }
                        }

                        
                    }
                    catch (Exception ex)
                    {
                        // Attempt to roll back the transaction.
                        try
                        {
                            transaction.Rollback();
                            CajaDialogo.Error(ex.Message);
                        }
                        catch (Exception ex2)
                        {
                            CajaDialogo.Error(ex2.Message);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                CajaDialogo.Error("Error de conexion open... msj: ", ex);
            }




            return idInserted;
        }
    }
}
