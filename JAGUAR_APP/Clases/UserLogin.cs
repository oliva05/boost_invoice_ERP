using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class UserLogin
    {
        public GrupoUser GrupoUsuario;
        public SqlConnection conn;
        private bool recuperado;
        private int id;
        //private int turnoId;
        private int idGrupo;
        private string nombreUser;
        private string ADuser;
        private string pass;
        private int idnivel;
        private string tipo;

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id { get => id; set => id = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string NombreUser { get => nombreUser; set => nombreUser = value; }
        public string ADuser1 { get => ADuser; set => ADuser = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Idnivel { get => idnivel; set => idnivel = value; }
        public int TurnoId { get => idnivel; set => idnivel = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Enable { get; set; }
        public bool AdminCambiarPrecio { get; set; }

        //Migracion ACS

        #region Members
        int vUserid;
        string vNombre;
        string vAlias;
        bool vRecuperado;
        //DataOperations dp;
        bool vSuperUser;
        string vPassword;
        #endregion

        #region Properties
        //public bool Recuperado
        //{
        //    get { return vRecuperado; }
        //    set { vRecuperado = value; }
        //}
        public int UserId
        {
            get { return vUserid; }
            set { vUserid = value; }
        }
        public string Nombre
        {
            get { return vNombre; }
            set { vNombre = value; }
        }
        public string AD_User
        {
            get { return vAlias; }
            set { vAlias = value; }
        }
        /// <summary>
        /// Set or Get bool if the user login is Super User
        /// </summary>
        public bool IsSuperUser
        {
            get { return vSuperUser; }
            set { vSuperUser = value; }
        }

        public string Password { get => vPassword; set => vPassword = value; }
        public string Usuario { get; set; }
        public bool Habilitado { get; set; }
        #endregion

        public UserLogin()
        {
            GrupoUsuario = new GrupoUser();
        }

        public string EncrypPassword(string pass)
        {
            try
            {
                byte[] enbyte = GetBytes(pass);
                string cadena_base64 = Convert.ToBase64String(enbyte);
                return cadena_base64;
            }
            catch (Exception)
            {
                return " ";
            }
        }

        private static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        public bool RecuperarRegistroFromUser(string pUser)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                string sql = @"SELECT top 1 id, 
                                       nombre, 
	                                   id_grupo_losa,
                                       ADUser
                                FROM [ACS].dbo.conf_usuarios 
                                where [ADUser] ='" + pUser + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    nombreUser = dr.GetString(1);
                    idGrupo = dr.GetInt32(2);
                    ADuser = dr.GetString(3);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }


        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                string sql = @"SELECT id, 
                                       nombre, 
	                                   id_grupo_losa,
                                       tipo
                                FROM [ACS].conf_usuarios 
                                where id ="+ pId;
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    nombreUser = dr.GetString(1);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_grupo_losa")))
                        idGrupo = dr.GetInt32(2);
                    if (!dr.IsDBNull(dr.GetOrdinal("tipo")))
                        Tipo = dr.GetString(3);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public int idNivelAcceso(int Iduser, int idSistema)
        {
            int id = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();
                string sql = "[ACS].[sp_get_nivel_acceso_for_user]";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_sistema", idSistema);
                cmd.Parameters.AddWithValue("@id_user", Iduser);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                //recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return id;
        }

        internal bool ValidarNivelPermisos(int pIdVentana)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                Conn.Open();
                string sql = @"SELECT count(*)
                                FROM [ACS].conf_usuario_ventanas vv 
                                where vv.id_ventana = " + pIdVentana.ToString() +
                                      "and vv.id_usuario = " + UserId.ToString();
                SqlCommand cmd = new SqlCommand(sql, Conn);
                int v = Convert.ToInt32(cmd.ExecuteScalar());
                if (v > 0)
                    r = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }


        //Vamos a cargar desde sql toda la data del usuario
        public bool RecuperarRegistro(string pUserID)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                Conn.Open();
                string sql = @"SELECT [id]
                                      ,[nombre]
                                      ,[ADUser]
                                      ,[super_user]
                                  FROM [dbo].[conf_usuarios]
                                  where id = " + pUserID;
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserId = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    AD_User = dr.GetString(2);
                    IsSuperUser = dr.GetBoolean(3);
                }
                vRecuperado = true;
                Conn.Close();
            }
            catch (Exception ec)
            {
                vRecuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return vRecuperado;
        }


        public bool RecuperarRegistroJAGUAR(string pAlias)
        {
            bool x = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = @"SELECT [id]
                                      ,usuario--[alias]
                                      ,[nombre]
                                      ,[super_user]
                                      ,[password]
                                      ,[habilitado]
                                      ,[id_grupo_losa]
                                      ,[bit_cambio_precio]
                                  FROM [ACS].[conf_usuarios]
                                   where [usuario] = '" + pAlias + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserId = dr.GetInt32(0);
                    id = UserId;
                    Usuario = dr.GetString(1);
                    Nombre = dr.GetString(2);
                    IsSuperUser = dr.GetBoolean(3);
                    Pass = dr.GetString(4);
                    Habilitado = dr.GetBoolean(5);
                    AdminCambiarPrecio = dr.GetBoolean(7);
                    GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)dr.GetInt32(6);
                }
                x = true;
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                x = false;
                CajaDialogo.Error(ex.Message);

            }
            return x;
        }


        public bool RecuperarRegistroJAGUAR(int pId)
        {
            bool x = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                string sql = @"SELECT [id]
                                      ,usuario--[alias]
                                      ,[nombre]
                                      ,[super_user]
                                      ,[password]
                                      ,[habilitado]
                                      ,[id_grupo_losa]
                                      ,isnull([turno_id],0) [turno_id]
                                  FROM [ACS].[conf_usuarios]
                                   where [id] = " + pId.ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserId = dr.GetInt32(0);
                    id = UserId;
                    Usuario = dr.GetString(1);
                    Nombre = dr.GetString(2);
                    NombreUser = dr.GetString(2);
                    IsSuperUser = dr.GetBoolean(3);
                    Pass = dr.GetString(4);
                    Habilitado = dr.GetBoolean(5);
                    IdGrupo = dr.GetInt32(6);
                    TurnoId = dr.GetInt32(7);
                }
                x = true;
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                x = false;
                CajaDialogo.Error(ex.Message);

            }
            return x;
        }

        internal bool ValidarNivelPermisosTemporal(int pIdNIvelVentana)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                Conn.Open();
                string sql = @"sp_get_validacion_permisos_temporales_usuarios";
                SqlCommand cmd = new SqlCommand(sql, Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ventana", pIdNIvelVentana);
                int v1 = Convert.ToInt32(cmd.ExecuteScalar());
                if (v1 > 0)
                    r = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("Error situado en Class: UserLogin, Function: ValidarNivelPermisosTemporal. Msj Erro: " + ec.Message);
            }
            return r;
        }

        public bool GuardarNuevoUsuario()
        {
            string sql = @"INSERT INTO [ACS].[conf_usuarios]
                                           ([usuario]
                                           ,[password]
                                           ,[habilitado]
                                           ,[nombre]
                                           ,[super_user]
                                            ,[id_grupo_losa]
                                            ,[turno_id])
                                     VALUES
                                           (@alias,
                                            @password,
                                            @habilitado,
                                            @nombre,
                                            @super_user,
                                            @id_grupo,
                                            @turno_id)";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("alias", SqlDbType.VarChar).Value = this.Usuario;
                cmd.Parameters.Add("password", SqlDbType.VarChar).Value = EncrypPassword(this.Pass);
                cmd.Parameters.Add("habilitado", SqlDbType.Bit).Value = this.Habilitado;
                cmd.Parameters.Add("nombre", SqlDbType.VarChar).Value = this.nombreUser;
                cmd.Parameters.Add("id_grupo", SqlDbType.VarChar).Value = this.IdGrupo;
                cmd.Parameters.Add("super_user", SqlDbType.Bit).Value = this.IsSuperUser;
                cmd.Parameters.Add("turno_id", SqlDbType.Bit).Value = this.IsSuperUser;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }


        public bool ModificarUsuario()
        {
            try
            {
                string sql = @"UPDATE [ACS].[conf_usuarios]
                                   SET [usuario] = @alias
                                      ,[password] = @password
                                      ,[habilitado] = @habilitado
                                      ,[nombre] = @nombre
                                      ,[id_grupo_losa]=@id_grupo
                                      ,[super_user] = @super_user
                                      ,[turno_id] = @turno_id
                                 WHERE id = @id";
                //DBOperations dp = new DBOperations();
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("alias", SqlDbType.VarChar).Value = Usuario;
                string a = EncrypPassword(this.Pass);
                cmd.Parameters.Add("password", SqlDbType.VarChar).Value = a;
                cmd.Parameters.Add("habilitado", SqlDbType.Bit).Value = Habilitado;
                cmd.Parameters.Add("nombre", SqlDbType.VarChar).Value = Nombre;
                cmd.Parameters.Add("id_grupo", SqlDbType.VarChar).Value = IdGrupo;
                cmd.Parameters.Add("super_user", SqlDbType.Bit).Value = IsSuperUser;
                cmd.Parameters.Add("turno_id", SqlDbType.Bit).Value = TurnoId;
                cmd.ExecuteScalar();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }






        public string DecryptPassword(string pass)
        {
            try
            {
                byte[] b = Convert.FromBase64String(pass);
                string cadena = GetString(b);
                return cadena;
            }
            catch
            {
                return " ";
            }
        }



    }
}
