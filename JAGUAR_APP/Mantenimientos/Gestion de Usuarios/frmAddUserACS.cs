using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices.AccountManagement;
using ACS.Classes;

namespace ACS.IT_Managment
{
    public partial class frmAddUserACS : Form
    {
        DataOperations dp = new DataOperations();
        int tipoOp = 1; //crear
        public int id_user;
        public frmAddUserACS()
        {
            InitializeComponent();
            loaddata();
            load_Empresa();
            Load_User();
            load_grupos_ARM();
        }
        public frmAddUserACS(int IdUSer)
        {
            InitializeComponent();
            loaddata();
            id_user = IdUSer;
            labelControl1.Text = "Edicion de Usuario.";
            load_Empresa();
            tipoOp = 2; // editar
            Load_User();
            lblactivo.Visible = true;
            toggactivo.Visible = true;
            load_grupos_ARM();

        }
        public void loaddata()
        {
            load_tipo();
            load_acs();
            load_losa();
            load_grupos_ARM();
        }
        public void Load_User()
        {
            string Query = @"sp_load_user_data";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_user", id_user);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   if (!dr.IsDBNull(1)) txtusuario.Text = dr.GetString(1);
                    if (!dr.IsDBNull(2)) txtuser.Text = dr.GetString(2);
                    if (!dr.IsDBNull(3)) grdTipoUsuario.EditValue = dr.GetString(3);
                    if (!dr.IsDBNull(5)) toggleSwitch1.IsOn = dr.GetBoolean(5);
                    if (!dr.IsDBNull(7)) grdACS.EditValue = dr.GetInt32(7);
                    if (!dr.IsDBNull(8)) grdLOSA.EditValue = dr.GetInt32(8);
                    if (!dr.IsDBNull(6)) toggactivo.IsOn = dr.GetBoolean(6); 
                    if (!dr.IsDBNull(9)) grd_empresa.EditValue = dr.GetInt32(9);
                    if (!dr.IsDBNull(10)) grdARM.EditValue = dr.GetInt32(10);
                }
                cn.Close();
                dr.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_tipo()
        {
            string query = @"Select distinct tabla.tipo as id, tabla.tipo as tipo
                            from ACS.conf_usuarios tabla
                            where tabla.tipo <> '' and activo = 1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //dsusuarios.tipos.Clear();
                //da.Fill(dsusuarios.tipos);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_Empresa()
        {
            string query = @"SELECT [id]
                                  ,[descripcion]
                              FROM [conf_usuario_empresa]
                              where enable = 1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //dsusuarios.empresa.Clear();
                //da.Fill(dsusuarios.empresa);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_acs()
        {
            string query = @"Select 1 as id, 'Produccion' as descripcion
                              union all
                            Select 2 as id, 'Logistica' as descripcion
                                union all
                            Select 3 as id, 'Calidad' as descripcion
                              union all
                            Select 4 as id, 'Desarrollo' as descripcion
                                 union all
                            Select 5 as id, 'Ninguna' as descripcion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //dsusuarios.ACS.Clear();
                //da.Fill(dsusuarios.ACS);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_losa()
        {
            //string query = @"Select 0 as id, 'Montacarga' as descripcion
            //                  union all
            //                Select 1 as id, 'Logistica' as descripcion
            //                    union all
            //                Select 2 as id, 'Calidad' as descripcion
            //                  union all
            //                Select 3 as id, 'Administrador' as descripcion 
            //                    union all
            //                Select 4 as id, 'Produccion' as descripcion
            //                     union all
            //                Select 5 as id, 'Producción Administrativa' as descripcion
            //                    union all
            //                Select 6 as id, 'Ninguna'";
            string query = "sp_get_grupos_usuarios_alosy";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //dsusuarios.Losa.Clear();
                //da.Fill(dsusuarios.Losa);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_grupos_ARM()
        {
            string query = @"Select 0 as id, 'Gestion y Clasificacion del Bin' as descripcion
                              union all
                            Select 1 as id, 'Asignacion de MP en Bin' as descripcion
                                union all
                            Select 2 as id, 'Gestion de Formulas y Ordenes de Produccion' as descripcion
                              union all
                            Select 3 as id, 'Ninguna' as descripcion";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsusuarios.ARM.Clear();
                //adat.Fill(dsusuarios.ARM);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void chDominio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int id_losa, id_acs,issuper;
            string Msj = "Error en la ejecucion.";
            bool Sepudo = false;

            if (txtusuario.Text == "")
            {
                CajaDialogo.Error("Error, el nombre de usuario no puede esta vacio.");
                txtusuario.Focus();
                return;
            }
            if (txtuser.Text == "")
            {
                CajaDialogo.Error("Error, el usuario no puede esta vacio.");
                txtusuario.Focus();
                return;
            }
            if (grdTipoUsuario.EditValue  == DBNull.Value )
            {
                CajaDialogo.Error("seleccione un tipo de usuario.");
                grdTipoUsuario.Focus();
                return;
            }
            if (grdTipoUsuario.EditValue == DBNull.Value)
            {
                CajaDialogo.Error("seleccione un tipo de usuario.");
                grdTipoUsuario.Focus();
                return;
            }
            if (grd_empresa.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar una empresa al que pertence el usuario.");
                grd_empresa.ShowPopup();
                return;
            }
            if (grdLOSA.EditValue == DBNull.Value)
            {
                id_losa = 99;
            }
            else
            {
                id_losa = Convert.ToInt32(grdACS.EditValue);
            }
            if (grdACS.EditValue == DBNull.Value)
            {
                id_acs = 99;
            }
            else
            {
                id_acs = Convert.ToInt32(grdACS.EditValue);
            }
            if (toggleSwitch1.IsOn)
            {
                issuper = 1;
            }
            else
            {
                issuper = 0;
            }
            if (tipoOp == 1)
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();


                SqlCommand cmd = new SqlCommand("sp_insert_new_user", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@nombre", txtusuario.Text);
                cmd.Parameters.AddWithValue("@usuario", txtuser.Text);

                cmd.Parameters.AddWithValue("@id_empresa", grd_empresa.EditValue != null ? grd_empresa.EditValue: DBNull.Value);
                if (id_acs == 99)
                {
                    cmd.Parameters.AddWithValue("@id_acs", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@id_acs", id_acs);
                }
                if (id_losa == 99)
                {
                    cmd.Parameters.AddWithValue("@id_losa", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@id_losa", id_losa);
                }

                cmd.Parameters.AddWithValue("@super_user", issuper);
                cmd.Parameters.AddWithValue("@tipo", grdTipoUsuario.EditValue.ToString());
                cmd.Parameters.AddWithValue("@id_grupo_arm", grdARM.EditValue != null ? grdARM.EditValue : DBNull.Value);
                try
                {
                    SqlDataReader DR = cmd.ExecuteReader();
                    if (DR.Read())
                    {

                        Msj = DR.GetString(0);
                        Sepudo = DR.GetBoolean(1);
                    }
                    if (Sepudo)
                    {
                        CajaDialogo.Information(Msj);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        CajaDialogo.Error(Msj);
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();


                SqlCommand cmd = new SqlCommand("sp_update_usuariosV2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre",txtusuario.Text);
                cmd.Parameters.AddWithValue("@user", txtuser.Text);
                cmd.Parameters.AddWithValue("@tipo", grdTipoUsuario.EditValue);
                cmd.Parameters.AddWithValue("@super_user", toggleSwitch1.IsOn == false ? 0 : 1);
                cmd.Parameters.AddWithValue("@activo", toggactivo.IsOn == false ? 0 : 1);
                cmd.Parameters.AddWithValue("@id_grupo", grdACS.EditValue != null ? grdACS.EditValue : DBNull.Value );
                cmd.Parameters.AddWithValue("@id_grupo_losa", grdLOSA.EditValue != null ? grdLOSA.EditValue : DBNull.Value);
                cmd.Parameters.AddWithValue("@id_empresa", grd_empresa.EditValue != null ? grd_empresa.EditValue : DBNull.Value);
                cmd.Parameters.AddWithValue("@id_user", id_user);
                cmd.Parameters.AddWithValue("@id_grupo_arm", grdARM.EditValue != null ? grdARM.EditValue : DBNull.Value);
                try
                {
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Information("Cambio realizado Exitosamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }


            }
        }

        private void lblactivo_Click(object sender, EventArgs e)
        {

        }

        private void toggactivo_Toggled(object sender, EventArgs e)
        {

        }
    }
}
