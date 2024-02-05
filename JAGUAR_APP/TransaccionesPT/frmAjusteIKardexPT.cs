using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;


using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using DevExpress.CodeParser;

namespace JAGUAR_APP.TransaccionesPT
{
    public partial class frmAjusteIKardexPT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp1 = new DataOperations();
        UserLogin UsuarioLogeado;
        public int IdTipoLote;
        //string code_sap; //Codigo de MP de SAP
        private decimal factorValue;
        decimal costo_unitario;

        //private decimal FactorUnidades;
        int Id_PT; //ID de Producto Terminado - Tabla en AQFSVR003.ACS4
        string ItemCode; //Id de lote de Producto Terminado
        public frmAjusteIKardexPT(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            dtFechaDocumento.DateTime = dp1.NowSetDateTime();

            //gridLookUpEditDestino.EditValue = 10;

            LoadPresentaciones();
            //txtNumLote.Visible = true;
        }



        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_presentaciones_activas_ajuste_PT_V2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMP.presentaciones.Clear();
                adat.Fill(dsRecepcionMP.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        //private void LoadBodega()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
        //        con.Open();

        //        SqlCommand cmd = new SqlCommand("dbo.usp_get_JAGUAR_Bodega", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter adat = new SqlDataAdapter(cmd);
        //        dsTarima1.bodega_destino.Clear();
        //        adat.Fill(dsRecepcionMP.presentaciones);
        //        con.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}



        //private void LoadMaestrosBodegas()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
        //        con.Open();

        //        SqlCommand cmd = new SqlCommand("dbo.usp_get_bodega_Kardex_PT", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        dsTarima1.bodega_destino.Clear();
        //        SqlDataAdapter adat = new SqlDataAdapter(cmd);
        //        adat = new SqlDataAdapter(cmd);
        //        adat.Fill(dsTarima1.bodega_destino);

        //        con.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            if (gvLookUpEditPresentacion.RowCount <= 0)
            {
                this.factorValue = 0;
            }
            else
            {
                this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            }

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch { 
            }

        }

        private void txtCantidadUnidades_Leave(object sender, EventArgs e)
        {
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPT_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el Producto Terminado!");
                return;
            }
            //if (string.IsNullOrEmpty(txtNumLote.Text))
            //{
            //    CajaDialogo.Error("Es Necesario seleccionar un Numero de Lote de Producto Terminado");
            //    return;
            //}
            if (gridLookUpEditPresentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe Seleccionar el tipo de presentacion!");
                return;
            }

            if (Convert.ToDecimal(txtCantidadUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de producto terminado en cero (0)!");
                return;
            }
            if (!string.IsNullOrEmpty(dtFechaDocumento.Text))
            {
                if (dtFechaDocumento.DateTime.Year <= 2020)
                {
                    CajaDialogo.Error("Es necesario ingresar una fecha de documento valida!");
                    return;
                }
            }

            //if(IdTipoLote ==2)
            //{
            //    if(dp1.ValidateNumberDecimal(txtCostoUnitario.Text)<=0)
            //    {
            //        CajaDialogo.Error("Es necesario especificar un costo unitario para efectuar este ajuste!");
            //        return;
            //    }
            //}
           
            DataOperations dp = new DataOperations();

            int tipoOperacion = 0;

            if (tsTipoTransaccion.IsOn)
                tipoOperacion = 1;
            else
                tipoOperacion = 2;


            //if (tipoOperacion == 1) //ENTRADA EN EL KARDEX GENERAL
            //{

            //string lote = !string.IsNullOrEmpty(txtNumLote.Text) ? txtNumLote.Text : null;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.[usp_InsertAjusteManual_Kardex_PT_V4]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", Convert.ToDecimal(Id_PT));
                cmd.Parameters.AddWithValue("@id_Usuario", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@fecha_doc", dtFechaDocumento.EditValue);
                cmd.Parameters.AddWithValue("@fecha_reg", DateTime.Now);
                cmd.Parameters.AddWithValue("@code", ItemCode);
                cmd.Parameters.AddWithValue("@unidades", txtCantidadUnidades.Text);
                //cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = !string.IsNullOrEmpty(txtNumLote.Text) ? txtNumLote.Text : null;
                if(string.IsNullOrEmpty(txtNumLote.Text))
                    cmd.Parameters.AddWithValue("@lote", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);

                cmd.Parameters.AddWithValue("@tipoTransaccion", tipoOperacion);
                
                if(IdTipoLote == 0)
                    cmd.Parameters.AddWithValue("@id_tipo_lote", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_tipo_lote", IdTipoLote);


                if (IdTipoLote==2)
                    cmd.Parameters.AddWithValue("@costo_unitario", costo_unitario);
                else
                    cmd.Parameters.AddWithValue("@costo_unitario", DBNull.Value);

                cmd.ExecuteNonQuery();
                conn.Close();

                CajaDialogo.Information("Transaccion Entrada!");
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            //}
        }


        private void txtCantidadUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtPT_Name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPT_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //int tipoTraansaccion = 0;

            //if (tsTipoTransaccion.IsOn)
            //{
            //    tipoTraansaccion = 1;
            //}
            //else
            //    tipoTraansaccion = 2;


            frmPT frm = new frmPT();
            frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPT_Name.Text = frm.ProductoT;
                Id_PT = frm.id_pt;
                ProductoTerminado productoTerminado = new ProductoTerminado();
                if (productoTerminado.Recuperar_producto(Id_PT))
                {
                    this.ItemCode = productoTerminado.Code;
                    gridLookUpEditPresentacion.EditValue = productoTerminado.Id_presentacion;
                }
            }
        }

        private void txtNumLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLotesxPT frm = new frmLotesxPT(Id_PT, this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = Convert.ToString(frm.lot_number);
                ItemCode = frm.code;
                costo_unitario = frm.CostoUnitario;
                this.IdTipoLote = frm.IdTipoLote;

                if (frm.IdTipoLote == 2)
                {
                    lblCostoUnitario.Visible = txtCostoUnitario.Visible = true;
                    txtCostoUnitario.Text = string.Format("{0:###,##0.00}", frm.CostoUnitario);
                    costo_unitario = frm.CostoUnitario;
                }
                else
                {
                    lblCostoUnitario.Visible = txtCostoUnitario.Visible = false;
                }

                gridLookUpEditPresentacion.EditValue = frm.id_presentacion;
            }
        }
    }
}