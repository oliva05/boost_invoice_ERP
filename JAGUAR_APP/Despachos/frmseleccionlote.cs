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

namespace JAGUAR_APP.Despachos
{
    public partial class frmseleccionlote : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int CantidadPendiente;
        private int Pid_detalle;
        private string itemcode;
        UserLogin UsuarioLogeado;
        public frmseleccionlote(int CantidadPendiente, string itemcode, string Dscripcion, int id_detalle, UserLogin User)
        {
            InitializeComponent();
            txtSolicitada.Text = CantidadPendiente.ToString();
            this.CantidadPendiente = CantidadPendiente;
            txtitem.Text = "(" + itemcode + ") - " + Dscripcion;
            Pid_detalle = id_detalle;
            this.itemcode = itemcode;
            LoadDetalleLotes();
            UsuarioLogeado = User;



        }
        private void LoadDetalleLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_pt_req", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                cmd.Parameters.AddWithValue("@idDetalle", Pid_detalle);
                ds_despachos.detalle_lote_pt.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(ds_despachos.detalle_lote_pt);
                con.Close();
                //Boolean Solounavez = false;
                foreach (ds_despachos.detalle_lote_ptRow row in ds_despachos.detalle_lote_pt.Rows)
                {
                    
                    txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - row.totalcants);
                     txtAsignada.Text = string.Format("{0:###,##0.00}", row.totalcants);
                    break;
                    
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;
            decimal cantidad_conseguida = 0;
            if (chkTodos.Checked)
            {
                //var gridView = (GridView)grRequisicoinesMP.FocusedView;
                //var row = (dsTransaccionesMP.detalle_lote_mpRow)gridView.GetFocusedDataRow();

                foreach (ds_despachos.detalle_lote_ptRow row in ds_despachos.detalle_lote_pt.Rows)
                {
                    if (row.cantidad == cantidaPendiente)
                    {
                        row.seleccionado = true;
                        cantidaPendiente = 0;
                        row.cants = row.cantidad;
                        break;
                    }
                    if (row.cantidad > cantidaPendiente && cantidaPendiente > 0)
                    {
                        if (row.cantidad > cantidaPendiente)
                            row.cants = cantidaPendiente;
                        else
                            row.cants = total_solicitado - cantidaPendiente;

                        //row.cants = row.peso_total - cantidaPendiente;
                        cantidaPendiente -= row.cants;
                        row.seleccionado = true;
                        break;
                    }
                    else
                    {
                        //en el row tenemos un valor menor que el solicitado
                        //Necesitaremos mas de un row para satisfaser la cantidad requerida.
                        if (row.cantidad < cantidaPendiente && cantidaPendiente > 0)
                        {
                            //seleccionamos la cantidad total del row para acumular el valor solictado.
                            row.cants = row.cantidad;

                            //Restamos la cantidad conseguida o asignada.
                            cantidaPendiente -= row.cants;

                            //Marcamos el row seleccionado porque se utilizaria dicho lote para la requisicion.
                            row.seleccionado = true;
                        }
                    }

                    //Calculo de totales.
                    if (row.seleccionado)
                        cantidad_conseguida += row.cants;

                    txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                    txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                    //end block foreach
                }
            }
            else
            {
                foreach (ds_despachos.detalle_lote_ptRow row in ds_despachos.detalle_lote_pt.Rows)
                {
                    row.seleccionado = false;
                    row.cants = 0;

                    if (row.seleccionado)
                        cantidad_conseguida += row.cants;

                    txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                    txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                }
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnguardado_Click(object sender, EventArgs e)
        {
            int Seleccionados = 0;
            foreach (ds_despachos.detalle_lote_ptRow row in ds_despachos.detalle_lote_pt.Rows)
            {
                if (row.seleccionado)
                {
                    Seleccionados++;
                    break;
                }
            }

            if (Seleccionados <= 0)
            {
                CajaDialogo.Error("Debe seleccionar al menos un lote");
                return;
            }

            //decimal pendiente = 0;
            if (Convert.ToDecimal(txtCantidadPendiente.Text) > 0)
            {
                DialogResult r = CajaDialogo.Pregunta("Las cantidades seleccionadas no abastecen el total requerido!!\nDesea Guardar el avance seleccionado?");
                if (r != DialogResult.Yes)
                    return;
            }


            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("sp_set_delete_seleccion_lote_pt_plan", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_detalle_req", Pid_detalle);
                cmd1.ExecuteNonQuery();

                foreach (ds_despachos.detalle_lote_ptRow row in ds_despachos.detalle_lote_pt.Rows)
                {
                    if (row.seleccionado)
                    {
                        SqlCommand cmd = new SqlCommand("orden_venta_sp_insert_lotes_req_pt", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote_mp", row.lote_pt);
                        cmd.Parameters.AddWithValue("@id_detalle_req", Pid_detalle);
                        cmd.Parameters.AddWithValue("@cantidad", row.cants);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void txtSolicitada_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}