using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class xfrmDialogFormatoFactura : DevExpress.XtraEditors.XtraForm
    {
        Factura factura = new Factura();
        int factura_id = 0;
        PDV PuntoVentaActual;
        public xfrmDialogFormatoFactura(int pFactura_id, PDV pPuntoVentaParametro)
        {
            InitializeComponent();
            factura_id = pFactura_id;
            PuntoVentaActual = pPuntoVentaParametro;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (factura.RecuperarRegistro(factura_id))
            {
                if (factura.CantidadImpresionesFactura == 0)
                {
                    rptFactura report = new rptFactura(factura, rptFactura.TipoCopia.Blanco);

                    using (ReportPrintTool printTool = new ReportPrintTool(report))
                    {
                        // Send the report to the default printer.
                        factura.UpdatePrintCount(factura_id);
                        printTool.ShowPreviewDialog();
                    }
                }
                else
                {
                    CajaDialogo.Error("Esta factura ya se imprimió! Para una reimpresión debe solicitar una autorización!");
                }
            }
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (factura.RecuperarRegistro(factura_id))
            {
                if (this.PuntoVentaActual.PermiteReimpresionFacturaConAutorizacion)
                {
                    if (factura.CantidadImpresionesFactura == 0)//Cantidad de impresiones de la factura
                    {
                        if (factura.IdNumeracionFiscal == 0)
                        {
                            rptFact_ReciboVentaLetterSize report = new rptFact_ReciboVentaLetterSize(factura, rptFact_ReciboVentaLetterSize.TipoCopia.Blanco);

                            using (ReportPrintTool printTool = new ReportPrintTool(report))
                            {
                                // Send the report to the default printer.
                                factura.UpdatePrintCount(factura_id);
                                printTool.ShowPreviewDialog();
                            }
                        }
                        else
                        {
                            rptFacturaLetterSize report = new rptFacturaLetterSize(factura, rptFacturaLetterSize.TipoCopia.Blanco);

                            using (ReportPrintTool printTool = new ReportPrintTool(report))
                            {
                                // Send the report to the default printer.
                                factura.UpdatePrintCount(factura_id);
                                printTool.ShowPreviewDialog();
                            }
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("Esta factura ya se imprimió! Para una reimpresión debe solicitar una autorización!");
                    }
                }
                else
                {
                    rptFacturaLetterSize report = new rptFacturaLetterSize(factura, rptFacturaLetterSize.TipoCopia.Blanco);

                    using (ReportPrintTool printTool = new ReportPrintTool(report))
                    {
                        // Send the report to the default printer.
                        factura.UpdatePrintCount(factura_id);
                        printTool.ShowPreviewDialog();
                    }
                }
            }
            this.Close();
        }
    }
}