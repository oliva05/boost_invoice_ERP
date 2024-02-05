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
using JAGUAR_APP.Calidad.LoteConfConsumo;
using JAGUAR_APP.TransaccionesMP;
using JAGUAR_APP.LogisticaJaguar;

namespace JAGUAR_APP.Reportes
{
    public partial class frmAsjuteInventarioPorLote : DevExpress.XtraEditors.XtraForm
    {
        private string ItemCode;//Codigo MP de SAP
        private decimal factorValue;
        private int Id_MP, Id_Presentacion;
        private string cardcode; //Codigo de Proveedor
        UserLogin UsuarioLogueado;
        //private decimal FactorUnidades;
        MateriaPrima MateriaPrimaActual;
        private decimal existencia_bodega_selected;
        private string bodega_selected;

        public frmAsjuteInventarioPorLote(UserLogin pUserLogin)
        {
            InitializeComponent();
            DataOperations dp1 = new DataOperations();
            dtFechaDocumento.DateTime = dp1.NowSetDateTime();
            LoadMaestrosBodegas();
            UsuarioLogueado = pUserLogin;

            LoadPresentaciones();
        }

        public frmAsjuteInventarioPorLote(UserLogin pUserLogin, int pIdMP, int id_lote_alosy, string pLote, int pid_bodega)
        {
            InitializeComponent();
            //ESTO SOLO ES PARA REPROCESO
            DataOperations dp1 = new DataOperations();
            dtFechaDocumento.DateTime = dp1.NowSetDateTime();
            MateriaPrimaActual = new MateriaPrima();
            UsuarioLogueado = pUserLogin;
  
            //LoadPresentaciones();

            if (MateriaPrimaActual.RecuperarRegistroFromID_RM(pIdMP))
            {
                Id_MP = pIdMP;
                txtMP_Name.Text = MateriaPrimaActual.NameComercial;

                //SearchLoteAuto(pIdMP, pLote);
                ItemCode = MateriaPrimaActual.CodeMP_SAP;
                LoadMaestrosBodegas();
                tsTipoTransaccion.IsOn = false;
                txtNumLote.Text = pLote;
                glueBodega.EditValue = pid_bodega;

                if (pid_bodega > 0)
                {
                    foreach (dsReportesInventario.bodega_origenRow item in dsReportesInventario.bodega_origen.Rows)
                    {
                        if (item.id == pid_bodega)
                        {
                            existencia_bodega_selected = item.existencia;
                            bodega_selected = item.descripcion;
                        }
                    }
                }
            }

        }


        public frmAsjuteInventarioPorLote(UserLogin pUserLogin, int pIdMP, int id_lote_alosy, string pLote)
        {
            InitializeComponent();
            DataOperations dp1 = new DataOperations();
            dtFechaDocumento.DateTime = dp1.NowSetDateTime();
            //LoadMaestrosBodegas();
            MateriaPrimaActual = new MateriaPrima();
            UsuarioLogueado = pUserLogin;
            //LoadPresentaciones();
            if (MateriaPrimaActual.RecuperarRegistroFromID_RM(pIdMP))
            {
                Id_MP = pIdMP;
                txtMP_Name.Text = MateriaPrimaActual.NameComercial;
                //SearchLoteAuto(pIdMP, pLote);
                ItemCode = MateriaPrimaActual.CodeMP_SAP;
                LoadMaestrosBodegas();
                //frmLotePorMP frm = new frmLotePorMP(Id_MP);
                //if (this.MdiParent != null)
                //{
                //    frm.FormBorderStyle = FormBorderStyle.Sizable;
                //}
                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //    txtNumLote.Text = frm.Lote;
                //    Id_Lote_Alosy = frm.Id_Lote;
                //    gridLookUpEditPresentacion.EditValue = frm.Id_UnidadMedida;
                //    Numero_transaccion = frm.Num_ingreso;
                //    FactorUnidades = frm.Factor;

                //    txtCantidadUnidades.Focus();
                //}
            }
            //if (Id_MP == 1110 || Id_MP == 1101)
            //{
            //    tsTipoTransaccion.IsOn = false;
            //    txtNumLote.Text = pLote; 
            //    gridLookUpEditDestino.EditValue = 2;
            //    gridLookUpEditOrigen.EditValue = 10;
            //}
        }

        private void LoadMaestrosBodegas()
        {
           
            DataOperations dp = new DataOperations();
            SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            con.Open();


            string sql = @"SELECT id,
                               descripcion,
                               descripcion_corta
                        FROM dbo.LOSA_bodegas
                        WHERE enable = 1";

            SqlCommand cmd = new SqlCommand(sql, con);

            dsReportesInventario.bodega_origen.Clear();

            SqlDataAdapter adat = new SqlDataAdapter(cmd);

            adat = new SqlDataAdapter(cmd);

            adat.Fill(dsReportesInventario.bodega_origen);
            con.Close();



        }

        //void SearchLoteAuto(int pidmp, string plote_)
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
        //        cn.Open();
        //        SqlCommand cmd = new SqlCommand("sp_get_lotes_for_mp_from_lot_and_id_mp", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id_mp", pidmp);
        //        cmd.Parameters.AddWithValue("@plote", plote_);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            Id_Lote_Alosy = dr.GetInt32(2);
        //            if (Id_Lote_Alosy > 0)
        //            {
        //                //txtLoteNuevo.Enabled = true;
        //                //txtNumLote.Enabled= false;
        //                MateriaPrima mat1 = new MateriaPrima();
        //                if (mat1.RecuperarRegistroFromID_RM(pidmp))
        //                {
        //                    ItemCode = mat1.CodeMP_SAP;//Codigo MP de SAP
        //                    MateriaPrimaActual = mat1;
        //                }
        //                txtLoteNuevo.Text = txtNumLote.Text = dr.GetString(0);
        //                Numero_transaccion = dr.GetInt32(1); // Numero de Ingresp

        //                factorValue = dr.GetDecimal(5);
        //                Id_Presentacion = dr.GetInt32(6);
        //                Id_MP = pidmp;
        //                //cardcode; //Codigo de Proveedor
        //            }
        //            else
        //            {
        //                //txtLoteNuevo.Enabled = false;
        //                //txtNumLote.Enabled = true;
        //            }
        //        }
        //        dr.Close();
        //        cn.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        MessageBox.Show(ec.Message);
        //    }
        //}


        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_get_presentacion_for_materia_prima_jaguar_mp]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantenimiento.Presentacion_tipo.Clear();
                adat.Fill(dsMantenimiento.Presentacion_tipo);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void cmdGuardar_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(txtMP_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la Materia Prima!");
                return;
            }

            if (Convert.ToDecimal(spinEditUnidades.Value) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de materia en cero (0)!");
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

            DataOperations dp = new DataOperations();

            if (tsTipoTransaccion.IsOn) //ENTRADA EN EL KARDEX GENERAL
            {
                tipoTransaccion = 1;
            }
            else
                tipoTransaccion = 2;

            try
            {

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.insert_Ajuste_Kardex_Inventario_MP", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                    cmd.Parameters.AddWithValue("@item_code", ItemCode);
                    cmd.Parameters.AddWithValue("@id_bodega", glueBodega.EditValue);
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@unidades", spinEditUnidades.Text);
                    cmd.Parameters.AddWithValue("@id_presentacion", Id_Presentacion);
                    cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                    cmd.Parameters.AddWithValue("@tipo_transaccion", tipoTransaccion);
                    cmd.Parameters.AddWithValue("@fecha", dtFechaDocumento.EditValue);

                    cmd.ExecuteNonQuery();

                    cnx.Close();
                }

                CajaDialogo.Information("DATOS GUARDADOS");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

            //if (tsTipoTransaccion.IsOn == false) //SALIDA EN EL KARDEX GENERAL
            //{
            //    if (existencia_bodega_selected <= 0)
            //    {
            //        CajaDialogo.Error("No puede dar salida al item " + ItemCode + " por que es 0 en la Bodega: " + bodega_selected);
            //        return;
            //    }
                //if (radioLoteExistente.Checked)
                //{
                //    try
                //    {
                //        //DataOperations dp = new DataOperations();
                //        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                //        conn.Open();
                //        SqlCommand cmd = new SqlCommand("sp_ajuste_kardex_por_lote_v4", conn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@cant_entrada", 0);
                //        cmd.Parameters.AddWithValue("@cant_salida", spinEditPesoKg.EditValue);
                        
                //        cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                //        cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                //        cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                //        cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
                //        cmd.Parameters.AddWithValue("@ud_entrada", 0);
                //        cmd.Parameters.AddWithValue("@ud_salida", spinEditUnidades.EditValue);
                //        cmd.Parameters.AddWithValue("@fechaDocumento", dtFechaDocumento.EditValue);                        
                //        if (dp.ValidateNumberInt32(glueBodega.EditValue) > 0)
                //            cmd.Parameters.AddWithValue("@bodega_origen", glueBodega.EditValue);
                //        else
                //            cmd.Parameters.AddWithValue("@bodega_origen", DBNull.Value);

                //        if (dp.ValidateNumberInt32(gridLookUpEditDestino.EditValue) > 0)
                //            cmd.Parameters.AddWithValue("@bodega_destino", gridLookUpEditDestino.EditValue);
                //        else
                //            cmd.Parameters.AddWithValue("@bodega_destino", DBNull.Value);

                //        if(string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
                //            cmd.Parameters.AddWithValue("id_presentacion", DBNull.Value);
                //        else
                //            cmd.Parameters.AddWithValue("id_presentacion", gridLookUpEditPresentacion.EditValue);
                //        cmd.Parameters.AddWithValue("@tipo_operacion", 1);//Forzosamente debe ser ajuste
                //        cmd.ExecuteNonQuery();
                //        conn.Close();

                //        CajaDialogo.Information("Transaccion Exitosa!");
                //        this.DialogResult = DialogResult.OK;
                //        this.Close();
                //    }
                //    catch (Exception ex)
                //    {
                //        CajaDialogo.Error(ex.Message);
                //    }
                //}
            //}
            
            
       

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cardcode = frm.Cardcode;
   
                
            }
        }

        private void gridLookUpEditPresentacion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
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
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }



        int tipoTransaccion;
        private void tsTipoTransaccion_Toggled(object sender, EventArgs e)
        {
            if (tsTipoTransaccion.IsOn == true)
            {
                tipoTransaccion = 1;

            }
            else
            {
                tipoTransaccion = 2;
            }
        }

        private void txtCantidadUnidades_Enter(object sender, EventArgs e)
        {
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }



        private void spinEditUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                decimal cantidad_ = 0;
                try
                {
                    cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
                //if (radioLoteNuevo.Checked)
                //{
                //    spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
                //}
                //else
                //    spinEditPesoKg.EditValue = (FactorUnidades * cantidad_).ToString();
            }
        }


        private void gridLookUpEdit1View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var SelectedBodega = gridLookUpEdit1View.GetDataRow(e.RowHandle);

            existencia_bodega_selected = Convert.ToDecimal(SelectedBodega["existencia"]);
            bodega_selected = Convert.ToString(SelectedBodega["descripcion"]);
        }

        private void frmAsjuteInventarioPorLote_Load(object sender, EventArgs e)
        {
            if (tsTipoTransaccion.IsOn == true)
            {
                tipoTransaccion = 1;
            }
            else
            {
                tipoTransaccion = 2;
            }

            glueBodega.EditValue = 1;

        }

        private void txtNumLote_Enter(object sender, EventArgs e)
        {
            //frmLotePorMP frm = new frmLotePorMP(Id_MP);
            //if (this.MdiParent != null)
            //{
            //    frm.FormBorderStyle = FormBorderStyle.Sizable;
            //}
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    txtNumLote.Text = frm.Lote;
            //    Id_Lote_Alosy = frm.Id_Lote;
            //    gridLookUpEditPresentacion.EditValue = frm.Id_UnidadMedida;
            //    Numero_transaccion = frm.Num_ingreso;
            //    FactorUnidades = frm.Factor;
            //    gridLookUpEditPresentacion.Enabled = false;
            //    spinEditUnidades.Focus();
            //}
        }

        private void txtMP_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmSearchMP frm = new frmSearchMP(tipoTransaccion);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMP_Name.Text = frm.ItemSeleccionado.ItemName;
                ItemCode = frm.ItemSeleccionado.ItemCode;
                Id_MP = frm.ItemSeleccionado.id;
            }
        }

        private void txtNumLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLotePorMP frm = new frmLotePorMP(Id_MP, txtMP_Name.Text, ItemCode);

            if (this.MdiParent != null)
            {
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = frm.Lote;
                gridLookUpEditPresentacion.EditValue = frm.Id_Presentacion;
                Id_Presentacion = frm.Id_Presentacion;
                spinEditUnidades.Focus();
            }
        }

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
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch {}
        }
    }
}