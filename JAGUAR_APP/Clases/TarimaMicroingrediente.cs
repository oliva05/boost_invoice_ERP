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
   public class TarimaMicroingrediente
    {

        Int64 _id;
        int _id_materiaprima;
        decimal _cantidad;
        decimal _cantidadKg;
        //decimal _peso;
        string _idProveedor;
        DateTime _FechaIngreso;
        int _numeroTransaccion;
        DateTime _fechaVencimiento;
        DateTime _fechaProduccion;
        string _LoteMP;
        bool _Enable;
        bool _Recuperad;
        int _idPresentacion;
        int _idUsuario;
        //int _tipotarimaid;
        int _idBoleta;
        string _CodigoBarra;
        int _id_ingreso;
        String _Proveedor;
        String _MateriaPrimaName;
        string Itemcode;
        string _MateriaPrima;
        int _idTarimaOrigen;
        int _idRM;



        public Int64 Id { get => _id; set => _id = value; }
        public int Id_materiaprima { get => _id_materiaprima; set => _id_materiaprima = value; }
        public bool Recuperado { get => _Recuperad; set => _Recuperad = value; }
        public string CardCode { get => _idProveedor; set => _idProveedor = value; }
        public DateTime FechaIngreso { get => _FechaIngreso; set => _FechaIngreso = value; }
        public int NumeroTransaccion { get => _numeroTransaccion; set => _numeroTransaccion = value; }
        public DateTime FechaProduccionMP { get => _fechaProduccion; set => _fechaProduccion = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
        public bool Enable { get => _Enable; set => _Enable = value; }
        public int IdPresentacion { get => _idPresentacion; set => _idPresentacion = value; }
        public int IdBoleta { get => _idBoleta; set => _idBoleta = value; }
        public string CodigoBarra { get => _CodigoBarra; set => _CodigoBarra = value; }
        public decimal Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal CantidadKg { get => _cantidadKg; set => _cantidadKg = value; }
        public int Id_ingreso { get => _id_ingreso; set => _id_ingreso = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string LoteMP { get => _LoteMP; set => _LoteMP = value; }
        public string NombreTarima { get => _MateriaPrimaName; set => _MateriaPrimaName = value; }
        public string ItemCode { get => Itemcode; set => Itemcode = value; }
        public string MateriaPrima { get => _MateriaPrima; set => _MateriaPrima = value; }
        public int IdTarimaOrigen { get => _idTarimaOrigen; set => _idTarimaOrigen = value; }
        public int IdRM { get => _idRM; set => _idRM = value; }

        public TarimaMicroingrediente()
        {

        }

        public bool RecuperarRegistroTarimaMicros(Int64 pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_row_tarima_micros_from_id_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                cmd.Parameters.AddWithValue("@barcode", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt64(0);
                    Id_materiaprima = dr.GetInt32(1);
                    if (!dr.IsDBNull(dr.GetOrdinal("CardCode")))
                        CardCode = dr.GetString(2);
                    else
                        CardCode = null;

                    FechaIngreso = dr.GetDateTime(3);

                    if (!dr.IsDBNull(dr.GetOrdinal("numero_transaccion")))
                        NumeroTransaccion = dr.GetInt32(4);
                    else
                        NumeroTransaccion = 0;

                    FechaVencimiento = dr.GetDateTime(5);
                    _fechaProduccion = dr.GetDateTime(6);

                    if (!dr.IsDBNull(dr.GetOrdinal("lote_materia_prima")))
                        _LoteMP = dr.GetString(7);
                    else
                        _LoteMP = null;

                    Enable = dr.GetBoolean(8);

                    if (!dr.IsDBNull(dr.GetOrdinal("id_presentacion")))
                        IdPresentacion = dr.GetInt32(9);
                    else
                        IdPresentacion = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("id_usuario")))
                        _idUsuario = dr.GetInt32(10);
                    else
                        _idUsuario = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("codigo_barra")))
                        CodigoBarra = dr.GetString(11);
                    else
                        CodigoBarra = null;

                    Cantidad = dr.GetDecimal(12);//ó unidades
                    CantidadKg = dr.GetDecimal(13);

                    if (!dr.IsDBNull(dr.GetOrdinal("id_tarima_origen")))
                        IdTarimaOrigen = dr.GetInt32(14);
                    else
                        IdTarimaOrigen = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("itemcode")))
                        ItemCode = dr.GetString(15);
                    else
                        ItemCode = null;

                    if (!dr.IsDBNull(dr.GetOrdinal("materia_prima_name")))
                        MateriaPrima = dr.GetString(16);
                    else
                        MateriaPrima = null;

                    if (!dr.IsDBNull(dr.GetOrdinal("id_rm")))
                        IdRM = dr.GetInt32(17);
                    else
                        _idRM = 0;

                     Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistroPorCodBarra(string codBarra)
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
                    Id = dr.GetInt64(0);
                    //FechaIngreso = dr.GetDateTime(1);
                    //FechaVencimiento = dr.GetDateTime(2);
                    //LotePT = dr.GetInt32(3);
                    //IdPresentacion = dr.GetInt32(4);
                    //_idUsuario = dr.GetInt32(5);
                    //_tipotarimaid = dr.GetInt32(6);
                    //IdProductoterminado = dr.GetInt32(7);
                    //Fecha_produccion_pt = dr.GetDateTime(8);
                    LoteMP = dr.GetString(3);
                    CodigoBarra = dr.GetString(6);
                    MateriaPrima = dr.GetString(9);
                    IdTarimaOrigen = dr.GetInt32(10);
                    Id_materiaprima = dr.GetInt32(11);
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
    }
}
