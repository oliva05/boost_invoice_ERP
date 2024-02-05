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

namespace JAGUAR_APP.Mantenimientos
{
    public partial class xfrmJAGUAR_TipoPresentacionConversion_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum Transacciones
        {
            Nuevo=1,
            Editar=2
        }

        int id_tipo_presentacion_Origen = 0;
        int id_tipo_presentacion_Destino;
        decimal factor;
        int tipoTransaccion = 0;

        public delegate void get_tipo_inserted(int Id_tipo_inserted);
        public event get_tipo_inserted EventoPasarId_tipo_inserted;


        public xfrmJAGUAR_TipoPresentacionConversion_CRUD(int pTransaccion,int id_tipo_presentacion_Origen_p, int id_tipo_presentacion_Destino_p, decimal factor_p)
        {
            InitializeComponent();
            ObtenerPresentacionOrigen();
            tipoTransaccion = pTransaccion;
            id_tipo_presentacion_Origen = id_tipo_presentacion_Origen_p;
            id_tipo_presentacion_Destino = id_tipo_presentacion_Destino_p;
            if (id_tipo_presentacion_Destino_p == 0)
            {
                luePresentacionDestino.EditValue = 26;//Libra
            }
            
            factor = factor_p;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerPresentacionOrigen()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.Presentacion_tipo.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetTipoPresentacionToConversion", cnx);
                    da.Fill(dsMantenimiento.Presentacion_tipo);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void cmdNew_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(luePresentacionOrigen.Text))
            {
                CajaDialogo.Error("DEBE SELECCIONAR UNA PRESENTACION");
                return;
            }

            if (string.IsNullOrEmpty(luePresentacionDestino.Text))
            {
                CajaDialogo.Error("DEBE SELECCIONAR UNA PRESENTACION");
                return;
            }

            if (luePresentacionOrigen.EditValue == luePresentacionDestino.EditValue)
            {
                CajaDialogo.Error("LA PRESENTACIÓN DE ORIGEN DEBE SER DIFERENTE DE LA PRESENTACIÓN DESTINO");
                return;
            }

            bool existeConversion = false;
            int id_inserted = 0;

            try
            {
                DataOperations dp = new DataOperations();

                switch (tipoTransaccion)
                {
                    case (int)Transacciones.Nuevo:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.usp_InsertMewConversionTipoPresentacion_V2", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id_presentacion_origen", SqlDbType.Int).Value = luePresentacionOrigen.EditValue;
                            cmd.Parameters.Add("@id_presentacion_destino", SqlDbType.Int).Value = luePresentacionDestino.EditValue;
                            cmd.Parameters.Add("@factor", SqlDbType.Decimal).Value = txtFactor.Text;

                            SqlDataReader dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                existeConversion = dr.GetBoolean(0);
                                id_inserted = dr.GetInt32(1);
                            }
                          //bool existeConversion= Convert.ToBoolean(  cmd.ExecuteScalar());

                            if (existeConversion)
                            {
                                CajaDialogo.Error("CONVERSION YA EXISTE");
                            }
                            else
                            {
                                CajaDialogo.Information("DATOS GUARDADOS");
                                EventoPasarId_tipo_inserted(id_inserted);
                                this.DialogResult = DialogResult.OK;
                            }
                            cnx.Close();
                        }
                        break;

                    case (int)Transacciones.Editar:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("[dbo].[usp_UpdateConversionTipoPresentacion]", cnx);

                            cmd2.Parameters.Add("@id_presentacion_origen", SqlDbType.Int).Value = luePresentacionOrigen.EditValue;
                            cmd2.Parameters.Add("@id_presentacion_destino", SqlDbType.Int).Value = luePresentacionDestino.EditValue;
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = luePresentacionDestino.EditValue;
                            cmd2.Parameters.Add("@factor", SqlDbType.Decimal).Value = txtFactor.Text;


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
            if (tipoTransaccion == (int)Transacciones.Editar)
            {
              luePresentacionOrigen.EditValue = id_tipo_presentacion_Origen;
              luePresentacionDestino.EditValue = id_tipo_presentacion_Destino;
                txtFactor.Text = factor.ToString();

                luePresentacionDestino.Enabled = false;
                luePresentacionOrigen.Enabled = false;

            }

        }

        private void luePresentacionOrigen_EditValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}