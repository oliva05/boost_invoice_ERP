using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

namespace JAGUAR_APP.Requisiciones
{
    public partial class frmSeleccionLoteMP_requisicion : DevExpress.XtraEditors.XtraForm
    {
        decimal CantidadSolicitada;
        decimal CantidadEntregada;
        int IdMP;
        UserLogin UsuarioLogeado;
        int IdRequisicionH;
        bool set_error = false;
        int LineError = 0;
        string ItemCode;
        int IdRequisicionDetalle;
        //bool SetErrorLabel = false;
        string MensajeErrorSet = "";
        int DocEntry;

        public frmSeleccionLoteMP_requisicion(int pid_mp, string pMateriaPrimaName, decimal pCantidadSolicitada, string UM_CantSolicitada
                                             ,decimal pCantidadEntregada, string UM_CantEntregada, UserLogin pUserLogeado, int pidRequicionH, 
                                              string pItemCode, int pIdRequisicionDetalle, int pDocEntry)
        {
            InitializeComponent();
            DocEntry = pDocEntry;
            //string NumRequisa = pidRequicionH.ToString();
            //while (NumRequisa.Length < 4)
            //{
            //    NumRequisa = "0" + NumRequisa;
            //}
            //NumRequisa = "RQ" + NumRequisa;
            //lblTituloSeleccionDeLote.Text = "Entrega de Materiales Req: " + NumRequisa;
            IdMP = pid_mp;
            ItemCode = pItemCode;
            IdRequisicionH = pidRequicionH;
            IdRequisicionDetalle = pIdRequisicionDetalle;
            UsuarioLogeado = pUserLogeado;
            CantidadSolicitada = pCantidadSolicitada;
            CantidadEntregada = pCantidadEntregada;
            lblMateriaPrima.Text = pMateriaPrimaName;
            lblCantidadSolicitada.Text = string.Format("{0:###,##0.0000}", pCantidadSolicitada) + " " + UM_CantSolicitada;
            lblCantidadEntregada.Text = string.Format("{0:###,##0.0000}", pCantidadEntregada) + " " + UM_CantEntregada;
            string req_num = DocEntry.ToString();
            while (req_num.Length < 5)
            {
                req_num = "0" + req_num;
            }
            req_num = "REQ" + req_num;
            lblNumRequisicion.Text = req_num;
            lblCantidadPendiente.Text = string.Format("{0:###,##0.0000}", pCantidadSolicitada - pCantidadEntregada) + " " + UM_CantEntregada;
            LoadLotes();

            gridView1.OptionsMenu.EnableColumnMenu = false;
            gridView1.Columns["costo"].Visible = false;

            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 11);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    gridView1.OptionsMenu.EnableColumnMenu = true;
                    gridView1.Columns["costo"].Visible = true;
                    break;
                default:
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(7))
                {
                    gridView1.OptionsMenu.EnableColumnMenu = true;
                    gridView1.Columns["costo"].Visible = true;
                }
                else
                {
                    //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #2 (Recepción de Facturas)");
                }
            }

            chkAutoSeleccion.Checked = true;    
            
        }






        private void LoadLotes()
        {
            string query = @"[codesahn].sp_get_inv_disponible_by_lote_entrega_mercancias";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp",  IdMP);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSReportes1.seleccion_lote_mp.Clear();
                da.Fill(dSReportes1.seleccion_lote_mp);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            set_error = false;
            string cell_field_name = e.Column.FieldName;
            switch (cell_field_name)
            {
                case "cantidad_seleccionada":
                    decimal cant_pendiente = CantidadSolicitada - CantidadEntregada;
                    DataOperations dp = new DataOperations();
                    decimal val_celda = dp.ValidateNumberDecimal( e.Value);

                   

                    if(val_celda> cant_pendiente)//Si ingreso una cantidad mayor a la cantidad pendiente
                    {
                        set_error = true;
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row_edited1 = (dSReportes.seleccion_lote_mpRow)gridView.GetDataRow(e.RowHandle);
                        MensajeErrorSet = "La cantidad ingresada hace que supere la cantidad requerida!";
                        LineError = e.RowHandle;
                    }

                    //validamos si la cantidad en acumulado excede la cantidad pendiente
                    if (!set_error)
                    {
                        decimal total_acumulado = 0;
                        foreach (dSReportes.seleccion_lote_mpRow row in dSReportes1.seleccion_lote_mp)
                        {
                            decimal cant_seleccionada_local = 0;
                            try
                            {
                                cant_seleccionada_local = dp.ValidateNumberDecimal(row.cantidad_seleccionada);
                            }
                            catch
                            {
                                cant_seleccionada_local = 0;
                            }

                            total_acumulado += cant_seleccionada_local;
                        }

                        if (total_acumulado > cant_pendiente)
                        {
                            set_error = true;
                            MensajeErrorSet = "La cantidad ingresada hace que supere la cantidad requerida!";
                            LineError = e.RowHandle;
                        }
                    }

                    //Validar que se utiliza el primer lote de la lista primero
                    
                    if(e.RowHandle > 0)//Al menos debemos estar en la segunda fila para validar esta opcion
                    {
                        //Validamos las filas previas hasta la actual
                        for(int i = 0; i < e.RowHandle; i++)
                        {
                            var gridView = (GridView)gridControl1.FocusedView;
                            var row_validate = (dSReportes.seleccion_lote_mpRow)gridView.GetDataRow(i);
                            if((row_validate.cantidad - row_validate.cantidad_seleccionada) > 0)
                            {
                                set_error = true;
                                LineError = i;
                                MensajeErrorSet = "Es necesario entregar los primeros lotes que ingresaron al almacen o bodega!";
                                //lblErrorShow.BackColor = Color.LightCoral;
                                //SetErrorLabel = true;
                                timerClearErrorSet.Enabled = true;
                                timerClearErrorSet.Start();
                                break;
                            }
                        }
                    }
                    else //Vamos a validar todas las lineas
                    {
                        //Validamos si el primer row satisafe la cantidad pendiente
                        if (dSReportes1.seleccion_lote_mp.Count > 1)
                        {
                            var gridView = (GridView)gridControl1.FocusedView;
                            var primer_row = (dSReportes.seleccion_lote_mpRow)gridView.GetDataRow(0);
                            if ((cant_pendiente - primer_row.cantidad_seleccionada) > 0)
                            {
                                //Significa que el primer row no cumple con cantidad pendiente
                                //Vamos a revisar las siguientes filas
                                for (int i = 1; i <= (dSReportes1.seleccion_lote_mp.Count - 1); i++)
                                {
                                    //var gridView = (GridView)gridControl1.FocusedView;
                                    var row_validate = (dSReportes.seleccion_lote_mpRow)gridView.GetDataRow(i);
                                    if ((row_validate.cantidad_seleccionada) > 0)
                                    {
                                        set_error = true;
                                        LineError = i;
                                        MensajeErrorSet = "Es necesario entregar los primeros lotes que ingresaron al almacen o bodega!";
                                        //lblErrorShow.BackColor = Color.LightCoral;
                                        //SetErrorLabel = true;
                                        timerClearErrorSet.Enabled = true;
                                        timerClearErrorSet.Start();
                                        break;
                                    }
                                }
                            }
                        }
                        //Sino no validamos nada
                    }

                    if (!set_error)
                        LineError = 0;



                   
                    break;
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "cantidad_seleccionada")
            {
                GridCellInfo cellInfo = e.Cell as GridCellInfo;
                if (cellInfo != null)
                {
                    if (LineError == 0)
                    {
                        if (set_error)
                        {
                            cellInfo.ViewInfo.ErrorIconText = MensajeErrorSet;// "La cantidad ingresada hace que supere la cantidad requerida!";
                            //cellInfo.ViewInfo.SetDisplayText("La cantidad ingresada hace que supere la cantidad requerida!");
                            cellInfo.ViewInfo.AllowTextToolTip = true;
                            cellInfo.State = DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused;
                            cellInfo.ViewInfo.ShowErrorIcon = true;
                            lblErrorShow.Text = MensajeErrorSet;/*"La cantidad ingresada hace que supere la cantidad requerida!";*/
                            lblErrorShow.BackColor = Color.LightCoral;
                            //SetErrorLabel = true;
                            timerClearErrorSet.Enabled = true;
                            timerClearErrorSet.Start();
                        }
                        else
                        {
                            cellInfo.ViewInfo.AllowTextToolTip = false;
                        }
                    }
                    else
                    {
                        if (set_error && e.RowHandle == LineError)
                        {
                            cellInfo.ViewInfo.ErrorIconText = MensajeErrorSet;// "La cantidad ingresada hace que supere la cantidad requerida!";
                            //cellInfo.ViewInfo.SetDisplayText("La cantidad ingresada hace que supere la cantidad requerida!");
                            cellInfo.State = DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused;
                            cellInfo.ViewInfo.AllowTextToolTip = true;
                            cellInfo.ViewInfo.ShowErrorIcon = true;
                            lblErrorShow.Text = MensajeErrorSet; //"La cantidad ingresada hace que supere la cantidad requerida!";
                            lblErrorShow.BackColor = Color.LightCoral;
                            //SetErrorLabel = true;
                            timerClearErrorSet.Enabled = true;
                            timerClearErrorSet.Start();
                        }
                        else
                        {
                            cellInfo.ViewInfo.AllowTextToolTip = false;
                        }
                    }
                }
            }
        }

        private void chkAutoSeleccion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSeleccion.Checked)
            {
                decimal cantidad_pend_asignar = CantidadSolicitada - CantidadEntregada;
                //int id_fila = 0;
                foreach (dSReportes.seleccion_lote_mpRow row in dSReportes1.seleccion_lote_mp.Rows)
                {
                    row.cantidad_seleccionada = 0;
                }

                foreach (dSReportes.seleccion_lote_mpRow row in dSReportes1.seleccion_lote_mp.Rows)
                {    
                    if (row.cantidad > cantidad_pend_asignar)
                    {
                        row.cantidad_seleccionada = cantidad_pend_asignar;
                        cantidad_pend_asignar = 0;
                        break;
                    }
                    else
                    {
                        row.cantidad_seleccionada = row.cantidad;
                        cantidad_pend_asignar -= row.cantidad;
                    }

                    if (cantidad_pend_asignar == 0)
                        break;
                }
            }
            else
            {
                foreach (dSReportes.seleccion_lote_mpRow row in dSReportes1.seleccion_lote_mp.Rows)
                {
                    row.cantidad_seleccionada = 0;
                }
            }
        }//End chkAutoSeleccion

        private void cmdGuardarEntregar_Click(object sender, EventArgs e)
        {
            decimal cant__selected = 0;
            foreach (dSReportes.seleccion_lote_mpRow row in dSReportes1.seleccion_lote_mp.Rows)
            {
                decimal val = 0;
                try 
                {
                    val = row.cantidad_seleccionada;
                } catch { val = 0; }
                cant__selected += val;
            }

            if(cant__selected == 0)
            {
                CajaDialogo.Error("Es necesario especificar los lotes que se van a entregar para poder aplicar los cambios!");
                return;
            }

            if (cant__selected > (CantidadSolicitada - CantidadEntregada))
            {
                CajaDialogo.Error("No puede exceder de la cantidad pendiente de entregar!");
                return;
            }

            

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de entregar esta materia Prima?");
            if (r != DialogResult.Yes)
                return;

            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    foreach (dSReportes.seleccion_lote_mpRow row in dSReportes1.seleccion_lote_mp)
                    {
                        if (row.cantidad_seleccionada > 0)
                        {
                            //Insert Header
                            command.CommandText = "[codesahn].sp_insert_detalle_entrega_lote";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id_detalle_requisicion", IdRequisicionDetalle);
                            command.Parameters.AddWithValue("@lote_mp", row.lote);
                            command.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);
                            command.Parameters.AddWithValue("@cantidad_entregado", row.cantidad_seleccionada);
                            command.Parameters.AddWithValue("@id_mp", IdMP);
                            command.Parameters.AddWithValue("@costo", row.cantidad_seleccionada * row.costo);
                            command.Parameters.AddWithValue("@itemcode", ItemCode);
                            command.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    CajaDialogo.InformationAuto();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        CajaDialogo.Error(ex2.Message);
                    }
                }
            }

        }

        private void timerClearErrorSet_Tick(object sender, EventArgs e)
        {
            timerClearErrorSet.Enabled = false;
            timerClearErrorSet.Stop();
            lblErrorShow.BackColor = Color.White;
            lblErrorShow.Text = "";
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }
    }
}