using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Mantenimientos.MateriaPrima.Models;
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
using static JAGUAR_APP.Mantenimientos.MateriaPrima.xfrmMateriasPrimas_Estado_CRUD;

namespace JAGUAR_APP.Mantenimientos.MateriaPrima
{
    public partial class xfrmMP_Tipo_Admin : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMP_Tipo_Admin()
        {
            InitializeComponent();
            ObtenerTiposMP();
        }

        private void ObtenerTiposMP()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.MP_Tipo.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getTipoMP", cnx);
                    da.Fill(dsMantenimiento.MP_Tipo);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                xfrmMateriasPrimas_Tipo_CRUD form = new xfrmMateriasPrimas_Tipo_CRUD((int)TipoTransaccion.Nuevo,0,"");
                form.EventoPasarId_tipo_inserted += new xfrmMateriasPrimas_Tipo_CRUD.get_tipo_inserted(Ejecutar);

                form.ShowDialog();

                //if (form.ShowDialog()== DialogResult.OK)
                //{
                //    ObtenerTiposMP();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void Ejecutar(int pIdInserted)
        {
            MP_Tipo tipo = new MP_Tipo();
            if (tipo.RecuperarRegistro(pIdInserted))
            {
                dsMantenimiento.MP_TipoRow row1 = dsMantenimiento.MP_Tipo.NewMP_TipoRow();
                row1.id = pIdInserted;
                row1.descripcion = tipo.Descripcion;


                dsMantenimiento.MP_Tipo.AddMP_TipoRow(row1);
                dsMantenimiento.AcceptChanges();
            }
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimiento.MP_TipoRow)gvEstado.GetFocusedDataRow();

                xfrmMateriasPrimas_Tipo_CRUD form= new xfrmMateriasPrimas_Tipo_CRUD((int)TipoTransaccion.Editar,row.id,row.descripcion);

                if (form.ShowDialog()== DialogResult.OK)
                {
                    ObtenerTiposMP();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
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
                        var row = (dsMantenimiento.MP_TipoRow)gvEstado.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DeleteTipoMP", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerTiposMP();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerTiposMP();
        }
    }


}