using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace JAGUAR_APP.AlmacenesExterno.Reporteria
{
    public partial class xsr_traslado_lotes : DevExpress.XtraReports.UI.XtraReport
    {
        public xsr_traslado_lotes()
        {
            InitializeComponent();

            //dsTrasladoLotes.Queries[0].Parameters[0].Value = this.Parameters["ID_H"].Value;
        }

    }
}
