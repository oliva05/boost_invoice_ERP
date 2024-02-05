using ACS.Classes;
//using JAGUAR_APP.Logistica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class Bodegas
    {
        public int id;
        public string descripcion;
        public string descripcion_corta;
        public bool enable;
        public string whs_equivalente;
        public bool Recuperado;
        //dsCierreMes.bodegasDataTable TableBodegas;
        dsColleccionesClases.bodegasDataTable TableBodegas;
        public Bodegas()
        {
            TableBodegas = new dsColleccionesClases.bodegasDataTable();// dsCierreMes.bodegasDataTable();
            LoadDatosMaestros();
        }

        private void LoadDatosMaestros()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_recuperar_registro_bodegas_all", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_bodega", pCodigoBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(TableBodegas);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public bool RecuperarRegistroPreLoaded(string pCodigoBodega)
        {
            Recuperado = false;
            foreach(dsColleccionesClases.bodegasRow row in TableBodegas.Rows)
            {
                if(row.whs_equivalente == pCodigoBodega)
                {
                    id = row.id;
                    descripcion = row.descripcion;
                    descripcion_corta = row.descripcion_corta;
                    enable = row.enable;
                    whs_equivalente = row.whs_equivalente;
                    Recuperado = true;
                    break;
                }
            }
            return Recuperado;
        }

        public bool RecuperarRegistro(string pCodigoBodega)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_recuperar_registro_bodega", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_bodega", pCodigoBodega);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    descripcion = dr.GetString(1);
                    descripcion_corta = dr.GetString(2);
                    enable = dr.GetBoolean(3);
                    whs_equivalente = dr.GetString(4);
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

        public bool RecuperarRegistro(int pIdBodega)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_recuperar_registro_bodega_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdBodega);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    descripcion = dr.GetString(1);
                    descripcion_corta = dr.GetString(2);
                    enable = dr.GetBoolean(3);
                    whs_equivalente = dr.GetString(4);
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





    }

}
