using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
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
    public partial class xfrmMasterMP_CRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;
        public MateriaPrima.Models.MateriaPrima mp = new Models.MateriaPrima();
        int tipoTransaccion = 0;

        public delegate void get_MP_inserted(int Id_MP_inserted);
        public event get_MP_inserted EventoPasarId_MP_inserted;

        public enum TipoTransaccion
        {
            Nuevo=1,
                Editar=2
        }

        public xfrmMasterMP_CRUD(UserLogin userLog,int tipoTransaccionP)
        {
            InitializeComponent();
            usuarioLogueado = userLog;
            ObtenerEstados();
            ObtenerTipoMP();
            ObtenerPresentacion();
            tipoTransaccion = tipoTransaccionP;
            if(tipoTransaccion == 1)
            {
                Clases.MateriaPrima mp1 = new Clases.MateriaPrima(0);

                txtCodigo.Text = mp1.GenerarSiguienteCodigoMP();
            }
        }

        public xfrmMasterMP_CRUD(UserLogin userLog,int tipoTransaccionP,MateriaPrima.Models.MateriaPrima mpP)
        {
            InitializeComponent();
            usuarioLogueado = userLog;
            ObtenerEstados();
            ObtenerTipoMP();
            ObtenerPresentacion();
            mp = mpP;
            tipoTransaccion = tipoTransaccionP;
        }

        private void ObtenerEstados()
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
                throw;
            }
        }

        private void ObtenerTipoMP()
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

        private void ObtenerPresentacion()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.TiposPresentacionesDataTable.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_getTipoPresentacionMP", cnx);
                    da.Fill(dsMantenimiento.TiposPresentacionesDataTable);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void xfrmMasterMP_CRUD_Load(object sender, EventArgs e)
        {
            if (tipoTransaccion== (int)TipoTransaccion.Editar)
            {
                txtCodigo.Text = mp.Codigo;
                txtNombreCorto.Text = mp.Nombre;
                txtComercial.Text = mp.NombreComercial;
                ceAplica.EditValue = mp.AplicaCosto;
                lueEstado.EditValue = mp.EstadoID;
                lueTipo.EditValue = mp.TipoID;
                luePresentacion.EditValue = mp.TipoPresentacionID;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {

                DataOperations dp = new DataOperations();
                int id_inserted = 0;

                if (string.IsNullOrEmpty(txtNombreCorto.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UN NOMBRE");
                    return;
                }

                if (string.IsNullOrEmpty(txtComercial.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UN NOMBRE COMERCIAL");
                    return;
                }

                if (string.IsNullOrEmpty( lueEstado.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN ESTADO");
                    return;
                }

                if (string.IsNullOrEmpty(lueTipo.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN TIPO");
                    return;
                }

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UN CODIGO");
                    return;
                }

                if (string.IsNullOrEmpty(luePresentacion.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA PRESENTACION");
                    return;
                }
                switch (tipoTransaccion)
                {
                    case (int)TipoTransaccion.Nuevo:

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.usp_insertNewMPV3", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nombre_comercial", SqlDbType.VarChar).Value = txtComercial.Text;
                            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtComercial.Text;
                            cmd.Parameters.Add("@aplic_costo", SqlDbType.Bit).Value = ceAplica.Checked;
                            cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = usuarioLogueado.Id;
                            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@id_tipo", SqlDbType.Int).Value = lueTipo.EditValue;
                            cmd.Parameters.Add("@id_estado", SqlDbType.Int).Value = lueEstado.EditValue;
                            cmd.Parameters.Add("@id_presentacion", SqlDbType.Int).Value = luePresentacion.EditValue;
                            
                            id_inserted=Convert.ToInt32( cmd.ExecuteScalar());

                            mp.NombreComercial = txtComercial.Text;
                            mp.Nombre = txtComercial.Text;
                            mp.AplicaCosto = ceAplica.Checked;
                            mp.Codigo = txtCodigo.Text;
                            mp.TipoID = dp.ValidateNumberInt32(lueTipo.EditValue);
                            mp.EstadoID = dp.ValidateNumberInt32(lueEstado.EditValue);
                            mp.TipoPresentacionID = dp.ValidateNumberInt32(luePresentacion.EditValue);
                            mp.TipoPresentacionNombre = luePresentacion.Text;

                           EventoPasarId_MP_inserted(id_inserted);


                            //CajaDialogo.Information("DATOS GUARDADOS");
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                     break;

                    case (int)TipoTransaccion.Editar:

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("dbo.usp_updateMasterMPV2", cnx);

                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@nombre_comercial", SqlDbType.VarChar).Value = txtComercial.Text;
                            cmd2.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombreCorto.Text;
                            cmd2.Parameters.Add("@aplic_costo", SqlDbType.Bit).Value = ceAplica.Checked;
                            cmd2.Parameters.Add("@id_user", SqlDbType.Int).Value = usuarioLogueado.Id;
                            cmd2.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCodigo.Text;
                            cmd2.Parameters.Add("@id_tipo", SqlDbType.Int).Value = lueTipo.EditValue;
                            cmd2.Parameters.Add("@id_estado", SqlDbType.Int).Value = lueEstado.EditValue;
                            cmd2.Parameters.Add("@fecha_creado", SqlDbType.DateTime).Value = mp.FechaCreado;
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = mp.ID;
                            cmd2.Parameters.Add("@id_presentacion", SqlDbType.Int).Value = luePresentacion.EditValue;

                            mp.NombreComercial = txtComercial.Text;
                            mp.Nombre = txtComercial.Text;
                            mp.AplicaCosto = ceAplica.Checked;
                            mp.Codigo = txtCodigo.Text;
                            mp.TipoID = dp.ValidateNumberInt32(lueTipo.EditValue);
                            mp.EstadoID = dp.ValidateNumberInt32(lueEstado.EditValue);
                            mp.TipoPresentacionID = dp.ValidateNumberInt32(luePresentacion.EditValue);
                            mp.TipoPresentacionNombre = luePresentacion.Text;

                            cmd2.ExecuteNonQuery();

                            //CajaDialogo.Information("DATOS ACTUALIZADOS");
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
    }
}