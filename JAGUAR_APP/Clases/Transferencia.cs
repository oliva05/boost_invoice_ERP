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
    class Transferencia
    {
        public Transferencia()
        {

        }

        private bool recuperado;
        private int id_d_lote;
        decimal peso;
        decimal unidades;
        DateTime fecha_transferencia;

        int user_creador;
        string usuario;
        int id_serie;
        int DocEntry;
        int id_mp;
        int id_lote_externo;
        int id_detalle;
        int id_presentacio;
        string bodega_in;
        string bodega_out;
        int id_ingreso_lote;
        bool bit_configurado;
        int id_tipo_transaccion;
        int IsTraslado;

        #region Miembros Header
        int id_transferencia;
        DateTime fecha_h;
        int id_ingreso;
        int DocEntryH;
        int numero_transaccion;
        #endregion

        public int Id_d_lote { get => id_d_lote; set => id_d_lote = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public decimal Unidades { get => unidades; set => unidades = value; }
        public DateTime Fecha_transferencia { get => fecha_transferencia; set => fecha_transferencia = value; }
        public int User_creador { get => user_creador; set => user_creador = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int Id_serie { get => id_serie; set => id_serie = value; }
        public int DocEntry1 { get => DocEntry; set => DocEntry = value; }
        public int Id_mp { get => id_mp; set => id_mp = value; }
        public int Id_lote_externo { get => id_lote_externo; set => id_lote_externo = value; }
        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Id_presentacio { get => id_presentacio; set => id_presentacio = value; }
        public string Bodega_in { get => bodega_in; set => bodega_in = value; }
        public string Bodega_out { get => bodega_out; set => bodega_out = value; }
        public int Id_ingreso_lote { get => id_ingreso_lote; set => id_ingreso_lote = value; }
        public bool Bit_configurado { get => bit_configurado; set => bit_configurado = value; }
        public int Id_tipo_transaccion { get => id_tipo_transaccion; set => id_tipo_transaccion = value; }
        public int IsTraslado1 { get => this.IsTraslado; set => this.IsTraslado = value; }
        public int Id_transferencia { get => id_transferencia; set => id_transferencia = value; }
        public DateTime Fecha_h { get => fecha_h; set => fecha_h = value; }
        public int Id_ingreso { get => id_ingreso; set => id_ingreso = value; }
        public int DocEntryH1 { get => DocEntryH; set => DocEntryH = value; }
        public int Numero_transaccion { get => numero_transaccion; set => numero_transaccion = value; }

        public bool RecuIsTraslado(int pNumero_transaccion)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_traslado_o_compra", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_transaccion", pNumero_transaccion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IsTraslado1 = dr.GetInt32(0);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistro(int pNumero_transaccion)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_salida_d_lote_for_numero_ingreso", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_transaccion", pNumero_transaccion);
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_d_lote = dr.GetInt32(0);
                    Peso = dr.GetDecimal(1);
                    Unidades = dr.GetDecimal(2);
                    Fecha_transferencia = dr.GetDateTime(3);
                    User_creador = dr.GetInt32(4);
                    Usuario = dr.GetString(5);
                    Id_serie = dr.GetInt32(6);
                    DocEntry1 = dr.GetInt32(7);
                    Id_mp = dr.GetInt32(8);
                    Id_lote_externo = dr.GetInt32(9);
                    Id_detalle = dr.GetInt32(10);
                    Id_presentacio = dr.GetInt32(11);
                    Bodega_in = dr.GetString(12);
                    Bodega_out = dr.GetString(13);
                    Id_ingreso_lote = dr.GetInt32(14);
                    Bit_configurado = dr.GetBoolean(15);
                    Id_tipo_transaccion = dr.GetInt32(16);
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

        public bool RecuperarHeaderTransf(int pNumero_transaccion)
        {
            string query = @"sp_get_transferencia_header_for_numero_ingreso";
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_transaccion", pNumero_transaccion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_transferencia = dr.GetInt32(0);
                    Fecha_h = dr.GetDateTime(1);
                    Id_ingreso = dr.GetInt32(2);
                    DocEntryH1 = dr.GetInt32(3);
                    Numero_transaccion = dr.GetInt32(4);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }

        public bool RecuperarHeaderTransf_for_id_transfer(int pid_transf)
        {
            string query = @"sp_get_transferencia_header_for_id_transferencia";
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_transferencia", pid_transf);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Bodega_in = dr.GetString(0);
                    Fecha_h = dr.GetDateTime(1);
                    Id_ingreso = dr.GetInt32(2);
                    DocEntryH1 = dr.GetInt32(3);
                    Numero_transaccion = dr.GetInt32(4);
                    Bodega_out = dr.GetString(5);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }

    }


  
}
