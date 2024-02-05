using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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

namespace ACS.IT_Managment
{
    public partial class frmAddWindowToUser : Form
    {
        int UserID;
        public frmAddWindowToUser(int pUserID)
        {
            InitializeComponent();
            UserID = pUserID;
        }

        private void frmAddWindowToUser_Load(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = @"SELECT vv.[id_ventana]
		                                ,[nombre]
		                                ,[codigo]
		                                ,[descripcion]
		                                ,[habilitada]
                                FROM [ACS].[conf_ventanas] vv 
                                where vv.habilitada = 1 and vv.[id_ventana] not in (" +
                               "SELECT uu.id_ventana " +
                               "FROM [ACS].[conf_usuario_ventanas] uu " +
                               "where uu.id_usuario = " + UserID.ToString() + ")";
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsMant_IT1.view_user.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMant_IT1.view_user);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsMant_IT.ventanas_funcionesRow)gridView.GetFocusedDataRow();
            bool guardado = false;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            //foreach (dsMant_IT.view_userRow row in dsMant_IT1.view_user)
            {
                DataRow r = gridView1.GetDataRow(i);
                //..
                
                bool selec = false;
                try
                {
                    selec = Convert.ToBoolean(r["seleccionar"]);
                }
                catch{}
                //int idV = Convert.ToInt32(r["id_ventana"]);
                //if (row.seleccionar)
                if (selec)
                {
                    int idV = Convert.ToInt32(r["id_ventana"]);
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        string sql = @"INSERT INTO [ACS].[conf_usuario_ventanas]
                                                ([id_usuario]
                                                ,[id_ventana])
                                            VALUES
                                                (" + UserID.ToString() +
                                                        ", " + idV.ToString() + ")";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        guardado = true;
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
            }

            if (guardado)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void funciones_button_n_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chSeleccionar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
