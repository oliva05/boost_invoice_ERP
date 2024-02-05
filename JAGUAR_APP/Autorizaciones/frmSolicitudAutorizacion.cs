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

namespace JAGUAR_APP.Autorizaciones
{
    public partial class frmSolicitudAutorizacion : DevExpress.XtraEditors.XtraForm
    {
        public frmSolicitudAutorizacion()
        {
            InitializeComponent();
            LoadUsers();
            LoadTipos();
            LoadRutasAprobacion();
        }

        private void LoadUsers()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.ALOSY_aprobacion_solicitudes_users",cnx);
                    dsAutorizaciones.Usuarios.Clear();
                    da.Fill(dsAutorizaciones.Usuarios);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadTipos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.ALOSY_aprobacion_solicitudes_get_tipos", cnx);
                    dsAutorizaciones.Tipos_Solicitud.Clear();
                    da.Fill(dsAutorizaciones.Tipos_Solicitud);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadRutasAprobacion()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("ALOSY_aprobacion_solicitudes_get_rutas_aprobacion", cnx);
                    dsAutorizaciones.Rutas_Aprobacion.Clear();
                    da.Fill(dsAutorizaciones.Rutas_Aprobacion);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty( lueUsuario.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN USUARIO SOLICITANTE");
                    return;
                }

                if (string.IsNullOrEmpty(lueUsuarioAprobador.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN USUARIO APROBADOR");
                    return;
                }

                if (string.IsNullOrEmpty(lueTipoSolicitu.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN TIPO DE SOLICITUD");
                    return;
                }

                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.LOSA_insert_aprobacion_solicitudes", cnx);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = lueUsuario.EditValue ;
                    cmd.Parameters.Add("@id_tipo_solicitud", SqlDbType.Int).Value = lueTipoSolicitu.EditValue  ;
                    cmd.Parameters.Add("@id_usuario_aprobador", SqlDbType.Int).Value = lueUsuarioAprobador.EditValue;
                    cmd.Parameters.Add("@id_ruta_aprobacion", SqlDbType.Int).Value = slueRuta.EditValue ;
                    cmd.Parameters.Add("@id_documento_solicitado", SqlDbType.Int).Value = lueDocumento.EditValue ;
                    cmd.Parameters.Add("@id_estado", SqlDbType.Int).Value = 1 ;
                    cmd.Parameters.Add("@comentario", SqlDbType.Int).Value = txtComentario.Text;

                    cmd.ExecuteNonQuery();

                    cnx.Close();
                }

                CajaDialogo.Information("DATOS GUARDADOS");
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}