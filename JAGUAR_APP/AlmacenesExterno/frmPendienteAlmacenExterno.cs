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
using JAGUAR_APP.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class frmPendienteAlmacenExterno : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmPendienteAlmacenExterno(UserLogin puser)
        {
            InitializeComponent();
            UsuarioLogeado = puser;
            load_data();


        }

        public void load_data()
        {
            string Query = @"id_informacion_data_almacenada";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsAlmacenesExternos.informacion.Clear();
                da.Fill(dsAlmacenesExternos.informacion);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsAlmacenesExternos.informacionRow)gridView.GetFocusedDataRow();
                frmShowResum frm = new frmShowResum(UsuarioLogeado, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}