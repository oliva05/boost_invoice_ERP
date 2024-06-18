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
using static ACS.Classes.DataOperations;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
using ACS.Classes;
using JAGUAR_APP.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace JAGUAR_APP.Facturacion.Mantenimientos
{
    public partial class xfrmVendedoresOP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        UserLogin usuarioLogueado = new UserLogin();

        int IDVendedor;

        public enum Operacion
        {
            Nuevo = 1,
            Editar = 2
        }

        Operacion tipoOP;
        
      
        public xfrmVendedoresOP(xfrmVendedoresOP.Operacion pOperacion,int PidVend, UserLogin pUserLog)
        {
            InitializeComponent();
            IDVendedor = PidVend;
            usuarioLogueado = pUserLog;

            tipoOP = pOperacion;

            switch (tipoOP)
            {
                case Operacion.Nuevo:

                    tsActivo.IsOn = true;
                    break;

                case Operacion.Editar:
                    Vendedores vend = new Vendedores();
                    vend.RecuperarRegistro(IDVendedor);
                    txtCodigo.Text = IDVendedor.ToString();
                    txtNombre.Text = vend.Nombre;
                    spincomision.EditValue = vend.ComisionPorcentaje;
                    txtRTN.Text = vend.RTN;
                    txtCorreo.Text = vend.Email;
                    txtTelefono.Text = vend.Telefono;
                    if (vend.Enable == true)
                        tsActivo.IsOn = true;
                    else
                        tsActivo.IsOn = false;
                    break;

                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe colocar un nombre!");
                return;
            }

            if (Convert.ToDecimal(spincomision.EditValue) < 0)
            {
                CajaDialogo.Error("Debe colocar un nombre!");
                return;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                CajaDialogo.Error("Debe colocar un correo!");
                return;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                CajaDialogo.Error("Debe colocar un telefono!");
                return;
            }
            bool Guardar = false;
            switch (tipoOP)
            {
                case Operacion.Nuevo:
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_vendedores", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre",txtNombre.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@email",txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@comision_porcentaje",spincomision.EditValue);
                        cmd.Parameters.AddWithValue("@user_id_creacion",usuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@fecha_creacion",dp.NowSetDateTime());
                        cmd.Parameters.AddWithValue("@user_id_last_modi", usuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@fecha_last_modi", dp.NowSetDateTime()); 
                        if (string.IsNullOrEmpty(txtRTN.Text))
                            cmd.Parameters.AddWithValue("@RTN", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@RTN",txtRTN.Text);
                        cmd.ExecuteNonQuery();
                        Guardar = true;
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        Guardar = false;
                        CajaDialogo.Error(EX.Message);
                    }

                    break;
                case Operacion.Editar:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_update_vendedor", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idVendedor", IDVendedor);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@comision_porcentaje", spincomision.EditValue);
                        cmd.Parameters.AddWithValue("@user_id_last_modi", usuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@fecha_last_modi", dp.NowSetDateTime());
                        if (tsActivo.IsOn)
                            cmd.Parameters.AddWithValue("@activo", 1);
                        else
                            cmd.Parameters.AddWithValue("@activo", 0);
                        if (string.IsNullOrEmpty(txtRTN.Text))
                            cmd.Parameters.AddWithValue("@RTN", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@RTN", txtRTN.Text);
                        cmd.ExecuteNonQuery();
                        Guardar = true;
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        Guardar = false;
                        CajaDialogo.Error(EX.Message);
                    }


                    break;
                default:
                    break;

            }

            if (Guardar)
            {
                CajaDialogo.Information("Vendedor Guardado!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}