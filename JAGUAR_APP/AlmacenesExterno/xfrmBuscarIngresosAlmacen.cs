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
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_APP.AlmacenesExterno.Models;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmBuscarIngresosAlmacen : DevExpress.XtraEditors.XtraForm
    {
        public xfrmBuscarIngresosAlmacen()
        {
            InitializeComponent();
            LoadIngresosExternos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadIngresosExternos()
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                cnx.Open();

                dsSalidasAlmacenesExternos.Ingresos_almacenes_externos_existentes.Clear();

                SqlDataAdapter da = new SqlDataAdapter("[dbo].[sp_get_ingresos_almacenes_externos_disponiblesV2]", cnx);
                da.Fill(dsSalidasAlmacenesExternos.Ingresos_almacenes_externos_existentes);
                cnx.Close();

            }
        }

         public   Ingreso_Almacenes_Externos_H ingreso_h   = new Ingreso_Almacenes_Externos_H();
        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            RowSelected();
        }

        private void gvIngreso_DoubleClick(object sender, EventArgs e)
        {
            RowSelected();
        }

        void RowSelected()
        {
            try
            {
                var gv = (GridView)gcIngreso.FocusedView;
                var row = (dsSalidasAlmacenesExternos.Ingresos_almacenes_externos_existentesRow)gv.GetDataRow(gv.FocusedRowHandle);

                ingreso_h.CardCode = row.cardcode;
                ingreso_h.CardName = row.CardName;
                ingreso_h.ID = row.id;
                ingreso_h.DocEntry = row.DocEntrySAP;
                ingreso_h.BodegaIN = row.bodega;
                ingreso_h.Id_presentacion = row.id_presentacion;

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}