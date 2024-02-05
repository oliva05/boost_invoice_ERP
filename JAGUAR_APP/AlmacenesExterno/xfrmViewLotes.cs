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
using System.Data.SqlClient;
using ACS.Classes;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmViewLotes : DevExpress.XtraEditors.XtraForm
    {
        int id_detalle = 0;

        public xfrmViewLotes(int pId_detalle)
        {
            InitializeComponent();
            id_detalle = pId_detalle;
            LoadLotes();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadLotes()
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                cnx.Open();
                dsAlmacenesExternos.Lotes_view.Clear();

                SqlDataAdapter da = new SqlDataAdapter("sp_get_ingreso_externos_lotes", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id_detalle", SqlDbType.Int).Value = id_detalle;

                da.Fill(dsAlmacenesExternos.Lotes_view);

                cnx.Close();
            }

        }
    }
}