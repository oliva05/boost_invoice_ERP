using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace JAGUAR_APP.JaguarProduccion
{
    public partial class frmHomeAvanceProduccion : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public event EventHandler Aplicar;
        public frmHomeAvanceProduccion(UserLogin pUserLogin)
        {
            InitializeComponent();
            this.UsuarioLogeado = pUserLogin;
            dp = new DataOperations();
            DateTime FechaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime FechaFinal = FechaInicial.AddHours(23);
            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;

            LoadDataHome();
        }

        public void InvocarAplicar()
        {
            this.Aplicar?.Invoke(this, EventArgs.Empty);
        }
        public void Aplicar_Click(object sender, EventArgs e)
        {
            InvocarAplicar();
        }

        private void LoadDataHome()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.[sp_get_lista_avances_de_orden_fabricacion_latas_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsProduccion1.avance_produccion_latas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProduccion1.avance_produccion_latas); 
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            LoadDataHome();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar nueva entrada de latas


            frmAddAvanceProduccion frm = new frmAddAvanceProduccion(this.UsuarioLogeado, 0);
            frm.EventoPasarId_Lata_inserted += new frmAddAvanceProduccion.get_latas_inserted(Ejecutar);
            frm.Show();
        }

        public void Ejecutar(Int64 pIdLataInserted)
        {
            //CajaDialogo.Information(pIdLataInserted.ToString());
            LatasProduccion lata1 = new LatasProduccion();
            if (lata1.RecuperarRegistro(pIdLataInserted))
            {
                dsProduccion.avance_produccion_latasRow row1 = dsProduccion1.avance_produccion_latas.Newavance_produccion_latasRow();
                //dsCompras.oc_d_normalRow row1 = dsCompras1.oc_d_normal.Newoc_d_normalRow();
                row1.id = pIdLataInserted;
                row1.id_orden = lata1.id_orden;
                row1.id_pt = lata1.id_pt;
                row1.ItemCode = lata1.ItemCode;
                row1.ItemName = lata1.ItemName;
                row1.cantidad_latas = lata1.cantidad_latas;
                row1.enable = lata1.enable;
                row1.fecha_hora = lata1.fecha_hora;
                row1.id_user = lata1.id_user;
                row1.UsuarioName = lata1.UsuarioName;
                row1.DocNum = lata1.DocNum;

                dsProduccion1.avance_produccion_latas.Addavance_produccion_latasRow(row1);
                //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                dsProduccion1.AcceptChanges();
                //dsCompras.AcceptChanges();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadDataHome();
        }
    }

}