using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_APP.Reportes
{
    public partial class rptHistoricoPT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHistoricoPT(DateTime FechaInicio,DateTime FechaFin)
        {
            InitializeComponent();
            LoadData(FechaInicio, FechaFin);

            lblFecha.Text = FechaInicio.ToShortDateString() + " Hasta " + FechaFin.ToShortDateString();
        }

        private void LoadData(DateTime pFechaInicio, DateTime pFechaFin)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.rpt_kardex_pt_historico", cnx);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("fecha_i", pFechaInicio);
                    da.SelectCommand.Parameters.Add("fecha_f", pFechaFin);

                    dsReportesInventario1.inventario_kardex_historico.Clear();
                    da.Fill(dsReportesInventario1.inventario_kardex_historico);


                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
