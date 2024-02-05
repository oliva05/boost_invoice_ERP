using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Formulas;
using JAGUAR_APP.LogisticaJaguar.Pedidos;
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
    public partial class frmAddOrderProductionV2 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        ProductoTerminado ProductoTerminadoActual;
        FormulaH FormulaActual;
        DataOperations dp;

        public frmAddOrderProductionV2(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            dp = new DataOperations();
            ProductoTerminadoActual = new ProductoTerminado();
            UsuarioLogeado = pUsuarioLogeado;
            LoadProductosTerminados();
            //dtDesde.EditValue = dp.Now();
            //dtHasta.EditValue = dp.Now().AddDays(1);
            dtDesde.EditValue = DateTime.Now;
            dtHasta.EditValue = DateTime.Now.AddDays(1);
            LoadDatosPedidosHeaderList();
            
        }

        private void LoadDatosPedidosHeaderList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[jaguar_sp_get_lista_pedidos_h_consolidado]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsPedidosPRD1.lista_pedidos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPedidosPRD1.lista_pedidos);

                //if(dsPedidosPRD1.lista_pedidos.Count>0)
                //    LoadDetalleConsolidadoPedidos();
                if (dsPedidosPRD1.lista_pedidos.Count > 0)
                {
                    cmd = new SqlCommand("[codesahn].[jaguar_sp_get_detalle_pedido_lines_consolidado]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                    cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                    dsPedidosPRD1.detalle_pedido.Clear();
                    adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsPedidosPRD1.detalle_pedido);

                    foreach (dsPedidosPRD.detalle_pedidoRow row1 in dsPedidosPRD1.detalle_pedido)
                    {
                        //ProductoTerminado pt = new ProductoTerminado();
                        //if (pt.Recuperar_producto(dp.ValidateNumberInt32(row1.id_pt)))
                        //{
                        //    row1.cant_latas = (pt.CantLatasByArroba * row1.cant_arrobas);
                        //    row1.cant_a_producir = (pt.CantBolsasByLata * row1.cant_latas);
                        //    row1.cantidad = (pt.CantBolsasByLata * row1.cant_latas);
                        //    //row1.cant_inv = pt.CantInventarioKardex;
                        //    //row1.id_presentacion = pt.Id_presentacion;
                        //}


                        row1.cant_latas = (row1.conf_cant_latas_por_arroba * row1.cant_arrobas);
                        row1.cant_a_producir = (row1.conf_cant_bolsas_por_lata * row1.cant_latas);
                        row1.cantidad = (row1.conf_cant_bolsas_por_lata * row1.cant_latas);
                        switch (row1.tipo_id)
                        {
                            case 1:
                            case 2:
                                row1.ud_medida_a_produccir = "Arroba(s)";
                                break;
                            case 3:
                                row1.ud_medida_a_produccir = "Libra(s)";
                                break;
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



        private void LoadDetalleConsolidadoPedidos()
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[codesahn].[jaguar_sp_get_detalle_pedido_lines_consolidado]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsPedidosPRD1.detalle_pedido.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPedidosPRD1.detalle_pedido);

                foreach (dsPedidosPRD.detalle_pedidoRow row1 in dsPedidosPRD1.detalle_pedido)
                {
                    ProductoTerminado pt = new ProductoTerminado();
                    if (pt.Recuperar_producto(dp.ValidateNumberInt32(row1.id_pt)))
                    {

                        row1.cant_latas = (pt.CantLatasByArroba * row1.cant_arrobas);
                        row1.cant_a_producir = (pt.CantBolsasByLata * row1.cant_latas);
                        row1.cantidad = (pt.CantBolsasByLata * row1.cant_latas);
                        //row1.cant_inv = pt.CantInventarioKardex;
                        //row1.id_presentacion = pt.Id_presentacion;
                    }
                }

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
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

                SqlCommand cmd = new SqlCommand("codesahn.sp_jaguar_get_lista_productos_terminados", con);
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

            //frmFormulasJaguarSelectionMode frm = new frmFormulasJaguarSelectionMode(this.UsuarioLogeado,
            //                                                                        dp.ValidateNumberInt32(gridLookUpEditProductoTerminado.EditValue));
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    //Explosionar Formula
            //    txtRecetaName.Text = frm.FormulaActual.codigo + " / " + frm.FormulaActual.nombre;
            //    FormulaActual = frm.FormulaActual;
            //}
        }//SearchReceta()

        private void gridLookUpEditProductoTerminado_EditValueChanged(object sender, EventArgs e)
        {
            //int idPT = dp.ValidateNumberInt32(gridLookUpEditProductoTerminado.EditValue);
            ////int valor_res = CargarRecetaId_Auto(idPT);
            //this.ProductoTerminadoActual = new ProductoTerminado();
            //this.ProductoTerminadoActual.Recuperar_producto(idPT);
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

                SqlCommand cmd = new SqlCommand("jaguar_sp_get_detalle_formula_segun_arroba", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", this.ProductoTerminadoActual.Id);
                //cmd.Parameters.AddWithValue("@cant_arroba", spinEditCantArrobas.EditValue);
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

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            dsProduccion1.Distribucion_ordenes_panaderos.Clear();
            LoadDatosPedidosHeaderList();
            //LoadDetalleConsolidadoPedidos();
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string celda = e.Column.FieldName;
            switch (celda)
            {
                case "cant_arrobas":
                    var gridView1 = (GridView)gridControl2.FocusedView;
                    var row1 = (dsPedidosPRD.detalle_pedidoRow)gridView1.GetDataRow(e.RowHandle);
                    ProductoTerminado pt = new ProductoTerminado();
                    if (pt.Recuperar_producto(dp.ValidateNumberInt32(row1.id_pt)))
                    {
                        row1.cant_latas = (pt.CantLatasByArroba * row1.cant_arrobas);
                        row1.cantidad = (pt.CantBolsasByLata * row1.cant_latas);
                    }
                    break;
            }
        }

        private void cmdAsignarArrobas_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)gridControl2.FocusedView;
            var row = (dsPedidosPRD.detalle_pedidoRow)gridView1.GetFocusedDataRow();
            row.cant_arrobas_asignadas = 0;
            dsPedidosPRD1.AcceptChanges();

            frmAsignarArrobasPanadero frm = new frmAsignarArrobasPanadero(row.id_pt, row.pt_name, row.presentacion_name, row.cant_arrobas);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Cantidad de arrobas asignadas.
                
                int cuenta_asignaciones = 0;
                foreach (Panadero pan in frm.ListaPanaderosAsignados)
                {
                    //Es el primer registro a distribuir
                    if (dsProduccion1.Distribucion_ordenes_panaderos.Rows.Count == 0)
                    {
                        
                        dsProduccion.Distribucion_ordenes_panaderosRow rowNew = dsProduccion1.Distribucion_ordenes_panaderos.NewDistribucion_ordenes_panaderosRow();
                        rowNew.id_pt = row.id_pt;
                        rowNew.nombre_pt = row.pt_name;
                        rowNew.id_presentacion = row.id_presentacion;
                        rowNew.presentacion_name = row.presentacion_name;
                        rowNew.id_panadero = pan.idPanadero;
                        rowNew.panadero_name = pan.NamePanadero;
                        rowNew.cantidad_arrobas = pan.CantAsignada;
                        dsProduccion1.Distribucion_ordenes_panaderos.AddDistribucion_ordenes_panaderosRow(rowNew);
                        cuenta_asignaciones++;
                    }
                    else
                    {
                        if (cuenta_asignaciones == 0)
                        {
                            int TotalRowsAsignaciones = dsProduccion1.Distribucion_ordenes_panaderos.Count;
                            //Eliminamos los registros previos para hacer la nueva distribucion.
                            for (int i = 0; i <= (TotalRowsAsignaciones - 1); i++)
                            {
                                //var gridViewDelete = (GridView)gridControl1.Views[0];
                                var rowPana = (dsProduccion.Distribucion_ordenes_panaderosRow)dsProduccion1.Distribucion_ordenes_panaderos[i];

                                if (rowPana != null)
                                {
                                    if (row.id_pt == rowPana.id_pt)
                                    {
                                        dsProduccion1.Distribucion_ordenes_panaderos.RemoveDistribucion_ordenes_panaderosRow(rowPana);
                                        dsProduccion1.AcceptChanges();
                                        TotalRowsAsignaciones--;
                                        i--;

                                        //Hemos revisado todos los rows, rompemos el ciclo.
                                        if (TotalRowsAsignaciones == 0)
                                            i = 1;
                                    }
                                }
                                
                            }
                        }

                        dsProduccion.Distribucion_ordenes_panaderosRow rowNew = dsProduccion1.Distribucion_ordenes_panaderos.NewDistribucion_ordenes_panaderosRow();
                        rowNew.id_pt = row.id_pt;
                        rowNew.nombre_pt = row.pt_name;
                        rowNew.id_presentacion = row.id_presentacion;
                        rowNew.presentacion_name = row.presentacion_name;
                        rowNew.id_panadero = pan.idPanadero;
                        rowNew.panadero_name = pan.NamePanadero;
                        rowNew.cantidad_arrobas = pan.CantAsignada;
                        //row.cant_arrobas = frm.Res_CantArrobas;
                        //row.cant_arrobas_asignadas = pan.CantAsignada;
                        //dsPedidosPRD1.AcceptChanges();

                        dsProduccion1.Distribucion_ordenes_panaderos.AddDistribucion_ordenes_panaderosRow(rowNew);
                        cuenta_asignaciones++;
                    }
                }


                //Recalcular el total de arrobas asignadas
                foreach(dsPedidosPRD.detalle_pedidoRow rowPedido in dsPedidosPRD1.detalle_pedido)
                {
                    decimal cantidad_asignar_tmp = 0;
                    foreach (dsProduccion.Distribucion_ordenes_panaderosRow rowPanaderos in dsProduccion1.Distribucion_ordenes_panaderos)
                    {
                        if (row.id_pt == rowPanaderos.id_pt)
                        {
                            cantidad_asignar_tmp = rowPanaderos.cantidad_arrobas;
                            if (rowPedido.id_pt == row.id_pt)
                                rowPedido.cant_arrobas_asignadas += cantidad_asignar_tmp;
                        }
                    }
                    //if(rowPedido.id_pt == row.id_pt)
                    //    rowPedido.cant_arrobas_asignadas += cantidad_asignar_tmp;
                }
                

                dsProduccion1.Distribucion_ordenes_panaderos.AcceptChanges();
            }
        }//Boton asignar arrobas

        private void cmdVerPage2_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = navigationPage2;
        }

        private void cmdVerPage1_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = navigationPage1;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if(dsProduccion1.Distribucion_ordenes_panaderos.Count <= 0)
            {
                CajaDialogo.Error("Es necesario asignar las Ordenes de Fabricación a panaderos antes de poder continuar!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Confirme que desea generar esta(s) orden(es) de fabricacion?");
            if (r != DialogResult.Yes)
                return;

            lblCompletado.Visible = progressBarControl1.Visible = true;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = dsProduccion1.Distribucion_ordenes_panaderos.Count;
            progressBarControl1.Properties.Minimum = 0;

            DataOperations dp = new DataOperations();
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
                    foreach(dsProduccion.Distribucion_ordenes_panaderosRow row in dsProduccion1.Distribucion_ordenes_panaderos)
                    {
                        //Insert Header
                        command.CommandText = "jaguar_sp_insert_header_orden_fabricacion_h";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@fecha", dp.NowSetDateTime());
                        command.Parameters.AddWithValue("@id_pt", row.id_pt);
                        command.Parameters.AddWithValue("@cant_arrobas",row.cantidad_arrobas);
                        command.Parameters.AddWithValue("@id_grupo_panaderos", row.id_panadero);
                        command.Parameters.AddWithValue("@id_user",this.UsuarioLogeado.Id);
                        ProductoTerminado prd1 = new ProductoTerminado();
                        if (prd1.Recuperar_producto(row.id_pt))
                        {
                            command.Parameters.AddWithValue("@cant_latas", (prd1.CantLatasByArroba * row.cantidad_arrobas));
                            command.Parameters.AddWithValue("@cant_bolsas", (prd1.CantBolsasByLata * (prd1.CantLatasByArroba * row.cantidad_arrobas)));
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@cant_latas", DBNull.Value);
                            command.Parameters.AddWithValue("@cant_bolsas", DBNull.Value);
                        }

                        Int64 id_h = Convert.ToInt64(command.ExecuteScalar());

                        //Insert Detalle
                        command.CommandText = "jaguar_sp_insert_detalle_orden_fabricacion_pan";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id_h", id_h);
                        command.Parameters.AddWithValue("@id_pt", row.id_pt);
                        command.Parameters.AddWithValue("@cant_arroba", row.cantidad_arrobas);
                        command.ExecuteNonQuery();

                        //Update Pedidos H
                        foreach(dsPedidosPRD.lista_pedidosRow rowx in dsPedidosPRD1.lista_pedidos)
                        {
                            if (rowx.id_estado == 4)
                            {
                                command.CommandText = "[codesahn].[jaguar_sp_set_lista_pedidos_h_consolidado_estado_change]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_pedido_h", rowx.id);
                                command.ExecuteNonQuery();

                                rowx.id_estado = 2;
                                rowx.estado_name = "Completed";
                            }
                        }
                        progressBarControl1.PerformStep();
                        progressBarControl1.Update();
                    }
                    

                    //command.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Description')";
                    //command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    CajaDialogo.InformationAuto();
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


        }

        private void btx_eliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsProduccion.Distribucion_ordenes_panaderosRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}