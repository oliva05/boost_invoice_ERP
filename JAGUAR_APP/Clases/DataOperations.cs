using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Reflection;
//using Devart.Data.PostgreSql;

namespace ACS.Classes 
{
    class DataOperations
    {
        #region Connection Credentials

      //  internal string ConnectionStringTtrace = @"Server=" + Globals.ServerAddress + @";
      //                                             Database=" + Globals.ActiveDB + @";
      //                                             User Id=" + Globals.DB_User + @";
      //                                             Password=" + Globals.DB_Pass + ";";

      //  internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.CTS_ServerAddress + @";
      //                                             Database=" + Globals.CTS_ActiveDB + @";
      //                                             user Id=" + Globals.CTS_DB_User + @";
      //                                             Password=" + Globals.CTS_DB_Pass + ";";

      //internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.Bas_ServerAddress + @";
      //                                             Database=" + Globals.Bas_ActiveDB + @";
      //                                             user Id=" + Globals.Bas_DB_User + @";
      //                                             Password=" + Globals.Bas_DB_Pass + ";";

      //internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.LOSA_ServerName + @";
      //                                             Database=" + Globals.LOSA_ActiveDB + @";
      //                                             user Id=" + Globals.LOSA_DB_User + @";
      //                                             Password=" + Globals.LOSA_DB_Pass + ";";

      //  internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.APMS_Server + @";
      //                                                 Database=" + Globals.APMS_ActiveDB + @";
      //                                                 User Id=" + Globals.APMS_DB_User + @";
      //                                                 Password=" + Globals.APMS_DB_Pass + ";";

        //internal string ConnectionStringJAGUAR_DB =
        internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.JAGUAR_ServerAddress + @";
                                                            Database=" + Globals.JAGUAR_ActiveDB + @";
                                                            User Id=" + Globals.JAGUAR_DB_User + @";
                                                            Password=" + Globals.JAGUAR_DB_Pass + ";";

//        internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.SAP_ServerAddress + @";
//                                                        Database=" + Globals.SAP_ActiveDB + @";
//                                                         User Id=" + Globals.SAP_DB_User + @";
//                                                           Password=" + Globals.SAP_DB_Pass + ";";

//        internal string ConnectionStringJAGUAR_DB = @";Database=" + Globals.CMS_ActiveDB + @";
//                                                    User Id=" + Globals.CMS_DB_User + @";
//                                                    Password=" + Globals.CMS_DB_Pass + ";";

//        internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.CMS_ServerPellet + @";
//                                                       Database=" + Globals.CMS_ActiveDB + @";
//                                                       User Id=" + Globals.CMS_DB_User + @";
//                                                       Password=" + Globals.CMS_DB_Pass + ";";

//        internal string ConnectionStringExtruderServer = @"Server=" + Globals.CMS_ServerExtruder + @";
//                                                       Database=" + Globals.CMS_ActiveDB + @";
//                                                       User Id=" + Globals.CMS_DB_User + @";
//                                                       Password=" + Globals.CMS_DB_Pass + ";";

////        internal string ConnectionStringJAGUAR_DB = @"Provider=PostgreSQL OLE DB Provider;
////                                                 Data Source=" + Globals.odoo_ServerAddress + @";
////                                                 location=" + Globals.odoo_ActiveDB + @";
////                                                 User ID=" + Globals.odoo_DB_User + @";
////                                                 password=" + Globals.odoo_DB_Pass + @";";

//        internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.odoo_ServerAddress + @";
//                                                 Port=5432;
//                                                 Database=" + Globals.odoo_ActiveDB + @";
//                                                 User Id=" + Globals.odoo_DB_User + @";
//                                                 Password=" + Globals.odoo_DB_Pass + @";";

//        internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.odoo2_ServerAddress + @";
//                                                 Port=5432;
//                                                 Database=" + Globals.odoo2_ActiveDB + @";
//                                                 User Id=" + Globals.odoo2_DB_User + @";
//                                                 Password=" + Globals.odoo2_DB_Pass + @";";

//        internal string ConnectionStringJAGUAR_DB4 = @"Server=" + Globals.odoo4_ServerAddress + @";
//                                                 Port=5432;
//                                                 Database=" + Globals.odoo4_ActiveDB + @";
//                                                 User Id=" + Globals.odoo4_DB_User + @";
//                                                 Password=" + Globals.odoo4_DB_Pass + @";";

//        internal string ConnectionStringJAGUAR_DB5 = @"Server=" + Globals.odoo5_ServerAddress + @";
//                                                 Port=5432;
//                                                 Database=" + Globals.odoo5_ActiveDB + @";
//                                                 User Id=" + Globals.odoo5_DB_User + @";
//                                                 Password=" + Globals.odoo5_DB_Pass + @";";

//        internal string ConnectionStringAMS = @"Server=" + Globals.AMS_ServerName + @";
//                                                       Database=" + Globals.AMS_ActiveDB + @";
//                                                       User Id=" + Globals.AMS_DB_User + @";
//                                                       Password=" + Globals.AMS_DB_Pass + ";";

        internal string FTP_Tickets_LOSA = @"ftp://10.50.11.32/ALOSY/";
        internal string FTP_Tickets_ACS = @"ftp://10.50.11.32/Tickets/";
        internal string User_FTP_Server = "roger.euceda";
        internal string Password_UserFTPServer = "Aqua2021?";

        internal string FTP_BannerTv_PRD = @"ftp://10.50.11.32/BannerTV_PRD/";

        //       internal string ConnectionStringPRININ = @"Server=" + Globals.prinin_ServerAddress + @";
        //                                                   Database=" + Globals.prinin_ActiveDB + @";
        //                                                   User Id=" + Globals.prinin_DB_User + @";
        //                                                   Password=" + Globals.prinin_DB_Pass + ";";

        public bool ValidateStringIsNullOrEmpty(object val)
        {
            bool IsNull = true;
            try
            {
                IsNull = string.IsNullOrEmpty(val.ToString());
            }
            catch { }
            return IsNull;
        }

        /// <summary>
        /// Objeto de conexion para SAP
        /// </summary>
        /// <returns></returns>
        //public SAPbobsCOM.Company Company()
        //{
        //    SAPbobsCOM.Company oCmp;
        //    oCmp = new SAPbobsCOM.Company();
        //    oCmp.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2016;
        //    oCmp.LicenseServer = "10.50.11.31";
        //    oCmp.Server = "10.50.11.31";
        //    oCmp.CompanyDB = "AQUA";
        //    oCmp.UserName = "manager";
        //    oCmp.Password = "sapserver";
        //    int result = oCmp.Connect();
        //    if (result != 0)
        //        //CajaDialogo.Information("Conexion exitosa a " + oCmp.CompanyName);
        //    //else
        //        CajaDialogo.Error("No se pudo realizar la coneccion al server de SAP. Error en el objeto company. Error: " + oCmp.GetLastErrorDescription());

        //    return oCmp;
        //}

        public DataSet GetSelectData(string FixedQuery)
        {
            DataSet data = new DataSet();

            SqlConnection Conn = new SqlConnection(ConnectionStringJAGUAR_DB);
            Conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(FixedQuery, Conn);
            adapter.Fill(data);

            Conn.Close();

            return data;
        }


        public int APMS_Exec_SP_GetID(string Procedure_Name, SqlCommand command, SqlParameter returnParameter)
        {
            Int32 ID;

            SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);

            if (command.CommandType == CommandType.StoredProcedure)
            {
                command.Connection = conn;
                command.CommandText = Procedure_Name;
                conn.Open();
                command.ExecuteNonQuery();

                ID = Convert.ToInt32(returnParameter.Value);

                conn.Close();
            }
            else
            {
                ID = -1;
            }

            return ID;
        }

        public DataTable APMS_Exec_SP_Get_Data(string Procedure_Name, SqlCommand command)
        {
            DataTable data = new DataTable();

            SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);

            command.CommandText = Procedure_Name;
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            conn.Open();

            data.Load(command.ExecuteReader());

            conn.Close();

            return data;
        }


        public void APMS_Exec_SP(string Procedure_Name, SqlCommand command)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);

                if (command.CommandType == CommandType.StoredProcedure)
                {
                    command.Connection = conn;
                    command.CommandText = Procedure_Name;
                    conn.Open();
                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DataSet APMS_GetSelectData(string FixedQuery)
        {
            DataSet data = new DataSet();

            SqlConnection Conn = new SqlConnection(ConnectionStringJAGUAR_DB);
            Conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(FixedQuery, Conn);
            adapter.Fill(data);

            Conn.Close();

            return data;
        }


        //public SAPbobsCOM.Company Company(string puser, string ppass)
        //{
        //    SAPbobsCOM.Company oCmp; 
        //    oCmp = new SAPbobsCOM.Company();
        //    oCmp.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2016;
        //    //oCmp.LicenseServer = Globals.ServerlicenseSDK;
        //    //oCmp.Server = Globals.ServerSDK;
        //    //oCmp.CompanyDB = Globals.ActiveDBSDK;
        //    oCmp.UserName = puser;
        //    oCmp.Password = ppass;
        //    int result = oCmp.Connect();
        //    if (result != 0)
        //        //CajaDialogo.Information("Conexion exitosa a " + oCmp.CompanyName);
        //        //else
        //        CajaDialogo.Error("No se pudo realizar la coneccion al server de SAP. Error en el objeto company. Error: " + oCmp.GetLastErrorDescription());

        //    return oCmp;
        //}


        //public Boolean CompanyIsconected(string puser, string ppass)
        //{
        //    SAPbobsCOM.Company oCmp;
        //    oCmp = new SAPbobsCOM.Company();
        //    oCmp.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2016;
        //    //oCmp.LicenseServer = Globals.ServerlicenseSDK;
        //    //oCmp.Server = Globals.ServerSDK;
        //    //oCmp.CompanyDB = Globals.ActiveDBSDK;
        //    oCmp.UseTrusted = false;
        //    oCmp.UserName = puser;
        //    oCmp.DbUserName = "sa";
        //    //oCmp.DbPassword = Globals.SAP_DB_Pass;
        //    oCmp.Password = ppass;
        //    oCmp.language = SAPbobsCOM.BoSuppLangs.ln_Spanish_La;
        //    string error = "";
        //    int result = oCmp.Connect();
        //    if (result == 0)
        //    {
        //        oCmp.Disconnect();
        //        error = oCmp.GetLastErrorDescription();
        //        return true;
        //    }
        //    else
        //        oCmp.Disconnect();
        //    error = oCmp.GetLastErrorDescription();
        //    oCmp.Disconnect();
        //    return false;
        //}


        //public void ODOO_Exec_SP(string procedure_name, PgSqlCommand command)
        //{
        //    PgSqlConnection Conn = new PgSqlConnection(ConnectionStringJAGUAR_DB);
        //    Conn.Open();

        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = procedure_name;
        //    command.Connection = Conn;
        //    command.ExecuteNonQuery();

        //    Conn.Close();
        //}


        //public DataSet ODOO_GetSelectData(string FixedQuery)
        //{
        //    DataSet data = new DataSet();

        //    PgSqlConnection Conn = new PgSqlConnection(ConnectionStringJAGUAR_DB);
        //    //NpgSqlConnection Conn = new NpgSqlConnection(ConnectionStringJAGUAR_DB);
        //    Conn.Open();

        //    PgSqlCommand cmd = new PgSqlCommand(FixedQuery, Conn);
        //    PgSqlDataAdapter adapter = new PgSqlDataAdapter(cmd);

        //    adapter.Fill(data);

        //    Conn.Close();

        //    return data;
        //}

        //public DataSet ODOO_GetSP_Results(string ProcedureName, PgSqlCommand cmd)
        //{
        //    DataSet data = new DataSet();

        //    PgSqlConnection Conn = new PgSqlConnection(ConnectionStringJAGUAR_DB);

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = ProcedureName;
        //    cmd.Connection = Conn;

        //    Conn.Open();

        //    PgSqlDataAdapter adapter = new PgSqlDataAdapter(cmd);
        //    adapter.Fill(data);

        //    Conn.Close();

        //    return data;
        //}

        //public DataSet ODOO2_GetSP_Results(string ProcedureName, PgSqlCommand cmd)
        //{
        //    DataSet data = new DataSet();

        //    PgSqlConnection Conn = new PgSqlConnection(ConnectionStringJAGUAR_DB);

        //    //cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = ProcedureName;
        //    cmd.Connection = Conn;

        //    Conn.Open();

        //    PgSqlDataAdapter adapter = new PgSqlDataAdapter(cmd);
        //    adapter.Fill(data);

        //    Conn.Close();

        //    return data;
        //}
        ////public Boolean CompanyIsconected(string puser, string ppass)
        //{
        //    SAPbobsCOM.Company oCmp;
        //    oCmp = new SAPbobsCOM.Company();
        //    oCmp.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2016;
        //    oCmp.LicenseServer = Globals.ServerlicenseSDK;
        //    oCmp.Server = Globals.ServerSDK;
        //    oCmp.CompanyDB = Globals.ActiveDBSDK;
        //    oCmp.UserName = puser;
        //    oCmp.Password = ppass;
        //    int result = oCmp.Connect();
        //    if (result == 0)
        //    {
        //        oCmp.Disconnect();
        //        return true;
        //    }
        //    else
        //        oCmp.Disconnect();
        //    return false;
        //}
        //public SAPbobsCOM.Company Company(string puser, string ppass)
        //{
        //    SAPbobsCOM.Company oCmp;
        //    oCmp = new SAPbobsCOM.Company();
        //    oCmp.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2016;
        //    oCmp.LicenseServer = Globals.ServerlicenseSDK;
        //    oCmp.Server = Globals.ServerSDK;
        //    oCmp.CompanyDB = Globals.ActiveDBSDK;
        //    oCmp.UserName = puser;
        //    oCmp.Password = ppass;
        //    int result = oCmp.Connect();
        //    if (result != 0)
        //        //CajaDialogo.Information("Conexion exitosa a " + oCmp.CompanyName);
        //        //else
        //        CajaDialogo.Error("No se pudo realizar la coneccion al server de SAP. Error en el objeto company. Error: " + oCmp.GetLastErrorDescription());

        //    return oCmp;
        //}

        public DateTime dNow()
        {
            DateTime val = DateTime.Now;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringJAGUAR_DB);
                con.Open();
                string sql = @"SELECT getdate()";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                val = Convert.ToDateTime(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }

        public DateTime NowSetDateTime()
        {
            DateTime val = DateTime.Now;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringJAGUAR_DB);
                con.Open();
                string sql = @"dbo.sp_get_hour_server_cloud_adjust";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                val = Convert.ToDateTime(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }

        public string GetConnectionString() 
        {
            return ConnectionStringJAGUAR_DB;
        }

        #endregion

        #region ACS Related Methods

        /// <summary>
        /// Retorna el numero de materias primas inactivas en una formula
        /// </summary>
        /// <param name="idFormula">El id unico de la formula a buscar</param>
        /// <returns></returns>
        public int get_inactive_rm(int idFormula) 
        {
            DataTable ingredientes = new DataTable();
            int veces = 0;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@peso_total", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = idFormula;
            cmd.Parameters["@peso_total"].Value = Convert.ToDouble(2500);

            ingredientes = ACS_Exec_SP_Get_Data("PP_Plan_Ordenes_Get_Ingredientes", cmd);

            foreach (DataRow row in ingredientes.Rows) 
            {
                if (row["estado"].ToString() == "i") 
                {
                    veces++;
                }
            }

            return veces;
        }

        public DateTime Now()
        {
            DateTime date;
            try
            {
                string sql = "select CURRENT_TIMESTAMP";
                SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                date = Convert.ToDateTime(cmd.ExecuteScalar());
            }
            catch (Exception ec)
            {
                date = DateTime.Today;
                CajaDialogo.Error(ec.Message);
            }
            return date;
        }

        public DataSet ACS_GetSelectData(string FixedQuery)
        {
            DataSet data = new DataSet();

            SqlConnection Conn = new SqlConnection(ConnectionStringJAGUAR_DB);
            Conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(FixedQuery, Conn);
            adapter.Fill(data);

            Conn.Close();

            return data;
        }

        public int ACS_Exec_SP_GetID(string Procedure_Name, SqlCommand command, SqlParameter returnParameter)
        {
            Int32 ID;
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);

                if (command.CommandType == CommandType.StoredProcedure)
                {
                    command.Connection = conn;
                    command.CommandText = Procedure_Name;
                    conn.Open();
                    command.ExecuteNonQuery();

                    ID = Convert.ToInt32(returnParameter.Value);

                    conn.Close();
                }
                else
                {
                    ID = -1;
                }
            }
            catch (Exception ec)
            {

                throw new Exception(ec.Message);
            }
            

            return ID;
        }

        public void ACS_Exec_SP(string Procedure_Name, SqlCommand command)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);

                if (command.CommandType == CommandType.StoredProcedure)
                {
                    command.Connection = conn;
                    command.CommandText = Procedure_Name;
                    conn.Open();
                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public DataTable ACS_Exec_SP_Get_Data(string Procedure_Name, SqlCommand command)
        {
            DataTable data = new DataTable();

            SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);

            command.CommandText = Procedure_Name;
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 3000;//150; // xJV 29/03/2017

            conn.Open();

            data.Load(command.ExecuteReader());

            conn.Close();

            return data;
        }

        public int ACS_InsertAndReturnID(string Command)
        {
            Int32 InsertedID;
            SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);
            conn.Open();

            SqlCommand cmd = new SqlCommand(Command, conn);

            InsertedID = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return InsertedID;
        }

        public void ACS_DoSmallDBOperation(string Command)
        {
            SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);
            conn.Open();

            SqlCommand cmd = new SqlCommand(Command, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public int bas_return_M_ship_id(int idarribodetalle)
        {
            int idh;
            string query = @"SELECT [id_shiph]
                              FROM[dbo].[TS_ship_d]
                              where enable = 1 and id = " + idarribodetalle;
            try
            {
                SqlConnection cn = new SqlConnection(ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if ( dr.Read())
                {
                    idh = Convert.ToInt32(dr[0].ToString());
                    dr.Close();
                    cn.Close();
                    string qry = @"SELECT [shipid]
                                  FROM [dbo].[TS_ship_h]
                                  where id = "+idh;
                    cn.Open();
                    cmd = new SqlCommand(qry, cn);
                    SqlDataReader drr = cmd.ExecuteReader();
                    if (drr.Read())
                    {
                        return Convert.ToInt32(drr[0].ToString());
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public void ACS_DoSmallDBOperationBas(string Command)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);
                conn.Open();

                SqlCommand cmd = new SqlCommand(Command, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public string Isnulldata(object x)
        {
            string campo;
            if (x == DBNull.Value)
            {
                campo = " ";
            }
            else
            {
                campo = Convert.ToString(x);
            }
            return campo;

        }

        #endregion

        #region APMS Related Methods

       

    

       
        public int basculaDB_Return_int(String quere)
        {
            int result = 0;
            SqlConnection cn = new SqlConnection(ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(quere, cn);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                return result;
                //CajaDialogo.Error("Error en operacion");
            }
        }

        public string basculaDB_Return_string(String quere)
        {
            string result = "";
            SqlConnection cn = new SqlConnection(ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(quere, cn);
                result = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                return result;
                //CajaDialogo.Error("Error en operacion");
            }
        }
        public string Nexcode(int id_secuencia) // Generar codigo para Bascula!
        {
            string nextcode = "";
            string prefijo = "";
            string siguiente = "";
            try
            {
                string query = @"SELECT 
                              [prefijo]
                              ,[siguiente]
                          FROM [dbo].[conf_tables_id]
                          where id = " + id_secuencia;
                SqlConnection cn = new SqlConnection(ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prefijo = dr[0].ToString();
                    siguiente = dr[1].ToString();
                    
                    for (int i = siguiente.Length; i < 6; i++)
                    {
                        siguiente = "0" + siguiente;
                    }
                    nextcode = prefijo + siguiente;
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error al generar el codigo no se ha podido obtener el codigo siguiente.";
              
            }

            return nextcode;
        }
       
        public void updatesecuence(int id_secuencia)
        {
            try
            {
                string Query = @"UPDATE [dbo].[conf_tables_id]
                               SET
                                  [siguiente] = siguiente + 1
                             WHERE id = " + id_secuencia;
                SqlConnection cn = new SqlConnection(ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                
            }
        }
   

      

       
        #endregion

        #region ODOO Related Methods

        //public DataSet ODOO_GetSelectData(string FixedQuery)
        //{
        //    DataSet data = new DataSet();

        //    NpgsqlConnection Conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);
        //    Conn.Open();

        //    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(FixedQuery, Conn);
        //    adapter.Fill(data);

        //    Conn.Close();

        //    return data;
        //}
        public DataSet SAP_GetSelectData(string FixedQuery)
        {
            DataSet data = new DataSet();

            SqlConnection Conn = new SqlConnection(ConnectionStringJAGUAR_DB);
            Conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(FixedQuery, Conn);
            adapter.Fill(data);

            Conn.Close();

            return data;
        }

        //public DataSet ODOO_GetSP_Results(string ProcedureName, NpgsqlCommand cmd)
        //{
        //    DataSet data = new DataSet();

        //    NpgsqlConnection Conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = ProcedureName;
        //    cmd.Connection = Conn;

        //    Conn.Open();

        //    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
        //    adapter.Fill(data);

        //    Conn.Close();

        //    return data;
        //}

        //public DataSet ODOO2_GetSP_Results(string ProcedureName, NpgsqlCommand cmd)
        //{
        //    DataSet data = new DataSet();

        //    NpgsqlConnection Conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);

        //    //cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = ProcedureName;
        //    cmd.Connection = Conn;

        //    Conn.Open();

        //    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
        //    adapter.Fill(data);

        //    Conn.Close();

        //    return data;
        //}

        //public Double ODOO_Get_Exchange_Rate(int currency_id, string date)
        //{
        //    string query = string.Format(@"SELECT rate
	       //                                  FROM public.res_currency_rate
        //                                    WHERE currency_id = {0}
        //                                      AND x_fecha = to_date('{1}','MM-dd-yyyy')", currency_id, date);

        //    return Convert.ToDouble(ODOO_GetSelectData(query).Tables[0].Rows[0][0].ToString());
        //}

        //public void ODOO_Exec_Command(string FixedQuery, NpgsqlCommand cmd)
        //{
        //    NpgsqlConnection Conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);
        //    Conn.Open();
        //    NpgsqlTransaction trans = Conn.BeginTransaction();

        //    cmd.CommandText = FixedQuery;
        //    cmd.Connection = Conn;
        //    cmd.ExecuteNonQuery();

        //    trans.Commit();
        //    Conn.Close();
        //}

        //public void ACS_Exec_Command(string FixedQuery, NpgsqlCommand cmd)
        //{
        //    NpgsqlConnection Conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);
        //    Conn.Open();
        //    NpgsqlTransaction trans = Conn.BeginTransaction();

        //    cmd.CommandText = FixedQuery;
        //    cmd.Connection = Conn;
        //    cmd.ExecuteNonQuery();

        //    trans.Commit();
        //    Conn.Close();
        //}

        //public void ODOO_Exec_SP(string procedure_name, NpgsqlCommand command) 
        //{
        //    NpgsqlConnection Conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);
        //    Conn.Open();

        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = procedure_name;
        //    command.Connection = Conn;
        //    command.ExecuteNonQuery();

        //    Conn.Close();
        //}

        //public int ODOO_Exec_SP_GetID(string procedure_name, NpgsqlCommand command, NpgsqlParameter returnParameter)
        //{
        //    //Antes: SqlParameter returnParameter
        //    //NpgsqlConnection Conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);
        //    //Conn.Open();

        //    //command.CommandType = CommandType.StoredProcedure;
        //    //command.CommandText = procedure_name;
        //    //command.Connection = Conn;
        //    //command.ExecuteNonQuery();

        //    //Int32 ID = Convert.ToInt32(returnParameter.Value);

        //    //Conn.Close();

        //    //return ID;

        //    Int32 ID;

        //    NpgsqlConnection Conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);

        //    command.Connection = Conn;
        //    command.CommandText = procedure_name;
        //    Conn.Open();

        //    command.CommandType = CommandType.StoredProcedure;
        //    //command.ExecuteNonQuery();
        //    ID = Convert.ToInt32(command.ExecuteScalar());

        //    //ID = Convert.ToInt32(returnParameter.Value);

        //    Conn.Close();

        //    return ID;


        //}

        //public int ODOO_InsertAndReturnID(string Command)
        //{
        //    Int32 InsertedID;
        //    NpgsqlConnection conn = new NpgsqlConnection(ConnectionStringJAGUAR_DB);
        //    conn.Open();

        //    NpgsqlCommand cmd = new NpgsqlCommand(Command, conn);

        //    InsertedID = Convert.ToInt32(cmd.ExecuteScalar());

        //    conn.Close();

        //    return InsertedID;
        //}

        //public void ODOO_DoSmallDBOperation(string Command)
        //{
        //    NpgsqlConnection con = new NpgsqlConnection(ConnectionStringJAGUAR_DB);
        //    con.Open();

        //    NpgsqlCommand cmd = new NpgsqlCommand(Command, con);
        //    cmd.ExecuteNonQuery();

        //    con.Close();
        //}

        #endregion

        #region WinCC_6_2 (Old Production) Related Methods
        
        public void WinCC_Exec_SP(string Procedure_Name, SqlCommand command)
        {
            SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);

            if (command.CommandType == CommandType.StoredProcedure)
            {
                command.Connection = conn;
                command.CommandText = Procedure_Name;
                conn.Open();
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public DataSet GetSelectData_SetServer(string FixedQuery, string SelectedServer)
        {
            DataSet data = new DataSet();

            SqlConnection Conn = new SqlConnection(string.Format("Server={0}{1}", SelectedServer, ConnectionStringJAGUAR_DB));
            Conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(FixedQuery, Conn);
            adapter.Fill(data);

            Conn.Close();

            return data;
        }

        #endregion

        #region Custom Methods
        //Method Implemented and Improved in the SecOps Class
        //public void SendEmailAlert(DataSet Receivers, int ColumnNumber, string Subject, string Body)
        //{
        //    MailMessage message = new MailMessage();
        //    SmtpClient smtp = new SmtpClient();

        //    message.From = new MailAddress("noreply@aquafeedhn.com", "Quality Data Analysis System v1.0");

        //    foreach (DataRow row in Receivers.Tables[0].Rows)
        //    {
        //        message.To.Add(new MailAddress(row[ColumnNumber].ToString()));
        //    }

        //    message.Subject = Subject;
        //    message.Body = Body;

        //    smtp.EnableSsl = false;
        //    smtp.Port = 80;
        //    smtp.Host = "smtpout.secureserver.net";
        //    smtp.UseDefaultCredentials = true;
        //    smtp.Credentials = new NetworkCredential("scans@aquafeedhn.com", "A1dd1cf460&");
        //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

        //    smtp.Send(message);
        //}

        #endregion

        #region Nutreco Related Methods

        //public DataSet PRININ_GetSelectData(string FixedQuery)
        //{
        //    DataSet data = new DataSet();

        //    SqlConnection Conn = new SqlConnection(ConnectionStringPRININ);
        //    Conn.Open();

        //    SqlDataAdapter adapter = new SqlDataAdapter(FixedQuery, Conn);
        //    adapter.Fill(data);

        //    Conn.Close();

        //    return data;
        //}

        #endregion

        #region Not Implemented Methods

        //public DataSet H_GetSelectData(string FixedQuery)
        //{
        //    DataSet data = new DataSet();

        //    SqlConnection Conn = new SqlConnection(ConnectionStringJAGUAR_DB_History);
        //    Conn.Open();

        //    SqlDataAdapter adapter = new SqlDataAdapter(FixedQuery, Conn);
        //    adapter.Fill(data);

        //    Conn.Close();

        //    return data;
        //}

        //public int H_InsertAndReturnID(string Command)
        //{
        //    Int32 InsertedID;
        //    SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB_History);
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand(Command, conn);

        //    InsertedID = Convert.ToInt32(cmd.ExecuteScalar());

        //    conn.Close();

        //    return InsertedID;
        //}

        //public void H_DoSmallDBOperation(string Command)
        //{
        //    SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB_History);
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand(Command, conn);
        //    cmd.ExecuteNonQuery();

        //    conn.Close();
        //}

        public void NewLogEntry(string user, string location, string action)
        {
            string Command = @" INSERT INTO [QDAS].[dbo].[QDAS_Logs]
		                                    ([date],[time],[user],[location],[action])
                                     VALUES (SYSDATETIME(),SYSDATETIME()," + user + ",'" + location + "','" + action + "')";

            SqlConnection conn = new SqlConnection(ConnectionStringJAGUAR_DB);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Command, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        internal int Exec_SP_GetID()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Funciones
        public decimal ValidateNumberDecimal(object val)
        {
            decimal valor = 0;
            try
            {
                valor = Convert.ToDecimal(val);
            }
            catch { }
            return valor;
        }


        public int ValidateNumberInt32(object val)
        {
            int valor = 0;
            try
            {
                valor = Convert.ToInt32(val);               
                //valor = (int)val;
            }
            catch 
            {
                string vals;
                try
                {
                    vals = val.ToString();
                    decimal valDecimal = Convert.ToDecimal(val);
                    valor = Decimal.ToInt32(valDecimal);
                }
                catch
                {
                    valor = 0;
                }
            }
            return valor;
        }

        public string ValidateNumberString(object val)
        {
            string valor = "";
            try
            {
                valor = val.ToString();
            }
            catch { }
            return valor;
        }

        public bool ValidateNumberStringText(object val)
        {
            bool r = false;
            string valor = "";
            try
            {
                valor = val.ToString();
                if (string.IsNullOrEmpty(valor))
                    r = false;
                else
                    r = true;
            }
            catch { }
            return r;
        }

        #endregion


        #region Propiedades
        public string AssemblyVersion
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                }
            }
        }

        #endregion

        #region Enums
        public enum TablesID
        {
            PT_ProductoTerminado=1,
            FormulaH=2,
            MateriaPrima=3,
            Proveedores=4
        }

        public enum TipoTransaccionesCRUD
        {
            Nuevo=1,
            Editar=2,
            Eliminar=3
        }

        public enum ClaseTipoPresentacion
        {
            Ingredientes_O_MP = 1,
            EmpaquePT = 2,
            RecepcionCompra = 3,
            MaterialEmpaque = 4
        }
        #endregion
    }
}
