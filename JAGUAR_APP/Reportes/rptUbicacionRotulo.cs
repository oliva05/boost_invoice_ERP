using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace JAGUAR_APP.Reportes
{
    public partial class rptUbicacionRotulo : DevExpress.XtraReports.UI.XtraReport
    {
        public rptUbicacionRotulo(string Rack, string code)
        {
            InitializeComponent();
            lblRack.Text = Rack;
            xrBarCode1.Text = xrBarCode2.Text = code;
        }

    }
}
