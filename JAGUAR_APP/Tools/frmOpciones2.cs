
using ACS.Classes;
using ACS.Produccion;
using LOSA.Accesos;
using LOSA.Accesos.AccesosUsuarios;
using LOSA.Accesos.GestionGrupos;
using LOSA.Accesos.GestionSistemas;
using LOSA.Accesos.GrupoLosa;
using LOSA.Accesos.NivelAccesoSistema;
using LOSA.ACS.RRHH;
using LOSA.AlmacenesExterno;
using LOSA.AlmacenesExterno.Salida_Almacen;
using LOSA.Calidad;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.Calidad.Revision_Sanidad;
using LOSA.Clases;
using LOSA.Despachos;
using LOSA.Liquidos;
using LOSA.Logistica;
using LOSA.Mantenimientos;
using LOSA.MigracionACS.Produccion;
using LOSA.MigracionACS.Produccion.BannerTV;
using LOSA.MigracionACS.Produccion.Configuraciones;
using LOSA.MigracionACS.Produccion.Consumos;
using LOSA.MigracionACS.Produccion.Eficiencia;
using LOSA.MigracionACS.Produccion.Eficiencia.DatosBromatologicos;
using LOSA.MigracionACS.Produccion.ForecastPRD;
using LOSA.MigracionACS.Produccion.Produccion.DashBoard;
using LOSA.MigracionACS.Produccion.Reports;
using LOSA.MigracionACS.Produccion.TemperaturaMaquinas;
using LOSA.MigracionACS.PT;
using LOSA.Nir;
using LOSA.PlanMPreque;
using LOSA.Produccion;
using LOSA.RecepcionMP;
using LOSA.RecuentoInventario;
using LOSA.Reportes;
using LOSA.Reproceso;
using LOSA.Tools;
using LOSA.TransaccionesMP;
using LOSA.TransaccionesPT;
using LOSA.Trazabilidad;
using LOSA.Trazabilidad.ReportesTRZ;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace LOSA
{
    public partial class frmOpciones2 : Form
    {
        UserLogin UsuarioLogeado;
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string ActiveADUser;
        DataTable UserGroups;

        public frmOpciones2(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            int i = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
            //int i = Convert.ToInt32(4);
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
                    int idNivel = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
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
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                        case 5://Depth Without Delta

                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Administradores:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.Produccion:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.ProduccionV2:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i-1].PageVisible = true;

                    idNivel = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
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
                    int idNivel2 = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
                    switch (idNivel2)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel2;
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
                            tabOpciones.SelectedTabPageIndex = 2;//Calidad
                            tabOpciones.TabPages[1].PageVisible = true;
                            break;
                    }
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
            cmdRegistroLote.Enabled =
            cmdGestionIngresos.Enabled =
            btnAjustesKardex.Enabled =
            cmdOrdenesFabricacion.Enabled =
            btnplanrequisas.Enabled =
            cmdRequisiciones_.Enabled =
            btnajuste.Enabled =
            cmdUbicaciones.Enabled =
            simpleButton3.Enabled =
            btndespachos.Enabled =
            btnReq_PT.Enabled =
            simpleButton2.Enabled =
            btnPlantarimas.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //frmMantenimiento frm = new frmMantenimiento();
            //frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRecepcionMPLogistica_Click(object sender, EventArgs e)
        {
            //
            frmImprimirHojaIngreso frm = new frmImprimirHojaIngreso(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            //frmBodega frm = new frmBodega();
            //frm.Show();
        }

        private void BtnTiposPresentaciones_Click(object sender, EventArgs e)
        {
            //frmTipoPresentacion frm = new frmTipoPresentacion();
            //frm.Show();
        }

        private void BtnEstadosProgramacionesRequisiciones_Click(object sender, EventArgs e)
        {
            //frmEstadoProgramacionRequisicion frm = new frmEstadoProgramacionRequisicion();
            //frm.Show();
        }

        private void BtnKardexTiposTransacciones_Click(object sender, EventArgs e)
        {
            //frmKardexTipoTransaccion frm = new frmKardexTipoTransaccion();
            //frm.Show();
        }

        private void BtnEstadosRequisiciones_Click(object sender, EventArgs e)
        {
            //frmEstadoRequisicion frm = new frmEstadoRequisicion();
            //frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Mantenimientos
            frmMantoOpciones frm = new frmMantoOpciones(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {

            frm_ingresos frm = new frm_ingresos(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            //frmTarima frm = new frmTarima(UsuarioLogeado);
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmEntradaMP frm = new frmEntradaMP(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void BtnCambiarUbicacion_Click(object sender, EventArgs e)
        {
            frmCambiarUbicacionTarima frm = new frmCambiarUbicacionTarima();
            frm.Show();
        }

        private void cmdProgramaRequisiciones_Click(object sender, EventArgs e)
        {
            frmOrdenesFabricacion frm = new frmOrdenesFabricacion(this.UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void BtnDevolciones_Click(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void BtnAjustesKardex_Click(object sender, EventArgs e)
        {
            frmAjustesKardex frm = new frmAjustesKardex(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void cmdRequisiciones_Click(object sender, EventArgs e)
        {

        }

        private void cmdRequisiciones__Click(object sender, EventArgs e)
        {
            frmRequisiciones frm = new frmRequisiciones(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdPT_Click(object sender, EventArgs e)
        {
            frmOptionMontaCarga frm = new frmOptionMontaCarga(UsuarioLogeado, 2);//pt
            //frm.WindowState = FormWindowState.Maximized;
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void cmdMP_Click(object sender, EventArgs e)
        {
            frmOptionMontaCarga frm = new frmOptionMontaCarga(UsuarioLogeado, 1);//MP
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();


        }

        private void btnAlimentacionManual_Click(object sender, EventArgs e)
        {
            //frmAlimentacionManual frm = new frmAlimentacionManual(UsuarioLogeado);
            //frm.Show();
            frmAlimentacionPanel frm = new frmAlimentacionPanel();
            frm.Show();
        }

        private void btnLotesPorProveedor_Click(object sender, EventArgs e)
        {
            frmLotesXProveedor frm = new frmLotesXProveedor();
            frm.Show();
        }

        private void btnLotesXMP_Click(object sender, EventArgs e)
        {
            frmLotesXMP frm = new frmLotesXMP();
            frm.Show();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            frmLotes frm = new frmLotes();
            frm.Show();
        }

        private void btnCantidadMP_Click(object sender, EventArgs e)
        {
            frmCantidadMP frm = new frmCantidadMP();
            frm.Show();
        }

        private void btnDevolciones_Click_1(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            frm.Show();
        }

        private void btnTrazabilidad_Click(object sender, EventArgs e)
        {
           frmTrazabilidadLote frm = new frmTrazabilidadLote();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdTarimasPT_Click(object sender, EventArgs e)
        {
            //frmHomeEnsacado frm = new frmHomeEnsacado(UsuarioLogeado);
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            frmactivacionPT frm = new frmactivacionPT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdLotesCalidad_Click(object sender, EventArgs e)
        {
            frmLotesStatus frm = new frmLotesStatus(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btndespachos_Click(object sender, EventArgs e)
        {
            LOSA.Despachos.frmdespachos frm = new LOSA.Despachos.frmdespachos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnplanesdespachos_Click(object sender, EventArgs e)
        {
            //LOSA.Despachos.frmplanes FRM = new Despachos.frmplanes(UsuarioLogeado);
            //FRM.Show();
        }

        private void btnReq_PT_Click(object sender, EventArgs e)
        {
            LOSA.Despachos.frm_Reqresumen_pt frm = new Despachos.frm_Reqresumen_pt(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            LOSA.Reportes.frmreport frm = new Reportes.frmreport(this.UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.Show();
        }

        private void btnconfiguracionCal_Click(object sender, EventArgs e)
        {
            frmcalidadcausas frm = new frmcalidadcausas();
            frm.Show();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            //frmTarimaManual FRM = new frmTarimaManual(UsuarioLogeado);
            //FRM.Show();
            frmMP_Granel frm = new frmMP_Granel(UsuarioLogeado);
            

            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnplanrequisas_Click(object sender, EventArgs e)
        {
            frmnewplan frm = new frmnewplan(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.Show();

        }

        private void cmdGestionIngresos_Click(object sender, EventArgs e)
        {
            //abrir la ventana de gestion de ingresos.
            frmGestionIngresos frm = new frmGestionIngresos(this.UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdUbicaciones_Click(object sender, EventArgs e)
        {
            frmGestionUbicaciones frm = new frmGestionUbicaciones(this.UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnRecuento_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            frmPlanPT frm = new frmPlanPT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnPlantarimas_Click(object sender, EventArgs e)
        {
            frm_planificacion_despachos frm = new frm_planificacion_despachos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnajuste_Click(object sender, EventArgs e)
        {

            //Poner validacion de permisos de forma restrictiva
            RecuentoInventario.frmRecuentoInventario frm = new RecuentoInventario.frmRecuentoInventario();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            //CajaDialogo.Error("Esta opcion esta en mantenimiento! No esta disponible actualmente!");
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            frmcalidad frm = new frmcalidad(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrintTM frm = new frmPrintTM(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmreporte_trazabilidad frm = new frmreporte_trazabilidad(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_salidapt_Click(object sender, EventArgs e)
        {
            frmdespacho frm = new frmdespacho(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            frmreporte_trazabilidad frm = new frmreporte_trazabilidad(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnRequisasManuales_Click(object sender, EventArgs e)
        {
            frmRequisasManuales frm = new frmRequisasManuales(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            frm_ajustes_inventario_PT frm = new frm_ajustes_inventario_PT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            frm_reporte_produccion frm = new frm_reporte_produccion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            frm_reporte_produccion frm = new frm_reporte_produccion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

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
        {
            frm_view_ingresos frm = new frm_view_ingresos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            frmRequisiciones frm = new frmRequisiciones(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btntarimasactivadasPT_Click(object sender, EventArgs e)
        {
            frm_rpt_productoT frm = new frm_rpt_productoT();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

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
        {
            frmTrazabilidadOpciones frm = new frmTrazabilidadOpciones(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_andenes_Click(object sender, EventArgs e)
        {
            frmSeleccionAnden frm = new frmSeleccionAnden();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void ManteIngresos_Click(object sender, EventArgs e)
        {
            frm_mantenimiento_calidad frm = new frm_mantenimiento_calidad(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnMPReproceso_Click(object sender, EventArgs e)
        {

           xfrmReprocesoMenu frm = new xfrmReprocesoMenu(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            frmLecturas frm = new frmLecturas(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton17_Click_1(object sender, EventArgs e)
        {
            xfrmIngresoLiquidos frm = new xfrmIngresoLiquidos(UsuarioLogeado);

            //xfrmTanque frm = new xfrmTanque();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnAut_Tm_Click(object sender, EventArgs e)
        {

        }

        private void tabEntregaMP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton17_Click_2(object sender, EventArgs e)
        {
            //frmPendienteAlmacenExterno frm = new frmPendienteAlmacenExterno(UsuarioLogeado);
            //Reproceso.frmReprocesoPrint frm = new Reproceso.frmReprocesoPrint();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            //xfrmIngresosMP_Reproceso frm = new xfrmIngresosMP_Reproceso(UsuarioLogeado);
            Reproceso.frmReprocesoPrint frm = new Reproceso.frmReprocesoPrint(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton17_Click_3(object sender, EventArgs e)
        {
            xfrmCheckActiveBin frm = new xfrmCheckActiveBin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            frmReporteExterno frm = new frmReporteExterno(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLoteActivoGranel_Click(object sender, EventArgs e)
        {
            frmLoteActivoGranel frm = new frmLoteActivoGranel(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            try
            {
                bool newVersion;
                bool notificacionesSinLeer;

                NotificacionesGenerales notifications = new NotificacionesGenerales();
                xfrmPopup frm = new xfrmPopup(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;

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

                if (notificacionesSinLeer)
                {
                    frm.Show();
                }
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
        {
            frmTrazabilidadHaciaAdelanteByMP_Lot frm = new frmTrazabilidadHaciaAdelanteByMP_Lot();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            frmControlIngreso frm = new frmControlIngreso();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            frmReporteProductoTerminado frm = new frmReporteProductoTerminado();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            frmReporteGeneralProductoTermnado frm = new frmReporteGeneralProductoTermnado(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            frmPlanSemanal frm = new frmPlanSemanal(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnReporteProduccionDespachos_Click(object sender, EventArgs e)
        {
            frmrptPlansemanal frm = new frmrptPlansemanal();
            if(this.MdiParent != null)
                if(!frm.IsMdiChild)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            frmCierreMensual frm = new frmCierreMensual(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            frmSeguimientoAlimentacion frm = new frmSeguimientoAlimentacion(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            frmReporteSeguimientoComprasTransito frm = new frmReporteSeguimientoComprasTransito();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            frmGestionUbicaciones frm = new frmGestionUbicaciones(this.UsuarioLogeado,1);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            frmGestionUbicaciones frm = new frmGestionUbicaciones(this.UsuarioLogeado, 2);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tabMasterData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            frmSeguimientoDespachos frm = new frmSeguimientoDespachos();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            frmReporteInventarioKardexGeneral frm = new frmReporteInventarioKardexGeneral(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            MantiniemintoCliente frm = new MantiniemintoCliente(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void tabPT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton32_Click(object sender, EventArgs e)
        {
            //xfrmPT_Reproceso frm = new xfrmPT_Reproceso(UsuarioLogeado);
            //xfrmReprocesoMenu frm = new xfrmReprocesoMenu(UsuarioLogeado);
            frmEleccionReproceso frm = new frmEleccionReproceso(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton33_Click(object sender, EventArgs e)
        {
            xfrmIngresosMP_Reproceso frm = new xfrmIngresosMP_Reproceso(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnClientesLote_Click(object sender, EventArgs e)
        {
            xfrmTrazabilidadClientesLotes frm = new xfrmTrazabilidadClientesLotes(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            //xfrmRevisionSanidad_InspeccionSeguridad frm = new xfrmRevisionSanidad_InspeccionSeguridad();

            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            //xfrmWizardRevisionanidadFirstStep frm = new xfrmWizardRevisionanidadFirstStep();

            ////if (this.MdiParent != null)
            ////    frm.MdiParent = this.MdiParent;

            ////frm.WindowState = FormWindowState.Maximized;
            //frm.Show();


            //xfrmWizardRevisionanidadFirstStep uc = new xfrmWizardRevisionanidadFirstStep();
            //uc.Dock = DockStyle.Fill;
            //this.Controls.Add(uc);

            xfrmSanidadAdmin frm = new xfrmSanidadAdmin();
            frm.ShowDialog();
        }

        private void cmdReportReqManual_Click(object sender, EventArgs e)
        {
            frmReporteRequisicionesManuales frm = new frmReporteRequisicionesManuales();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
            //frmrptMpEntregadaaProduccion
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            frmrptMpEntregadaaProduccion frm = new frmrptMpEntregadaaProduccion();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
            //
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

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
        {
            frmConfigLoteConsumoFirst frm = new frmConfigLoteConsumoFirst(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void cmdLoteActivoGranel_Click(object sender, EventArgs e)
        {
            frmLoteActivoGranelV2 frm = new frmLoteActivoGranelV2(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdReporteProximosVencer_Click(object sender, EventArgs e)
        {
            frmReporteKardexGeneralVencimiento frm = new frmReporteKardexGeneralVencimiento(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnRecuento_Click_1(object sender, EventArgs e)
        {
            Logistica.frmRecuentoInventarios frmRecuentoInventario = new Logistica.frmRecuentoInventarios(this.UsuarioLogeado);
            frmRecuentoInventario.Show();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            frmEntregaTarimaMicros frm = new frmEntregaTarimaMicros(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
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
            frmHisotrialPTCodigo frm = new frmHisotrialPTCodigo();            
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdUsuarios_Click(object sender, EventArgs e)
        {
            AccesoUsuario frm = new AccesoUsuario();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdGrupos_Click(object sender, EventArgs e)
        {
            PrincipalGestionGrupos frm = new PrincipalGestionGrupos();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdSistemas_Click(object sender, EventArgs e)
        {
            PrincipalSistemas frm = new PrincipalSistemas();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdGruposAlosy_Click(object sender, EventArgs e)
        {
            PrincipalGrupoLosa frm = new PrincipalGrupoLosa();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdAccesoSistemas_Click(object sender, EventArgs e)
        {
            NivelAccesoSistema frm = new NivelAccesoSistema();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem1_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Produccion.PP_Operator_Panel_v2 form = new Produccion.PP_Operator_Panel_v2(ActiveUserCode, ActiveUserName, "N/A", ActiveUserType, UserGroups);
            //form.ShowDialog();

            try
            {

            PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(ActiveUserCode, ActiveUserName, "N/A", ActiveUserType, UserGroups); ;
            frm.MdiParent = this.MdiParent;
            frm.Show();
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

            RPT_Trazabilidad_Lote frm = new RPT_Trazabilidad_Lote();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbPlanProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {

            Prod_Ordenes_Produccion frm = new Prod_Ordenes_Produccion(ActiveUserCode, ActiveUserName, ActiveUserType);
                frm.MdiParent = this.MdiParent;
                frm.Show();
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

            PP_Main_Products_Order MPO = new PP_Main_Products_Order(UsuarioLogeado);
            MPO.ActiveUserCodeP = ActiveUserCode;
            MPO.ActiveUserNameP = ActiveUserName;
            MPO.ActiveUserTypeP = ActiveUserType;
            MPO.MdiParent = this.MdiParent;
                MPO.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bnPortafolio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PT_Productos prod = new PT_Productos(ActiveUserCode, ActiveUserName, ActiveUserType);
            prod.MdiParent = this.MdiParent;
            prod.Show();
        }

        private void nbControlProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //comentario 
                //sincronizacion
                string a = null;
                int group = 0;
                string Query = @"SELECT 
                                      [id_group]
                                  FROM [ACS].[dbo].[conf_usuarios]
                                  where id = " + ActiveUserCode;
                DataOperations dp = new DataOperations();

                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    group = dr.GetInt32(0);
                }
                PRB_Registro pp = new PRB_Registro(ActiveUserCode, group, this.UsuarioLogeado);
                pp.UsuarioLog1 = ActiveUserName;
                pp.CodigoUss = ActiveUserCode;
                pp.MdiParent = this.MdiParent;
                pp.Show();
            }
            catch (Exception)
            {


            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(60))
                {
                    frmDatosBrom frm = new frmDatosBrom(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #60");
                }
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
            frmHorometrosLineas frm = new frmHorometrosLineas();
            frm.MdiParent = this.MdiParent;
                frm.Show();

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
                        PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(ActiveUserCode, ActiveUserName, "N/A", ActiveUserType, UserGroups);
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    case 5://Depth Without Delta
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(68))
                    {
                        //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                       PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(ActiveUserCode, ActiveUserName, "N/A", ActiveUserType, UserGroups);
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #69");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }

        private void nbReporteBatch_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //
                if (UsuarioLogeado.ValidarNivelPermisos(46))
                {
                    frmintakeKepserver frm = new frmintakeKepserver();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #46");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void nbReporteEnsacadora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //reporte ensacadora
                if (UsuarioLogeado.ValidarNivelPermisos(48))
                {
                    frmReporteEnsacadora frm = new frmReporteEnsacadora();
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                //reporte Ingenieria de procesos.
                //Sacos por lotes
                if (UsuarioLogeado.ValidarNivelPermisos(48))
                {
                    frmSacosPorLote frm = new frmSacosPorLote();
                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void nbEficienciaTurno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                frmDashBoardEficiencia frm = new frmDashBoardEficiencia(UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void nbGestionLotes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                PP_Gestion_lote frm = new PP_Gestion_lote(UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void nbReporteEficiencia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {

            //Imprimir reporte de eficiencia
            frmPrintReportEficiencia frm = new frmPrintReportEficiencia(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbEficienciaMolinos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                frmEficienciaMolinos frm = new frmEficienciaMolinos();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void nbBannerTV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {

                frmBannerMainTV_PRD frm = new frmBannerMainTV_PRD(UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
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
                        accesoprevio = true;
                        frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
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
                    if (UsuarioLogeado.ValidarNivelPermisos(68))
                    {
                        frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #68");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void nbTemperatura_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                xfrmMenuTemperatura frm = new xfrmMenuTemperatura();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }

        private void nbForeCastPRD_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
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
                        accesoprevio = true;
                        frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
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
                    if (UsuarioLogeado.ValidarNivelPermisos(71))
                    {
                        //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                        frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
                    }
                }
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
                        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
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
                    if (UsuarioLogeado.ValidarNivelPermisos(80))
                    {
                        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #80");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                IntakeBatchViewerFull frm = new IntakeBatchViewerFull();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmAlimentacionManual frm = new frmAlimentacionManual(UsuarioLogeado);
            //frm.Show();
            frmAlimentacionPanel frm = new frmAlimentacionPanel();
            frm.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPrintTM frm = new frmPrintTM(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmactivacionPT frm = new frmactivacionPT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfrmCheckActiveBin frm = new xfrmCheckActiveBin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfrmIngresosMP_Reproceso frm = new xfrmIngresosMP_Reproceso(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
