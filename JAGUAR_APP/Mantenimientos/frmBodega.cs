using ACS.Classes;
using JAGUAR_APP.Mantenimientos.Modelos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmBodega : Form
    {
        DataOperations dp = new DataOperations();
        public frmBodega()
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
                    dsMantenimiento.BodegasDataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("exec spObtenerBodegas", conexionLOSA);
                    adapter.Fill(dsMantenimiento.BodegasDataTable);
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
            frmBodegaCRUD frm = new frmBodegaCRUD(new Bodega());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Bodega bodega = new Bodega
            {
                Id = Convert.ToInt32(gvBodegas.GetRowCellValue(gvBodegas.GetRowHandle(gvBodegas.GetSelectedRows()[0]), colid)),
                Descripcion = gvBodegas.GetRowCellValue(gvBodegas.GetRowHandle(gvBodegas.GetSelectedRows()[0]), coldescripcion).ToString(),
                DescripcionCorta = gvBodegas.GetRowCellValue(gvBodegas.GetRowHandle(gvBodegas.GetSelectedRows()[0]), coldescripcion_corta).ToString(),
                Enable = Convert.ToBoolean(gvBodegas.GetRowCellValue(gvBodegas.GetRowHandle(gvBodegas.GetSelectedRows()[0]), colenable))
            };

            frmBodegaCRUD frm = new frmBodegaCRUD(bodega);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}