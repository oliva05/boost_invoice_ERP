using System;
using System.Data;
using System.Windows.Forms;
using JAGUAR_APP.Mantenimientos.Modelos;
using System.Data.SqlClient;
using ACS.Classes;
using Core.Clases.Herramientas;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmBodegaCRUD : Form
    {
        DataOperations dp = new DataOperations();
        private Bodega bodega;
        CajaDialogo CajaDialogo = new CajaDialogo();
        public frmBodegaCRUD()
        {
            InitializeComponent();
        }

        public frmBodegaCRUD(Bodega bodega)
        {
            InitializeComponent();
            this.bodega = bodega;
        }

        private void frmBodegaCRUD_Load(object sender, EventArgs e)
        {
            memoDescripcion.Text = bodega.Descripcion;
            txtDescripcionCorta.Text = bodega.DescripcionCorta;
            chkEnable.Checked = bodega.Enable;
        }
        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bodega.Descripcion = memoDescripcion.Text;
            bodega.DescripcionCorta = txtDescripcionCorta.Text;
            bodega.Enable = chkEnable.Checked;

            using (SqlConnection conexionJAGUAR_APP = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                try
                {
                    if (txtDescripcionCorta.Text.Length <= 0 || memoDescripcion.Text.Length <= 0)
                        {
                        CajaDialogo.Error("Debe de llenar todos los campos del formulario");
                        return;
                       
                    }
                    else
                    {
                        conexionJAGUAR_APP.Open();
                        using (SqlCommand command = new SqlCommand("spInsertarActualizarBodegas", conexionJAGUAR_APP))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = bodega.Id;
                            command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = bodega.Descripcion;
                            command.Parameters.Add("@DescripcionCorta", SqlDbType.VarChar).Value = bodega.DescripcionCorta;
                            command.Parameters.Add("@Enable", SqlDbType.Bit).Value = bodega.Enable;
                            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = bodega.Fecha;
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

        private void txtDescripcionCorta_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }
    }
}
