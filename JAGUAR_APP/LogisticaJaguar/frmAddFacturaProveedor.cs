using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.MaterialEmpaque.Model;
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

namespace JAGUAR_APP.LogisticaJaguar
{
    public partial class frmAddFacturaProveedor : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        Proveedor ProveedorActual;
        FacturaProveedorH FacturaProveedorH_Actual;

        public enum TipoAccionVentana
        {
            Insert = 1,
            Update = 2
        }

        TipoAccionVentana TipoAccionActualVentana;

        public frmAddFacturaProveedor(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            TipoAccionActualVentana = TipoAccionVentana.Insert;
            FacturaProveedorH_Actual = new FacturaProveedorH();
            this.UsuarioLogeado = pUsuarioLogeado;
            dp = new DataOperations();
            dtFechaFactura.EditValue = dtHoraEntregado.EditValue = dtHoraRecibido.EditValue = dp.NowSetDateTime();
            if (UsuarioLogeado.ValidarNivelPermisos(3))
            {
                dtHoraRevisado.EditValue = dtHoraRecibido.EditValue;
                txtNombreRevisado.Text = pUsuarioLogeado.Nombre;
            }
            else
            {
                dtHoraRevisado.Enabled = false;
            }

            LoadMateriasPrimas();
            LoadProveedoresList();
            LoadPresentacionFacturaList(); 
            LoadPresentacionJaguarList();
            LoadBodegaList();

            txtNombreRecibido.Text = pUsuarioLogeado.Nombre;
        }

        public frmAddFacturaProveedor(UserLogin pUsuarioLogeado, TipoAccionVentana pTipoAccionVentana, Int64 pIdFacturaH)
        {
            InitializeComponent();
            TipoAccionActualVentana = pTipoAccionVentana;
            this.UsuarioLogeado = pUsuarioLogeado;
            FacturaProveedorH_Actual = new FacturaProveedorH();
            dp = new DataOperations();

            switch (TipoAccionActualVentana)
            {
                case TipoAccionVentana.Insert:
                    
                    dtFechaFactura.EditValue = dtHoraEntregado.EditValue = dtHoraRecibido.EditValue = dp.NowSetDateTime();
                    txtNombreRecibido.Text = pUsuarioLogeado.Nombre;

                    if (UsuarioLogeado.ValidarNivelPermisos(3))
                    {
                        dtHoraRevisado.EditValue = dtHoraRecibido.EditValue;
                        txtNombreRevisado.Text = pUsuarioLogeado.Nombre;
                    }
                    else
                    {
                        dtHoraRevisado.Enabled = false;
                    }

                    LoadMateriasPrimas();
                    LoadProveedoresList();
                    LoadPresentacionFacturaList();
                    LoadPresentacionJaguarList();
                    LoadBodegaList();

                    
                    break;
                case TipoAccionVentana.Update: //************* UPDATE CASE *****************//
                    if (FacturaProveedorH_Actual.RecuperarRegistro(pIdFacturaH))
                    {
                        dtFechaFactura.EditValue = FacturaProveedorH_Actual.fecha_factura;
                        dtHoraEntregado.EditValue = FacturaProveedorH_Actual.fecha_registro;
                        dtHoraRecibido.EditValue = FacturaProveedorH_Actual.fecha_registro;
                        
                        txtNumeroFactura.Text = FacturaProveedorH_Actual.factura;
                        

                        if (UsuarioLogeado.ValidarNivelPermisos(3))
                        {
                            dtHoraRevisado.EditValue = FacturaProveedorH_Actual.hora_revisado;
                            txtNombreRevisado.Text = FacturaProveedorH_Actual.usuario_revisado_name;
                        }
                        else
                        {
                            dtHoraRevisado.Enabled = false;
                        }

                        LoadMateriasPrimas();
                        LoadProveedoresList();
                        LoadPresentacionFacturaList();
                        LoadPresentacionJaguarList();
                        LoadBodegaList();

                        gridLookUpEditProveedor.EditValue = FacturaProveedorH_Actual.id_proveedor;
                        LoadProveedoresCAIList(FacturaProveedorH_Actual.id_proveedor);
                        ProveedorActual = new Proveedor();
                        ProveedorActual.RecuperarRegistro(FacturaProveedorH_Actual.id_proveedor);
                        //gridLookUpEdit_CAI_Proveedor.Text = FacturaProveedorH_Actual.cai;
                        gridLookUpEdit_CAI_Proveedor.EditValue = FacturaProveedorH_Actual.IdCai;
                        txtNombreEntrega.Text = FacturaProveedorH_Actual.entregado_por_nombre;
                        txtIdentidadEntrega.Text = FacturaProveedorH_Actual.entregado_por_identidad;
                        txtTelefonoEntrega.Text = FacturaProveedorH_Actual.entregado_por_telefono;
                        txtObservaciones.Text = FacturaProveedorH_Actual.observaciones;

                        txtNombreRecibido.Text = FacturaProveedorH_Actual.usuario_recibido_name;
                        LoadDetalleFactura(pIdFacturaH);

                        //Validar si tiene permisos de guardar cambios
                        //AFC_ConsumoReal
                        bool accesoprevio = false;
                        int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
                        switch (idNivel)
                        {
                            case 1://Basic View
                            case 2://Basic No Autorization
                            case 3://Medium Autorization
                                cmdGuardar.Visible = false;
                                break;
                            case 4://Depth With Delta
                            case 5://Depth Without Delta
                                accesoprevio = true;
                                cmdGuardar.Visible = true;
                                break;
                            default:
                                cmdGuardar.Visible = false;
                                break;
                        }

                        if (!accesoprevio)
                        {
                            if (UsuarioLogeado.ValidarNivelPermisos(7))
                            {
                                cmdGuardar.Visible = true;
                            }
                            else
                            {
                                //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #7 (Revisión de Facturas Entrada Mercancias)");
                            }
                        }







                    }
                    break;
            }


            
        }

        private void LoadDetalleFactura(long pIdFacturaH)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_lines_invoice_supplier_D", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_facturah", pIdFacturaH);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsLogisticaJaguar1.detalle_recepcion_fact.Clear();
                adat.Fill(dsLogisticaJaguar1.detalle_recepcion_fact);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadMateriasPrimas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_get_materias_primas_list_v3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsLogisticaJaguar1.MP_List.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.MP_List);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadProveedoresList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[Jaguar_sp_GetProveedores_id_descripcion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsLogisticaJaguar1.proveedores_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.proveedores_list);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadProveedoresCAIList(int pIdProveedor)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[JAGUAR_sp_Get_CAIByProveedor]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.CAI_List.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.CAI_List);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadPresentacionFacturaList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_get_presentacion_for_materia_prima_factura_prv]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.unidad_medida_factura.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.unidad_medida_factura);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadPresentacionJaguarList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_get_presentacion_for_materia_prima_jaguar_mp]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.unidad_medida_jaguar.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.unidad_medida_jaguar);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadBodegaList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.jaguar_sp_get_detalle_bodegas_list", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                dsLogisticaJaguar1.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogisticaJaguar1.bodegas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void gridLookUpEditTipoPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(gridLookUpEditProveedor.Text))
            {
                DataOperations dp = new DataOperations();
                if (gridLookUpEditProveedor.EditValue != null) {
                    int idProveedor = dp.ValidateNumberInt32(gridLookUpEditProveedor.EditValue);
                    ProveedorActual = new Proveedor();
                    LoadProveedoresCAIList(idProveedor);
                    ProveedorActual.RecuperarRegistro(idProveedor);
                }
            }
        }

        private void cmdAddFactura_Click(object sender, EventArgs e)
        {
            int count_lines = dsLogisticaJaguar1.detalle_recepcion_fact.Rows.Count;

            dsLogisticaJaguar.detalle_recepcion_factRow row1 = dsLogisticaJaguar1.detalle_recepcion_fact.Newdetalle_recepcion_factRow();
            //row1.cantidad = 0;
            //row1.cantidad_ingreso = 0;
            row1.id_ud_medida_prv = 0;
            row1.id_ud_medida_jaguar = 0;
            row1.id_mp = 0;
            //row1.ItemCode = "";
            //row1.total_fila = 0;

            row1.num_linea = count_lines + 1;
            row1.id_bodega = 1;
            dsLogisticaJaguar1.detalle_recepcion_fact.Adddetalle_recepcion_factRow(row1);
            dsLogisticaJaguar1.AcceptChanges();


            if (dsLogisticaJaguar1.detalle_recepcion_fact.Count > 1)
            {
                int filai = 1;
                foreach(dsLogisticaJaguar.detalle_recepcion_factRow row in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
                {
                    row.num_linea = filai;
                    filai++;
                }
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataOperations dp = new DataOperations();
            switch (e.Column.FieldName)
            {
                case "cantidad":
                case "id_ud_medida_prv":
                case "id_ud_medida_jaguar":
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView.GetFocusedDataRow();
                    
                    int idOrigen = dp.ValidateNumberInt32(row.id_ud_medida_prv);
                    int idDestino = dp.ValidateNumberInt32(row.id_ud_medida_jaguar);

                    if(idOrigen>0 && idDestino > 0)
                    {
                        PresentacionX Pres1 = new PresentacionX();
                        decimal factor = Pres1.Factor_conversion(idOrigen, idDestino);

                        if(factor > 0)
                        {
                            row.cantidad_ingreso = (row.cantidad * factor);
                        }
                    }
                    
                    break;
                case "id_mp":
                    var gridView1 = (GridView)gridControl1.FocusedView;
                    var row1 = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView1.GetFocusedDataRow();

                    MateriaPrima mp1 = new MateriaPrima();
                    if (mp1.RecuperarRegistroFromID_RM(row1.id_mp))
                    {
                        row1.id_ud_medida_jaguar = mp1.IdPresentacionDefault;
                        idOrigen = dp.ValidateNumberInt32(row1.id_ud_medida_prv);
                        idDestino = dp.ValidateNumberInt32(row1.id_ud_medida_jaguar);
                        row1.ItemCode = mp1.Codigo;
                        row1.descripcion_mp = mp1.NameComercial;

                        if (idOrigen > 0 && idDestino > 0)
                        {
                            PresentacionX Pres1 = new PresentacionX();
                            decimal factor = Pres1.Factor_conversion(idOrigen, idDestino);

                            if (factor > 0)
                            {
                                row1.cantidad_ingreso = (row1.cantidad * factor);
                            }
                        }
                    }
                    break;
                case "ItemCode":
                    var gridView2 = (GridView)gridControl1.FocusedView;
                    var row2 = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView2.GetFocusedDataRow();

                    if (row2.ItemCode.Contains("MP"))
                    {
                        MateriaPrima mp2 = new MateriaPrima();
                        if (mp2.RecuperarRegistroFromItemCode(row2.ItemCode))
                        {
                            row2.id_ud_medida_jaguar = mp2.IdPresentacionDefault;
                            idOrigen = dp.ValidateNumberInt32(row2.id_ud_medida_prv);
                            idDestino = dp.ValidateNumberInt32(row2.id_ud_medida_jaguar);
                            row2.ItemCode = mp2.Codigo;
                            row2.id_mp = mp2.IdMP_ACS;
                            row2.descripcion_mp = mp2.NameComercial;
                            row2.type_id = 1;//MP

                            if (idOrigen > 0 && idDestino > 0)
                            {
                                PresentacionX Pres1 = new PresentacionX();
                                decimal factor = Pres1.Factor_conversion(idOrigen, idDestino);

                                if (factor > 0)
                                {
                                    row2.cantidad_ingreso = (row2.cantidad * factor);
                                }
                            }
                        }
                    }
                    else
                    {
                        Material_Empaque mp2 = new Material_Empaque();
                        if (mp2.RecuperaRegistroFromItemCode(row2.ItemCode))
                        {
                            row2.id_ud_medida_jaguar = mp2.PresentacionID;
                            idOrigen = dp.ValidateNumberInt32(row2.id_ud_medida_prv);
                            idDestino = dp.ValidateNumberInt32(row2.id_ud_medida_jaguar);
                            row2.ItemCode = mp2.Codigo;
                            row2.descripcion_mp = mp2.Material;
                            row2.type_id = 2;//ME
                            row2.id_mp = mp2.ID;

                            if (idOrigen > 0 && idDestino > 0)
                            {
                                PresentacionX Pres1 = new PresentacionX();
                                decimal factor = Pres1.Factor_conversion(idOrigen, idDestino);

                                if (factor > 0)
                                {
                                    row2.cantidad_ingreso = (row2.cantidad * factor);
                                }
                            }
                        }
                    }

                    

                    break;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!dp.ValidateNumberStringText(gridLookUpEditProveedor.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el proveedor!");
                return;
            }

            if (!ProveedorActual.Recuperado)
            {
                CajaDialogo.Error("Es necesario seleccionar el proveedor!");
                return;
            }

            if (!dp.ValidateNumberStringText(gridLookUpEdit_CAI_Proveedor.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el CAI del proveedor!");
                return;
            }

            if (!dp.ValidateNumberStringText(txtNumeroFactura.Text))
            {
                CajaDialogo.Error("Es necesario ingresar el número de la Factura!");
                return;
            }

            if (!dp.ValidateNumberStringText(dtFechaFactura.Text))
            {
                CajaDialogo.Error("Es necesario indicar la fecha de la Factura!");
                return;
            }

            if (dsLogisticaJaguar1.detalle_recepcion_fact.Rows.Count == 0)
            {
                CajaDialogo.Error("Es necesario indicar el detalle de lineas de la Factura!");
                return;
            }

            bool Problemas = false;
            int fila = 0;
            foreach (dsLogisticaJaguar.detalle_recepcion_factRow row in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
            {
                //if (row.type_id == 1)
                //{
                    if (row.cantidad == 0 || row.id_ud_medida_prv == 0 ||
                        row.cantidad_ingreso == 0 || row.id_ud_medida_jaguar == 0 ||
                        row.id_mp == 0 || row.total_fila == 0)
                    {
                        Problemas = true;
                        fila = row.num_linea;
                        break;
                    }
                //}
                //else
                //{
                //    if (row.cantidad == 0 || row.id_ud_medida_prv == 0 ||
                //        row.cantidad_ingreso == 0 || row.id_ud_medida_jaguar == 0 ||
                //        row. == 0 || row.total_fila == 0)
                //    {
                //        Problemas = true;
                //        fila = row.num_linea;
                //        break;
                //    }
                //}
            }

            if (Problemas)
            {
                CajaDialogo.Error("Se encontraron datos incompletos en el detalle de lineas de factura! Linea: " + fila.ToString());
                return;
            }

            try
            {

                DataOperations dp = new DataOperations();
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    SqlTransaction transaction;

                    // Start a local transaction.
                    transaction = connection.BeginTransaction("SampleTransaction");

                    // Must assign both transaction object and connection
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    try
                    {

                        if (TipoAccionActualVentana == TipoAccionVentana.Insert)
                        {
                            //Insert Header
                            cmd.CommandText = "[codesahn].[jaguar_sp_insert_recepcion_factura_compra_v2]";
                            cmd.CommandType = CommandType.StoredProcedure;
                        }
                        else
                        {
                            cmd.CommandText = "[codesahn].[jaguar_sp_update_recepcion_factura_compra]";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_header", FacturaProveedorH_Actual.idFacturaH);
                        }
                        
                        cmd.Parameters.AddWithValue("@id_proveedor", gridLookUpEditProveedor.EditValue);
                        cmd.Parameters.AddWithValue("@id_usuario_recibido", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@cai", gridLookUpEdit_CAI_Proveedor.Text);
                        cmd.Parameters.AddWithValue("@id_cai", gridLookUpEdit_CAI_Proveedor.EditValue);
                        cmd.Parameters.AddWithValue("@factura", txtNumeroFactura.Text);
                        cmd.Parameters.AddWithValue("@fecha_factura", dtFechaFactura.EditValue);
                        cmd.Parameters.AddWithValue("@entregado_por_nombre", txtNombreEntrega.Text);
                        cmd.Parameters.AddWithValue("@entregado_por_identidad", txtIdentidadEntrega.Text);
                        cmd.Parameters.AddWithValue("@entregado_por_hora", dtHoraEntregado.EditValue);
                        cmd.Parameters.AddWithValue("@entregado_por_telefono", txtTelefonoEntrega.Text);
                        
                        if(string.IsNullOrEmpty(dtHoraRevisado.Text))
                            cmd.Parameters.AddWithValue("@id_usuario_revisado", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_usuario_revisado", this.UsuarioLogeado.Id);

                        if (string.IsNullOrEmpty(dtHoraRevisado.Text))
                            cmd.Parameters.AddWithValue("@hora_revisado", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@hora_revisado", dtHoraRevisado.EditValue);

                        cmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text);

                        int id_H = 0;


                        if (TipoAccionActualVentana == TipoAccionVentana.Insert)
                            id_H = dp.ValidateNumberInt32(cmd.ExecuteScalar());
                        else
                            cmd.ExecuteNonQuery();

                        //Insert Detalle y transaccion de kardex
                        foreach (dsLogisticaJaguar.detalle_recepcion_factRow row in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
                        {
                            cmd.Parameters.Clear();
                            if (TipoAccionActualVentana == TipoAccionVentana.Insert)
                            {
                                //Insert Detalle
                                cmd.CommandText = "[codesahn].[sp_set_insert_detalle_factura_proveedor_d_v3]";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_factura_h", id_H);//Header id recien insertado en la transaccion
                            }
                            else
                            {
                                Int64 id_linea_new = 0;
                                try
                                {
                                    id_linea_new = row.id;
                                }
                                catch { }

                                if(id_linea_new == 0)
                                {
                                    cmd.CommandText = "[codesahn].[sp_set_insert_detalle_factura_proveedor_d_v3]";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_factura_h", FacturaProveedorH_Actual.idFacturaH);
                                }
                                else
                                {
                                    cmd.CommandText = "[codesahn].[sp_set_update_detalle_factura_proveedor_d_v2]";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_linea_detalle", row.id);
                                    cmd.Parameters.AddWithValue("@id_factura_h", FacturaProveedorH_Actual.idFacturaH);
                                }
                                
                            }
                            //cmd.CommandText = "[codesahn].[sp_set_insert_detalle_factura_proveedor_d_v2]";
                            //cmd.CommandType = CommandType.StoredProcedure;
                            
                            cmd.Parameters.AddWithValue("@cantidad_factura", row.cantidad);
                            cmd.Parameters.AddWithValue("@id_unidad_medida_factura", row.id_ud_medida_prv);
                            cmd.Parameters.AddWithValue("@descripcion", row.descripcion_mp);
                            cmd.Parameters.AddWithValue("@cantidad_entrada", row.cantidad_ingreso);
                            cmd.Parameters.AddWithValue("@id_unidad_medida_entrada", row.id_ud_medida_jaguar);
                            cmd.Parameters.AddWithValue("@total_linea", row.total_fila);
                            cmd.Parameters.AddWithValue("@id_materia_prima", row.id_mp);
                            cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@num_factura", txtNumeroFactura.Text);
                            cmd.Parameters.AddWithValue("@item_code", row.ItemCode);
                            cmd.Parameters.AddWithValue("@id_bodega", 1);//row.id_bodega);
                            cmd.Parameters.AddWithValue("@codigo_proveedor", ProveedorActual.Jaguar_codigo);
                            cmd.Parameters.AddWithValue("@tipo_item", row.type_id);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                    }
                }//End using
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

        private void cmdEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de eliminar esta linea?");
            if (r != DialogResult.Yes)
                return;

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsLogisticaJaguar.detalle_recepcion_factRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsLogisticaJaguar1.AcceptChanges();
                if (dsLogisticaJaguar1.detalle_recepcion_fact.Count > 1)
                {
                    int filai = 1;
                    foreach (dsLogisticaJaguar.detalle_recepcion_factRow rowx in dsLogisticaJaguar1.detalle_recepcion_fact.Rows)
                    {
                        rowx.num_linea = filai;
                        filai++;
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }
    }
}