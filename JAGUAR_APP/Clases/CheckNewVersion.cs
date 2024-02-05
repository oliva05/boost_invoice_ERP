using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
   public class CheckNewVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Revision { get; set; }
        public int Build { get; set; }

    //public bool ValidarSiHayNuevaVersion()
    //{
    //    DataOperations dp = new DataOperations();
    //    SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
    //    string SQL = @"SELECT TOP 1  major,minor,revision,build
    //                    FROM dbo.ALOSY_notificaciones_actualizaciones_bitacora
    //                    ORDER BY id DESC";

    //    SqlCommand cmd = new SqlCommand(SQL,cnx);

    //    cmd.CommandType = System.Data.CommandType.Text;

    //    SqlDataReader dr = cmd.ExecuteReader();

    //    while (dr.Read())
    //    {
    //            Major = dr.GetInt32(0);
    //            Minor = dr.GetInt32(1);
    //            Revision = dr.GetInt32(2);
    //            Build = dr.GetInt32(3);
    //    }
    //        int currentVersion = Convert.ToInt32(string.Concat(Major,Minor,Revision,Build));



    //        if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
    //        {
    //            Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
    //            int checkingForNewVersion = Convert.ToInt32(string.Concat(ver.Major, ver.Minor, ver.Revision, ver.Build));

    //            if (checkingForNewVersion>currentVersion)
    //            {
    //                //Insertar registro en tabla de notificacion

    //            }
    //        }
    //        else
    //        {
    //            var ver = Assembly.GetExecutingAssembly().GetName().Version;
    //            //return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
    //        }

    //    }

    }
}
