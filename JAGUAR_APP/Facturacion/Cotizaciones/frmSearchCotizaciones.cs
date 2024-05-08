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
using JAGUAR_APP.Facturacion.Cotizaciones;
using JAGUAR_APP.Clases;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    public partial class frmSearchCotizaciones : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        PDV PuntoVentaActual;
        public int IdCotizacion = 0;
        DataOperations dp;
        public frmSearchCotizaciones(UserLogin pUserLog, PDV pPuntoVenta)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;
            PuntoVentaActual = pPuntoVenta;
            dp  = new DataOperations();
            dtFechaDesdeDisponibles.DateTime = dp.dNow().AddDays(-30);
            dtFechaHastaDisponibles.DateTime = dp.dNow().AddDays(1);

            LoadData();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdCotizaciones.FocusedView;
            var row = (dsFactCotizacion.ListaCotizacionesRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                IdCotizacion = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void LoadData()
        {
            try
            {
                string query = @"[sp_cotizaciones_lista_abiertas]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fDesde", dtFechaDesdeDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@fFinal", dtFechaHastaDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@PuntoVentaID", PuntoVentaActual.ID);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFactCotizacion1.ListaCotizaciones.Clear();
                adat.Fill(dsFactCotizacion1.ListaCotizaciones);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}