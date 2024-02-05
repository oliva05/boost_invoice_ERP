namespace JAGUAR_APP.RecuentoInventario
{
    partial class frmRecuentoInventario
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
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsRecuento = new JAGUAR_APP.RecuentoInventario.dsRecuento();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasParaVencer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_prd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbMateriaPrima = new DevExpress.XtraEditors.GridLookUpEdit();
            this.materiaprimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemdescrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tggOperacion = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGestionar = new DevExpress.XtraEditors.SimpleButton();
            this.checkDisponibles = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMateriaPrima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDisponibles.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(966, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 48);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(86, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(579, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Recuento de inventario";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "tarimas_ajuste";
            this.grd_data.DataSource = this.dsRecuento;
            this.grd_data.Location = new System.Drawing.Point(-1, 147);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(1170, 579);
            this.grd_data.TabIndex = 33;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsRecuento
            // 
            this.dsRecuento.DataSetName = "dsRecuento";
            this.dsRecuento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colingreso,
            this.collote_materia_prima,
            this.colitemcode1,
            this.colmaterial,
            this.colcantidad,
            this.coldescripcion,
            this.colfactor,
            this.colpeso,
            this.colcodigo,
            this.colFechaIngreso,
            this.colDiasParaVencer,
            this.colcant_prd,
            this.colcant_bodega,
            this.colseleccionar});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", this.colcantidad, "(Cantidad Total ={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", null, "(Peso ={0:0.##.##} Kg.)")});
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_data.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.grdv_data.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colingreso
            // 
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.OptionsColumn.AllowEdit = false;
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 0;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 1;
            // 
            // colitemcode1
            // 
            this.colitemcode1.FieldName = "itemcode";
            this.colitemcode1.Name = "colitemcode1";
            this.colitemcode1.OptionsColumn.AllowEdit = false;
            this.colitemcode1.Visible = true;
            this.colitemcode1.VisibleIndex = 2;
            // 
            // colmaterial
            // 
            this.colmaterial.FieldName = "material";
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.OptionsColumn.AllowEdit = false;
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 3;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 4;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 5;
            // 
            // colfactor
            // 
            this.colfactor.FieldName = "factor";
            this.colfactor.Name = "colfactor";
            this.colfactor.OptionsColumn.AllowEdit = false;
            // 
            // colpeso
            // 
            this.colpeso.DisplayFormat.FormatString = "n2";
            this.colpeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 6;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 7;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.FieldName = "FechaIngreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.OptionsColumn.AllowEdit = false;
            this.colFechaIngreso.Visible = true;
            this.colFechaIngreso.VisibleIndex = 8;
            // 
            // colDiasParaVencer
            // 
            this.colDiasParaVencer.FieldName = "DiasParaVencer";
            this.colDiasParaVencer.Name = "colDiasParaVencer";
            this.colDiasParaVencer.OptionsColumn.AllowEdit = false;
            // 
            // colcant_prd
            // 
            this.colcant_prd.FieldName = "cant_prd";
            this.colcant_prd.Name = "colcant_prd";
            this.colcant_prd.OptionsColumn.AllowEdit = false;
            this.colcant_prd.Visible = true;
            this.colcant_prd.VisibleIndex = 9;
            // 
            // colcant_bodega
            // 
            this.colcant_bodega.FieldName = "cant_bodega";
            this.colcant_bodega.Name = "colcant_bodega";
            this.colcant_bodega.OptionsColumn.AllowEdit = false;
            this.colcant_bodega.Visible = true;
            this.colcant_bodega.VisibleIndex = 10;
            // 
            // colseleccionar
            // 
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 17);
            this.labelControl2.TabIndex = 96;
            this.labelControl2.Text = "Materia Prima:";
            // 
            // cbMateriaPrima
            // 
            this.cbMateriaPrima.Location = new System.Drawing.Point(97, 81);
            this.cbMateriaPrima.Name = "cbMateriaPrima";
            this.cbMateriaPrima.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbMateriaPrima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriaPrima.Properties.Appearance.Options.UseFont = true;
            this.cbMateriaPrima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMateriaPrima.Properties.DataSource = this.materiaprimaBindingSource;
            this.cbMateriaPrima.Properties.DisplayMember = "itemdescrip";
            this.cbMateriaPrima.Properties.NullText = "";
            this.cbMateriaPrima.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cbMateriaPrima.Properties.PopupFormSize = new System.Drawing.Size(400, 0);
            this.cbMateriaPrima.Properties.PopupView = this.gvMateriaPrima;
            this.cbMateriaPrima.Properties.ValueMember = "itemcode";
            this.cbMateriaPrima.Size = new System.Drawing.Size(314, 24);
            this.cbMateriaPrima.TabIndex = 95;
            this.cbMateriaPrima.EditValueChanged += new System.EventHandler(this.cbMateriaPrima_EditValueChanged);
            // 
            // materiaprimaBindingSource
            // 
            this.materiaprimaBindingSource.DataMember = "materia_prima";
            this.materiaprimaBindingSource.DataSource = this.dsRecuento;
            // 
            // gvMateriaPrima
            // 
            this.gvMateriaPrima.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.GroupRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.Row.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMateriaPrima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemcode,
            this.colitemdescrip});
            this.gvMateriaPrima.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvMateriaPrima.Name = "gvMateriaPrima";
            this.gvMateriaPrima.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMateriaPrima.OptionsView.ShowAutoFilterRow = true;
            this.gvMateriaPrima.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvMateriaPrima.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Item Code";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            // 
            // colitemdescrip
            // 
            this.colitemdescrip.Caption = "Materia Prima";
            this.colitemdescrip.FieldName = "itemdescrip";
            this.colitemdescrip.Name = "colitemdescrip";
            this.colitemdescrip.Visible = true;
            this.colitemdescrip.VisibleIndex = 0;
            // 
            // tggOperacion
            // 
            this.tggOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tggOperacion.Location = new System.Drawing.Point(308, 14);
            this.tggOperacion.Name = "tggOperacion";
            this.tggOperacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.tggOperacion.Properties.Appearance.Options.UseFont = true;
            this.tggOperacion.Properties.OffText = "Salida de inventario";
            this.tggOperacion.Properties.OnText = "Reingreso de Inventario";
            this.tggOperacion.Size = new System.Drawing.Size(302, 36);
            this.tggOperacion.TabIndex = 98;
            this.tggOperacion.Visible = false;
            this.tggOperacion.Toggled += new System.EventHandler(this.tggOperacion_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(205, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 25);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Operacion:";
            this.labelControl1.Visible = false;
            // 
            // cmdGestionar
            // 
            this.cmdGestionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGestionar.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdGestionar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGestionar.Appearance.Options.UseBackColor = true;
            this.cmdGestionar.Appearance.Options.UseFont = true;
            this.cmdGestionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGestionar.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.web_apply_32px;
            this.cmdGestionar.Location = new System.Drawing.Point(967, 57);
            this.cmdGestionar.Name = "cmdGestionar";
            this.cmdGestionar.Size = new System.Drawing.Size(199, 48);
            this.cmdGestionar.TabIndex = 100;
            this.cmdGestionar.Text = "Gestionar";
            this.cmdGestionar.Click += new System.EventHandler(this.cmdGestionar_Click);
            // 
            // checkDisponibles
            // 
            this.checkDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkDisponibles.Location = new System.Drawing.Point(992, 122);
            this.checkDisponibles.Name = "checkDisponibles";
            this.checkDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisponibles.Properties.Appearance.Options.UseFont = true;
            this.checkDisponibles.Properties.Caption = "Seleccionar Todas";
            this.checkDisponibles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkDisponibles.Size = new System.Drawing.Size(124, 19);
            this.checkDisponibles.TabIndex = 101;
            this.checkDisponibles.CheckedChanged += new System.EventHandler(this.checkDisponibles_CheckedChanged);
            // 
            // frmRecuentoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 726);
            this.Controls.Add(this.checkDisponibles);
            this.Controls.Add(this.cmdGestionar);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tggOperacion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cbMateriaPrima);
            this.Controls.Add(this.grd_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuentoInventario";
            this.Text = "frmRecuentoInventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMateriaPrima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDisponibles.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit cbMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemdescrip;
        private DevExpress.XtraEditors.ToggleSwitch tggOperacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsRecuento dsRecuento;
        private System.Windows.Forms.BindingSource materiaprimaBindingSource;
        private DevExpress.XtraEditors.SimpleButton cmdGestionar;
        private DevExpress.XtraEditors.CheckEdit checkDisponibles;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfactor;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasParaVencer;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_prd;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
    }
}