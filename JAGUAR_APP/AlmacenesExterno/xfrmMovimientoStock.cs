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
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.AlmacenesExterno.Models;
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_APP.AlmacenesExterno.Salida_Almacen.Models;
using JAGUAR_APP.AlmacenesExterno.Salida_Almacen;
using JAGUAR_APP.Clases;

namespace  JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmMovimientoStock : DevExpress.XtraEditors.XtraForm
    {
        Materia_Prima_Transferencia materia_Prima_Transferencia = new Materia_Prima_Transferencia();
        int id_h;
        string id_proveedor;
        int docEntry;
        UserLogin UsuarioLogeado;
        int id_presentacion;
        public xfrmMovimientoStock(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            ObtenerBodegas();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarProd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                materia_Prima_Transferencia = new Materia_Prima_Transferencia();
                xfrmBuscarMP_Ingresos_Externos frm = new xfrmBuscarMP_Ingresos_Externos();

                var gv = (GridView)gcTransferencia.FocusedView;
                var row = (dsAlmacenesExternos.Transferencia_StockRow)gv.GetDataRow(gv.FocusedRowHandle);

                if (frm.ShowDialog() == DialogResult.OK)
                {

                    if (row == null)
                    {


                        DataRow workRow = dsAlmacenesExternos.Transferencia_Stock.NewRow();

                        workRow[0] = frm.materia_Prima_Transferencia.CodeItem;
                        workRow[1] = frm.materia_Prima_Transferencia.CodeName;
                        workRow["cantidad_kilos"] = frm.materia_Prima_Transferencia.Peso;
                        workRow["unidades"] = frm.materia_Prima_Transferencia.Unidades;

                        dsAlmacenesExternos.Transferencia_Stock.Rows.Add(workRow);

                        gvTransferencia.PostEditor();
                    }
                    else
                    {
                        row.codeItem = frm.materia_Prima_Transferencia.CodeItem;
                        row.mp = frm.materia_Prima_Transferencia.CodeName;
                        row.cantidad_kilos = frm.materia_Prima_Transferencia.Peso;
                        row.unidades = frm.materia_Prima_Transferencia.Unidades;

                        gv.FocusedColumn = colmp;
                        //gv.RefreshData();
                        dsAlmacenesExternos.AcceptChanges();
                        //gvTransferencia.PostEditor();
                    }

                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
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


        Ingreso_Almacenes_Externos_H ingreso_Almacenes_Externos_H = new Ingreso_Almacenes_Externos_H();
        private void btnBuscarIngreso_Click(object sender, EventArgs e)
        {
            xfrmBuscarIngresosAlmacen frm = new xfrmBuscarIngresosAlmacen();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtProveedor.Text = frm.ingreso_h.CardName;
                id_h = frm.ingreso_h.ID;
                id_proveedor = frm.ingreso_h.CardCode;
                docEntry = frm.ingreso_h.DocEntry;
                lueAlmacenFROM.EditValue = frm.ingreso_h.BodegaIN;
                id_presentacion = frm.ingreso_h.Id_presentacion; 
                LoadDetailIngresosExternos();

                ingreso_Almacenes_Externos_H = frm.ingreso_h;
            }
        }


        private void LoadDetailIngresosExternos()
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                dsSalidasAlmacenesExternos.Transferencia_Stock.Clear();
                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter("[dbo].[sp_get_ingresos_externos_disponibles_salida_externa]", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id_h;

                da.Fill(dsSalidasAlmacenesExternos.Transferencia_Stock);

                cnx.Close();
            }


            foreach (var item in dsSalidasAlmacenesExternos.Transferencia_Stock)
            {
                item.from_almacen = lueAlmacenFROM.Text;
                item.to_almacen = lueAlmacenDestino.Text;
            }

        }

        private void lueAlmacenFROM_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProveedor.Text))
                {
                    txtProveedor.Text = "";
                    CajaDialogo.Error("DEBE DE SELCCIONAR LA MATERIA PRIMA");

                    return;
                }

                if (lueAlmacenFROM.EditValue != lueAlmacenDestino.EditValue)
                {

                    foreach (var item in dsSalidasAlmacenesExternos.Transferencia_Stock)
                    {
                        if (item.seleccionar == true)
                        {

                            item.from_almacen = lueAlmacenFROM.Text;
                            item.to_almacen = lueAlmacenDestino.Text;
                        }
                    }
                }
                else
                {
                    CajaDialogo.Error("EL ALMACEN DE ORIGEN DEBE SER DIFERENTE AL ALMACEN DESTINO");
                    lueAlmacenFROM.Text = "";
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void lueAlmacenDestino_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProveedor.Text))
                {
                    txtProveedor.EditValue = null;
                    CajaDialogo.Error("DEBE DE SELCCIONAR LA MATERIA PRIMA");
                    return;
                }

                if (lueAlmacenFROM.EditValue.ToString() != lueAlmacenDestino.EditValue.ToString())
                {

                    foreach (var item in dsSalidasAlmacenesExternos.Transferencia_Stock)
                    {
                        if (item.seleccionar == true)
                        {

                            item.from_almacen = lueAlmacenFROM.Text;
                            item.to_almacen = lueAlmacenDestino.Text;
                        }
                    }
                }
                else
                {
                    CajaDialogo.Error("EL ALMACEN DE DESTINO DEBE SER DIFERENTE AL ALMACEN ORIGEN");
                    lueAlmacenDestino.EditValue = "";
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnConfLotes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsSalidasAlmacenesExternos.Transferencia_Stock.ToList().Where(x => x.seleccionar == true).ToList().Count == 0)
                {
                    CajaDialogo.Error("DEBE SELECCIONAR AL MENOS UN ITEM");
                    return;
                }


                if (string.IsNullOrEmpty(lueAlmacenFROM.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA BODEGA ORIGEN Y DESTINO");
                    return;
                }

                if (string.IsNullOrEmpty(lueAlmacenDestino.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA BODEGA ORIGEN Y DESTINO");
                    return;
                }


                List<Ingresos_Externos_D> lista = new List<Ingresos_Externos_D>();

                foreach (var item in dsSalidasAlmacenesExternos.Transferencia_Stock.ToList().Where(x => x.seleccionar == true).ToList())
                {
                    Ingresos_Externos_D ingresos_Externos_D = new Ingresos_Externos_D();

                    ingresos_Externos_D.DocEntry = item.DocEntrySAP;
                    ingresos_Externos_D.NumLine = item.NumLine;
                    ingresos_Externos_D.ID = item.id;
                    ingresos_Externos_D.ItemCode = item.itemcode;
                    ingresos_Externos_D.ItemName = item.itemName;
                    ingresos_Externos_D.Peso = item.peso;
                    ingresos_Externos_D.Unidades = item.unidades;
                    ingresos_Externos_D.IDMP = item.id_mp;
                    ingresos_Externos_D.BodegaIN = lueAlmacenFROM.Text;
                    ingresos_Externos_D.BodegaOUT = lueAlmacenDestino.Text;
                    ingresos_Externos_D.factura = item.factura;
                    ingresos_Externos_D.docnum = item.DocNum;

                    lista.Add(ingresos_Externos_D);

                }

                ingreso_Almacenes_Externos_H.BodegaIN = lueAlmacenFROM.Text;
                ingreso_Almacenes_Externos_H.BodegaOUT = lueAlmacenDestino.Text;

                xfrmConfLotesSalidaAlmacen frm = new xfrmConfLotesSalidaAlmacen(lista, ingreso_Almacenes_Externos_H, UsuarioLogeado);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ceSeleccionar_CheckStateChanged(object sender, EventArgs e)
        {
            var gv = (GridView)gcTransferencia.FocusedView;
            var row = (dsSalidasAlmacenesExternos.Transferencia_StockRow)gv.GetDataRow(gv.FocusedRowHandle);


            if (string.IsNullOrEmpty(row.to_almacen) || string.IsNullOrEmpty(row.from_almacen))
            {
                row.to_almacen = lueAlmacenDestino.Text;
                row.from_almacen = lueAlmacenFROM.Text;

            }
        }

        private void xfrmMovimientoStock_Load(object sender, EventArgs e)
        {
            deFecha.EditValue = DateTime.Now;
        }

        private void gvTransferencia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "to_almacen")
            {
                DataOperations dp = new DataOperations();
                if (!string.IsNullOrEmpty(dp.ValidateNumberString(e.Value)))
                {
                    var gv = (GridView)gcTransferencia.FocusedView;
                    var row = (dsSalidasAlmacenesExternos.Transferencia_StockRow)gv.GetDataRow(e.RowHandle);
                    row.seleccionar = true;
                }
            }    
        }
    }
}