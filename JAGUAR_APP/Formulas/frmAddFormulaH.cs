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
    public partial class frmAddFormulaH : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        ProductoTerminado ProductoTerminadoActual;
        DataOperations dp;
        FormulaH FormulaActual;

        public enum TipoTransaccion
        {
            Insert = 1,
            Update = 2
        }

        TipoTransaccion TipoTransaccionActual;
        public frmAddFormulaH(UserLogin pUsuarioLogeado, int pIdPT, TipoTransaccion pTipoTransaccion, int pIdFormula)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            TipoTransaccionActual = pTipoTransaccion;
            dp = new DataOperations();
            FormulaActual = new FormulaH();
            ProductoTerminadoActual = new ProductoTerminado();

            if (ProductoTerminadoActual.Recuperar_producto(pIdPT))
            {
                lblTituloFormula.Text = "Receta de " + ProductoTerminadoActual.Descripcion;
                dtDesde.EditValue = dp.NowSetDateTime();
                dtHasta.EditValue = dp.NowSetDateTime().AddYears(1);
                LoadEstados();
                LoadTipos();
            }
            switch (pTipoTransaccion)
            {
                case TipoTransaccion.Insert:
                    toggleSwitchEnableFormula.Visible = lblToggleSwitchEnable.Visible = false;
                    txtCodigoFormula.Text = FormulaActual.GenerarNextCodigo();
                    txtCodigoFormula.ReadOnly = true;
                    txtVersion.Text = "1";
                    break;
                case TipoTransaccion.Update:
                    toggleSwitchEnableFormula.Visible = lblToggleSwitchEnable.Visible = true;
                    txtCodigoFormula.ReadOnly = true;
                    if (FormulaActual.RecuperarRegistro(pIdFormula))
                    {
                        txtCodigoFormula.Text = FormulaActual.codigo;
                        txtVersion.Text = FormulaActual.version.ToString();
                        gridLookUpEditTipoFormula.EditValue = FormulaActual.tipo;
                        gridLookUpEdit_EstadosFormula.EditValue = FormulaActual.estado_id;
                        txtDescripcionFormulaNombre.Text = FormulaActual.nombre;
                        txtComentario.Text = FormulaActual.commentario;
                        dtDesde.EditValue = FormulaActual.available_date;
                        dtHasta.EditValue = FormulaActual.due_date;
                        toggleSwitchEnableFormula.IsOn = FormulaActual.Enable;
                    }
                    break;
            }
        }

        private void LoadTipos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_listado_estados_formula", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsFormulasCRUD1.EstadosTable.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFormulasCRUD1.EstadosTable);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadEstados()
        {
            try
            {
                
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_listado_tipos_formula", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsFormulasCRUD1.TiposTable.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFormulasCRUD1.TiposTable);

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
            if (string.IsNullOrEmpty(gridLookUpEditTipoFormula.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Tipo de Receta!");
                return;
            }

            if (string.IsNullOrEmpty(gridLookUpEdit_EstadosFormula.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Estado de la Receta!");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcionFormulaNombre.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Nombre de la Receta!");
                return;
            }

            if (string.IsNullOrEmpty(txtVersion.Text))
            {
                CajaDialogo.Error("Es necesario definir un numero de versión!");
                return;
            }

            int Version = dp.ValidateNumberInt32(txtVersion.Text);

            if (Version == 0)
            {
                CajaDialogo.Error("Es necesario definir un numero de versión mayor a cero!");
                return;
            }

            //if (string.IsNullOrEmpty(gridLookUpEditTipoProducto.Text))
            //{
            //    CajaDialogo.Error("Es necesario indicar el Destino del Producto!");
            //    return;
            //}

            DialogResult r = CajaDialogo.Pregunta("Desea guardar los cambios?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn1 = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                Conn1.Open();
                SqlCommand cmd = new SqlCommand("", Conn1);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (TipoTransaccionActual)
                {
                    case TipoTransaccion.Insert:
                        cmd.CommandText = "codesahn.sp_set_insert_new_formula_h";

                        break;
                    case TipoTransaccion.Update:
                        cmd.CommandText = "codesahn.sp_set_update_new_formula_h";
                        cmd.Parameters.AddWithValue("@id", FormulaActual.id);
                        cmd.Parameters.AddWithValue("@enable", toggleSwitchEnableFormula.IsOn);
                        break;
                }

                cmd.Parameters.AddWithValue("@codigo", txtCodigoFormula.Text);
                cmd.Parameters.AddWithValue("@version", Version);
                cmd.Parameters.AddWithValue("@tipo", gridLookUpEditTipoFormula.EditValue);
                cmd.Parameters.AddWithValue("@nombre", txtDescripcionFormulaNombre.Text);
                cmd.Parameters.AddWithValue("@id_user_creado", this.UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@comment", txtComentario.Text);
                cmd.Parameters.AddWithValue("@estado_id", gridLookUpEdit_EstadosFormula.EditValue);
                cmd.Parameters.AddWithValue("@available_date", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@due_date", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@id_producto_terminado", ProductoTerminadoActual.Id);
                cmd.ExecuteNonQuery();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
    
}