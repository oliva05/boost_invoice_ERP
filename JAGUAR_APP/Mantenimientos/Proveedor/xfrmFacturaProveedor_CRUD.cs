using ACS.Classes;
using DevExpress.XtraEditors;
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
    public partial class xfrmFacturaProveedor_CRUD : DevExpress.XtraEditors.XtraForm
    {
        int tipoTransaccion;
        FacturaProveedor factura = new FacturaProveedor();

        public delegate void get_inserted(int Id_inserted);
        public event get_inserted EventoPasarId_inserted;

        public xfrmFacturaProveedor_CRUD(int pTipoTransaccion, FacturaProveedor pFactura)
        {
            InitializeComponent();
            ObtenerProveedores();
            tipoTransaccion = pTipoTransaccion;
            factura = pFactura;
        }

        private void ObtenerProveedores()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.JAGUAR_Proveedor.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetProveedores", cnx);
                    da.Fill(dsMantenimiento.JAGUAR_Proveedor);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ObtenerCAI(int id_proveedor)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.CAI.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetJAGUAR_CAIByProveedor", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_proveedor",SqlDbType.Int).Value= id_proveedor;
                    da.Fill(dsMantenimiento.CAI);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                int id_inserted = 0;
                switch (tipoTransaccion)
                {
                    case (int)DataOperations.TipoTransaccionesCRUD.Nuevo:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.usp_InsertJAGUAR_ProveedorFactura_V2", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id_cai", SqlDbType.Int).Value = slueCAI.EditValue;
                            cmd.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = lueProveedor.EditValue;
                            cmd.Parameters.Add("@numero_factura", SqlDbType.VarChar).Value = txtFactura.Text;
                            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = deFecha.EditValue;
                            cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = factura.UserId;

                           id_inserted=Convert.ToInt32( cmd.ExecuteScalar());

                            CajaDialogo.Information("DATOS GUARDADOS");
                            EventoPasarId_inserted(id_inserted);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;

                    case (int)DataOperations.TipoTransaccionesCRUD.Editar:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("[dbo].[usp_UpdateJAGUAR_ProveedorFactura]", cnx);

                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@id_cai", SqlDbType.Int).Value = slueCAI.EditValue;
                            cmd2.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = lueProveedor.EditValue;
                            cmd2.Parameters.Add("@numero_factura", SqlDbType.VarChar).Value = txtFactura.Text;
                            cmd2.Parameters.Add("@fecha", SqlDbType.Date).Value = deFecha.EditValue;
                            cmd2.Parameters.Add("@id_user", SqlDbType.Int).Value = factura.UserId;
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = factura.ID;


                            cmd2.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS ACTUALIZADOS");
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void lueProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ObtenerCAI(Convert.ToInt32(lueProveedor.EditValue));
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xfrmFacturaProveedor_CRUD_Load(object sender, EventArgs e)
        {
            //if (tipoTransaccion==(int)DataOperations.TipoTransaccionesCRUD.Nuevo)
            //{
               
            //}


            if (tipoTransaccion == (int)DataOperations.TipoTransaccionesCRUD.Editar)
            {
                txtFactura.Text = factura.NumeroFactura;
                lueProveedor.EditValue = factura.ProveedorID;
                slueCAI.EditValue = factura.CAI_ID;
                deFecha.EditValue = factura.Fecha;
            }
        }
    }
}