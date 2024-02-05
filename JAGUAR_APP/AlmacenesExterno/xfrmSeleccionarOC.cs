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
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.AlmacenesExterno.Models;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmSeleccionarOC : DevExpress.XtraEditors.XtraForm
    {
        public xfrmSeleccionarOC()
        {
            InitializeComponent();
            CargarDatos();
        }


        private void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_OC_H_v2", cnx);
                    dsAlmacenesExternos.OC.Clear();

                    da.Fill(dsAlmacenesExternos.OC);

                }
            }
            catch (Exception)
            {

            }
        }

        public OrdenCompra_H oc = new OrdenCompra_H();
        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)gcOC.FocusedView;
            var row = (dsAlmacenesExternos.OCRow)gv.GetDataRow(gv.FocusedRowHandle);
            oc = new OrdenCompra_H();

            if (row!=null)
            {
                oc.ID = row.id;
                oc.FechaDocumento = row.Fecha_Documento;
                oc.DocNum = row.DocNum;
                oc.CodProv = row.CodProv;
                oc.Proveedor = row.Proveedor;
                oc.Comentario = row.Comentario;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvOC_DoubleClick(object sender, EventArgs e)
        {
            //var gv = (GridView)gcOC.FocusedView;
            //var row = (dsAlmacenesExternos.OCRow)gv.GetDataRow(gv.FocusedRowHandle);
            var gridView = (GridView)gcOC.FocusedView;
            var row = (dsAlmacenesExternos.OCRow)gridView.GetFocusedDataRow();

            oc = new OrdenCompra_H();

            if (row != null)
            {
                oc.ID = row.id;
                oc.FechaDocumento = row.Fecha_Documento;
                oc.DocNum = row.DocNum;
                oc.CodProv = row.CodProv;
                oc.Proveedor = row.Proveedor;
                oc.Comentario = row.Comentario;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}