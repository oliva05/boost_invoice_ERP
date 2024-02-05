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

namespace JAGUAR_APP.Mantenimientos.ProductoTerminado
{
    public partial class frmCRUD_ProductoTerminado : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public enum TipoOperacion
        {
            Insert = 1,
            Update = 2
        }
        TipoOperacion TipoOperacionActual;
        Clases.ProductoTerminado PT_Class_instance;

        decimal CostoPorArroba;


        public frmCRUD_ProductoTerminado(UserLogin pUser, TipoOperacion pTipoOperacion, int pId_PT)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            LoadPresentacionesPT();
            LoadTiposPT();
            LoadEstadosPT();
            LoadTipoFacturacion();
            LoadTipoBuffet();
            LoadTipoDestinoFacturacion();
            LoadClasesProductoTerminado();
            LoadImpuestosAplicables();

            TipoOperacionActual = pTipoOperacion;
            PT_Class_instance = new Clases.ProductoTerminado();
            defaultToolTipController1.SetToolTip(gridLookUpEditTipoFacturacionDestino, "Si el producto se programa para pedido(s) es de tipo producción!" +
                                                                                        "\nSi el Producto no pasa por producción de panificadora es Factura Detalle.");
            switch (pTipoOperacion)
            {
                case TipoOperacion.Insert:
                    txtCodigoProducto.Text = PT_Class_instance.GenerarSiguienteCodigoPT();
                    toggleSwitchEnablePT.IsOn = true;
                    toggleSwitchEnablePT.Enabled = false;
                    break;
                case TipoOperacion.Update:
                    if (PT_Class_instance.Recuperar_producto(pId_PT))
                    {
                        lblTituloVentana.Text = "Edición de Producto Terminado";
                        gridLookUpEditEstadoPT.EditValue = PT_Class_instance.Id_estado;
                        gridLookUpEditTipoProducto.EditValue = PT_Class_instance.Tipo_id;
                        gridLookUpEdit_Presentaciones.EditValue = PT_Class_instance.Id_presentacion;
                        txtDescripcionProducto.Text = PT_Class_instance.Descripcion;
                        toggleSwitchEnablePT.IsOn = PT_Class_instance.Enable;
                        txtCodigoProducto.Text = PT_Class_instance.Code;
                        tggCosteoPorArroba.IsOn = PT_Class_instance.CostoDeMO_porArrobaBit;
                        txtCostoPorArroba.Text = string.Format("{0:###,##0.00}", PT_Class_instance.CostoPorArroba);
                        glueTipoFacturacion.EditValue = PT_Class_instance.tipo_facturacion_id;
                        glueTipoBuffet.EditValue = PT_Class_instance.tipo_buffet_id;


                        gridLookUpEditTipoFacturacionDestino.EditValueChanged -= new EventHandler(gridLookUpEditTipoFacturacionDestino_EditValueChanged);
                        gridLookUpEditTipoFacturacionDestino.EditValue = PT_Class_instance.id_tipo_facturacion_prd;
                        gridLookUpEditTipoFacturacionDestino.EditValueChanged += new EventHandler(gridLookUpEditTipoFacturacionDestino_EditValueChanged);

                        gle_ClaseProducto.EditValue = PT_Class_instance.Id_clase;
                        gleImpuestoAplicable.EditValue = PT_Class_instance.Id_isv_aplicable;

                        //gridLookUpEditTipoFacturacionDestino.TextChanged -= new EventHandler(gridLookUpEditTipoFacturacionDestino_TextChanged);
                        //gridLookUpEditTipoFacturacionDestino.Text = PT_Class_instance.TipoFacturacion_prd_name;
                        //gridLookUpEditTipoFacturacionDestino.TextChanged += new EventHandler(gridLookUpEditTipoFacturacionDestino_TextChanged);
                    }
                    break;
                default:

                    break;
            }
            
        }

        private void LoadClasesProductoTerminado()
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_clases_para_producto_terminado]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dsProductoTerminado1.claseProducto.Clear();
                sqlDataAdapter.Fill(dsProductoTerminado1.claseProducto);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadImpuestosAplicables()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].sp_get_lista_impuestos_aplicables_for_crud_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dsProductoTerminado1.ImpuestoAplicable.Clear();
                sqlDataAdapter.Fill(dsProductoTerminado1.ImpuestoAplicable);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadPresentacionesPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_presentacion_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsProductoTerminado1.presentaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadEstadosPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_estados_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsProductoTerminado1.Estados.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.Estados);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadTiposPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_tipo_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsProductoTerminado1.TipoPT.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.TipoPT);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTipoFacturacion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                string sql = @"SELECT id,
                                   descripcion
                            FROM dbo.Facturacion_TipoFacturacion
                            WHERE enable = 1";

                SqlCommand cmd = new SqlCommand(sql, con);
                dsMantenimientosFacturacion.TipoFacturacion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantenimientosFacturacion.TipoFacturacion);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTipoBuffet()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                string sql = @"dbo.uspGetTipoBuffet_v2";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                dsMantenimientosFacturacion.TipoBuffet.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantenimientosFacturacion.TipoBuffet);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadTipoDestinoFacturacion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                string sql = @"dbo.uspGetTipoFacturacionDestino";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                dsProductoTerminado1.tipo_facturacion_destino.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductoTerminado1.tipo_facturacion_destino);
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
            if (string.IsNullOrEmpty(gridLookUpEdit_Presentaciones.Text))
            {
                CajaDialogo.Error("Es necesario indicar la presentación!");
                return;
            }

            if (string.IsNullOrEmpty(gridLookUpEditEstadoPT.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Estado!");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcionProducto.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Nombre del Producto!");
                return;
            }

            if (string.IsNullOrEmpty(gridLookUpEditTipoProducto.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Destino del Producto!");
                return;
            }
            
            if (string.IsNullOrEmpty(glueTipoBuffet.Text))
            {
                CajaDialogo.Error("Es necesario indicar un tipo de buffet del Producto!");
                return;
            }
            
            if (string.IsNullOrEmpty(glueTipoFacturacion.Text))
            {
                CajaDialogo.Error("Es necesario indicar el tipo de facturación del Producto!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Desea guardar los cambios?");
            if(r != DialogResult.Yes)
                return;

            if (tggCosteoPorArroba.IsOn)
            {

            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn1 = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                Conn1.Open();
                SqlCommand cmd = new SqlCommand("", Conn1);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (TipoOperacionActual)
                {
                    case TipoOperacion.Insert:
                        cmd.CommandText = "[codesahn].[sp_set_insert_nuevo_producto_terminado_v5]";

                        break;
                    case TipoOperacion.Update:
                        cmd.CommandText = "[codesahn].[sp_set_update_nuevo_producto_terminado_v5]";
                        cmd.Parameters.AddWithValue("@id", PT_Class_instance.Id);
                        break;
                }

                if (!tggCosteoPorArroba.IsOn)
                    CostoPorArroba = 0;
                
                cmd.Parameters.AddWithValue("@id_user_created", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@enable", toggleSwitchEnablePT.IsOn);
                cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEdit_Presentaciones.EditValue);
                cmd.Parameters.AddWithValue("@id_estado", gridLookUpEditEstadoPT.EditValue);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcionProducto.Text);
                cmd.Parameters.AddWithValue("@code", txtCodigoProducto.Text);
                cmd.Parameters.AddWithValue("@tipo_id", gridLookUpEditTipoProducto.EditValue);
                cmd.Parameters.AddWithValue("@costo_mo_por_arroba", tggCosteoPorArroba.IsOn);
                cmd.Parameters.AddWithValue("@costo_por_arroba", CostoPorArroba);
                cmd.Parameters.AddWithValue("@id_tipo_facturacion", glueTipoFacturacion.EditValue);

                int id_tipoBuffet = dp.ValidateNumberInt32(glueTipoBuffet.EditValue);
                if(id_tipoBuffet <= 0)
                    cmd.Parameters.AddWithValue("@id_tipo_buffet", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_tipo_buffet", glueTipoBuffet.EditValue);

                cmd.Parameters.AddWithValue("@id_tipo_facturacion_prd", gridLookUpEditTipoFacturacionDestino.EditValue);
                
                if(dp.ValidateNumberInt32(Convert.ToInt32(gle_ClaseProducto.EditValue))==0)
                    cmd.Parameters.AddWithValue("@id_clase", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_clase", gle_ClaseProducto.EditValue);


                if (dp.ValidateNumberInt32(Convert.ToInt32(gleImpuestoAplicable.EditValue)) == 0)
                    cmd.Parameters.AddWithValue("@id_impuesto_aplicable", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_impuesto_aplicable", gleImpuestoAplicable.EditValue);

                cmd.ExecuteNonQuery();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tggCosteoPorArroba_Toggled(object sender, EventArgs e)
        {
            if(tggCosteoPorArroba.IsOn == false)
            {
                txtCostoPorArroba.Enabled = false;
            }
            else
            {
                txtCostoPorArroba.Enabled = true;
            }
        }

        private void txtCostoPorArroba_Validated(object sender, EventArgs e)
        {
            decimal val = 0;
            try
            {
                val = Convert.ToDecimal(txtCostoPorArroba.Text);
            }
            catch
            {
                val = 0;
            }
            CostoPorArroba = val;
        }

        private void gridLookUpEditTipoFacturacionDestino_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEditTipoFacturacionDestino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}