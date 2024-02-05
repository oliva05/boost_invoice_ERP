using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Requisiciones;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmRequisicionesDetalle : Form
    {
        UserLogin UsuarioLogeado;
        int IdRequisicionHeader;
        DataOperations dp;
        int IdEstado;
        decimal Cant_arroabas;
        int DocEntry;


        public frmRequisicionesDetalle(UserLogin pUsuarioLogeado, int pIdReqH, int pLote, int pIdEstado, string pAsignadoA, string pProductoName, decimal pCantArrobas, int pDocEntry)
        {
            InitializeComponent();
            Cant_arroabas = pCantArrobas;
            lblCantidadArrobas.Text = string.Format("{0:###,##0}", Cant_arroabas);
            lblProductoTerminadoName.Text = pProductoName;
            txtAsignadoA.Text = pAsignadoA;
            DocEntry = pDocEntry;
            Requisicion requisicion1 = new Requisicion();
            if (requisicion1.RecuperarRegistroFromId_H(pIdReqH))
            {
                LblNumOrdenFabricacion.Text = requisicion1.DocNum_OrdenFabricacion;
            }

            //LotePT = pLote;
            IdEstado = pIdEstado;
            //lblProductoTerminadoName.Text = pIdReqH.ToString();
            //txtAsignadoA.Text = pLote.ToString();
            UsuarioLogeado = pUsuarioLogeado;
            IdRequisicionHeader = pIdReqH;

            string req_num = DocEntry.ToString();
            while (req_num.Length < 5)
            {
                req_num = "0" + req_num;
            }
            req_num = "REQ" + req_num;
            LblNumRequisicion.Text = req_num;

            dp = new DataOperations();
            LoadDatos();


            ValidarPermisosReqDetalle();
        }

        private void ValidarPermisosReqDetalle()
        {
            bool CargaPrevia = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    LoadAllEstadosReq();
                    CargaPrevia = true;
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!CargaPrevia)
            {
                ValidarPermisosFromId_permiso();
            }

           

        }

        private void ValidarPermisosFromId_permiso()
        {
            if (UsuarioLogeado.ValidarNivelPermisos(85))//Permiso limitado
            {
                if(IdEstado == 5) 
                    LoadPermisos(85);//Cargamos los permisos de habilitar requisicion
                //else
                //    gridLookUpEdit_estados.Visible = lblEtiquetaEstadosReq.Visible = false;
            }

            //if (dsTransaccionesMP1.estados_requisicion_list.Count == 0)//Verificamos si es un jefe
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(86))
            //    {
            //        LoadPermisos(86);//Cargamos los permisos del jefe
            //    }
            //}

            //if (dsTransaccionesMP1.estados_requisicion_list.Count == 0)
            //{
            //    gridLookUpEdit_estados.Visible = lblEtiquetaEstadosReq.Visible = false;//Significa que no tiene ningun privilegio para cambiar estado
            //}
        }

        private void LoadPermisos(int pIPermiso)
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("sp_get_all_estados_req_by_permiso", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_permiso", pIPermiso);
            //    dsTransaccionesMP1.estados_requisicion_list.Clear();
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    adat.Fill(dsTransaccionesMP1.estados_requisicion_list);

            //    if(dsTransaccionesMP1.estados_requisicion_list.Count>0)
            //        gridLookUpEdit_estados.Visible = lblEtiquetaEstadosReq.Visible = true;

            //    con.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void LoadAllEstadosReq()
        { }

        private void LoadDatos()
        {
            try
            {

                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_requisicion_detalle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req_header", IdRequisicionHeader);
                dSReportes.requisicion_d    .Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dSReportes.requisicion_d);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnVerD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton editar
            //var gridView = (GridView)grDetalleLote.FocusedView;
            //var row = (dsTransaccionesMP.requisiciones_dRow)gridView.GetFocusedDataRow();

            //if (row.entregada == 0)
            //{
            //    CajaDialogo.Error("No se a entregado Materia Prima");
            //    return;
            //}

            //if (row.asignado == 0)
            //{
            //    frmSeleccionLote frm = new frmSeleccionLote(UsuarioLogeado,
            //                                               row.id,
            //                                               row.id_materia_prima,
            //                                               row.solicitada,
            //                                               row.id_unidad_medida,
            //                                               row.unidad
            //                                               , row.pendiente);
            //    //frm.WindowState = FormWindowState.Maximized;
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        LoadDatos();
            //    }
            //}
            //else
            //{

               
            //        frmSeleccionLote frm = new frmSeleccionLote(UsuarioLogeado,
            //                                                    row.id,
            //                                                    row.id_materia_prima,
            //                                                    row.solicitada,
            //                                                    row.id_unidad_medida,
            //                                                    row.unidad
            //                                                    ,row.pendiente);
            //        //frm.WindowState = FormWindowState.Maximized;
            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {
            //            LoadDatos();
            //        }

               
            //}
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gvTarimas_RowStyle(object sender, RowStyleEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //{
            //    var gridView = (GridView)grDetalleLote.FocusedView;
            //    //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
            //    var row = (dsTransaccionesMP.requisiciones_dRow)gridView.GetDataRow(e.RowHandle);
            //    if (row != null)
            //    {
            //        if (row.solicitada == row.asignado)
            //        {
            //            e.Appearance.BackColor = Color.FromArgb(113, 220, 200);
            //        }
            //        else
            //        {
            //            if (row.asignado > 0)
            //            {
            //                //
            //                e.Appearance.BackColor = Color.FromArgb(255, 255, 192);
            //            }
            //            else
            //            {
            //                e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
            //            }
            //        }
            //    }
            //}
        }

        private void chkAutoSelect_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAutoSelect.Checked)
            //{
            //    //SeleccionLoteMPAuto
            //    foreach(dsTransaccionesMP.requisiciones_dRow row in dsTransaccionesMP1.requisiciones_d.Rows)
            //    {
            //        SeleccionLoteMPAuto sele = new SeleccionLoteMPAuto(row.id_materia_prima,
            //                                                            row.id,
            //                                                            row.solicitada,
            //                                                            this.UsuarioLogeado.Id);
            //        if(sele.Guardar_SeleccionLoteAuto())
            //        {
            //            //LoadDatos();
            //        }
            //    }
                
            //    LoadDatos();
            //    CajaDialogo.Information("Autoseleccion finalizada con Exito!");
            //}
            //else
            //{

            //}
        }

        private void btnconsumir_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    var gridView = (GridView)grDetalleLote.FocusedView;
            //    var row = (dsTransaccionesMP.requisiciones_dRow)gridView.GetFocusedDataRow();
            //    if (row.asignado != 0)
            //    {
            //        if (row.asignado != row.entregada)
            //        {
            //            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            //            cn.Open();
            //            string query = @"sp_entregar_in_bodega";
            //            SqlCommand cmd = new SqlCommand(query,cn);
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            cmd.Parameters.AddWithValue("@id_detalle_req", row.id);
            //            cmd.Parameters.AddWithValue("@cantidaP", row.pendiente);
            //            cmd.ExecuteNonQuery();
            //            CajaDialogo.Information("Lotes en produccion consumidos.");
            //            LoadDatos();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("Ya se ha entregado toda la materia prima para esta Materia prima.");
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("Debe de asignar lotes para verificar si se puede consumir de la bodega de produccion.");
            //        return;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void cmdEntregar__ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Entregar MP
            var gridView = (GridView)grDetalleLote.FocusedView;
            var row = (dSReportes.requisicion_dRow)gridView.GetFocusedDataRow();

            frmSeleccionLoteMP_requisicion frm = new frmSeleccionLoteMP_requisicion(row.id_materia_prima, row.code + " - " + row.mp, row.solicitada,
                                                                                    row.presentacion, row.entregada, row.presentacion,
                                                                                    this.UsuarioLogeado, this.IdRequisicionHeader, row.code, row.id//id req detalle
                                                                                    ,DocEntry);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadDatos();
            }
        }
    }
}
