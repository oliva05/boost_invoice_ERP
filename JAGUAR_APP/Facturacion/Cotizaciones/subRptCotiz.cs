using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    public partial class subRptCotiz : DevExpress.XtraReports.UI.XtraReport
    {
        int IDcotizcion = 0;
        public subRptCotiz()
        {
            InitializeComponent();
            //IDcotizcion = Convert.ToInt32(SubIdCotizacion.Value);
        }

    }
}
