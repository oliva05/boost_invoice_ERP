using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using System;
using System.Collections;
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
    public partial class frmAsignarArrobasPanadero : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        string PT_Name;
        string Presentacion_name;
        decimal CantArrobas;
        int id_pt;

        public decimal Res_CantArrobas;
        public decimal Res_CantArrobasAsigned;
        public ArrayList ListaPanaderosAsignados;
        public frmAsignarArrobasPanadero(int pIdPt, string pPT_Name, string pPresentacion_name, decimal pCantArrobas)
        {
            InitializeComponent();
            dp = new DataOperations();
            LoadPanaderos();
            id_pt = pIdPt;
            txtProductoTerminado.Text =  PT_Name = pPT_Name;
            txtPresentacionNombre.Text = Presentacion_name = pPresentacion_name;
            CantArrobas = pCantArrobas;
            Res_CantArrobas = Math.Round(pCantArrobas, 0);
            txtCantidadInicial.Text= string.Format("{0:###,##0}", Res_CantArrobas);
        }

        private void LoadPanaderos()
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_lista_panaderos_asignar_arrobas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_pt", this.ProductoTerminadoActual.Id);
                //cmd.Parameters.AddWithValue("@cant_arroba", spinEditCantArrobas.EditValue);
                dsProduccion1.panaderos_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProduccion1.panaderos_list);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            decimal Cant_Asignada = 0;
            foreach(dsProduccion.panaderos_listRow row in dsProduccion1.panaderos_list)
            {
                try
                {
                    if(row.seleccionado)
                        Cant_Asignada += dp.ValidateNumberInt32(row.cantidad);
                }
                catch { }
            }

            if(Cant_Asignada > Res_CantArrobas)
            {
                CajaDialogo.Error("Esta asignando una cantidad mayor a la disponible!");
                return;
            }

            foreach (dsProduccion.panaderos_listRow row in dsProduccion1.panaderos_list)
            {
                decimal cant_provisional = 0;
                try
                {
                    if(row.seleccionado)
                        cant_provisional = row.cantidad;
                    else
                        cant_provisional = 0;
                }
                catch { cant_provisional = 0; }

                row.cantidad = cant_provisional;
            }

            ListaPanaderosAsignados = new ArrayList();
            foreach (dsProduccion.panaderos_listRow row in dsProduccion1.panaderos_list)
            {
                if (row.cantidad > 0)
                {
                    Panadero pan1 = new Panadero();
                    pan1.idPanadero = row.id;
                    pan1.NamePanadero = row.nombre;
                    pan1.CantAsignada = row.cantidad;
                    ListaPanaderosAsignados.Add(pan1);
                }
            }

            Res_CantArrobasAsigned = Cant_Asignada;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsProduccion.panaderos_listRow)gridView.GetFocusedDataRow();

            if (e.Column.FieldName == "cantidad")
            {
                //row.cantidad;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            

            if (e.Column.FieldName == "cantidad")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsProduccion.panaderos_listRow)gridView.GetFocusedDataRow();


                if (dp.ValidateNumberInt32(row.cantidad) > 0)
                    row.seleccionado = true;
                else
                    row.seleccionado = false;

            }
        }
    }
}