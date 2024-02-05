using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmNavigationPageAutorizacion : DevExpress.XtraEditors.XtraForm
    {
        Factura factura = new Factura();

        int factura_id = 0;
        PDV PuntoVentaActual;
        UserLogin userLogin;


        public bool autorizacion_directa = false;

        Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
        public enum TipoAutorizacion
        {
            Anulacion = 1,
            Reimpresion = 2,
            NotaCredito_Debito = 3,
            Anulacion_Recibo = 4
        }

        enum TipoNota
        {
            Credito=1,
            Debito=2
        }

        public enum TipoDocumentoOrigen
        {
            Factura = 1,
            Recibo = 2
        }

        public TipoAutorizacion tipoAutorizacionActual;
        public TipoDocumentoOrigen TipoDocumentoOrigenActual;
        public frmNavigationPageAutorizacion(Factura_SolicitudAutorizacion request)
        {
            InitializeComponent();
            TipoDocumentoOrigenActual = TipoDocumentoOrigen.Factura;
            LoadData();
            //userLogin = usuarioLog;
            solicitud = request;
        }

        public frmNavigationPageAutorizacion(Factura_SolicitudAutorizacion request, PDV pPuntoVenta)
        {
            InitializeComponent();
            TipoDocumentoOrigenActual = TipoDocumentoOrigen.Factura;
            PuntoVentaActual = pPuntoVenta;
            LoadData();
            //userLogin = usuarioLog;
            solicitud = request;
        }

        public frmNavigationPageAutorizacion(Factura_SolicitudAutorizacion request, PDV pPuntoVenta, TipoDocumentoOrigen pTipoDoc)
        {
            InitializeComponent();
            TipoDocumentoOrigenActual = pTipoDoc;
            PuntoVentaActual = pPuntoVenta;
            LoadData();
            //userLogin = usuarioLog;
            solicitud = request;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                {
                    cnx.Open();
                    dsFacturasGestion.TipoAutorizacion.Clear();

                    SqlCommand cmd = cnx.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    switch (TipoDocumentoOrigenActual)
                    {
                        case TipoDocumentoOrigen.Factura:
                            if (this.PuntoVentaActual == null)
                            {
                                cmd.CommandText = "dbo.LoadTiposAutorizacion";
                            }
                            else
                            {
                                cmd.CommandText = "[dbo].[LoadTiposAutorizacion_by_punto_venta_V2]";
                                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                            }
                            break;
                        case TipoDocumentoOrigen.Recibo:
                            cmd.CommandText = "[dbo].[LoadTiposAutorizacion_by_punto_venta_V3]";
                            cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                            break;
                    }
                    

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsFacturasGestion.TipoAutorizacion);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private bool ValidarSolicitudExistente(long id_solicitud)
        {
            try
            {
                DataOperations dp = new DataOperations();
                bool existeSolicitud;

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

                using (SqlCommand cmd = new SqlCommand("ValidarSolicitudAutorizacionExistente_V2", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_factura", id_solicitud);
                    cmd.Parameters.Add("@id_tipo_autorizacion", solicitud.TipoAutorizacionID);

                    existeSolicitud = Convert.ToBoolean(cmd.ExecuteScalar());
                    cnx.Close();
                }


                return existeSolicitud;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void btnAutorizar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsFacturasGestion.TipoAutorizacionRow)grd_data.GetFocusedDataRow();

                solicitud.TipoAutorizacionID = row.id;

                if (TipoDocumentoOrigenActual == TipoDocumentoOrigen.Factura)
                {
                    foreach (var item in solicitud.Facturas_seleccionadas)
                    {

                        if (ValidarSolicitudExistente(item.FacturaId))
                        {
                            CajaDialogo.Error("Ya existe una solicitud en proceso para la factura seleccionada");
                            return;
                        }
                    }
                }

                if (row.id == 3)
                {
                    if (solicitud.Clientes_Seleccionados.Distinct().Count() != 1)
                    {
                        CajaDialogo.Error("Para autorizar Notas de Crédito y Débito, debe seleccionar facturas del mismo cliente");
                        return;
                    }
                }

                switch (row.id)
                {
                    case 2:
                        this.tipoAutorizacionActual = TipoAutorizacion.Reimpresion;
                       
                        this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
                        break;
                    case 1:
                        this.tipoAutorizacionActual = TipoAutorizacion.Anulacion;
                        
                        this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
                        break;
                    case 3:
                        this.tipoAutorizacionActual = TipoAutorizacion.NotaCredito_Debito;
                        dsFacturasGestion.facturas_solicitud_NC_ND.Clear();
                        FacturaDetalle factura_detalle = new FacturaDetalle();

                        foreach (var item in solicitud.Facturas_seleccionadas)
                        {
                            if (factura_detalle.RecuperaDetallFactura(item.FacturaId))
                            {
                                foreach (var detalle in factura_detalle.factura_detalle)
                                {
                                dsFacturasGestion.facturas_solicitud_NC_ND.Rows.Add(item.FacturaId, item.NumeroFactura, detalle.TotalLinea,item.PuntoVenda_Id,item.PuntoVenta,detalle.Precio,detalle.Cantidad,detalle.ProductoTerminadoId,detalle.Descripcion);
                                }
                            }
                        }
                        
                        this.navigationFrame1.SelectedPage = npNC_ND;
                        txtUser.Focus();
                        break;
                    case 4://Anulacion de Recibos
                        this.tipoAutorizacionActual = TipoAutorizacion.Anulacion_Recibo;
                        this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
                        txtJustificacion.Focus();
                        break;
                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

                SqlTransaction transaccion;
        private void cdmConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtJustificacion.Text))
                {
                    CajaDialogo.Error("Antes de confirmar, debe de ingresar una justificación para esta solicitud");
                    return;
                }

                if (txtJustificacion.Text.Length < 4)
                {
                    CajaDialogo.Error("Debe ingresar una justificacion valida!");
                    txtJustificacion.Focus();
                    return;
                }

                DataOperations dp = new DataOperations();
                bool guardado = false;

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                long id_inserted = 0;

                cnx.Open();
                transaccion = cnx.BeginTransaction();

                switch (TipoDocumentoOrigenActual)
                {
                    case TipoDocumentoOrigen.Factura:
                        switch (tipoAutorizacionActual)
                        {
                            case TipoAutorizacion.Anulacion:
                                foreach (var item in solicitud.Facturas_seleccionadas)
                                {
                                    using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", transaccion.Connection))
                                    {

                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Transaction = transaccion;
                                        cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = solicitud.TipoAutorizacionID;
                                        cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                                        cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                        cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                        cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = solicitud.UsuarioSolicita_Id;
                                        cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = solicitud.ClienteId;
                                        cmd.Parameters.Add("@id_tipo_nota", SqlDbType.Int).Value = 0;

                                        id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                                        //cnx.Close();
                                    }


                                    using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada", transaccion.Connection))
                                    {
                                        //cnx.Open();

                                        cmd2.CommandType = CommandType.StoredProcedure;
                                        cmd2.Transaction = transaccion;
                                        cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                        cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item.FacturaId;
                                        cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                        cmd2.Parameters.Add("@monto", SqlDbType.Decimal).Value = 0;

                                        cmd2.ExecuteNonQuery();
                                        guardado = true;
                                        //cnx.Close();
                                    }
                                }


                                if (guardado == true)
                                {

                                    CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                                    this.DialogResult = DialogResult.OK;
                                }
                                break;
                            case TipoAutorizacion.Reimpresion:
                                foreach (var item in solicitud.Facturas_seleccionadas)
                                {
                                    using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", transaccion.Connection))
                                    {
                                        //cnx.Open();

                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Transaction = transaccion;

                                        cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = solicitud.TipoAutorizacionID;
                                        cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                                        cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                        cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                        cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = solicitud.UsuarioSolicita_Id;
                                        cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = solicitud.ClienteId;
                                        cmd.Parameters.Add("@id_tipo_nota", SqlDbType.Int).Value = 0;

                                        id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                                        //cnx.Close();
                                    }


                                    using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada", transaccion.Connection))
                                    {
                                        //cnx.Open();

                                        cmd2.CommandType = CommandType.StoredProcedure;
                                        cmd2.Transaction = transaccion;

                                        cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                        cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item.FacturaId;
                                        cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                        cmd2.Parameters.Add("@monto", SqlDbType.Decimal).Value = 0;

                                        cmd2.ExecuteNonQuery();
                                        guardado = true;
                                        //cnx.Close();
                                    }
                                }
                                break;
                            case TipoAutorizacion.NotaCredito_Debito:

                                using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", transaccion.Connection))
                                {
                                    //cnx.Open();

                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Transaction = transaccion;

                                    cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = solicitud.TipoAutorizacionID;
                                    cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                                    cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                    cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                    cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = solicitud.UsuarioSolicita_Id;
                                    cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = solicitud.ClienteId;
                                    cmd.Parameters.Add("@id_tipo_nota", SqlDbType.Int).Value = Convert.ToBoolean(toggleSwitch1.EditValue) == true ? (int)TipoNota.Credito : (int)TipoNota.Debito;


                                    id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                                    //cnx.Close();
                                }


                                foreach (var item in dsFacturasGestion.facturas_solicitud_NC_ND)
                                {
                                    using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada_V2", transaccion.Connection))
                                    {
                                        //cnx.Open();

                                        cmd2.CommandType = CommandType.StoredProcedure;
                                        cmd2.Transaction = transaccion;

                                        cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                        cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item.id_factura;
                                        cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                        cmd2.Parameters.Add("@monto", SqlDbType.Decimal).Value = item.monto;
                                        cmd2.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = item.cantidad;
                                        cmd2.Parameters.Add("@precio", SqlDbType.Decimal).Value = item.precio;
                                        cmd2.Parameters.Add("@id_pt", SqlDbType.Decimal).Value = item.id_pt;

                                        cmd2.ExecuteNonQuery();
                                        guardado = true;
                                        //cnx.Close();
                                    }
                                }


                                //if (guardado == true)
                                //{

                                //    CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                                //    this.DialogResult = DialogResult.OK;
                                //}
                                break;
                            default:
                                break;
                        }
                        break;
                    case TipoDocumentoOrigen.Recibo:
                        switch (tipoAutorizacionActual)
                        {
                            case TipoAutorizacion.Anulacion_Recibo:
                                using (SqlCommand cmd2 = new SqlCommand("dbo.[usp_Facturacion_InsertSolicitudAutorizacion_v2]", transaccion.Connection))
                                {
                                    cmd2.CommandType = CommandType.StoredProcedure;
                                    cmd2.Transaction = transaccion;
                                    cmd2.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = 4;//Anulacion de recibos
                                    cmd2.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                                    cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                    cmd2.Parameters.Add("@id_pdv", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                    cmd2.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = solicitud.UsuarioSolicita_Id;
                                    cmd2.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = solicitud.ClienteId;
                                    cmd2.Parameters.Add("@id_tipo_nota", SqlDbType.Int).Value = 0;
                                    cmd2.Parameters.Add("@id_reciboH", SqlDbType.BigInt).Value = solicitud.ReciboId;

                                    id_inserted = Convert.ToInt64(cmd2.ExecuteScalar());
                                }

                                if (id_inserted > 0)
                                {
                                    using (SqlCommand cmd2 = new SqlCommand("[dbo].[uspInsertAutorizacion_FacuracionAsociada_v3]", transaccion.Connection))
                                    {
                                        cmd2.CommandType = CommandType.StoredProcedure;
                                        cmd2.Transaction = transaccion;
                                        cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                        cmd2.Parameters.Add("@idReciboH", SqlDbType.BigInt).Value = solicitud.ReciboId;
                                        cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                        cmd2.Parameters.Add("@monto", SqlDbType.Decimal).Value = 0;

                                        cmd2.ExecuteNonQuery();
                                        guardado = true;
                                        //cnx.Close();
                                    }
                                }
                                break;
                        }
                        break;
                }

                transaccion.Commit();
                cnx.Close();

                if (guardado == true)
                {
                    CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cdmCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npGestionSolicitud;
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
        }

        private void cmdAplicarAutorizacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //autorizar y aplicar de una vez el efecto
            switch(TipoDocumentoOrigenActual)
            {
                case TipoDocumentoOrigen.Factura:
                    try
                    {
                        var row = (dsFacturasGestion.TipoAutorizacionRow)grd_data.GetFocusedDataRow();
                        Factura factura = new Factura();

                        solicitud.TipoAutorizacionID = row.id;

                        foreach (var item in solicitud.Facturas_seleccionadas)
                        {
                            if (ValidarSolicitudExistente(item.FacturaId))
                            {
                                CajaDialogo.Error("Ya existe una solicitud en proceso para la factura seleccionada");
                                return;
                            }
                        }

                        if (row.id == 3)
                        {
                            if (solicitud.Clientes_Seleccionados.Distinct().Count() != 1)
                            {
                                CajaDialogo.Error("Para autorizar Notas de Crédito y Débito, debe seleccionar facturas del mismo cliente");
                                return;
                            }
                        }

                        UserLogin Autorizar_Login = new UserLogin();
                        navigationFrame1.SelectedPage = npAutorizacion;
                        txtUsuario.Focus();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
                case TipoDocumentoOrigen.Recibo:
                    try
                    {
                        var row = (dsFacturasGestion.TipoAutorizacionRow)grd_data.GetFocusedDataRow();
                        ReciboH Recibo1 = new ReciboH();

                        solicitud.TipoAutorizacionID = row.id;

                        UserLogin Autorizar_Login = new UserLogin();
                        navigationFrame1.SelectedPage = npAutorizacion;
                        txtUsuario.Focus();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
            }
        }


            bool contraseniaCorrecta = false;
        private UserLogin ValidateUserInfo(string usuario, string clave)
        {
            UserLogin user = new UserLogin();
            //string usuario = user.EncrypPassword("Nutreco");//Users.EncrypPassword("Nutreco"); 
            if (user.RecuperarRegistroJAGUAR(usuario))
            {
                if (!user.Habilitado)
                {
                    CajaDialogo.Information("Este usuario no esta habilitado o no existe!");
                    return new UserLogin();
                }

                if (user.DecryptPassword(user.Pass) == clave)
                {

                    contraseniaCorrecta = true;
                    return user;
                 }
                else
                {
                    CajaDialogo.Error("Contraseña Incorrecta!");
                    txtClave.Text = "";
                    return new UserLogin();
                }

            }
            else
            {
                CajaDialogo.Error("No se pudo encontrar el usuario que usted ingreso, favor revise bien el alias de usuario.");
                txtUsuario.Focus();
                return new UserLogin();
            }
        }

        private void btnCancelarAutorizacionDirecta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarAutorizacionDirecta_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = ValidateUserInfo(txtUsuario.Text,txtClave.Text);
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
               

                if (usuario.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores && contraseniaCorrecta==true)
                {
                    switch (TipoDocumentoOrigenActual)
                    {
                        case TipoDocumentoOrigen.Factura:

                            switch (solicitud.TipoAutorizacionID)
                            {
                                case 1:
                                    this.tipoAutorizacionActual = TipoAutorizacion.Anulacion;
                                    using (SqlCommand cmd = new SqlCommand("dbo.AnularFacturaFromAutorizacionDirecta", cnx))
                                    {
                                        cnx.Open();

                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                        cmd.Parameters.Add("@id_factura_H", SqlDbType.BigInt).Value = solicitud.FacturaId;

                                        cmd.ExecuteNonQuery();

                                        CajaDialogo.Information("La factura ha sido anulada");
                                        this.DialogResult = DialogResult.OK;
                                        autorizacion_directa = true;
                                        cnx.Close();
                                    }
                                    break;
                                case 2:
                                    this.tipoAutorizacionActual = TipoAutorizacion.Reimpresion;

                                    using (SqlCommand cmd = new SqlCommand("dbo.ReimpresionFacturaFromAutorizacionDirecta", cnx))
                                    {
                                        cnx.Open();

                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                        cmd.Parameters.Add("@id_factura_H", SqlDbType.BigInt).Value = solicitud.FacturaId;

                                        cmd.ExecuteNonQuery();

                                        CajaDialogo.Information("Ahora puede reimprimir la factura");
                                        this.DialogResult = DialogResult.OK;
                                        autorizacion_directa = true;
                                        cnx.Close();
                                    }
                                    break;
                                case 3:
                                    this.tipoAutorizacionActual = TipoAutorizacion.NotaCredito_Debito;

                                    int tipoNota = 0;

                                    if (Convert.ToBoolean(tsTipoNCND.EditValue) == true)
                                    {
                                        tipoNota = 1;
                                    }
                                    else
                                    {
                                        tipoNota = 2;
                                    }

                                    //solicitud.Facturas_seleccionadas = new List<FacturasSeleccionada>();
                                    //foreach (var item in dsFacturasGestion.facturas_solicitud_NC_ND)
                                    //{
                                    //    solicitud.Facturas_seleccionadas.Add(new FacturasSeleccionada
                                    //    {
                                    //        NumeroFactura = item.numero_factura,
                                    //        Monto = item.monto

                                    //    });
                                    //}

                                    frmNotaCRUD frm3 = new frmNotaCRUD(frmNotaCRUD.SourceSolicitud.AutorizacionDirecta, userLogin, solicitud.PuntoDeVenta_Id, tipoNota, solicitud);

                                    if (frm3.ShowDialog() == DialogResult.OK)
                                    {
                                        this.Close();
                                    }


                                    //frmNotaCRUD frm3 = new frmNotaCRUD(frmNotaCRUD.SourceSolicitud.FacturaEmitida, usuario);
                                    //dsFacturasGestion.facturas_solicitud_NC_ND.Clear();
                                    //foreach (var item in solicitud.Facturas_seleccionadas)
                                    //{
                                    //    dsFacturasGestion.facturas_solicitud_NC_ND.Rows.Add(item.FacturaId, item.NumeroFactura, item.Monto, item.PuntoVenda_Id, item.PuntoVenta);
                                    //}
                                    //this.navigationFrame1.SelectedPage = npNC_ND;
                                    break;
                            }
                            break;
                        case TipoDocumentoOrigen.Recibo:
                            this.tipoAutorizacionActual = TipoAutorizacion.Anulacion;
                            using (SqlCommand cmd = new SqlCommand("[dbo].[AnularReciboFromAutorizacionDirecta]", cnx))
                            {
                                cnx.Open();

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                cmd.Parameters.Add("@idReciboH", SqlDbType.BigInt).Value = solicitud.ReciboId;

                                cmd.ExecuteNonQuery();

                                CajaDialogo.Information("El recibo ha sido anulado.");
                                autorizacion_directa = true;
                                this.DialogResult = DialogResult.OK;
                                cnx.Close();
                            }
                            break;
                    }
                    
                }
            }
            catch (Exception exc)
            {
                CajaDialogo.Error(exc.Message);
            }


        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = ValidateUserInfo(txtUser.Text,txtpass.Text);
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                int tipoNota = 0;

                if (Convert.ToBoolean( tsTipoNCND.EditValue)==true)
                {
                    tipoNota = 1;
                }
                else
                {
                    tipoNota = 2;
                }

                solicitud.Facturas_seleccionadas = new List<FacturasSeleccionada>();
                foreach (var item in dsFacturasGestion.facturas_solicitud_NC_ND)
                {
                    solicitud.Facturas_seleccionadas.Add(new FacturasSeleccionada
                    {
                        NumeroFactura = item.numero_factura,
                        Monto = item.monto

                    }) ;
                }

                if (usuario.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores && contraseniaCorrecta==true)
                {
                    frmNotaCRUD frm3 = new frmNotaCRUD(frmNotaCRUD.SourceSolicitud.AutorizacionDirecta, userLogin,solicitud.PuntoDeVenta_Id,tipoNota,solicitud);
                    frm3.Show();
                }

            }
            catch (Exception exc)
            {
                CajaDialogo.Error(exc.Message);
            }
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtClave.Text = "";
            txtUsuario.Text = "";

            navigationFrame1.SelectedPage = npGestionSolicitud;
        }

        private void frmNavigationPageAutorizacion_Load(object sender, EventArgs e)
        {
            if (TipoDocumentoOrigenActual == TipoDocumentoOrigen.Factura)
            {
                foreach (var item in solicitud.Facturas_seleccionadas)
                {
                    factura = new Factura();

                    if (factura.RecuperarRegistroFor_NotaCreditoDebito(item.FacturaId)) ;
                    {
                        solicitud.Facturas_seleccionadas.FirstOrDefault(x => x.FacturaId == item.FacturaId).Cantidad = factura.Cantidad;
                        solicitud.Facturas_seleccionadas.FirstOrDefault(x => x.FacturaId == item.FacturaId).ProductoId = factura.ProductoId;
                        solicitud.Facturas_seleccionadas.FirstOrDefault(x => x.FacturaId == item.FacturaId).Precio = factura.Precio;
                        solicitud.Facturas_seleccionadas.FirstOrDefault(x => x.FacturaId == item.FacturaId).FacturaD_Id = factura.FacturaD_Id;
                    }
                }
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {

            btnConfirmarAutorizacionDirecta_Click(sender, e);
            }
        }

        private void gv_facturas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "cantidad")
                {
                    decimal cantidad = Convert.ToDecimal(gv_facturas.GetRowCellValue(e.RowHandle, gv_facturas.Columns[4]));
                    decimal precio = Convert.ToDecimal(gv_facturas.GetRowCellValue(e.RowHandle, gv_facturas.Columns[5]));

                    var row = (dsFacturasGestion.facturas_solicitud_NC_NDRow)gv_facturas.GetDataRow(e.RowHandle);

                    row.monto = cantidad * precio;

                    //grd_data.SetRowCellValue(e.RowHandle, grd_data.Columns[3], (cantidad * precio));
                }
            }
            catch (Exception exc)
            {
                CajaDialogo.Error(exc.Message);
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtClave.Focus();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }
        }
    }
}