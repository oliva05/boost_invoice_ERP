using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
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

namespace JAGUAR_APP.TransaccionesPT
{
    public partial class frmLotesxPT : DevExpress.XtraEditors.XtraForm
    {
        public string code, productoTerminado, ItemCode, lot_number;
        public int id_pt, id_presentacion;
        public decimal CostoUnitario;
        UserLogin UsuarioLogeado;
        
        /// <summary>
        /// 1= Lote desde Orden de Fabricacion, 2= Desde Lote nuevo creado manual
        /// </summary>
        public int IdTipoLote = 1;

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmLotePT_Cost frm = new frmLotePT_Cost(id_pt, UsuarioLogeado);
            frm.MdiParent = this.MdiParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                ProductoTerminado pt = new ProductoTerminado();
                if (pt.Recuperar_producto(id_pt))
                {
                    this.code = pt.Code;
                    this.productoTerminado = pt.Descripcion;
                    this.lot_number = frm.LotePT;
                    this.id_presentacion = pt.Id_presentacion;
                    this.CostoUnitario = frm.CostoUnitario;
                    this.IdTipoLote = 2;

                    this.DialogResult = DialogResult.OK;    
                    this.Close();
                }
            }
        }

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridLotePT.FocusedView;
            var row = (dsPT.kardex_pt_loteRow)gridView.GetFocusedDataRow();

            this.code = row.code;
            this.productoTerminado = row.pt;
            this.lot_number = row.lote;
            this.id_pt=row.id_pt;
            this.id_presentacion = row.id_presentacion;
            this.IdTipoLote = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gvLotePT_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridLotePT.FocusedView;
            var row = (dsPT.kardex_pt_loteRow)gridView.GetFocusedDataRow();

            this.code = row.code;
            this.productoTerminado = row.pt;
            this.lot_number = row.lote;
            this.id_presentacion = row.id_presentacion;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public frmLotesxPT(int pid_pt, UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            id_pt = pid_pt;
            UsuarioLogeado = pUsuarioLogeado;
            Load_Data();
        }

        public void Load_Data()
        {
            string Query = @"dbo.usp_get_Lote_PT_Kardex";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                dsPT1.kardex_pt_lote.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT1.kardex_pt_lote);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}