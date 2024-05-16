using DevExpress.XtraReports.UI;
using JAGUAR_APP.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    public partial class subRptCotizacion : DevExpress.XtraReports.UI.XtraReport
    {
        public subRptCotizacion()
        {
            InitializeComponent();

 

            //Cotizacion coti = new Cotizacion();
            //coti.RecuperarRegistro(PidCotizacion);
            //lblcliente.Text = coti.Cliente;
            //lblRTN.Text = coti.RTN;
            //lblTelefono.Text = coti.Telefono;
            //lblEmail.Text = coti.Email;
            //lblContacto.Text = coti.Contacto;
            //lblFecha.Text = string.Format("{0:d}", coti.FechaEmision);
            //lblFechaVenc.Text = string.Format("{0:d}", coti.FechaVencimiento);
            //lblNumCoti.Text = "N#: 000" + coti.NumCotizacion.ToString();
            //lblUsuario.Text = coti.Usuario;

            //lblSub.Text = string.Format("{0:#,###,##0.00}", coti.SubTotal);
            //lblIsv15.Text = string.Format("{0:#,###,##0.00}", coti.ISV);
            //lblTotal.Text = string.Format("{0:#,###,##0.00}", coti.Total);

            ////PuntoVenta
            //PDV pdv = new PDV();
            //pdv.RecuperaRegistro(coti.PuntoVentaId);
            //lblDireccionPuntoVenta.Text = pdv.Direccion;
            //lblEmailPDV.Text = pdv.Correo;
            //lblTelefonoPDV.Text = pdv.RTN + " " + pdv.Telefono;
        }

    }
}
