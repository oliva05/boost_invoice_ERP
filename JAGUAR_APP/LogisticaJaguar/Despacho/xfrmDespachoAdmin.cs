using ACS.Classes;
using DevExpress.XtraEditors;
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
using static JAGUAR_APP.LogisticaJaguar.Despacho.xfrmDespachoCRUD;

namespace JAGUAR_APP.LogisticaJaguar.Despacho
{
    public partial class xfrmDespachoAdmin : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado = new UserLogin();
        PDV PuntoVentaActual;
        public xfrmDespachoAdmin(UserLogin pUserLogin)
        {
            InitializeComponent();
            LoadDespacho();
            usuarioLogueado = pUserLogin;
        }

        public xfrmDespachoAdmin(UserLogin pUserLogin, int pIdPuntoVenta)
        {
            InitializeComponent();
            PDV PuntoVentaActual = new PDV();
            //LoadDespacho();
            if (PuntoVentaActual.RecuperaRegistro(pIdPuntoVenta))
                LoadDespachoV2();
            
            
            usuarioLogueado = pUserLogin;
        }


        
        private void LoadDespachoV2()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                using (SqlDataAdapter da = new SqlDataAdapter("[dbo].[uspGetTrasladoByPuntoVenta]", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                    dsDespacho.Despacho_H.Clear();
                    da.Fill(dsDespacho.Despacho_H);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDespacho()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetDespacho", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dsDespacho.Despacho_H.Clear();
                    da.Fill(dsDespacho.Despacho_H);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            xfrmDespachoCRUD frm = new xfrmDespachoCRUD(0,TipoTransaccion.Insert, usuarioLogueado, 0);
            if (frm.ShowDialog()== DialogResult.OK)
                LoadDespacho();
        }

        private void xfrmDespachoAdmin_Load(object sender, EventArgs e){}

        private void btnEditar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsDespacho.Despacho_HRow)gvDespacho.GetFocusedDataRow();
                xfrmDespachoCRUD form = new xfrmDespachoCRUD(row.id_despacho,TipoTransaccion.Update,usuarioLogueado, row.id_punto_venta);

                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsDespacho.Despacho_HRow)gvDespacho.GetFocusedDataRow();
            xfrmDespachoCRUD form = new xfrmDespachoCRUD(row.id, TipoTransaccion.Update, usuarioLogueado, row.id_punto_venta);
            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}