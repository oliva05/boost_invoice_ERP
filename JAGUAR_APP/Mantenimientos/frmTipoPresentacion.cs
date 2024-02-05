using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Mantenimientos.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmTipoPresentacion : Form
    {
        DataOperations dp = new DataOperations();
       public frmTipoPresentacion()
        {
            InitializeComponent();
            
            LoadPresentaciones();
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
                dsMantenimiento.Presentacion_tipo.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantenimiento.Presentacion_tipo);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        void CargarDatos()
        {
            try
            {
                using (SqlConnection conexionLOSA = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    dsMantenimiento.TiposPresentacionesDataTable.Clear();
                    SqlCommand cmd = new SqlCommand("dbo.spObtenerTiposPresentaciones_v2", conexionLOSA);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (string.IsNullOrEmpty(gridLookUpEditTipoPresentacion.Text))
                        cmd.Parameters.AddWithValue("@id_clase", 0);
                    else
                        cmd.Parameters.AddWithValue("@id_clase", gridLookUpEditTipoPresentacion.EditValue);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dsMantenimiento.TiposPresentacionesDataTable);
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
            frmTipoPresentacionCRUD frm = new frmTipoPresentacionCRUD(new TipoPresentacion());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gcTiposPresentaciones.FocusedView;
            var row = (dsMantenimiento.TiposPresentacionesDataTableRow)gridView.GetFocusedDataRow();
            TipoPresentacion tipoPresentacion = new TipoPresentacion
            {
                //Id = Convert.ToInt32(gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), colid)),
                //Descripcion = gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), coldescripcion).ToString(),
                //Enable = Convert.ToBoolean(gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), colenable)),
                //Factor = Convert.ToDecimal(gvTiposPresentaciones.GetFocusedRowCellValue(gvTiposPresentaciones.Columns[3]).ToString())
                Id = row.id,
                Descripcion = row.descripcion,
                Enable = row.enable,
                Factor = row.factor,
                IdTipo = row.id_clase
            };

            frmTipoPresentacionCRUD frm = new frmTipoPresentacionCRUD(tipoPresentacion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void gridLookUpEditTipoPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
