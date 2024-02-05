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

namespace JAGUAR_APP.AlmacenesExterno.AjusteInvAlmaExterno
{
    public partial class frmAddAjusteAlmacenExterno : DevExpress.XtraEditors.XtraForm
    {
        int IdUsuarioLogeado;
        LoteAlmacenExternoD LoteActual;
        DataOperations dp;
        public frmAddAjusteAlmacenExterno(LoteAlmacenExternoD pLote, int pIdUsuario)
        {
            InitializeComponent();
            dp = new DataOperations();
            LoteActual = pLote;
            IdUsuarioLogeado = pIdUsuario;
            txtMateriaPrimaName.Text = pLote.codigoMp + " - " + pLote.mpNombre;
            txtLoteMP.Text = pLote.lote;

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdguardar_Click(object sender, EventArgs e)
        {
            if (dp.ValidateNumberDecimal(spinEditPesoKg.EditValue) <= 0)
            {
                CajaDialogo.Error("Es necesario ingresar Kg mayores a Cero!");
                return;
            }
            if (dp.ValidateNumberDecimal(spinEditUnidades.EditValue) <= 0)
            {
                CajaDialogo.Error("Es necesario ingresar Unidades mayores a Cero!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de realizar este ajuste?");
            if (r != DialogResult.Yes)
                return;
            bool Guardo = false;
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_insert_ajuste_mp_almacen_externo_", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@peso", spinEditPesoKg.EditValue);
                cmd.Parameters.AddWithValue("@unidades", spinEditUnidades.EditValue);
                cmd.Parameters.AddWithValue("@user_creador", IdUsuarioLogeado);
                cmd.Parameters.AddWithValue("@id_mp", LoteActual.id_mp);
                
                if(LoteActual.id_lote_externo == 0)
                    cmd.Parameters.AddWithValue("@id_lote_externo", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_lote_externo", LoteActual.id_lote_externo);

                if(LoteActual.id_detalle == 0)
                    cmd.Parameters.AddWithValue("@id_detalle", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_detalle", LoteActual.id_detalle);

                if(LoteActual.id_presentacion == 0)
                    cmd.Parameters.AddWithValue("@id_presentacion", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_presentacion", LoteActual.id_presentacion);
                
                if(string.IsNullOrEmpty(LoteActual.BodegaIn))
                    cmd.Parameters.AddWithValue("@bodega_in", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@bodega_in", LoteActual.BodegaIn);
                
                if(LoteActual.id_ingreso_lote == 0)
                    cmd.Parameters.AddWithValue("@id_ingreso_lote", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_ingreso_lote", LoteActual.id_ingreso_lote);
                cmd.ExecuteNonQuery();
                Guardo = true;

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


            if (Guardo)
            {
                CajaDialogo.InformationAuto();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}