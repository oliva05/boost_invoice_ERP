using ACS.Classes;
using DevExpress.CodeParser;
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

namespace JAGUAR_APP.LogisticaJaguar.Despacho
{
    public partial class frmRecepcionItem : DevExpress.XtraEditors.XtraForm
    {
        decimal CantTotalTraslado;
        decimal CantAcumuladaRecepcionada;
        public decimal CantActual;
        decimal CantRestante;
        DataOperations dp;
        public frmRecepcionItem(decimal pCantTotalTraslado, decimal pCantAcumuladaRecepcionada, string pItemCode, string pItemName)
        {
            InitializeComponent();
            txtCodigo.Text = pItemCode;
            txtNombre.Text = pItemName;
            txtCantidadTraslado.Text = string.Format("{0:###,##0.00}", pCantTotalTraslado);
            txtAcumuladoRecepcionado.Text = string.Format("{0:###,##0.00}", pCantAcumuladaRecepcionada);
            CantTotalTraslado = pCantTotalTraslado;
            CantAcumuladaRecepcionada= pCantAcumuladaRecepcionada;
            CantActual = 0;
            CantRestante = CantTotalTraslado- CantAcumuladaRecepcionada;
            txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantRestante);
            dp = new DataOperations();
            txtCantidadRecepcionActual.Focus();
        }

        private void txtCantidadRecepcionActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cdmCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtCantidadRecepcionActual_Validating(object sender, CancelEventArgs e)
        {
            CantActual = dp.ValidateNumberDecimal(txtCantidadRecepcionActual.EditValue);
            CantRestante = CantTotalTraslado - CantAcumuladaRecepcionada - CantActual;
        }

        private void cdmConfirmar_Click(object sender, EventArgs e)
        {
            if (CantActual <= 0)
            {
                CajaDialogo.Error("No se permite recepcionar cantidades menores o iguales a cero!");
                return;
            }

            if ((CantActual + CantAcumuladaRecepcionada) > CantTotalTraslado)
            {
                CajaDialogo.Error("La cantidad a recepcionar no puede exceder de la cantidad pendiente de recibir!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmRecepcionItem_Activated(object sender, EventArgs e)
        {
            txtCantidadRecepcionActual.Focus();
        }
    }
}