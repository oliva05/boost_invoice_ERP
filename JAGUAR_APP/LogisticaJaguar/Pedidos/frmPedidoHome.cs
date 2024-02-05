using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace JAGUAR_APP.LogisticaJaguar.Pedidos
{
    public partial class frmPedidoHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmPedidoHome(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadDatos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void toggleSwitchVerTodas_Toggled(object sender, EventArgs e)
        {
            LoadDatos();
        }


        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.jaguar_sp_get_lista_pedidos_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todas", toggleSwitchVerTodas.IsOn);
                dsPedidos_PRD1.lista_pedidos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPedidos_PRD1.lista_pedidos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddPedidoPRD frm = new frmAddPedidoPRD(this.UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidos_PRD.lista_pedidosRow)gridView.GetFocusedDataRow();

            frmAddPedidoPRD frm = new frmAddPedidoPRD(this.UsuarioLogeado, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void cmdConfirmarPedido_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPedidos_PRD.lista_pedidosRow)gridView.GetFocusedDataRow();

            if (row.id_estado == 1)
            {
                DialogResult r = CajaDialogo.Pregunta("Esta seguro que desea pasar este pedido de Borrador a Confirmado?");
                if (r != DialogResult.Yes)
                    return;

                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_update_estado_pedido_produccion_ovejita", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pedido_h", row.id);
                    cmd.ExecuteNonQuery();
                    row.id_estado = 4;
                    PedidoH pedx = new PedidoH();
                    if (pedx.RecuperarRegistro(row.id))
                    {
                        row.NumDoc = pedx.DocNum;
                        row.comentario = pedx.Comentario;
                    }
                    row.estado_name = "Confirmado";
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else
            {
                CajaDialogo.Information("Solo pedidos en estado de Borrador se pueden confirmar!");
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }
    }
}