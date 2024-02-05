using System;
using System.Data;
using System.Windows.Forms;
using JAGUAR_APP.Mantenimientos.Modelos;
using System.Data.SqlClient;
using ACS.Classes;
using Core.Clases.Herramientas;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmTipoPresentacionCRUD : Form
    {
        DataOperations dp = new DataOperations();
        private TipoPresentacion tipoPresentacion;
        public frmTipoPresentacionCRUD()
        {
            InitializeComponent();
            LoadPresentaciones();
        }

        public frmTipoPresentacionCRUD(TipoPresentacion tipoPresentacion)
        {
            InitializeComponent();
            LoadPresentaciones();
            this.tipoPresentacion = tipoPresentacion;
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_tipo_presentaciones_clase", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMantenimiento1.Presentacion_tipo.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantenimiento1.Presentacion_tipo);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void frmTipoPresentacionCRUD_Load(object sender, EventArgs e)
        {
            txtDescripcionPresentacion.Text = tipoPresentacion.Descripcion;
            toggleSwitchEnable.IsOn = tipoPresentacion.Enable;
            txtFactor.Text = tipoPresentacion.Factor.ToString();
            gridLookUpEditTipoPresentacion.EditValue = tipoPresentacion.IdTipo;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gridLookUpEditTipoPresentacion.Text))
            {
                CajaDialogo.Error("Es necesario elejir un Tipo de Presentación!");
                return;
            }

            tipoPresentacion.Descripcion = txtDescripcionPresentacion.Text;
            tipoPresentacion.Enable = toggleSwitchEnable.IsOn;
            tipoPresentacion.Factor = Convert.ToDecimal(txtFactor.Text);

            using (SqlConnection conexionJAGUAR_APP = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                try
                {
                    if (txtDescripcionPresentacion.Text.Length <= 0)
                    {
                        CajaDialogo.Error("Debe de llenar todos los campos del formulario");
                        return;

                    }
                    else
                    {
                        conexionJAGUAR_APP.Open();
                        using (SqlCommand command = new SqlCommand("dbo.spInsertarActualizarTiposPresentaciones_v2", conexionJAGUAR_APP))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = tipoPresentacion.Id;
                            command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoPresentacion.Descripcion;
                            command.Parameters.Add("@Enable", SqlDbType.Bit).Value = tipoPresentacion.Enable;
                            //command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = tipoPresentacion.Fecha;
                            command.Parameters.Add("@factor", SqlDbType.Decimal).Value = tipoPresentacion.Factor;
                            command.Parameters.AddWithValue("@id_tipo",  gridLookUpEditTipoPresentacion.EditValue);
                            command.ExecuteNonQuery();

                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void memoDescripcion_EditValueChanged(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void TextEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //  else
            //{
            //    e.Handled = true;
            //}
        }

        private void frmTipoPresentacionCRUD_Activated(object sender, EventArgs e)
        {
            txtDescripcionPresentacion.Focus();
        }

        private void txtDescripcionPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                txtFactor.Focus();
        }

        private void txtFactor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gridLookUpEditTipoPresentacion.Focus();
        }

        private void gridLookUpEditTipoPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGuardar.Focus();
        }
    }
}