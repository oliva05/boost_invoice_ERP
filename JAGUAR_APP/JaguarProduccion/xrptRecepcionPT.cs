using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_APP.JaguarProduccion
{
    public partial class xrptRecepcionPT : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptRecepcionPT()
        {
            InitializeComponent();
            //Load();
            var i=this.Orden_Fabricacion_ID.Value;

        }
        //private void Load()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();

        //        //long id_h = Convert.ToInt32(this.Parameters[0].Value);

        //        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
        //        {
        //            cnx.Open();
        //            SqlDataAdapter da = new SqlDataAdapter("dbo.rpt_pt_recibido_by_id_order_production", cnx);
        //            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //            da.SelectCommand.Parameters.Add("id", this.Orden_Fabricacion_ID.Value);

        //            dsLogisticaJaguar1.Recepcion_Bolsas.Clear();
        //            da.Fill(dsLogisticaJaguar1.Recepcion_Bolsas);


        //            cnx.Close();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        CajaDialogo.Error(ex.Message);
        //    }
        //}

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            //Load();
        }

        private void xrptRecepcionPT_ParametersRequestValueChanged(object sender, DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs e)
        {
            //Load();

        }

        private void xrptRecepcionPT_BeforePrint(object sender, CancelEventArgs e)
        {
            //Load();

        }

        private void Detail_BeforePrint(object sender, CancelEventArgs e)
        {
            //Load();

        }
    }
}
