
using ACS.Classes;
//using ACS.Forecast;
using ACS.IT_Managment;
using DevExpress.XtraReports.UI;
using Eatery.Ventas;
//using ACS.Produccion;
//using ACS.RRHH.HorasExtra;
using JAGUAR_APP.Accesos;
using JAGUAR_APP.Accesos.AccesosUsuarios;
using JAGUAR_APP.Accesos.GestionGrupos;
using JAGUAR_APP.Accesos.GestionSistemas;
using JAGUAR_APP.Accesos.GrupoLosa;
using JAGUAR_APP.Accesos.NivelAccesoSistema;
using JAGUAR_APP.Accesos.TurnosUsuario;
using JAGUAR_APP.ACS.RRHH;
using JAGUAR_APP.AlmacenesExterno;
using JAGUAR_APP.AlmacenesExterno.Salida_Almacen;
//using JAGUAR_APP.Calidad;
//using JAGUAR_APP.Calidad.LoteConfConsumo;
//using JAGUAR_APP.Calidad.Revision_Sanidad;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Despachos;
using JAGUAR_APP.Facturacion.Configuraciones;
using JAGUAR_APP.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.Mantenimientos;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
using JAGUAR_APP.Facturacion.Numeracion_Fiscal;
using JAGUAR_APP.Facturacion.Reportes;
using JAGUAR_APP.JaguarProduccion;
using JAGUAR_APP.LogisticaJaguar;
using JAGUAR_APP.LogisticaJaguar.Despacho;
using JAGUAR_APP.LogisticaJaguar.Pedidos;
//using JAGUAR_APP.Liquidos;
//using JAGUAR_APP.Logistica;
using JAGUAR_APP.Mantenimientos;
using JAGUAR_APP.Mantenimientos.Clientes;
using JAGUAR_APP.Mantenimientos.Facturacion.Mantenimiento;
using JAGUAR_APP.Mantenimientos.Formulas;
using JAGUAR_APP.Mantenimientos.MaterialEmpaque;
using JAGUAR_APP.Mantenimientos.MateriaPrima;
using JAGUAR_APP.Mantenimientos.Panaderos;
using JAGUAR_APP.Mantenimientos.ProductoTerminado;
using JAGUAR_APP.Mantenimientos.Proveedor;
using JAGUAR_APP.RecuentoInventario;
using JAGUAR_APP.Reportes;
using JAGUAR_APP.Reproceso;
using JAGUAR_APP.Tools;
using LOSA.TransaccionesMP;
//using JAGUAR_APP.TransaccionesMP;
//using JAGUAR_APP.TransaccionesPT;
//using JAGUAR_APP.Trazabilidad;
//using JAGUAR_APP.Trazabilidad.ReportesTRZ;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using JAGUAR_APP.Facturacion.Cotizaciones;

namespace JAGUAR_APP
{
    public partial class frmOpciones : Form
    {
        UserLogin UsuarioLogeado;
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        //string ActiveADUser;
        //DataTable UserGroups;

        public frmOpciones(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            txtEquipoLogeadoActual.Text = Dns.GetHostName();
            if (string.IsNullOrEmpty(txtEquipoLogeadoActual.Text))
                txtEquipoLogeadoActual.Visible = false;
            else
                txtEquipoLogeadoActual.Visible = true;

            tabPageFacturacion.PageVisible = false;

            int i = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
            //int i = Convert.ToInt32(4);
            int idNivel;
            switch (pUser.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Montacarga:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.Logistica:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.Calidad:
                    //int idNivel = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY
                    //switch (idNivel)
                    //{
                    //    case 1://Basic View
                    //        BasicView();
                    //        UsuarioLogeado.Idnivel = idNivel;
                    //        break;
                    //    case 2://Basic No Autorization

                    //        break;
                    //    case 3://Medium Autorization

                    //        break;
                    //    case 4://Depth With Delta
                    //        tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    //        tabOpciones.TabPages[i].PageVisible = true;
                    //        break;
                    //    case 5://Depth Without Delta

                    //        break;
                    //    default:
                    //        tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    //        tabOpciones.TabPages[i].PageVisible = true;
                    //        break;
                    //}
                    break;
                case GrupoUser.GrupoUsuario.Administradores:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;

                    idNivel = pUser.idNivelAcceso(pUser.Id, 11);//11 = JAGUAR
                    switch (idNivel)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization

                            break;
                        case 4://Depth With Delta
                            //tabOpciones.TabPages[0].PageVisible = true;
                            tabOpciones.TabPages[1].PageVisible = true; //Logistica
                            tabOpciones.TabPages[2].PageVisible = false;//Calidad
                            tabOpciones.TabPages[3].PageVisible = true; //Admin
                            tabOpciones.TabPages[4].PageVisible = false;//Produccion
                            tabOpciones.TabPages[5].PageVisible = false;
                            tabOpciones.TabPages[6].PageVisible = false;
                            tabOpciones.TabPages[7].PageVisible = false;
                            tabOpciones.TabPages[8].PageVisible = false;

                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;


                            //SubTab
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            tabPageFacturacion.PageVisible = true;
                            break;
                        case 5://Depth Without Delta
                            tabPageFacturacion.PageVisible = true;
                            //Mantenimientos de Facturacion
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Produccion:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.ProduccionV2:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i - 1].PageVisible = true;

                    idNivel = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY
                    switch (idNivel)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization

                            break;
                        case 4://Depth With Delta
                            //tabOpciones.TabPages[0].PageVisible = true;
                            tabOpciones.TabPages[1].PageVisible = true;
                            //tabOpciones.TabPages[2].PageVisible = true;
                            tabOpciones.TabPages[3].PageVisible = true;
                            //tabOpciones.TabPages[4].PageVisible = true;
                            //tabOpciones.TabPages[5].PageVisible = true;
                           
                            break;
                        case 5://Depth Without Delta

                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Contabilidad:
                    int idNivel2 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY
                    //switch (idNivel2)
                    //{
                    //    case 1://Basic View
                    //        BasicView();
                    //        UsuarioLogeado.Idnivel = idNivel2;
                    //        break;
                    //    case 2://Basic No Autorization

                    //        break;
                    //    case 3://Medium Autorization

                    //        break;
                    //    case 4://Depth With Delta

                    //        break;
                    //    case 5://Depth Without Delta

                    //        break;
                    //    default:
                    //        tabOpciones.SelectedTabPageIndex = 2;//Calidad
                    //        //tabOpciones.TabPages[1].PageVisible = true;
                    //        tabOpciones.TabPages[8].PageVisible = true;
                    //        break;
                    //}
                    break;

                case GrupoUser.GrupoUsuario.RRHH:
                    int idNivel3 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY

                    //switch (idNivel3)
                    //{
                    //    case 1://Basic View
                    //        BasicView();
                    //        UsuarioLogeado.Idnivel = idNivel3;
                    //        break;
                    //    case 2://Basic No Autorization

                    //        break;
                    //    case 3://Medium Autorization

                    //        break;
                    //    case 4://Depth With Delta

                    //        break;
                    //    case 5://Depth Without Delta

                    //        break;
                    //    default:
                    //        tabOpciones.SelectedTabPageIndex = 6;//RRHH
                    //        tabOpciones.TabPages[6].PageVisible = true;
                    //        break;
                    //}
                    break;

                case GrupoUser.GrupoUsuario.Forecasting:
                    int idNivel4 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY

                    //switch (idNivel4)
                    //{
                    //    case 1://Basic View
                    //        BasicView();
                    //        UsuarioLogeado.Idnivel = idNivel4;
                    //        break;
                    //    case 2://Basic No Autorization

                    //        break;
                    //    case 3://Medium Autorization

                    //        break;
                    //    case 4://Depth With Delta

                    //        break;
                    //    case 5://Depth Without Delta

                    //        break;
                    //    default:
                    //        tabOpciones.SelectedTabPageIndex = 7;//Forecasting
                    //        tabOpciones.TabPages[7].PageVisible = true;
                    //        break;
                    //}
                    break;

                case GrupoUser.GrupoUsuario.Bascula:
                    int idNivel10 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY

                    //switch (idNivel10)
                    //{
                    //    case 1://Basic View
                    //        BasicView();
                    //        UsuarioLogeado.Idnivel = idNivel10;
                    //        break;
                    //    case 2://Basic No Autorization

                    //        break;
                    //    case 3://Medium Autorization

                    //        break;
                    //    case 4://Depth With Delta

                    //        break;
                    //    case 5://Depth Without Delta

                    //        break;
                    //    default:
                    //        tabOpciones.SelectedTabPageIndex = 8;//RRHH
                    //        tabOpciones.TabPages[8].PageVisible = true;
                    //        break;
                    //}
                    break;

                case GrupoUser.GrupoUsuario.Formulacion:
                    int idNivel11 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY

                    switch (idNivel11)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel11;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization

                            break;
                        case 4://Depth With Delta

                            break;
                        case 5://Depth Without Delta

                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = 9;//RRHH
                            tabOpciones.TabPages[9].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Facturacion_Admin:
                    xtraTabControl2.TabPages[2].PageVisible = true;
                    int pidNivel_11 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY 11=JAGUAR
                    switch (pidNivel_11)
                    {
                        case 1://Basic View
                            UsuarioLogeado.Idnivel = pidNivel_11;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization
                            tabOpciones.TabPages[1].PageVisible = true; //Logistica
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        case 4://Depth With Delta
                            tabOpciones.TabPages[1].PageVisible = true; //Logistica
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        case 5://Depth Without Delta
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        default:
                            break;
                    }
                    tabPageFacturacion.PageVisible = true;
                    break;

                case GrupoUser.GrupoUsuario.Facturacion_EndUser:
                    int idNivel_11 = pUser.idNivelAcceso(pUser.Id, 11);//7 = ALOSY 11=JAGUAR
                    switch (idNivel_11)
                    {
                        case 1://Basic View
                            UsuarioLogeado.Idnivel = idNivel_11;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible = 
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible = 
                            NBI_Cliente.Visible = true;
                            break;
                        case 4://Depth With Delta
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        case 5://Depth Without Delta
                            xtraTabControl2.TabPages[2].PageVisible = true;
                            NBI_Despachos.Visible = NBI_ListaPrecios.Visible =
                            NBI_PuntoVenta.Visible = NBI_NumeracionFiscal.Visible =
                            NBI_Cliente.Visible = true;
                            break;
                        default:
                            break;
                    }
                    tabPageFacturacion.PageVisible = true;
                    break;
                default:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
            }
        }

        public void BasicView()
        {
            TabCalidad.PageVisible = TabLogistica.PageVisible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        { }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRecepcionMPLogistica_Click(object sender, EventArgs e)
        { }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            frmBodega frm = new frmBodega();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void BtnTiposPresentaciones_Click(object sender, EventArgs e)
        {
            frmTipoPresentacion frm = new frmTipoPresentacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void BtnEstadosProgramacionesRequisiciones_Click(object sender, EventArgs e)
        { }

        private void BtnKardexTiposTransacciones_Click(object sender, EventArgs e)
        {
            frmKardexTipoTransaccion frm = new frmKardexTipoTransaccion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void BtnEstadosRequisiciones_Click(object sender, EventArgs e)
        {
            frmEstadoRequisicion frm = new frmEstadoRequisicion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        { }

        private void simpleButton3_Click(object sender, EventArgs e)
        { }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {}

        private void simpleButton2_Click(object sender, EventArgs e)
        {  }

        private void BtnCambiarUbicacion_Click(object sender, EventArgs e)
        { }

        private void cmdProgramaRequisiciones_Click(object sender, EventArgs e)
        { }

        private void BtnDevolciones_Click(object sender, EventArgs e)
        {  }

        private void BtnAjustesKardex_Click(object sender, EventArgs e)
        {   }

        private void cmdRequisiciones_Click(object sender, EventArgs e)
        { }

        private void cmdRequisiciones__Click(object sender, EventArgs e)
        { }

        private void cmdPT_Click(object sender, EventArgs e)
        { }

        private void cmdMP_Click(object sender, EventArgs e)
        {}

        private void btnAlimentacionManual_Click(object sender, EventArgs e)
        {  }

        private void btnLotesPorProveedor_Click(object sender, EventArgs e)
        { }

        private void btnLotesXMP_Click(object sender, EventArgs e)
        { }

        private void btnLotes_Click(object sender, EventArgs e)
        {  }

        private void btnCantidadMP_Click(object sender, EventArgs e)
        { }

        private void btnDevolciones_Click_1(object sender, EventArgs e)
        { }

        private void btnTrazabilidad_Click(object sender, EventArgs e)
        {}

        private void cmdTarimasPT_Click(object sender, EventArgs e)
        { }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {}

        private void cmdLotesCalidad_Click(object sender, EventArgs e)
        { }

        private void btndespachos_Click(object sender, EventArgs e)
        {  }

        private void btnplanesdespachos_Click(object sender, EventArgs e)
        { }

        private void btnReq_PT_Click(object sender, EventArgs e)
        {
            JAGUAR_APP.Despachos.frm_Reqresumen_pt frm = new Despachos.frm_Reqresumen_pt(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        { }

        private void btnconfiguracionCal_Click(object sender, EventArgs e)
        { }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
        }

        private void btnplanrequisas_Click(object sender, EventArgs e)
        {
        }

        private void cmdGestionIngresos_Click(object sender, EventArgs e)
        { }

        private void cmdUbicaciones_Click(object sender, EventArgs e)
        { }

        private void btnRecuento_Click(object sender, EventArgs e)
        {

        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {   }

        private void btnPlantarimas_Click(object sender, EventArgs e)
        { }

        private void btnajuste_Click(object sender, EventArgs e)
        {

            //Poner validacion de permisos de forma restrictiva
            RecuentoInventario.frmRecuentoInventario frm = new RecuentoInventario.frmRecuentoInventario();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            //CajaDialogo.Error("Esta opcion esta en mantenimiento! No esta disponible actualmente!");
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        { }

        private void btnPrint_Click(object sender, EventArgs e)
        { }

        private void simpleButton5_Click(object sender, EventArgs e)
        { }

        private void btn_salidapt_Click(object sender, EventArgs e)
        { }

        private void simpleButton6_Click(object sender, EventArgs e)
        { }

        private void simpleButton7_Click(object sender, EventArgs e)
        { }

        private void simpleButton8_Click(object sender, EventArgs e)
        { }

        private void btnRequisasManuales_Click(object sender, EventArgs e)
        { }

        private void simpleButton10_Click(object sender, EventArgs e)
        { }

        private void simpleButton11_Click(object sender, EventArgs e)
        { }

        private void simpleButton12_Click(object sender, EventArgs e)
        { }

        private void btnAlmacenesExternos_Click(object sender, EventArgs e)
        {
            xfrmAlmacenesExternos_Main frm = new xfrmAlmacenesExternos_Main(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                //frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        { }

        private void simpleButton15_Click(object sender, EventArgs e)
        { }

        private void btntarimasactivadasPT_Click(object sender, EventArgs e)
        { }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            //xfrmMovimientoStock frm = new xfrmMovimientoStock(UsuarioLogeado);
            xfrmMovimientoStockMain frm = new xfrmMovimientoStockMain(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdReporteReqManuales_Click(object sender, EventArgs e)
        {
            frmRequisicionesManualesReporte frm = new frmRequisicionesManualesReporte();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            frmRequisicionesManualesReporte frm = new frmRequisicionesManualesReporte();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        { }

        private void btn_andenes_Click(object sender, EventArgs e)
        {
            frmSeleccionAnden frm = new frmSeleccionAnden();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void ManteIngresos_Click(object sender, EventArgs e)
        { }

        private void btnMPReproceso_Click(object sender, EventArgs e)
        { }

        private void simpleButton9_Click(object sender, EventArgs e)
        { }

        private void simpleButton17_Click(object sender, EventArgs e)
        { }

        private void simpleButton17_Click_1(object sender, EventArgs e)
        { }

        private void btnAut_Tm_Click(object sender, EventArgs e)
        { }

        private void tabEntregaMP_Paint(object sender, PaintEventArgs e)
        { }

        private void simpleButton17_Click_2(object sender, EventArgs e)
        { }

        private void simpleButton17_Click_3(object sender, EventArgs e)
        { }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            frmReporteExterno frm = new frmReporteExterno(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLoteActivoGranel_Click(object sender, EventArgs e)
        { }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            try
            {
                bool newVersion;
                bool notificacionesSinLeer;

                NotificacionesGenerales notifications = new NotificacionesGenerales();
                //xfrmPopup frm = new xfrmPopup(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                this.ActiveUserCode = UsuarioLogeado.Id.ToString();
                this.ActiveUserName = UsuarioLogeado.NombreUser;
                this.ActiveUserType = UsuarioLogeado.Tipo;


                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    notifications.Major = ver.Major;
                    notifications.Minor = ver.Minor;
                    notifications.Build = ver.Build;
                    notifications.Revision = ver.Revision;
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    notifications.Major = ver.Major;
                    notifications.Minor = ver.Minor;
                    notifications.Build = ver.Build;
                    notifications.Revision = ver.Revision;
                }

                newVersion = notifications.ValidarVersionBuild(notifications.Major, notifications.Minor, notifications.Build, notifications.Revision, UsuarioLogeado.Id);
                notificacionesSinLeer = notifications.ValidarNotificacionesSinLeer(UsuarioLogeado.Id);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnImprimirTm_Click(object sender, EventArgs e)
        {
            frmprint__tarimas frm = new frmprint__tarimas();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_rptubicaciones_Click(object sender, EventArgs e)
        {
            rptUbicaciones frm = new rptUbicaciones();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        { }

        private void simpleButton20_Click(object sender, EventArgs e)
        { }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            frmReporteProductoTerminado frm = new frmReporteProductoTerminado();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        { }

        private void simpleButton23_Click(object sender, EventArgs e)
        { }

        private void btnReporteProduccionDespachos_Click(object sender, EventArgs e)
        { }

        private void simpleButton24_Click(object sender, EventArgs e)
        { }

        private void simpleButton25_Click(object sender, EventArgs e)
        { }

        private void simpleButton26_Click(object sender, EventArgs e)
        { }

        private void simpleButton27_Click(object sender, EventArgs e)
        { }

        private void simpleButton28_Click(object sender, EventArgs e)
        { }

        private void tabMasterData_Paint(object sender, PaintEventArgs e)
        { }

        private void simpleButton29_Click(object sender, EventArgs e)
        { }

        private void simpleButton30_Click(object sender, EventArgs e)
        { }

        private void simpleButton31_Click(object sender, EventArgs e)
        { }

        private void tabPT_Paint(object sender, PaintEventArgs e)
        { }

        private void simpleButton32_Click(object sender, EventArgs e)
        { }

        private void simpleButton33_Click(object sender, EventArgs e)
        { }

        private void btnClientesLote_Click(object sender, EventArgs e)
        { }

        private void simpleButton34_Click(object sender, EventArgs e)
        { }

        private void cmdReportReqManual_Click(object sender, EventArgs e)
        {
            frmReporteRequisicionesManuales frm = new frmReporteRequisicionesManuales();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
            //frmrptMpEntregadaaProduccion
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        { }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        { }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            frmReporteAsistencia frm = new frmReporteAsistencia(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void cmdReporteInventarioPorFecha_Click(object sender, EventArgs e)
        {
            frmReporteInvPorLoteA_LaFecha frm = new frmReporteInvPorLoteA_LaFecha(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void cmdVerConfiguracionLotesVencimientoMP_Click(object sender, EventArgs e)
        { }

        private void cmdLoteActivoGranel_Click(object sender, EventArgs e)
        { }

        private void cmdReporteProximosVencer_Click(object sender, EventArgs e)
        {
            //frmReporteKardexGeneralVencimiento frm = new frmReporteKardexGeneralVencimiento(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            //frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnRecuento_Click_1(object sender, EventArgs e)
        {
            //Logistica.frmRecuentoInventarios frmRecuentoInventario = new Logistica.frmRecuentoInventarios(this.UsuarioLogeado);
            //frmRecuentoInventario.Show();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //frmEntregaTarimaMicros frm = new frmEntregaTarimaMicros(UsuarioLogeado);
            //if (this.MdiParent != null)
            //{
            //    frm.MdiParent = this.MdiParent;
            //    frm.FormBorderStyle = FormBorderStyle.Sizable;
            //}
            //frm.Show();
        }

        private void btnTransferenciaPendiente_Click(object sender, EventArgs e)
        {
            frmTransPendientes frm = new frmTransPendientes(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void btnHistorialPT_Click(object sender, EventArgs e)
        {
            //frmHisotrialPTCodigo frm = new frmHisotrialPTCodigo();
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void cmdUsuarios_Click(object sender, EventArgs e)
        {
            AccesoUsuario frm = new AccesoUsuario(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdGrupos_Click(object sender, EventArgs e)
        {
            PrincipalGestionGrupos frm = new PrincipalGestionGrupos();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdSistemas_Click(object sender, EventArgs e)
        {
            PrincipalSistemas frm = new PrincipalSistemas();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdGruposAlosy_Click(object sender, EventArgs e)
        {
            PrincipalGrupoLosa frm = new PrincipalGrupoLosa();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdAccesoSistemas_Click(object sender, EventArgs e)
        {
            NivelAccesoSistema frm = new NivelAccesoSistema();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmAlimentacionManual frm = new frmAlimentacionManual(UsuarioLogeado);
            //frm.Show();
            //frmAlimentacionPanel frm = new frmAlimentacionPanel();
            //frm.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmPrintTM frm = new frmPrintTM(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmactivacionPT frm = new frmactivacionPT(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //xfrmCheckActiveBin frm = new xfrmCheckActiveBin();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;

                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbTrazabilidad_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {

                //RPT_Trazabilidad_Lote frm = new RPT_Trazabilidad_Lote(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bnProgramaProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //PP_Main_Products_Order frm = new PP_Main_Products_Order(UsuarioLogeado);
                //frm.ActiveUserCodeP = ActiveUserCode;
                //frm.ActiveUserNameP = ActiveUserName;
                //frm.ActiveUserTypeP = ActiveUserType;
                //frm.MdiParent = this.MdiParent;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bnPortafolio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //PT_Productos frm = new PT_Productos(ActiveUserCode, ActiveUserName, ActiveUserType, this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbControlProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //string a = null;
                int group = 0;
                string Query = @"SELECT 
                                      [id_group]
                                  FROM [ACS].[dbo].[conf_usuarios]
                                  where id = " + ActiveUserCode;
                DataOperations dp = new DataOperations();

                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    group = dr.GetInt32(0);
                }
                //PRB_Registro pp = new PRB_Registro(ActiveUserCode, group, this.UsuarioLogeado);
                //pp.UsuarioLog1 = ActiveUserName;
                //pp.CodigoUss = ActiveUserCode;
                //pp.MdiParent = this.MdiParent;
                //pp.Show();

                try
                {
                    //PRB_Registro frm = new PRB_Registro(ActiveUserCode, group, this.UsuarioLogeado);
                    //frm.UsuarioLog1 = ActiveUserName;
                    //frm.CodigoUss = ActiveUserCode;
                    //frm.MdiParent = this.MdiParent;
                    //if (!frm.CerrarForm)
                    //    frm.Show();
                    //else
                    //    frm.Dispose();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(60))
            //    {
            //        frmDatosBrom frm = new frmDatosBrom(this.UsuarioLogeado);
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #60");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmDatosBrom frm = new frmDatosBrom(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbConsultaHora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //frmHorometrosLineas frm = new frmHorometrosLineas();
                //frm.MdiParent = this.MdiParent;
                //frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;

                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            //accesoprevio = true;
            //PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //frm.MdiParent = this;
            //frm.Show();
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7=ALOSY, 9=AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //        case 2://Basic No Autorization
            //        case 3://Medium Autorization
            //        case 4://Depth With Delta
            //        case 5://Depth Without Delta
            //            accesoprevio = true;
            //            PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //            frm.MdiParent = this;
            //            frm.Show();
            //            break;
            //        default:
            //            break;
            //    }

            //    if (!accesoprevio)
            //    {
            //        if (UsuarioLogeado.ValidarNivelPermisos(69))
            //        {
            //            //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //            frm.MdiParent = this;
            //            frm.Show();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #69");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
        }

        private void nbReporteBatch_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(46))
            //    {
            //        frmintakeKepserver frm = new frmintakeKepserver();
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #46");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmintakeKepserver frm = new frmintakeKepserver(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbReporteEnsacadora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    //reporte ensacadora
            //    if (UsuarioLogeado.ValidarNivelPermisos(48))
            //    {
            //        frmReporteEnsacadora frm = new frmReporteEnsacadora();
            //        frm.MdiParent = this.MdiParent;
            //        frm.WindowState = FormWindowState.Maximized;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmReporteEnsacadora frm = new frmReporteEnsacadora(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    //reporte Ingenieria de procesos.
            //    //Sacos por lotes
            //    if (UsuarioLogeado.ValidarNivelPermisos(48))
            //    {
            //        frmSacosPorLote frm = new frmSacosPorLote();
            //        frm.MdiParent = this.MdiParent;
            //        frm.WindowState = FormWindowState.Maximized;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmSacosPorLote frm = new frmSacosPorLote(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbEficienciaTurno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmDashBoardEficiencia frm = new frmDashBoardEficiencia(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmDashBoardEficiencia frm = new frmDashBoardEficiencia(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbGestionLotes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    PP_Gestion_lote frm = new PP_Gestion_lote(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //PP_Gestion_lote frm = new PP_Gestion_lote(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbReporteEficiencia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{

            //    //Imprimir reporte de eficiencia
            //    frmPrintReportEficiencia frm = new frmPrintReportEficiencia(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmPrintReportEficiencia frm = new frmPrintReportEficiencia(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbEficienciaMolinos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmEficienciaMolinos frm = new frmEficienciaMolinos();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmEficienciaMolinos frm = new frmEficienciaMolinos(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbBannerTV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{

            //    frmBannerMainTV_PRD frm = new frmBannerMainTV_PRD(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    //frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                //frmBannerMainTV_PRD frm = new frmBannerMainTV_PRD(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //            break;
            //        case 2://Basic No Autorization
            //            break;
            //        case 3://Medium Autorization
            //            break;
            //        case 4://Depth With Delta
            //            accesoprevio = true;
            //            frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //            break;
            //        case 5://Depth Without Delta
            //            break;
            //        default:
            //            break;
            //    }

            //    if (!accesoprevio)
            //    {
            //        if (UsuarioLogeado.ValidarNivelPermisos(68))
            //        {
            //            frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #68");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbTemperatura_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    xfrmMenuTemperatura frm = new xfrmMenuTemperatura();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //xfrmMenuTemperatura frm = new xfrmMenuTemperatura(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbForeCastPRD_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //            break;
            //        case 2://Basic No Autorization
            //            break;
            //        case 3://Medium Autorization
            //            break;
            //        case 4://Depth With Delta
            //            accesoprevio = true;
            //            frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //            break;
            //        case 5://Depth Without Delta
            //            break;
            //        default:
            //            break;
            //    }

            //    if (!accesoprevio)
            //    {
            //        if (UsuarioLogeado.ValidarNivelPermisos(71))
            //        {
            //            //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                //frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbConfiguraciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
                //switch (idNivel)
                //{
                //    case 1://Basic View
                //        break;
                //    case 2://Basic No Autorization
                //        break;
                //    case 3://Medium Autorization
                //        break;
                //    case 4://Depth With Delta
                //        accesoprevio = true;
                //        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
                //        frm.MdiParent = this.MdiParent;
                //        frm.Show();
                //        break;
                //    case 5://Depth Without Delta
                //        break;
                //    default:
                //        break;
                //}

                //if (!accesoprevio)
                //{
                //    if (UsuarioLogeado.ValidarNivelPermisos(80))
                //    {
                //        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
                //        frm.MdiParent = this.MdiParent;
                //        frm.Show();
                //    }
                //    else
                //    {
                //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #80");
                //    }
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    IntakeBatchViewerFull frm = new IntakeBatchViewerFull();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
        }

        private void nbPlanProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    Prod_Ordenes_Produccion frm = new Prod_Ordenes_Produccion(ActiveUserCode, ActiveUserName, ActiveUserType, this.UsuarioLogeado);
            //    //frm.MdiParent = this.MdiParent;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void frmTmVirtuales_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    frmrptarimasvirtuales frm = new frmrptarimasvirtuales();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            xfrmAccesosTemporalesAdmin frm = new xfrmAccesosTemporalesAdmin(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void nbTrasladoAceiteExterno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmOilRequest frm = new frmOilRequest(this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            //try
            //{
            //    frmOilRequest frm = new frmOilRequest(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbSetMaterial_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmSetRM_Tantques_Ext frm = new frmSetRM_Tantques_Ext(this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            //try
            //{
            //    frmSetRM_Tantques_Ext frm = new frmSetRM_Tantques_Ext(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbReporteTrasladoAceites_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmReporteTraslados prod = new frmReporteTraslados();
            //    prod.MdiParent = this.MdiParent;
            //    prod.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            //try
            //{
            //    frmReporteTraslados frm = new frmReporteTraslados(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbTrasladosTanquesArriba_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmReporteTrasladosArribaAdvanced frm = new frmReporteTrasladosArribaAdvanced();
            //prod.MdiParent = this.MdiParent;
            //prod.Show();
            //try
            //{
            //    frmReporteTrasladosArribaAdvanced frm = new frmReporteTrasladosArribaAdvanced(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbSalidaAceite_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmReporteConsumoLinea frm = new frmReporteConsumoLinea(this.UsuarioLogeado);
            //prod.MdiParent = this.MdiParent;
            //prod.Show();
            //try
            //{
            //    frmReporteConsumoLinea frm = new frmReporteConsumoLinea(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbSetLoteGranel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //if (UsuarioLogeado.ValidarNivelPermisos(8))
            //{
            //    frmLoteActivoGraneles frm = new frmLoteActivoGraneles();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //else
            //{
            //    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            //}
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frm_report_oil_in_and_out frm = new frm_report_oil_in_and_out();
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
            //try
            //{
            //    frm_report_oil_in_and_out frm = new frm_report_oil_in_and_out(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden();
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}

            //if (!accesoprevio)
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(73))
            //    {
            //        //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //        frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden();
            //        frm.MdiParent = this;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #73");
            //    }
            //}

            //try
            //{
            //    frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void nbTrazabilidad_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    RPT_Trazabilidad_Lote frm = new RPT_Trazabilidad_Lote(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;

            //    if (!frm.CerrarForm)
            //        frm.Show();
            //    else
            //        frm.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            //frmEmpleadosM FRM = new frmEmpleadosM();
            //FRM.MdiParent = this.MdiParent;
            //FRM.Show();
        }

        private void simpleButton39_Click(object sender, EventArgs e)
        {
            //OC_Menu frmCom = new OC_Menu(UsuarioLogeado);
            //frmCom.MdiParent = this.MdiParent;
            //frmCom.WindowState = FormWindowState.Maximized;
            //frmCom.Show();
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {

            //if (UsuarioLogeado.ValidarNivelPermisos(57))
            //{
            //    frmGestionAccesosEncuesta frm = new frmGestionAccesosEncuesta();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //else
            //{
            //    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #57");
            //}
        }

        private void simpleButton41_Click(object sender, EventArgs e)
        {
            //Frm_MantenimientoFace frm = new Frm_MantenimientoFace();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton42_Click(object sender, EventArgs e)
        {
            //frmResumenHorasExtra frm = new frmResumenHorasExtra(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton43_Click(object sender, EventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmResumenNominas frm = new frmResumenNominas();
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmResumenVacaciones frm = new frmResumenVacaciones();
            //        frm.MdiParent = this;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton45_Click(object sender, EventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmLiquidacionesOP frm = new frmLiquidacionesOP(UsuarioLogeado);
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton46_Click(object sender, EventArgs e)
        {
            //frmSaldosVacacionesRRHH frm = new frmSaldosVacacionesRRHH(this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton49_Click(object sender, EventArgs e)
        {
            //FML_Compare_Cost_External_Local form = new FML_Compare_Cost_External_Local();
            //form.MdiParent = this.MdiParent;
            //form.Show();
        }

        private void simpleButton47_Click(object sender, EventArgs e)
        {
            //FCT_Proyeccion_Ventas forecast = new FCT_Proyeccion_Ventas();
            ////forecast.MdiParent = this;
            //forecast.ActiveUserCode = ActiveUserCode;
            //forecast.ShowDialog();
        }

        private void simpleButton51_Click(object sender, EventArgs e)
        {
            //FCT_Volumenes vol = new FCT_Volumenes();
            ////vol.MdiParent = this;
            //vol.ActiveUserCode = ActiveUserCode;
            //vol.ShowDialog();
        }

        private void simpleButton50_Click(object sender, EventArgs e)
        {
            //FCT_MRP mrp = new FCT_MRP(this.UsuarioLogeado);
            ////mrp.MdiParent = this;
            //mrp.ActiveUserCode = ActiveUserCode;
            //mrp.ShowDialog();
        }

        private void simpleButton48_Click(object sender, EventArgs e)
        {
            //FCT_Proyeccion_Sacos frm = new FCT_Proyeccion_Sacos();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton56_Click(object sender, EventArgs e)
        {
            //FCT_Proyeccion_Etiquetas frm = new FCT_Proyeccion_Etiquetas();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton52_Click(object sender, EventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        //accesoprevio = true;
            //        //FCT_MRP_Complete frm = new FCT_MRP_Complete(this.UsuarioLogeado);
            //        //frm.MdiParent = this.MdiParent;
            //        //frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton53_Click(object sender, EventArgs e)
        {
            ////AFC_ProyeccionVentas
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        //AFC_ProyeccionVentas frm = new AFC_ProyeccionVentas(UsuarioLogeado);
            //        //frm.MdiParent = this;
            //        //frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}
        }

        private void simpleButton54_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    //accesoprevio = true;
                    //frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                    //frm.MdiParent = this;
                    //frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(71))
                {
                    //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                    //frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                    //frm.MdiParent = this;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
                }
            }
        }

        private void simpleButton55_Click(object sender, EventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    //AFC_ConsumoReal frm = new AFC_ConsumoReal();
                    //frm.MdiParent = this;
                    //frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(71))
                {
                    //AFC_ConsumoReal frm = new AFC_ConsumoReal();
                    //frm.MdiParent = this;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
                }
            }
        }

        private void simpleButton58_Click(object sender, EventArgs e)
        {
            try
            {
                //MigracionACS.Produccion.Reports.Rep_Fml_Uso form = new MigracionACS.Produccion.Reports.Rep_Fml_Uso();
                //form.MdiParent = this.MdiParent;
                //form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);               
            }
        }

        private void simpleButton59_Click(object sender, EventArgs e)
        {
            try
            {
                //MigracionACS.Finanzas.Reports.Rep_Fml_Uso form = new MigracionACS.Finanzas.Reports.Rep_Fml_Uso();
                //form.MdiParent = this.MdiParent;
                //form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        
        }

        private void simpleButton62_Click(object sender, EventArgs e)
        {
            try
            {
              //MigracionACS.Finanzas.Reports.RPT_Conta_Varios form = new MigracionACS.Finanzas.Reports.RPT_Conta_Varios(ActiveUserCode, ActiveUserType, ActiveADUser, UserGroups, this.UsuarioLogeado);
              //  form.MdiParent = this.MdiParent;
              //  form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton65_Click(object sender, EventArgs e)
        {
            try
            {
            //MigracionACS. Finanzas.Reports.RPT_FML_NC_MasterDetailReport form = new MigracionACS.Finanzas.Reports.RPT_FML_NC_MasterDetailReport();
            //    form.MdiParent = this.MdiParent;
            //form.Show();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton61_Click(object sender, EventArgs e)
        {
            try
            {
               //MigracionACS.Finanzas.Reports.RPT_FML_FL_FF_CostVar_MasterDetailReport form = new MigracionACS.Finanzas.Reports.RPT_FML_FL_FF_CostVar_MasterDetailReport(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups);
               // form.MdiParent = this.MdiParent;
               // form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton60_Click(object sender, EventArgs e)
        {
            try
            {
                int user_id = int.Parse(ActiveUserCode);
                //user_id = GetUserID(ActiveUserName);

                if (user_id == 1020 || user_id == 1035 || user_id == 1037)
                {
                    //frm_Reporteador_Validate_byUser frm = new frm_Reporteador_Validate_byUser(ActiveUserCode, ActiveUserName, ActiveUserType);
                    //frm.MdiParent = this.MdiParent;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene permisos para Abrir esta ventana");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void simpleButton66_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(34))
                {
                   //MigracionACS.SAR.SAR_Main frmAll = new MigracionACS.SAR.SAR_Main();
                   // frmAll.MdiParent = this.MdiParent;
                   // frmAll.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #34");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void simpleButton63_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(58))
                {
                    //frmConsumoConsolaReal frm = new frmConsumoConsolaReal();
                    //frm.MdiParent = this;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #58");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
             
            }
        }

        private void simpleButton64_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(58))
                {
                    //frmConsumoConsolaTeorico frm = new frmConsumoConsolaTeorico();
                    //frm.MdiParent = this.MdiParent;
                    //frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #58");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            
            }
        }

        private void simpleButton57_Click(object sender, EventArgs e)
        {
            rd_OdooMenu.ShowPopup(new Point((this.Width / 2), (this.Height / 2)));
        }

        private void btnMP_BodsegaPRD_Click(object sender, EventArgs e)
        {
            //frm_MateriaPrimaEnBodegaPRd frm = new frm_MateriaPrimaEnBodegaPRd(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btn_mp_bodega_prd_finanzas_Click(object sender, EventArgs e)
        {
            //frm_MateriaPrimaEnBodegaPRd frm = new frm_MateriaPrimaEnBodegaPRd(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnRutas_traza_produccion_Click(object sender, EventArgs e)
        {
            //frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnrutas_traz_logistica_Click(object sender, EventArgs e)
        {
            //frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btn_rutas_traza_contabilidad_Click(object sender, EventArgs e)
        {
            //frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void btnAprobaTarimasConta_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_tarimas_pt_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //frmReporteTrasladosArribaByLotePT frm = new frmReporteTrasladosArribaByLotePT(this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                //if (!frm.CerrarForm)
                //    frm.Show();
                //else
                //    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton67_Click(object sender, EventArgs e)
        {
            //xfrmReporteLotesAConsumir frm = new xfrmReporteLotesAConsumir();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //xfrmReporteLotesAConsumir frm = new xfrmReporteLotesAConsumir();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton68_Click(object sender, EventArgs e)
        {
            try
            {
                //TT_Arribo arrib = new TT_Arribo(ActiveUserCode);
                //arrib.MdiParent = this.MdiParent;
                //arrib.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton71_Click(object sender, EventArgs e)
        {
            try
            {
                //TT_reporte_bascula rept = new TT_reporte_bascula();
                //rept.MdiParent = this.MdiParent;
                //rept.WindowState = FormWindowState.Maximized;
                //rept.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton70_Click(object sender, EventArgs e)
        {
            try
            {
                //frmCamionesEnPredio rept = new frmCamionesEnPredio(UsuarioLogeado);
                //rept.MdiParent = this.MdiParent;
                ////rept.WindowState = FormWindowState.Maximized;
                //rept.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton69_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //            break;
            //        case 2://Basic No Autorization
            //            break;
            //        case 3://Medium Autorization
            //            break;
            //        case 4://Depth With Delta
            //            //accesoprevio = true;
            //            //frmDetalleDesechos frm = new frmDetalleDesechos(this.UsuarioLogeado);
            //            //frm.MdiParent = this.MdiParent;
            //            //frm.Show();
            //            break;
            //        case 5://Depth Without Delta
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void simpleButton72_Click(object sender, EventArgs e)
        {
            try
            {
                //FML_FF_Main_Panel form = new FML_FF_Main_Panel(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups);
                //form.MdiParent = this.MdiParent;
                //form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton73_Click(object sender, EventArgs e)
        {
            try
            {
                //FML_Formulas_v2 fm = new FML_Formulas_v2(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups);
                //fm.MdiParent = this.MdiParent;
                //fm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem9_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //xfrmMP_Por_BIN frm = new xfrmMP_Por_BIN();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void simpleButton74_Click(object sender, EventArgs e)
        {
            frmMainProductoTerminado frm = new frmMainProductoTerminado(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            Mantenimientos.MateriaPrima.xfrmMasterMP_Admin frm = new Mantenimientos.MateriaPrima.xfrmMasterMP_Admin(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton75_Click(object sender, EventArgs e)
        {
            //frmAddVentana frm = new frmAddVentana(frmAddVentana.Accion.nuevo, 0, this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            frmMantVentanas frm = new frmMantVentanas(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton76_Click(object sender, EventArgs e)
        {
            frmUsuariosAccesos frm = new frmUsuariosAccesos(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdTiposMP_Click(object sender, EventArgs e)
        {
            Mantenimientos.MateriaPrima.xfrmMP_Tipo_Admin frm = new Mantenimientos.MateriaPrima.xfrmMP_Tipo_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdEstados_Click(object sender, EventArgs e)
        {
            Mantenimientos.MateriaPrima.xfrmMP_Estados_Admin frm = new Mantenimientos.MateriaPrima.xfrmMP_Estados_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdFML_Tipo_Click(object sender, EventArgs e)
        {
            xfrmMP_Tipo_Formula_Admin frm = new xfrmMP_Tipo_Formula_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmd_estadosFML_Click(object sender, EventArgs e)
        {
            xfrmFML_Formula_Estados_Admin frm = new xfrmFML_Formula_Estados_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmd_estadosFML_Click_1(object sender, EventArgs e)
        {
            xfrmFML_Formula_Estados_Admin frm = new xfrmFML_Formula_Estados_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

       

        private void cmdFML_Tipo_Click_1(object sender, EventArgs e)
        {
            xfrmMP_Tipo_Formula_Admin frm = new xfrmMP_Tipo_Formula_Admin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdProveedores_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_Proveedor_Admin frm = new xfrmJAGUAR_Proveedor_Admin(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void simpleButton77_Click(object sender, EventArgs e)
        {
            xfrmProveedorCAI frm = new xfrmProveedorCAI(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdFacturas_Click(object sender, EventArgs e)
        {
            xfrmProveedorFactura frm = new xfrmProveedorFactura(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }


        private void cmdPanaderos_Click_1(object sender, EventArgs e)
        {
            xfrmJAGUAR_Panaderos frm = new xfrmJAGUAR_Panaderos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItemRecepcionFactura_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {
                    frmRecepcionFacturaProveedor frm = new frmRecepcionFacturaProveedor(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }
            
        }

        private void simpleButton78_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_TipoPresentacionConversion frm = new xfrmJAGUAR_TipoPresentacionConversion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItemOrdenFabricacion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmProductionOrdersHome frm = new frmProductionOrdersHome(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {
                    frmProductionOrdersHome frm = new frmProductionOrdersHome(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmMainProductoTerminado frm = new frmMainProductoTerminado(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(4))
                {
                    frmMainProductoTerminado frm = new frmMainProductoTerminado(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #4 (Acceso Recetas)");
                }
            }



            //frmMainProductoTerminado frm = new frmMainProductoTerminado(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmPedidoHome
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmPedidoHome frm = new frmPedidoHome(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(4))
                {
                    frmPedidoHome frm = new frmPedidoHome(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #5 (Acceso Pedidos)");
                }
            }
        }//





        private void simpleButton2_Click_2(object sender, EventArgs e)
        {
            frmReporteInventarioKardexGeneral frm = new frmReporteInventarioKardexGeneral(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_Clientes frm = new xfrmJAGUAR_Clientes(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmReporteInventarioKardexGeneral frm = new frmReporteInventarioKardexGeneral(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItemRequisiciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmRequisiciones frm = new frmRequisiciones(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(4))
                {
                    frmRequisiciones frm = new frmRequisiciones(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #6 (Acceso Requisiciones)");
                }
            }
        }

        private void navBarItemKardexPT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmReporteGeneralProductoTerminado frm = new frmReporteGeneralProductoTerminado(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnME_Click(object sender, EventArgs e)
        {
            xfrmJAGUAR_MaterialEmpaque frm = new xfrmJAGUAR_MaterialEmpaque(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItemCAI_Proveedores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrmProveedorCAI frm = new xfrmProveedorCAI(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {
                    xfrmProveedorCAI frm = new xfrmProveedorCAI(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }
            //xfrmProveedorCAI frm = new xfrmProveedorCAI();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void navBarItemmaterialEmpaqueLogistica_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrmJAGUAR_MaterialEmpaque frm = new xfrmJAGUAR_MaterialEmpaque(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(8))
                {
                    xfrmJAGUAR_MaterialEmpaque frm = new xfrmJAGUAR_MaterialEmpaque(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #8 (Gestión Datos maestros Material de Empaque)");
                }
            }
        }

        private void navBarItemAvanceProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //avance de produccion ingreso de latas
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmHomeAvanceProduccion frm = new frmHomeAvanceProduccion(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {
                    frmHomeAvanceProduccion frm = new frmHomeAvanceProduccion(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }
            
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Recibo de produccion
            //frmHomeAvanceProduccionBolsas
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeAvanceProduccionBolsas frm = new frmHomeAvanceProduccionBolsas(this.UsuarioLogeado);
                    
                    //Version donde no se selecciona la orden de fabricacion
                    //frmHomeAvanceProduccionBolsasGroupBy frm = new frmHomeAvanceProduccionBolsasGroupBy(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(9))
                {
                    frmHomeAvanceProduccionBolsas frm = new frmHomeAvanceProduccionBolsas(this.UsuarioLogeado);

                    //Version donde no se selecciona la orden de fabricacion
                    //frmHomeAvanceProduccionBolsasGroupBy frm = new frmHomeAvanceProduccionBolsasGroupBy(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #9 (Recepción de Producto Terminado)");
                }
            }
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    xfrmJAGUAR_Proveedor_Admin frm = new xfrmJAGUAR_Proveedor_Admin(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {
                    xfrmProveedorCAI frm = new xfrmProveedorCAI(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }
        }

        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //DateTime FechaInicio=Convert.ToDateTime( "2023-01-01");
            //DateTime FechaFin=Convert.ToDateTime( "2023-05-01");

            //rptHistoricoPT report = new rptHistoricoPT(FechaInicio, FechaFin);

            //using (ReportPrintTool printTool = new ReportPrintTool(report))
            //{
            //    // Send the report to the default printer.
            //    printTool.ShowPreviewDialog();
            //}

            frmReporteGeneralProductoTerminadoHST frm = new frmReporteGeneralProductoTerminadoHST(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void navBarItem23_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeProductoDanado frm = new frmHomeProductoDanado(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(9))
                {
                    frmHomeProductoDanado frm = new frmHomeProductoDanado(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #9 (Recepción de Producto Terminado)");
                }
            }
        }

        private void simpleButton2_Click_3(object sender, EventArgs e)
        {
            PrincipalTurnos frm = new PrincipalTurnos(UsuarioLogeado);
            //PrincipalTurnos frm = new PrincipalTurnos(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnClienteFacturacion_Click(object sender, EventArgs e)
        {
            xfrmFacturacion_Clientes frm = new xfrmFacturacion_Clientes(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnNumeracion_Click(object sender, EventArgs e)
        {
            frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnMantoPDV_Click(object sender, EventArgs e)
        {
            xfrm_PDV frm = new xfrm_PDV(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarFacturaMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if(!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    
                    frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    ////frmFactura frm = new frmFactura(this.UsuarioLogeado);
                    ////frm.MdiParent = this.MdiParent;
                    ////frm.Show();
                    //switch (puntoVenta1.TipoFacturacionID)
                    //{
                    //    //1	Facturación Rápida
                    //    case 1:
                    //        frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    //        frm.MdiParent = this.MdiParent;
                    //        frm.Show();
                    //        break;

                    //    //2	Facturación Normal
                    //    case 2:

                    //        break;
                    //}
                    frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnListaPrecios_Click(object sender, EventArgs e)
        {

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(12))
                {
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #12 (Gestion de Lista de Precio)");
                }
            }
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            xfrmDespachoAdmin xfrm = new xfrmDespachoAdmin(UsuarioLogeado);
            xfrm.MdiParent = this.MdiParent;
            xfrm.Show();
        }

        private void navBarItemFacturasEmitidas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }



            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeFacturasEmitidas frm = new frmHomeFacturasEmitidas(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {

                    frmHomeFacturasEmitidas frm = new frmHomeFacturasEmitidas(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarControl3_Click(object sender, EventArgs e)
        {

        }

        private void NBI_Cliente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoClientes();
        }

        private void AccesoAMantoClientes()
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    accesoprevio = false;
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrmFacturacion_Clientes frm = new xfrmFacturacion_Clientes(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {

                    xfrmFacturacion_Clientes frm = new xfrmFacturacion_Clientes(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
            
        }

        private void AccesoAMantoNumeracionFiscal()
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    accesoprevio = false;
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {

                    frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #16 (Configuraciones de Facturacion)");
                }
            }
            
        }

        private void AccesoMantoPuntosDeVenta()
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    xfrm_PDV frm = new xfrm_PDV(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    accesoprevio = true;
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {

                    xfrm_PDV frm = new xfrm_PDV(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #16 (Configuraciones de Facturacion)");
                }
            }
            
        }

        private void NBI_NumeracionFiscal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoNumeracionFiscal();
        }

        private void AccesoAMantoListasDePrecio()
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    xfrnListaPrecioAdmin frm2 = new xfrnListaPrecioAdmin(UsuarioLogeado);
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(12))
                {
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #12 (Gestion de Lista de Precio)");
                }
            }
        }

        private void NBI_PuntoVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoMantoPuntosDeVenta();
        }

        private void NBI_ListaPrecios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoListasDePrecio();
        }

        private void NBI_Despachos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoTraslados(true, "Recepcion de Factura");
        }

       

        private void AccesoAMantoTraslados(bool pMostrarCopiarDesdeFactura, string pStringVentana)
        {
            //xfrmDespachoAdmin xfrm = new xfrmDespachoAdmin(UsuarioLogeado);
            //xfrm.MdiParent = this.MdiParent;
            //xfrm.Show();

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    //accesoprevio = true;
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    string HostName = Dns.GetHostName();
                    FacturacionEquipo EquipoActual = new FacturacionEquipo();
                    PDV puntoVenta1 = new PDV();

                    if (EquipoActual.RecuperarRegistro(HostName))
                    {
                        if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                        {
                            CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                            return;
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                        return;
                    }

                    xfrmTrasladoRecepcionDetalleFactura frm = new xfrmTrasladoRecepcionDetalleFactura(this.UsuarioLogeado, puntoVenta1.ID, pStringVentana);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(13))
                {
                    string HostName = Dns.GetHostName();
                    FacturacionEquipo EquipoActual = new FacturacionEquipo();
                    PDV puntoVenta1 = new PDV();

                    if (EquipoActual.RecuperarRegistro(HostName))
                    {
                        if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                        {
                            CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                            return;
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                        return;
                    }

                    xfrmTrasladoRecepcionDetalleFactura frm = new xfrmTrasladoRecepcionDetalleFactura(this.UsuarioLogeado, puntoVenta1.ID, pStringVentana);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #13 (Despacho de Producto Terminado)");
                }
            }
        }

        private void navBarItem24_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AccesoAMantoTraslados(true, "Entrega de Factura");
        }

        private void navBarItem55_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    HomeEstadoCuenta frm2 = new HomeEstadoCuenta(20);
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    HomeEstadoCuenta frm = new HomeEstadoCuenta(20);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    HomeEstadoCuenta frm = new HomeEstadoCuenta(20);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Gestion de Facturacion)");
                }
            }

        }

        private void nbRequest_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    frmHomeSolicitudesAutorizacion frm2 = new frmHomeSolicitudesAutorizacion(UsuarioLogeado);
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeSolicitudesAutorizacion frm = new frmHomeSolicitudesAutorizacion(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {
                    frmHomeSolicitudesAutorizacion frm = new frmHomeSolicitudesAutorizacion(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #16 (Configuracion de Facturacion)");
                }
            }
        }

        private void nB_PagoMultiple_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomePagoMultipleSimple frm = new frmHomePagoMultipleSimple(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    frmHomePagoMultipleSimple frm = new frmHomePagoMultipleSimple(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarItem56_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomeNotasCreditoDebito frm = new frmHomeNotasCreditoDebito(UsuarioLogeado );
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {
                    frmHomeNotasCreditoDebito frm = new frmHomeNotasCreditoDebito( UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #16 (Configuracion de Facturacion)");
                }
            }
        }

        private void navBarItem57_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmCierreDiaHome frm = new frmCierreDiaHome(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(14))
                {
                    frmCierreDiaHome frm = new frmCierreDiaHome(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #14 (Cierre de caja, punto de venta)");
                }
            }
        }

        private void nbKardexFacturacion_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmKardexFacturacion frm = new frmKardexFacturacion(UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }
            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    frmKardexFacturacion frm = new frmKardexFacturacion(UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Perfil de facturador)");
                }
            }
        }

        private void navBarItem58_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }



            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    frmFacturaWithPDV frm = new frmFacturaWithPDV(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    frmFacturaWithPDV frm = new frmFacturaWithPDV(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarItem59_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    frmReporteConsumoMPPorDia frm = new frmReporteConsumoMPPorDia();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }
        }

        private void nBarRecepcionFactPuntoVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }



            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    //xfrmTrasladoRecepcion frm = new xfrmTrasladoRecepcion(this.UsuarioLogeado, puntoVenta1.ID, true);
                    xfrmTrasladoRecepcionDetalleFactura frm = new xfrmTrasladoRecepcionDetalleFactura(0, this.UsuarioLogeado, puntoVenta1.ID);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    //xfrmTrasladoRecepcion frm = new xfrmTrasladoRecepcion(this.UsuarioLogeado, puntoVenta1.ID, true);
                    xfrmTrasladoRecepcionDetalleFactura frm = new xfrmTrasladoRecepcionDetalleFactura(0, this.UsuarioLogeado, puntoVenta1.ID);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarCotizaciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmCotizacionesHome frm = new frmCotizacionesHome(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }
        }
    }
}