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

namespace JAGUAR_APP.Despachos
{
    public partial class frm_seleccionUD : DevExpress.XtraEditors.XtraForm
    {
      public int Ud;
        int Max;
        public frm_seleccionUD(decimal Pud)
        {
            InitializeComponent();
            Ud =Convert.ToInt32(Pud);
            Ud = Convert.ToInt32(Pud);
            Max = Convert.ToInt32(Pud);
            txtUnidades.Text = Ud.ToString();
        }
        public frm_seleccionUD(decimal Pud, string ParaDiferenciarTipos)
        {
            InitializeComponent();
            Ud = Convert.ToInt32(Pud);
            Ud = Convert.ToInt32(Pud);
            Max = Convert.ToInt32(Pud+ 5);
            txtUnidades.Text = Ud.ToString();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            if ((Ud + 1 ) > Max)
            {

            }
            else
            {
                Ud = Ud + 1;
                txtUnidades.Text = Ud.ToString();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int temp = Ud - 1;
            if (temp == 0)
            {

            }
            else
            {
                Ud = Ud - 1;
                txtUnidades.Text = Ud.ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Ud = Convert.ToInt32(txtUnidades.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}