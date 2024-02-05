using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace JAGUAR_APP.Utileria
{
    public partial class frmMensajeCalidad : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoMsj
        {
            error = 1,
            info = 2
        }
        TipoMsj TipoMensajeActual;
        public frmMensajeCalidad(TipoMsj ptipo, string msj)
        {
          
            InitializeComponent();
            labelControl1.Text = msj;
            TipoMensajeActual = ptipo;
            switch (ptipo)
            {
                case TipoMsj.error:
                    msjBoxIcon.Image = pictureBoxError.Image;
                    break;
                case TipoMsj.info:
                    msjBoxIcon.Image = pictureBoxInfomation.Image;
                    break;
            }
        }

        public frmMensajeCalidad(TipoMsj ptipo, string msj, int time)
        {
            InitializeComponent();
            labelControl1.Text = msj;
            TipoMensajeActual = ptipo;
            switch (ptipo)
            {
                case TipoMsj.error:
                    msjBoxIcon.Image = pictureBoxError.Image;
                    break;
                case TipoMsj.info:
                    msjBoxIcon.Image = pictureBoxInfomation.Image;
                    break;
            }
            timer1.Interval = time;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}