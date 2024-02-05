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
    public partial class xfrmMP_Estados_Admin : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMP_Estados_Admin()
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

                    dsMantenimiento.MP_Estados.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getEstadosMP", cnx);
                    da.Fill(dsMantenimiento.MP_Estados);

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
                xfrmMateriasPrimas_Estado_CRUD form = new xfrmMateriasPrimas_Estado_CRUD((int)TipoTransaccion.Nuevo,0,"");
                form.EventoPasarId_estado_inserted += new xfrmMateriasPrimas_Estado_CRUD.get_estado_inserted(Ejecutar);

                form.ShowDialog();
                //if (form.ShowDialog()== DialogResult.OK)
                //{
                //    ObtenerEstadosMP();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void Ejecutar(int pIdInserted)
        {
            MP_Estado estado = new MP_Estado();

            if (estado.RecuperarRegistro(pIdInserted))
            {
                dsMantenimiento.MP_EstadosRow row1 = dsMantenimiento.MP_Estados.NewMP_EstadosRow();
                row1.id = pIdInserted;
                row1.descripcion = estado.Descripcion;

                dsMantenimiento.MP_Estados.AddMP_EstadosRow(row1);
                dsMantenimiento.AcceptChanges();
            }
        }


        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimiento.MP_EstadosRow)gvEstado.GetFocusedDataRow();

                xfrmMateriasPrimas_Estado_CRUD form= new xfrmMateriasPrimas_Estado_CRUD((int)TipoTransaccion.Editar,row.id,row.descripcion);

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
                        var row = (dsMantenimiento.MP_EstadosRow)gvEstado.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DeleteEstadoMP", cnx))
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerEstadosMP();
        }
    }


}