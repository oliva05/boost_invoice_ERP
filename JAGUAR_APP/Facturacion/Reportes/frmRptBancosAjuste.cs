using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Facturacion.CoreFacturas;
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

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class frmRptBancosAjuste : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        int idCuenta;
        public frmRptBancosAjuste(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;

            LoadCuentas();

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

        private void cmdFacturar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdCuentas.Text))
            {
                CajaDialogo.Error("Debe seleccionar una Cuenta!");
                return;
            }

            if ((decimal)spindValor.Value <= 0)
            {
                CajaDialogo.Error("El Valor debe ser mayor a (0)!");
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_bancos_ajuste", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cuenta",grdCuentas.EditValue);
                cmd.Parameters.AddWithValue("@id_factura",DBNull.Value);
                cmd.Parameters.AddWithValue("@id_retiro",DBNull.Value);
                if (tsTipoTra.IsOn)//Entrada
                {
                    cmd.Parameters.AddWithValue("@entrada", spindValor.Value);
                    cmd.Parameters.AddWithValue("@salida", 0);
                }
                else //Salida
                {
                    cmd.Parameters.AddWithValue("@entrada", 0);
                    cmd.Parameters.AddWithValue("@salida", spindValor.Value);
                }

                cmd.Parameters.AddWithValue("@fecha", dp.Now());
                cmd.Parameters.AddWithValue("@user_id",UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@referencia",txtReferencia.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }

            CajaDialogo.Information("Guardado con Exito!");

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}