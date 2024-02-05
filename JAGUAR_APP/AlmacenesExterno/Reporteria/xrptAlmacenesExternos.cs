using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using System.Data.SqlClient;
using JAGUAR_APP.AlmacenesExterno.Models;

namespace JAGUAR_APP.AlmacenesExterno.Reporteria
{
    public partial class xrptAlmacenesExternos : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptAlmacenesExternos(int id_h)
        {
            InitializeComponent();

            try
            {
                InfoHeaderRptIngreso infoHeaderRptIngreso = new InfoHeaderRptIngreso();

                if (infoHeaderRptIngreso.RecuperarRegistro(id_h))
                {
                    xlrProveedor.Text = infoHeaderRptIngreso.Proveedor;
                    xrlCiudad.Text = infoHeaderRptIngreso.Ciudad;
                    xrlPais.Text = infoHeaderRptIngreso.Pais;
                    xrlDireccion.Text = infoHeaderRptIngreso.Direccion;
                    xrlFecha.Text = infoHeaderRptIngreso.FechaIngreso.ToString("dd/MM/yyyy") ;
                    xrlTiempo.Text = infoHeaderRptIngreso.FechaIngreso.ToShortTimeString();
                }

                xrlIngreso.Text = "Informe de lotes en documento: "+id_h;

                sqlDataSource1.Queries[0].Parameters[0].Value = id_h;

                //    cnx.Close();

                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //sqlDataSource1.fil
        }

    }
}
