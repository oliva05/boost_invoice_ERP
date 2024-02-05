
namespace JAGUAR_APP.Requisiciones
{
    partial class frmSeleccionLoteMP_requisicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionLoteMP_requisicion));
            this.lblCantidadEntregada = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblCantidadSolicitada = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblMateriaPrima = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTituloSeleccionDeLote = new DevExpress.XtraEditors.LabelControl();
            this.lblNumRequisicion = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dSReportes1 = new JAGUAR_APP.Requisiciones.dSReportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_seleccionada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCantidadPendiente = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoSeleccion = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardarEntregar = new DevExpress.XtraEditors.SimpleButton();
            this.lblErrorShow = new System.Windows.Forms.Label();
            this.timerClearErrorSet = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoSeleccion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadEntregada
            // 
            this.lblCantidadEntregada.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEntregada.Appearance.Options.UseFont = true;
            this.lblCantidadEntregada.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCantidadEntregada.Location = new System.Drawing.Point(149, 95);
            this.lblCantidadEntregada.Name = "lblCantidadEntregada";
            this.lblCantidadEntregada.Size = new System.Drawing.Size(201, 20);
            this.lblCantidadEntregada.TabIndex = 58;
            this.lblCantidadEntregada.Text = "N/D";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 95);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(157, 20);
            this.labelControl5.TabIndex = 57;
            this.labelControl5.Text = "Cantidad Entregada____";
            // 
            // lblCantidadSolicitada
            // 
            this.lblCantidadSolicitada.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadSolicitada.Appearance.Options.UseFont = true;
            this.lblCantidadSolicitada.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCantidadSolicitada.Location = new System.Drawing.Point(149, 67);
            this.lblCantidadSolicitada.Name = "lblCantidadSolicitada";
            this.lblCantidadSolicitada.Size = new System.Drawing.Size(201, 20);
            this.lblCantidadSolicitada.TabIndex = 56;
            this.lblCantidadSolicitada.Text = "N/D";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(167, 20);
            this.labelControl4.TabIndex = 55;
            this.labelControl4.Text = "Cantidad Solicitada______";
            // 
            // lblMateriaPrima
            // 
            this.lblMateriaPrima.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaPrima.Appearance.Options.UseFont = true;
            this.lblMateriaPrima.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMateriaPrima.Location = new System.Drawing.Point(149, 41);
            this.lblMateriaPrima.Name = "lblMateriaPrima";
            this.lblMateriaPrima.Size = new System.Drawing.Size(494, 20);
            this.lblMateriaPrima.TabIndex = 54;
            this.lblMateriaPrima.Text = "N/D";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(148, 20);
            this.labelControl2.TabIndex = 53;
            this.labelControl2.Text = "Materia Prima_________";
            // 
            // lblTituloSeleccionDeLote
            // 
            this.lblTituloSeleccionDeLote.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloSeleccionDeLote.Appearance.Options.UseFont = true;
            this.lblTituloSeleccionDeLote.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloSeleccionDeLote.Location = new System.Drawing.Point(4, 21);
            this.lblTituloSeleccionDeLote.Name = "lblTituloSeleccionDeLote";
            this.lblTituloSeleccionDeLote.Size = new System.Drawing.Size(271, 29);
            this.lblTituloSeleccionDeLote.TabIndex = 59;
            this.lblTituloSeleccionDeLote.Text = "Entrega de Materiales";
            // 
            // lblNumRequisicion
            // 
            this.lblNumRequisicion.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRequisicion.Appearance.Options.UseFont = true;
            this.lblNumRequisicion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNumRequisicion.Location = new System.Drawing.Point(149, 15);
            this.lblNumRequisicion.Name = "lblNumRequisicion";
            this.lblNumRequisicion.Size = new System.Drawing.Size(494, 20);
            this.lblNumRequisicion.TabIndex = 61;
            this.lblNumRequisicion.Text = "N/D";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(9, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(168, 20);
            this.labelControl6.TabIndex = 60;
            this.labelControl6.Text = "Requisición #_____________";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "seleccion_lote_mp";
            this.gridControl1.DataSource = this.dSReportes1;
            this.gridControl1.Location = new System.Drawing.Point(4, 243);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(663, 256);
            this.gridControl1.TabIndex = 62;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dSReportes1
            // 
            this.dSReportes1.DataSetName = "dSReportes";
            this.dSReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote,
            this.colcantidad,
            this.colid_presentacion,
            this.colpresentacion_name,
            this.colcantidad_seleccionada,
            this.colnum_linea,
            this.colcosto});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.ReadOnly = true;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            this.collote.Width = 210;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cant. Inventario";
            this.colcantidad.DisplayFormat.FormatString = "n4";
            this.colcantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.ReadOnly = true;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            this.colcantidad.Width = 89;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.OptionsColumn.ReadOnly = true;
            // 
            // colpresentacion_name
            // 
            this.colpresentacion_name.Caption = "Presentación";
            this.colpresentacion_name.FieldName = "presentacion_name";
            this.colpresentacion_name.Name = "colpresentacion_name";
            this.colpresentacion_name.OptionsColumn.ReadOnly = true;
            this.colpresentacion_name.Visible = true;
            this.colpresentacion_name.VisibleIndex = 4;
            this.colpresentacion_name.Width = 110;
            // 
            // colcantidad_seleccionada
            // 
            this.colcantidad_seleccionada.Caption = "Cant. Seleccionada";
            this.colcantidad_seleccionada.DisplayFormat.FormatString = "n4";
            this.colcantidad_seleccionada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_seleccionada.FieldName = "cantidad_seleccionada";
            this.colcantidad_seleccionada.Name = "colcantidad_seleccionada";
            this.colcantidad_seleccionada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad_seleccionada", "SUMA={0:n4}")});
            this.colcantidad_seleccionada.Visible = true;
            this.colcantidad_seleccionada.VisibleIndex = 5;
            this.colcantidad_seleccionada.Width = 115;
            // 
            // colnum_linea
            // 
            this.colnum_linea.Caption = "Linea";
            this.colnum_linea.FieldName = "num_linea";
            this.colnum_linea.Name = "colnum_linea";
            this.colnum_linea.OptionsColumn.ReadOnly = true;
            this.colnum_linea.Visible = true;
            this.colnum_linea.VisibleIndex = 0;
            this.colnum_linea.Width = 36;
            // 
            // colcosto
            // 
            this.colcosto.Caption = "Costo Unitario Lempiras";
            this.colcosto.DisplayFormat.FormatString = "n4";
            this.colcosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcosto.FieldName = "costo";
            this.colcosto.Name = "colcosto";
            this.colcosto.Visible = true;
            this.colcosto.VisibleIndex = 3;
            this.colcosto.Width = 85;
            // 
            // lblCantidadPendiente
            // 
            this.lblCantidadPendiente.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPendiente.Appearance.Options.UseFont = true;
            this.lblCantidadPendiente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCantidadPendiente.Location = new System.Drawing.Point(149, 121);
            this.lblCantidadPendiente.Name = "lblCantidadPendiente";
            this.lblCantidadPendiente.Size = new System.Drawing.Size(201, 20);
            this.lblCantidadPendiente.TabIndex = 64;
            this.lblCantidadPendiente.Text = "N/D";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(9, 121);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(149, 20);
            this.labelControl7.TabIndex = 63;
            this.labelControl7.Text = "Cantidad Pendiente___";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(4, 223);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 20);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "Detalle de Lotes";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkAutoSeleccion);
            this.groupBox1.Controls.Add(this.lblCantidadPendiente);
            this.groupBox1.Controls.Add(this.lblCantidadEntregada);
            this.groupBox1.Controls.Add(this.lblCantidadSolicitada);
            this.groupBox1.Controls.Add(this.lblMateriaPrima);
            this.groupBox1.Controls.Add(this.lblNumRequisicion);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Location = new System.Drawing.Point(4, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 148);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // chkAutoSeleccion
            // 
            this.chkAutoSeleccion.Location = new System.Drawing.Point(530, 124);
            this.chkAutoSeleccion.Name = "chkAutoSeleccion";
            this.chkAutoSeleccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chkAutoSeleccion.Properties.Appearance.Options.UseFont = true;
            this.chkAutoSeleccion.Properties.Caption = "Auto Selección";
            this.chkAutoSeleccion.Size = new System.Drawing.Size(127, 24);
            this.chkAutoSeleccion.TabIndex = 65;
            this.chkAutoSeleccion.CheckedChanged += new System.EventHandler(this.chkAutoSeleccion_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(561, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 41);
            this.simpleButton1.TabIndex = 65;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdGuardarEntregar
            // 
            this.cmdGuardarEntregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardarEntregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdGuardarEntregar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdGuardarEntregar.Appearance.Options.UseBackColor = true;
            this.cmdGuardarEntregar.Appearance.Options.UseFont = true;
            this.cmdGuardarEntregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardarEntregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardarEntregar.ImageOptions.Image")));
            this.cmdGuardarEntregar.Location = new System.Drawing.Point(449, 17);
            this.cmdGuardarEntregar.Name = "cmdGuardarEntregar";
            this.cmdGuardarEntregar.Size = new System.Drawing.Size(106, 41);
            this.cmdGuardarEntregar.TabIndex = 67;
            this.cmdGuardarEntregar.Text = "Entregar \r\nMateriales";
            this.cmdGuardarEntregar.Click += new System.EventHandler(this.cmdGuardarEntregar_Click);
            // 
            // lblErrorShow
            // 
            this.lblErrorShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorShow.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblErrorShow.Location = new System.Drawing.Point(4, 502);
            this.lblErrorShow.Name = "lblErrorShow";
            this.lblErrorShow.Size = new System.Drawing.Size(663, 27);
            this.lblErrorShow.TabIndex = 68;
            // 
            // timerClearErrorSet
            // 
            this.timerClearErrorSet.Interval = 5000;
            this.timerClearErrorSet.Tick += new System.EventHandler(this.timerClearErrorSet_Tick);
            // 
            // frmSeleccionLoteMP_requisicion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 531);
            this.Controls.Add(this.lblErrorShow);
            this.Controls.Add(this.cmdGuardarEntregar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblTituloSeleccionDeLote);
            this.Name = "frmSeleccionLoteMP_requisicion";
            this.ShowIcon = false;
            this.Text = "Entrega de Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoSeleccion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCantidadEntregada;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblCantidadSolicitada;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblMateriaPrima;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblTituloSeleccionDeLote;
        private DevExpress.XtraEditors.LabelControl lblNumRequisicion;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblCantidadPendiente;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private dSReportes dSReportes1;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_seleccionada;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_linea;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit chkAutoSeleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarEntregar;
        private System.Windows.Forms.Label lblErrorShow;
        private System.Windows.Forms.Timer timerClearErrorSet;
    }
}