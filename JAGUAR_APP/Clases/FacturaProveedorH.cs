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
    public class FacturaProveedorH
    {
        public Int64 idFacturaH;
        public int id_proveedor;
        public int id_usuario_recibido;
        public string usuario_recibido_name;
        public string cai;
        public string factura;
        public DateTime fecha_factura;
        public DateTime fecha_registro;
        public bool enable;
        public string entregado_por_nombre;
        public string entregado_por_identidad;
        public DateTime entregado_por_hora;
        public string entregado_por_telefono;
        public int id_usuario_revisado;
        public string usuario_revisado_name;
        public DateTime hora_revisado;
        public string observaciones;
        public int DocNum;
        public int IdCai;
        public bool Recuperado;

        public FacturaProveedorH()
        {

        }

        public bool RecuperarRegistro(Int64 pIdFacturaH)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();


                SqlCommand cmd = new SqlCommand("codesahn.sp_get_class_header_recepcion_factura_proveedor_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdFacturaH);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idFacturaH = dr.GetInt64(0);
                    id_proveedor = dr.GetInt32(1);
                    id_usuario_recibido = dr.GetInt32(2);
                    usuario_recibido_name = dr.GetString(3);
                    cai = dr.GetString(4);
                    factura = dr.GetString(5);
                    fecha_factura = dr.GetDateTime(6);
                    fecha_registro = dr.GetDateTime(7);
                    enable = dr.GetBoolean(8);
                    entregado_por_nombre = dr.GetString(9);
                    entregado_por_identidad = dr.GetString(10);
                    entregado_por_hora = dr.GetDateTime(11);
                    entregado_por_telefono = dr.GetString(12);
                    id_usuario_revisado = dr.GetInt32(13);
                    usuario_revisado_name = dr.GetString(14);
                    hora_revisado = dr.GetDateTime(15);
                    observaciones = dr.GetString(16);
                    DocNum = dr.GetInt32(17);
                    IdCai = dr.GetInt32(18);
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
