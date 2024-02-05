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
    public class Requisicion
    {
        public Requisicion()
        {
            Recuperado = false;
            IdRequisicion = 0;
        }

        public bool Recuperado;
        public int IdRequisicion;
        public string Barcode;

        int _idRequisicion;
        int _id_usuario;
        Int64 _id_orden;
        DateTime _fecha_solicitada;
        DateTime _fecha_a_producir;
        int _id_estado;
        int _DocEntry;
        string _comentario;
        string _barcode;
        bool _bit_finalizar;
        int _id_requisa;
        bool _bit_manual;
        int _user_end;
        int _Lote;
        string _descripcion_estado;

        public int IdRequisicion1 { get => _idRequisicion; set => _idRequisicion = value; }
        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public Int64 Id_orden { get => _id_orden; set => _id_orden = value; }
        public DateTime Fecha_solicitada { get => _fecha_solicitada; set => _fecha_solicitada = value; }
        public DateTime Fecha_a_producir { get => _fecha_a_producir; set => _fecha_a_producir = value; }
        public int Id_estado { get => _id_estado; set => _id_estado = value; }
        public int DocEntry { get => _DocEntry; set => _DocEntry = value; }
        public string Comentario { get => _comentario; set => _comentario = value; }
        public string Barcode1 { get => _barcode; set => _barcode = value; }
        public bool Bit_finalizar { get => _bit_finalizar; set => _bit_finalizar = value; }
        public int Id_requisa { get => _id_requisa; set => _id_requisa = value; }
        public bool Bit_manual { get => _bit_manual; set => _bit_manual = value; }
        public int User_end { get => _user_end; set => _user_end = value; }
        public int Lote { get => _Lote; set => _Lote = value; }
        public string Descripcion_estado { get => _descripcion_estado; set => _descripcion_estado = value; }
        public string DocNum_OrdenFabricacion { get => _descripcion_estado; set => _descripcion_estado = value; }

        public bool RecuperarRegistroFromBarcodeClass(string barcode)
        {
            try
            {
                Recuperado = false;
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.[sp_get_datos_requisicion_from_barcodeClass]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdRequisicion = _idRequisicion = dr.GetInt32(0);
                    _id_usuario = dr.GetInt32(1);
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("id_orden")))
                        _id_orden = dr.GetInt32(2);

                    _fecha_solicitada = dr.GetDateTime(3);
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("fecha_a_producir")))
                        _fecha_a_producir = dr.GetDateTime(4);

                    _id_estado = dr.GetInt32(5);

                    if (!dr.IsDBNull(dr.GetOrdinal("DocEntry")))
                        _DocEntry = dr.GetInt32(6);
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("comentario")))
                        _comentario = dr.GetString(7);

                    _barcode = dr.GetString(8);
                    _bit_finalizar = dr.GetBoolean(9);
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("id_requisa")))
                        _id_requisa = dr.GetInt32(10);

                    _bit_manual = dr.GetBoolean(11);
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("user_end")))
                        _user_end = dr.GetInt32(12);

                    if (!dr.IsDBNull(dr.GetOrdinal("Lote")))
                        _Lote = dr.GetInt32(13);

                    if (!dr.IsDBNull(dr.GetOrdinal("descripcion_estado")))
                        Descripcion_estado = dr.GetString(14);

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

        public bool RecuperarRegistroFromId_H(int pId_h)
        {
            try
            {
                Recuperado = false;
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.[sp_get_datos_requisicion_from_IdH_Class]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pId_h);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdRequisicion = _idRequisicion = dr.GetInt32(0);
                    _id_usuario = dr.GetInt32(1);

                    if (!dr.IsDBNull(dr.GetOrdinal("id_orden")))
                        _id_orden = dr.GetInt64(2);

                    _fecha_solicitada = dr.GetDateTime(3);

                    if (!dr.IsDBNull(dr.GetOrdinal("fecha_a_producir")))
                        _fecha_a_producir = dr.GetDateTime(4);

                    _id_estado = dr.GetInt32(5);

                    if (!dr.IsDBNull(dr.GetOrdinal("DocEntry")))
                        _DocEntry = dr.GetInt32(6);

                    if (!dr.IsDBNull(dr.GetOrdinal("comentario")))
                        _comentario = dr.GetString(7);

                    if (!dr.IsDBNull(dr.GetOrdinal("barcode")))
                        Barcode = dr.GetString(8);

                    if (!dr.IsDBNull(dr.GetOrdinal("id_requisa")))
                        _id_requisa = dr.GetInt32(9);

                    if (!dr.IsDBNull(dr.GetOrdinal("descripcion_estado")))
                        Descripcion_estado = dr.GetString(10);

                    if (!dr.IsDBNull(dr.GetOrdinal("DocNum_OrdenFabricacion")))
                        DocNum_OrdenFabricacion = dr.GetString(11);
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

        public bool RecuperarRegistroFromBarcode(string barcode)
        {
            try
            {
                Recuperado = false;
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_datos_requisicion_from_barcode", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                IdRequisicion = Convert.ToInt32(cmd.ExecuteScalar());
                if (IdRequisicion > 0)
                {
                    Barcode = barcode;
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
