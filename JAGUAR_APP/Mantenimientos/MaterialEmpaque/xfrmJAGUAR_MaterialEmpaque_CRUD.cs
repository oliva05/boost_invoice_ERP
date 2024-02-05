using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Mantenimientos.Clientes.Models;
using JAGUAR_APP.Mantenimientos.MaterialEmpaque.Model;
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
using static ACS.Classes.DataOperations;
using static JAGUAR_APP.Clases.Conf_TablesID;

namespace JAGUAR_APP.Mantenimientos.MaterialEmpaque
{
    public partial class xfrmJAGUAR_MaterialEmpaque_CRUD : DevExpress.XtraEditors.XtraForm
    {

        int tipoTransaccion = 0;
        Conf_TablesID tableID = new Conf_TablesID();
        Material_Empaque material = new Material_Empaque();
        UserLogin userLogged = new UserLogin();


        public delegate void get_ME_inserted(int Id_ME_inserted);
        public event get_ME_inserted EventoPasarId_ME_inserted;

        public xfrmJAGUAR_MaterialEmpaque_CRUD(int pTransaccion,Material_Empaque pMaterial,UserLogin user)
        {
            InitializeComponent();
            ObtenerPresentacion();
            tipoTransaccion = pTransaccion;

            material = pMaterial;
            userLogged = user;
        }

       private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerPresentacion()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();

                    dsMantenimiento.Presentacion_tipo.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("spObtenerTiposPresentaciones_v2", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.Add("@id_clase", (int)ClaseTipoPresentacion.MaterialEmpaque);
                    da.Fill(dsMantenimiento.Presentacion_tipo);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.Material_De_Empaque))
                {
                    txtCodigo.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }





        private void cmdNew_Click(object sender, EventArgs e)
        {          
           

            if (string.IsNullOrEmpty(txtMaterial.Text))
            {
                CajaDialogo.Error("DEBE INGRESAR UN MATERIAL DE EMPAQUE VALIDO");
                return;
            }


            try
            {
                DataOperations dp = new DataOperations();
                int id_inserted = 0;

                switch (tipoTransaccion)
                {
                    case (int)TipoTransaccionesCRUD.Nuevo:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.usp_Insert_JAGUAR_Material_de_EmpaqueV3", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtMaterial.Text;
                            cmd.Parameters.Add("@presentacion_id", SqlDbType.VarChar).Value = txtPresentacion.EditValue;
                            cmd.Parameters.Add("@id_user", SqlDbType.VarChar).Value = userLogged.Id;

                            id_inserted = Convert.ToInt32(cmd.ExecuteScalar());

                            //cmd.ExecuteNonQuery();
                            CajaDialogo.Information("DATOS GUARDADOS");
                            EventoPasarId_ME_inserted(id_inserted);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;

                    case (int)TipoTransaccionesCRUD.Editar:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("dbo.usp_Update_JAGUAR_Material_de_EmpaqueV2", cnx);

                            cmd2.CommandType = CommandType.StoredProcedure;


                    
                            cmd2.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtMaterial.Text;
                            cmd2.Parameters.Add("@presentacion_id", SqlDbType.VarChar).Value = txtPresentacion.EditValue;
                            cmd2.Parameters.Add("@id", SqlDbType.VarChar).Value = material.ID;
                            cmd2.Parameters.Add("@id_user", SqlDbType.VarChar).Value = userLogged.Id;


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
            if (tipoTransaccion==(int)TipoTransaccionesCRUD.Editar)
            {
                txtMaterial.Text = material.Material;
                txtPresentacion.EditValue = material.PresentacionID;
                txtCodigo.Text = material.Codigo;
                //txtCodigo.Enabled = false;
            }
            else
            {
                GetIDTable();
            }
           
        }
    }
}