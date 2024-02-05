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
using System.Data.SqlClient;
using ACS.Classes;
using JAGUAR_APP.Clases;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.RecuentoInventario;

namespace JAGUAR_APP.RecuentoInventario
{
    public partial class frmEdtiarDetalleRecuento : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        decimal exist_sistema = 0;
        decimal exist_fisica = 0;
        decimal diferencia = 0;
        int id_detalle;
        public frmEdtiarDetalleRecuento(int pid_detalle, string pmateria_prima, string pbodega, decimal pexist_sistema, decimal pexist_fisica, decimal pdiferencia)
        {
            InitializeComponent();
            txtMatriaPr.Text = pmateria_prima;
            txtBodega.Text = pbodega;

            exist_sistema = pexist_sistema;
            exist_fisica = pexist_fisica;
            diferencia = pdiferencia;
            id_detalle = pid_detalle;

            spinExistenciaSistema.EditValue = exist_sistema;
            spinExistenciaFisica.EditValue = exist_fisica;
            spinDiferencia.EditValue = diferencia;
            spinNuevaCantidad.EditValue = exist_fisica;

        }

        private void CalculoDetalle()
        {
            try
            {
                //decimal diferenciaLocal = 0;

                spinDiferencia.EditValue = (Convert.ToDecimal(spinExistenciaSistema.EditValue) - Convert.ToDecimal(spinExistenciaFisica.EditValue));

                //spinDiferencia.EditValue = diferenciaLocal;
                spinNuevaCantidad.EditValue = spinExistenciaFisica.EditValue;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spinExistenciaFisica_Enter(object sender, EventArgs e)
        {
            CalculoDetalle();
        }

        private void spinExistenciaFisica_EditValueChanged(object sender, EventArgs e)
        {
            CalculoDetalle();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(spinExistenciaFisica.EditValue) < 0)
            {
                CajaDialogo.Error("La Existencia Fisica no puede ser menor que 0!");
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_update_detalle_inventario_final", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_detalle", id_detalle);
                cmd.Parameters.AddWithValue("@existencia_aprox", spinExistenciaSistema.EditValue);
                cmd.Parameters.AddWithValue("@existencia_fisica", spinExistenciaFisica.EditValue);
                cmd.Parameters.AddWithValue("@diferencia_peso", spinDiferencia.EditValue);
                cmd.Parameters.AddWithValue("@nueva_cantidad", spinNuevaCantidad.EditValue);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}