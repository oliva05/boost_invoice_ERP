using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace JAGUAR_APP.JaguarProduccion
{
    public partial class frmAddAvanceProduccion : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        OrdenFabricacionJaguarH OrdenFabricacionActual;
        ItemS ItemSeleccionado;
        decimal CantidadIngresada;

        public enum TipoAccion
        {
            Latas = 1,
            Bolsas = 2
        }

        public delegate void get_latas_inserted(Int64 Id_lata_inserted);
        public event get_latas_inserted EventoPasarId_Lata_inserted;
        public TipoAccion TipoAccionActual;


        public frmAddAvanceProduccion(UserLogin pUsuarioLogeado, Int64 pIdOrdenFabricacion)
        {
            InitializeComponent();
            CantidadIngresada = 0;
            ItemSeleccionado = new ItemS();
            UsuarioLogeado = pUsuarioLogeado;
            TipoAccionActual = TipoAccion.Latas;

            LoadOrders();
            OrdenFabricacionActual = new OrdenFabricacionJaguarH();
            if (OrdenFabricacionActual.Recuperado)
            {

            }
        }

        public frmAddAvanceProduccion(UserLogin pUsuarioLogeado, Int64 pIdOrdenFabricacion, TipoAccion pTipoAccion)
        {
            InitializeComponent();
            ItemSeleccionado = new ItemS();
            UsuarioLogeado = pUsuarioLogeado;
            TipoAccionActual = pTipoAccion;
            this.Text = "Agregar Bolsas";
            lblDescripcionCantidad.Text = "Cantidad de Bolsas:";

            LoadOrders();
            OrdenFabricacionActual = new OrdenFabricacionJaguarH();
            if (OrdenFabricacionActual.Recuperado)
            {

            }
        }

        private void LoadOrders()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_detalle_production_orders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todas", false);
                dsLogisticaJaguar1.Home_Production_orders.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.Home_Production_orders);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdSumarOne_Click(object sender, EventArgs e)
        {
            CantidadIngresada += 1;
            txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
        }

        private void cmdSumarFive_Click(object sender, EventArgs e)
        {
            CantidadIngresada += 5;
            txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
        }

        private void cmdSumarTen_Click(object sender, EventArgs e)
        {
            CantidadIngresada += 10;
            txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
        }

        private void cmdRestarOne_Click(object sender, EventArgs e)
        {
            if (CantidadIngresada >= 1)
            {
                CantidadIngresada -= 1;
                txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
            }
            else
            {
                CantidadIngresada = 0;
                txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
            }
                
        }

        private void cmdRestarFive_Click(object sender, EventArgs e)
        {
            if (CantidadIngresada >= 5)
            {
                CantidadIngresada -= 5;
                txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
            }
            else
            {
                CantidadIngresada = 0;
                txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
            }
                
        }

        private void cmdRestarTen_Click(object sender, EventArgs e)
        {
            if (CantidadIngresada >= 10)
            {
                CantidadIngresada -= 10;
                txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
            }
            else
            {
                CantidadIngresada = 0;
                txtCantLatas.Text = string.Format("{0:###,##0.00}", CantidadIngresada);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {   
        }

        public class ItemS
        {
            public int id_orden;
            public Int64 id_lata_avance;
            public ItemS()
            {

            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionado")
            {
                
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsLogisticaJaguar.Home_Production_ordersRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {

                    ItemSeleccionado.id_orden = row.id;
                    //ItemSeleccionado.ItemCode = row.ItemCode;
                    //ItemSeleccionado.ItemName = row.Name_;
                    row.seleccionado = true;
                }

                foreach (dsLogisticaJaguar.Home_Production_ordersRow row1 in dsLogisticaJaguar1.Home_Production_orders)
                {
                    if (row1.id != ItemSeleccionado.id_orden)
                        row1.seleccionado = false;
                }
            }
        }

        private void cmdAplicarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                CantidadIngresada = Convert.ToDecimal(txtCantLatas.Text);
                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(txtCantLatas, "Ingrese un número valido!");
                CajaDialogo.Error("Es necesario ingresar una cantidad mayor a cero!");
                return;
            }

            if (CantidadIngresada <= 0)
            {
                CajaDialogo.Error("Es necesario ingresar una cantidad mayor a cero!");
                return;
            }

            if(ItemSeleccionado == null)
            {
                CajaDialogo.Error("Es necesario seleccionar una orden de fabricación!");
                return;
            }

            ItemSeleccionado.id_orden = 0;
            foreach (dsLogisticaJaguar.Home_Production_ordersRow row1 in dsLogisticaJaguar1.Home_Production_orders)
            {
                if (row1.seleccionado)
                    ItemSeleccionado.id_orden = row1.id;                     
            }

            if (ItemSeleccionado.id_orden <= 0)
            {
                CajaDialogo.Error("Es necesario seleccionar una orden de fabricación!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                string query = "";
                switch (TipoAccionActual)
                {
                    case TipoAccion.Latas:
                        query = "codesahn.sp_set_insert_avance_produccion_revision_latas_standarv2";
                        break;
                    case TipoAccion.Bolsas:
                        query = "codesahn.sp_set_insert_avance_produccion_revision_bolsas_standar";
                        break;
                }

                if (dp.ValidateStringIsNullOrEmpty(query))
                {
                    CajaDialogo.Error("No se puede ejecutar la operacion, el tipo TipoOperacion: 1 = Latas, 2 = Bolsas no se ha definido!");
                    return;
                }

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden", ItemSeleccionado.id_orden);
                cmd.Parameters.AddWithValue("@cantidad", CantidadIngresada);
                cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                ItemSeleccionado.id_lata_avance = Convert.ToInt64(cmd.ExecuteScalar());
                con.Close();
                
                EventoPasarId_Lata_inserted(ItemSeleccionado.id_lata_avance);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtCantLatas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CantidadIngresada = Convert.ToDecimal(txtCantLatas.Text);
                errorProvider1.Clear();
            }
            catch 
            {
                errorProvider1.SetError(txtCantLatas, "Ingrese un número valido!");
            }
        }
    }
}