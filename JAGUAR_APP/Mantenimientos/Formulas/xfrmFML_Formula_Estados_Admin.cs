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
using static JAGUAR_APP.Mantenimientos.Formulas.xfrmFML_Formula_Estado_CRUD;

namespace JAGUAR_APP.Mantenimientos.Formulas
{
    public partial class xfrmFML_Formula_Estados_Admin : DevExpress.XtraEditors.XtraForm
    {
        public xfrmFML_Formula_Estados_Admin()
        {
            InitializeComponent();
            ObtenerEstadosMP();
        }

        private void ObtenerEstadosMP()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.FML_Estados.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getEstadosFML", cnx);
                    da.Fill(dsMantenimiento.FML_Estados);

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
            try
            {
                xfrmFML_Formula_Estado_CRUD form = new xfrmFML_Formula_Estado_CRUD((int)TipoTransaccion.Nuevo,0,"");

                if (form.ShowDialog()== DialogResult.OK)
                {
                    ObtenerEstadosMP();
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
                var row = (dsMantenimiento.FML_EstadosRow)gvEstado.GetFocusedDataRow();

                xfrmFML_Formula_Estado_CRUD form= new xfrmFML_Formula_Estado_CRUD((int)TipoTransaccion.Editar,row.id,row.descripcion);

                if (form.ShowDialog()== DialogResult.OK)
                {
                    ObtenerEstadosMP();
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
                        var row = (dsMantenimiento.FML_EstadosRow)gvEstado.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DeleteEstadoFML", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerEstadosMP();
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