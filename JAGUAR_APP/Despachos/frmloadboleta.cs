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
using JAGUAR_APP.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Despachos
{
    public partial class frmloadboleta : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int IdBoleta;
        public int IdSerial;
        public string CardCode;
        public string CardName;
        public frmloadboleta()
        {
            InitializeComponent();
            load_boleta_in_place();
        }
        public void load_boleta_in_place()
        {
            string query = @"EXEC [dbo].[sp_get_boletas_en_predio]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.boleta.Clear();
                da.Fill(ds_despachos.boleta);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnusar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_boleta.FocusedView;
                var row = (ds_despachos.boletaRow)gridview.GetFocusedDataRow();
                IdBoleta = row.NumID;
                IdSerial = row.id;
                CardCode = row.carcode;
                CardName = row.cardname;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}