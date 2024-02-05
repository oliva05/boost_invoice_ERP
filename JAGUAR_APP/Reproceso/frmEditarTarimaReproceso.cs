using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using Core.Clases.Herramientas;
using Huellas;
using JAGUAR_APP.Clases;
//using JAGUAR_APP.RecepcionMP;

namespace JAGUAR_APP.Reproceso
{
    public partial class frmEditarTarimaReproceso : DevExpress.XtraEditors.XtraForm
    {
        int IdTarima;
        UserLogin UsuarioLogeado;
        decimal factor;
        public string ItemCode;
        public frmEditarTarimaReproceso(int pIdTarima, UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            LoadPresentaciones();
            IdTarima = pIdTarima;
            LoadDataTarima(pIdTarima);
        }

        private void LoadDataTarima(int pIdTarima)
        {
            Tarima tam = new Tarima();
            if (tam.RecuperarRegistroTarimaReproceso(this.IdTarima))
            {
                dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaIngreso);
                gridLookUpEditPresentacion.EditValue = tam.IdPresentacion;
                txtUnidades.Text = string.Format("{0:###,##0.00}", tam.Cantidad);
                txtNumIngreso.Text = string.Format("{0:###,##0}", tam.NumeroTransaccion);
                txtLote.Text = tam.LoteMP;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", tam.Peso);
                dtFechaProduccion.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaProduccionMP);
                dtFechaVencimiento.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaVencimiento);
                MateriaPrima mp = new MateriaPrima();
                if (mp.RecuperarRegistroFromID_RM(tam.Id_materiaprima))
                {
                    ItemCode = mp.CodeMP_SAP;
                    txtMP_Name.Text = mp.Name;
                }
            }
        }

        private void LoadPresentaciones()
        {
            try
            {
                //DataOperations dp = new DataOperations();
                //SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                //con.Open();

                //SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsRecepcionMPx1.presentaciones.Clear();
                //adat.Fill(dsRecepcionMPx1.presentaciones);
                //con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtMP_Name_Click(object sender, EventArgs e)
        {
            //frmMP frm = new frmMP();
            //if (this.MdiParent != null)
            //{
            //    //frm.MdiParent = this.MdiParent;
            //    frm.FormBorderStyle = FormBorderStyle.Sizable;
            //}
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    txtMP_Name.Text = frm.MateriaPrima;

            //    //txtCodigoProveedor.Text = frm.idProveedor;
            //    //txtProveedorName.Text = frm.NombreProveedor;
            //    this.ItemCode = frm.ItemCode;
            //}
        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn) // 
            {
                CalculodelPromedio();
            }
            else
            {
                try
                {
                    txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
                }
                catch
                {
                    txtPesoKg.Text = "0";
                }
            }
        }

        private void CalculodelPromedio()
        {
            try
            {
                int unidades_Tarimas = Convert.ToInt32(txtUnidades.Text);
                int cantidad_tariams = Convert.ToInt32(txtCantidadTarimasTotal.Text);
                decimal Unidades_totales = unidades_Tarimas * cantidad_tariams;
                decimal total_pesoKg = Convert.ToDecimal(txtPesoKg.Text);
                factor = 0;
                factor = total_pesoKg / Unidades_totales;
                txtpresentacionPromedio.Text = string.Format("{0:###,##0.00}", (factor));


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtpresentacionPromedio_EditValueChanged(object sender, EventArgs e)
        {
            PresentacionX pre1 = new PresentacionX();
            if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
            {
                factor = pre1.Factor;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
            }
        }

        private void Tg_presentacion_promedio_Toggled(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn)          // Data
            {
                try
                {
                    txtpresentacionPromedio.Visible = true;
                    gridLookUpEditPresentacion.Visible = false;
                    factor = 0;
                    labelControl12.Text = "Peso total KG";
                    txtPesoKg.Enabled = true;
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                txtpresentacionPromedio.Visible = false;
                gridLookUpEditPresentacion.Visible = true;
                txtPesoKg.Enabled = false;
                labelControl12.Text = "Peso Kg por tarima";

                try
                {
                    PresentacionX pre1 = new PresentacionX();
                    if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
                    {
                        factor = pre1.Factor;
                        txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));

                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);

                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            if (IdTarima <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima sin la boleta de bascula!");
                return;
            }

            if (Convert.ToDecimal(txtUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima con unidades de materia en cero (0)!");
                return;
            }

            if (!Tg_presentacion_promedio.IsOn)
            {
                if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
                {
                    CajaDialogo.Error("Es necesario seleccionar la presentacion de la Materia Prima!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaProduccion.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de producción de la materia prima!");
                return;
                
            }
            if (dtFechaProduccion.DateTime.Year < 2019)
            {
                CajaDialogo.Error("La Fecha de Produccion debe tener una Fecha Valida");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }

            int cant = 0;
            try
            {
                cant = Convert.ToInt32(txtCantidadTarimasTotal.Text);
            }
            catch
            {
                cant = 0;
            }

            if (cant <= 0)
            {
                CajaDialogo.Error("No se puede registrar menos de una (1) tarima!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Desea realizar estas modificaciones?");
            if (r != DialogResult.Yes)
                return;

            ValidarConsumoAlimentacion(IdTarima);

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_tarima_reproceso_v4", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha_ingreso", Convert.ToDateTime(dtFechaIngreso.EditValue));
                cmd.Parameters.AddWithValue("@fecha_vencimiento", Convert.ToDateTime(dtFechaVencimiento.EditValue));
                cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", Convert.ToDateTime(dtFechaProduccion.EditValue));
                cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);
                cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(txtUnidades.Text));
                cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPesoKg.Text));
                //cmd.Parameters.AddWithValue("@id_proveedor", glueProveedor.EditValue.ToString());
                cmd.Parameters.AddWithValue("@itemcode", this.ItemCode);
                cmd.Parameters.AddWithValue("@id", this.IdTarima);
                cmd.ExecuteNonQuery();
                con.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void ValidarConsumoAlimentacion(int pIdTarima)
        {
            try
            {
                string sql = @"SELECT count(*)
                               FROM [LOSA].[dbo].[LOSA_alimentacion_tarimas] A
                                    where enable = 1 and id_tarima =" + pIdTarima;
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                int RegistrosConsumo = (int)cmd.ExecuteScalar();

                if (RegistrosConsumo > 0)
                {
                    CajaDialogo.Error("No puede editar esta tarima ya que fue entregada parcial o completamente a produccion!");
                    return;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            PresentacionX pre1 = new PresentacionX();
            if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
            {
                factor = pre1.Factor;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
            }
        }
    }
}