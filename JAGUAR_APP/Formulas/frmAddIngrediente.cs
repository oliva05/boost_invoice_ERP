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

namespace JAGUAR_APP.Formulas
{
    public partial class frmAddIngrediente : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        FormulaH FormulaActual;
        FormulaIngrediente IngredienteEdit;
        public int IdIngredienteSelected;

        public enum TipoTransaccion
        {
            Insert = 1,
            Update = 2
        }

        TipoTransaccion TipoTransaccionActual;
        public frmAddIngrediente(UserLogin pUsuarioLogeado, TipoTransaccion pTipoTransaccionActual, int pIdIngrediente, int pIdFormulaH)
        {
            InitializeComponent();
            TipoTransaccionActual = pTipoTransaccionActual;
            IdIngredienteSelected = pIdIngrediente;
            UsuarioLogeado = pUsuarioLogeado;
            FormulaActual = new FormulaH();
            FormulaActual.RecuperarRegistro(pIdFormulaH);
            LoadMateriasPrimas();
            LoadPresentacionMateriaPrima();
            switch (TipoTransaccionActual)
            {
                case TipoTransaccion.Insert:
                    lblToggleSwitchEnable.Visible = toggleSwitchEnableFormula.Visible = false;
                    IdIngredienteSelected = 0;
                    break;
                case TipoTransaccion.Update:
                    lblToggleSwitchEnable.Visible = toggleSwitchEnableFormula.Visible = true;
                    IngredienteEdit = new FormulaIngrediente();
                    if (IngredienteEdit.RecuperarRegistro(pIdIngrediente))
                    {
                        if(FormulaActual.tipo == 8)//Material empaque
                            gridLookUpEditMateriaPrima.EditValue = IngredienteEdit.id_me;
                        else
                            gridLookUpEditMateriaPrima.EditValue = IngredienteEdit.id_mp;

                        spinEditCantidadMP.EditValue = IngredienteEdit.peso_batch;
                        gridLookUpEditPresentacion.EditValue = IngredienteEdit.id_presentacion;
                        toggleSwitchEnableFormula.IsOn = IngredienteEdit.enable;
                    }
                    break;
            }
        }

        private void LoadMateriasPrimas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_get_materias_primas_list_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_formula_h", FormulaActual.id);
                dsFormulasCRUD1.materia_prima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFormulasCRUD1.materia_prima);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadPresentacionMateriaPrima()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].sp_get_presentacion_for_materia_prima", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_pt", pID_PT);
                dsFormulasCRUD1.presentacion_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFormulasCRUD1.presentacion_mp);

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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gridLookUpEditMateriaPrima.Text))
            {
                CajaDialogo.Error("Es necesario indicar el ingrediente o materia prima!");
                return;
            }

            if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
            {
                CajaDialogo.Error("Es necesario indicar la presentación del ingrediente!");
                return;
            }

            if (spinEditCantidadMP.Value <= 0)
            {
                CajaDialogo.Error("Es necesario indicar un valor mayor a cero!");
                return;
            }

            FormulaIngrediente Ing1 = new FormulaIngrediente();
            dp = new DataOperations();
            int id_mp_selected_grid = dp.ValidateNumberInt32(gridLookUpEditMateriaPrima.EditValue);
            if (TipoTransaccionActual == TipoTransaccion.Insert )
            {
                if (Ing1.Validar_MP_InFormula(FormulaActual.id, id_mp_selected_grid))
                {
                    CajaDialogo.Error("Este Ingrediente ya esta agregado en esta Receta!"); 
                    return;
                }
            }

            if (TipoTransaccionActual == TipoTransaccion.Update)
            {
                if (id_mp_selected_grid != IngredienteEdit.id_mp)
                {
                    if (Ing1.Validar_MP_InFormula(FormulaActual.id, id_mp_selected_grid))
                    {
                        CajaDialogo.Error("Este Ingrediente ya esta agregado en esta Receta!");
                        return;
                    }
                }
            }

            //|| IdIngredienteSelected != id_mp_selected_grid
            DialogResult r = CajaDialogo.Pregunta("Desea guardar los cambios?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("", con);
                switch (TipoTransaccionActual)
                {
                    case TipoTransaccion.Insert:
                        cmd.CommandText = "[codesahn].sp_set_insert_ingrediente_detalle_formula";
                        break;
                    case TipoTransaccion.Update:
                        cmd.CommandText = "[codesahn].sp_set_update_ingrediente_detalle_formula";
                        cmd.Parameters.AddWithValue("@id_ingrediente", IdIngredienteSelected);
                        cmd.Parameters.AddWithValue("@enable", toggleSwitchEnableFormula.IsOn);
                        break;
                }
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                cmd.Parameters.AddWithValue("@peso_batch", spinEditCantidadMP.EditValue);
                cmd.Parameters.AddWithValue("@id_mp", gridLookUpEditMateriaPrima.EditValue);
                cmd.Parameters.AddWithValue("@id_formula_h", FormulaActual.id);

                if (TipoTransaccionActual == TipoTransaccion.Update)
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    IdIngredienteSelected = Convert.ToInt32(cmd.ExecuteScalar());
                }
                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


        }



    }
    

}