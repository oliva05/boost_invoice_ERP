
namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    partial class frmCotizacionesHome
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizacionesHome));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdCotizaciones = new DevExpress.XtraGrid.GridControl();
            this.dsFactCotizacion1 = new JAGUAR_APP.Facturacion.Cotizaciones.dsFactCotizacion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_emision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnExcelAuto = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRefreshDisponibles = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaHastaDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesdeDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactCotizacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCotizaciones
            // 
            this.grdCotizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCotizaciones.DataMember = "ListaCotizaciones";
            this.grdCotizaciones.DataSource = this.dsFactCotizacion1;
            this.grdCotizaciones.Location = new System.Drawing.Point(3, 83);
            this.grdCotizaciones.MainView = this.gridView1;
            this.grdCotizaciones.Name = "grdCotizaciones";
            this.grdCotizaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposEditar,
            this.reposEliminar,
            this.reposPrint});
            this.grdCotizaciones.Size = new System.Drawing.Size(1332, 669);
            this.grdCotizaciones.TabIndex = 0;
            this.grdCotizaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsFactCotizacion1
            // 
            this.dsFactCotizacion1.DataSetName = "dsFactCotizacion";
            this.dsFactCotizacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcliente,
            this.colrtn,
            this.colcontacto,
            this.coltelefono,
            this.colfecha_emision,
            this.colfecha_vencimiento,
            this.coluser_creador,
            this.colestado,
            this.coltotal,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.grdCotizaciones;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.Caption = "id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 53;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.AllowEdit = false;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 1;
            this.colcliente.Width = 98;
            // 
            // colrtn
            // 
            this.colrtn.Caption = "RTN";
            this.colrtn.FieldName = "rtn";
            this.colrtn.Name = "colrtn";
            this.colrtn.OptionsColumn.AllowEdit = false;
            this.colrtn.Visible = true;
            this.colrtn.VisibleIndex = 2;
            this.colrtn.Width = 98;
            // 
            // colcontacto
            // 
            this.colcontacto.Caption = "Contacto";
            this.colcontacto.FieldName = "contacto";
            this.colcontacto.Name = "colcontacto";
            this.colcontacto.OptionsColumn.AllowEdit = false;
            this.colcontacto.Visible = true;
            this.colcontacto.VisibleIndex = 3;
            this.colcontacto.Width = 98;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.AllowEdit = false;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 4;
            this.coltelefono.Width = 98;
            // 
            // colfecha_emision
            // 
            this.colfecha_emision.Caption = "Fecha";
            this.colfecha_emision.FieldName = "fecha_emision";
            this.colfecha_emision.Name = "colfecha_emision";
            this.colfecha_emision.OptionsColumn.AllowEdit = false;
            this.colfecha_emision.Visible = true;
            this.colfecha_emision.VisibleIndex = 5;
            this.colfecha_emision.Width = 98;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "F. Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 6;
            this.colfecha_vencimiento.Width = 98;
            // 
            // coluser_creador
            // 
            this.coluser_creador.Caption = "Usuario";
            this.coluser_creador.FieldName = "user_creador";
            this.coluser_creador.Name = "coluser_creador";
            this.coluser_creador.OptionsColumn.AllowEdit = false;
            this.coluser_creador.Visible = true;
            this.coluser_creador.VisibleIndex = 7;
            this.coluser_creador.Width = 98;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 8;
            this.colestado.Width = 98;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Monto Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 9;
            this.coltotal.Width = 98;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.reposEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 98;
            // 
            // reposEditar
            // 
            this.reposEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEditar.Name = "reposEditar";
            this.reposEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposEditar_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Eliminar";
            this.gridColumn2.ColumnEdit = this.reposEliminar;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 11;
            this.gridColumn2.Width = 98;
            // 
            // reposEliminar
            // 
            this.reposEliminar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.reposEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEliminar.Name = "reposEliminar";
            this.reposEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposEliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposEliminar_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Imprimir";
            this.gridColumn3.ColumnEdit = this.reposPrint;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 12;
            this.gridColumn3.Width = 142;
            // 
            // reposPrint
            // 
            this.reposPrint.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.reposPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposPrint.Name = "reposPrint";
            this.reposPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposPrint_ButtonClick);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "# Cotizacion";
            this.gridColumn4.FieldName = "num_cotizacion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 87;
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.ImageOptions.Image")));
            this.cmdNew.Location = new System.Drawing.Point(40, 39);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(106, 39);
            this.cmdNew.TabIndex = 15;
            this.cmdNew.Text = "&Nuevo";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(1192, 41);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(106, 39);
            this.cmdSalir.TabIndex = 16;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(289, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(767, 23);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Cotizaciones";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcelAuto
            // 
            this.btnExcelAuto.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExcelAuto.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExcelAuto.Appearance.Options.UseBackColor = true;
            this.btnExcelAuto.Appearance.Options.UseFont = true;
            this.btnExcelAuto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAuto.ImageOptions.Image")));
            this.btnExcelAuto.Location = new System.Drawing.Point(896, 41);
            this.btnExcelAuto.Name = "btnExcelAuto";
            this.btnExcelAuto.Size = new System.Drawing.Size(106, 39);
            this.btnExcelAuto.TabIndex = 112;
            this.btnExcelAuto.Text = "Excel";
            this.btnExcelAuto.Visible = false;
            // 
            // cmdRefreshDisponibles
            // 
            this.cmdRefreshDisponibles.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.cmdRefreshDisponibles.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdRefreshDisponibles.Appearance.Options.UseBackColor = true;
            this.cmdRefreshDisponibles.Appearance.Options.UseFont = true;
            this.cmdRefreshDisponibles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefreshDisponibles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefreshDisponibles.ImageOptions.Image")));
            this.cmdRefreshDisponibles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefreshDisponibles.Location = new System.Drawing.Point(772, 41);
            this.cmdRefreshDisponibles.Name = "cmdRefreshDisponibles";
            this.cmdRefreshDisponibles.Size = new System.Drawing.Size(106, 39);
            this.cmdRefreshDisponibles.TabIndex = 111;
            this.cmdRefreshDisponibles.Text = "Refresh";
            this.cmdRefreshDisponibles.Click += new System.EventHandler(this.cmdRefreshDisponibles_Click);
            // 
            // dtFechaHastaDisponibles
            // 
            this.dtFechaHastaDisponibles.EditValue = null;
            this.dtFechaHastaDisponibles.Location = new System.Drawing.Point(612, 50);
            this.dtFechaHastaDisponibles.Name = "dtFechaHastaDisponibles";
            this.dtFechaHastaDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaHastaDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHastaDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaHastaDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaHastaDisponibles.Size = new System.Drawing.Size(142, 22);
            this.dtFechaHastaDisponibles.TabIndex = 109;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(526, 54);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 16);
            this.labelControl9.TabIndex = 110;
            this.labelControl9.Text = "Fecha Hasta:";
            // 
            // dtFechaDesdeDisponibles
            // 
            this.dtFechaDesdeDisponibles.EditValue = null;
            this.dtFechaDesdeDisponibles.Location = new System.Drawing.Point(365, 50);
            this.dtFechaDesdeDisponibles.Name = "dtFechaDesdeDisponibles";
            this.dtFechaDesdeDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaDesdeDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesdeDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaDesdeDisponibles.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesdeDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaDesdeDisponibles.Size = new System.Drawing.Size(142, 22);
            this.dtFechaDesdeDisponibles.TabIndex = 107;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(274, 53);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(85, 16);
            this.labelControl8.TabIndex = 108;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // frmCotizacionesHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 756);
            this.Controls.Add(this.btnExcelAuto);
            this.Controls.Add(this.cmdRefreshDisponibles);
            this.Controls.Add(this.dtFechaHastaDisponibles);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaDesdeDisponibles);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.grdCotizaciones);
            this.Name = "frmCotizacionesHome";
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactCotizacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCotizaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposPrint;
        private System.Windows.Forms.Label lblTitulo;
        //private dsCotizaciones dsCotizaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colrtn;
        private DevExpress.XtraGrid.Columns.GridColumn colcontacto;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_emision;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnExcelAuto;
        private DevExpress.XtraEditors.SimpleButton cmdRefreshDisponibles;
        private DevExpress.XtraEditors.DateEdit dtFechaHastaDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaDesdeDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private dsFactCotizacion dsFactCotizacion1;
    }
}