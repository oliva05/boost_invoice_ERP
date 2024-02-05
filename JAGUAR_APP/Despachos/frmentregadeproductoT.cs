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
using ACS.Classes;
using JAGUAR_APP.Clases;

namespace JAGUAR_APP.Despachos
{
    public partial class frmentregadeproductoT : DevExpress.XtraEditors.XtraForm
    {
        UserLogin User;
        public frmentregadeproductoT(UserLogin UsuarioLogeado)
        {
            InitializeComponent();
            User = UsuarioLogeado;
        }

        private void cmdDetalleMP_Click(object sender, EventArgs e)
        {
            frmplanesdecarga frm = new frmplanesdecarga(User);
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEntrega_Click(object sender, EventArgs e)
        {
            frmEntregaTarimaReqPT frm = new frmEntregaTarimaReqPT(User);
            frm.Show();
        }
    }
}