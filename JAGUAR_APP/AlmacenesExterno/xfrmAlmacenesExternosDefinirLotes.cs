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
using JAGUAR_APP.AlmacenesExterno.Models;
using DevExpress.XtraGrid.Views.Grid;
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using JAGUAR_APP.AlmacenesExterno.Reporteria;
using DevExpress.XtraReports.UI;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmAlmacenesExternosDefinirLotes : DevExpress.XtraEditors.XtraForm
    {
        List<Conf_MP_Ingresada> lista = new List<Conf_MP_Ingresada>();
        OrdenCompra_H oc_h = new OrdenCompra_H();
        decimal totalPeso, totalUnidades;
        UserLogin UsuarioLogueado;
        Ingreso_Externo_Lote LoteExternoVar;
        dsAlmacenesExternos dsTodas = new dsAlmacenesExternos();
        int RowSelected = 0;
        decimal TotalLineadeMP = 0;
        int LoteNumerador= 1;

        public xfrmAlmacenesExternosDefinirLotes(List<Conf_MP_Ingresada> pLista, OrdenCompra_H pOC_h,UserLogin pUser)
        {
            InitializeComponent();
            lista = pLista;
            //LoadLotes();
            oc_h = pOC_h;
            UsuarioLogueado = pUser;
            ObtenerBodegas();
        }

        private void ObtenerBodegas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsAlmacenesExternos.Warehouse.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_almacenes_externos_bodegas", cnx);
                    da.Fill(dsAlmacenesExternos.Warehouse);


                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void xfrmAlmacenesExternosDefinirLotes_Load(object sender, EventArgs e)
        {
            int Numerador = 1;
            foreach (var item in lista)
            {
                DataRow workRow = dsAlmacenesExternos.Conf_MP_Ingresadas.NewRow();
                workRow[0] = item.ItemCode;
                workRow[1] = item.CantIngresada;
                workRow[2] = item.Descripcion;
                workRow[3] = item.UnidadesIngresadas;
                //workRow[4] = ;
                workRow[5] = item.LineNum;
                workRow[6] = item.MPID;
                workRow[8] = item.bodega;
                workRow[9] = item.id_presentacion;
                workRow["row"] = Numerador;
                Numerador++;
                dsAlmacenesExternos.Conf_MP_Ingresadas.Rows.Add(workRow);

                totalPeso = totalPeso + item.CantIngresada;
                totalUnidades = totalUnidades + item.UnidadesIngresadas;
            }

        }

        List<Ingreso_Externo_Lote> lotes = new List<Ingreso_Externo_Lote>();
        private void simpleButton3_Click(object sender, EventArgs e)
        {

            if (RowSelected == 0)
            {
                CajaDialogo.Error("Debe seleccionar una Materia prima para empezar a configurar los lotes.");
                return;
            }

            decimal Ingresado = 0;
            foreach (var items in dsAlmacenesExternos.Lote)
            {
                Ingresado = Ingresado + items.cantidad;
            }


            if (Ingresado == TotalLineadeMP)
            {
                CajaDialogo.Error("No se puede agregar mas lotes por que la cantidad configurada sobrepasa el limite seleccionado.");
                return;
            }

            xfrmLoteCRUD frm = new xfrmLoteCRUD();

            var gvConfMP = (GridView)gcIngreso.FocusedView;
            //var row = (dsAlmacenesExternos.Conf_MP_IngresadasRow)gvConfMP.GetDataRow(gvConfMP.FocusedRowHandle);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoteExternoVar = frm.lote;
                frm.lote.Row_ = lotes.Count + 1;
                lotes.Add(frm.lote);
                int counterRows = 1;

                var lotesDisponibles = lotes.Where(x => x.NumLine == -1);

                 Ingresado = 0;
                foreach (var items in dsAlmacenesExternos.Lote)
                {
                    Ingresado = Ingresado + items.cantidad;
                }

                Ingresado = Ingresado + frm.lote.Cantidad;

                if (Ingresado > TotalLineadeMP)
                {
                    CajaDialogo.Error("No se puede seleccionar este lote por que la cantidad selecionada en los lotes supera la cantidad selecionada por MP.");
                    return;
                }


                DataRow workRow = dsAlmacenesExternos.Lote.NewRow();
                DataRow workRowad = dsTodas.Lote.NewRow();

                workRow[0] = workRowad[0] =  frm.lote.ID;
                workRow[1] = workRowad[1] = frm.lote.Cantidad;
                workRow[2] = workRowad[2] = frm.lote.Unidades;
                workRow[3] = workRowad[3] = 0;
                workRow[4] = workRowad[4] = frm.lote.Lote;
                workRow[7] = workRowad[7] = frm.lote.NumLine;
                workRow[8] = workRowad[8] = frm.lote.Row_;
                workRow["fecha_vencimiento"] = workRowad["fecha_vencimiento"] = frm.lote.FechaVencimiento;
                workRow["fecha_produccion"] = workRowad["fecha_produccion"] = frm.lote.FechaProduccion; 
                workRow["id_pertenece"] = workRowad["id_pertenece"] = RowSelected;
                workRow["LoteNumerador"] = workRowad["LoteNumerador"] = LoteNumerador;
                LoteNumerador++;                // Update de cambio de las listas...
                counterRows++; // no se que hace.

                dsAlmacenesExternos.Lote.Rows.Add(workRow);
                dsTodas.Lote.Rows.Add(workRowad);
            }
        }




        private void gvLote_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gv = (GridView)gcLote.FocusedView;
            var row = (dsAlmacenesExternos.LoteRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (e.Column.FieldName == "Seleccionar")
            {
                if (row.num_line == -1)
                {
                    row.num_line = Convert.ToInt32(gvIngreso.GetFocusedRowCellValue(colLineNum).ToString());
                    //lotes.Find(x => x.Row_ == e.RowHandle + 1).NumLine = Convert.ToInt32(gvIngreso.GetFocusedRowCellValue(colLineNum).ToString());
                }
            }


            if (e.Column.FieldName == "CantSeleccionada")
            {

                if (row != null)
                {
                    if (row.CantSeleccionada > row.cantidad)
                    {
                        CajaDialogo.Error("DEBES SELECCIONAR UNA CANTIDAD MENOR O IGUAL A LA DISPONIBLE");
                        row.CantSeleccionada = 0;
                    }
                    if (row.CantSeleccionada > 0)
                        row.Seleccionar = true;
                }
                gvIngreso.PostEditor();
            }
        }

        List<Ingreso_Externo_Lote_Seleccionado> list_lotes_seleccionados = new List<Ingreso_Externo_Lote_Seleccionado>();

       

        private void LoadLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("sp_get_lote_almacenes_externos",cnx);
                    dsAlmacenesExternos.Lote.Clear();
                    da.Fill(dsAlmacenesExternos.Lote);

                    cnx.Close();
                }

                foreach (var item in dsAlmacenesExternos.Lote)
                {
                    Ingreso_Externo_Lote lote = new Ingreso_Externo_Lote();

                    lote.ID = item.id;
                    lote.NumLine = item.num_line;
                    lote.Lote = item.lote;
                    lote.Unidades = item.unidades;
                    lote.Cantidad = item.cantidad;
                    lote.Row_ = item.row_;

                    lotes.Add(lote);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       

        SqlTransaction transaction;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //var test = 
                //CajaDialogo.Information(dsAlmacenesExternos.Conf_MP_Ingresadas.Select("LineNum=0").ToString());

                //var SumCantSeleccionados = list_lotes_seleccionados.Sum(x => x.Cantidad);
                //var SumUnidadesSeleccionados = list_lotes_seleccionados.Sum(x => x.Unidades);
                //bool puedeguardar = false;
                decimal Comparacion = 0;
                int id_perteneceDetalle = 0;
                decimal SumadelLote = 0;
                foreach (var Detalle in dsAlmacenesExternos.Conf_MP_Ingresadas)
                {

                    Comparacion = Detalle.CantidadIngresada;
                    id_perteneceDetalle = Detalle.row;
                    SumadelLote = 0;
                    foreach (var lotes in dsTodas.Lote)
                    {
                        if (id_perteneceDetalle == lotes.id_pertenece)
                        {
                            SumadelLote = SumadelLote + lotes.cantidad;
                        }
                    }
                    if (Comparacion != SumadelLote)
                    {
                        CajaDialogo.Error("LA CANTIDAD DE LOTES SELECCIONADOS NO COINCIDEN CON LA MATERIA PRIMA");
                        return;
                    }
                }

                //if (totalPeso!= SumCantSeleccionados )
                //{
                //    CajaDialogo.Error("LA CANTIDAD DE LOTES SELECCIONADOS NO COINCIDEN CON LA MATERIA PRIMA");
                //    return;
                //}

                //foreach (var item in dsAlmacenesExternos.Conf_MP_Ingresadas)
                //{
                //    if (item.fecha_vencimiento.Year == 1900 && item.fecha_vencimiento.Month==1 && item.fecha_vencimiento.Day==1)
                //    {
                //        CajaDialogo.Error("DEBE DE INGRESAR LA FECHA DE VENCIMIENTO");
                //        return;
                //    }
                //}
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                int id_h = 0;
                int id_d = 0;




                cnx.Open();
                transaction = cnx.BeginTransaction("SampleTransaction");

                SqlCommand cmd = new SqlCommand("sp_insert_almacenes_externos_h_v2", transaction.Connection);
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_bodega", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@peso", SqlDbType.Decimal).Value = totalPeso;
                cmd.Parameters.Add("@cardcode", SqlDbType.VarChar).Value = oc_h.CodProv;
                cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@id_user_creador", SqlDbType.Int).Value = UsuarioLogueado.Id;
                //cmd.Parameters.Add("@id_user_creador", SqlDbType.Int).Value = 1104;
                cmd.Parameters.Add("@enable", SqlDbType.Bit).Value = 1;
                cmd.Parameters.Add("@id_estado", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@fecha_documento", SqlDbType.Date).Value = oc_h.FechaDocumento;
                //cmd.Parameters.Add("@DocEntrySAP", SqlDbType.Int).Value = oc_h.DocNum;
                
                if(oc_h.DocEntrySAP == 0)
                {
                    if(oc_h.RecuperarRegistro(oc_h.DocNum))
                    {
                        cmd.Parameters.Add("@DocEntrySAP", SqlDbType.Int).Value = oc_h.DocEntrySAP;
                    }
                    else
                    {
                        CajaDialogo.Error("No se pudo recuperar el DocEntry de la OC de SAP!\nPor favor solicite soporte con este caso...");
                        return;
                    }
                }
                else
                {
                    cmd.Parameters.Add("@DocEntrySAP", SqlDbType.Int).Value = oc_h.DocEntrySAP;
                }

                
                cmd.Parameters.Add("@unidades", SqlDbType.Decimal).Value = totalUnidades;
                cmd.Parameters.Add("@factura", SqlDbType.VarChar).Value = oc_h.Factura ;


                id_h = Convert.ToInt32(cmd.ExecuteScalar());


                foreach (var item in dsAlmacenesExternos.Conf_MP_Ingresadas)
                {


                    SqlCommand cmd2 = new SqlCommand("sp_insert_almacenes_externos_d", transaction.Connection);
                    cmd2.Transaction = transaction;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@peso", SqlDbType.Decimal).Value = item.CantidadIngresada;
                    cmd2.Parameters.Add("@enable", SqlDbType.Bit).Value = 1;
                    cmd2.Parameters.Add("@unidades", SqlDbType.Decimal).Value = item.UnidadesIngresar;
                    cmd2.Parameters.Add("@itemcode", SqlDbType.VarChar).Value = item.ItemCode;
                    cmd2.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.id_mp;
                    cmd2.Parameters.Add("@NumLine", SqlDbType.Int).Value = item.LineNum;
                    cmd2.Parameters.Add("@id_ingreso_h", SqlDbType.Int).Value = id_h;
                    cmd2.Parameters.Add("@fecha_vencimiento", SqlDbType.DateTime).Value = item.fecha_vencimiento;
                    cmd2.Parameters.Add("@bodega", SqlDbType.VarChar).Value = item.bodega;
                    cmd2.Parameters.Add("@presentacion", SqlDbType.Int).Value = item.id_presentacion;
                    int Id_EnMemoriaDeLaLineadeMP;
                    id_d = Convert.ToInt32(cmd2.ExecuteScalar());
                    Id_EnMemoriaDeLaLineadeMP = item.row;
                    //var tmpLotesSeleccionados = list_lotes_seleccionados.Where(x => x.NumLine == item.LineNum).ToList();

                    foreach (var item2 in dsTodas.Lote)
                    {
                        //int IdLoteExterno = item2.



                        if (item2.id_pertenece == Id_EnMemoriaDeLaLineadeMP)
                        {
                            SqlCommand cmd3 = new SqlCommand("sp_insert_lote_almacenes_externos_v2", transaction.Connection);
                            cmd3.Transaction = transaction;
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@lote",item2.lote);
                            cmd3.Parameters.AddWithValue("@cantidad", item2.cantidad);
                            cmd3.Parameters.AddWithValue("@unidades", item2.unidades);
                            cmd3.Parameters.AddWithValue("@id_detalle", id_d); 
                            cmd3.Parameters.AddWithValue("@fecha_vencimiento", item2.fecha_vencimiento);
                            cmd3.Parameters.AddWithValue("@fecha_produccion", item2.fecha_produccion);

                            cmd3.ExecuteNonQuery();
                        }



                    }

                }


                transaction.Commit();
                cnx.Close();

                CajaDialogo.Information("SE HA GUARDADO EL REGISTRO EXITOSAMENTE");
                try
                {
                    dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd3 = new SqlCommand("sp_almacenes_externos_rpt_info_ingreso", con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@id_h", id_h);
                    dsSalidasAlmacenesExternos1.reporte_ingreso_h_almacen_externo.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd3);
                    adat.Fill(dsSalidasAlmacenesExternos1.reporte_ingreso_h_almacen_externo);

                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
                xrptAlmacenesExternos report = new xrptAlmacenesExternos(id_h) { DataSource = dsSalidasAlmacenesExternos1, DataMember = "reporte_ingreso_h_almacen_externo" };

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    // Send the report to the default printer.
                    printTool.ShowPreviewDialog();
                }

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }
        }

        private void gvLote_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gv = (GridView)gcLote.FocusedView;
            var row = (dsAlmacenesExternos.LoteRow)gv.GetDataRow(gv.FocusedRowHandle);

        }

     
        private void ceSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gv = (GridView)gcIngreso.FocusedView;
                var row = (dsAlmacenesExternos.Conf_MP_IngresadasRow)gv.GetDataRow(gv.FocusedRowHandle);

                //Quita la seleccion del grid de arriba
                foreach (var item in dsAlmacenesExternos.Conf_MP_Ingresadas)
                {
                    item.seleccionar = false;
                }

                if (row != null)
                {
                    row.seleccionar = true;
                    RowSelected = row.row;
                    TotalLineadeMP = row.CantidadIngresada;
                    dsAlmacenesExternos.Lote.Clear();
                    foreach (var item in dsTodas.Lote)
                    {
                        if (item.id_pertenece == RowSelected)
                        {
                            DataRow workRow = dsAlmacenesExternos.Lote.NewRow();

                            workRow[0] = item.id;
                            workRow[1] = item.cantidad;
                            workRow[2] = item.unidades;
                            workRow[3] =  0;
                            workRow[4] = item.lote;
                            workRow[7] = item.num_line;
                            workRow[8] = item.row_;  
                            workRow["fecha_vencimiento"] = item.fecha_vencimiento;
                            workRow["fecha_produccion"] = item.fecha_produccion;
                            workRow["id_pertenece"] = item.id_pertenece;
                            workRow["LoteNumerador"] =  item.LoteNumerador;

                            dsAlmacenesExternos.Lote.Rows.Add(workRow);
                            dsAlmacenesExternos.AcceptChanges();
                        }
                    }
                    row.AcceptChanges();
                }

               

            }
            catch (Exception exx)
            {
                CajaDialogo.Error(exx.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            var gridView = (GridView)gcLote.FocusedView;
            var row = (dsAlmacenesExternos.LoteRow)gridView.GetFocusedDataRow();
            int RowIdEnMemoria;
            //bool TenemosRowUsandose = false;
            RowIdEnMemoria = row.LoteNumerador;
            foreach (var item in dsTodas.Lote)
            {
                if (item.LoteNumerador == RowIdEnMemoria)
                {
                    item.Delete();
                    dsTodas.AcceptChanges();
                    break;
                }
            }
            gvLote.DeleteRow(gvLote.FocusedRowHandle);
            dsAlmacenesExternos.Lote.AcceptChanges();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            Ingreso_Externo_Lote lote = new Ingreso_Externo_Lote();
            var gridView = (GridView)gcLote.FocusedView;
            var row = (dsAlmacenesExternos.LoteRow)gridView.GetFocusedDataRow();
            lote.ID = row.id;
            lote.Lote = row.lote;
            lote.Cantidad = row.cantidad;
            lote.FechaProduccion = row.fecha_produccion;
            lote.FechaVencimiento = row.fecha_vencimiento;
            lote.Unidades = row.unidades;


            foreach (var item in dsTodas.Lote)
            {
                if (item.LoteNumerador == row.LoteNumerador)
                {
                    item.Delete();
                    dsTodas.AcceptChanges();
                    break;
                }
            }

            decimal Ingresado = 0;
            foreach (var items in dsAlmacenesExternos.Lote)
            {
                Ingresado = Ingresado + items.cantidad;
            }


            //if (Ingresado == TotalLineadeMP)
            //{
            //    CajaDialogo.Error("No se puede agregar mas lotes por que la cantidad configurada sobrepasa el limite seleccionado.");
            //    return;
            //}


            xfrmLoteCRUD frm = new xfrmLoteCRUD(lote);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                 Ingresado = 0;
                foreach (var items in dsAlmacenesExternos.Lote)
                {
                    if (items.LoteNumerador != row.LoteNumerador)
                    {
                        Ingresado = Ingresado + items.cantidad;
                    }
                }

                Ingresado = Ingresado + frm.lote.Cantidad;

                if (Ingresado > TotalLineadeMP)
                {
                    CajaDialogo.Error("No se puede seleccionar este lote por que la cantidad selecionada en los lotes supera la cantidad selecionada por MP.");
                    return;
                }

                int RowIdEnMemoria = row.LoteNumerador;
                gvLote.DeleteRow(gvLote.FocusedRowHandle);
                foreach (var item in dsTodas.Lote)
                {
                    if (item.LoteNumerador == RowIdEnMemoria)
                    {
                        item.Delete();
                        dsTodas.AcceptChanges();
                        break;
                    }
                }
                LoteExternoVar = frm.lote;
                frm.lote.Row_ = lotes.Count + 1;
                lotes.Add(frm.lote);
                int counterRows = 1;

                var lotesDisponibles = lotes.Where(x => x.NumLine == -1);




                DataRow workRow = dsAlmacenesExternos.Lote.NewRow();
                DataRow workRowad = dsTodas.Lote.NewRow();

                workRow[0] = workRowad[0] = frm.lote.ID;
                workRow[1] = workRowad[1] = frm.lote.Cantidad;
                workRow[2] = workRowad[2] = frm.lote.Unidades;
                workRow[3] = workRowad[3] = 0;
                workRow[4] = workRowad[4] = frm.lote.Lote;
                workRow[7] = workRowad[7] = frm.lote.NumLine;
                workRow[8] = workRowad[8] = frm.lote.Row_;
                workRow["fecha_vencimiento"] = workRowad["fecha_vencimiento"] = frm.lote.FechaVencimiento;
                workRow["fecha_produccion"] = workRowad["fecha_produccion"] = frm.lote.FechaProduccion;
                workRow["id_pertenece"] = workRowad["id_pertenece"] = RowSelected;
                workRow["LoteNumerador"] = workRowad["LoteNumerador"] = LoteNumerador;
                LoteNumerador++;                // Update de cambio de las listas...
                counterRows++; // no se que hace.

                dsAlmacenesExternos.Lote.Rows.Add(workRow);
                dsTodas.Lote.Rows.Add(workRowad);


            }
        }

        private void gvIngreso_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)gcIngreso.FocusedView;
                var row = (dsAlmacenesExternos.Conf_MP_IngresadasRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {

                    if (row.seleccionar)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0, 178, 148);

                    }
                    else
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void gvIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


        }

       
    }
}