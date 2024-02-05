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
using System.Data.SqlClient;
using JAGUAR_APP.AlmacenesExterno.Models;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.AlmacenesExterno
{
    public partial class xfrmBuscarMP_Ingresos_Externos : DevExpress.XtraEditors.XtraForm
    {
        public xfrmBuscarMP_Ingresos_Externos()
        {
            InitializeComponent();
            CargarData();
        }
    
    private void CargarData()
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                cnx.Open();

                dsAlmacenesExternos.MP_Almacen_Externo_Existente.Clear();
                SqlDataAdapter da = new SqlDataAdapter("sp_almacenes_externos_mp_existente",cnx);
                da.Fill(dsAlmacenesExternos.MP_Almacen_Externo_Existente);
                cnx.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public   Materia_Prima_Transferencia materia_Prima_Transferencia = new Materia_Prima_Transferencia();
        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {

                var gv = (GridView)gcIngreso.FocusedView;
                var row = (dsAlmacenesExternos.MP_Almacen_Externo_ExistenteRow)gv.GetDataRow(gv.FocusedRowHandle);


                materia_Prima_Transferencia.CodeItem = row.itemcode;
                materia_Prima_Transferencia.CodeName = row.itemName;
                materia_Prima_Transferencia.Peso = row.peso;
                materia_Prima_Transferencia.Unidades = row.unidades;
                
                

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }
    }
}