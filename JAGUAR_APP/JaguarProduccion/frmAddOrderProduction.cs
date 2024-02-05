using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace JAGUAR_APP.JaguarProduccion
{
    public partial class frmAddOrderProduction : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        ProductoTerminado ProductoTerminadoActual;
        FormulaH FormulaActual;
        DataOperations dp;

        public frmAddOrderProduction(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            dp = new DataOperations();
            UsuarioLogeado = pUsuarioLogeado;
            LoadProductosTerminados();
        }

        //private void LoadRecetas(int pIdPT)
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
        //        con.Open();

        //        SqlCommand cmd = new SqlCommand("", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.Parameters.AddWithValue("@idbodega", idBodega);
        //        dsLogisticaJaguar1.Productos_terminados_list.Clear();
        //        SqlDataAdapter adat = new SqlDataAdapter(cmd);
        //        adat.Fill(dsLogisticaJaguar1.Productos_terminados_list);
        //        con.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}

        private void LoadProductosTerminados()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_jaguar_get_lista_productos_terminados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsLogisticaJaguar1.Productos_terminados_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.Productos_terminados_list);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SearchReceta();
        }

        private void SearchReceta()
        {

            frmFormulasJaguarSelectionMode frm = new frmFormulasJaguarSelectionMode(this.UsuarioLogeado,
                                                                                    dp.ValidateNumberInt32(gridLookUpEditProductoTerminado.EditValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Explosionar Formula
                txtRecetaName.Text = frm.FormulaActual.codigo + " / " + frm.FormulaActual.nombre;
                FormulaActual = frm.FormulaActual;
            }
        }//SearchReceta()

        private void gridLookUpEditProductoTerminado_EditValueChanged(object sender, EventArgs e)
        {
            int idPT = dp.ValidateNumberInt32(gridLookUpEditProductoTerminado.EditValue);
            //int valor_res = CargarRecetaId_Auto(idPT);
            this.ProductoTerminadoActual = new ProductoTerminado();
            this.ProductoTerminadoActual.Recuperar_producto(idPT);
            //switch (valor_res)
            //{
            //    case -1://No tiene formula seteada
            //        txtRecetaName.Text = "";
            //        CajaDialogo.Error("Este Producto Terminado aún no tiene una Receta definida!");
            //        break;
            //    case 0://Hay mas de una formula seteada
            //        frmFormulasJaguarSelectionMode frm1 = new frmFormulasJaguarSelectionMode(this.UsuarioLogeado, this.ProductoTerminadoActual.Id);
            //        if(frm1.ShowDialog() == DialogResult.OK)
            //        {
            //            txtRecetaName.Text = frm1.FormulaActual.codigo + " / " + frm1.FormulaActual.nombre;
            //            FormulaActual = frm1.FormulaActual;
            //        }
            //        break;
            //    default:
            //        //Formula a cargar en automatico
            //        FormulaActual = new FormulaH();
            //        if (FormulaActual.RecuperarRegistro(valor_res))
            //        {
            //            txtRecetaName.Text = FormulaActual.codigo + " / " + FormulaActual.nombre;
            //        }

            //        break;
            //}

            LoadDetalleOrdenFabricacion();
        }

        private int CargarRecetaId_Auto(int pIdPT)
        {
            int valor = 0;
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_jaguar_get_formula_main_from_pt_id]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pIdPT);
                valor = dp.ValidateNumberInt32(Convert.ToInt32(cmd.ExecuteScalar()));
                con.Close();
            }
            catch (Exception ec)
            {
                valor = 0;
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }//CargarRecetaId_Auto(int pIdPT)

        private void spinEditCantArrobas_EditValueChanged(object sender, EventArgs e)
        {
            LoadDetalleOrdenFabricacion();
        }

        private void LoadDetalleOrdenFabricacion()
        {
            //Calcular segun cantidad de arrobas
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.jaguar_sp_get_detalle_formula_segun_arroba", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", this.ProductoTerminadoActual.Id);
                cmd.Parameters.AddWithValue("@cant_arroba", spinEditCantArrobas.EditValue);
                dsLogisticaJaguar1.orden_produccion_detalle.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.orden_produccion_detalle);
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
    }
}