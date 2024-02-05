using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Reportes;
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

namespace JAGUAR_APP.Calidad.LoteConfConsumo
{
    public partial class frmSearchMP : DevExpress.XtraEditors.XtraForm
    {

       public ItemBusqueda ItemSeleccionado = new ItemBusqueda();
        public enum TipoTransaccion
        {
            Entrada = 1,
            Salida = 2,
           
        }
        int tipoTransaccion = 0;

        public frmSearchMP(int pTipoTransaccion)
        {
            InitializeComponent();
            ItemSeleccionado = new ItemBusqueda();
            tipoTransaccion = pTipoTransaccion;
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.usp_getMP_Kardex", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@transaccion", tipoTransaccion);


                dsReportesInventario.Kardex_BusquedaMP.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesInventario.Kardex_BusquedaMP);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionar")
            {
             
                var row = (dsReportesInventario.Kardex_BusquedaMPRow)gvMP.GetFocusedDataRow();

                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id = row.id_mp;
                    ItemSeleccionado.ItemCode = row.code;
                    ItemSeleccionado.ItemName = row.nombre_comercial;

                    row.seleccionar = true;
                }

                foreach (dsReportesInventario.Kardex_BusquedaMPRow row1 in dsReportesInventario.Kardex_BusquedaMP)
                {
                    if (row1.id_mp != ItemSeleccionado.id)
                        row1.seleccionar = false;
                }
            }
        }


        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
       
            var row = (dsReportesInventario.Kardex_BusquedaMPRow)gvMP.GetFocusedDataRow();

            ItemSeleccionado.id = row.id_mp;
            ItemSeleccionado.ItemCode = row.code;
            ItemSeleccionado.ItemName = row.nombre_comercial;
            ItemSeleccionado.Presentacion = row.presentacion;
            ItemSeleccionado.PresenacionID = row.id_presentacion;    
            row.seleccionar = true;

            cmdAplicar_Click(new object(), new EventArgs());

            foreach (dsReportesInventario.Kardex_BusquedaMPRow row1 in dsReportesInventario.Kardex_BusquedaMP)
            {
                if (row1.id_mp != ItemSeleccionado.id)
                    row1.seleccionar = false;
            }
        }

       
    }
}