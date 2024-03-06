using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Formulas;
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

namespace JAGUAR_APP.Mantenimientos.ProductoTerminado
{
    public partial class frmMainProductoTerminado : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        

        public frmMainProductoTerminado(UserLogin pUserLogin)
        {
            InitializeComponent();
            dp = new DataOperations();
            UsuarioLogeado = pUserLogin;
            LoadDataDetallePT();
        }

        private void LoadDataDetallePT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].sp_get_datos_maestros_pt_list_crudV2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", tggVerDisables.IsOn);
                dsProductoTerminado1.lista_main_CRUD.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.lista_main_CRUD);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEditarPT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton editar el master de producto
            var gridView = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridView.GetFocusedDataRow();
            if (row != null)
            {
                if (row.id > 0)
                {
                    frmCRUD_ProductoTerminado frm = new frmCRUD_ProductoTerminado(this.UsuarioLogeado, frmCRUD_ProductoTerminado.TipoOperacion.Update, row.id);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataDetallePT();
                    }
                }
            }
        }


        private void cmdReceta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver Receta del Producto
            var gridView = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridView.GetFocusedDataRow();

            if (UsuarioLogeado.ValidarNivelPermisos(1))
            {
                frmFormulasJaguar frm = new frmFormulasJaguar(this.UsuarioLogeado, row.id);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No cuenta con los privilegios para acceder a esta opción! Permiso requerido #1");
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdNuevoPT_Click(object sender, EventArgs e)
        {
            frmCRUD_ProductoTerminado frm = new frmCRUD_ProductoTerminado(this.UsuarioLogeado, frmCRUD_ProductoTerminado.TipoOperacion.Insert,0);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadDataDetallePT();
            }

        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridDetalleProductosCRUD.ExportToXlsx(dialog.FileName);
        }

        private void tggViewFilter_Toggled(object sender, EventArgs e)
        {
            LoadDataDetallePT();
        }

        private void cmdEditar2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton editar el master de producto
            var gridView = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridView.GetFocusedDataRow();
            if (row != null)
            {
                if (row.id > 0)
                {
                    frmCRUD_ProductoTerminado frm = new frmCRUD_ProductoTerminado(this.UsuarioLogeado, frmCRUD_ProductoTerminado.TipoOperacion.Update, row.id);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataDetallePT();
                    }
                }
            }
        }





        private void cmdReceta2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver Receta del Producto
            var gridView = (GridView)gridDetalleProductosCRUD.FocusedView;
            var row = (dsProductoTerminado.lista_main_CRUDRow)gridView.GetFocusedDataRow();

            if (UsuarioLogeado.ValidarNivelPermisos(1))
            {
                frmFormulasJaguar frm = new frmFormulasJaguar(this.UsuarioLogeado, row.id);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No cuenta con los privilegios para acceder a esta opción! Permiso requerido #1");
            }
        }

        private void tggVerDisables_Toggled(object sender, EventArgs e)
        {
            LoadDataDetallePT();
        }
    }
}