using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Huellas;
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

namespace JAGUAR_APP.RecuentoInventario
{
    public partial class frmAjusteINV_PorTarimas : DevExpress.XtraEditors.XtraForm
    {
        dsRecuento dsParametro;
        public frmAjusteINV_PorTarimas(dsRecuento pdsParametro)
        {
            InitializeComponent();
            dsParametro = pdsParametro;
            radioGroupTipoTransaccion.EditValue = 2;


        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl1.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsRecuento.tarimas_ajusteRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.cant_prd > 0)
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 153, 153);//Rojo
                        //row.seleccionar = false;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 255);//blanco
                        //row.seleccionar = true;
                    }
                }
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            bool Exito = false;
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //int TiempoP = 1000;
            SplashForm frmProceso = new SplashForm();
            try
            {
                cn.Open();

                if (radioGroupTipoTransaccion.SelectedIndex == 0)//Entrada
                {
                    foreach (dsRecuento.tarimas_ajusteRow row in dsRecuento1.tarimas_ajuste)
                    {
                        if (row.seleccionar)
                        {
                            string query = @"sp_revivir_tarima";
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_tarima", row.id);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            Exito = true;
                        }
                        //else
                        //{
                        //    string query = @"sp_update_tarima_recuento";
                        //    SqlCommand cmd = new SqlCommand(query, cn);
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("@ingreso", row.ingreso);
                        //    cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        //    cmd.Parameters.AddWithValue("@lote_materia_prima", row.lote_materia_prima);
                        //    cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                        //    cmd.Parameters.AddWithValue("@peso", row.peso);
                        //    cmd.ExecuteNonQuery();
                        //    cmd.Parameters.Clear();
                        //}
                    }
                }
                else
                {
                    //Salida
                    foreach (dsRecuento.tarimas_ajusteRow row in dsRecuento1.tarimas_ajuste)
                    {
                        if (row.seleccionar)
                        {
                            string query = @"sp_eliminar_tarima";
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_tarima", row.id);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            Exito = true;
                        }
                        //else
                        //{
                        //    string query = @"sp_update_tarima_recuento";
                        //    SqlCommand cmd = new SqlCommand(query, cn);
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("@ingreso", row.ingreso);
                        //    cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        //    cmd.Parameters.AddWithValue("@lote_materia_prima", row.lote_materia_prima);
                        //    cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                        //    cmd.Parameters.AddWithValue("@peso", row.peso);
                        //    cmd.ExecuteNonQuery();
                        //    cmd.Parameters.Clear();
                        //}
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (Exito)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            //frmProceso.ShowDialog();
            //Thread.Sleep(TiempoP);
            //frmProceso.Close();
            //if (tipoOp == 0)
            //{
            //    load_tarimas();
            //}
            //else
            //{
            //    load_fuerainventario();
            //}
        }//end boton guardar

        private void frmAjusteINV_PorTarimas_Load(object sender, EventArgs e)
        {
            dsRecuento1.tarimas_ajuste.Clear();
            foreach (dsRecuento.tarimas_ajusteRow row in dsParametro.tarimas_ajuste.Rows)
            {
                if (row.seleccionar)
                {
                    
                    dsRecuento.tarimas_ajusteRow row1 = dsRecuento1.tarimas_ajuste.Newtarimas_ajusteRow();
                    if (row.cant_prd > 0)
                    {
                        row1.seleccionar = false;
                    }
                    else
                    {
                        row1.seleccionar = true;
                    }
                    row1.id = row.id;
                    row1.ingreso = row.ingreso;
                    row1.lote_materia_prima = row.lote_materia_prima;
                    row1.itemcode = row.itemcode;
                    row1.material = row.material;
                    row1.cantidad = row.cantidad;
                    row1.descripcion = row.descripcion;
                    row1.factor = row.factor;
                    row1.peso = row.peso;
                    row1.codigo = row.codigo;
                    row1.FechaIngreso = row.FechaIngreso;
                    row1.DiasParaVencer = row.DiasParaVencer;
                    row1.cant_prd = row.cant_prd;
                    row1.cant_bodega = row.cant_bodega;
                    dsRecuento1.tarimas_ajuste.Addtarimas_ajusteRow(row1);
                    dsRecuento1.AcceptChanges();
                    gridControl1.RefreshDataSource();
                }
            }
        }
    }
}