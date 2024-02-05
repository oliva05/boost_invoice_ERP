using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Reportes
{
    public partial class frmrpt_productoterminado : DevExpress.XtraEditors.XtraForm
    {
        public frmrpt_productoterminado()
        {
            InitializeComponent();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frm_reportesMaster frm = new frm_reportesMaster(frm_reportesMaster.Reporte.ExistenciaHastaLaFecha);
            frm.Show();
        }

        private void btnDespachos_Click(object sender, EventArgs e)
        {
            frm_reportesMaster frm = new frm_reportesMaster(frm_reportesMaster.Reporte.IngresoRangoDeFechas);
            frm.Show();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            frm_reportesMaster frm = new frm_reportesMaster(frm_reportesMaster.Reporte.RptFechaVencimiento);
            frm.Show();
            
        }
    }
}