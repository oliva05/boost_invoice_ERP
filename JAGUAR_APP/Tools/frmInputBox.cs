using ACS.Classes;
using Core.Clases.Herramientas;
using JAGUAR_APP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Tools
{
    public partial class frmInputBox : Form
    {

        public bool ValidInteger;
        public int Numero_transaccion, id_lote_externo;
        private int id_tarima;
        public int unidades_x_tarima; 
        public decimal peso_x_tarima;
        private int IsTrasladoMP;
        public string LoteMP;
        
        public frmInputBox(int pnumero_Transaccion, int pid_tarima, int pIdLoteExterno)
        {
            InitializeComponent();
            Numero_transaccion = pnumero_Transaccion;
            id_tarima = pid_tarima;

            if(pIdLoteExterno>0)
                LoadDetalle_lote_salida(pIdLoteExterno);

            txtValue.Text = "1";

            Transferencia Traslado = new Transferencia();
            Traslado.RecuIsTraslado(Numero_transaccion);
            IsTrasladoMP = Traslado.IsTraslado1;
            Traslado.RecuIsTraslado(Numero_transaccion);

            if (IsTrasladoMP == 0) //No es traslado! es Duplicar Tarima de Compra Directa
            {
                grdlookLoteExterno.Visible = false;
                labelControl1.Visible = false;
            }
            txtPeso.EditValue = 0;
            txtUnidades.EditValue = 1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (IsTrasladoMP == 1)
            {
                if (string.IsNullOrEmpty(grdlookLoteExterno.Text))
                {
                    CajaDialogo.Error("Debe seleccionar un Lote!");
                    return;
                }
            }
            if (Convert.ToInt32(txtUnidades.EditValue) == 0)
            {
                CajaDialogo.Error("El campo Unidades no puede ser 0");
                return;
            }
            if (Convert.ToDecimal(txtPeso.EditValue) == 0)
            {
                CajaDialogo.Error("El campo Peso no puede ser 0");
                return;
            }

            if (IsTrasladoMP == 1)
            {
                id_lote_externo = Convert.ToInt32(grdlookLoteExterno.EditValue);
                LoteMP = grdlookLoteExterno.Text;
            }
            unidades_x_tarima = Convert.ToInt32(txtUnidades.EditValue);
            peso_x_tarima = Convert.ToDecimal(txtPeso.EditValue);

            if (IsTrasladoMP == 1)
            {
                CajaDialogo.Pregunta("Al duplicar la tarima Rebajara de Bodega Externa, Esta seguro?");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadDetalle_lote_salida(int _pIdLoteExterno)
        {
            //DataOperations dp = new DataOperations();
            //string query = @"sp_get_salida_d_lote_for_numero_ingreso";
            //SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //try
            //{
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand(query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@numero_transaccion", Numero_transaccion);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    dsRecepcionMPx.detalle_lote_externo.Clear();
            //    da.Fill(dsRecepcionMPx.detalle_lote_externo);
            //    cn.Close();

            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}

            //DataOperations dp = new DataOperations();
            //string query = @"sp_get_lista_lotes_factura_ingreso_externo";
            //SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //try
            //{
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand(query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_lote_externo", _pIdLoteExterno);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    dsRecepcionMPx.detalle_lote_externo.Clear();
            //    da.Fill(dsRecepcionMPx.detalle_lote_externo);
            //    cn.Close();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidInteger)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValue_Click(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void frmInputBox_Activated(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
            
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            //subir
            int subir;
           subir = Convert.ToInt32(txtValue.Text);
            subir = subir + 1;
            txtValue.Text = subir.ToString();
        }

        private void txtUnidades_Enter(object sender, EventArgs e)
        {
            Transferencia trans = new Transferencia();
            trans.RecuperarRegistro(Numero_transaccion);

            PresentacionX present = new PresentacionX();
            present.RecuperarRegistro(trans.Id_presentacio);

            txtPeso.EditValue = Convert.ToInt32(txtUnidades.EditValue) * present.Factor;
        }

        private void txtUnidades_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Transferencia trans = new Transferencia();
                trans.RecuperarRegistro(Numero_transaccion);

                Tarima tar1 = new Tarima();
                tar1.RecuperarRegistro(id_tarima);
                
                PresentacionX present = new PresentacionX();
                present.RecuperarRegistro(tar1.IdPresentacion);

                txtPeso.EditValue = Convert.ToInt32(txtUnidades.EditValue) * present.Factor;


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grdlookLoteExterno_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "1")
            {

            }
            else
            {
                int bajar;
                bajar = Convert.ToInt32(txtValue.Text);
                bajar = bajar - 1;
                txtValue.Text = bajar.ToString();

            }
        }
    }
}
