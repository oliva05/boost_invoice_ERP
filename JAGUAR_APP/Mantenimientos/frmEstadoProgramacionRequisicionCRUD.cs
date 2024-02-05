using System;
using System.Data;
using System.Windows.Forms;
using JAGUAR_APP.Mantenimientos.Modelos;
using System.Data.SqlClient;
using ACS.Classes;
using Core.Clases.Herramientas;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmEstadoProgramacionRequisicionCRUD : Form
    {
        DataOperations dp = new DataOperations();
        private EstadoProgramacionRequisicion estadoProgramacionRequisicion;
        public frmEstadoProgramacionRequisicionCRUD()
        {
            InitializeComponent();
        }

        public frmEstadoProgramacionRequisicionCRUD(EstadoProgramacionRequisicion estadoProgramacionRequisicion)
        {
            InitializeComponent();
            this.estadoProgramacionRequisicion = estadoProgramacionRequisicion;
        }
        
        private void frmEstadoProgramacionRequisicionCRUD_Load(object sender, EventArgs e)
        {
            memoDescripcion.Text = estadoProgramacionRequisicion.Descripcion;
            chkEnable.Checked = estadoProgramacionRequisicion.Enable;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estadoProgramacionRequisicion.Descripcion = memoDescripcion.Text;
            estadoProgramacionRequisicion.Enable = chkEnable.Checked;

            using (SqlConnection conexionJAGUAR_APP = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                try
                {

                    if ( memoDescripcion.Text.Length <= 0)
                    {
                        CajaDialogo.Error("Debe de llenar todos los campos del formulario");
                        return;

                    }
                    else
                    {
                        conexionJAGUAR_APP.Open();
                        using (SqlCommand command = new SqlCommand("spInsertarActualizarEstadosProgramacionesRequisiciones", conexionJAGUAR_APP))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = estadoProgramacionRequisicion.Id;
                            command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = estadoProgramacionRequisicion.Descripcion;
                            command.Parameters.Add("@Enable", SqlDbType.Bit).Value = estadoProgramacionRequisicion.Enable;
                            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = estadoProgramacionRequisicion.Fecha;
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
