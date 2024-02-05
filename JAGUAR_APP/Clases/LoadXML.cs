using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Data.SqlClient;

//using Microsoft.Office.Interop.Excel;
using System.IO;
using ACS.Classes;

namespace JAGUAR_APP.Classes
{
    class LoadXML
    {
        string VarRuta;
        string VarPathExcel;

        public string VarPathExcelPar
        {
            get { return VarPathExcel; }
            set { VarPathExcel = value; }
        }
        public LoadXML(string ParRutaXml)
        {
            VarRuta = ParRutaXml;
            //VarPathExcelPar = PatchExcel();

        }


        public DataSet Dosomething()
        {
            DataSet ds = new DataSet();
            XmlTextReader xmlTexts = new XmlTextReader(VarRuta);
           
            ds.ReadXml(VarRuta);
            return ds;
        }
        public string PatchExcel()
        {
            if (File.Exists(VarRuta))
            {
                //System.Data.DataTable dt = new System.Data.DataTable();
                //DataSet ds = new DataSet();
                //XmlTextReader xmlTexts = new XmlTextReader(VarRuta);
                string newPath = VarRuta.Remove(VarRuta.Length - 4,VarRuta.Length);
                newPath = newPath + ".xls";
                System.IO.File.Copy(VarRuta,newPath);
                return newPath;

            }
            else
            {
                CajaDialogo.Error("La ruta no existe.");
                return "NUll";
            }
        }
    }
}
