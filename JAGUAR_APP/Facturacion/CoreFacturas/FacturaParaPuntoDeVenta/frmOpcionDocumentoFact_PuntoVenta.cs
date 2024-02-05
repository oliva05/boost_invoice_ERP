using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace JAGUAR_APP.Facturacion.CoreFacturas.FacturaParaPuntoDeVenta
{
    public partial class frmOpcionDocumentoFact_PuntoVenta : DevExpress.XtraEditors.XtraForm
    {
        public int IdSeleccionDocumento = 0;
        public frmOpcionDocumentoFact_PuntoVenta()
        {
            InitializeComponent();
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_documentos_type_emitir_para_puntos_de_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsBusquedas1.type_docs_emision_PuntoVenta.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsBusquedas1.type_docs_emision_PuntoVenta);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionado")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsBusquedas.type_docs_emision_PuntoVentaRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    IdSeleccionDocumento = row.id;
                    row.seleccionado = true;
                }

                foreach (dsBusquedas.type_docs_emision_PuntoVentaRow row1 in dsBusquedas1.type_docs_emision_PuntoVenta)
                {
                    if (row1.id != IdSeleccionDocumento)
                        row1.seleccionado = false;
                }
            }
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            if(IdSeleccionDocumento>0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CajaDialogo.Error("Es necesario seleccionar un tipo de documento en la columna [Seleccionado] para poder continuar!");
                return;
            }
        }
    }
}