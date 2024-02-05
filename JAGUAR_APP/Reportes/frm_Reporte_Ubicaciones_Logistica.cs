using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using System.IO;

namespace JAGUAR_APP.Reportes
{
    public partial class frm_Reporte_Ubicaciones_Logistica : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_ubi;
        public string UbCodigo;
        public frm_Reporte_Ubicaciones_Logistica(int Pid_ubicacion, string PUbCodigo)
        {
            InitializeComponent();
            UbCodigo = PUbCodigo;
            id_ubi = Pid_ubicacion;
            labelControl1.Text = "Existencia en el Rack: " + UbCodigo;
            load_data();
        }
        public void load_data()
        {
            string query = @"[dbo].[sp_obtener_tarimas_por_ubicacion]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UbiCode", UbCodigo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes.TarimaResult.Clear();
                da.Fill(dsReportes.TarimaResult);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Reporte_Ubicaciones_Logistica_Load(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            grd_reporte.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grd_reporte.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grd_reporte.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grd_reporte.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grd_reporte.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grd_reporte.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "No se pudo abrir el archivo." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "No se pudo guardar el archivo." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}