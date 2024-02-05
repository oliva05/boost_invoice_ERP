using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.LogisticaJaguar.Models;
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

namespace JAGUAR_APP.LogisticaJaguar.Despacho
{
    public partial class xfrmSelectPT : DevExpress.XtraEditors.XtraForm
    {
        public List<PT_Selection> seleccionados = new List<PT_Selection>();
        public xfrmSelectPT()
        {
            InitializeComponent();
            LoadPT();
        }

      

        private void LoadPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                using (SqlDataAdapter da = new SqlDataAdapter("[dbo].[uspGetPT_DisponibleFromTraslado]", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dsDespacho.PT_Seleccion.Clear();
                    da.Fill(dsDespacho.PT_Seleccion);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       

        private void gvPT_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            #region Codigo Euceda
            //try
            //{
            //    seleccionados.Clear();
            //    var row = (dsDespacho.PT_SeleccionRow)gvPT.GetFocusedDataRow();

            //    if (row.cant_despachar > row.existencia)
            //    {
            //        CajaDialogo.Error("Dede de ingresar una cantidad menor a la existente");
            //        row.cant_despachar = 0;
            //        return;
            //    }

            //    if (row.seleccion == true && row.cant_despachar == 0)
            //    {
            //        CajaDialogo.Error("debe de ingresar la cantidad a despachar del producto seleccionado");
            //        row.seleccion = false;
            //        return;
            //    }

            //    foreach (var item in dsDespacho.PT_Seleccion)
            //    {
            //        if (item.seleccion)
            //        {
            //            PT_Selection seleccion = new PT_Selection();

            //            if (item.cant_despachar > 0)
            //            {
            //                seleccion.PT_ID = item.id_pt;
            //                seleccion.Codigo = item.code;
            //                seleccion.PT_Name = item.pt;
            //                seleccion.Lote = item.lote;
            //                seleccion.Existencia = item.existencia;
            //                seleccion.PresentacionID = item.id_presentacion;
            //                seleccion.Presentacion = item.presentacion;
            //                seleccion.Cantidad_Despachar = item.cant_despachar;
            //                seleccionados.Add(seleccion);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            #endregion

            if (e.Column.FieldName == "cant_despachar")
            {
                var row = (dsDespacho.PT_SeleccionRow)gvPT.GetFocusedDataRow();

                if (row.cant_despachar > row.existencia)
                {
                    CajaDialogo.Error("Dede de ingresar una cantidad menor a la existente");
                    row.cant_despachar = 0;
                    return;
                }
                else
                {
                    row.seleccion = true; 
                }
            }
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (var item in dsDespacho.PT_Seleccion)
            {
                if (item.seleccion)
                {
                    PT_Selection seleccion = new PT_Selection();

                    if (item.cant_despachar > 0)
                    {
                        seleccion.PT_ID = item.id_pt;
                        seleccion.Codigo = item.code;
                        seleccion.PT_Name = item.pt;
                        seleccion.Lote = item.lote;
                        seleccion.Existencia = item.existencia;
                        seleccion.PresentacionID = item.id_presentacion;
                        seleccion.Presentacion = item.presentacion;
                        seleccion.Cantidad_Despachar = item.cant_despachar;
                        seleccionados.Add(seleccion);
                    }
                }
            }
            this.DialogResult= DialogResult.OK;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}