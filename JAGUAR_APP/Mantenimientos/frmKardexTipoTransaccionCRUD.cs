using ACS.Classes;
using Core.Clases.Herramientas;
using JAGUAR_APP.Mantenimientos.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmKardexTipoTransaccionCRUD : Form
    {
        DataOperations dp = new DataOperations();
        KardexTipoTransaccion kardexTipoTransaccion;
        public frmKardexTipoTransaccionCRUD()
        {
            InitializeComponent();
        }

        public frmKardexTipoTransaccionCRUD(KardexTipoTransaccion kardexTipoTransaccion)
        {
            this.kardexTipoTransaccion = kardexTipoTransaccion;
            InitializeComponent();
        }

        private void frmKardexTipoTransaccionCRUD_Load(object sender, EventArgs e)
        {
            memoDescripcion.Text = kardexTipoTransaccion.Descripcion;
            chkEnable.Checked = kardexTipoTransaccion.Enable;
        }
        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            kardexTipoTransaccion.Descripcion = memoDescripcion.Text;
            kardexTipoTransaccion.Enable = chkEnable.Checked;

            using (SqlConnection conexionJAGUAR_APP = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                try
                {
                    if (memoDescripcion.Text.Length <= 0)
                    {
                        CajaDialogo.Error("Debe de llenar todos los campos del formulario");
                        return;

                    }
                    else
                    {
                        conexionJAGUAR_APP.Open();
                        using (SqlCommand command = new SqlCommand("spInsertarActualizarKardexTiposTransacciones", conexionJAGUAR_APP))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = kardexTipoTransaccion.Id;
                            command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = kardexTipoTransaccion.Descripcion;
                            command.Parameters.Add("@Enable", SqlDbType.Bit).Value = kardexTipoTransaccion.Enable;
                            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = kardexTipoTransaccion.Fecha;
                            command.ExecuteNonQuery();

                            this.DialogResult = DialogResult.OK;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void memoDescripcion_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }
    }
}
