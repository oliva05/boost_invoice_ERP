using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Proveedor.Model;
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

namespace JAGUAR_APP.Mantenimientos.Proveedor
{
    public partial class xfrmProveedorCAI_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum Transacciones
        {
            Nuevo=1,
            Editar=2
        }
        public delegate void get_cai_inserted(int Id_lata_inserted);
        public event get_cai_inserted EventoPasarId_cai_inserted;

        int tipoTransaccion = 0;
        Proveedor_CAI cai;
        UserLogin UsuarioLogeado;

        public xfrmProveedorCAI_CRUD(int pTransaccion,Proveedor_CAI pCAI, UserLogin pUserLogin)
        {
            InitializeComponent();
            ObtenerProveedores();
            tipoTransaccion = pTransaccion;
            cai = pCAI;
            UsuarioLogeado = pUserLogin;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerProveedores()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.JAGUAR_Proveedor.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetProveedores", cnx);
                    da.Fill(dsMantenimiento.JAGUAR_Proveedor);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void cmdNew_Click(object sender, EventArgs e)
        { //dbo.usp_JAGUAR_InsertNewProveedorCAI
            int CorrelativoInicia = Convert.ToInt32(seCorrelativoInicia.Text);
            int CorrelativoTermina = Convert.ToInt32(seCorrelativoTermina.Text);

            DateTime FechaInicio = Convert.ToDateTime(deFechaInicio.EditValue);
            DateTime FechaFin = Convert.ToDateTime(deFechaFin.EditValue);

            if (CorrelativoInicia>CorrelativoTermina)
            {
                CajaDialogo.Error("VERIFIQUE EL CORRELATIVO INICIAL, YA QUE DEBE SER MENOR QUE EL CORRELATIVO FINAL");
                return;
            }

            if (FechaInicio > FechaFin)
            {
                CajaDialogo.Error("VERIFIQUE LA FECHA INICIAL, YA QUE DEBE SER MENOR QUE LA FECHA FINAL");
                return;
            }

            if (string.IsNullOrEmpty(txtCAI.Text))
            {
                CajaDialogo.Error("DEBE INGRESAR UN CAI VALIDO");
                return;
            }

            if (string.IsNullOrEmpty(txtCAI.Text))
            {
                CajaDialogo.Error("DEBE INGRESAR UN CAI VALIDO");
                return;
            }

            if (string.IsNullOrEmpty(txtLeyenda.Text))
            {
                CajaDialogo.Error("DEBE INGRESAR UNA LEYENDA");
                return;
            }

            if (string.IsNullOrEmpty(deFechaInicio.Text))
            {
                CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA INICIAL");
                return;
            }

            if (string.IsNullOrEmpty(deFechaFin.Text))
            {
                CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA FINAL");
                return;
            }

            if (string.IsNullOrEmpty(seCorrelativoInicia.Text))
            {
                CajaDialogo.Error("DEBE INGRESAR UN NUMERO DE CORRELATIVO VALIDO");
                return;
            }

            if (string.IsNullOrEmpty(seCorrelativoTermina.Text))
            {
                CajaDialogo.Error("DEBE INGRESAR UN NUMERO DE CORRELATIVO VALIDO");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                int id_inserted = 0;

                switch (tipoTransaccion)
                {
                    case (int)Transacciones.Nuevo:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.usp_JAGUAR_InsertNewProveedorCAI_V2", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@cai", SqlDbType.VarChar).Value = txtCAI.Text;
                            cmd.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = deFechaInicio.EditValue;
                            cmd.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = deFechaFin.EditValue;
                            cmd.Parameters.Add("@correlativoDesde", SqlDbType.Int).Value = seCorrelativoInicia.EditValue;
                            cmd.Parameters.Add("@correlativoHasta", SqlDbType.Int).Value = seCorrelativoTermina.EditValue;
                            cmd.Parameters.Add("@leyenda", SqlDbType.VarChar).Value = txtLeyenda.Text;
                            cmd.Parameters.Add("@proveedor_id", SqlDbType.Int).Value = lueProveedor.EditValue;

                           id_inserted=Convert.ToInt32( cmd.ExecuteScalar());

                            CajaDialogo.Information("DATOS GUARDADOS");
                            EventoPasarId_cai_inserted(id_inserted);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;

                    case (int)Transacciones.Editar:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("[dbo].[usp_update_JAGUAR_CAI_Proveedor]", cnx);

                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@cai", SqlDbType.VarChar).Value = txtCAI.Text;
                            cmd2.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = deFechaInicio.EditValue;
                            cmd2.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = deFechaFin.EditValue;
                            cmd2.Parameters.Add("@correlativoDesde", SqlDbType.Int).Value = seCorrelativoInicia.EditValue;
                            cmd2.Parameters.Add("@correlativoHasta", SqlDbType.Int).Value = seCorrelativoTermina.EditValue;
                            cmd2.Parameters.Add("@leyenda", SqlDbType.VarChar).Value = txtLeyenda.Text ;
                            cmd2.Parameters.Add("@proveedor_id", SqlDbType.Int).Value = lueProveedor.EditValue;
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = cai.ID;


                            cmd2.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS ACTUALIZADOS");
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

        private void xfrmProveedorCAI_CRUD_Load(object sender, EventArgs e)
        {
            if (tipoTransaccion==(int)Transacciones.Editar)
            {
                txtCAI.Text = cai.CAI;
                txtLeyenda.Text = cai.Leyenda;
                deFechaInicio.EditValue = cai.FechaInicio;
                deFechaFin.EditValue = cai.FechaFin;
                seCorrelativoInicia.EditValue = cai.CorrelativoInicia;
                seCorrelativoTermina.EditValue = cai.CorrelativoTermina;
                lueProveedor.EditValue = cai.ProveedorID;
            }
            else
            {
            deFechaFin.EditValue = DateTime.Now;
            deFechaInicio.EditValue = DateTime.Now;

            }
        }
    }
}