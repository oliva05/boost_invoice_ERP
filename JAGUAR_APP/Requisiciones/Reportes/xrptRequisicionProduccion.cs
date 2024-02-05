using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static JAGUAR_APP.Clases.Conf_TablesID;

namespace JAGUAR_APP.Requisiciones.Reportes
{
    public partial class xrptRequisicionProduccion : DevExpress.XtraReports.UI.XtraReport
    {
        Conf_TablesID confTable = new Conf_TablesID();
        public xrptRequisicionProduccion(int id )
        {
            InitializeComponent();
            LoadHeader(id);
            LoadDetail(id);
            LoadDetailMP_Entregada(id);
            xrTblFechaHoy.Text = DateTime.Now.ToString();
            //xrTblComentario.Text = "Comentario:" + xrTblComentario.Text;
        }

        private void LoadHeader(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                   SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("dbo.usp_rpt_get_requisicion_by_id", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id_h);
                    dSReportes1.requisiciones_h_rpt.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dSReportes1.requisiciones_h_rpt);
                    xrTblDoc.Text = confTable.GetFormatCode(Convert.ToInt32( dSReportes1.requisiciones_h_rpt.Rows[0][8].ToString()),(int)TablesIDOptions.RequisicionesMP);
                    //[requisiciones_h_rpt].[DocEntry]
                 con.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void LoadDetail(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    //SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    //con.Open();
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("[dbo].[sp_get_requisicion_detalle_v3]", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_req_header", id_h);
                    dSReportes1.rpt_requisicion_d.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dSReportes1.rpt_requisicion_d);
                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadDetailMP_Entregada(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_rpt_get_requisicion_mp_entregada", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_req_header", id_h);
                    dSReportes1.rpt_requisicion_mp_entrega.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dSReportes1.rpt_requisicion_mp_entrega);
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
