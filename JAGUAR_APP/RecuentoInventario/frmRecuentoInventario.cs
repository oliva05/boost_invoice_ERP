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
using Huellas;
using System.Threading;

namespace JAGUAR_APP.RecuentoInventario
{
    public partial class frmRecuentoInventario : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int tipoOp = 0; // 0 eS IGUAL A Salida y 1 es igual a entrada
        public frmRecuentoInventario()
        {
            InitializeComponent();
            cargarMateriaPrima();
        }

        private void cargarMateriaPrima()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                string SQL = @"[dbo].[sp_get_list_MP_by_tarima_id_mp]";

                dsRecuento.materia_prima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsRecuento.materia_prima);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public void load_tarimas()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                string SQL = @"sp_load_tarimas_to_edit_v2";

                dsRecuento.tarimas_ajuste.Clear();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", cbMateriaPrima.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);

                adat.Fill(dsRecuento.tarimas_ajuste);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }
        private void cbMateriaPrima_EditValueChanged(object sender, EventArgs e)
        {
            //if (tipoOp == 0 )
            //{
            //    load_tarimas();
            //}
            //else
            //{
            //    load_fuerainventario();
            //}
            load_tarimas();
        }

        public void load_fuerainventario()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                string SQL = @"sp_load_tarimas_to_back";

                dsRecuento.tarimas.Clear();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", cbMateriaPrima.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);

                adat.Fill(dsRecuento.tarimas);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            int TiempoP = 2000;
            SplashForm frmProceso = new SplashForm();
            try
            {
                cn.Open();

                if (tipoOp == 0)
                {
                    foreach (dsRecuento.tarimasRow row in dsRecuento.tarimas)
                    {
                        if (row.eliminar)
                        {
                            string query = @"sp_eliminar_tarima";
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_tarima", row.id);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                        }
                        else
                        {
                            string query = @"sp_update_tarima_recuento";
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ingreso", row.ingreso);
                            cmd.Parameters.AddWithValue("@id_tarima", row.id);
                            cmd.Parameters.AddWithValue("@lote_materia_prima", row.lote_materia_prima);
                            cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmd.Parameters.AddWithValue("@peso", row.peso);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }


                    }
                }
                else
                {
                    foreach (dsRecuento.tarimasRow row in dsRecuento.tarimas)
                    {
                        if (row.eliminar)
                        {
                            string query = @"sp_revivir_tarima";
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_tarima", row.id);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                        }
                        else
                        {
                            string query = @"sp_update_tarima_recuento";
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ingreso", row.ingreso);
                            cmd.Parameters.AddWithValue("@id_tarima", row.id);
                            cmd.Parameters.AddWithValue("@lote_materia_prima", row.lote_materia_prima);
                            cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmd.Parameters.AddWithValue("@peso", row.peso);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }


                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            frmProceso.ShowDialog();
            Thread.Sleep(TiempoP);
            frmProceso.Close(); 
            if (tipoOp == 0)
            {
                load_tarimas();
            }
            else
            {
                load_fuerainventario();
            }

        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsRecuento.tarimasRow)gridView.GetFocusedDataRow();
                if (tipoOp == 0)
                {
                    switch (e.Column.Name)
                    {
                        case "colEIngreso":
                            bool ingreso = row.EIngreso;
                            row.EIngreso = Convert.ToBoolean(e.Value);
                            foreach (dsRecuento.tarimasRow item in dsRecuento.tarimas.Rows)
                            {
                                if (row.ingreso == item.ingreso)
                                {
                                    item.EIngreso = Convert.ToBoolean(e.Value);
                                    item.eliminar = Convert.ToBoolean(e.Value);
                                    if (Convert.ToBoolean(e.Value))
                                    {

                                        item.peso = 0;
                                        item.cantidad = 0;
                                    }
                                    else
                                    {
                                        item.cantidad = item.CantidadSave;
                                        item.peso = item.cantidad * item.factor;
                                    }
                                    item.AcceptChanges();
                                }
                            }
                            break;
                        case "colELote":
                            row.ELote = Convert.ToBoolean(e.Value);
                            foreach (dsRecuento.tarimasRow item in dsRecuento.tarimas.Rows)
                            {
                                if (row.lote_materia_prima == item.lote_materia_prima && row.ingreso == item.ingreso)
                                {
                                    item.ELote = Convert.ToBoolean(e.Value);
                                    item.eliminar = Convert.ToBoolean(e.Value);

                                    if (Convert.ToBoolean(e.Value))
                                    {

                                        item.peso = 0;
                                        item.cantidad = 0;
                                    }
                                    else
                                    {
                                        item.cantidad = item.CantidadSave;
                                        item.peso = item.cantidad * item.factor;
                                    }
                                    item.AcceptChanges();
                                }
                            }
                            break;
                        case "coleliminar":

                            if (Convert.ToBoolean(e.Value))
                            {

                                row.eliminar = Convert.ToBoolean(e.Value);
                                row.peso = 0;
                                row.cantidad = 0;
                            }
                            else
                            {
                                row.EIngreso = Convert.ToBoolean(e.Value);
                                row.ELote = Convert.ToBoolean(e.Value);
                                row.eliminar = Convert.ToBoolean(e.Value);
                                row.cantidad = row.CantidadSave;
                                row.peso = row.cantidad * row.factor;
                            }
                            break;
                        case "colcantidad":
                            row.cantidad = Convert.ToDecimal(e.Value);
                            row.peso = row.cantidad * row.factor;


                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    switch (e.Column.Name)
                    {
                        case "colEIngreso":
                            bool ingreso = row.EIngreso;
                            row.EIngreso = Convert.ToBoolean(e.Value);
                            foreach (dsRecuento.tarimasRow item in dsRecuento.tarimas.Rows)
                            {
                                if (row.ingreso == item.ingreso)
                                {
                                    item.EIngreso = Convert.ToBoolean(e.Value);
                                    item.eliminar = Convert.ToBoolean(e.Value);
                                    item.AcceptChanges();
                                }
                            }
                            break;
                        case "colELote":
                            row.ELote = Convert.ToBoolean(e.Value);
                            foreach (dsRecuento.tarimasRow item in dsRecuento.tarimas.Rows)
                            {
                                if (row.lote_materia_prima == item.lote_materia_prima && row.ingreso == item.ingreso)
                                {
                                    item.ELote = Convert.ToBoolean(e.Value);
                                    item.eliminar = Convert.ToBoolean(e.Value); 
                                    item.AcceptChanges();
                                }
                            }
                            break;
                        case "coleliminar":

                            if (Convert.ToBoolean(e.Value))
                            {

                                row.eliminar = Convert.ToBoolean(e.Value);   
                            }
                            else
                            {
                                row.EIngreso = Convert.ToBoolean(e.Value);
                                row.ELote = Convert.ToBoolean(e.Value);
                                row.eliminar = Convert.ToBoolean(e.Value); 
                            }
                            break;
                        case "colcantidad":
                            row.cantidad = Convert.ToDecimal(e.Value);
                            row.peso = row.cantidad * row.factor;


                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void tggOperacion_Toggled(object sender, EventArgs e)
        {
            if (tggOperacion.IsOn)
            {
                tipoOp = 1;
            }
            else
            {
                tipoOp = 0;
            }
            if (cbMateriaPrima.EditValue != null)
            {
                if (tipoOp == 0)
                {
                    load_tarimas();
                }
                else
                {
                    load_fuerainventario();
                }
            }
        }

        private void checkDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            int contaHab = dsRecuento.tarimas.Count;
            var gridViewHabilitado = (GridView)grd_data.FocusedView;
            for (int i = 0; i < contaHab; i++)
            {
                dsRecuento.tarimasRow rowHab = (dsRecuento.tarimasRow)gridViewHabilitado.GetDataRow(i);
                int r = gridViewHabilitado.GetVisibleRowHandle(i + 1);
                if (r >= 0)
                {
                    if (rowHab != null)
                    {
                        rowHab.eliminar = checkDisponibles.Checked;
                        //ListaTarimas.Add(rowHab.id);
                    }
                }
                else
                {
                    if (rowHab != null)
                        rowHab.eliminar = false;
                }
            }
        }

        private void cmdGestionar_Click(object sender, EventArgs e)
        {
            frmAjusteINV_PorTarimas frm = new frmAjusteINV_PorTarimas(dsRecuento);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                load_tarimas();
            }
        }
    }
}