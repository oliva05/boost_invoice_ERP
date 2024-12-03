using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraSpreadsheet.Import.Xls;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Facturacion.Reportes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmPagoFactura : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public ArrayList ListaDetallePago;
        public enum TipoPago
        {
            Efectivo = 1,
            Tarjeta = 2,
            DepositoBancario = 3
        }

        public TipoPago TipoPagoSeleccionadoActual;
        public decimal ValorA_Pagar;
        public decimal varPago;

        //Saldo total al combinar pagos.
        decimal Saldo;

        //Suma total de la combinacion de pagos
        decimal SumaTotal;

        public int IdFormato;
        public string PrinterName;
        public string ReferenciaReciboPago;

        PDV PuntoVentaActual;

        public frmPagoFactura(UserLogin pUsuarioLogeado, decimal pValorA_Pagar, PDV pPuntoVentaActual)
        {
            InitializeComponent();
            dp = new DataOperations();
            PuntoVentaActual = pPuntoVentaActual;

            this.UsuarioLogeado = pUsuarioLogeado;
            ValorA_Pagar = pValorA_Pagar;
            lblTotalPagoRequerido.Text = string.Format("{0: L #,###,##0.00}", pValorA_Pagar);
            txtValorEfectivo.Text = txtValorTC.Text = txtValorPagarTransferencia.Text = string.Format("{0:###,##0.00}", pValorA_Pagar);

            TipoPagoSeleccionadoActual = TipoPago.Efectivo;
            SetButtonPago();
            
            SetRadioButtonFormatt();
            GetPrintersNames();
        }

        private void SetRadioButtonFormatt()
        {
            switch (PuntoVentaActual.IdFormatoFactura)
            {
                case 1:
                    radioGroup1.EditValue = 1;
                    radioGroup2.EditValue = 1;
                    radioGroup3.EditValue = 1;
                    radioGroup1.ReadOnly = true;
                    radioGroup2.ReadOnly = true;
                    radioGroup3.ReadOnly = true;
                    break;
                case 2:
                    radioGroup1.EditValue = 2;
                    radioGroup2.EditValue = 2;
                    radioGroup3.EditValue = 2;
                    radioGroup1.ReadOnly = true;
                    radioGroup2.ReadOnly = true;
                    radioGroup3.ReadOnly = true;
                    break;
            }
            
        }

        private void GetPrintersNames()
        {
            //PrintersConfig conf = new PrintersConfig(PsConnection);
            //int id = conf.getIdPrinterDefault();
            //if (id > 0)
            //{
            //    radioGroup1.EditValue = id;
            //}

            //if (PuntoVentaActual.Recuperado)
            //{

                ListboxPrintersEfectivo.Items.Clear();
                foreach (string printname in PrinterSettings.InstalledPrinters)
                {
                    //Console.WriteLine(printname);

                    //if (conf.Key == printname)
                    //{
                    //    ListboxPrinters.Items.Add(printname, true);
                    //}
                    //else
                    //{
                    //    ListboxPrinters.Items.Add(printname, false);
                    //}
                    ListboxPrintersEfectivo.Items.Add(printname, false);
                }

                ListboxPrintersTransferencia.Items.Clear();
                foreach (string printname in PrinterSettings.InstalledPrinters)
                {
                    //Console.WriteLine(printname);

                    //if (conf.Key == printname)
                    //{
                    //    ListboxPrinters.Items.Add(printname, true);
                    //}
                    //else
                    //{
                    //    ListboxPrinters.Items.Add(printname, false);
                    //}
                    ListboxPrintersTransferencia.Items.Add(printname, false);
                }

                ListboxPrintersTarjeta.Items.Clear();
                foreach (string printname in PrinterSettings.InstalledPrinters)
                {
                    //Console.WriteLine(printname);

                    //if (conf.Key == printname)
                    //{
                    //    ListboxPrinters.Items.Add(printname, true);
                    //}
                    //else
                    //{
                    //    ListboxPrinters.Items.Add(printname, false);
                    //}
                    ListboxPrintersTarjeta.Items.Add(printname, false);
                }

            
        }

        private void SetButtonPago()
        {
            switch(this.TipoPagoSeleccionadoActual)
            {
                case TipoPago.Efectivo: //1
                    cmdEfectivo.Appearance.BackColor = Color.LightSkyBlue;
                    cmdTarjeta.Appearance.BackColor = Color.White;
                    cmdDepositoBancario.Appearance.BackColor = Color.White;
                    xtraTabPage1.PageVisible = true;
                    xtraTabPage2.PageVisible = 
                    xtraTabPage3.PageVisible = false;
                    break;
                case TipoPago.Tarjeta: //2
                    cmdEfectivo.Appearance.BackColor = Color.White;
                    cmdTarjeta.Appearance.BackColor = Color.LightSkyBlue;
                    cmdDepositoBancario.Appearance.BackColor = Color.White;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage2.PageVisible = true;
                    xtraTabPage3.PageVisible = false;
                    break;
                case TipoPago.DepositoBancario: //3
                    cmdEfectivo.Appearance.BackColor = Color.White;
                    cmdTarjeta.Appearance.BackColor = Color.White;
                    cmdDepositoBancario.Appearance.BackColor = Color.LightSkyBlue;
                    xtraTabPage1.PageVisible = 
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage3.PageVisible = true;
                    break;
            }
        }

        private void cmdEfectivo_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = xtraTabPage1;
            TipoPagoSeleccionadoActual = TipoPago.Efectivo;
            SetButtonPago();
            txtEntregado.Focus();
        }

        private void cmdTarjeta_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = xtraTabPage2;
            TipoPagoSeleccionadoActual = TipoPago.Tarjeta;
            SetButtonPago();
        }

        private void cmdDepositoBancario_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = xtraTabPage3;
            TipoPagoSeleccionadoActual = TipoPago.DepositoBancario;
            LoadCuentas();
            SetButtonPago();
        }

        private void LoadCuentas()
        {
            try
            {
                string query = @"sp_cuentas_activas";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRegistroPagos1.cuentas.Clear();
                adat.Fill(dsRegistroPagos1.cuentas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        void calcularCambio()
        {
            if (!string.IsNullOrEmpty(txtEntregado.Text))
            {
                try
                {
                    varPago = Convert.ToDecimal(txtEntregado.Text);
                }
                catch
                {
                    CajaDialogo.Error("Debe ingresar un valor Decimal Valido!");
                    return;
                }
                decimal cambio = varPago - ValorA_Pagar;
                if(cambio < 0) 
                    cambio = 0;

                txtCambio.Text = string.Format("{0:###,##0.00}", cambio);
            }
        }

        private void txtEntregado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularCambio();
                cmdPagar.Focus();
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            calcularCambio();

            if(TipoPagoSeleccionadoActual == TipoPago.DepositoBancario)
            {
                if (string.IsNullOrWhiteSpace(grdCuentas.Text))
                {
                    CajaDialogo.Error("Debe seleccionar una Cuenta");
                    return;
                }
            }


            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
            //    return;
            //}

            varPago = (dp.ValidateNumberDecimal(txtEntregado.Text) - dp.ValidateNumberDecimal(txtCambio.Text));

            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }
            

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }
            string TipoPagoName = "N/D";

            switch (TipoPagoSeleccionadoActual)
            {
                case TipoPago.Efectivo:
                    TipoPagoName = "Efectivo";
                    break;
                case TipoPago.Tarjeta:
                    TipoPagoName = "Tarjeta";
                    break;
                case TipoPago.DepositoBancario:
                    TipoPagoName = "Deposito Bancario";
                    break;
                default:
                    break;
            }

            //AgregarPago(1, "Efectivo", varPago,"N/D");
            AgregarPago((int)TipoPagoSeleccionadoActual, TipoPagoName, varPago, "N/D");

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void AgregarPago(int IdPago, string NombrePago, decimal vValor, string pReferencia)
        {
            Saldo = 0;
            int ExistePreviamente = 0;
            SumaTotal = 0;
            foreach(dsRegistroPagos.resumen_pagoRow row in dsRegistroPagos1.resumen_pago)
            {
                if (row.id == IdPago)
                {
                    ExistePreviamente++;
                    break;
                }
            }

            if (ExistePreviamente <= 0)
            {
                //Agregamos un nuevo Row
                dsRegistroPagos.resumen_pagoRow row1 = dsRegistroPagos1.resumen_pago.Newresumen_pagoRow();
                row1.id = IdPago;
                row1.descripcion = NombrePago;
                row1.valor = vValor;
                row1.tipo_id = IdPago;
                row1.referencia = pReferencia;
                if (TipoPagoSeleccionadoActual == TipoPago.DepositoBancario)
                    row1.id_cuenta = Convert.ToInt32(grdCuentas.EditValue);
                else
                    row1.id_cuenta = 0;


                dsRegistroPagos1.resumen_pago.Addresumen_pagoRow(row1);
                dsRegistroPagos1.AcceptChanges();
            }
            else
            {
                //Actualizamos el row existente
                foreach (dsRegistroPagos.resumen_pagoRow row in dsRegistroPagos1.resumen_pago)
                {
                    if (row.id == IdPago)
                        row.valor = vValor;

                    //if (row.id == 3)//Deposito Bancario
                    row.referencia = pReferencia;

                    //SumaTotal += vValor;
                }

                //lblResumenPagosTotal.Text = string.Format("{0:###,##0.00}", SumaTotal);
            }

            foreach (dsRegistroPagos.resumen_pagoRow row in dsRegistroPagos1.resumen_pago)
            {
                SumaTotal += row.valor;
            }

            Saldo = ValorA_Pagar - SumaTotal;
            lblSaldo.Text = string.Format("{0:L #,###,##0.00}", Saldo); 

            if (Saldo == 0)
            {
                //Verde
                lblSaldo.ForeColor = Color.LightGreen;
            }
            else
            {
                //Rojo
                lblSaldo.ForeColor = Color.LightCoral;
            }

            lblResumenPagosTotal.Text = string.Format("{0:L #,###,##0.00}", SumaTotal);
        }


        private void ListboxPrinters_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularCambioTC();
                cmdPagar.Focus();
            }
        }

        private void calcularCambioTC()
        {
            if (!string.IsNullOrEmpty(txtEntregadoTC.Text))
            {
                try
                {
                    varPago = Convert.ToDecimal(txtEntregadoTC.Text);
                }
                catch
                {
                    CajaDialogo.Error("Debe ingresar un valor Decimal Valido!");
                    return;
                }
                decimal cambio = varPago - ValorA_Pagar;
                //txtCambio.Text = string.Format("{0:###,##0.00}", cambio);
            }
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            calcularCambioTC();
            varPago = dp.ValidateNumberDecimal(txtEntregadoTC.Text);

            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
            //    return;
            //}

            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }

            AgregarPago(2, "Tarjeta", varPago, "N/D");
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            varPago = spinEdit1.Value;
        }

        private void radioGroup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }

        private void checkedListBoxControl2_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            varPago = dp.ValidateNumberDecimal(spinEdit1.Value);
            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor transferido debe ser mayor o igual al de la factura.");
            //    return;
            //}
            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            if (!string.IsNullOrEmpty(txtReferencia.Text))
            {
                ReferenciaReciboPago = txtReferencia.Text;
            }
            else
            {
                ReferenciaReciboPago = "N/D";
            }

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }
            AgregarPago(3, "Deposito Bancario", varPago, ReferenciaReciboPago);
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void txtEntregado_TextChanged(object sender, EventArgs e)
        {
            //calcularCambio();
            //cmdPagar.Focus();
        }

        private void txtEntregado_Validated(object sender, EventArgs e)
        {
            calcularCambio();
            cmdPagar.Focus();
        }

        private void txtEntregadoTC_Validated(object sender, EventArgs e)
        {
            calcularCambioTC();
            cmdPagar.Focus();
        }

        private void txtEntregado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEntregadoTC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtReferencia_Validated(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtReferencia.Text)) 
            {
                ReferenciaReciboPago = txtReferencia.Text;
            }
        }

        private void spinEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            varPago = spinEdit1.Value;
        }

        private void txtEntregado_TextChanged_1(object sender, EventArgs e)
        {
            calcularCambio();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(SumaTotal<=0)
            {
                CajaDialogo.Error("Es necesario ingresar un pago mayor a cero (0) para continuar...");
                return;
            }

            if(ListaDetallePago == null)
                ListaDetallePago = new ArrayList();

            
            foreach (dsRegistroPagos.resumen_pagoRow row in dsRegistroPagos1.resumen_pago)
            {
                RegistroPago PagoParcial = new RegistroPago();
                PagoParcial.Id = row.id;

                if (row.id == 3)
                    PagoParcial.Referencia = row.referencia;
                else
                    PagoParcial.Referencia = "N/D";

                PagoParcial.IdTipo = row.tipo_id;

                PagoParcial.Description = row.descripcion;
                PagoParcial.Valor = row.valor;
                PagoParcial.IdCuenta = row.id_cuenta;
                ListaDetallePago.Add(PagoParcial);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}