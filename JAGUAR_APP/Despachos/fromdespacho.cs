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
using DevExpress.XtraReports.UI;

namespace JAGUAR_APP.Despachos
{
    public partial class fromdespacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int idDetalle;
        string ItemCode;
        string ItemName;
        string CardCode;
        string CardName;
        int Cant_asignada;
        int cant_aenviar;
        int idSerial; // Numero de Serie de boleta
        int idboleta;
        decimal factor;
        public fromdespacho(UserLogin UsuarioLogeado, int detalle)
        {
            InitializeComponent();
            this.UsuarioLogeado = UsuarioLogeado;
            idDetalle = detalle;
            load_data();
            load_encabezado();
        }
        public void load_data()
        {
            string query = @"EXEC [dbo].[sp_load_req_entrada]
		                    @iddetalle = @iddetalle";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.Parameters.Add("@iddetalle", SqlDbType.Int).Value = idDetalle;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.lote_entregado.Clear();
                da.Fill(ds_despachos.lote_entregado);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
      
        public void load_encabezado()
        {
            string query = @"EXEC [dbo].[sp_load_info_encabezado_despacho]
		                    @iddetalle = @iddetalle";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@iddetalle", SqlDbType.Int).Value = idDetalle;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ItemCode = dr.GetString(0);
                    ItemName = dr.GetString(1);
                    Cant_asignada = dr.GetInt32(2);
                    cant_aenviar = dr.GetInt32(3);
                    factor = dr.GetDecimal(4);
                }
                dr.Close();
                cn.Close();
                txtItemCode.Text = ItemCode;
                txtItemName.Text = ItemName;
                txtcantidad.Text = String.Format("{0:###,##0.00}", Cant_asignada);
                txtcantidadEnviar.Text = String.Format("{0:###,##0.00}", cant_aenviar);
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

        private void fromdespacho_Load(object sender, EventArgs e)
        {

        }

       

        private void btnguardado_Click(object sender, EventArgs e)
        {

            int rows = 0;
            rows = ds_despachos.lote_entregado.Rows.Count;
            if (rows == 0)
            {
                CajaDialogo.Error("No hay tarimas para asignar a este despacho.");
                return;
            }
            if (txtboleta.Text == "")
            {
                CajaDialogo.Error("No se ha seleccionado ninguna boleta para enlazar.");
                return;
            }
            try
            {
                string query = @"EXEC [dbo].sp_insert_into_despacho
                                @iddetalle = @Viddetalle
                                ,@iduser = @VUsuario
	                            ,@CardCode = @Vcardcode
	                            ,@CardName = @Vcardname
	                            ,@idserie = @VidserieBol
	                            ,@idboleta = @VidBoleta
	                            ,@cantidad = @VCantidad
	                            ,@factor = @VFactor";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@Viddetalle", SqlDbType.Int).Value = idDetalle;
                cmd.Parameters.Add("@VUsuario", SqlDbType.Int).Value = UsuarioLogeado.Id;
                cmd.Parameters.Add("@Vcardcode", SqlDbType.VarChar).Value = CardCode;
                cmd.Parameters.Add("@Vcardname", SqlDbType.VarChar).Value = CardName;
                cmd.Parameters.Add("@VidserieBol", SqlDbType.Int).Value = idSerial;
                cmd.Parameters.Add("@VidBoleta", SqlDbType.Int).Value = idboleta;
                cmd.Parameters.Add("@VCantidad", SqlDbType.Int).Value = cant_aenviar;
                cmd.Parameters.Add("@VFactor", SqlDbType.Decimal).Value = factor;

               int result = Convert.ToInt32(cmd.ExecuteScalar());
                    Reportes.rpt_despacho cp = new Reportes.rpt_despacho(result);
                    cp.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(cp);
                    printReport.ShowPreview();
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnboleta_Click(object sender, EventArgs e)
        {
            frmloadboleta frm = new frmloadboleta();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idboleta = frm.IdBoleta;
                idSerial = frm.IdSerial;
                CardCode = frm.CardCode;
                CardName = frm.CardName;
                txtboleta.Text = idboleta.ToString();
                txtCardCode.Text = CardCode;
                txtCardName.Text = CardName;

            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}