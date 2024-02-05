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

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmDetalleIngresoAlmacenExterno : DevExpress.XtraEditors.XtraForm
    {
        int id;

        public xfrmDetalleIngresoAlmacenExterno(int pId)
        {
            InitializeComponent();
            id = pId;

            LoadDetailIngresosExternos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadDetailIngresosExternos()
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter("sp_get_ingresos_externos_d", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

                da.Fill(dsAlmacenesExternos.ingresos_externos_d);

                cnx.Close();
            }

        }

        private void btnVerLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)gcIngreso.FocusedView;
            var row = (dsAlmacenesExternos.ingresos_externos_dRow)gv.GetDataRow(gv.FocusedRowHandle);


            xfrmViewLotes frm = new xfrmViewLotes(row.id);

                frm.ShowDialog();
        }
    }
}