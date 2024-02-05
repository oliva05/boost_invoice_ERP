using ACS.Classes;
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

namespace JAGUAR_APP.TransaccionesMP
{
    public partial class frmLogKardex : DevExpress.XtraEditors.XtraForm
    {
        int id_mp;
        string lote;
        int id_bodega;

        public frmLogKardex(int pid_mp, string plote, int pid_bodega)
        {
            InitializeComponent();

            id_mp = pid_mp;
            lote = plote;
            id_bodega = pid_bodega;

            LoadBodegaMP();
        }

        private void LoadBodegaMP()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_load_kardex_for_mp_lote_and_bodega", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                cmd.Parameters.AddWithValue("@lote", lote);
                cmd.Parameters.AddWithValue("@id_bodega", id_bodega);
                dsReportesInventario.LogKardex_MP.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesInventario.LogKardex_MP);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}