using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.LogisticaJaguar.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_APP.LogisticaJaguar
{
    public partial class xrptRecepcionFacturas : DevExpress.XtraReports.UI.XtraReport
    {
        //RecepcionFacturasProveedor factura_h = new RecepcionFacturasProveedor();

        public xrptRecepcionFacturas(RecepcionFacturasProveedor factura_h)
        {
            InitializeComponent();
            string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Juio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            xrlDocNum.Text = factura_h.NumeroFactura;
            xrlProveedor.Text = factura_h.Proveedor;
            xrlFecha.Text ="San Pedro Sula "+ factura_h.Fecha.Day.ToString().PadLeft(2,'0')+" de "+ Meses[factura_h.Fecha.Month-1]+" del "+  factura_h.Fecha.Year;
            xrlEntregadoPor.Text = factura_h.EntregadoPor;
            xrlEntregadoPorIdentidad.Text = factura_h.EntregadoPorIdentidad;
            xrlEntregadoPorTelefono.Text = factura_h.EntregadoPorTelefono;
            xrlEntregadoPorHora.Text = factura_h.EntregadoPorHora.ToShortTimeString();
            xrlRecibidoPor.Text = factura_h.RecibidoPor;
            xrlRecibipoPorHora.Text = factura_h.RecibidoPorHora.ToShortTimeString();
            xrlRevisadoPor.Text = factura_h.RevisadoPor;
            xrlRevisadoPorHora.Text = factura_h.RevisadoPorHora.ToShortTimeString();
            xrlObservaciones.Text = factura_h.Observaciones;
            lblDocNum.Text = "# Documento: " + factura_h.DocNum.ToString();
            GetDetailFactura(factura_h.ID);

        }

        private void GetDetailFactura(Int64 id_h)
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter("dbo.[usp_GetDetailFacturaProveedor_v2]", cnx);
                dsLogisticaJaguar1.Detalle_Recepcion_Facturas_rpt.Clear();
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id_h", System.Data.SqlDbType.Int).Value = id_h;
                da.Fill(dsLogisticaJaguar1.Detalle_Recepcion_Facturas_rpt);
                cnx.Close();
            }

        }

    }
}
