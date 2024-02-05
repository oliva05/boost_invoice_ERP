using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using ACS.Classes;
using System.Data;
using System.Reflection;

namespace JAGUAR_APP.Despachos.Reportes
{
    public partial class rpt_despacho : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        int ParId;
        public rpt_despacho(int idDespacho)
        {
            InitializeComponent();
            lblVersionALOSY.Text = AssemblyVersion;
            ParId = idDespacho;
            load_informacio();
        }

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
        public void load_informacio()
        {
            string Query = @"EXEC	[dbo].[sp_load_despacho_header]
		                            @iddespacho = @ID";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ParId;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCardCode.Text = dr.GetString(1);
                    txtCardName.Text = dr.GetString(2);
                    txtItemCode.Text = dr.GetString(3);
                    txtItemName.Text = dr.GetString(4);
                    txtcantidad.Text = dr.GetInt32(7).ToString();
                    txtplaca.Text    = dr.GetString(9);
                    txtfurgon.Text   = dr.GetString(10);
                }
                dr.Close();
                cn.Close();

                Query  = @"EXEC [dbo].[sp_load_despacho_detalle]
		                        @iddespacho = @ID";
                SqlConnection Conexion = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                Conexion.Open();
                SqlCommand Comando = new SqlCommand(Query, cn);
                Comando.Parameters.Add("@ID", SqlDbType.Int).Value = ParId;
                SqlDataAdapter da  = new SqlDataAdapter(Comando);
                ds_despachos1.despachos.Clear();
                da.Fill(ds_despachos1.despachos);
                Conexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         

        }

    }
}
