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
using static ACS.Classes.DataOperations;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
using ACS.Classes;
using JAGUAR_APP.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Facturacion.Mantenimientos
{
    public partial class xfrmVendedoresMain : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        UserLogin usuarioLogueado = new UserLogin();

        public xfrmVendedoresMain(UserLogin pUserLog)
        {
            InitializeComponent();
            usuarioLogueado = pUserLog;
            ObtenerVendedores();
        }

        private void ObtenerVendedores()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_vendedores_all", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Activo", tsActivo.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantenimientosFacturacion1.Vendedores.Clear();
                adat.Fill(dsMantenimientosFacturacion1.Vendedores);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gcClientes.FocusedView;
            var row = (dsMantenimientosFacturacion.VendedoresRow)gridview.GetFocusedDataRow();

            xfrmVendedoresOP frm = new xfrmVendedoresOP(xfrmVendedoresOP.Operacion.Editar,row.id, usuarioLogueado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ObtenerVendedores();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerVendedores();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            xfrmVendedoresOP frm = new xfrmVendedoresOP(xfrmVendedoresOP.Operacion.Nuevo, 0, usuarioLogueado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ObtenerVendedores();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsActivo_Toggled(object sender, EventArgs e)
        {
            ObtenerVendedores();
        }
    }
}