using ACS.Classes;
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

namespace JAGUAR_APP.Despachos
{
    public partial class frmRequesicionesDetalle_PT : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int IdRequisicionHeader;
        public frmRequesicionesDetalle_PT(UserLogin pUsuarioLogeado, int pIdReqH)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            IdRequisicionHeader = pIdReqH;
            LoadDatos();
        }
        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_requisicion_detalle_pt]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req_header", IdRequisicionHeader);
                ds_despachos.requisiciones_d.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(ds_despachos.requisiciones_d);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
         //   Boton editar
            //var gridView = (GridView)grd_detalle.FocusedView;
            //var row = (ds_despachos.requisiciones_dRow)gridView.GetFocusedDataRow();
            //frmRequisicion_Seleccion_Lote frm = new frmRequisicion_Seleccion_Lote(UsuarioLogeado, row.id, row.id_materia_prima, row.solicitada, row.id_unidad_medida, row.unidad);
            //frm.WindowState = FormWindowState.Maximized;
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadDatos();
            //}
        }

        private void grdv_detalle_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)grd_detalle.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (ds_despachos.requisiciones_dRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.solicitada == row.asignado)
                    {
                        e.Appearance.BackColor = Color.FromArgb(113, 220, 200);
                    }
                    else
                    {
                        if (row.asignado > 0)
                        {
                            //
                            e.Appearance.BackColor = Color.FromArgb(255, 255, 192);
                        }
                        else
                        {
                            e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                }
            }
        }

        private void btndespacho_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_detalle.FocusedView;
                var row = (ds_despachos.requisiciones_dRow)gridview.GetFocusedDataRow();
                fromdespacho frm = new fromdespacho(UsuarioLogeado, row.id);
                frm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
           
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}