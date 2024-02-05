
namespace JAGUAR_APP.AlmacenesExterno
{
    partial class xfrmMovimientoStockDetalle
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
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gcTransferencia = new DevExpress.XtraGrid.GridControl();
            this.dsSalidasAlmacenesExternos1 = new JAGUAR_APP.AlmacenesExterno.dsSalidasAlmacenesExternos();
            this.gvTransferencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmateria_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fabricacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblNumTrans = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grdIngresoPlanta = new DevExpress.XtraGrid.GridControl();
            this.grdvIngresoPlanta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_creador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fabricacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_in1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_out1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngresoPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvIngresoPlanta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.cancel;
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1107, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 47);
            this.btnAtras.TabIndex = 44;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gcTransferencia
            // 
            this.gcTransferencia.DataMember = "Salida_Almacen_Detalle";
            this.gcTransferencia.DataSource = this.dsSalidasAlmacenesExternos1;
            this.gcTransferencia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTransferencia.Location = new System.Drawing.Point(0, 91);
            this.gcTransferencia.MainView = this.gvTransferencia;
            this.gcTransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTransferencia.Name = "gcTransferencia";
            this.gcTransferencia.Size = new System.Drawing.Size(1224, 184);
            this.gcTransferencia.TabIndex = 45;
            this.gcTransferencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransferencia});
            // 
            // dsSalidasAlmacenesExternos1
            // 
            this.dsSalidasAlmacenesExternos1.DataSetName = "dsSalidasAlmacenesExternos";
            this.dsSalidasAlmacenesExternos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTransferencia
            // 
            this.gvTransferencia.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTransferencia.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTransferencia.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTransferencia.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTransferencia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTransferencia.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTransferencia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTransferencia.Appearance.Row.Options.UseFont = true;
            this.gvTransferencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_mp,
            this.colmateria_prima,
            this.colid_h,
            this.colpeso,
            this.colunidades,
            this.colenable,
            this.colDocEntry,
            this.colcode_sap});
            this.gvTransferencia.DetailHeight = 284;
            this.gvTransferencia.GridControl = this.gcTransferencia;
            this.gvTransferencia.Name = "gvTransferencia";
            this.gvTransferencia.OptionsBehavior.Editable = false;
            this.gvTransferencia.OptionsView.ShowAutoFilterRow = true;
            this.gvTransferencia.OptionsView.ShowFooter = true;
            this.gvTransferencia.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // colmateria_prima
            // 
            this.colmateria_prima.Caption = "Materia Prima";
            this.colmateria_prima.FieldName = "materia_prima";
            this.colmateria_prima.Name = "colmateria_prima";
            this.colmateria_prima.OptionsColumn.AllowEdit = false;
            this.colmateria_prima.Visible = true;
            this.colmateria_prima.VisibleIndex = 1;
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Total Kg";
            this.colpeso.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 2;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Cantidad";
            this.colunidades.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colunidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", "SUMA={0:0.##.##} Ud")});
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colDocEntry
            // 
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Codigo SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Salida_Almacen_D_Lote";
            this.gridControl1.DataSource = this.dsSalidasAlmacenesExternos1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1218, 349);
            this.gridControl1.TabIndex = 46;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colpeso1,
            this.colunidades1,
            this.colfecha,
            this.coluser_creador,
            this.colusuario,
            this.colDocEntry1,
            this.colfecha_vencimiento,
            this.colfecha_fabricacion,
            this.colbodega_in,
            this.colbodega_out,
            this.collote});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colpeso1
            // 
            this.colpeso1.Caption = "Cantidad Kg";
            this.colpeso1.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso1.FieldName = "peso";
            this.colpeso1.Name = "colpeso1";
            this.colpeso1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "SUMA={0:#.##}")});
            this.colpeso1.Visible = true;
            this.colpeso1.VisibleIndex = 6;
            this.colpeso1.Width = 184;
            // 
            // colunidades1
            // 
            this.colunidades1.Caption = "Cantidad Ud";
            this.colunidades1.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colunidades1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colunidades1.FieldName = "unidades";
            this.colunidades1.Name = "colunidades1";
            this.colunidades1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", "SUMA={0:#.##}")});
            this.colunidades1.Visible = true;
            this.colunidades1.VisibleIndex = 5;
            this.colunidades1.Width = 190;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            // 
            // coluser_creador
            // 
            this.coluser_creador.FieldName = "user_creador";
            this.coluser_creador.Name = "coluser_creador";
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            // 
            // colDocEntry1
            // 
            this.colDocEntry1.FieldName = "DocEntry";
            this.colDocEntry1.Name = "colDocEntry1";
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.DisplayFormat.FormatString = "{0:d}";
            this.colfecha_vencimiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 3;
            this.colfecha_vencimiento.Width = 225;
            // 
            // colfecha_fabricacion
            // 
            this.colfecha_fabricacion.Caption = "Fecha Fabricacion";
            this.colfecha_fabricacion.DisplayFormat.FormatString = "{0:d}";
            this.colfecha_fabricacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_fabricacion.FieldName = "fecha_fabricacion";
            this.colfecha_fabricacion.Name = "colfecha_fabricacion";
            this.colfecha_fabricacion.Visible = true;
            this.colfecha_fabricacion.VisibleIndex = 4;
            this.colfecha_fabricacion.Width = 276;
            // 
            // colbodega_in
            // 
            this.colbodega_in.FieldName = "bodega_in";
            this.colbodega_in.Name = "colbodega_in";
            this.colbodega_in.Visible = true;
            this.colbodega_in.VisibleIndex = 1;
            this.colbodega_in.Width = 136;
            // 
            // colbodega_out
            // 
            this.colbodega_out.FieldName = "bodega_out";
            this.colbodega_out.Name = "colbodega_out";
            this.colbodega_out.Visible = true;
            this.colbodega_out.VisibleIndex = 2;
            this.colbodega_out.Width = 152;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            this.collote.Width = 226;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(241, 30);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "# Transferencia de Stock";
            // 
            // lblNumTrans
            // 
            this.lblNumTrans.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTrans.Appearance.Options.UseFont = true;
            this.lblNumTrans.Location = new System.Drawing.Point(259, 24);
            this.lblNumTrans.Name = "lblNumTrans";
            this.lblNumTrans.Size = new System.Drawing.Size(36, 30);
            this.lblNumTrans.TabIndex = 48;
            this.lblNumTrans.Text = "###";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblNumTrans);
            this.panelControl1.Controls.Add(this.btnAtras);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1265, 86);
            this.panelControl1.TabIndex = 49;
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(0, 280);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1224, 385);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(1224, 385);
            this.tabPane1.TabIndex = 50;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Transferencia Planficada";
            this.tabNavigationPage1.Controls.Add(this.gridControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1224, 358);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Ingreso en Planta";
            this.tabNavigationPage2.Controls.Add(this.grdIngresoPlanta);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1224, 358);
            // 
            // grdIngresoPlanta
            // 
            this.grdIngresoPlanta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdIngresoPlanta.DataMember = "Salida_Almacen_D_Lote_Ingreso";
            this.grdIngresoPlanta.DataSource = this.dsSalidasAlmacenesExternos1;
            this.grdIngresoPlanta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdIngresoPlanta.Location = new System.Drawing.Point(3, 4);
            this.grdIngresoPlanta.MainView = this.grdvIngresoPlanta;
            this.grdIngresoPlanta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdIngresoPlanta.Name = "grdIngresoPlanta";
            this.grdIngresoPlanta.Size = new System.Drawing.Size(1218, 349);
            this.grdIngresoPlanta.TabIndex = 47;
            this.grdIngresoPlanta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvIngresoPlanta});
            // 
            // grdvIngresoPlanta
            // 
            this.grdvIngresoPlanta.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdvIngresoPlanta.Appearance.FocusedRow.Options.UseFont = true;
            this.grdvIngresoPlanta.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvIngresoPlanta.Appearance.FooterPanel.Options.UseFont = true;
            this.grdvIngresoPlanta.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvIngresoPlanta.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvIngresoPlanta.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdvIngresoPlanta.Appearance.Row.Options.UseFont = true;
            this.grdvIngresoPlanta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colpeso2,
            this.colunidades2,
            this.colfecha1,
            this.coluser_creador1,
            this.colDocEntry2,
            this.colfecha_vencimiento1,
            this.colfecha_fabricacion1,
            this.colbodega_in1,
            this.colbodega_out1,
            this.collote1,
            this.colDocNum});
            this.grdvIngresoPlanta.DetailHeight = 284;
            this.grdvIngresoPlanta.GridControl = this.grdIngresoPlanta;
            this.grdvIngresoPlanta.Name = "grdvIngresoPlanta";
            this.grdvIngresoPlanta.OptionsBehavior.Editable = false;
            this.grdvIngresoPlanta.OptionsView.ShowAutoFilterRow = true;
            this.grdvIngresoPlanta.OptionsView.ShowFooter = true;
            this.grdvIngresoPlanta.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // colpeso2
            // 
            this.colpeso2.Caption = "Cantidad";
            this.colpeso2.FieldName = "peso";
            this.colpeso2.Name = "colpeso2";
            this.colpeso2.OptionsColumn.AllowEdit = false;
            this.colpeso2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "SUMA={0:#.##}")});
            this.colpeso2.Visible = true;
            this.colpeso2.VisibleIndex = 7;
            this.colpeso2.Width = 123;
            // 
            // colunidades2
            // 
            this.colunidades2.Caption = "Unidades";
            this.colunidades2.FieldName = "unidades";
            this.colunidades2.Name = "colunidades2";
            this.colunidades2.OptionsColumn.AllowEdit = false;
            this.colunidades2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", "SUMA={0:#.##}")});
            this.colunidades2.Visible = true;
            this.colunidades2.VisibleIndex = 6;
            this.colunidades2.Width = 123;
            // 
            // colfecha1
            // 
            this.colfecha1.FieldName = "fecha";
            this.colfecha1.Name = "colfecha1";
            this.colfecha1.OptionsColumn.AllowEdit = false;
            // 
            // coluser_creador1
            // 
            this.coluser_creador1.FieldName = "user_creador";
            this.coluser_creador1.Name = "coluser_creador1";
            // 
            // colDocEntry2
            // 
            this.colDocEntry2.FieldName = "DocEntry";
            this.colDocEntry2.Name = "colDocEntry2";
            this.colDocEntry2.OptionsColumn.AllowEdit = false;
            this.colDocEntry2.Width = 123;
            // 
            // colfecha_vencimiento1
            // 
            this.colfecha_vencimiento1.Caption = "Fecha de Vencimiento";
            this.colfecha_vencimiento1.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento1.Name = "colfecha_vencimiento1";
            this.colfecha_vencimiento1.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento1.Visible = true;
            this.colfecha_vencimiento1.VisibleIndex = 5;
            this.colfecha_vencimiento1.Width = 127;
            // 
            // colfecha_fabricacion1
            // 
            this.colfecha_fabricacion1.Caption = "Fecha de Fabricacion";
            this.colfecha_fabricacion1.FieldName = "fecha_fabricacion";
            this.colfecha_fabricacion1.Name = "colfecha_fabricacion1";
            this.colfecha_fabricacion1.OptionsColumn.AllowEdit = false;
            this.colfecha_fabricacion1.Visible = true;
            this.colfecha_fabricacion1.VisibleIndex = 4;
            this.colfecha_fabricacion1.Width = 125;
            // 
            // colbodega_in1
            // 
            this.colbodega_in1.Caption = "Destino";
            this.colbodega_in1.FieldName = "bodega_in";
            this.colbodega_in1.Name = "colbodega_in1";
            this.colbodega_in1.OptionsColumn.AllowEdit = false;
            this.colbodega_in1.Visible = true;
            this.colbodega_in1.VisibleIndex = 2;
            this.colbodega_in1.Width = 125;
            // 
            // colbodega_out1
            // 
            this.colbodega_out1.Caption = "Origen";
            this.colbodega_out1.FieldName = "bodega_out";
            this.colbodega_out1.Name = "colbodega_out1";
            this.colbodega_out1.OptionsColumn.AllowEdit = false;
            this.colbodega_out1.Visible = true;
            this.colbodega_out1.VisibleIndex = 1;
            this.colbodega_out1.Width = 128;
            // 
            // collote1
            // 
            this.collote1.Caption = "Lote";
            this.collote1.FieldName = "lote";
            this.collote1.Name = "collote1";
            this.collote1.OptionsColumn.AllowEdit = false;
            this.collote1.Visible = true;
            this.collote1.VisibleIndex = 0;
            this.collote1.Width = 197;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "OC de Sap";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 3;
            // 
            // xfrmMovimientoStockDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 702);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcTransferencia);
            this.Controls.Add(this.tabPane1);
            this.Name = "xfrmMovimientoStockDetalle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIngresoPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvIngresoPlanta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcTransferencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransferencia;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsSalidasAlmacenesExternos dsSalidasAlmacenesExternos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colmateria_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso1;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fabricacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblNumTrans;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_in;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_out;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl grdIngresoPlanta;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvIngresoPlanta;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso2;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades2;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_creador1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry2;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fabricacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_in1;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_out1;
        private DevExpress.XtraGrid.Columns.GridColumn collote1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
    }
}