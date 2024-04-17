    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACS.Classes
{
    //enum listaAmbientes{ Produccion, Desarrollo, HAMACHI };

    public class Globals
    {
        //Cambiar aqui: ------------------------------------
        //listaAmbientes value = listaAmbientes.Desarrollo;
        //--------------------------------------------------

        public enum Especies
        {
            Tilapia = 1,
            Camaron = 2
        }
        #region Credenciales Producción


        //Jaguar

        //public static string JAGUAR_ServerAddress = "mssql-123688-0.cloudclusters.net,18285";
        //public static string JAGUAR_ServerName = "mssql-123688-0.cloudclusters.net,18285";
        public static string JAGUAR_ServerAddress = "mssql-137225-0.cloudclusters.net,10006";
        public static string JAGUAR_ServerName = "Servidor Producción";
        //public static string JAGUAR_ServerName = "DESKTOP-P55C1OL";
        //public static string JAGUAR_ServerAddress = "DESKTOP-P55C1OL";

        //public static string JAGUAR_ServerAddress = "10.101.0.204";
        //public static string JAGUAR_ServerName = "10.101.0.204";
        public static string JAGUAR_ActiveDB = "ImportadoraV";
        public static string JAGUAR_DB_User = "importadora_db";
        public static string JAGUAR_DB_Pass = "ProyProgres02024HN";
        //public static string JAGUAR_DB_Pass = "Alza2023*";

        //Jaguar Server Fisico
        //public static string JAGUAR_ServerAddress = @"PANSVR01\PANSVR01";
        //public static string JAGUAR_ServerName = @"PANSVR01\PANSVR01";
        //public static string JAGUAR_ActiveDB = "JAGUAR_DB";
        //public static string JAGUAR_DB_User = "sa";
        //public static string JAGUAR_DB_Pass = " tBW3DER7";
        //

        //Jaguar Server Local Oliva
        //public static string JAGUAR_ServerAddress = @"7L12TV3\MSSQL_7L12TV3";
        //public static string JAGUAR_ServerName = @"7L12TV3\MSSQL_7L12TV3";
        //public static string JAGUAR_ActiveDB = "JAGUAR_DB";
        //public static string JAGUAR_DB_User = "sa";
        //public static string JAGUAR_DB_Pass = "Aq4x_3Fj2#";


        #endregion

        #region Credenciales Pruebas AQFSVR007\\AQFSVR007

        ////WINCC
        //public static string CMS_ServerPellet = "AQFSVR003";
        //public static string CMS_ServerExtruder = "AQFSVR003";
        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "";
        //public static string CMS_ActiveDB = "process_data";

        ////Ttrace
        //public static string ServerAddress = "AQFSVR007\\AQFSVR007";
        //public static string ServerName = "Servidor Productivo";
        //public static string ActiveDB = "ACS";
        //public static string DB_User = "sa";
        //public static string DB_Pass = "AquaF33dHN2014";

        ////ACS(Costos)
        //public static string CTS_ServerAddress = "AQFSVR007\\AQFSVR007";
        //public static string CTS_ServerName = "Servidor Productivo";
        //public static string CTS_ActiveDB = "ACS";
        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "AquaF33dHN2014";

        //////Bascula nueva version (desarrollo)
        //public static string Bas_ServerAddress = "AQFSVR007\\AQFSVR007";
        //public static string Bas_ServerName = "Servidor Desarrollo";
        //public static string Bas_ActiveDB = "BASCULA";
        //public static string Bas_DB_User = "sa";
        //public static string Bas_DB_Pass = "AquaF33dHN2014";

        ////LOSA
        //public static string LOSA_ServerAddress = "AQFSVR007\\AQFSVR007";
        //public static string LOSA_ServerName = "AQFSVR007\\AQFSVR007";
        //public static string LOSA_ActiveDB = "LOSA"; //BASE PRODUCTIVA
        ////public static string LOSA_ActiveDB = "LOSA2"; //BASE DE PRUEBAS
        //public static string LOSA_DB_User = "sa";
        //public static string LOSA_DB_Pass = " AquaF33dHN2014";

        //////LOSA Desarrollo
        ////public static string LOSA_ServerName = $"AQFSVR007\\AQFSVR007";
        ////public static string LOSA_ServerAddress = $"AQFSVR007\\AQFSVR007";
        ////public static string LOSA_ActiveDB = "LOSA";
        ////public static string LOSA_DB_User = "sa";
        ////public static string LOSA_DB_Pass = "AquaF33dHN2014";

        ////LOSA local Roger Euceda
        ////public static string LOSA_ServerAddress = @"ADRE5079CP\SQLEXPRESS2014";
        ////public static string LOSA_ServerName = @"ADRE5079CP\SQLEXPRESS2014";
        ////public static string LOSA_ActiveDB = "LOSA";
        ////public static string LOSA_DB_User = "sa";
        ////public static string LOSA_DB_Pass = "ABC123xyz";

        ////SAP
        //public static string SAP_ServerAddress = @"AQFSVR006\AQFSVR006";
        //public static string SAP_ServerName = "Servidor de Desarrollo";
        //public static string SAP_ActiveDB = "AQUA";
        //public static string SAP_DB_User = "sa";
        //public static string SAP_DB_Pass = "Aqua2018";


        //// APMS(Aquafeed Pocess Management System)
        //public static string APMS_Server = @"AQFSVR008\AQFSVR008";
        //public static string APMS_DB_User = "sa";
        //public static string APMS_DB_Pass = "AquaF33dHN2017";
        //public static string APMS_ActiveDB = "APMS";

        ////public static string APMS_Server = @"AQFSVR007\AQFSVR007";
        ////public static string APMS_DB_User = "sa";
        ////public static string APMS_DB_Pass = "AquaF33dHN2014";
        ////public static string APMS_ActiveDB = "APMS";

        ////ODOO
        //public static string odoo_ServerAddress = "AQFSVR003";
        //public static string odoo_ServerName = "Servidor Productivo";
        //public static string odoo_ActiveDB = "aquafeed";
        //public static string odoo_DB_User = "aquafeed";
        //public static string odoo_DB_Pass = "Aqua3820";

        ////ODOO2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "AFF";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";


        ////ODOO4
        //public static string odoo4_ServerAddress = "AQFSVR003";
        //public static string odoo4_ServerName = "Servidor Productivo";
        //public static string odoo4_ActiveDB = "odoo_sap";
        //public static string odoo4_DB_User = "aquafeed";
        //public static string odoo4_DB_Pass = "Aqua3820";


        //////Promix -- TEST ---
        //public static string prinin_ServerAddress = "9DR5P32";
        //public static string prinin_ServerName = "Development Server";
        //public static string prinin_ActiveDB = "PRININ";
        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "";

        ////SAP
        //public static string ActiveDBSDK = "AQUA_AF";
        //public static string ServerSDK = "10.50.11.31";
        //public static string ServerlicenseSDK = "10.50.11.31";
        #endregion

        internal string ConnectionStringJAGUAR_DB = @"Server=" + Globals.JAGUAR_ServerName + @";
                                                       Database=" + Globals.JAGUAR_ActiveDB + @";
                                                       User Id=" + Globals.JAGUAR_DB_User + @";
                                                       Password=" + Globals.JAGUAR_DB_Pass + ";";


        #region Credenciales Desarrollo
        ////WINCC
        //public static string CMS_ServerPellet = @"JFTDF12\SQLEXPRESS";
        //public static string CMS_ServerExtruder = @"JFTDF12\SQLEXPRESS";
        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "AquaFeed2016";
        //public static string CMS_ActiveDB = "process_data";

        ////APMS (Aquafeed Pocess Management System)
        ////public static string APMS_Server        = @"JFTDF12\SQLEXPRESS";
        //public static string APMS_Server = @"localhost";
        //public static string APMS_DB_User = "sa";
        //public static string APMS_DB_Pass = "AquaFeed2016";
        //public static string APMS_ActiveDB = "APMS";

        ////ACS (Aquafeed Costing System)
        ////ACS (Costos)
        //public static string CTS_ServerAddress = @"F3DYSQ2\MSSQLSERVER2";
        //public static string CTS_ServerName = @"F3DYSQ2\MSSQLSERVER2";
        //public static string CTS_ActiveDB = "ACS";
        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "Aqua2018";

        ////Odoo
        //public static string odoo_ServerAddress = "AQFSVR003";
        //public static string odoo_ServerName = "Servidor Productivo";
        //public static string odoo_ActiveDB = "RRHH";
        //public static string odoo_DB_User = "aquafeed";
        //public static string odoo_DB_Pass = "Aqua3820";


        ////ODOO2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "AFF";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";

        //////ODOO4
        //public static string odoo4_ServerAddress = "AQFSVR003";
        //public static string odoo4_ServerName = "Servidor Productivo";
        //public static string odoo4_ActiveDB = "odoo_sap";
        //public static string odoo4_DB_User = "aquafeed";
        //public static string odoo4_DB_Pass = "Aqua3820";


        ////Promix
        //public static string prinin_ServerAddress = "9DR5P32";
        //public static string prinin_ServerName = "Development Server";
        //public static string prinin_ActiveDB = "PRININ";
        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "";

        ////SAP
        //public static string SAP_ServerAddress = @"AQFSVR006";
        //public static string SAP_ServerName = "Servidor de Desarrollo";
        //public static string SAP_ActiveDB = "AQUA";
        //public static string SAP_DB_User = "sa";
        //public static string SAP_DB_Pass = "Aqua2018";


        #endregion

        #region Credenciales Desarrollo
        ////WINCC
        //public static string CMS_ServerPellet = @"JFTDF12\SQLEXPRESS";
        //public static string CMS_ServerExtruder = @"JFTDF12\SQLEXPRESS";
        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "AquaFeed2016";
        //public static string CMS_ActiveDB = "process_data";

        //APMS (Aquafeed Pocess Management System)
        //public static string APMS_Server        = @"JFTDF12\SQLEXPRESS";
        //public static string APMS_Server = @"localhost";
        //public static string APMS_DB_User = "sa";
        //public static string APMS_DB_Pass = "AquaFeed2016";
        //public static string APMS_ActiveDB = "APMS";

        //ACS (Aquafeed Costing System)
        //ACS (Costos)
        //public static string CTS_ServerAddress = "6XJ7QD2-PC";
        //public static string CTS_ServerName = "6XJ7QD2-PC";
        //public static string CTS_ActiveDB = "ACS";
        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "Marathon00";

        //Odoo2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "RRHH";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";


        //ODOO2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "AFF";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";

        ////ODOO4
        //public static string odoo4_ServerAddress = "AQFSVR003";
        //public static string odoo4_ServerName = "Servidor Productivo";
        //public static string odoo4_ActiveDB = "odoo_sap";
        //public static string odoo4_DB_User = "aquafeed";
        //public static string odoo4_DB_Pass = "Aqua3820";


        //Promix
        //public static string prinin_ServerAddress = "9DR5P32";
        //public static string prinin_ServerName = "Development Server";
        //public static string prinin_ActiveDB = "PRININ";
        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "Promix1620";
        //public static string prinin_DB_Pass = "Promix1620";
        #endregion

        #region Credenciales Desarrollo (HAMACHI)
        ////WINCC
        //public static string CMS_ServerPellet = "25.15.38.196";
        //public static string CMS_ServerExtruder = "25.15.38.196";

        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "AquaFeed2016";
        //public static string CMS_ActiveDB = "process_data";

        ////ACS (Costos)
        //public static string CTS_ServerAddress = "25.15.38.196";
        //public static string CTS_ServerName = "Servidor de Desarrollo";
        //public static string CTS_ActiveDB = "ACS";

        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "AquaFeed2016";

        ////ODOO
        //public static string odoo_ServerAddress = "25.15.38.196";
        //public static string odoo_ServerName = "Servidor de Desarrollo";
        //public static string odoo_ActiveDB = "pruebas";

        //public static string odoo_DB_User = "aquafeed"; //"aquafeed";
        //public static string odoo_DB_Pass = "Aqua3820";
        #endregion
    }
}