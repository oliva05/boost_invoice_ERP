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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.AlmacenesExterno.Models;
using JAGUAR_APP.Clases;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmRevisarOC : DevExpress.XtraEditors.XtraForm
    {
        OrdenCompra_H oc_h = new OrdenCompra_H();

        UserLogin UsuarioLogueado;

        public xfrmRevisarOC(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogueado = pUser;
            ObtenerBodegas();
            LoadPresentaciones();
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas_v4", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAlmacenesExternos.presentacion.Clear();
                adat.Fill(dsAlmacenesExternos.presentacion);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
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
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_almacenes_externos_bodegas_v2", cnx);
                    da.Fill(dsAlmacenesExternos.Warehouse);


                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnOC_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AbrirBusquedaOC();
        }

        private void AbrirBusquedaOC()
        {
            xfrmSeleccionarOC frm = new xfrmSeleccionarOC();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                oc_h = frm.oc;
                txtProveedor.Text = frm.oc.Proveedor;
                txtDate.EditValue = frm.oc.FechaDocumento;
                txtComment.Text = frm.oc.Comentario;
                btnOC.Text = frm.oc.DocNum.ToString();

                LoadOCDetail(frm.oc.ID);
            }
        }

        private void LoadOCDetail(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {

                    cnx.Open();
                    dsAlmacenesExternos.RevisionOC.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_OC_Detail_AlmacenesExternos", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@DocEntry", SqlDbType.Int).Value = id;
                    da.Fill(dsAlmacenesExternos.RevisionOC);
                    cnx.Close();
                    if (string.IsNullOrEmpty(txtfactura.Text))
                    {
                        errorProvider1.SetError(txtfactura, "Ingrese el numero de Factura!");
                        txtfactura.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        //SqlTransaction transaction;
        private void btn_Click(object sender, EventArgs e)
        {
            List<Conf_MP_Ingresada> lista = new List<Conf_MP_Ingresada>();
            if (txtfactura.Text == "")
            {
                CajaDialogo.Error("DEBE ESPECIFICAR LA FACTURA");
                return;
            }
            oc_h.Factura = txtfactura.Text;
            var gv = (GridView)gcIngreso.FocusedView;

                       
            foreach (dsAlmacenesExternos.RevisionOCRow element in dsAlmacenesExternos.RevisionOC)
            {
                if (element.seleccionar == true)
                {
                    if (element.CantidadIngresar == 0)
                    {
                        CajaDialogo.Error("DEBE DE INGRESAR UNA CANTIDAD");
                        return;
                    }

                    if (element.UnidadesIngresar == 0)
                    {
                        CajaDialogo.Error("DEBE DE INGRESAR LAS UNIDADES");
                        return;
                    }

                    //Rehabilitar codigo despues de fijar inv iniciales
                    //if (element.diferencia < 0)
                    //{
                    //    CajaDialogo.Error("YA SE INGRESO LA MISMA CANTIDAD DE LA ORDEN DE COMPRA");
                    //    return;
                    //}

                    if (string.IsNullOrEmpty( element.bodega))
                    {
                        CajaDialogo.Error("DEBE SELECCIONAR UN ALMACEN");
                        return;
                    }

                    if ( element.id_presentacion==0)
                    {
                        CajaDialogo.Error("DEBE SELECCIONAR UNA PRESENTACION");
                        return;
                    }

                    //if (element.diferencia >= 0)
                    {

                        lista.Add(new Conf_MP_Ingresada
                        {
                            ItemCode = element.ItemCode,
                            CantIngresada = element.CantidadIngresar,
                            Descripcion = element.Dscription,
                            UnidadesIngresadas = element.UnidadesIngresar,
                            LineNum = element.LineNum,
                            MPID = element.id_mp,
                            bodega = element.bodega,
                            id_presentacion = element.id_presentacion

                        }) ;

                    }

                   
                }
                else
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN ITEM");
                    return;
                }
            }
            xfrmAlmacenesExternosDefinirLotes frm = new xfrmAlmacenesExternosDefinirLotes(lista, oc_h, UsuarioLogueado);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


            //xfrmAlmacenesExternosDefinirLotes frm = new xfrmAlmacenesExternosDefinirLotes(lista,oc_h,UsuarioLogueado );

            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    this.Close();
            //}

        }

        private void gvIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gv = (GridView)gcIngreso.FocusedView;
            var row = (dsAlmacenesExternos.RevisionOCRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (row != null)
            {
                //Habilitar esta validacion luego de cargar saldos iniciales
                //if (row.CantidadIngresar > row.kg)
                //{
                //    CajaDialogo.Error("LA CANTIDAD INGRESADA ES SUPERIOR A LO QUE DISPONE LA ORDEN DE COMPRA");
                //    row.CantidadIngresar = 0;
                //    return;
                //}

                //if (row.diferencia <= 0 )
                //{
                //    CajaDialogo.Error("YA SE INGRESO LA MISMA CANTIDAD DE LA ORDEN DE COMPRA");
                //    row.CantidadIngresar = 0;
                //    return;
                //}

                //if ( row.CantidadIngresar > row.diferencia && row.diferencia > 0)
                //{
                //    CajaDialogo.Error("DEBE DE INGRESAR UNA CANTIDAD MENOR O IGUAL A " + row.diferencia+ " Para esta MP");
                //    row.CantidadIngresar = 0;
                //    return;
                //}

                //if (row.CantidadIngresar <= row.diferencia && row.diferencia > 0)
                //{
                //    row.seleccionar = true;
                //}
            }

            switch(e.Column.FieldName)
            {
                case "id_presentacion":
                case "CantidadIngresar":
                    PresentacionX pres1 = new PresentacionX();
                    if (pres1.RecuperarRegistro(row.id_presentacion))
                    {
                        DataOperations dp = new DataOperations();
                        if (pres1.Factor > 0)
                        {
                            row.UnidadesIngresar = Math.Round((dp.ValidateNumberDecimal(row.CantidadIngresar) / pres1.Factor), 0);
                            if(row.UnidadesIngresar>0)
                                row.seleccionar = true;
                            else
                                row.seleccionar = false;
                        }
                    }
                    break;
            }
        }

        private void ceSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            var gv = (GridView)gcIngreso.FocusedView;
            var row = (dsAlmacenesExternos.RevisionOCRow)gv.GetDataRow(gv.FocusedRowHandle);

            //if (row.seleccionar==true)
            //{
            //    if (row.diferencia<=0)
            //    {
            //        CajaDialogo.Error("NO PUEDE SELECCIONAR ESTE ITEM PORQUE YA HA SIDO INGRESADO TOTALMENTE");
            //        row.seleccionar = false;
            //        return;
            //    }

            //}
        }

        private void txtfactura_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtfactura.Text))
            {
                errorProvider1.Clear();
            }
        }

        private void btnOC_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void xfrmRevisarOC_Activated(object sender, EventArgs e)
        {
            btnOC.Focus();
        }

        private void gcIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}