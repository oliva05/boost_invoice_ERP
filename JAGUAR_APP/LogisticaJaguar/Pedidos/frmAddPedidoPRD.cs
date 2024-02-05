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

namespace JAGUAR_APP.LogisticaJaguar.Pedidos
{
    public partial class frmAddPedidoPRD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        PedidoH ped1;
        int IdPedidoH;
        public enum TipoTransaccion
        {
            Insert  = 1,
            Update = 2
        }

        TipoTransaccion TipoTransaccionActual;
        public frmAddPedidoPRD(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            dp = new DataOperations();
            TipoTransaccionActual = TipoTransaccion.Insert;
            ped1 = new PedidoH();
            //txtNumeroPedido.Text = GetNextNumPedidoJaguar();
            txtNumeroPedido.Text = GetNextNumPedidoTMP_Jaguar();
            txtEstado.Text = "Nuevo";
            txtEstado.ReadOnly = true;
            txtNumeroPedido.ReadOnly = true;
            dtFechaPedido.EditValue = dp.NowSetDateTime();
            LoadMasterProductoPT();
            LoadPresentacionPT();
            ObtenerClientes();
            lblPedidoRotuloHeader.Text = "Nuevo Pedido";
        }

        public frmAddPedidoPRD(UserLogin pUsuarioLogeado, int pIdH)
        {
            InitializeComponent();
            ped1 = new PedidoH();
            IdPedidoH = pIdH;
            lblPedidoRotuloHeader.Text = "Modificar Pedido";
            UsuarioLogeado = pUsuarioLogeado;
            dp = new DataOperations();
            TipoTransaccionActual = TipoTransaccion.Update;
            LoadMasterProductoPT();
            //LoadPresentacionPT();
            //ObtenerClientes();

            //PedidoH ped1 = new PedidoH();
            
            if (ped1.RecuperarRegistro(pIdH))
            {
                txtNumeroPedido.Text = ped1.DocNum;
                txtEstado.Text = ped1.EstadoName;
                txtEstado.ReadOnly = true;
                txtNumeroPedido.ReadOnly = true;
                dtFechaPedido.EditValue = ped1.Fecha;
                memoEditComentario.EditValue = ped1.Comentario;
                slueCliente.EditValueChanged -= new EventHandler(slueCliente_EditValueChanged);
                slueCliente.EditValue = ped1.ClienteID;
                slueCliente.EditValueChanged += new EventHandler(slueCliente_EditValueChanged);

                LoadDetalle(ped1.id);
            }
        }

        private void LoadDetalle(int pidH)
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.jaguar_sp_get_detalle_pedido_lines", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pidH);
                dsPedidos_PRD1.detalle_pedido.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPedidos_PRD1.detalle_pedido);

                foreach(dsPedidos_PRD.detalle_pedidoRow row1 in dsPedidos_PRD1.detalle_pedido)
                {
                    //ProductoTerminado pt = new ProductoTerminado();
                    //if (pt.Recuperar_producto(dp.ValidateNumberInt32(row1.id_pt)))
                    //{

                    //    row1.cant_latas = (pt.CantLatasByArroba * row1.cant_arrobas);
                    //    row1.cant_a_producir = (pt.CantBolsasByLata * row1.cant_latas);
                    //    row1.cantidad = (pt.CantBolsasByLata * row1.cant_latas);
                    //}
                    foreach(dsPedidos_PRD.master_pt_listRow rowPT in dsPedidos_PRD1.master_pt_list)
                    {
                        if (row1.id_pt == rowPT.id)
                        {

                            row1.cant_latas = (rowPT.cant_latas * row1.cant_arrobas);
                            row1.cant_a_producir = (rowPT.cant_bolsas_por_lata * row1.cant_latas);
                            row1.cantidad = (rowPT.cant_bolsas_por_lata * row1.cant_latas);
                        }
                    }
                    
                }

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private string GetNextNumPedidoJaguar()
        {
            string number_ = "";
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.jaguar_sp_get_next_num_pedido", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                //dsPedidos_PRD1.lista_pedidos.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsPedidos_PRD1.lista_pedidos);
                number_ = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return number_;
        }

        private string GetNextNumPedidoTMP_Jaguar()
        {
            string number_ = "";
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[jaguar_sp_get_next_num_pedido_tmp]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                number_ = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return number_;
        }


        private void LoadPresentacionPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_get_presentacion_for_pt]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_pt", pID_PT);
                dsPedidos_PRD1.presentacion_pt.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPedidos_PRD1.presentacion_pt);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadMasterProductoPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[sp_get_master_for_pt_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_pt", pID_PT);
                dsPedidos_PRD1.master_pt_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPedidos_PRD1.master_pt_list);


                cmd = new SqlCommand("[codesahn].[sp_get_presentacion_for_pt]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_pt", pID_PT);
                dsPedidos_PRD1.presentacion_pt.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPedidos_PRD1.presentacion_pt);

                dsMantenimiento.JAGUAR_Clientes.Clear();

                SqlDataAdapter da = new SqlDataAdapter("dbo.usp_JAGUAR_LoadClientes", con);
                da.Fill(dsMantenimiento.JAGUAR_Clientes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAddLinea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(slueCliente.Text))
            {
                CajaDialogo.Error("Debe de seleccionar un cliente antes de adicionar las lineas!");
                return;
            }

            int count_lines = dsPedidos_PRD1.detalle_pedido.Rows.Count;

            dsPedidos_PRD.detalle_pedidoRow row1 = dsPedidos_PRD1.detalle_pedido.Newdetalle_pedidoRow();
            
            //row1.cantidad = 0;
            row1.num_linea = dsPedidos_PRD1.detalle_pedido.Count + 1;
            row1.id = 0;
            row1.id_pt = 0;
            row1.id_h = 0;
            row1.enable = true;
            row1.id_presentacion = 0;
            row1.presentacion_name = "";
            //row1.cant_arrobas =0;
            row1.ItemCode = "";
            row1.pt_name = "";
            //row1.cant_latas = 0;
            
            dsPedidos_PRD1.detalle_pedido.Adddetalle_pedidoRow(row1);
            dsPedidos_PRD1.AcceptChanges();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string celda = e.Column.FieldName;
            switch (celda)
            {
                case "id_pt":
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsPedidos_PRD.detalle_pedidoRow)gridView.GetDataRow(e.RowHandle);
                    ProductoTerminado pt1 = new ProductoTerminado();
                    if (pt1.Recuperar_producto(dp.ValidateNumberInt32(row.id_pt)))
                    {
                        row.ItemCode = pt1.Code;
                        row.cant_arrobas = 1;
                        //row.cant_pedido = 0;
                        row.cant_latas = pt1.CantLatasByArroba;
                        row.cantidad = pt1.CantBolsasByLata;
                        row.id_presentacion = pt1.Id_presentacion;
                        row.cant_inv = pt1.CantInventarioKardex;
                        switch (pt1.Tipo_id)
                        {
                            case 1:
                            case 2:
                                row.ud_medida_a_produccir = "Arroba(s)";
                                break;
                            case 3:
                                row.ud_medida_a_produccir = "Libra(s)";
                                break;
                        }
                    }
                    break;
                case "cant_arrobas":
                    //var gridView1 = (GridView)gridControl1.FocusedView;
                    //var row1 = (dsPedidos_PRD.detalle_pedidoRow)gridView1.GetDataRow(e.RowHandle);
                    //ProductoTerminado pt = new ProductoTerminado();
                    //if (pt.Recuperar_producto(dp.ValidateNumberInt32(row1.id_pt)))
                    //{
                    //    row1.cant_latas = (pt.CantLatasByArroba * row1.cant_arrobas);
                    //    row1.cantidad = (pt.CantBolsasByLata * row1.cant_latas);
                    //    row1.cant_inv = pt.CantInventarioKardex;
                    //    row1.id_presentacion = pt.Id_presentacion;
                    //}
                    break;
                case "cant_pedido":
                    switch (TipoTransaccionActual)
                    {
                        case TipoTransaccion.Insert:
                            if (!ped1.Recuperado)//insert
                            {
                                dp = new DataOperations();
                                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                                {
                                    connection.Open();

                                    SqlCommand command = connection.CreateCommand();
                                    //SqlTransaction transaction;

                                    // Start a local transaction.
                                    //transaction = connection.BeginTransaction("SampleTransaction");

                                    // Must assign both transaction object and connection
                                    // to Command object for a pending local transaction
                                    command.Connection = connection;
                                    //command.Transaction = transaction;
                                    command.CommandText = "[codesahn].[jaguar_sp_insert_pedido_h_v2]";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@fecha", dtFechaPedido.EditValue);
                                    command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                                    if (!dp.ValidateStringIsNullOrEmpty(memoEditComentario.Text))
                                        command.Parameters.AddWithValue("@comentario", memoEditComentario.EditValue);
                                    else
                                        command.Parameters.AddWithValue("@comentario", DBNull.Value);

                                    command.Parameters.AddWithValue("@DocNum", txtNumeroPedido.Text);
                                    command.Parameters.AddWithValue("@id_cliente", slueCliente.EditValue);

                                    int idH = dp.ValidateNumberInt32(command.ExecuteScalar());
                                    ped1.RecuperarRegistro(idH);
                                }
                            }
                            break;
                        case TipoTransaccion.Update:
                            //if (ped1.Recuperado)//update
                            //{
                            //    dp = new DataOperations();
                            //    using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                            //    {
                            //        connection.Open();

                            //        SqlCommand command = connection.CreateCommand();
                            //        command.Connection = connection;
                            //        command.CommandText = "[codesahn].[jaguar_sp_insert_pedido_h_v2]";
                            //        command.CommandType = CommandType.StoredProcedure;
                            //        command.Parameters.AddWithValue("@fecha", dtFechaPedido.EditValue);
                            //        command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                            //        if (!dp.ValidateStringIsNullOrEmpty(memoEditComentario.Text))
                            //            command.Parameters.AddWithValue("@comentario", memoEditComentario.EditValue);
                            //        else
                            //            command.Parameters.AddWithValue("@comentario", DBNull.Value);

                            //        command.Parameters.AddWithValue("@DocNum", txtNumeroPedido.Text);
                            //        command.Parameters.AddWithValue("@id_cliente", slueCliente.EditValue);

                            //        int idH = dp.ValidateNumberInt32(command.ExecuteScalar());
                            //        ped1.RecuperarRegistro(idH);
                            //    }
                            //}
                            break;
                    }

                    if (ped1.Recuperado)
                    {
                        #region codigo validando inv
                        //if (ped1.id>0)
                        //{
                        //    var gridView2 = (GridView)gridControl1.FocusedView;
                        //    var row2 = (dsPedidos_PRD.detalle_pedidoRow)gridView2.GetDataRow(e.RowHandle);
                        //    ProductoTerminado pt2 = new ProductoTerminado();
                        //    if (pt2.Recuperar_producto(dp.ValidateNumberInt32(row2.id_pt)))
                        //    {
                        //        decimal Cant_a_producir = row2.cant_pedido - row2.cant_inv;

                        //        decimal factor_Lata = 0;
                        //        if (pt2.CantBolsasByLata > 0)
                        //            factor_Lata = Cant_a_producir / pt2.CantBolsasByLata;

                        //        decimal factor_arroba = 0;
                        //        if (pt2.CantLatasByArroba > 0)
                        //            factor_arroba = factor_Lata / pt2.CantLatasByArroba;

                        //        row2.cant_arrobas = factor_arroba;
                        //        row2.cant_latas = row2.cant_arrobas * pt2.CantLatasByArroba;
                        //        row2.cantidad = factor_Lata * pt2.CantBolsasByLata;


                        //        decimal VarCantArrobas = dp.ValidateNumberDecimal(row2.cant_arrobas);
                        //        int VarIdPresentacion = dp.ValidateNumberInt32(row2.id_presentacion);
                        //        decimal VarCantPedido = dp.ValidateNumberDecimal(row2.cant_pedido);

                        //        if (VarCantArrobas > 0 && VarIdPresentacion > 0 && VarCantPedido > 0)
                        //        {
                        //            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        //            {
                        //                connection.Open();
                        //                SqlCommand command = connection.CreateCommand();
                        //                //switch (TipoTransaccionActual)
                        //                //{
                        //                //    case TipoTransaccion.Insert:
                        //                //        command.CommandText = "codesahn.jaguar_sp_insert_pedido_d";
                        //                //        break;
                        //                //    case TipoTransaccion.Update:
                        //                //        command.CommandText = "codesahn.jaguar_sp_update_pedido_d";
                        //                //        command.Parameters.AddWithValue("@id", row2.id);
                        //                //        break;
                        //                //}

                        //                if (row2.id > 0)
                        //                {
                        //                    //Update
                        //                    command.CommandText = "codesahn.jaguar_sp_update_pedido_d";
                        //                    command.Parameters.AddWithValue("@id", row2.id);
                        //                }
                        //                else
                        //                {
                        //                    //Insert
                        //                    command.CommandText = "codesahn.jaguar_sp_insert_pedido_d";
                        //                }

                        //                command.CommandType = CommandType.StoredProcedure;
                        //                command.Parameters.AddWithValue("@id_pt", row2.id_pt);
                        //                command.Parameters.AddWithValue("@cantidad", VarCantPedido);
                        //                command.Parameters.AddWithValue("@id_h", ped1.id);
                        //                command.Parameters.AddWithValue("@id_presentacion_pt", VarIdPresentacion);
                        //                command.Parameters.AddWithValue("@cant_arrobas", VarCantArrobas);
                        //                //command.ExecuteNonQuery();


                        //                if (row2.id <= 0)
                        //                {
                        //                    //Update
                        //                    row2.id = Convert.ToInt32(command.ExecuteScalar());
                        //                }
                        //                else
                        //                {
                        //                    command.ExecuteNonQuery();
                        //                }

                        //            }
                        //        }
                        //    }
                        //}//End if ped.id >0
                        #endregion
                        if (ped1.id > 0)
                        {
                            var gridView2 = (GridView)gridControl1.FocusedView;
                            var row2 = (dsPedidos_PRD.detalle_pedidoRow)gridView2.GetDataRow(e.RowHandle);
                            ProductoTerminado pt2 = new ProductoTerminado();
                            if (pt2.Recuperar_producto(dp.ValidateNumberInt32(row2.id_pt)))
                            {
                                //decimal Cant_a_producir = row2.cant_pedido - row2.cant_inv;
                                decimal Cant_a_producir = row2.cant_pedido;

                                decimal factor_Lata = 0;
                                if (pt2.CantBolsasByLata > 0)
                                    factor_Lata = Cant_a_producir / pt2.CantBolsasByLata;

                                decimal factor_arroba = 0;
                                if (pt2.CantLatasByArroba > 0)
                                    factor_arroba = factor_Lata / pt2.CantLatasByArroba;

                                row2.cant_arrobas = factor_arroba;
                                row2.cant_latas = row2.cant_arrobas * pt2.CantLatasByArroba;
                                row2.cantidad = factor_Lata * pt2.CantBolsasByLata;


                                decimal VarCantArrobas = dp.ValidateNumberDecimal(row2.cant_arrobas);
                                int VarIdPresentacion = dp.ValidateNumberInt32(row2.id_presentacion);
                                decimal VarCantPedido = dp.ValidateNumberDecimal(row2.cant_pedido);

                                if (VarCantArrobas > 0 && VarIdPresentacion > 0 && VarCantPedido > 0)
                                {
                                    using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                                    {
                                        connection.Open();
                                        SqlCommand command = connection.CreateCommand();

                                        if (row2.id > 0)
                                        {
                                            //Update
                                            command.CommandText = "codesahn.jaguar_sp_update_pedido_d";
                                            command.Parameters.AddWithValue("@id", row2.id);
                                        }
                                        else
                                        {
                                            //Insert
                                            command.CommandText = "codesahn.jaguar_sp_insert_pedido_d";
                                        }

                                        command.CommandType = CommandType.StoredProcedure;
                                        command.Parameters.AddWithValue("@id_pt", row2.id_pt);
                                        command.Parameters.AddWithValue("@cantidad", VarCantPedido);
                                        command.Parameters.AddWithValue("@id_h", ped1.id);
                                        command.Parameters.AddWithValue("@id_presentacion_pt", VarIdPresentacion);
                                        command.Parameters.AddWithValue("@cant_arrobas", VarCantArrobas);
                                        //command.ExecuteNonQuery();

                                        if (row2.id <= 0)
                                        {
                                            //Update
                                            row2.id = Convert.ToInt32(command.ExecuteScalar());
                                        }
                                        else
                                        {
                                            command.ExecuteNonQuery();
                                        }

                                    }
                                }
                            }
                        }//End if ped.id >0
                    }



                    break;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            bool error = false;
            //Validar cantidad de pedido mayor a cero en cada linea
            foreach (dsPedidos_PRD.detalle_pedidoRow row in dsPedidos_PRD1.detalle_pedido.Rows)
            {
                if (row.cant_pedido <= 0)
                {
                    error = true;
                    break;
                }
            }
            if (error)//Significa que esta enviando pedido menor o igual a cero
            {
                CajaDialogo.Error("La cantidad de pedido debe ser mayor a cero!");
                return;
            }

            if (string.IsNullOrEmpty( slueCliente.Text))
            {
                CajaDialogo.Error("Debe de seleccionar un cliente");
                return;
            }

            //Validar seleccion de pt completa
            error = false;
            foreach (dsPedidos_PRD.detalle_pedidoRow row in dsPedidos_PRD1.detalle_pedido.Rows)
            {
                if (row.id_pt == 0)
                {
                    error = true;
                    break;
                }
            }
            if (error)//Significa que esta enviando a guardar el detalle sin seleccionar un producto terminado valido.
            {
                CajaDialogo.Error("Es neecesario especificar el producto terminado!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de guardar este detalle de pedido?");
            if (r != DialogResult.Yes)
                return;

            //Guardar Header y Detalle del pedido.
            dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    switch (TipoTransaccionActual)
                    {
                        case TipoTransaccion.Insert:
                            command.CommandText = "codesahn.jaguar_sp_insert_pedido_h";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@fecha", dtFechaPedido.EditValue);
                            command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                            if (!dp.ValidateStringIsNullOrEmpty(memoEditComentario.Text))
                                command.Parameters.AddWithValue("@comentario", memoEditComentario.EditValue);
                            else
                                command.Parameters.AddWithValue("@comentario", DBNull.Value);

                            command.Parameters.AddWithValue("@DocNum", txtNumeroPedido.Text);
                            command.Parameters.AddWithValue("@id_cliente", slueCliente.EditValue);

                            int idH = dp.ValidateNumberInt32(command.ExecuteScalar());

                            command.CommandText = "codesahn.jaguar_sp_insert_pedido_d";
                            command.CommandType = CommandType.StoredProcedure;

                            foreach (dsPedidos_PRD.detalle_pedidoRow row in dsPedidos_PRD1.detalle_pedido.Rows)
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_pt", row.id_pt);
                                command.Parameters.AddWithValue("@cantidad", row.cant_pedido);
                                command.Parameters.AddWithValue("@id_h", idH);
                                command.Parameters.AddWithValue("@id_presentacion_pt", row.id_presentacion);
                                command.Parameters.AddWithValue("@cant_arrobas", row.cant_arrobas);
                                command.ExecuteNonQuery();
                            }
                            break;
                        case TipoTransaccion.Update:
                            command.CommandText = "[codesahn].[jaguar_sp_update_pedido_h]";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@fecha", dtFechaPedido.EditValue);
                            command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                            if (!dp.ValidateStringIsNullOrEmpty(memoEditComentario.Text))
                                command.Parameters.AddWithValue("@comentario", memoEditComentario.EditValue);
                            else
                                command.Parameters.AddWithValue("@comentario", DBNull.Value);

                            command.Parameters.AddWithValue("@DocNum", txtNumeroPedido.Text);
                            command.Parameters.AddWithValue("@id_h", IdPedidoH);
                            command.Parameters.AddWithValue("@id_cliente", slueCliente.EditValue);
                            command.ExecuteScalar();



                            command.CommandText = "[codesahn].[jaguar_sp_update_pedido_d]";
                            command.CommandType = CommandType.StoredProcedure;

                            foreach (dsPedidos_PRD.detalle_pedidoRow row in dsPedidos_PRD1.detalle_pedido.Rows)
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_pt", row.id_pt);
                                command.Parameters.AddWithValue("@cantidad", row.cant_pedido);
                                command.Parameters.AddWithValue("@id_h", IdPedidoH);
                                command.Parameters.AddWithValue("@id_presentacion_pt", row.id_presentacion);
                                command.Parameters.AddWithValue("@cant_arrobas", row.cant_arrobas);
                                command.Parameters.AddWithValue("@id", row.id);
                                command.ExecuteNonQuery();
                            }
                            break;
                        default:
                            break;
                    }
                    

                    //command.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Description')";
                    //command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        CajaDialogo.Error(ex2.Message);
                    }
                }
            }





        }//Bloque de opcion de guardar

        private void ObtenerClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.JAGUAR_Clientes.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_JAGUAR_LoadClientes", cnx);
                    da.Fill(dsMantenimiento.JAGUAR_Clientes);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void memoEditComentario_EditValueChanged(object sender, EventArgs e)
        {
            updatePedidoH();
        }

        private void updatePedidoH()
        {
            if (ped1.Recuperado)
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    //SqlTransaction transaction;
                    command.CommandText = "[codesahn].[jaguar_sp_update_pedido_h_v2]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fecha", dtFechaPedido.EditValue);
                    command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    if (!dp.ValidateStringIsNullOrEmpty(memoEditComentario.Text))
                        command.Parameters.AddWithValue("@comentario", memoEditComentario.EditValue);
                    else
                        command.Parameters.AddWithValue("@comentario", DBNull.Value);

                    command.Parameters.AddWithValue("@DocNum", txtNumeroPedido.Text);
                    command.Parameters.AddWithValue("@id_h", ped1.id);
                    command.Parameters.AddWithValue("@id_cliente", slueCliente.EditValue);
                    command.ExecuteScalar();
                }
            }
        }

        private void slueCliente_EditValueChanged(object sender, EventArgs e)
        {
            updatePedidoH();
        }

        private void memoEditComentario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                updatePedidoH();
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdEliminarRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsPedidos_PRD.detalle_pedidoRow)gridView1.GetFocusedDataRow();

            try
            {
                
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_update_linea_pedido_prd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_detalle", row.id);
                cmd.ExecuteNonQuery();
                con.Close();

                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}