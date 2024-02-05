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
using JAGUAR_APP.AlmacenesExterno.Models;
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmLoteCRUD : DevExpress.XtraEditors.XtraForm
    {
        public Ingreso_Externo_Lote lote = new Ingreso_Externo_Lote();
        public xfrmLoteCRUD()
        {
            InitializeComponent();
        }
        public xfrmLoteCRUD(Ingreso_Externo_Lote Plote)
        {
            InitializeComponent();
            lote = Plote;

             txtUnidad.Text = lote.Unidades.ToString();
             txtLote.Text = lote.Lote.ToString();
            txtCantidad.Text = lote.Cantidad.ToString(); ;
            //lote.NumLine = -1;
            deFechaProduccion.EditValue = lote.FechaProduccion ;
            deFechaVencimiento.EditValue =  lote.FechaVencimiento ;
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToDateTime(deFechaProduccion.Text) ==  Convert.ToDateTime(deFechaVencimiento.Text) )
                {
                    CajaDialogo.Error("Las fechas de produccion y vencimiento tienen que ser diferentes.");
                    return;
                }
                if (Convert.ToDateTime(deFechaProduccion.Text) >= Convert.ToDateTime(deFechaVencimiento.Text))
                {
                    CajaDialogo.Error("La fecha de produccion no puede ser menor que la fecha de vencimiento.");
                    return;
                }
                //DataOperations dp = new DataOperations();

                lote = new Ingreso_Externo_Lote();

                lote.Unidades = Convert.ToDecimal(txtUnidad.Text);
                lote.Lote = txtLote.Text;
                lote.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                lote.NumLine = -1;
                lote.FechaProduccion = Convert.ToDateTime(deFechaProduccion.Text);
                lote.FechaVencimiento = Convert.ToDateTime(deFechaVencimiento.Text);

                //using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                //{
                //    cnx.Open();
                //    SqlCommand cmd = new SqlCommand("sp_insert_lote_almacenes_externos", cnx);
                //    cmd.CommandType = CommandType.StoredProcedure;
                //    cmd.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = lote.Cantidad;
                //    cmd.Parameters.Add("@unidades", SqlDbType.Decimal).Value = lote.Unidades;
                //    cmd.Parameters.Add("@id_detalle", SqlDbType.Decimal).Value = 0;
                //    cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = lote.Lote;
                //    cmd.Parameters.Add("@fecha_vencimiento", SqlDbType.DateTime).Value = lote.FechaVencimiento;
                //    cmd.Parameters.Add("@fecha_produccion", SqlDbType.DateTime).Value = lote.FechaProduccion;

                //    lote.ID = Convert.ToInt32(cmd.ExecuteScalar());
                //    cnx.Close();

                //}


                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtLote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCantidad.Focus();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtUnidad.Focus();
        }

        private void txtUnidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                deFechaProduccion.Focus();
        }

        private void deFechaProduccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                deFechaVencimiento.Focus();
        }

        private void deFechaVencimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGuardar_Click(sender, new EventArgs());
        }
    }
}