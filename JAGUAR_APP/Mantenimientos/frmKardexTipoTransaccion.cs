using ACS.Classes;
using JAGUAR_APP.Mantenimientos.Modelos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmKardexTipoTransaccion : Form
    {
        DataOperations dp= new DataOperations();
        public frmKardexTipoTransaccion()
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
                    dsMantenimiento.KardexTiposTransaccionesDataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("exec spObtenerKardexTiposTransacciones", conexionLOSA);
                    adapter.Fill(dsMantenimiento.KardexTiposTransaccionesDataTable);
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
            frmKardexTipoTransaccionCRUD frm = new frmKardexTipoTransaccionCRUD(new KardexTipoTransaccion());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            KardexTipoTransaccion kardexTipoTransaccion = new KardexTipoTransaccion
            {
                Id = Convert.ToInt32(gvKardexTiposTransacciones.GetRowCellValue(gvKardexTiposTransacciones.GetRowHandle(gvKardexTiposTransacciones.GetSelectedRows()[0]), colid)),
                Descripcion = gvKardexTiposTransacciones.GetRowCellValue(gvKardexTiposTransacciones.GetRowHandle(gvKardexTiposTransacciones.GetSelectedRows()[0]), coldescripcion).ToString(),
                Enable = Convert.ToBoolean(gvKardexTiposTransacciones.GetRowCellValue(gvKardexTiposTransacciones.GetRowHandle(gvKardexTiposTransacciones.GetSelectedRows()[0]), colenable))
            };

            frmKardexTipoTransaccionCRUD frm = new frmKardexTipoTransaccionCRUD(kardexTipoTransaccion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}
