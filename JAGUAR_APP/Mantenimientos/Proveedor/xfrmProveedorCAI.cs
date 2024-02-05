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
    public partial class xfrmProveedorCAI : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public xfrmProveedorCAI(UserLogin pUserLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogeado;
            ObtenerCAI();
        }

        private void ObtenerCAI()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.CAI.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetJAGUAR_ProveedorCAI", cnx);
                    da.Fill(dsMantenimiento.CAI);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            xfrmProveedorCAI_CRUD frm = new xfrmProveedorCAI_CRUD((int)DataOperations.TipoTransaccionesCRUD.Nuevo,null, this.UsuarioLogeado);
            frm.EventoPasarId_cai_inserted += new xfrmProveedorCAI_CRUD.get_cai_inserted(Ejecutar);

            frm.ShowDialog();

            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    ObtenerCAI();
            //}
        }

        public void Ejecutar(int pIdInserted)
        {
            Proveedor_CAI cai = new Proveedor_CAI();
            if (cai.RecuperarRegistro(pIdInserted))
            {
                dsMantenimiento.CAIRow row1 = dsMantenimiento.CAI.NewCAIRow();
                row1.id = pIdInserted;
                row1.CAI = cai.CAI;
                row1.FechaInicio = cai.FechaInicio;
                row1.FechaLimite = cai.FechaFin;
                row1.CorrelativoDesde = cai.CorrelativoInicia;
                row1.CorrelativoHasta = cai.CorrelativoTermina;
                row1.Leyenda = cai.Leyenda;
                row1.id_proveedor = cai.ProveedorID;
                row1.proveedor = cai.Proveedor;


                dsMantenimiento.CAI.AddCAIRow(row1);
                dsMantenimiento.AcceptChanges();
            }
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Deseas eliminar este registro?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        var row = (dsMantenimiento.CAIRow)gvProveedor.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DisableCAIByProveedor", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerCAI();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Proveedor_CAI cai = new Proveedor_CAI();
                var row = (dsMantenimiento.CAIRow)gvProveedor.GetFocusedDataRow();

                cai.CAI = row.CAI;
                cai.CorrelativoInicia = row.CorrelativoDesde;
                cai.CorrelativoTermina = row.CorrelativoHasta;
                cai.FechaInicio = row.FechaInicio;
                cai.FechaFin = row.FechaLimite;
                cai.Leyenda = row.Leyenda;
                cai.ProveedorID = row.id_proveedor;
                cai.ID = row.id;

                xfrmProveedorCAI_CRUD xfrm = new xfrmProveedorCAI_CRUD((int)DataOperations.TipoTransaccionesCRUD.Editar,cai, this.UsuarioLogeado);

                if (xfrm.ShowDialog()== DialogResult.OK)
                {
                    ObtenerCAI();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerCAI();
        }
    }
}