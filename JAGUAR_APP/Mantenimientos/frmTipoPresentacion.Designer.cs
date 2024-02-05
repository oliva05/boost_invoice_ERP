namespace JAGUAR_APP.Mantenimientos
{
    partial class frmTipoPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPresentacion));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tiposPresentacionesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento = new JAGUAR_APP.Mantenimientos.dsMantenimiento();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gcTiposPresentaciones = new DevExpress.XtraGrid.GridControl();
            this.gvTiposPresentaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colclase_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEditTipoPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceTipos = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tiposPresentacionesDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposPresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposPresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // tiposPresentacionesDataTableBindingSource
            // 
            this.tiposPresentacionesDataTableBindingSource.DataMember = "TiposPresentacionesDataTable";
            this.tiposPresentacionesDataTableBindingSource.DataSource = this.dsMantenimiento;
            // 
            // dsMantenimiento
            // 
            this.dsMantenimiento.DataSetName = "LOSADataSet";
            this.dsMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(0, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 44);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(754, 80);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(145, 44);
            this.btnAtras.TabIndex = 30;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gcTiposPresentaciones
            // 
            this.gcTiposPresentaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTiposPresentaciones.DataSource = this.tiposPresentacionesDataTableBindingSource;
            this.gcTiposPresentaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gcTiposPresentaciones.Location = new System.Drawing.Point(-1, 130);
            this.gcTiposPresentaciones.MainView = this.gvTiposPresentaciones;
            this.gcTiposPresentaciones.Name = "gcTiposPresentaciones";
            this.gcTiposPresentaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.repositoryItemCheckEdit1});
            this.gcTiposPresentaciones.Size = new System.Drawing.Size(899, 454);
            this.gcTiposPresentaciones.TabIndex = 32;
            this.gcTiposPresentaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTiposPresentaciones});
            // 
            // gvTiposPresentaciones
            // 
            this.gvTiposPresentaciones.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvTiposPresentaciones.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTiposPresentaciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTiposPresentaciones.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvTiposPresentaciones.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTiposPresentaciones.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTiposPresentaciones.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTiposPresentaciones.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvTiposPresentaciones.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTiposPresentaciones.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTiposPresentaciones.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTiposPresentaciones.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTiposPresentaciones.Appearance.Row.Options.UseFont = true;
            this.gvTiposPresentaciones.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTiposPresentaciones.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTiposPresentaciones.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTiposPresentaciones.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTiposPresentaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colenable,
            this.colFactor,
            this.coleditar,
            this.colclase_Name});
            this.gvTiposPresentaciones.GridControl = this.gcTiposPresentaciones;
            this.gvTiposPresentaciones.Name = "gvTiposPresentaciones";
            this.gvTiposPresentaciones.OptionsView.ShowAutoFilterRow = true;
            this.gvTiposPresentaciones.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Código";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 113;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 250;
            // 
            // colenable
            // 
            this.colenable.Caption = "Enable";
            this.colenable.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            this.colenable.OptionsColumn.ReadOnly = true;
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 2;
            this.colenable.Width = 67;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colFactor
            // 
            this.colFactor.Caption = "Factor";
            this.colFactor.DisplayFormat.FormatString = "n4";
            this.colFactor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFactor.FieldName = "factor";
            this.colFactor.Name = "colFactor";
            this.colFactor.OptionsColumn.ReadOnly = true;
            this.colFactor.OptionsFilter.AllowFilter = false;
            this.colFactor.Visible = true;
            this.colFactor.VisibleIndex = 3;
            // 
            // coleditar
            // 
            this.coleditar.Caption = "Editar";
            this.coleditar.ColumnEdit = this.btnEditar;
            this.coleditar.FieldName = "editar";
            this.coleditar.MaxWidth = 60;
            this.coleditar.Name = "coleditar";
            this.coleditar.Visible = true;
            this.coleditar.VisibleIndex = 4;
            this.coleditar.Width = 53;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::JAGUAR_APP.Properties.Resources.edit;
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // colclase_Name
            // 
            this.colclase_Name.Caption = "Tipo";
            this.colclase_Name.FieldName = "clase_Name";
            this.colclase_Name.Name = "colclase_Name";
            this.colclase_Name.OptionsColumn.AllowEdit = false;
            this.colclase_Name.OptionsColumn.ReadOnly = true;
            this.colclase_Name.Visible = true;
            this.colclase_Name.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(899, 45);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Mantenimiento de Tipo de Presentación";
            // 
            // gridLookUpEditTipoPresentacion
            // 
            this.gridLookUpEditTipoPresentacion.EditValue = "";
            this.gridLookUpEditTipoPresentacion.Location = new System.Drawing.Point(344, 98);
            this.gridLookUpEditTipoPresentacion.Name = "gridLookUpEditTipoPresentacion";
            this.gridLookUpEditTipoPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEditTipoPresentacion.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditTipoPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditTipoPresentacion.Properties.DataSource = this.bindingSourceTipos;
            this.gridLookUpEditTipoPresentacion.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditTipoPresentacion.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditTipoPresentacion.Properties.ValueMember = "id";
            this.gridLookUpEditTipoPresentacion.Size = new System.Drawing.Size(327, 26);
            this.gridLookUpEditTipoPresentacion.TabIndex = 38;
            this.gridLookUpEditTipoPresentacion.EditValueChanged += new System.EventHandler(this.gridLookUpEditTipoPresentacion_EditValueChanged);
            // 
            // bindingSourceTipos
            // 
            this.bindingSourceTipos.DataMember = "Presentacion_tipo";
            this.bindingSourceTipos.DataSource = this.dsMantenimiento;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(212, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 21);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Tipo Presentación";
            // 
            // frmTipoPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 584);
            this.Controls.Add(this.gridLookUpEditTipoPresentacion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcTiposPresentaciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.Name = "frmTipoPresentacion";
            this.ShowIcon = false;
            this.Text = "Tipos Presentaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tiposPresentacionesDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposPresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposPresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tiposPresentacionesDataTableBindingSource;
        private dsMantenimiento dsMantenimiento;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcTiposPresentaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTiposPresentaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn coleditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colclase_Name;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditTipoPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource bindingSourceTipos;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
    }
}