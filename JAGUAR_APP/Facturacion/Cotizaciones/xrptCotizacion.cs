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

            Id_cotizacion.Value = pid;

            Cotizacion coti = new Cotizacion();
            coti.RecuperarRegistro(pid);
            lblcliente.Text = lblcliente2.Text = coti.Cliente;
            lblRTN.Text = lblRTN2.Text = coti.RTN;
            lblTelefono.Text = lblTelefono2.Text = coti.Telefono;
            lblEmail.Text = lblEmail2.Text = coti.Email;
            lblContacto.Text = lblContacto2.Text = coti.Contacto;
            lblFecha.Text = lblFecha2.Text = string.Format("{0:d}", coti.FechaEmision);
            lblFechaVenc.Text = lblFechaVenc2.Text = string.Format("{0:d}", coti.FechaVencimiento);
            lblNumCoti.Text  = lblNumCoti2.Text = "N#: 000" + coti.NumCotizacion.ToString();
            lblUsuario.Text = lblUsuario2.Text = coti.Usuario;

            lblSub.Text = lblSub2.Text = string.Format("{0:L#,###,##0.00}", coti.SubTotal);
            lblIsv15.Text = lblIsv152.Text = string.Format("{0:L#,###,##0.00}", coti.ISV);
            lblTotal.Text = lblTotal2.Text = string.Format("{0:L#,###,##0.00}", coti.Total);
            //string.Format("{0:L###,##0.00}", liqu.salario_base);
            //PuntoVenta
            PDV pdv = new PDV();
            pdv.RecuperaRegistro(coti.PuntoVentaId);
            lblTituloEmpresa.Text = lblTituloEmpresa2.Text = pdv.NombreLegal;
            lblDireccionPuntoVenta.Text  = lblDireccionPuntoVenta2.Text = pdv.Direccion;
            lblEmailPDV.Text = lblEmailPDV2.Text = pdv.Correo;
            lblTelefonoPDV.Text = lblTelefonoPDV2.Text = "RTN: "+ pdv.RTN + " Tele: " + pdv.Telefono;

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
