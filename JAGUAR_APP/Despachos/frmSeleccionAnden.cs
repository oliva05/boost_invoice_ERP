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
using JAGUAR_APP.Despachos.Reportes;

namespace JAGUAR_APP.Despachos
{
    public partial class frmSeleccionAnden : DevExpress.XtraEditors.XtraForm
    {

        public int id_nueraReq;
        public int tipo = 0;
        DataOperations dp = new DataOperations();
        public frmSeleccionAnden()
        {
            InitializeComponent();

            load_infor();
            tipo = 1;
        }

        public frmSeleccionAnden(int Pid)
        {
            InitializeComponent();
            id_nueraReq = Pid;

            load_infor();
            tipo = 0;
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void load_infor() 
        {
            string query = @"sp_load_viewV2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.Anden_view.Clear();
                da.Fill(ds_despachos.Anden_view);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            
        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.Anden_viewRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {
                    

                    if (row.bit_cargando)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0, 112, 198);

                    }
                    else
                    {
                        e.Appearance.BackColor = Color.FromArgb(158, 219, 149);
                    }
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.Anden_viewRow)gridView.GetFocusedDataRow();
                if (row.bit_cargando)
                {
                    CajaDialogo.Error("No se puede cargar una requisa en un Anden que esta en proceso de cargando.");
                    return;
                }


                if (tipo == 0)
                {   //Esto es con id de requisa
                    string query = @"sp_set_change_requesa_anden";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_req", id_nueraReq);
                    cmd.Parameters.AddWithValue("@anden", row.numero);
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Information("Se asigno el camion al anden.");
                    cn.Close();
                    load_infor();
                    this.DialogResult = DialogResult.OK;

                }
                else
                {   //Seleccinar requisa

                    frmReq_view frm = new frmReq_view();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        id_nueraReq = frm.id_requisa;

                        string query = @"sp_set_change_requesa_anden";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_req", id_nueraReq);
                        cmd.Parameters.AddWithValue("@anden", row.numero);
                        cmd.ExecuteNonQuery();
                        CajaDialogo.Information("Se asigno el camion al anden.");
                        cn.Close();
                        load_infor();
                    }
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}