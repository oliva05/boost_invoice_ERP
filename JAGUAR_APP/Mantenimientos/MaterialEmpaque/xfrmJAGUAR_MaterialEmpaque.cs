using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.MaterialEmpaque.Model;
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

namespace JAGUAR_APP.Mantenimientos.MaterialEmpaque
{
    public partial class xfrmJAGUAR_MaterialEmpaque : DevExpress.XtraEditors.XtraForm
    {


        UserLogin usuarioLogueado = new UserLogin();

        public xfrmJAGUAR_MaterialEmpaque(UserLogin user)
        {
            InitializeComponent();
            ObtenerMaterialesEmpaque();
            usuarioLogueado = user;
        }

        private void ObtenerMaterialesEmpaque()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.JAGUAR_MaterialEmpaque.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.udp_Get_JAGUAR_MaterialEmpaque", cnx);
                    da.Fill(dsMantenimiento.JAGUAR_MaterialEmpaque);

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
            xfrmJAGUAR_MaterialEmpaque_CRUD frm = new xfrmJAGUAR_MaterialEmpaque_CRUD((int)DataOperations.TipoTransaccionesCRUD.Nuevo,null,usuarioLogueado);
            frm.EventoPasarId_ME_inserted += new xfrmJAGUAR_MaterialEmpaque_CRUD.get_ME_inserted(Ejecutar);

            frm.ShowDialog();

            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    ObtenerMaterialesEmpaque();
            //}
        }

        public void Ejecutar(int pIdLataInserted)
        {
            Material_Empaque material_empaque = new Material_Empaque();

            if (material_empaque.RecuperaRegistro(pIdLataInserted))
            {
                dsMantenimiento.JAGUAR_MaterialEmpaqueRow row1 = dsMantenimiento.JAGUAR_MaterialEmpaque.NewJAGUAR_MaterialEmpaqueRow();
                row1.id = pIdLataInserted;
                row1.nombre = material_empaque.Material;
                row1.codigo = material_empaque.Codigo;
                row1.id_user = material_empaque.UserID;
                row1.usuario = material_empaque.Usuario;
                row1.id_presentacion = material_empaque.PresentacionID;
                row1.factor = material_empaque.Factor;
                row1.presentacion = material_empaque.Presentacion;
                row1.FechaCreacion = material_empaque.FechaCreacion;
                //row1.Fecha = material_empaque.FechaModificacion;


                dsMantenimiento.JAGUAR_MaterialEmpaque.AddJAGUAR_MaterialEmpaqueRow(row1);
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
                        var row = (dsMantenimiento.JAGUAR_MaterialEmpaqueRow)gvME.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_Disable_JAGUAR_MaterialEmpaque", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerMaterialesEmpaque();
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
                var row = (dsMantenimiento.JAGUAR_MaterialEmpaqueRow)gvME.GetFocusedDataRow();

                Material_Empaque material = new Material_Empaque();

                material.ID = row.id;
                material.Material = row.nombre;
                material.PresentacionID = row.id_presentacion;
                material.Codigo = row.codigo;

                xfrmJAGUAR_MaterialEmpaque_CRUD frm = new xfrmJAGUAR_MaterialEmpaque_CRUD((int)DataOperations.TipoTransaccionesCRUD.Editar,material,usuarioLogueado);
                if (frm.ShowDialog()== DialogResult.OK)
                {
                    ObtenerMaterialesEmpaque();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerMaterialesEmpaque();
        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gvME.ExportToXlsx(dialog.FileName);
        }
    }
}