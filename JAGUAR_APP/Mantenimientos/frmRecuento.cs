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
using JAGUAR_APP.Clases;
using System.Data.SqlClient;

namespace JAGUAR_APP.Mantenimientos
{

    
    public partial class frmRecuento : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmRecuento(UserLogin User)
        {
            InitializeComponent();
            UsuarioLogeado = User;
            load_data();
        }
        public void load_data()
        {
            string Query = @"sp_load_inventario_ajustar";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimiento.Ajuste.Clear();
                da.Fill(dsMantenimiento.Ajuste);
                cn.Close();
               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}