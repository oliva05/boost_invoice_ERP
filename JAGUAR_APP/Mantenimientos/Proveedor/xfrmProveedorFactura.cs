using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Proveedor.Model;
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

namespace JAGUAR_APP.Mantenimientos.Proveedor
{
    public partial class xfrmProveedorFactura : DevExpress.XtraEditors.XtraForm
    {
        UserLogin user = new UserLogin();

        public xfrmProveedorFactura(UserLogin pUser)
        {
            InitializeComponent();
            user = pUser;
            ObtenerFacturas();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                FacturaProveedor factura = new FacturaProveedor();
                factura.UserId = user.Id;
                xfrmFacturaProveedor_CRUD frm = new xfrmFacturaProveedor_CRUD((int)DataOperations.TipoTransaccionesCRUD.Nuevo, factura);
                frm.EventoPasarId_inserted += new xfrmFacturaProveedor_CRUD.get_inserted(Ejecutar);

                frm.ShowDialog();
                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //    ObtenerFacturas();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void Ejecutar(int pIdInserted)
        {
            FacturaProveedor factura = new FacturaProveedor();
            if (factura.RecuperarRegistro(pIdInserted))
            {
                dsMantenimiento.Proveedor_FacturaRow row1 = dsMantenimiento.Proveedor_Factura.NewProveedor_FacturaRow();
                row1.id = pIdInserted;
                row1.id_cai = factura.CAI_ID;
                row1.cai = factura.CAI;
                row1.id_proveedor = factura.ProveedorID;
                row1.proveedor = factura.Proveedor;
                row1.NumeroFactura = factura.NumeroFactura;
                row1.fecha = factura.Fecha;
                row1.id_user = factura.UserId;
                row1.Usuario = factura.User;
                row1.FechaInicio = factura.FechaInicio;
                row1.FechaLimite = factura.FechaFin;

                dsMantenimiento.Proveedor_Factura.AddProveedor_FacturaRow(row1);
                dsMantenimiento.AcceptChanges();
            }
        }

        private void ObtenerFacturas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.Proveedor_Factura.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetJAGUAR_ProveedorFactura", cnx);
                    da.Fill(dsMantenimiento.Proveedor_Factura);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FacturaProveedor factura = new FacturaProveedor();

                var row = (dsMantenimiento.Proveedor_FacturaRow)gvFactura.GetFocusedDataRow();

                factura.CAI_ID = row.id_cai;
                factura.NumeroFactura = row.NumeroFactura;
                factura.ProveedorID = row.id_proveedor;
                factura.Fecha = row.fecha;
                factura.UserId = row.id_user;
                factura.ID = row.id;

                xfrmFacturaProveedor_CRUD frm = new xfrmFacturaProveedor_CRUD((int)DataOperations.TipoTransaccionesCRUD.Editar, factura);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ObtenerFacturas();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Deseas eliminar este registro?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    var row = (dsMantenimiento.Proveedor_FacturaRow)gvFactura.GetFocusedDataRow();


                    SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                    using (SqlCommand command = new SqlCommand("dbo.usp_DisableJAGUAR_ProveedorFactura", cnx))
                    {
                        cnx.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                        command.ExecuteNonQuery();
                        cnx.Close();

                        ObtenerFacturas();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerFacturas();
        }
    }
}