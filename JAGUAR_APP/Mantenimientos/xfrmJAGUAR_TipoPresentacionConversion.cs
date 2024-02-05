using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Modelos;
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

namespace JAGUAR_APP.Mantenimientos
{
    public partial class xfrmJAGUAR_TipoPresentacionConversion : DevExpress.XtraEditors.XtraForm
    {


        public xfrmJAGUAR_TipoPresentacionConversion()
        {
            InitializeComponent();
            ObtenerConversiones();
            //usuarioLogueado = userLogged;
        }

        private void ObtenerConversiones()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.Conversiones.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getConversionesTipoPresentacion", cnx);
                    da.Fill(dsMantenimiento.Conversiones);

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
            xfrmJAGUAR_TipoPresentacionConversion_CRUD frm = new xfrmJAGUAR_TipoPresentacionConversion_CRUD((int)DataOperations.TipoTransaccionesCRUD.Nuevo,0,0,0);
            frm.EventoPasarId_tipo_inserted += new xfrmJAGUAR_TipoPresentacionConversion_CRUD.get_tipo_inserted(Ejecutar);

            frm.ShowDialog();
        }

        public void Ejecutar(int pIdInserted)
        {
            TipoPresentacionConversion tipoConversion = new TipoPresentacionConversion();
            if (tipoConversion.RecuperarRegistro(pIdInserted))
            {
                dsMantenimiento.ConversionesRow row1 = dsMantenimiento.Conversiones.NewConversionesRow();
                row1.idConversion = pIdInserted;
                row1.id_presentacion_origen = tipoConversion.PresentacionOrigenID;
                row1.id_presentacion_destino = tipoConversion.PresentacionDestinoID;
                row1.Presentacion_Origen = tipoConversion.PresentacionOrigen;
                row1.Presentacion_Destino = tipoConversion.PresentacionDestino;
                row1.factor = tipoConversion.Factor;


                dsMantenimiento.Conversiones.AddConversionesRow(row1);
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
                        var row = (dsMantenimiento.ConversionesRow)gvConversion.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DisableConversionTipoPresentacion", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.idConversion;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerConversiones();
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
                var row = (dsMantenimiento.ConversionesRow)gvConversion.GetFocusedDataRow();


                xfrmJAGUAR_TipoPresentacionConversion_CRUD frm = new xfrmJAGUAR_TipoPresentacionConversion_CRUD((int)DataOperations.TipoTransaccionesCRUD.Editar,row.id_presentacion_origen,row.id_presentacion_destino,row.factor);
                if (frm.ShowDialog()== DialogResult.OK)
                {
                    ObtenerConversiones();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}