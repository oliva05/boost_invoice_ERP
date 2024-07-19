using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JAGUAR_APP.BancosYTitulares
{
    
    public partial class frmTitularOP : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        PDV PuntoVentaActual;
        int IdTitular = 0;
        public enum TipoOperacion
        {
            Insert = 1,
            Update = 2
        }

        TipoOperacion TipoOP;
        public frmTitularOP(frmTitularOP.TipoOperacion pTipoOP, int pId, UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;
            TipoOP = pTipoOP;

            CargarBancos();
            CargarTipoCuenta();

            switch (TipoOP)
            {
                case TipoOperacion.Insert:

                    break;
                case TipoOperacion.Update:
                    IdTitular = pId;
                    Cuentas cuen = new Cuentas();
                    cuen.RecuperarRegistrosTitualarById(IdTitular);
                    txtNombre.Text = cuen.Nombre;
                    TxtTelefono.Text = cuen.Telefono;
                    txtIdentidad.Text = cuen.Identidad;
                    txtRTN.Text = cuen.RTN;
                    txtCorreo.Text = cuen.Correo;
                    TsActivo.IsOn = cuen.Activo;
                    CargarCuengasById();

                    break;
                default:
                    break;
            }
        }

        private void CargarTipoCuenta()
        {
            try
            {
                string query = @"sp_finanzas_get_tipo_cuentas";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdTitular", IdTitular);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsBancos1.lista_tipo_cuenta.Clear();
                adat.Fill(dsBancos1.lista_tipo_cuenta);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarBancos()
        {
            try
            {
                string query = @"sp_finanzas_get_bancos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdTitular", IdTitular);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsBancos1.lista_bancos.Clear();
                adat.Fill(dsBancos1.lista_bancos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarCuengasById()
        {
            try
            {
                string query = @"sp_finanzas_get_cuentas_by_id";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTitular",IdTitular);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsBancos1.listados_cuentas_by_id.Clear();
                adat.Fill(dsBancos1.listados_cuentas_by_id);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCloseHeader_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAddDetalle_Click(object sender, EventArgs e)
        {
            DataRow dr = dsBancos1.listados_cuentas_by_id.NewRow();
            dr[0] = 0;
            dr[1] = 0;
            dr[2] = "";
            dr[3] = "LPS";
            dr[4] = 1;
            dr[5] = true;
            dsBancos1.listados_cuentas_by_id.Rows.Add(dr);
            dsBancos1.listados_cuentas_by_id.AcceptChanges();

        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe Colocar el Nombre/Razon Social de la Cuenta");
                return;
            }

            if (gvCuentas.RowCount == 0)
            {
                CajaDialogo.Error("Debe adicionar al Menos una Cuenta!");
                return;
            }


            string NumCuentaTempo = "";
            bool ExisteCoincidencia = false;
            int contador = 0;
            foreach (dsBancos.listados_cuentas_by_idRow item in dsBancos1.listados_cuentas_by_id.Rows)
            {
                if (item.id_banco == 0)
                {
                    CajaDialogo.Error("Debe seleccionar un Banco!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(item.num_cuenta))
                {
                    CajaDialogo.Error("Debe ingresar un Numero de Cuenta Valido!");
                    return;
                }
                if (item.num_cuenta == "[Vacio]")
                {
                    CajaDialogo.Error("Debe ingresar un Numero de Cuenta Valido!");
                    return;
                }

                /**
                 Ciclo 1
                    Obtener el PrimerValor
                 Ciclo 2
                    Validar Primer Valor con todos los del Ciclo 2
                        Si se repite mas de 1 Vez (se repite una vez poor que vuelve a pasar por el mismo)
                    sis e repite una vez se para el ciclo!

                Si pasa tood esto bien, ciclo 1 validara con las cuentas de la base de datos excluyendo el Idtitular en Cuestion!

                 */
                NumCuentaTempo = item.num_cuenta;
                contador = 0;
                foreach (dsBancos.listados_cuentas_by_idRow item2do in dsBancos1.listados_cuentas_by_id.Rows)
                {
                    //Validacion de Cuentas
                    switch (TipoOP)
                    {
                        case TipoOperacion.Insert:
                            if (NumCuentaTempo == item2do.num_cuenta)
                            {
                                contador++;
                            }

                            if (contador > 1)
                            {
                                ExisteCoincidencia = true;
                                break;
                            }

                            break;

                        case TipoOperacion.Update:

                            if (NumCuentaTempo == item2do.num_cuenta)
                            {
                                contador++;
                            }

                            if (contador > 1)
                            {
                                ExisteCoincidencia = true;
                                break;
                            }

                            break;

                        default:
                            break;
                    }
                }

                if (ValidacionNumeroCuenta(item.num_cuenta, IdTitular))
                {
                    CajaDialogo.Error("Este Numero de Cuenta ya Existe en otro Titular");
                    return;
                }

                if (ExisteCoincidencia)
                {
                    CajaDialogo.Error("Los numeros de Cuenta se Repiten!\nNumero de Cuenta: "+item.num_cuenta);
                    return;
                }


            }

            bool Guardar = false;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            switch (TipoOP)
            {
                case TipoOperacion.Insert:

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_finanzas_insert_titular";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre",txtNombre.Text);
                        if (string.IsNullOrWhiteSpace(TxtTelefono.Text))
                            cmd.Parameters.AddWithValue("@telefono",DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@telefono", TxtTelefono.Text);

                        if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                            cmd.Parameters.AddWithValue("@correo", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);

                        if (string.IsNullOrWhiteSpace(txtIdentidad.Text))
                            cmd.Parameters.AddWithValue("@identidad", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@identidad", txtIdentidad.Text);

                        if (string.IsNullOrWhiteSpace(txtRTN.Text))
                            cmd.Parameters.AddWithValue("@RTN", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@RTN", txtRTN.Text);

                        cmd.Parameters.AddWithValue("@fecha_creacion", dp.Now());
                        cmd.Parameters.AddWithValue("@user_creador",UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@activo",TsActivo.IsOn);

                        int id_headertTitular = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsBancos.listados_cuentas_by_idRow row in dsBancos1.listados_cuentas_by_id.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_finanzas_insert_cuentas";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_titular", id_headertTitular);
                            cmd.Parameters.AddWithValue("@id_banco", row.id_banco);
                            cmd.Parameters.AddWithValue("@num_cuenta", row.num_cuenta.Trim());
                            cmd.Parameters.AddWithValue("@moneda", row.moneda.Trim()); 
                            cmd.Parameters.AddWithValue("@tipo_cuenta", row.tipo_cuenta);
                            cmd.Parameters.AddWithValue("@activo", row.activo);
                            cmd.Parameters.AddWithValue("@id_cuenta", row.id_cuenta);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;
                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }


                    break;
                case TipoOperacion.Update:

                    //SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_finanzas_update_titular]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        if (string.IsNullOrWhiteSpace(TxtTelefono.Text))
                            cmd.Parameters.AddWithValue("@telefono", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@telefono", TxtTelefono.Text);

                        if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                            cmd.Parameters.AddWithValue("@correo", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);

                        if (string.IsNullOrWhiteSpace(txtIdentidad.Text))
                            cmd.Parameters.AddWithValue("@identidad", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@identidad", txtIdentidad.Text);

                        if (string.IsNullOrWhiteSpace(txtRTN.Text))
                            cmd.Parameters.AddWithValue("@RTN", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@RTN", txtRTN.Text);

                        cmd.Parameters.AddWithValue("@fecha_creacion", dp.Now());
                        cmd.Parameters.AddWithValue("@user_creador", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@activo", TsActivo.IsOn);
                        cmd.Parameters.AddWithValue("@id_titular",IdTitular);
                        cmd.ExecuteNonQuery();

                        foreach (dsBancos.listados_cuentas_by_idRow row in dsBancos1.listados_cuentas_by_id.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_finanzas_insert_cuentas";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_titular", IdTitular);
                            cmd.Parameters.AddWithValue("@id_banco", row.id_banco);
                            cmd.Parameters.AddWithValue("@num_cuenta", row.num_cuenta.Trim());
                            cmd.Parameters.AddWithValue("@moneda", row.moneda.Trim());
                            cmd.Parameters.AddWithValue("@tipo_cuenta", row.tipo_cuenta);
                            cmd.Parameters.AddWithValue("@activo", row.activo);
                            cmd.Parameters.AddWithValue("@id_cuenta", row.id_cuenta);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;
                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    break;
                default:
                    break;
            }

            if (Guardar)
            {
                CajaDialogo.Information("Titular Guardado");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private bool ValidacionNumeroCuenta(string num_cuenta, int pIdTitular)
        {
            bool Existe = true;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_finanzas_validacion_Existencia_cuenta",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_cuenta", num_cuenta);
                cmd.Parameters.AddWithValue("@idTitular", IdTitular);
                Existe = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Existe;
        }

        private void repostDeleteMemory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)gcCuentas.FocusedView;
            var row = (dsBancos.listados_cuentas_by_idRow)gridView1.GetFocusedDataRow();

            if (row.id_cuenta == 0)
            {
                try
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    dsBancos1.AcceptChanges();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

        }
           
    }
}