using ACS.Classes;
using JAGUAR_APP.Mantenimientos.Modelos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmEstadoRequisicion : Form
    {
        DataOperations dp = new DataOperations();
        public frmEstadoRequisicion()
        {
            InitializeComponent();
            CargarDatos();
        }

        void CargarDatos()
        {
            try
            {
                using (SqlConnection conexionLOSA = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    dsMantenimiento.EstadosRequisicionesDataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("exec spObtenerEstadosRequisiciones", conexionLOSA);
                    adapter.Fill(dsMantenimiento.EstadosRequisicionesDataTable);
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEstadoRequisicionCRUD frm = new frmEstadoRequisicionCRUD(new EstadoRequisicion());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EstadoRequisicion estadoRequisicion = new EstadoRequisicion
            {
                Id = Convert.ToInt32(gvEstadosRequisiciones.GetRowCellValue(gvEstadosRequisiciones.GetRowHandle(gvEstadosRequisiciones.GetSelectedRows()[0]), colid)),
                Descripcion = gvEstadosRequisiciones.GetRowCellValue(gvEstadosRequisiciones.GetRowHandle(gvEstadosRequisiciones.GetSelectedRows()[0]), coldescripcion).ToString(),
                Enable = Convert.ToBoolean(gvEstadosRequisiciones.GetRowCellValue(gvEstadosRequisiciones.GetRowHandle(gvEstadosRequisiciones.GetSelectedRows()[0]), colenable))
            };

            frmEstadoRequisicionCRUD frm = new frmEstadoRequisicionCRUD(estadoRequisicion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}
