using ACS.Classes;
using DevExpress.XtraEditors;
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
using static JAGUAR_APP.Mantenimientos.Formulas.xfrmFormulas_Tipo_CRUD;

namespace JAGUAR_APP.Mantenimientos.Formulas
{
    public partial class xfrmMP_Tipo_Formula_Admin : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMP_Tipo_Formula_Admin()
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

                    dsMantenimiento.FML_Tipo.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getTipo_FML", cnx);
                    da.Fill(dsMantenimiento.FML_Tipo);

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
                xfrmFormulas_Tipo_CRUD form = new xfrmFormulas_Tipo_CRUD((int)TipoTransaccion.Nuevo,0,"");

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

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimiento.FML_TipoRow)gvTipoFML.GetFocusedDataRow();

                xfrmFormulas_Tipo_CRUD form= new xfrmFormulas_Tipo_CRUD((int)TipoTransaccion.Editar,row.id,row.descripcion);

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
                        var row = (dsMantenimiento.FML_TipoRow)gvTipoFML.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DeleteTipo_FML", cnx))
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
    }


}