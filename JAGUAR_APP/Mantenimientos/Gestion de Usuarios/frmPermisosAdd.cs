using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using ACS.Classes;

namespace PRININ.Gestion_de_Usuarios
{
    public partial class frmPermisosAdd : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int UserID; 

        public frmPermisosAdd(int pUserID)
        {
            InitializeComponent();
            UserID = pUserID;
            LoaData();
        }

        private void LoaData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
               
                string sql = @"SELECT 
		                        t1.id
		                        ,nombre
                                ,codigo
                                ,descripcion
                                ,t1.enable
	                        from [dbo].[USUARIOS_VENTANAS] t1
                            where t1.enable = 1 and t1.id NOT IN (Select t2.id_venta from [dbo].[USUARIOS_VENT_CONF] t2 where t2.id_usuario = @id )" +
                            "order by codigo asc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = UserID.ToString();
                dsUsers.permisos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsUsers.permisos.Clear();
                adat.Fill(dsUsers.permisos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in dsUsers.permisos.Rows)
            {
                item["checkcolumn"] = checkAll.Checked;
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;

            bool guardado = false;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow r = gridView1.GetDataRow(i);

                bool selec = false;
                try
                {
                    selec = Convert.ToBoolean(r["checkcolumn"]);
                }
                catch
                { }

                if (selec)
                {
                    int idV = Convert.ToInt32(r["id"]);
                    try
                    {
                        string sql = @"INSERT INTO 
                                              [ACS].[conf_usuarios]
                                            (
                                              id_usuario,
                                              id_venta
                                            )
                                            VALUES (
                                              @id_usuario,
                                              @id_venta
                                            )";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.Add("id_usuario", SqlDbType.Int).Value = UserID.ToString();
                        cmd.Parameters.Add("id_venta", SqlDbType.Int).Value = idV.ToString();
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}