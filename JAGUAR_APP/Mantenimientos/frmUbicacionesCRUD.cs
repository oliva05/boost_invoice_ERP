using ACS.Classes;
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

namespace JAGUAR_APP.Mantenimientos
{
    public partial class frmUbicacionesCRUD : Form
    {
        int IdBodega;
        DataOperations dp = new DataOperations();
        public frmUbicacionesCRUD(int pIdBod)
        {
            InitializeComponent();
            IdBodega = pIdBod;
            lblUltimoRack.Text = LoadLastNumberRack();
        }

        private string LoadLastNumberRack()
        {
            string rack = "";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                string sql = "dbo.sp_get_last_rack_from_wh";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_bodega", IdBodega);
                rack = cmd.ExecuteScalar().ToString();
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return rack;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validaciones iniciales para el nuevo rack.
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("No se puede guardar un rack en blanco!");
                return;
            }

            string s_error = "";
            //vamos a validar que el nuevo rack no este repetido en esa bodega.
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                string sql = @"dbo.[sp_get_validacion_rack_en_bodega_exist]";
                s_error = "sp: " + sql;//en caso de error mostraremos el ultimo stored procedure enviado a ejecutar.
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idbodega", IdBodega);
                cmd.Parameters.AddWithValue("@rack", txtDescripcion.Text);
                int result = Convert.ToInt32(cmd.ExecuteScalar());//.ToString();
                cn.Close();

                if(result == 1)
                {
                    CajaDialogo.Error("Este Rack ya esta registrado en " + lblBodegaActual.Text +
                                      ", consulte la lista de racks, e intente con un codigo, nombre o numero distinto!");
                    return;
                }

                //Guardamos el nuevo rack.
                //cn.Open();
                //SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", cn);
                //cmm.CommandType = CommandType.StoredProcedure;
                //cmm.Parameters.AddWithValue("@id", 1);
                //string barcode = cmm.ExecuteScalar().ToString();

                cn.Open();
                string sql2 = @"dbo.[sp_set_insert_new_rack]";
                s_error = "sp: " + sql2;//en caso de error mostraremos el ultimo stored procedure enviado a ejecutar.
                SqlCommand cmd2 = new SqlCommand(sql2, cn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@id_bodega", IdBodega);
                cmd2.Parameters.AddWithValue("@rack", txtDescripcion.Text);
                //cmd.Parameters.AddWithValue("@codigo_barra", txtDescripcion.Text);
                cmd2.ExecuteNonQuery();//.ToString();
                cn.Close();
                txtDescripcion.Text = "";

                CajaDialogo.Information("Transacción exitosa!");
                //return;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("El error se genero en " + s_error + " Exception: " + ec.Message);
            }

        }
    }
}
