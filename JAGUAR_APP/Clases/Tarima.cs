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
    public class Tarima
    {
        int _id;
        String _MateriaPrimaName;
        int _id_materiaprima;
        decimal _cantidad;
        decimal _peso;
        string _idProveedor;
        DateTime _FechaIngreso;
        int _numeroTransaccion;
        DateTime _fechaVencimiento;
        DateTime _fechaProduccion;
        string _LoteMP;
        string _ProductoTerminadoName;
        int _LotePT;
        bool _Enable;
        int _idPresentacion;
        string _Descripcionpresentacion;
        int _idUsuario;
        int _tipotarimaid;
        int id_estado_tarima;
        string _tipoTarimaDescripcion;
        int _idProductoterminado;
        DateTime _fechaProductoTerminadoProduccion;
        int _idBoleta;
        string _CodigoBarra;
        int _idUnidadMedida;
        String _Proveedor;
        bool _Recuperad;
        string _MateriaPrima;
        decimal _factor;
        int id_estadoCalidad;
        int _id_ingreso;
        int _id_ingresoH;
        int _id_lote_externo;
        int id_alimentacion;
        private int id_turno;
        DateTime fecha_produccion_pt;
        string Itemcode;
        int _id_tarima_reproceso;
        string _productoTerminadoName_Detalle;
        string turno;
        public Tarima()
        {

        }

        /// <summary>
        /// Id tarima
        /// </summary>
        public int Id { get => _id; set => _id = value; }
        public int Id_materiaprima { get => _id_materiaprima; set => _id_materiaprima = value; }
        public int IdUnidadMedida { get => _idUnidadMedida; set => _idUnidadMedida = value; }
        public bool Recuperado { get => _Recuperad; set => _Recuperad = value; }
        public decimal Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Descripcionpresentacion { get => _Descripcionpresentacion; set => _Descripcionpresentacion = value; }
        public string TipoTarimaDescripcion { get => _tipoTarimaDescripcion; set => _tipoTarimaDescripcion = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string LoteMP { get => _LoteMP; set => _LoteMP = value; }
        public string NombreTarima { get => _MateriaPrimaName; set => _MateriaPrimaName = value; }
        public string CodigoBarra { get => _CodigoBarra; set => _CodigoBarra = value; }
        public string MateriaPrima { get => _MateriaPrima; set => _MateriaPrima = value; }
        public DateTime FechaIngreso { get => _FechaIngreso; set => _FechaIngreso = value; }
        public int NumeroTransaccion { get => _numeroTransaccion; set => _numeroTransaccion = value; }
        public DateTime FechaProduccionMP { get => _fechaProduccion; set => _fechaProduccion = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
        public int IdBoleta { get => _idBoleta; set => _idBoleta = value; }
        public decimal Peso { get => _peso; set => _peso = value; }
        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public int IdPresentacion { get => _idPresentacion; set => _idPresentacion = value; }
        public decimal Factor { get => _factor; set => _factor = value; }
        public bool Enable { get => _Enable; set => _Enable = value; }
        public int IdProductoterminado { get => _idProductoterminado; set => _idProductoterminado = value; }
        public int LotePT { get => _LotePT; set => _LotePT = value; }
        public int Id_estadoCalidad { get => id_estadoCalidad; set => id_estadoCalidad = value; }
        public int Id_ingreso { get => _id_ingreso; set => _id_ingreso = value; }
        public int Id_estado_tarima { get => id_estado_tarima; set => id_estado_tarima = value; }
        public int Id_alimentacion { get => id_alimentacion; set => id_alimentacion = value; }
        public DateTime Fecha_produccion_pt { get => fecha_produccion_pt; set => fecha_produccion_pt = value; }
        public int Id_turno { get => id_turno; set => id_turno = value; }


        /// <summary>
        /// ItemCode es Equivalente al Codigo de SAP
        /// </summary>
        public string ItemCode { get => Itemcode; set => Itemcode = value; }
        public int id_estado_pt { get; set; }
        public string ProductoTerminadoName { get => _ProductoTerminadoName; set => _ProductoTerminadoName = value; }
        /// <summary>
        /// ID de PT de la nueva Tarima de MP Reproceso
        /// </summary>
        public int Id_tarima_reproceso { get => _id_tarima_reproceso; set => _id_tarima_reproceso = value; }
        public string ProductoTerminadoName_Detalle { get => _productoTerminadoName_Detalle; set => _productoTerminadoName_Detalle = value; }
        public string Turno { get => turno; set => turno = value; }
        public int Id_ingresoH { get => _id_ingresoH; set => _id_ingresoH = value; }
        public int Id_lote_externo { get => _id_lote_externo; set => _id_lote_externo = value; }

        public bool RecuperarRegistro(int pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarima_from_idV5", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    IdUnidadMedida = dr.GetInt32(1);
                    //Cantidad = 1;
                    _MateriaPrimaName = dr.GetString(2);
                    TipoTarimaDescripcion = dr.GetString(3);
                    //IdProveedor = dr.GetString(4);
                    Proveedor = dr.GetString(4);

                    LoteMP = dr.GetString(5);
                    Cantidad = dr.GetDecimal(7);
                    Id_materiaprima = dr.GetInt32(8);
                    MateriaPrima = dr.GetString(9);
                    FechaIngreso = dr.GetDateTime(10);
                    NumeroTransaccion = dr.GetInt32(11);
                    FechaProduccionMP = dr.GetDateTime(12);
                    FechaVencimiento = dr.GetDateTime(13);
                    IdBoleta = dr.GetInt32(14);
                    CodigoBarra = dr.GetString(15);
                    Factor = dr.GetDecimal(16);
                    Enable = dr.GetBoolean(17);
                    Peso = dr.GetDecimal(18);
                    IdProductoterminado = dr.GetInt32(19);
                    LotePT = dr.GetInt32(20);
                    id_estadoCalidad = dr.GetInt32(21);
                    Id_estado_tarima = dr.GetInt32(22);
                    Id_alimentacion = dr.GetInt32(23);
                    Fecha_produccion_pt = dr.GetDateTime(24);
                    Id_turno = dr.GetInt32(25);
                    IdPresentacion = dr.GetInt32(26);
                    ItemCode = dr.GetString(27);
                    Id_tarima_reproceso = dr.GetInt32(28);
                    Turno = dr.GetString(29);
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

        public bool RecuperarRegistro_activacion(int pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_row_tarima_from_id_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    // IdUnidadMedida = dr.GetInt32(1);
                    //Cantidad = 1;
                    _MateriaPrimaName = dr.GetString(2);
                    TipoTarimaDescripcion = dr.GetString(3);
                    IdProveedor = dr.GetString(4);
                    LoteMP = dr.GetString(5);
                    Cantidad = dr.GetDecimal(7);
                    Id_materiaprima = dr.GetInt32(8);
                    MateriaPrima = dr.GetString(9);
                    FechaIngreso = dr.GetDateTime(10);
                    NumeroTransaccion = dr.GetInt32(11);
                    FechaProduccionMP = dr.GetDateTime(12);
                    FechaVencimiento = dr.GetDateTime(13);
                    IdBoleta = dr.GetInt32(14);
                    CodigoBarra = dr.GetString(15);
                    Factor = dr.GetDecimal(16);
                    Enable = dr.GetBoolean(17);
                    Peso = dr.GetDecimal(18);
                    IdProductoterminado = dr.GetInt32(19);
                    LotePT = dr.GetInt32(20);
                    id_estadoCalidad = dr.GetInt32(21);

                    Id_alimentacion = dr.GetInt32(23);
                    Fecha_produccion_pt = dr.GetDateTime(24);
                    Id_turno = dr.GetInt32(25);
                    id_estado_pt = dr.GetInt32(26);
                    Recuperado = true;

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistro_v2(int pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarima_from_id_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    IdUnidadMedida = dr.GetInt32(1);
                    //Cantidad = 1;
                    _MateriaPrimaName = dr.GetString(2);
                    TipoTarimaDescripcion = dr.GetString(3);
                    //IdProveedor = dr.GetString(4);
                    Proveedor = dr.GetString(4);

                    LoteMP = dr.GetString(5);
                    Cantidad = dr.GetDecimal(7);
                    Id_materiaprima = dr.GetInt32(8);
                    MateriaPrima = dr.GetString(9);
                    FechaIngreso = dr.GetDateTime(10);
                    NumeroTransaccion = dr.GetInt32(11);
                    FechaProduccionMP = dr.GetDateTime(12);
                    FechaVencimiento = dr.GetDateTime(13);
                    IdBoleta = dr.GetInt32(14);
                    CodigoBarra = dr.GetString(15);
                    Factor = dr.GetDecimal(16);
                    Enable = dr.GetBoolean(17);
                    Peso = dr.GetDecimal(18);
                    IdProductoterminado = dr.GetInt32(19);
                    LotePT = dr.GetInt32(20);
                    id_estadoCalidad = dr.GetInt32(21);
                    Id_estado_tarima = dr.GetInt32(22);
                    Id_alimentacion = dr.GetInt32(23);
                    Fecha_produccion_pt = dr.GetDateTime(24);
                    ProductoTerminadoName = dr.GetString(25);
                    Id_turno = dr.GetInt32(25);
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
        public bool RecuperarRegistro_v3(int pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarima_from_id_v3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    IdUnidadMedida = dr.GetInt32(1);
                    //Cantidad = 1;
                    _MateriaPrimaName = dr.GetString(2);
                    TipoTarimaDescripcion = dr.GetString(3);
                    //IdProveedor = dr.GetString(4);
                    Proveedor = dr.GetString(4);

                    LoteMP = dr.GetString(5);
                    _Descripcionpresentacion = dr.GetString(6);
                    Cantidad = dr.GetDecimal(7);
                    Id_materiaprima = dr.GetInt32(8);
                    MateriaPrima = dr.GetString(9);
                    FechaIngreso = dr.GetDateTime(10);
                    NumeroTransaccion = dr.GetInt32(11);
                    FechaProduccionMP = dr.GetDateTime(12);
                    FechaVencimiento = dr.GetDateTime(13);
                    IdBoleta = dr.GetInt32(14);
                    CodigoBarra = dr.GetString(15);
                    Factor = dr.GetDecimal(16);
                    Enable = dr.GetBoolean(17);
                    Peso = dr.GetDecimal(18);
                    IdProductoterminado = dr.GetInt32(19);
                    LotePT = dr.GetInt32(20);
                    id_estadoCalidad = dr.GetInt32(21);
                    Id_estado_tarima = dr.GetInt32(22);
                    Id_alimentacion = dr.GetInt32(23);
                    Fecha_produccion_pt = dr.GetDateTime(24);
                    Id_turno = dr.GetInt32(25);
                    id_estado_pt = dr.GetInt32(26);
                    ProductoTerminadoName = dr.GetString(27);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_presentacion")))
                        IdPresentacion = dr.GetInt32(28);

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
        public bool RecuperarRegistropt(int pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarima_from_id_V2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    IdUnidadMedida = dr.GetInt32(1);
                    //Cantidad = 1;
                    _MateriaPrimaName = dr.GetString(2);
                    TipoTarimaDescripcion = dr.GetString(3);
                    IdProveedor = dr.GetString(4);
                    LoteMP = dr.GetString(5);
                    Cantidad = dr.GetDecimal(7);
                    Id_materiaprima = dr.GetInt32(8);
                    MateriaPrima = dr.GetString(9);
                    FechaIngreso = dr.GetDateTime(10);
                    NumeroTransaccion = dr.GetInt32(11);
                    FechaProduccionMP = dr.GetDateTime(12);
                    FechaVencimiento = dr.GetDateTime(13);
                    IdBoleta = dr.GetInt32(14);
                    CodigoBarra = dr.GetString(15);
                    Factor = dr.GetDecimal(16);
                    Enable = dr.GetBoolean(17);
                    Peso = dr.GetDecimal(18);
                    IdProductoterminado = dr.GetInt32(19);
                    LotePT = dr.GetInt32(20);
                    id_estadoCalidad = dr.GetInt32(21);

                    Id_alimentacion = dr.GetInt32(23);
                    Fecha_produccion_pt = dr.GetDateTime(24);
                    Id_turno = dr.GetInt32(25);
                    id_estado_pt = dr.GetInt32(26);
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


        public bool RecuperarRegistro(int pIdTarima)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_row_tarima_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                //cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Id_materiaprima = dr.GetInt32(1);
                    IdProveedor = dr.GetString(2);
                    FechaIngreso = dr.GetDateTime(3);
                    NumeroTransaccion = dr.GetInt32(4);
                    FechaVencimiento = dr.GetDateTime(5);
                    _fechaProduccion = dr.GetDateTime(6);
                    _LoteMP = dr.GetString(7);
                    LotePT = dr.GetInt32(8);
                    Enable = dr.GetBoolean(9);
                    IdPresentacion = dr.GetInt32(10);
                    _idUsuario = dr.GetInt32(11);
                    _tipotarimaid = dr.GetInt32(12);
                    IdProductoterminado = dr.GetInt32(13);
                    _fechaProductoTerminadoProduccion = dr.GetDateTime(14);
                    IdBoleta = dr.GetInt32(15);
                    CodigoBarra = dr.GetString(16);
                    Cantidad = dr.GetDecimal(17);//ó unidades
                    IdUnidadMedida = dr.GetInt32(18);
                    _peso = dr.GetDecimal(19);
                    id_estadoCalidad = dr.GetInt32(20);
                    Id_ingreso = dr.GetInt32(21);
                    Id_alimentacion = dr.GetInt32(22);
                    Fecha_produccion_pt = dr.GetDateTime(23);
                    Id_turno = dr.GetInt32(24);
                    Itemcode = dr.GetString(25);

                    if (!dr.IsDBNull(dr.GetOrdinal("id_ingreso_h")))
                        Id_ingresoH = dr.GetInt32(26);
                    if (!dr.IsDBNull(dr.GetOrdinal("nombre_comercial")))
                        MateriaPrima = dr.GetString(27);
                    if (!dr.IsDBNull(dr.GetOrdinal("CardName")))
                        _Proveedor = dr.GetString(28);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_lote_externo")))
                        _id_lote_externo = dr.GetInt32(29);

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

        public bool RecuperarRegistroTarimaReproceso(int pIdTarima)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_row_tarima_from_idV2Reproceso]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                //cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Id_materiaprima = dr.GetInt32(1);
                    IdProveedor = dr.GetString(2);
                    FechaIngreso = dr.GetDateTime(3);
                    NumeroTransaccion = dr.GetInt32(4);
                    FechaVencimiento = dr.GetDateTime(5);
                    _fechaProduccion = dr.GetDateTime(6);
                    _LoteMP = dr.GetString(7);
                    LotePT = dr.GetInt32(8);
                    Enable = dr.GetBoolean(9);
                    IdPresentacion = dr.GetInt32(10);
                    _idUsuario = dr.GetInt32(11);
                    _tipotarimaid = dr.GetInt32(12);
                    IdProductoterminado = dr.GetInt32(13);
                    _fechaProductoTerminadoProduccion = dr.GetDateTime(14);
                    IdBoleta = dr.GetInt32(15);
                    CodigoBarra = dr.GetString(16);
                    Cantidad = dr.GetDecimal(17);//ó unidades
                    IdUnidadMedida = dr.GetInt32(18);
                    _peso = dr.GetDecimal(19);
                    id_estadoCalidad = dr.GetInt32(20);
                    Id_ingreso = dr.GetInt32(21);
                    Id_alimentacion = dr.GetInt32(22);
                    Fecha_produccion_pt = dr.GetDateTime(23);
                    Id_turno = dr.GetInt32(24);

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

        public bool RecuperarTarimaPorIngreso(int pNumIngreso)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_get_row_tarima_from_num_ingreso", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_ingreso", pNumIngreso);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Id_materiaprima = dr.GetInt32(1);
                    IdProveedor = dr.GetString(2);
                    FechaIngreso = dr.GetDateTime(3);
                    NumeroTransaccion = dr.GetInt32(4);
                    FechaVencimiento = dr.GetDateTime(5);
                    _fechaProduccion = dr.GetDateTime(6);
                    _LoteMP = dr.GetString(7);
                    LotePT = dr.GetInt32(8);
                    Enable = dr.GetBoolean(9);
                    IdPresentacion = dr.GetInt32(10);
                    _idUsuario = dr.GetInt32(11);
                    _tipotarimaid = dr.GetInt32(12);
                    IdProductoterminado = dr.GetInt32(13);
                    _fechaProductoTerminadoProduccion = dr.GetDateTime(14);
                    IdBoleta = dr.GetInt32(15);
                    CodigoBarra = dr.GetString(16);
                    Cantidad = dr.GetDecimal(17);//ó unidades
                    IdUnidadMedida = dr.GetInt32(18);
                    _peso = dr.GetDecimal(19);
                    id_estadoCalidad = dr.GetInt32(20);
                    Id_ingreso = dr.GetInt32(21);
                    Id_alimentacion = dr.GetInt32(22);
                    Fecha_produccion_pt = dr.GetDateTime(23);
                    Id_turno = dr.GetInt32(24);
                    Recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public string GetPrinterNameConsola()
        {
            DataOperations dp = new DataOperations();
            string name = "ND";
            try
            {
                string StoreProcedure = @"[sp_get_printer_name_impresion_tarima_consola]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(StoreProcedure, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", Serial);
                name = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return name;
        }


        public string GetPrinterNameLogistica()
        {
            DataOperations dp = new DataOperations();
            string name = "ND";
            try
            {
                string StoreProcedure = @"sp_get_printer_name_impresion_tarima_logistica";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(StoreProcedure, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", Serial);
                name = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return name;
        }


        public bool RecuperarTarimaPT(int pIdTarima)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarima_pt_for_id", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    FechaIngreso = dr.GetDateTime(1);
                    FechaVencimiento = dr.GetDateTime(2);
                    LotePT = dr.GetInt32(3);
                    IdPresentacion = dr.GetInt32(4);
                    _idUsuario = dr.GetInt32(5);
                    _tipotarimaid = dr.GetInt32(6);
                    IdProductoterminado = dr.GetInt32(7);
                    Fecha_produccion_pt = dr.GetDateTime(8);
                    CodigoBarra = dr.GetString(9);
                    Cantidad = dr.GetDecimal(10);//ó unidades
                    _peso = dr.GetDecimal(11);
                    ItemCode = dr.GetString(12);
                    id_estadoCalidad = dr.GetInt32(13);
                    Id_turno = dr.GetInt32(14);
                    id_estado_pt = dr.GetInt32(15);
                    Id_alimentacion = dr.GetInt32(16);
                    ProductoTerminadoName = dr.GetString(17);
                    ProductoTerminadoName_Detalle = dr.GetString(18);
                    Recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;

        }

        public bool RecuperarTarimaPorCodBarra(string codBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarima_for_codigo_barra", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codBarra", codBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Id = dr.GetInt32(0);
                    //FechaIngreso = dr.GetDateTime(1);
                    //FechaVencimiento = dr.GetDateTime(2);
                    //LotePT = dr.GetInt32(3);
                    //IdPresentacion = dr.GetInt32(4);
                    //_idUsuario = dr.GetInt32(5);
                    //_tipotarimaid = dr.GetInt32(6);
                    //IdProductoterminado = dr.GetInt32(7);
                    //Fecha_produccion_pt = dr.GetDateTime(8);
                    LoteMP = dr.GetString(3);
                    CodigoBarra = dr.GetString(9);
                    MateriaPrima = dr.GetString(17);
                    //Cantidad = dr.GetDecimal(10);//ó unidades
                    //_peso = dr.GetDecimal(11);
                    //ItemCode = dr.GetString(12);
                    //id_estadoCalidad = dr.GetInt32(13);
                    //Id_turno = dr.GetInt32(14);
                    //id_estado_pt = dr.GetInt32(15);
                    //Id_alimentacion = dr.GetInt32(16);
                    //ProductoTerminadoName = dr.GetString(17);
                    //ProductoTerminadoName_Detalle = dr.GetString(18);
                    Recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;

        }

        public bool RecuperarRegistroTarimaMicros(int pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_row_tarima_micros_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                //cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Id_materiaprima = dr.GetInt32(1);
                    IdProveedor = dr.GetString(2);
                    FechaIngreso = dr.GetDateTime(3);
                    NumeroTransaccion = dr.GetInt32(4);
                    FechaVencimiento = dr.GetDateTime(5);
                    _fechaProduccion = dr.GetDateTime(6);
                    _LoteMP = dr.GetString(7);
                    Enable= dr.GetBoolean(8);
                    IdPresentacion = dr.GetInt32(9);
                    _idUsuario = dr.GetInt32(10);
                    _tipotarimaid = dr.GetInt32(11);
                    IdBoleta = dr.GetInt32(12);
                    CodigoBarra = dr.GetString(13);
                    Cantidad = dr.GetDecimal(14);//ó unidades
                    Id_ingreso = dr.GetInt32(15);
                   
                    
                    
                    //LotePT = dr.GetInt32(8);
                    //Enable = dr.GetBoolean(9);
                    //IdProductoterminado = dr.GetInt32(13);
                    //_fechaProductoTerminadoProduccion = dr.GetDateTime(14);
                    //IdUnidadMedida = dr.GetInt32(18);
                    //_peso = dr.GetDecimal(19);
                    //id_estadoCalidad = dr.GetInt32(20);
                    //Id_alimentacion = dr.GetInt32(22);
                    //Fecha_produccion_pt = dr.GetDateTime(23);
                    //Id_turno = dr.GetInt32(24);
                    //Recuperado = true;
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
