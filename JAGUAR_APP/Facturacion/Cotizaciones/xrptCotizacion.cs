using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    public partial class xrptCotizacion : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public xrptCotizacion(int pid)
        {
            InitializeComponent();
            Cotizacion coti = new Cotizacion();
            coti.RecuperarRegistro(pid);
            lblcliente.Text = coti.Cliente;
            lblRTN.Text = coti.RTN;
            lblTelefono.Text = coti.Telefono;
            lblEmail.Text = coti.Email;
            lblContacto.Text = coti.Contacto;
            lblFecha.Text = string.Format("{0:d}", coti.FechaEmision);
            lblFechaVenc.Text = string.Format("{0:d}", coti.FechaVencimiento);
            lblNumCoti.Text = "N#: 000" + coti.NumCotizacion.ToString();
            lblUsuario.Text = coti.Usuario;

            lblSub.Text = string.Format("{0:#,###,##0.00}", coti.SubTotal);
            lblIsv15.Text = string.Format("{0:#,###,##0.00}", coti.ISV);
            lblTotal.Text = string.Format("{0:#,###,##0.00}", coti.Total);

            //PuntoVenta
            PDV pdv = new PDV();
            pdv.RecuperaRegistro(coti.PuntoVentaId);
            lblDireccionPuntoVenta.Text = pdv.Direccion;
            lblEmailPDV.Text = pdv.Correo;
            lblTelefonoPDV.Text = pdv.RTN + " " + pdv.Telefono;



            CargarDetalle(pid);
        }

        private void CargarDetalle(int pidh)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_cotizacion_detalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pidh);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFactCotizacion1.detalle_cotizacion.Clear();
                adat.Fill(dsFactCotizacion1.detalle_cotizacion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
