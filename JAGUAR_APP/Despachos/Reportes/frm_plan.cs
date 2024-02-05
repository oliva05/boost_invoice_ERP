using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using ACS.Classes;
using System.Reflection;

namespace JAGUAR_APP.Despachos.Reportes
{
    public partial class frm_plan : DevExpress.XtraReports.UI.XtraReport
    {
        public int Id_despachos;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frm_plan(int Pid_despacho, UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            lblVersionALOSY.Text = AssemblyVersion;
            UsuarioLogeado = pUsuarioLogeado;
            lblUser.Text = pUsuarioLogeado.NombreUser;
            Id_despachos = Pid_despacho;
            load_header();
            load_detalle();
        }

        public void load_header() 
        {
            string query = @"sp_data_load_rpt_plan_v1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id_despachos);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtid_documento.Text = Id_despachos.ToString();
                    txtfecha.Text = string.Format("{0:dd/MM/yyyy}", dr.GetDateTime(2));
                    txtvehiculo.Text = dr.GetString(5);
                    txtboleta.Text = dr.GetInt32(3).ToString();
                    txtfurgon.Text = dr.GetString(6);
                    txtcodigoCLiente.Text = dr.GetString(7);
                    txtcliente.Text = dr.GetString(9);
                    txtMotorista.Text = lblMotoristaFirma.Text = dr.GetString(10);
                    lblIdentidadNumberMotorista.Text = dr.GetString(11);
                    lblDestino.Text = dr.GetString(12);
                }
               
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
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

        public void load_detalle() 
        {
            string query = @"sp_data_load_rpt_plan_detalle_v1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id_despachos);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporte1.detalle.Clear();
                da.Fill(dsReporte1.detalle);
                cn.Close();
            }
            catch (Exception ex )
            {

                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
