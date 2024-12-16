using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.BancosYTitulares;
using JAGUAR_APP.Clases;
using JAGUAR_APP.LogisticaJaguar;
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
    public partial class frmRptBancos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;

        public frmRptBancos(UserLogin puserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = puserLogin;
            loadata();
        }

        private void loadata()
        {
            try
            {
                string query = @"sp_rpt_get_total_bank";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PuntoVenta",1);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsBancos1.kardex_total_cuentas.Clear();
                adat.Fill(dsBancos1.kardex_total_cuentas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            loadata();
        }

        private void cmdPrintRpt_Click(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdvTotalBancos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var gridview = (GridView)grdTotalCuentas.FocusedView;
            var row = (dsBancos.kardex_total_cuentasRow)gridview.GetFocusedDataRow();

            if (row != null) 
            {
                loadatadetalle(row.id_cuenta);
            }
        }

        private void loadatadetalle(int pidcuenta)
        {
            try
            {
                string query = @"sp_get_bank_details";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cuenta", pidcuenta);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsBancos1.cuenta_detalle.Clear();
                adat.Fill(dsBancos1.cuenta_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmRptBancosAjuste frm = new frmRptBancosAjuste(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK) 
            {
                loadata();
            }
        }
    }
}