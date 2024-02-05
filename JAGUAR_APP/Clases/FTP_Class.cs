using ACS.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class FTP_Class
    {
        public FTP_Class()
        {

        }

        public bool GuardarArchivo(UserLogin pUsuarioLogeado, string pFileName, string pathFile)
        {
            bool Guardado = false;
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_Tickets_LOSA + pFileName);
                //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                string pass = "Tempo1234";
                string user_op = "operador";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                //request.Credentials = new NetworkCredential(user_op, pass);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                //request.EnableSsl = false;

                using (Stream fileStream = File.OpenRead(pathFile))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                    Guardado = true;
                }
            }
            catch(Exception ec)
            {
                throw new Exception(ec.Message);
            }

            return Guardado;
        }

        public void DownloadFile(string pathSource, string pathDestination, UserLogin pUsuarioLogeado)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string pass = "Tempo1234";
                string user_op = "operador";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                //request.Credentials = new NetworkCredential(user_op, pass);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestination))
                {
                    ftpStream.CopyTo(fileStream);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
