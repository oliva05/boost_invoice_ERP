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
    public class Funciones
    {
        public Funciones()
        {
        }

        public decimal GetDifHorasforDecimal(DateTime desde, DateTime hasta)
        {
            decimal val = 0;
            try
            {
                //int horai = desde.Hour;
                //int horaf = hasta.Hour;

                //int mini = desde.Minute;
                //int minf = hasta.Minute;
                double valm = (hasta - desde).TotalMinutes;
                decimal difh = (Convert.ToDecimal( valm) / 60);
                //decimal h = Math.Truncate(difh);
                //decimal m = difh - h;
                val = difh;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }


        public string GetDifHorasforString(DateTime desde, DateTime hasta)
        {
            string res = "";
            try
            {
                //int horai = desde.Hour;
                //int horaf = hasta.Hour;

                //int mini = desde.Minute;
                //int minf = hasta.Minute;

                double difh = (hasta - desde).TotalMinutes / 60;
                decimal h = Math.Truncate(Convert.ToDecimal(difh));
                decimal m = Convert.ToDecimal(difh) - h;


                string hora = h.ToString();
                string Min = m.ToString();
                if (hora.Length <= 1)
                    hora = "0" + h.ToString();

                Min =  Math.Round((h*60),2).ToString();
                res = hora + ":" + Min;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return res;
        }

        public string GetDifHorasforStringFromDecimal(decimal valor)
        {
            string res = "";
            try
            {
                //int horai = desde.Hour;
                //int horaf = hasta.Hour;

                //int mini = desde.Minute;
                //int minf = hasta.Minute;

                decimal difh = valor / 60;
                decimal h = Math.Truncate(difh);
                decimal m = difh - h;


                string hora = h.ToString();
                string Min = m.ToString();
                if (hora.Length <= 1)
                    hora = "0" + h.ToString();

                Min = Math.Round((h * 60), 2).ToString();
                res = hora + ":" + Min;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return res;
        }

        public decimal GetHoras_acumuladasLinea(int pidH, int pLinea)
        {
            decimal valor = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_horas_lote_prb_eficiencia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", pidH);
                cmd.Parameters.AddWithValue("@idlinea", pLinea);
                valor = Convert.ToDecimal(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }






    }
}
