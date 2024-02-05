using DevExpress.XtraEditors;
//using JAGUAR_APP.RecepcionMP;
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
using JAGUAR_APP.Clases;
using System.Data.SqlClient;
using Core.Clases.Herramientas;
using System.Collections;
using DevExpress.XtraReports.UI;
using JAGUAR_APP.Reportes;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.AlmacenesExterno.Salida_Almacen
{
    public partial class frmTipoIngreso_v2 : DevExpress.XtraEditors.XtraForm
    {
        public int idTransferencia_Externa_SalidaH;
        public int IdSerie;
        public string ItemCode;
        public string ItemName;
        public string CardCode;
        public string Proveedor;
        public DateTime f_ingreso;
        public int id_presentacion;
        public int N_Referencia;
        public DateTime f_vencimiento;
        public DateTime f_produccion;
        public string lote;
        public decimal PesoTraslado;
        public decimal factor=1;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmTipoIngreso_v2(int id_traslado, UserLogin Puser)
        {
            InitializeComponent();
            idTransferencia_Externa_SalidaH = id_traslado;
            load_salidoTraslado();
            LoadPresentaciones();
            LoadNumeroTransaccion();
            LoadData();
            LoadBarcos();
            LoadUbicaciones();
            UsuarioLogeado = Puser;

            tb_opciones.TabPages[1].PageVisible = false;
        }
        public frmTipoIngreso_v2(int id_traslado, UserLogin Puser, string pItemCode)
        {
            InitializeComponent();
            ItemCode = pItemCode;
            idTransferencia_Externa_SalidaH = id_traslado;
            load_salidoTraslado();
            LoadPresentaciones();
            LoadNumeroTransaccion();
            LoadData();
            LoadBarcos();
            LoadUbicaciones();
            UsuarioLogeado = Puser;

            tb_opciones.TabPages[1].PageVisible = false;
        }
        private void LoadData()
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("sp_get_ingresos_granel_mp_traslados_v2", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@itemcode", ItemCode);
            //    dsRecepcionMPx1.granel.Clear();
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    adat.Fill(dsRecepcionMPx1.granel);
            //    con.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }
        private void LoadUbicaciones()
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            //    string SQL = @"sp_get_lista_ubicaciones_granel";
            //    SqlCommand cmd = new SqlCommand(SQL, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    //cmd.Parameters.AddWithValue("@codigo_barra", "");
            //    dsRecepcionMPx1.ubicaciones_granel.Clear();
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    adat.Fill(dsRecepcionMPx1.ubicaciones_granel);

            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }
        private void LoadBarcos()
        {
            //
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("sp_get_ships_active_for_losa", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    //cmd.Parameters.AddWithValue("@idbodega", idBodega);
            //    dsRecepcionMPx1.barcos.Clear();
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    adat.Fill(dsRecepcionMPx1.barcos);

            //    con.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }
        private void LoadNumeroTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 2);
                string num_ingreso = cmm2.ExecuteScalar().ToString();
                txtNumIngreso.Text = num_ingreso;
                txtingresoGranel.Text = num_ingreso;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        public void load_salidoTraslado() 
        {
            try
            {
                string query = @"sp_load_informacion_transporte_externo";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_transporte", idTransferencia_Externa_SalidaH);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ItemCode = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    ItemName = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    CardCode = dr.IsDBNull(2) ? "" : dr.GetString(2);
                    Proveedor = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    f_ingreso = dr.IsDBNull(4) ? DateTime.Now : dr.GetDateTime(4);
                    id_presentacion = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                    lote = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    f_vencimiento = dr.IsDBNull(7) ? DateTime.Now : dr.GetDateTime(7);
                    f_produccion = dr.IsDBNull(8) ? DateTime.Now : dr.GetDateTime(8);
                    PesoTraslado = dr.IsDBNull(9) ? 0 : dr.GetDecimal(9);


                    txtCodigoMP.Text = ItemCode;
                    txtMP_Name.Text = ItemName;
                    txtCodigoProveedor.Text = CardCode;
                    txtProveedorName.Text = Proveedor;
                    gridLookUpEditPresentacion.EditValue = id_presentacion;
                    dtFechaIngreso.EditValue = f_ingreso;
                    dtFechaProduccion.EditValue = f_produccion;
                    dtFechaVencimiento.EditValue = f_vencimiento;
                    txtLote.Text = lote;
                    txtPesoTransferencia.Text = PesoTraslado.ToString();
                    txtMPCgranel.Text = ItemCode;
                    txtMPgranel.Text = ItemName;
                    dtIngresoGranel.EditValue = f_ingreso;
                    txtLoteGranel.Text = lote;
                    dtProduccionGranel.EditValue = f_produccion;
                    dtVencimientoGranel.EditValue = f_vencimiento;
                    txtPesotransferenciaGranel.Text = PesoTraslado.ToString();



                }

                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            
        }
        private void LoadPresentaciones()
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    dsRecepcionMPx1.presentaciones.Clear();
            //    adat.Fill(dsRecepcionMPx1.presentaciones);
            //    con.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }
      


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            btnsacos.Appearance.BackColor = Color.FromArgb(77, 201, 176);
            btngranel.Appearance.BackColor = Color.FromArgb(255, 255, 255);
            tb_opciones.TabIndex = 0;
            tb_opciones.TabPages[0].PageVisible  = true;
            tb_opciones.TabPages[1].PageVisible = false;
        }

        private void btngranel_Click(object sender, EventArgs e)
        {
            btngranel.Appearance.BackColor = Color.FromArgb(77, 201, 176);
            btnsacos.Appearance.BackColor = Color.FromArgb(255, 255, 255);
            tb_opciones.TabIndex = 1;
            tb_opciones.TabPages[1].PageVisible = true;
            tb_opciones.TabPages[0].PageVisible = false;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //FrmBoleta frm = new FrmBoleta();
            //frm.WindowState = FormWindowState.Maximized;
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    txtIdBoleta.Text = frm.NumBoleta.ToString();
            //    this.IdSerie = frm.IdSerie;
            //}
        }

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            PresentacionX pre1 = new PresentacionX();
            if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
            {
                factor = pre1.Factor;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
            }
        }

        private void txtCantidadTarimasTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUnidades_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
            }
            catch
            {
                txtPesoKg.Text = "0";
            }
        }

        private void grdbarco_EditValueChanged(object sender, EventArgs e)
        {
            //int idbarco = Convert.ToInt32(grdbarco.EditValue);
            //foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            //{
            //    row.shipid = idbarco;
            //}
            //dsRecepcionMPx1.granel.AcceptChanges();
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void grdUbicaciones_EditValueChanged(object sender, EventArgs e)
        {
            //int idUbicaciones = Convert.ToInt32(grdUbicaciones.EditValue);
            //foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            //{
            //    row.id_ubicacion = idUbicaciones;
            //}
            //dsRecepcionMPx1.granel.AcceptChanges();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (tb_opciones.TabIndex == 1)       // granel
            {
                try
                {
                    if (txtLoteGranel.Text == "")
                    {
                        CajaDialogo.Error("Debe ingresar un lote valido para registrar el traslado.");
                        return;
                    }
                    if (grdbarco.EditValue == null)
                    {
                        CajaDialogo.Error("Debe registra el barco por el cual viene la materia prima.");
                        return;
                    }
                    if (grdUbicaciones.EditValue == null)
                    {
                        CajaDialogo.Error("Debe registrar la ubicacion en la que el modulo se pueda registrar.");
                        return;
                    }
                    if (dtProduccionGranel.EditValue == null)
                    {
                        CajaDialogo.Error("Debe ingresar la fecha de Producción!");
                        return;
                    }
                    if (dtVencimientoGranel.EditValue == null)
                    {
                        CajaDialogo.Error("Debe ingresar la fecha de Vencimiento!");
                        return;
                    }
                    if (Convert.ToDateTime(dtProduccionGranel.EditValue) >= Convert.ToDateTime(dtVencimientoGranel.EditValue))
                    {
                        CajaDialogo.Error("La fecha de vencimiento no puede ser menor o igual a la fecha de Producción!");
                        return;
                    }

                    string quer = @"sp_obtener_numero_ingreso";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(quer, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int ingreso = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();

                    cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    cn.Open();
                    cmd = new SqlCommand("sp_insert_new_lote_activo_granel_v3", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@lote", txtLote.Text);
                    cmd.Parameters.AddWithValue("@id_user_create", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                    cmd.Parameters.AddWithValue("@fechap", dtProduccionGranel.EditValue);
                    cmd.Parameters.AddWithValue("@fechav", dtVencimientoGranel.EditValue);

                    int id_lote = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();

                    bool PuedeContinuar = false;
                    //foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
                    //{
                    //    if (row.seleccionar)
                    //    {

                    //        try
                    //        {
                    //            int a = row.id_ubicacion;
                    //            if (a > 0)
                    //                PuedeContinuar = true;

                    //        }
                    //        catch
                    //        {
                    //            PuedeContinuar = false;
                    //            break;
                    //        }
                    //    }
                    //}

                    if (!PuedeContinuar)
                    {
                        CajaDialogo.Error("Debe seleccionar una ubicacion valida!");
                        return;
                    }

                    PuedeContinuar = false;
                    //foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
                    //{

                    //    if (row.seleccionar)
                    //    {
                    //        try
                    //        {
                    //            int a = row.shipid;
                    //            if (a > 0)
                    //                PuedeContinuar = true;

                    //        }
                    //        catch
                    //        {
                    //            PuedeContinuar = false;
                    //            break;
                    //        }
                    //    }
                    //}

                    if (!PuedeContinuar)
                    {
                        CajaDialogo.Error("Debe seleccionar una barco valido!");
                        return;
                    }

                    bool Guardo = false;
                    DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar estos ingresos de Materia Prima Granel?");
                    if (r != DialogResult.Yes)
                        return;

                    decimal sumar_Kg = 0;
                    int cantidad_selecionada = 0;
                    //foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
                    //{
                    //    if (row.seleccionar)
                    //    {
                    //        sumar_Kg = sumar_Kg + row.PesoProd;
                    //        cantidad_selecionada = cantidad_selecionada + 1;
                    //    }
                    //}

                    string query = @"sp_insert_ingreso_granel_v2";
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();
                    SqlCommand Comnd = new SqlCommand(query, con);
                    Comnd.CommandType = CommandType.StoredProcedure;
                    Comnd.Parameters.AddWithValue("@entrada", sumar_Kg);
                    Comnd.Parameters.AddWithValue("@lote", txtLote.Text);
                    Comnd.Parameters.AddWithValue("@id_ingreso", ingreso);
                    Comnd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                    Comnd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    Comnd.Parameters.AddWithValue("@count_trailetas", cantidad_selecionada);
                    Comnd.Parameters.AddWithValue("@id_traslado", idTransferencia_Externa_SalidaH);
                    int Id_lote_generado = Convert.ToInt32(Comnd.ExecuteScalar());




                    con.Close();
                    //foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
                    //{
                    //    //
                    //    try
                    //    {
                    //        if (row.seleccionar)
                    //        {
                    //            DataOperations dp = new DataOperations();
                    //            cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    //            cn.Open();

                    //            string SQL = @"sp_set_insert_tarimas_graneles_v3";
                    //            cmd = new SqlCommand(SQL, cn);
                    //            cmd.CommandType = CommandType.StoredProcedure;
                    //            cmd.Parameters.AddWithValue("@id_boleta", row.NBoleta);
                    //            cmd.Parameters.AddWithValue("@entrada", row.PesoProd);
                    //            cmd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                    //            cmd.Parameters.AddWithValue("@lote", txtLote.Text);
                    //            cmd.Parameters.AddWithValue("@id_lote", id_lote);
                    //            cmd.Parameters.AddWithValue("@id", row.id);
                    //            cmd.Parameters.AddWithValue("@id_ubicacion", row.id_ubicacion);
                    //            cmd.Parameters.AddWithValue("@id_ingreso", ingreso);
                    //            cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    //            cmd.Parameters.AddWithValue("@id_lote_alosy", Id_lote_generado);

                    //            cmd.ExecuteNonQuery();
                    //            Guardo = true;
                    //            cn.Close();
                    //        }
                    //    }
                    //    catch (Exception ec)
                    //    {
                    //        MessageBox.Show(ec.Message);
                    //    }
                    //}

                    if (Guardo)
                    {
                        CajaDialogo.InformationAuto();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else//sacos
            {
                try
                {
                    int idloteInserted;
                    if (IdSerie <= 0)
                    {
                        CajaDialogo.Error("No se puede registrar una tarima sin la boleta de bascula!");
                        return;
                    }
                    //if (gvNuevaUbicacion.RowCount <= 0)
                    //{
                    //    CajaDialogo.Error("Debe seleccionar una ubicacion predeterminada para todas las tarimas.");
                    //    return;
                    //}

                    if (Convert.ToDecimal(txtUnidades.Text) <= 0)
                    {
                        CajaDialogo.Error("No se puede registrar una tarima con unidades de materia en cero (0)!");
                        return;
                    }

                    if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
                    {
                        CajaDialogo.Error("Es necesario seleccionar la presentacion de la Materia Prima!");
                        return;
                    }

                    if (string.IsNullOrEmpty(txtLote.Text))
                    {
                        CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
                        return;
                    }

                    if (string.IsNullOrEmpty(dtFechaProduccion.Text))
                    {
                        CajaDialogo.Error("Es obligatorio llenar la fecha de producción!");
                        return;
                    }

                    if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
                    {
                        CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                        return;
                    }
                    int cant = 0;
                    try
                    {
                        cant = Convert.ToInt32(txtCantidadTarimasTotal.Text);
                    }
                    catch
                    {
                        cant = 0;
                    }

                    if (cant <= 0)
                    {
                        CajaDialogo.Error("No se puede registrar menos de una (1) tarima!");
                        return;
                    }

                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_ingresos_v3", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemcode", txtCodigoMP.Text);//          //
                        cmd.Parameters.AddWithValue("@itemname", txtMP_Name.Text);//    //
                        cmd.Parameters.AddWithValue("@cardcode", txtCodigoProveedor.Text);//     //
                        cmd.Parameters.AddWithValue("@cardname", txtProveedorName.Text);  //    //
                        cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                        cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text); //  //
                        cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);//     //
                        cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);//
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);//        //
                        cmd.Parameters.AddWithValue("@id_boleta", this.IdSerie);//      //
                        cmd.Parameters.AddWithValue("@cant", txtUnidades.Text);//   //
                        cmd.Parameters.AddWithValue("@TotalTarimas", txtCantidadTarimasTotal.Text);// //
                        cmd.Parameters.AddWithValue("@pesotaria", Convert.ToDecimal(txtPesoKg.Text));// 
                        cmd.Parameters.AddWithValue("@id_traslado", idTransferencia_Externa_SalidaH);//

                        idloteInserted = Convert.ToInt32(cmd.ExecuteScalar());
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                        return;

                    }

                    bool Guardo = false;
                    int vid_tarima = 0;
                    ArrayList List = new ArrayList();

                    for (int i = 1; i <= cant; i++)
                    {
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                            con.Open();

                            SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                            cmm.CommandType = CommandType.StoredProcedure;
                            cmm.Parameters.AddWithValue("@id", 1);
                            string barcode = cmm.ExecuteScalar().ToString();

                            SqlCommand cmd = new SqlCommand("sp_insert_new_tarima", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@itemcode", txtCodigoMP.Text);
                            cmd.Parameters.AddWithValue("@id_proveedor", txtCodigoProveedor.Text);
                            cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                            cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                            cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                            cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                            cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);
                            cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);

                            PresentacionX pres1 = new PresentacionX();
                            decimal PesoTotalTarima = 0;
                            decimal pres_factor_actual = 0;
                            try
                            {
                                if (pres1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
                                {
                                    PesoTotalTarima = dp.ValidateNumberDecimal(pres1.Factor) * dp.ValidateNumberInt32(txtUnidades.Text);
                                    pres_factor_actual = pres1.Factor;
                                }
                            }
                            catch
                            { }

                            cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@id_boleta", this.IdSerie);
                            cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                            cmd.Parameters.AddWithValue("@cant", txtUnidades.Text);
                            cmd.Parameters.AddWithValue("@peso", PesoTotalTarima/*Convert.ToDecimal(txtPesoKg.Text)*/);
                            cmd.Parameters.AddWithValue("@idlotes", idloteInserted);
                            vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                            SqlCommand cmdx = new SqlCommand("sp_insert_ubicacion_default", con);// ahora recibe el parametro de ubicacion para poder guardarlo automatico en todas las tarimas
                            cmdx.CommandType = CommandType.StoredProcedure;
                            cmdx.Parameters.AddWithValue("@id_tarima", vid_tarima);
                            cmdx.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmdx.Parameters.AddWithValue("@codigo_barra", barcode);
                            cmdx.Parameters.AddWithValue("@id_ubicacion", 131); //bodega c500 predeterminada
                            cmdx.ExecuteNonQuery();

                            List.Add(vid_tarima);

                            Guardo = true;
                            con.Close();  
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                    }

                    //CajaDialogo.InformationAuto();
                    if (Guardo)
                    {
                        DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
                        //if (r == DialogResult.Yes)
                        //{
                        //    for (int i = 0; i <= (List.Count - 1); i++)
                        //    {
                        //        int id_tarimax = Convert.ToInt32(List[i]);
                        //        rptReporteIngresoTarima report = new rptReporteIngresoTarima(id_tarimax);
                        //        report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                        //        report.ShowPrintMarginsWarning = false;
                        //        report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                        //        report.Print();


                        //    }
                        //}
                        rptLoteRotulo boleta = new rptLoteRotulo(idloteInserted);
                        boleta.ShowPrintMarginsWarning = false;
                        boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                        boleta.Print();
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
                catch (Exception ex)
                {


                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{
            //    if (e.Column.Name == "colseleccionar")
            //    {
            //        var gridView = (GridView)gridControl1.FocusedView;
            //        var row = (dsRecepcionMPx.granelRow)gridView.GetFocusedDataRow();
            //        row.seleccionar = Convert.ToBoolean(e.Value);
            //        row.AcceptChanges();
            //    }
            //}
            //catch (Exception ex)
            //{
                   
            //}
        }
    }
}