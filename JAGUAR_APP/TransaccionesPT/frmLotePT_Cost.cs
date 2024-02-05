using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Export.Doc;
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
    public partial class frmLotePT_Cost : DevExpress.XtraEditors.XtraForm
    {
        int Id_pt;
        UserLogin UsuarioLogeado;
        public string LotePT;
        public decimal CostoUnitario;

        public frmLotePT_Cost(int id_pt, UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            Id_pt = id_pt;
            UsuarioLogeado = pUsuarioLogeado;
            GenerarLoteAuto();
        }

        private void GenerarLoteAuto()
        {
            TablesId tablesId = new TablesId();
            if (tablesId.RecuperarSiguienteCodigoFromId_table(23))
            {
                txtLoteAutomatico.Text = tablesId.NextCode;
            }
        }

        private void chk_lote_propio_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lote_propio.Checked)
            {
                chk_Auto.EditValueChanged -= new EventHandler(chk_Auto_EditValueChanged);
                chk_Auto.Checked = false;
                chk_Auto.EditValueChanged += new EventHandler(chk_Auto_EditValueChanged);
            }
        }

        private void chk_Auto_EditValueChanged(object sender, EventArgs e)
        {
            if (chk_lote_propio.Checked)
            {
                chk_lote_propio.EditValueChanged -= new EventHandler(chk_lote_propio_CheckedChanged);
                chk_lote_propio.Checked = false;
                chk_lote_propio.EditValueChanged += new EventHandler(chk_lote_propio_CheckedChanged);
            }
        }

        private void txtLotePropio_EditValueChanged(object sender, EventArgs e)
        {
            if(txtLotePropio.Text.Length > 0)
            {
                if (txtLotePropio.Text.Length < 4)
                {
                    errorProvider1.SetError(txtLotePropio, "El Lote debe tener al menos 4 caracteres de longitud!");
                    txtLotePropio.Focus();
                }
                else
                {
                    if (validarLoteExiste(txtLotePropio.Text))
                    {
                        errorProvider1.SetError(txtLotePropio, "Este numero o nombre de lote ya existe! debe ingrear un lote diferente!");
                        txtLotePropio.Focus();
                    }
                    else
                    {
                        errorProvider1.Clear();

                        chk_Auto.EditValueChanged -= new EventHandler(chk_Auto_EditValueChanged);
                        chk_Auto.Checked = false;
                        chk_Auto.EditValueChanged += new EventHandler(chk_Auto_EditValueChanged);

                        chk_lote_propio.EditValueChanged -= new EventHandler(chk_lote_propio_CheckedChanged);
                        chk_lote_propio.Checked = true;
                        chk_lote_propio.EditValueChanged += new EventHandler(chk_lote_propio_CheckedChanged);
                    }
                }
            }
        }

        private bool validarLoteExiste(string pLoteName)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_valida_lote_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", Id_pt);
                cmd.Parameters.AddWithValue("@lote", pLoteName);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r = dr.GetBoolean(0);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            CostoUnitario = spinEdit1.Value;

            if(CostoUnitario<=0)
            {
                CajaDialogo.Error("Es necesario indicar el costo unitario para efectuar el ajuste!");
                return;
            }

            if(chk_Auto.Checked)
            {
                LotePT = txtLoteAutomatico.Text;
            }
            else
            {
                LotePT = txtLotePropio.Text;
            }

            if(LotePT.Length < 4)
            {
                CajaDialogo.Error("Es necesario indicar un lote con al menos 4 caracteres!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}