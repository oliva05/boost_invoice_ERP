using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ACS.Classes;

namespace JAGUAR_APP.Classes
{
    public class Liquidacion
    {
        #region Miembros Header    
        public bool recuperado;
        public int id_liquidacion;
        public string codigo;
        public int id_empleado;
        public string empleado;
        public string puesto;
        public DateTime fecha_creacion;
        public DateTime fecha_ingreso;
        public DateTime fecha_egreso;
        public string antiguedad;
        public decimal salario_base;
        public decimal promedio_base;
        public decimal salario_pro_mensual;
        public decimal promedio_diario_extrpromedio_diario_extr;
        public bool enable;
        public decimal dias_a_pagar;
        public int id_user_creador;
        public string usuario_creador;
        public bool aplica_cesantia;
        public int id_porcentaje;
        private decimal porcentaje;
        private decimal diasTomados;
        private bool aplica_preaviso;

        public string operacion = "";

        public decimal DiasTomados { get => diasTomados; set => diasTomados = value; }
        public decimal Porcentaje { get => porcentaje; set => porcentaje = value; }
        public decimal Preaviso { get => _preaviso_dias; set => _preaviso_dias = value; }
        public decimal Preaviso_total { get => _preaviso_total; set => _preaviso_total = value; }
        public decimal Cesantia_dias { get => _cesantia_dias; set => _cesantia_dias = value; }
        public decimal Cesantia_total { get => _cesantia_total; set => _cesantia_total = value; }
        public decimal Cesantia_prop_dias { get => _cesantia_prop_dias; set => _cesantia_prop_dias = value; }
        public decimal Cesantia_prop_total { get => _cesantia_prop_total; set => _cesantia_prop_total = value; }
        public decimal Vacaciones_dias { get => _vacaciones_dias; set => _vacaciones_dias = value; }
        public decimal Vacaciones_total { get => _vacaciones_total; set => _vacaciones_total = value; }
        public decimal Vacaciones_prop_dias { get => _vacaciones_prop_dias; set => _vacaciones_prop_dias = value; }
        public decimal Vacaciones_prop_total { get => _vacaciones_prop_total; set => _vacaciones_prop_total = value; }
        public decimal Decimo_cuarto_dias { get => _decimo_cuarto_dias; set => _decimo_cuarto_dias = value; }
        public decimal Decimo_cuarto_total { get => _decimo_cuarto_total; set => _decimo_cuarto_total = value; }
        public decimal Decimo_tercero_dias { get => _decimo_tercero_dias; set => _decimo_tercero_dias = value; }
        public decimal Decimo_tercero_total { get => _decimo_tercero_total; set => _decimo_tercero_total = value; }
        public decimal Total_derechos { get => _total_derechos; set => _total_derechos = value; }
        public string Mes1er { get => _mes1er; set => _mes1er = value; }
        public decimal Sueldo1erMes { get => _sueldo1erMes; set => _sueldo1erMes = value; }
        public string Mes2do { get => _mes2do; set => _mes2do = value; }
        public decimal Sueldo2doMes { get => _sueldo2doMes; set => _sueldo2doMes = value; }
        public decimal Comisiones1erMes { get => _comisiones1erMes; set => _comisiones1erMes = value; }
        public decimal Bono1erMes { get => _bono1erMes; set => _bono1erMes = value; }
        public decimal Incentivo1erMes { get => _incentivo1erMes; set => _incentivo1erMes = value; }
        public decimal HorasE1Mes { get => _horasE1Mes; set => _horasE1Mes = value; }
        public decimal Total1erMes { get => _total1erMes; set => _total1erMes = value; }
        public decimal Comisiones2doMes { get => _comisiones2doMes; set => _comisiones2doMes = value; }
        public decimal Bono2doMes { get => _bono2doMes; set => _bono2doMes = value; }
        public decimal Incentivo2doMes { get => _incentivo2doMes; set => _incentivo2doMes = value; }
        public decimal HorasE2doMes { get => _horasE2doMes; set => _horasE2doMes = value; }
        public decimal Total2doMes { get => _total2doMes; set => _total2doMes = value; }
        public string Mes3er { get => _mes3er; set => _mes3er = value; }
        public decimal Sueldo3erMes { get => _sueldo3erMes; set => _sueldo3erMes = value; }
        public decimal Comisiones3erMes { get => _comisiones3erMes; set => _comisiones3erMes = value; }
        public decimal Bono3erMes { get => _bono3erMes; set => _bono3erMes = value; }
        public decimal Incentivo3erMes { get => _incentivo3erMes; set => _incentivo3erMes = value; }
        public decimal HorasE3erMes { get => _horasE3erMes; set => _horasE3erMes = value; }
        public decimal Total3erMes { get => _total3erMes; set => _total3erMes = value; }
        public string Mes4to { get => _mes4to; set => _mes4to = value; }
        public decimal Sueldo4toMes { get => _sueldo4toMes; set => _sueldo4toMes = value; }
        public decimal Comisiones4toMes { get => _comisiones4toMes; set => _comisiones4toMes = value; }
        public decimal Bono4toMes { get => _bono4toMes; set => _bono4toMes = value; }
        public decimal Incentivo4toMes { get => _incentivo4toMes; set => _incentivo4toMes = value; }
        public decimal HorasE4toMes { get => _horasE4toMes; set => _horasE4toMes = value; }
        public decimal Total4toMes { get => _total4toMes; set => _total4toMes = value; }
        public string Mes5to { get => _mes5to; set => _mes5to = value; }
        public decimal Sueldo5toMes { get => _sueldo5toMes; set => _sueldo5toMes = value; }
        public decimal Comisiones5toMes { get => _comisiones5toMes; set => _comisiones5toMes = value; }
        public decimal Bono5toMes { get => _bono5toMes; set => _bono5toMes = value; }
        public decimal Incentivo5toMes { get => _incentivo5toMes; set => _incentivo5toMes = value; }
        public decimal HorasE5toMes { get => _horasE5toMes; set => _horasE5toMes = value; }
        public decimal Total5toMes { get => _total5toMes; set => _total5toMes = value; }
        public string Mes6to { get => _mes6to; set => _mes6to = value; }
        public decimal Sueldo6toMes { get => _sueldo6toMes; set => _sueldo6toMes = value; }
        public decimal Comisiones6toMes { get => _comisiones6toMes; set => _comisiones6toMes = value; }
        public decimal Bono6toMes { get => _bono6toMes; set => _bono6toMes = value; }
        public decimal Incentivo6toMes { get => _incentivo6toMes; set => _incentivo6toMes = value; }
        public decimal HorasE6toMes { get => _horasE6toMes; set => _horasE6toMes = value; }
        public decimal Total6toMes { get => _total6toMes; set => _total6toMes = value; }
        public string Total6MesesNombre { get => _total6MesesNombre; set => _total6MesesNombre = value; }
        public decimal Totalsueldo { get => _totalsueldo; set => _totalsueldo = value; }
        public decimal Totalcomisiones { get => _totalcomisiones; set => _totalcomisiones = value; }
        public decimal Totalbono { get => _totalbono; set => _totalbono = value; }
        public decimal Totalincentivo { get => _totalincentivo; set => _totalincentivo = value; }
        public decimal Totalhorasextra { get => _totalhorasextra; set => _totalhorasextra = value; }
        public decimal Totaltotal { get => _totaltotal; set => _totaltotal = value; }
        public string Promedio6MesesNombre { get => _promedio6MesesNombre; set => _promedio6MesesNombre = value; }
        public decimal Promediocomisiones { get => _promediocomisiones; set => _promediocomisiones = value; }
        public decimal Promediobono { get => _promediobono; set => _promediobono = value; }
        public decimal Promedioincentivo { get => _promedioincentivo; set => _promedioincentivo = value; }
        public decimal Promediohorasextra { get => _promediohorasextra; set => _promediohorasextra = value; }
        public decimal Promediosueldobase { get => _promediosueldobase; set => _promediosueldobase = value; }
        public decimal Promediototal { get => _promediototal; set => _promediototal = value; }
        public decimal DiasVacaciones { get => _diasVacaciones; set => _diasVacaciones = value; }
        public string DescripcionVacaciones { get => _descripcionVacaciones; set => _descripcionVacaciones = value; }
        public bool Aplica_preaviso { get => aplica_preaviso; set => aplica_preaviso = value; }
        #endregion

        #region Miembros Detalle Derechos
        private decimal _preaviso_dias;
        private decimal _preaviso_total;
        private decimal _cesantia_dias;
        private decimal _cesantia_total;
        private decimal _cesantia_prop_dias;
        private decimal _cesantia_prop_total;
        private decimal _vacaciones_dias;
        private decimal _vacaciones_total;
        private decimal _vacaciones_prop_dias;
        private decimal _vacaciones_prop_total;
        private decimal _decimo_cuarto_dias;
        private decimal _decimo_cuarto_total;
        private decimal _decimo_tercero_dias;
        private decimal _decimo_tercero_total;
        private decimal _total_derechos;
        #endregion


        #region MiembroUltimos6Meses
        //1er Mes del Calculo de los Ultimos 6 Meses
        private string _mes1er; //Nombre del Mes 
        private decimal _sueldo1erMes; //Sueldo Base
        private decimal _comisiones1erMes; //Comisiones
        private decimal _bono1erMes; //Bono
        private decimal _incentivo1erMes; //incentivos
        private decimal _horasE1Mes; //Horas Extras
        private decimal _total1erMes; //Total

        //2do Mes del Calculo de los Ultimos 6 Meses
        private string _mes2do;
        private decimal _sueldo2doMes;
        private decimal _comisiones2doMes;
        private decimal _bono2doMes;
        private decimal _incentivo2doMes;
        private decimal _horasE2doMes;
        private decimal _total2doMes;

        //3er Mes del Calculo de los Ultimos 6 Meses
        private string _mes3er;
        private decimal _sueldo3erMes;
        private decimal _comisiones3erMes;
        private decimal _bono3erMes;
        private decimal _incentivo3erMes;
        private decimal _horasE3erMes;
        private decimal _total3erMes;

        //4to Mes del Calculo de los Ultimos 6 Meses
        private string _mes4to;
        private decimal _sueldo4toMes;
        private decimal _comisiones4toMes;
        private decimal _bono4toMes;
        private decimal _incentivo4toMes;
        private decimal _horasE4toMes;
        private decimal _total4toMes;

        //5to Mes del Calculo de los Ultimos 6 Meses
        private string _mes5to;
        private decimal _sueldo5toMes;
        private decimal _comisiones5toMes;
        private decimal _bono5toMes;
        private decimal _incentivo5toMes;
        private decimal _horasE5toMes;
        private decimal _total5toMes;

        //6to Mes del Calculo de los Ultimos 6 Meses
        private string _mes6to;
        private decimal _sueldo6toMes;
        private decimal _comisiones6toMes;
        private decimal _bono6toMes;
        private decimal _incentivo6toMes;
        private decimal _horasE6toMes;
        private decimal _total6toMes;

        //Cuando es - 1 - Total de Linea (SueldoBase,Comisiones,Bono,Incentivo,HorasExtra,TotalDelMes)
        private string _total6MesesNombre;
        private decimal _totalsueldo;
        private decimal _totalcomisiones;
        private decimal _totalbono;
        private decimal _totalincentivo;
        private decimal _totalhorasextra;
        private decimal _totaltotal;

        //Cuando es -1 - Promedio (SueldoBase,Comisiones,Bono,Incentivo,HorasExtra,TotalDelMes)
        private string _promedio6MesesNombre;
        private decimal _promediosueldobase;
        private decimal _promediocomisiones;
        private decimal _promediobono;
        private decimal _promedioincentivo;
        private decimal _promediohorasextra;
        private decimal _promediototal;
        #endregion

        #region VariablesVacaciones
        private decimal _diasVacaciones;
        private string _descripcionVacaciones;
         
        #endregion

        public bool RecuperarHeaderLiquidacion(int pid)
        {
            operacion = "select";
            recuperado = false;

            string query = @"[sp_get_RRHH_lquidaciones_h_for_id]";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_liquidacion", pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id_liquidacion = pid;
                    id_empleado = dr.GetInt32(0);
                    codigo = dr.GetString(1);
                    empleado = dr.GetString(2);
                    puesto = dr.GetString(3);
                    fecha_creacion = dr.GetDateTime(4);
                    fecha_ingreso = dr.GetDateTime(5);
                    fecha_egreso = dr.GetDateTime(6);
                    antiguedad = dr.GetString(7);
                    salario_base = dr.GetDecimal(8);
                    promedio_base = dr.GetDecimal(9);
                    salario_pro_mensual = dr.GetDecimal(10);
                    promedio_diario_extrpromedio_diario_extr = dr.GetDecimal(11);
                    enable = dr.GetBoolean(12);
                    dias_a_pagar = dr.GetDecimal(13);
                    id_user_creador = dr.GetInt32(14);
                    usuario_creador = dr.GetString(15);
                    aplica_cesantia = dr.GetBoolean(16);
                    id_porcentaje = dr.GetInt32(17);
                    diasTomados = dr.GetDecimal(18);
                    porcentaje = dr.GetDecimal(19);
                    aplica_preaviso = dr.GetBoolean(20);
                    recuperado = true;
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return recuperado;
        }

        public bool RecuperarHeaderLiquidacionForEmpleado(int pid_empleado)
        {
            operacion = "select";
            recuperado = false;

            string query = @"sp_get_RRHH_lquidaciones_h_for_id_empleado";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", pid_empleado);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id_empleado = pid_empleado;
                    id_liquidacion = dr.GetInt32(0);
                    codigo = dr.GetString(1);
                    empleado = dr.GetString(2);
                    puesto = dr.GetString(3);
                    fecha_creacion = dr.GetDateTime(4);
                    fecha_ingreso = dr.GetDateTime(5);
                    fecha_egreso = dr.GetDateTime(6);
                    antiguedad = dr.GetString(7);
                    salario_base = dr.GetDecimal(8);
                    promedio_base = dr.GetDecimal(9);
                    salario_pro_mensual = dr.GetDecimal(10);
                    promedio_diario_extrpromedio_diario_extr = dr.GetDecimal(11);
                    enable = dr.GetBoolean(12);
                    dias_a_pagar = dr.GetDecimal(13);
                    id_user_creador = dr.GetInt32(14);
                    usuario_creador = dr.GetString(15);
                    aplica_cesantia = dr.GetBoolean(16);
                    id_porcentaje = dr.GetInt32(17);
                    diasTomados = dr.GetDecimal(18);
                    porcentaje = dr.GetDecimal(19);
                    aplica_preaviso = dr.GetBoolean(20);
                    recuperado = true;
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return recuperado;

        }

        public bool RecuperarDeducciones(int pid)
        {
            operacion = "select";
            recuperado = false;

            string query = @"";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_liquidacion", pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    recuperado = true;
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return recuperado;

        }

        public bool ActualizarsiRegistros(int pid)
        {
            operacion = "update";
            bool actualizar;
            id_liquidacion = pid;

            actualizar = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@operacion", operacion);
                //cmd.Parameters.AddWithValue("@id", pid);
                //cmd.Parameters.AddWithValue("@name", name);
                //cmd.Parameters.AddWithValue("@car", car);
                //cmd.Parameters.AddWithValue("@license_plate", license_plate);
                //cmd.Parameters.AddWithValue("@creation_date", creation_date);
                //cmd.Parameters.AddWithValue("@fuel", fuel);
                //cmd.Parameters.AddWithValue("@enable", enable);
                cmd.ExecuteNonQuery();
                conn.Close();
                actualizar = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return actualizar;
        }

    }

    
}
