using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using JAGUAR_APP.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.AlmacenesExterno.Salida_Almacen
{
    public partial class frmTransPendientes : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmTransPendientes(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }
        public void load_data() 
        {
            try
            {
                string qeury = @"sp_load_ingresos_externos_detalle_lote";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(qeury,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsAlmacenesExternos.transexterno.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsAlmacenesExternos.transexterno);
                cn.Close();
                

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRealizarIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsAlmacenesExternos.transexternoRow)gridView.GetFocusedDataRow();
                frmTipoIngreso_v2 frm = new frmTipoIngreso_v2(row.id, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            xfrmMovimientoStock frm = new xfrmMovimientoStock(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }
    }
}