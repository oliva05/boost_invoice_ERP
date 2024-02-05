using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Clientes.Models;
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

namespace JAGUAR_APP.Mantenimientos.MateriaPrima
{
    public partial class xfrmMasterMP_Admin : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLoguado = new UserLogin();

        public xfrmMasterMP_Admin( UserLogin user)
        {
            InitializeComponent();
            usuarioLoguado = user;
            ObtenerMP();
        }

    private void ObtenerMP()
    {
        try
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                cnx.Open();

                dsMantenimiento.MP.Clear();

                SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getMasterMP", cnx);
                da.Fill(dsMantenimiento.MP);

                cnx.Close();

            }
        }
        catch (Exception ex)
        {
            CajaDialogo.Error(ex.Message);
            throw;
        }
    }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                xfrmMasterMP_CRUD frm = new xfrmMasterMP_CRUD(usuarioLoguado,(int)xfrmMasterMP_CRUD.TipoTransaccion.Nuevo);
                frm.EventoPasarId_MP_inserted += new xfrmMasterMP_CRUD.get_MP_inserted(Ejecutar);
                frm.ShowDialog();
                //if (frm.ShowDialog()== DialogResult.OK)
                //{
                //    ObtenerMP();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void Ejecutar(int pIdInserted)
        {
            MateriaPrima.Models.MateriaPrima mp = new Models.MateriaPrima();

            if (mp.RecuperarRegistro(pIdInserted))
            {
                dsMantenimiento.MPRow row1 = dsMantenimiento.MP.NewMPRow();
                row1.id = pIdInserted;
                row1.nombre = mp.Nombre;
                row1.code = mp.Codigo;
                row1.nombre = mp.Nombre;
                row1.nombre_comercial = mp.NombreComercial;
                row1.id_presentacion_default = mp.TipoPresentacionID;
                row1.tipo_presentacion = mp.TipoPresentacionNombre;
                row1.id_estado = mp.EstadoID;
                row1.Estado = mp.Estado;
                row1.id_tipo = mp.TipoID;
                row1.Tipo = mp.TipoMP;
                row1.fecha_creado = mp.FechaCreado;

                dsMantenimiento.MP.AddMPRow(row1);
                dsMantenimiento.AcceptChanges();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                MateriaPrima.Models.MateriaPrima mp = new Models.MateriaPrima();

                var row = (dsMantenimiento.MPRow)gvMP.GetFocusedDataRow();

                xfrmMasterMP_CRUD frm = new xfrmMasterMP_CRUD(usuarioLoguado,(int)xfrmMasterMP_CRUD.TipoTransaccion.Editar,mp);

                mp.ID = row.id;
                mp.Nombre = row.nombre;
                mp.NombreComercial = row.nombre_comercial;
                mp.Codigo = row.code;
                mp.FechaCreado = row.fecha_creado;
                mp.EstadoID = row.id_estado;
                mp.TipoID = row.id_tipo;
                mp.TipoPresentacionID = row.id_presentacion_default;
                mp.AplicaCosto = row.aplic_costos;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //ObtenerMP();

                    row.id = mp.ID;
                    row.nombre = mp.Nombre;
                    row.nombre_comercial = mp.NombreComercial;
                    row.code = mp.Codigo;
                    row.fecha_creado = mp.FechaCreado;
                    row.id_estado = mp.EstadoID;
                    row.id_tipo = mp.TipoID;
                    row.id_presentacion_default = mp.TipoPresentacionID;
                    row.aplic_costos = mp.AplicaCosto;
                    row.tipo_presentacion = mp.TipoPresentacionNombre;
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
                        var row = (dsMantenimiento.MPRow)gvMP.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        using (SqlCommand command = new SqlCommand("dbo.usp_deleteMP", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerMP();
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
            ObtenerMP();
        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gvMP.ExportToXlsx(dialog.FileName);
        }
    }
}