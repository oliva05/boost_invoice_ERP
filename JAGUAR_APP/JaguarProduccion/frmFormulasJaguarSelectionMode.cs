using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace JAGUAR_APP.Formulas
{
    public partial class frmFormulasJaguarSelectionMode : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        ProductoTerminado ProductoTerminadoActual;
        public FormulaH FormulaActual;

        public frmFormulasJaguarSelectionMode(UserLogin pUsuarioLogeado, int pIdPT)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            ProductoTerminadoActual = new ProductoTerminado();
            if (ProductoTerminadoActual.Recuperar_producto(pIdPT))
            {
                lblTituloFormula.Text = "Receta de " + ProductoTerminadoActual.Descripcion;
                LoadFormulasH(pIdPT);
            }
        }

        private void LoadFormulasH(int pID_PT)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_lista_formulas_from_pt_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pID_PT);
                dsFormulasCRUD1.formula_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFormulasCRUD1.formula_h);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleIngredientes(int pdIdFormula)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_detalle_ingredientes_formula", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_formula_h", pdIdFormula);
                dsFormulasCRUD1.ingredientes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFormulasCRUD1.ingredientes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmAddFormulaH frm = new frmAddFormulaH(this.UsuarioLogeado, ProductoTerminadoActual.Id, frmAddFormulaH.TipoTransaccion.Insert, 0);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadFormulasH(ProductoTerminadoActual.Id);
            }
        }

        private void cmdEditarFormula_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsFormulasCRUD.formula_hRow)gridView.GetFocusedDataRow();

            frmAddFormulaH frm = new frmAddFormulaH(this.UsuarioLogeado, ProductoTerminadoActual.Id, frmAddFormulaH.TipoTransaccion.Update, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadFormulasH(ProductoTerminadoActual.Id);
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdAgregarIngrediente_Click(object sender, EventArgs e)
        {
            if(FormulaActual==null)
            {
                CajaDialogo.Error("Es necesario seleccionar una formula en el panel izquiedo!");
            }

            if (!FormulaActual.Recuperado)
            {
                CajaDialogo.Error("Es necesario seleccionar una formula en el panel izquiedo!");
            }

            frmAddIngrediente frm = new frmAddIngrediente(this.UsuarioLogeado, frmAddIngrediente.TipoTransaccion.Insert,0, FormulaActual.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //var gridView = (GridView)gridControl2.FocusedView;
                //var row = (dsFormulasCRUD.ingredientesRow)gridView.GetFocusedDataRow();

                FormulaIngrediente IngredienteEdit = new FormulaIngrediente();
                if (IngredienteEdit.RecuperarRegistro(frm.IdIngredienteSelected))
                {
                    dsFormulasCRUD.ingredientesRow row = dsFormulasCRUD1.ingredientes.NewingredientesRow();
                    //dsCompras.oc_d_normalRow row1 = dsCompras.oc_d_normal.Newoc_d_normalRow();
                    row.peso_batch = IngredienteEdit.peso_batch;
                    row.id_mp = IngredienteEdit.id_mp;
                    row.itemCode = IngredienteEdit.ItemCode;
                    row.itemName = IngredienteEdit.ItemName;
                    row.id = frm.IdIngredienteSelected;
                    dsFormulasCRUD1.ingredientes.AddingredientesRow(row);
                    //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                    //dsCompras.AcceptChanges();
                    dsFormulasCRUD1.AcceptChanges();
                    
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsFormulasCRUD.formula_hRow)gridView.GetFocusedDataRow();

            if (row != null)
            {
                FormulaActual = new FormulaH();
                FormulaActual.RecuperarRegistro(row.id);
                spinEditCant_Latas.EditValue = FormulaActual.Latas;
                spinEditCantidadBolsasPorLata.EditValue = FormulaActual.Bolsas;
                LoadDetalleIngredientes(FormulaActual.id);
            }
        }

        private void cmdEditarIngrediente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsFormulasCRUD.ingredientesRow)gridView.GetFocusedDataRow();

            frmAddIngrediente frm = new frmAddIngrediente(this.UsuarioLogeado, frmAddIngrediente.TipoTransaccion.Update, row.id, FormulaActual.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                FormulaIngrediente IngredienteEdit = new FormulaIngrediente();
                if (IngredienteEdit.RecuperarRegistro(row.id))
                {
                    row.peso_batch = IngredienteEdit.peso_batch;
                    row.id_mp = IngredienteEdit.id_mp;
                    row.itemCode = IngredienteEdit.ItemCode;
                    row.itemName = IngredienteEdit.ItemName;
                }
            }
        }

        private void cmdGuardarLatasY_Bolsas_Click(object sender, EventArgs e)
        {
            if(FormulaActual != null)
            {
                if (FormulaActual.Recuperado)
                {
                    FormulaActual.Latas = spinEditCant_Latas.Value;
                    FormulaActual.Bolsas = spinEditCantidadBolsasPorLata.Value;
                    if (FormulaActual.FN_Update_cant_latas_Bolsas())
                        CajaDialogo.Information("Transacción Completada!");
                }
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionar")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsFormulasCRUD.formula_hRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    if (FormulaActual.RecuperarRegistro(row.id))
                        row.seleccionar = true;
                }

                foreach (dsFormulasCRUD.formula_hRow row1 in dsFormulasCRUD1.formula_h)
                {
                    if (row1.id != FormulaActual.id)
                        row1.seleccionar = false;
                }
            }
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            if(FormulaActual != null)
            {
                if (FormulaActual.Recuperado)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    CajaDialogo.Error("La receta seleccionada no parece ser un registro valido!");
                }
            }
            else
            {
                CajaDialogo.Error("Es necesario seleccionar una Receta valida!");
            }
        }
    }
}