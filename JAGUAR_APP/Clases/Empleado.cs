using ACS.Classes;
//using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class Empleado
    {
        int _Id;
        string _pin;
        string _nombre;
        public int _idcontrato;
        public string _puesto;
        public DateTime _FechaInicio;
        public DateTime _FechaFin;
        public decimal _Salario;
        public string _antiguedad;
        public decimal _salarioBaseDiario;
        public decimal _salarioBaseMensual;
        public decimal _SalarioDiarioOrdinario;
        private int idCurrency;

        public Empleado()
        {

        }

        public string Pin { get => _pin; set => _pin = value; }
        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        /// <summary>
        /// Indica la moneda del Salario. Ejemplo: 1=Lempiras     2=USD
        /// </summary>
        public int IdCurrency { get => idCurrency; set => idCurrency = value; }

        //public string RecuperarIdFromPin(int id)
        //{
        //    string a = "";
        //    try
        //    {
        //        string sql = @"select id
        //                        from public.hr_employee hh
        //                        where hh.id = " + id;
        //        DataOperations op = new DataOperations();
        //        PgSqlConnection Conn = new PgSqlConnection(op.ConnectionStringJAGUAR_DB);
        //        Conn.Open();
        //        PgSqlCommand cmd = new PgSqlCommand(sql, Conn);
        //        a = cmd.ExecuteScalar().ToString();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //    return a;
        //}


        //public bool RecuperarIdFromCode(string pcode)
        //{
        //    bool a = false;
        //    try
        //    {
        //        string sql = @"SELECT id,
        //                              name
        //                            FROM public.hr_employee ee
        //                            where ee.barcode = :codigo";
        //        DataOperations op = new DataOperations();
        //        PgSqlConnection Conn = new PgSqlConnection(op.ConnectionStringJAGUAR_DB);
        //        Conn.Open();
        //        PgSqlCommand cmd = new PgSqlCommand(sql, Conn);
        //        cmd.Parameters.AddWithValue("codigo", pcode);
        //        PgSqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            Id = dr.GetInt32(0);
        //            Nombre = dr.GetString(1);
        //            a = true;
        //        }
        //        dr.Close();
        //        Conn.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //    return a;
        //}

        //public bool RecuperarDatosForLiquidacion(int _idEmpleado)
        //{
        //    bool a = false;
        //    try
        //    {
        //        string sql = @"select * from public.ft_get_header_liquidacion_acs (:_id_empleado);";
        //        DataOperations op = new DataOperations();
        //        PgSqlConnection Conn = new PgSqlConnection(op.ConnectionStringJAGUAR_DB);
        //        Conn.Open();
        //        PgSqlCommand cmd = new PgSqlCommand(sql, Conn);
        //        cmd.Parameters.AddWithValue("_id_empleado",_idEmpleado);
        //        PgSqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            _idcontrato = dr.GetInt32(0);
        //            _puesto = dr.GetString(1);
        //            _FechaInicio = dr.GetDateTime(2);
        //            _FechaFin = dr.GetDateTime(3);
        //            _Salario = dr.GetDecimal(4);
        //            _antiguedad = dr.GetString(5);
        //            _salarioBaseDiario = dr.GetDecimal(6);
        //            _salarioBaseMensual = dr.GetDecimal(7);
        //            _SalarioDiarioOrdinario = dr.GetDecimal(8);
        //            IdCurrency = dr.GetInt32(9);
        //            a = true;
        //        }
        //        dr.Close();
        //        Conn.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //    return a;
        //}






    }
}
