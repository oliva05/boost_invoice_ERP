using ACS.Classes;
using JAGUAR_APP.Mantenimientos.Modelos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmEstadoProgramacionRequisicion : Form
    {

        DataOperations dp = new DataOperations();
        public frmEstadoProgramacionRequisicion()
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
                    dsMantenimiento.EstadosProgramacionesRequisicionesDataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("exec spObtenerEstadosProgramacionesRequisiciones", conexionLOSA);
                    adapter.Fill(dsMantenimiento.EstadosProgramacionesRequisicionesDataTable);
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
            frmEstadoProgramacionRequisicionCRUD frm = new frmEstadoProgramacionRequisicionCRUD(new EstadoProgramacionRequisicion());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EstadoProgramacionRequisicion estadoProgramacionRequisicion = new EstadoProgramacionRequisicion
            {
                Id = Convert.ToInt32(gvEstadosProgramacionesRequisiciones.GetRowCellValue(gvEstadosProgramacionesRequisiciones.GetRowHandle(gvEstadosProgramacionesRequisiciones.GetSelectedRows()[0]), colid)),
                Descripcion = gvEstadosProgramacionesRequisiciones.GetRowCellValue(gvEstadosProgramacionesRequisiciones.GetRowHandle(gvEstadosProgramacionesRequisiciones.GetSelectedRows()[0]), coldescripcion).ToString(),
                Enable = Convert.ToBoolean(gvEstadosProgramacionesRequisiciones.GetRowCellValue(gvEstadosProgramacionesRequisiciones.GetRowHandle(gvEstadosProgramacionesRequisiciones.GetSelectedRows()[0]), colenable))
            };

            frmEstadoProgramacionRequisicionCRUD frm = new frmEstadoProgramacionRequisicionCRUD(estadoProgramacionRequisicion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}
