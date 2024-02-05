using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.ACS.RRHH
{
    public partial class frmReporteAsistencia : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmReporteAsistencia(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadDatos();
            LoadDatosEntradas();
        }

        private void LoadDatos()
        {
            if (string.IsNullOrEmpty(dt_inicial.Text))
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                dt_inicial.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dt_final.Text))
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                dt_final.Focus();
                return;
            }

            if (dt_final.DateTime< dt_inicial.DateTime)
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_load_marcas_turno_by_day", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dt_inicial", dt_inicial.DateTime);
                cmd.Parameters.AddWithValue("@dt_final", dt_final.DateTime);
                dsRRHH_reportes1.resumen_asistencia.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRRHH_reportes1.resumen_asistencia);

                con.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDatosEntradas()
        {
            if (string.IsNullOrEmpty(dt_inicial.Text))
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                dt_inicial.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dt_final.Text))
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                dt_final.Focus();
                return;
            }

            if (dt_final.DateTime < dt_inicial.DateTime)
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_marcas_turno_by_day_for_email]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dt_inicial", dt_inicial.DateTime);
                cmd.Parameters.AddWithValue("@dt_final", dt_final.DateTime);
                dsRRHH_reportes1.resumen_asistenciaEntradas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRRHH_reportes1.resumen_asistenciaEntradas);

                con.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            switch (xtraTabControl1.SelectedTabPageIndex)
            {
                case 0:
                    if (dsRRHH_reportes1.resumen_asistencia.Count < 1)
                    {
                        CajaDialogo.Error("Debe de generar el reporte primero.");
                        return;
                    }
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                    dialog.FilterIndex = 0;

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        gridControl1.ExportToXlsx(dialog.FileName);
                    }
                    break;
                case 1:
                    if (dsRRHH_reportes1.resumen_asistencia.Count < 1)
                    {
                        CajaDialogo.Error("Debe de generar el reporte primero.");
                        return;
                    }
                    SaveFileDialog dialog1 = new SaveFileDialog();
                    dialog1.Filter = "Excel File (.xlsx)|*.xlsx";
                    dialog1.FilterIndex = 0;

                    if (dialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        gridControl2.ExportToXlsx(dialog1.FileName);
                    }
                    break;
            }
            
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(dt_inicial.Text))
            {
                if (!string.IsNullOrEmpty(dt_final.Text))
                {
                    if (dt_final.DateTime < dt_inicial.DateTime)
                    {
                        if (dsRRHH_reportes1.resumen_asistenciaEntradas.Count <= 0)
                            LoadDatosEntradas();
                    }       
                }
            }   
        }



    }
}