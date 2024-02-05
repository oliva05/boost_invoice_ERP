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
using JAGUAR_APP.Clases;
using JAGUAR_APP.AlmacenesExterno.Reporteria;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmSeleccionarTransferencia : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public xfrmSeleccionarTransferencia(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            switch (UsuarioLogeado.Idnivel)
            {
                case 1://Basic View
                    
                    break;
                case 2://Basic No Autorization
                    
                    break;
                case 3://Medium Autorization

                    break;
                case 4://Depth With Delta
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }
            load_data();
        }

        public void load_data()
        {
            DataOperations dp = new DataOperations();
            string query = @"sp_load_salida_externa_header_seleccion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsSalidasAlmacenesExternos1.Salida_Almacen_H_Seleccion.Clear();
                da.Fill(dsSalidasAlmacenesExternos1.Salida_Almacen_H_Seleccion);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public SalidaPlanExterno salid_plan = new SalidaPlanExterno();
        private void reposSeleccionado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            RowSelected();
        }

        private void gvTransferencia_DoubleClick(object sender, EventArgs e)
        {
            RowSelected();
        }

        private void RowSelected()
        {
            try
            {
                var gv = (GridView)gcTransferencia.FocusedView;
                var row = (dsSalidasAlmacenesExternos.Salida_Almacen_H_SeleccionRow)gv.GetDataRow(gv.FocusedRowHandle);

                salid_plan.Id_header = row.id;
                salid_plan.Id_ingreso = row.id_ingreso;
                salid_plan.DocEntry = row.DocEntry;
                salid_plan.id_mp = row.id_mp;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}