using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using JAGUAR_APP.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;

namespace JAGUAR_APP.Despachos
{
    public partial class frm_despacho_v3 : DevExpress.XtraEditors.XtraForm
    {
        public int id_despacho;
        public int N_Documento;
        string Error = "";
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        UserLogin usuarioLogueado = new UserLogin();
        Tarima tarimaEncontrada;
        int id_selected = 0;

        public frm_despacho_v3()
        {
            InitializeComponent();

            load_data();
            load_andenes();
        }

        public void load_andenes()
        {
            string query = @"sp_load_andenes_configurados";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.Andenes.Clear();
                da.Fill(ds_despachos.Andenes);
                cn.Close();

                foreach (ds_despachos.AndenesRow row in ds_despachos.Andenes.Rows)
                {
                    switch (row.id)
                    {

                        case 1:
                            Anden1.Visible = true;
                            if (row.bit_orden)
                            {
                                Anden1.Enabled = true;
                                Anden1.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                                if (id_selected == row.id)
                                {

                                    Anden1.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                    N_Documento = row.id_req;
                                    txtDocumento.Text = row.id_req.ToString();
                                }

                            }
                            else
                            {
                                Anden1.Enabled = false;
                                Anden1.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                            }
                            break;
                        case 2:
                            Anden2.Visible = true;
                            if (row.bit_orden)
                            {
                                Anden2.Enabled = true;
                                Anden2.Appearance.BackColor = Color.FromArgb(255, 255, 255);

                                if (id_selected == row.id)
                                {

                                    Anden2.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                    N_Documento = row.id_req;
                                    txtDocumento.Text = row.id_req.ToString();
                                }
                            }
                            else
                            {
                                Anden2.Enabled = false;
                                Anden2.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                            }
                            break;
                        case 3:
                            Anden3.Visible = true;
                            if (row.bit_orden)
                            {
                                Anden3.Enabled = true;
                                Anden3.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                                if (id_selected == row.id)
                                {

                                    Anden3.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                    N_Documento = row.id_req;
                                    txtDocumento.Text = row.id_req.ToString();
                                }
                            }
                            else
                            {
                                Anden3.Enabled = false;
                                Anden3.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                            }
                            break;
                        case 4:
                            Anden4.Visible = true;
                            if (row.bit_orden)
                            {
                                Anden4.Enabled = true;
                                Anden4.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                                if (id_selected == row.id)
                                {

                                    Anden4.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                    N_Documento = row.id_req;
                                    txtDocumento.Text = row.id_req.ToString();
                                }
                            }
                            else
                            {
                                Anden4.Enabled = false;
                                Anden4.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                            }
                            break;
                        case 5:
                            Anden5.Visible = true;
                            if (row.bit_orden)
                            {
                                Anden5.Enabled = true;
                                Anden5.Appearance.BackColor = Color.FromArgb(255, 255, 255);

                                if (id_selected == row.id)
                                {

                                    Anden5.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                    N_Documento = row.id_req;
                                    txtDocumento.Text = row.id_req.ToString();
                                }
                            }
                            else
                            {
                                Anden5.Enabled = false;
                                Anden5.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                            }
                            break;
                        case 6:
                            Anden6.Visible = true;
                            if (row.bit_orden)
                            {
                                Anden6.Enabled = true;
                                Anden6.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                                if (id_selected == row.id)
                                {

                                    Anden6.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                    N_Documento = row.id_req;
                                    txtDocumento.Text = row.id_req.ToString();
                                }
                            }
                            else
                            {
                                Anden6.Enabled = false;
                                Anden6.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                            }
                            break;
                        default:
                            break;
                    }
                }
                load_datar();
                load_filas();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_datar()
        {
            string query = @"sp_load_info_despacho_to_entregar";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", N_Documento);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.info_despacho.Clear();
                da.Fill(ds_despachos.info_despacho);
                cn.Close();
                txtDocumento.Text = N_Documento.ToString();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data()
        {
            string query = @"sp_load_info_operador_pt_despachos";
            SqlConnection CN = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(query, CN);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.op_despachos.Clear();
                da.Fill(ds_despachos.op_despachos);
                CN.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
      
        public void load_activas()
        {
            string query = @"sp_load_info_operador_pt_despachos_todos";
            SqlConnection CN = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(query, CN);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.op_despachos.Clear();
                da.Fill(ds_despachos.op_despachos);
                CN.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {

        }

        private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                dt.Rows.Add("TARIMA", idTarima);
                dt.Rows.Add("Cliente", pProveedor);
                dt.Rows.Add("LOTE", pLote);
                dt.Rows.Add("PRESENTACION", pPpresentacion);

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
            }
        }



        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    string SQL = "exec sp_getTarimas_without_filters_PT @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idTarima = dr.GetInt32(0);

                            if (InfoTarima.RecuperarRegistropt(idTarima, ""))
                            {
                                factorPresentacion = InfoTarima.Factor;
                                tarimaEncontrada = InfoTarima;
                            }

                            gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3).ToString(), dr.GetString(4).ToString());
                            //gvTarima.InitNewRow += GridView1_InitNewRow;
                            gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("TARIMA NO ENCONTRADA");
                        tarimaEncontrada = null;
                        gcTarima.DataSource = null;
                        beTarima.Text = "";
                    }

                    cn.Close();

                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        public void EntregarTarima()
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            datosTarimaPorCodBarra(cn);

            //Entrega de tarima
            int Guardo = 0;
            bool error = false;
            bool disponible = false;
            string mensaje = "";
            if (tarimaEncontrada != null)
            {
                if (tarimaEncontrada.Recuperado)
                {
                    if (!tarimaEncontrada.Enable)
                    {
                        error = true;
                        mensaje = "La tarima no esta activa!";
                    }

                    switch (tarimaEncontrada.id_estado_pt)
                    {
                        case 1://Virtual
                            error = true;
                            mensaje = "Se imprimió el Rotulo de la tarima pero es necesario recepcionar o Activar la tarima!";
                            break;
                        case 2://Recepcion
                            break;
                        case 3://Desactivado
                            error = true;
                            mensaje = "Esta tarima esta desactivada!";
                            break;
                        case 4://Entregada
                            error = true;
                            mensaje = "Esta tarima ya fue entregada!";
                            break;
                        case 5://En Bodega
                            break;
                        case 6://Reproceso
                            break;
                        default://Cualquier otro caso
                            break;
                    }


                    if (!error)
                    {
                        if (tarimaEncontrada.Id_estadoCalidad > 1)
                        {
                            error = true;
                            mensaje = "La tarima no esta Disponible por parte de Calidad!";
                        }
                    }   
                    

                    if (!error)
                    {   
                        txtCantidadT.Text = string.Format("{0:###,##0.00}", tarimaEncontrada.Cantidad);
                        txtPeso.Text = string.Format("{0:###,##0.00}", tarimaEncontrada.Peso);

                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                            con.Open();
                            int result = 0;
                            SqlCommand cmd = new SqlCommand("sp_verifica_diponibilidad_tarima_entrega_pt", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", tarimaEncontrada.Id);
                            cmd.Parameters.AddWithValue("@id_despacho", N_Documento);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                result = Convert.ToInt32(dr.GetValue(0));
                                Error = dr.GetString(1);
                            }
                            //disponible = Convert.ToBoolean(cmd.ExecuteScalar());
                            if (result == 1)
                            {
                                disponible = true;
                            }
                            else
                            {
                                disponible = false;
                            }
                            dr.Close();
                            con.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }


                        if (!disponible)
                        {
                            error = true;
                            mensaje = Error;
                        }

                        //if (!error)//Si error sigue en false evaluaremos la ubicacion.
                        //{
                        //    Ubicacion_Tarima ub1 = new Ubicacion_Tarima();
                        //    if (ub1.RecuperarRegistro(tarimaEncontrada.Id, ""))
                        //    {
                        //        if (ub1.IdBodega != 10)
                        //        {
                        //            error = true;
                        //            mensaje = "La tarima no esta en la bodega de Producto Terminado, no se puede entregar!";
                        //        }
                        //    }
                        //    else
                        //    {
                        //        error = true;
                        //        mensaje = "La tarima no tiene una ubicacion valida, aun esta en proceso de colocacion!";
                        //    }
                        //}
                    }
                }
                else
                {
                    error = true;
                    mensaje = "El codigo de barra leido no es correcto!";
                }

                if (error)
                {
                    lblMensaje.Text = mensaje;
                    lblMensaje.ForeColor = Color.White;
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }
                frm_seleccionUD frm = new frm_seleccionUD(Convert.ToDecimal(txtCantidadT.Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        con.Open();
                        int Final = 0;
                        SqlCommand cmd = new SqlCommand("sp_set_insert_salida_tarima_pt_v4", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idtarima", tarimaEncontrada.Id);
                        cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@unidades", frm.Ud);
                        cmd.Parameters.AddWithValue("@id_despacho_h", N_Documento);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Guardo = dr.GetInt32(0);
                            Final = dr.GetInt32(1);
                        }
                        if (Final == 1)
                        {
                            Clear();
                        }
                        dr.Close();
                        con.Close();
                        
                    }
                    catch (Exception ec)
                    {
                        //CajaDialogo.Error(ec.Message);
                        lblMensaje.Text = ec.Message;
                        lblMensaje.ForeColor = Color.White;
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                    }

                    if (Guardo == 1)
                    {
                        //Mensaje de transaccion exitosa
                        lblMensaje.Text = "Transacción Exitosa!";
                        LoadDetalleDespachoStatus(N_Documento);
                        panelNotificacion.BackColor = Color.MediumSeaGreen;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                    }
                }

            }
            else
            {
                lblMensaje.Text = "No se encontro el registro de la tarima!";
                panelNotificacion.BackColor = Color.Red;
                lblMensaje.ForeColor = Color.White;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
            }

        }

        public void Clear() 
        {
            ds_despachos.info_despacho.Clear();
            txtDocumento.Text = "";
            ds_despachos.producto_carga.Clear();
            load_andenes();


        }

        /// <summary>
        /// Recibe el parametro de Id Despacho (int)
        /// </summary>
        /// <param name="p_id_h"></param>
        void LoadDetalleDespachoStatus(int p_id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_despacho_status", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", p_id_h);

                dsTransaccionesDespacho1.despacho_estado_detalle.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesDespacho1.despacho_estado_detalle);
                con.Close();

                //Quitar el focus a la row por default
                FocusRowInGrid();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void FocusRowInGrid()
        {
            var gridView = (GridView)gridControl1.FocusedView;
            gridView.ClearSelection();
            gridView1.UnselectRow(1);
        }

        private void chEnable_Tick(object sender, EventArgs e)
        {
            try
            {
                int cambio = 0;
                string query = @"sp_look_if_we_have_changes_in_conf_anden";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cambio = dr.GetInt32(0);
                }
                dr.Close();
                cn.Close();

                if (cambio > 0)
                {
                    load_andenes();


                    query = @"sp_update_set_bit_cambio";
                    cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    cn.Open();
                    cmd = new SqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();


                    foreach (ds_despachos.AndenesRow row in ds_despachos.Andenes.Rows)
                    {
                        if (row.id == id_selected)
                        {
                            row.selected = true;
                            row.AcceptChanges();
                            break;
                        }
                    }
                }
                


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }
         public void seleccionar_Anden(int Id_anden) 
        {
            id_selected = Id_anden;
            foreach (ds_despachos.AndenesRow row in ds_despachos.Andenes.Rows)
            {
                switch (row.id)
                {

                    case 1:
                        Anden1.Visible = true;
                        if (row.bit_orden)
                        {
                            Anden1.Enabled = true;
                            Anden1.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                            if (id_selected == row.id)
                            {

                                Anden1.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                N_Documento = row.id_req;
                                txtDocumento.Text = row.id_req.ToString();
                            }

                        }
                        else
                        {
                            Anden1.Enabled = false;
                            Anden1.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                        }
                        break;
                    case 2:
                        Anden2.Visible = true;
                        if (row.bit_orden)
                        {
                            Anden2.Enabled = true;
                            Anden2.Appearance.BackColor = Color.FromArgb(255, 255, 255);

                            if (id_selected == row.id)
                            {

                                Anden2.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                N_Documento = row.id_req;
                                txtDocumento.Text = row.id_req.ToString();
                            }
                        }
                        else
                        {
                            Anden2.Enabled = false;
                            Anden2.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                        }
                        break;
                    case 3:
                        Anden3.Visible = true;
                        if (row.bit_orden)
                        {
                            Anden3.Enabled = true;
                            Anden3.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                            if (id_selected == row.id)
                            {

                                Anden3.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                N_Documento = row.id_req;
                                txtDocumento.Text = row.id_req.ToString();
                            }
                        }
                        else
                        {
                            Anden3.Enabled = false;
                            Anden3.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                        }
                        break;
                    case 4:
                        Anden4.Visible = true;
                        if (row.bit_orden)
                        {
                            Anden4.Enabled = true;
                            Anden4.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                            if (id_selected == row.id)
                            {

                                Anden4.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                N_Documento = row.id_req;
                                txtDocumento.Text = row.id_req.ToString();
                            }
                        }
                        else
                        {
                            Anden4.Enabled = false;
                            Anden4.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                        }
                        break;
                    case 5:
                        Anden5.Visible = true;
                        if (row.bit_orden)
                        {
                            Anden5.Enabled = true;
                            Anden5.Appearance.BackColor = Color.FromArgb(255, 255, 255);

                            if (id_selected == row.id)
                            {

                                Anden5.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                N_Documento = row.id_req;
                                txtDocumento.Text = row.id_req.ToString();
                            }
                        }
                        else
                        {
                            Anden5.Enabled = false;
                            Anden5.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                        }
                        break;
                    case 6:
                        Anden6.Visible = true;
                        if (row.bit_orden)
                        {
                            Anden6.Enabled = true;
                            Anden6.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                            if (id_selected == row.id)
                            {

                                Anden6.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                                N_Documento = row.id_req;
                                txtDocumento.Text = row.id_req.ToString();
                            }
                        }
                        else
                        {
                            Anden6.Enabled = false;
                            Anden6.Appearance.BackColor = Color.FromArgb(172, 172, 172);
                            N_Documento = row.id_req;
                            txtDocumento.Text = row.id_req.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            load_datar();
            load_filas();
            if (N_Documento > 0)
                LoadDetalleDespachoStatus(N_Documento);
        }

        public void load_filas()
        {
            string query = @"sp_load_tarimas_to_orden_despacho";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", N_Documento);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.producto_carga.Clear();
                da.Fill(ds_despachos.producto_carga);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void Anden1_Click(object sender, EventArgs e)
        {
            seleccionar_Anden(1);
            beTarima.Focus();


        }

        private void Anden2_Click(object sender, EventArgs e)
        {
            seleccionar_Anden(2);
            beTarima.Focus();
        }

        private void Anden3_Click(object sender, EventArgs e)
        {
            seleccionar_Anden(3);
            beTarima.Focus();
        }

        private void Anden4_Click(object sender, EventArgs e)
        {
            seleccionar_Anden(4);
            beTarima.Focus();
        }

        private void Anden5_Click(object sender, EventArgs e)
        {
            seleccionar_Anden(5);
            beTarima.Focus();
        }

        private void Anden6_Click(object sender, EventArgs e)
        {
            seleccionar_Anden(6);
            beTarima.Focus();
        }

        private void Anden7_Click(object sender, EventArgs e)
        {
            seleccionar_Anden(7);
            beTarima.Focus();
        }

        private void beTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EntregarTarima();
            }
        }

        private void timerLimpiarMensaje_Tick_1(object sender, EventArgs e)
        {

            load_data();
            load_filas();
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            txtCantidadT.Text = txtPeso.Text = "0";
            beTarima.Text = "";
            gcTarima.DataSource = null;
            lblMensaje.Text = "";
            beTarima.Focus();
        }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                decimal pendiente = Convert.ToDecimal(View.GetRowCellDisplayText(e.RowHandle, View.Columns["Pendiente"]));

                if (pendiente <= 0)
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    
                }
                else
                {
                    e.Appearance.BackColor = Color.White;
                }
                //switch (Estado)
                //{
                //    case "10":
                //        e.Appearance.BackColor = Color.FromArgb(158, 219, 149);
                //        break;
                //    case "20":
                //        e.Appearance.BackColor = Color.FromArgb(255, 223, 102);
                //        break;
                //    case "30":
                //        e.Appearance.BackColor = Color.FromArgb(169, 148, 129);
                //        break;
                //    case "40":
                //        e.Appearance.BackColor = Color.FromArgb(88, 69, 54);
                //        break;
                //    case "50":
                //        e.Appearance.BackColor = Color.FromArgb(255, 223, 102);
                //        break;
                //    case "70":
                //        e.Appearance.BackColor = Color.FromArgb(158, 158, 158);
                //        break;
                //    default:
                //        break;
                //}
            }
        }
    }
     
}