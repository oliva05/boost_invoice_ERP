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

namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    public partial class frmCotizacionesHome : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        PDV PuntoVentaActual;
        UserLogin UsuarioLogeado;
        int PuntoVentaId;
        public frmCotizacionesHome(UserLogin userLogin, PDV ppuntoventa)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            PuntoVentaActual = ppuntoventa;
            dtFechaDesdeDisponibles.DateTime = dp.dNow().AddDays(-30);
            dtFechaHastaDisponibles.DateTime = dp.dNow().AddDays(1);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_cotizaciones_lista";
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

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            frmCotizacionOP frm = new frmCotizacionOP(frmCotizacionOP.TipoOperacion.Insert, UsuarioLogeado, PuntoVentaActual, 0);
            frm.ShowDialog();
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdvDetalle = (GridView)grdCotizaciones.FocusedView;
            var row = (dsFactCotizacion.ListaCotizacionesRow)grdvDetalle.GetFocusedDataRow();

            if (row.id > 0)
            {
                frmCotizacionOP frm = new frmCotizacionOP(frmCotizacionOP.TipoOperacion.Update, UsuarioLogeado, PuntoVentaActual, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }

        }

        private void reposEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdvDetalle = (GridView)grdCotizaciones.FocusedView;
            var row = (dsFactCotizacion.ListaCotizacionesRow)grdvDetalle.GetFocusedDataRow();

            if (row.id > 0)
            {
                bool Proceder = false;
                switch (row.id_estado)
                {
                    case 1:
                        Proceder = true;
                        break;

                    case 2:
                        Proceder = false;
                        

                        break;
                    default:
                        break;
                }


                if (Proceder)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_cotizacion_eliminar", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_h", row.id);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        LoadData();
                    }

                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }
                }
                else
                {
                    CajaDialogo.Error("No se puede eliminar una Cotizacion Cerrada!");
                    return;
                }


            }
        }

        private void reposPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdvDetalle = (GridView)grdCotizaciones.FocusedView;
            var row = (dsFactCotizacion.ListaCotizacionesRow)grdvDetalle.GetFocusedDataRow();


        }
    }
}