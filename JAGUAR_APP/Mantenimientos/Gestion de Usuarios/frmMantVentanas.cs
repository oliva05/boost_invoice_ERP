using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Gestion_de_Usuarios;
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
    public partial class frmMantVentanas : Form
    {
        UserLogin UsuarioLogeado;
        public frmMantVentanas(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmAddVentana frm = new frmAddVentana(frmAddVentana.Accion.nuevo,0, this.UsuarioLogeado);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                load_data();
            }
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            load_data();
        }
        public void load_data()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = @"SELECT [id_ventana]
                                      ,[nombre]
                                      ,[codigo]
                                      ,[descripcion]
                                      ,[habilitada]
                                  FROM [JAGUAR_DB].[ACS].[conf_ventanas]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsMant_IT1.ventanas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMant_IT1.ventanas);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void frmMantVentanas_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //Ver la configuracion de la ventana
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMant_IT.ventanasRow)gridView.GetFocusedDataRow();
            frmAddVentana frm = new frmAddVentana(frmAddVentana.Accion.editar, row.id_ventana, this.UsuarioLogeado);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                load_data();
            }
        }

        private void ButtonFunciones_Click(object sender, EventArgs e)
        {
            ////Ver el detalle de funciones de la ventana
            ////var gridView = (GridView)gridControl1.FocusedView;
            ////var row = (dsMant_IT.ventanasRow)gridView.GetFocusedDataRow();
            ////frmVentanaFunciones frm = new frmVentanaFunciones(row.id_ventana);
            ////if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            ////{
            ////    load_data();
            ////}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
