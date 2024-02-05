using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
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

namespace JAGUAR_APP.TransaccionesMP
{
    public partial class frmLotePorMP : DevExpress.XtraEditors.XtraForm
    {

        public string Lote;
        public int Id_Presentacion;
        private int Id_MP;

        string mp;
        string code;

        public frmLotePorMP(int pid_mp, string pMP,string pCode)
        {
            InitializeComponent();
            Id_MP = pid_mp;
            mp = pMP;
            code = pCode;
            cargarlotespormp();
        }

        private void cargarlotespormp()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                SqlCommand cmd = new SqlCommand("dbo.usp_get_Lote_by_MP", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                dsRecepcionMP.MP_por_lotes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMP.MP_por_lotes);
                cn.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcLotePorMP.FocusedView;
            var row = (dsRecepcionMP.MP_por_lotesRow)gridView.GetFocusedDataRow();
            this.Lote = row.lote;
            this.Id_Presentacion = row.id_presentacion;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gvMP_DoubleClick(object sender, EventArgs e)
        {

            var row = (dsRecepcionMP.MP_por_lotesRow)gvMP.GetFocusedDataRow();


            this.Lote = row.lote;
            this.Id_Presentacion = row.id_presentacion;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLotePorMP_Load(object sender, EventArgs e)
        {
            lblMP.Text = "MP: " +code+" - "+ mp;
        }
    }
}