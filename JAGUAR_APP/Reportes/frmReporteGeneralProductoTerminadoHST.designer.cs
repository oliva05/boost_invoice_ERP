
namespace JAGUAR_APP.Reportes
{
    partial class frmReporteGeneralProductoTerminadoHST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGeneralProductoTerminadoHST));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dsReportesInventario1 = new JAGUAR_APP.Reportes.dsReportesInventario();
            this.grd_inventario = new DevExpress.XtraGrid.GridControl();
            this.grdv_inventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_in1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_out1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_in1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_out1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAjuste = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchVerTodas = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchVerTodas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1223, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 47);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dsReportesInventario1
            // 
            this.dsReportesInventario1.DataSetName = "dsReportesInventario";
            this.dsReportesInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grd_inventario
            // 
            this.grd_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_inventario.DataMember = "inventario_kardex_historico";
            this.grd_inventario.DataSource = this.dsReportesInventario1;
            this.grd_inventario.Location = new System.Drawing.Point(-2, 110);
            this.grd_inventario.MainView = this.grdv_inventario;
            this.grd_inventario.Name = "grd_inventario";
            this.grd_inventario.Size = new System.Drawing.Size(1331, 561);
            this.grd_inventario.TabIndex = 0;
            this.grd_inventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario});
            // 
            // grdv_inventario
            // 
            this.grdv_inventario.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_inventario.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_inventario.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_inventario.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_inventario.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_inventario.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_inventario.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.Preview.Options.UseFont = true;
            this.grdv_inventario.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.Row.Options.UseFont = true;
            this.grdv_inventario.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_inventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.gridColumn4,
            this.colProducto1,
            this.collote_pt1,
            this.colcantidad_in1,
            this.colcantidad_out1,
            this.colpeso_in1,
            this.colpeso_out1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colcosto,
            this.gridColumn5});
            this.grdv_inventario.GridControl = this.grd_inventario;
            this.grdv_inventario.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", null, "(Kilogramos: SUMA={0:0.##.##} Kg)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", null, "(Unidades en Existencia: SUMA={0:0.##.##} Ud)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", null, "(TM Existencia: SUMA={0:0.##.##} TM)")});
            this.grdv_inventario.Name = "grdv_inventario";
            this.grdv_inventario.OptionsView.ShowAutoFilterRow = true;
            this.grdv_inventario.OptionsView.ShowFooter = true;
            this.grdv_inventario.OptionsView.ShowGroupPanel = false;
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.Name = "colid_pt1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha";
            this.gridColumn4.FieldName = "fecha";
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 123;
            // 
            // colProducto1
            // 
            this.colProducto1.Caption = "N Producto";
            this.colProducto1.FieldName = "PT";
            this.colProducto1.Name = "colProducto1";
            this.colProducto1.OptionsColumn.ReadOnly = true;
            this.colProducto1.Visible = true;
            this.colProducto1.VisibleIndex = 1;
            this.colProducto1.Width = 196;
            // 
            // collote_pt1
            // 
            this.collote_pt1.Caption = "# Lote";
            this.collote_pt1.FieldName = "lote";
            this.collote_pt1.Name = "collote_pt1";
            this.collote_pt1.OptionsColumn.ReadOnly = true;
            this.collote_pt1.Visible = true;
            this.collote_pt1.VisibleIndex = 2;
            this.collote_pt1.Width = 196;
            // 
            // colcantidad_in1
            // 
            this.colcantidad_in1.Caption = "Cantidad Entrada";
            this.colcantidad_in1.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colcantidad_in1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_in1.FieldName = "cantidad_in";
            this.colcantidad_in1.Name = "colcantidad_in1";
            this.colcantidad_in1.OptionsColumn.AllowEdit = false;
            // 
            // colcantidad_out1
            // 
            this.colcantidad_out1.Caption = "Cantidad Salida";
            this.colcantidad_out1.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colcantidad_out1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_out1.FieldName = "cantidad_out";
            this.colcantidad_out1.Name = "colcantidad_out1";
            this.colcantidad_out1.OptionsColumn.AllowEdit = false;
            // 
            // colpeso_in1
            // 
            this.colpeso_in1.Caption = "Peso Entrada";
            this.colpeso_in1.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso_in1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_in1.FieldName = "peso_in";
            this.colpeso_in1.Name = "colpeso_in1";
            this.colpeso_in1.OptionsColumn.AllowEdit = false;
            // 
            // colpeso_out1
            // 
            this.colpeso_out1.Caption = "Peso Salida";
            this.colpeso_out1.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso_out1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_out1.FieldName = "peso_out";
            this.colpeso_out1.Name = "colpeso_out1";
            this.colpeso_out1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Existencia";
            this.gridColumn1.FieldName = "existencia";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 196;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Presentación";
            this.gridColumn2.FieldName = "presentacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 184;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Factor";
            this.gridColumn3.FieldName = "factor";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 196;
            // 
            // colcosto
            // 
            this.colcosto.DisplayFormat.FormatString = "n4";
            this.colcosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcosto.FieldName = "costo";
            this.colcosto.Name = "colcosto";
            this.colcosto.OptionsColumn.ReadOnly = true;
            this.colcosto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "costo", "SUM={0:n4}")});
            this.colcosto.Visible = true;
            this.colcosto.VisibleIndex = 6;
            this.colcosto.Width = 202;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Transacción";
            this.gridColumn5.FieldName = "transaccion";
            this.gridColumn5.MinWidth = 21;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 118;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1113, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 47);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdAjuste
            // 
            this.cmdAjuste.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjuste.Appearance.Options.UseFont = true;
            this.cmdAjuste.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAjuste.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAjuste.ImageOptions.Image")));
            this.cmdAjuste.Location = new System.Drawing.Point(12, 8);
            this.cmdAjuste.Name = "cmdAjuste";
            this.cmdAjuste.Size = new System.Drawing.Size(172, 47);
            this.cmdAjuste.TabIndex = 6;
            this.cmdAjuste.Text = "Ajuste de Inventario";
            this.cmdAjuste.Visible = false;
            this.cmdAjuste.Click += new System.EventHandler(this.cmdAjuste_Click);
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(1003, 9);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 47);
            this.cmdRecargar.TabIndex = 7;
            this.cmdRecargar.Text = "Recargar";
            this.cmdRecargar.Click += new System.EventHandler(this.cmdRecargar_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(570, 78);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 83;
            // 
            // dtDesde
            // 
            this.dtDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(570, 50);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 82;
            // 
            // CargarDatos
            // 
            this.CargarDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CargarDatos.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.CargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarDatos.Appearance.Options.UseBackColor = true;
            this.CargarDatos.Appearance.Options.UseFont = true;
            this.CargarDatos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.CargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.ImageOptions.Image")));
            this.CargarDatos.Location = new System.Drawing.Point(705, 50);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 54);
            this.CargarDatos.TabIndex = 81;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(488, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 80;
            this.labelControl3.Text = "Fecha Hasta:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(488, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 79;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(638, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 17);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Ver Todos";
            // 
            // toggleSwitchVerTodas
            // 
            this.toggleSwitchVerTodas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toggleSwitchVerTodas.Location = new System.Drawing.Point(705, 16);
            this.toggleSwitchVerTodas.Name = "toggleSwitchVerTodas";
            this.toggleSwitchVerTodas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.toggleSwitchVerTodas.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchVerTodas.Properties.OffText = "No";
            this.toggleSwitchVerTodas.Properties.OnText = "Si";
            this.toggleSwitchVerTodas.Size = new System.Drawing.Size(109, 22);
            this.toggleSwitchVerTodas.TabIndex = 77;
            this.toggleSwitchVerTodas.Toggled += new System.EventHandler(this.toggleSwitchVerTodas_Toggled);
            // 
            // frmReporteGeneralProductoTerminadoHST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 670);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.toggleSwitchVerTodas);
            this.Controls.Add(this.grd_inventario);
            this.Controls.Add(this.cmdRecargar);
            this.Controls.Add(this.cmdAjuste);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReporteGeneralProductoTerminadoHST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Historico de Producto Terminado.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchVerTodas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl grd_inventario;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdAjuste;
        private dsReportesInventario dsReportesInventario1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_in1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_out1;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_in1;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_out1;
        private DevExpress.XtraEditors.SimpleButton cmdRecargar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchVerTodas;
    }
}