namespace JAGUAR_APP.AlmacenesExterno
{
    partial class xfrmMovimientoStock
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcTransferencia = new DevExpress.XtraGrid.GridControl();
            this.transferenciaStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSalidasAlmacenesExternos = new JAGUAR_APP.AlmacenesExterno.dsSalidasAlmacenesExternos();
            this.gvTransferencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodeItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrom_almacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luBodegaFrom = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlmacenesExternos = new JAGUAR_APP.AlmacenesExterno.dsAlmacenesExternos();
            this.colto_almacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luBodegaTO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colcantidad_kilos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantIngresar = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ceSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnBuscarProd = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarIngreso = new DevExpress.XtraEditors.SimpleButton();
            this.lueAlmacenFROM = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lueAlmacenDestino = new DevExpress.XtraEditors.LookUpEdit();
            this.btnConfLotes = new DevExpress.XtraEditors.SimpleButton();
            this.txtProveedor = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBodegaFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBodegaTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAlmacenFROM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAlmacenDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTransferencia
            // 
            this.gcTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransferencia.DataSource = this.transferenciaStockBindingSource;
            this.gcTransferencia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTransferencia.Location = new System.Drawing.Point(-1, 188);
            this.gcTransferencia.MainView = this.gvTransferencia;
            this.gcTransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTransferencia.Name = "gcTransferencia";
            this.gcTransferencia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtCantIngresar,
            this.ceSeleccionar,
            this.btnBuscarProd,
            this.luBodegaFrom,
            this.luBodegaTO});
            this.gcTransferencia.Size = new System.Drawing.Size(1168, 368);
            this.gcTransferencia.TabIndex = 35;
            this.gcTransferencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransferencia});
            // 
            // transferenciaStockBindingSource
            // 
            this.transferenciaStockBindingSource.DataMember = "Transferencia_Stock";
            this.transferenciaStockBindingSource.DataSource = this.dsSalidasAlmacenesExternos;
            // 
            // dsSalidasAlmacenesExternos
            // 
            this.dsSalidasAlmacenesExternos.DataSetName = "dsSalidasAlmacenesExternos";
            this.dsSalidasAlmacenesExternos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colcodeItem,
            this.colmp,
            this.colfrom_almacen,
            this.colto_almacen,
            this.colcantidad_kilos,
            this.colunidades,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.colid_presentacion});
            this.gvTransferencia.DetailHeight = 284;
            this.gvTransferencia.GridControl = this.gcTransferencia;
            this.gvTransferencia.Name = "gvTransferencia";
            this.gvTransferencia.OptionsView.ShowAutoFilterRow = true;
            this.gvTransferencia.OptionsView.ShowFooter = true;
            this.gvTransferencia.OptionsView.ShowGroupPanel = false;
            this.gvTransferencia.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colto_almacen, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvTransferencia.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvTransferencia_CellValueChanged);
            // 
            // colcodeItem
            // 
            this.colcodeItem.Caption = "Item Code";
            this.colcodeItem.FieldName = "itemcode";
            this.colcodeItem.MinWidth = 21;
            this.colcodeItem.Name = "colcodeItem";
            this.colcodeItem.OptionsColumn.AllowEdit = false;
            this.colcodeItem.OptionsFilter.AllowFilter = false;
            this.colcodeItem.Visible = true;
            this.colcodeItem.VisibleIndex = 0;
            this.colcodeItem.Width = 164;
            // 
            // colmp
            // 
            this.colmp.Caption = "Item Name";
            this.colmp.FieldName = "itemName";
            this.colmp.MinWidth = 21;
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.OptionsFilter.AllowFilter = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 1;
            this.colmp.Width = 164;
            // 
            // colfrom_almacen
            // 
            this.colfrom_almacen.Caption = "De Almacén";
            this.colfrom_almacen.ColumnEdit = this.luBodegaFrom;
            this.colfrom_almacen.FieldName = "from_almacen";
            this.colfrom_almacen.MinWidth = 21;
            this.colfrom_almacen.Name = "colfrom_almacen";
            this.colfrom_almacen.OptionsFilter.AllowFilter = false;
            this.colfrom_almacen.Visible = true;
            this.colfrom_almacen.VisibleIndex = 2;
            this.colfrom_almacen.Width = 164;
            // 
            // luBodegaFrom
            // 
            this.luBodegaFrom.AutoHeight = false;
            this.luBodegaFrom.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luBodegaFrom.DataSource = this.warehouseBindingSource;
            this.luBodegaFrom.DisplayMember = "WhsCode";
            this.luBodegaFrom.Name = "luBodegaFrom";
            this.luBodegaFrom.ValueMember = "WhsCode";
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.dsAlmacenesExternos;
            // 
            // dsAlmacenesExternos
            // 
            this.dsAlmacenesExternos.DataSetName = "dsAlmacenesExternos";
            this.dsAlmacenesExternos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colto_almacen
            // 
            this.colto_almacen.Caption = "Almacén Destino";
            this.colto_almacen.ColumnEdit = this.luBodegaTO;
            this.colto_almacen.FieldName = "to_almacen";
            this.colto_almacen.MinWidth = 21;
            this.colto_almacen.Name = "colto_almacen";
            this.colto_almacen.OptionsFilter.AllowFilter = false;
            this.colto_almacen.Visible = true;
            this.colto_almacen.VisibleIndex = 3;
            this.colto_almacen.Width = 164;
            // 
            // luBodegaTO
            // 
            this.luBodegaTO.AutoHeight = false;
            this.luBodegaTO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luBodegaTO.DataSource = this.warehouseBindingSource;
            this.luBodegaTO.DisplayMember = "WhsCode";
            this.luBodegaTO.Name = "luBodegaTO";
            this.luBodegaTO.ValueMember = "WhsCode";
            // 
            // colcantidad_kilos
            // 
            this.colcantidad_kilos.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colcantidad_kilos.AppearanceCell.Options.UseBackColor = true;
            this.colcantidad_kilos.Caption = "Cantidad en Almacen";
            this.colcantidad_kilos.FieldName = "peso";
            this.colcantidad_kilos.MinWidth = 21;
            this.colcantidad_kilos.Name = "colcantidad_kilos";
            this.colcantidad_kilos.OptionsColumn.AllowEdit = false;
            this.colcantidad_kilos.OptionsFilter.AllowFilter = false;
            this.colcantidad_kilos.Visible = true;
            this.colcantidad_kilos.VisibleIndex = 4;
            this.colcantidad_kilos.Width = 164;
            // 
            // colunidades
            // 
            this.colunidades.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colunidades.AppearanceCell.Options.UseBackColor = true;
            this.colunidades.Caption = "Unidades en Almacén";
            this.colunidades.FieldName = "unidades";
            this.colunidades.MinWidth = 21;
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.OptionsFilter.AllowFilter = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 5;
            this.colunidades.Width = 237;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cantidad a Transferir";
            this.gridColumn1.FieldName = "cantidad_a_transferir";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 81;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "NumLine";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 81;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "DocEntrySAP";
            this.gridColumn3.MinWidth = 21;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 81;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "id";
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 81;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Seleccionar";
            this.gridColumn5.FieldName = "seleccionar";
            this.gridColumn5.MinWidth = 21;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 95;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            // 
            // txtCantIngresar
            // 
            this.txtCantIngresar.AutoHeight = false;
            this.txtCantIngresar.Name = "txtCantIngresar";
            // 
            // ceSeleccionar
            // 
            this.ceSeleccionar.AutoHeight = false;
            this.ceSeleccionar.Name = "ceSeleccionar";
            this.ceSeleccionar.CheckStateChanged += new System.EventHandler(this.ceSeleccionar_CheckStateChanged);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.AutoHeight = false;
            editorButtonImageOptions1.Image = global::JAGUAR_APP.Properties.Resources.trazabilidad;
            this.btnBuscarProd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnBuscarProd_ButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Proveedor:_______";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(734, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fecha de documento:";
            // 
            // deFecha
            // 
            this.deFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(905, 89);
            this.deFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFecha.Properties.Appearance.Options.UseFont = true;
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Size = new System.Drawing.Size(201, 24);
            this.deFecha.TabIndex = 41;
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
            this.btnAtras.Location = new System.Drawing.Point(954, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 47);
            this.btnAtras.TabIndex = 43;
            this.btnAtras.Text = "Cancelar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnBuscarIngreso
            // 
            this.btnBuscarIngreso.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnBuscarIngreso.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnBuscarIngreso.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBuscarIngreso.Appearance.Options.UseBackColor = true;
            this.btnBuscarIngreso.Appearance.Options.UseFont = true;
            this.btnBuscarIngreso.Appearance.Options.UseForeColor = true;
            this.btnBuscarIngreso.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBuscarIngreso.Location = new System.Drawing.Point(21, 16);
            this.btnBuscarIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarIngreso.Name = "btnBuscarIngreso";
            this.btnBuscarIngreso.Size = new System.Drawing.Size(154, 47);
            this.btnBuscarIngreso.TabIndex = 44;
            this.btnBuscarIngreso.Text = "Buscar MP";
            this.btnBuscarIngreso.Click += new System.EventHandler(this.btnBuscarIngreso_Click);
            // 
            // lueAlmacenFROM
            // 
            this.lueAlmacenFROM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lueAlmacenFROM.Enabled = false;
            this.lueAlmacenFROM.Location = new System.Drawing.Point(905, 118);
            this.lueAlmacenFROM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueAlmacenFROM.Name = "lueAlmacenFROM";
            this.lueAlmacenFROM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueAlmacenFROM.Properties.Appearance.Options.UseFont = true;
            this.lueAlmacenFROM.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lueAlmacenFROM.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueAlmacenFROM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAlmacenFROM.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WhsCode", "Whs Code", 103, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WhsName", "Whs Name", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueAlmacenFROM.Properties.DataSource = this.warehouseBindingSource;
            this.lueAlmacenFROM.Properties.DisplayMember = "WhsCode";
            this.lueAlmacenFROM.Properties.NullText = "";
            this.lueAlmacenFROM.Properties.ValueMember = "WhsCode";
            this.lueAlmacenFROM.Size = new System.Drawing.Size(201, 24);
            this.lueAlmacenFROM.TabIndex = 45;
            this.lueAlmacenFROM.EditValueChanged += new System.EventHandler(this.lueAlmacenFROM_EditValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(801, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "De almacén:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Almacén destino:";
            // 
            // lueAlmacenDestino
            // 
            this.lueAlmacenDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lueAlmacenDestino.Location = new System.Drawing.Point(905, 147);
            this.lueAlmacenDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueAlmacenDestino.Name = "lueAlmacenDestino";
            this.lueAlmacenDestino.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lueAlmacenDestino.Properties.Appearance.Options.UseFont = true;
            this.lueAlmacenDestino.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lueAlmacenDestino.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueAlmacenDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAlmacenDestino.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WhsCode", "Whs Code", 103, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WhsName", "Whs Name", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueAlmacenDestino.Properties.DataSource = this.warehouseBindingSource;
            this.lueAlmacenDestino.Properties.DisplayMember = "WhsCode";
            this.lueAlmacenDestino.Properties.NullText = "";
            this.lueAlmacenDestino.Properties.ValueMember = "WhsCode";
            this.lueAlmacenDestino.Size = new System.Drawing.Size(201, 24);
            this.lueAlmacenDestino.TabIndex = 47;
            this.lueAlmacenDestino.EditValueChanged += new System.EventHandler(this.lueAlmacenDestino_EditValueChanged);
            // 
            // btnConfLotes
            // 
            this.btnConfLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfLotes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfLotes.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfLotes.Appearance.Options.UseBackColor = true;
            this.btnConfLotes.Appearance.Options.UseFont = true;
            this.btnConfLotes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnConfLotes.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfLotes.Location = new System.Drawing.Point(771, 12);
            this.btnConfLotes.Name = "btnConfLotes";
            this.btnConfLotes.Size = new System.Drawing.Size(154, 47);
            this.btnConfLotes.TabIndex = 49;
            this.btnConfLotes.Text = "Conf. Lotes";
            this.btnConfLotes.Click += new System.EventHandler(this.btnConfLotes_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(170, 89);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Size = new System.Drawing.Size(244, 78);
            this.txtProveedor.TabIndex = 50;
            // 
            // xfrmMovimientoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 555);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.btnConfLotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lueAlmacenDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lueAlmacenFROM);
            this.Controls.Add(this.btnBuscarIngreso);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gcTransferencia);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xfrmMovimientoStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento Stock";
            this.Load += new System.EventHandler(this.xfrmMovimientoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBodegaFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBodegaTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAlmacenFROM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAlmacenDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTransferencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransferencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantIngresar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceSeleccionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private dsAlmacenesExternos dsAlmacenesExternos;
        private DevExpress.XtraGrid.Columns.GridColumn colcodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colfrom_almacen;
        private DevExpress.XtraGrid.Columns.GridColumn colto_almacen;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_kilos;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnBuscarProd;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luBodegaFrom;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luBodegaTO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnBuscarIngreso;
        private System.Windows.Forms.BindingSource transferenciaStockBindingSource;
        private dsSalidasAlmacenesExternos dsSalidasAlmacenesExternos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LookUpEdit lueAlmacenFROM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lueAlmacenDestino;
        private DevExpress.XtraEditors.SimpleButton btnConfLotes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.MemoEdit txtProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
    }
}