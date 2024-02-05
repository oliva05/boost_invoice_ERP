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
using JAGUAR_APP.Despachos;

namespace JAGUAR_APP.Reportes
{
    public partial class frm_Unir : DevExpress.XtraEditors.XtraForm
    {

        public int DocEntry;
        public int Id_despacho;
        DataOperations dp = new DataOperations();
        public frm_Unir(int Pid)
        {
            InitializeComponent();
            Id_despacho = Pid;
            //load_data();
        }


        //public void load_data()
        //{
        //    string query = @"";
        //    try
        //    {
        //        SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
        //        cn.Open();
        //        SqlCommand cmd = new SqlCommand(query, cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id", Id_despacho);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill();
        //    }
        //    catch (Exception ex)
        //    {

        //        CajaDialogo.Error(ex.Message);
        //    }
        //}
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PickOC_Click(object sender, EventArgs e)
        {
            frm_seleccionar frm = new frm_seleccionar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtdocnum.Text = frm.DocNUm.ToString();
                DocEntry = frm.docentry;

            }
        }
    }
}