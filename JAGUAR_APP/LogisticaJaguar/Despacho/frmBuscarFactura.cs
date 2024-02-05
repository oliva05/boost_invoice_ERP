using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraExport;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Despachos;
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

namespace JAGUAR_APP.LogisticaJaguar.Despacho
{
    public partial class frmBuscarFactura : DevExpress.XtraEditors.XtraForm
    {
        public Int64 IdFacturaSelected;
        int IdPuntoVentaActual;
        public int IdEstado;
        bool IsFromPuntoVenta;

        public frmBuscarFactura(int pIdPuntoVentaActual)
        {
            InitializeComponent();
            IdPuntoVentaActual = pIdPuntoVentaActual;
            LoadDatos(false);
        }

        public frmBuscarFactura(int pIdPuntoVentaActual, bool pIsFromPuntoVenta)
        {
            InitializeComponent();
            IdPuntoVentaActual = pIdPuntoVentaActual;
            this.IsFromPuntoVenta = pIsFromPuntoVenta;
            LoadDatos(IsFromPuntoVenta);
        }

        private void LoadDatos(bool pIsFromPuntoVenta)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand();// "dbo.[sp_get_detalle_facturas_para_entregar_o_recepcion_punto_venta_v2]", con);
                if (pIsFromPuntoVenta)
                    cmd.CommandText = "dbo.[sp_get_detalle_facturas_para_entregar_o_recepcion_punto_venta_v3]";
                else
                    cmd.CommandText = "dbo.[sp_get_detalle_facturas_para_entregar_o_recepcion_punto_venta_v2]";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta", IdPuntoVentaActual);
                cmd.Parameters.AddWithValue("@mostrar_all", toggleSwitch1.IsOn);
                dsDespacho1.factura_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsDespacho1.factura_list);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionado")
            {
                //var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsDespacho.factura_listRow)gridView1.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    //ItemSeleccionado.id = row.id;
                    //ItemSeleccionado.ItemCode = row.ItemCode;
                    //ItemSeleccionado.ItemName = row.Name_;
                    IdFacturaSelected = row.id;
                    IdEstado = row.id_estado;
                    row.seleccionado = true;
                }

                foreach (dsDespacho.factura_listRow row1 in dsDespacho1.factura_list)
                {
                    if (row1.id != IdFacturaSelected)
                        row1.seleccionado = false;
                }
            }                                                 
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            if (IdFacturaSelected > 0)
            {
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
            else
            {
                errorProvider1.SetError(cmdAplicar, "Es necesario seleccionar una factura!");
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            //LoadDatos(false);
            LoadDatos(this.IsFromPuntoVenta);
        }
    }
}