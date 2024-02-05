using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Panaderos.Models;
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

namespace JAGUAR_APP.Mantenimientos.Panaderos
{
    public partial class xfrmJAGUAR_Panaderos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        UserLogin usuarioLogueado = new UserLogin();

        public xfrmJAGUAR_Panaderos(UserLogin userLogged)
        {
            InitializeComponent();
            ObtenerPanaderos();
            usuarioLogueado = userLogged;
        }

        private void ObtenerPanaderos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.Panadero.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetJAGUAR_Panaderos", cnx);
                    da.Fill(dsMantenimiento.Panadero);

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
            xfrmJAGUAR_Panaderos_CRUD frm = new xfrmJAGUAR_Panaderos_CRUD((int)DataOperations.TipoTransaccionesCRUD.Nuevo,null,0,usuarioLogueado);
            frm.EventoPasarId_inserted += new xfrmJAGUAR_Panaderos_CRUD.get_panadero_inserted(Ejecutar);

            frm.ShowDialog();

            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    ObtenerPanaderos();
            //}
        }

        public void Ejecutar(int pIdInserted)
        {
            JAGUAR_Panadero panadero = new JAGUAR_Panadero();
            if (panadero.RecuperarRegistro(pIdInserted))
            {
                dsMantenimiento.PanaderoRow row1 = dsMantenimiento.Panadero.NewPanaderoRow();
                row1.id = pIdInserted;
                row1.nombre = panadero.Nombre;
                row1.codigo = panadero.Codigo;
                row1.FechaCreacion = panadero.FechaCreacion;
                row1.FechaModificacion = panadero.FechaModificacion;
                row1.UsuarioCreacion_id = panadero.UsuarioCreacionID;
                row1.usuario = panadero.UsuarioCreacion;


                dsMantenimiento.Panadero.AddPanaderoRow(row1);
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
                        var row = (dsMantenimiento.PanaderoRow)gvPanaderos.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_DisableJAGUAR_Panadero", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                            command.Parameters.Add("@user_id", SqlDbType.Int).Value = usuarioLogueado.Id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerPanaderos();
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
                var row = (dsMantenimiento.PanaderoRow)gvPanaderos.GetFocusedDataRow();


                xfrmJAGUAR_Panaderos_CRUD frm = new xfrmJAGUAR_Panaderos_CRUD((int)DataOperations.TipoTransaccionesCRUD.Editar,row.nombre,row.id,usuarioLogueado);
                if (frm.ShowDialog()== DialogResult.OK)
                {
                    ObtenerPanaderos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerPanaderos();
        }
    }
}