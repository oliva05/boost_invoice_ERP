namespace JAGUAR_APP.Despachos
{
    partial class frmRequesicionesDetalle_PT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequesicionesDetalle_PT));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.grd_detalle = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new JAGUAR_APP.Despachos.ds_despachos();
            this.grdv_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsolicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprogramada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidad_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnedit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colasignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btndespacho = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndespacho)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(11, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(511, 40);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Detalle PT Solicitada";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(543, 11);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(176, 47);
            this.btnAtras.TabIndex = 37;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grd_detalle
            // 
            this.grd_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_detalle.DataMember = "requisiciones_d";
            this.grd_detalle.DataSource = this.ds_despachos;
            this.grd_detalle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_detalle.Location = new System.Drawing.Point(1, 72);
            this.grd_detalle.MainView = this.grdv_detalle;
            this.grd_detalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_detalle.Name = "grd_detalle";
            this.grd_detalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnedit,
            this.btndespacho});
            this.grd_detalle.Size = new System.Drawing.Size(730, 488);
            this.grd_detalle.TabIndex = 38;
            this.grd_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_detalle});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_detalle
            // 
            this.grdv_detalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_detalle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdv_detalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_detalle.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.grdv_detalle.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdv_detalle.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_detalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_detalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_detalle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdv_detalle.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.Row.Options.UseFont = true;
            this.grdv_detalle.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_detalle.Appearance.SelectedRow.Options.UseFont = true;
            this.grdv_detalle.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grdv_detalle.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grdv_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_materia_prima,
            this.colmp,
            this.colsolicitada,
            this.colprogramada,
            this.colentregada,
            this.colpendiente,
            this.colenable,
            this.colid_unidad_medida,
            this.colunidad,
            this.colcode_sap,
            this.gridColumn1,
            this.colasignado,
            this.colDespacho});
            this.grdv_detalle.DetailHeight = 284;
            this.grdv_detalle.GridControl = this.grd_detalle;
            this.grdv_detalle.Name = "grdv_detalle";
            this.grdv_detalle.OptionsCustomization.AllowFilter = false;
            this.grdv_detalle.OptionsView.ShowAutoFilterRow = true;
            this.grdv_detalle.OptionsView.ShowFooter = true;
            this.grdv_detalle.OptionsView.ShowGroupPanel = false;
            this.grdv_detalle.RowHeight = 16;
            this.grdv_detalle.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdv_detalle_RowStyle);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 17;
            this.colid.Name = "colid";
            this.colid.Width = 64;
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.MinWidth = 17;
            this.colid_materia_prima.Name = "colid_materia_prima";
            this.colid_materia_prima.Width = 64;
            // 
            // colmp
            // 
            this.colmp.Caption = "PT";
            this.colmp.FieldName = "mp";
            this.colmp.MinWidth = 17;
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 1;
            this.colmp.Width = 77;
            // 
            // colsolicitada
            // 
            this.colsolicitada.Caption = "Ud. Solicitado";
            this.colsolicitada.FieldName = "solicitada";
            this.colsolicitada.MinWidth = 17;
            this.colsolicitada.Name = "colsolicitada";
            this.colsolicitada.OptionsColumn.AllowEdit = false;
            this.colsolicitada.Visible = true;
            this.colsolicitada.VisibleIndex = 2;
            this.colsolicitada.Width = 77;
            // 
            // colprogramada
            // 
            this.colprogramada.FieldName = "programada";
            this.colprogramada.MinWidth = 17;
            this.colprogramada.Name = "colprogramada";
            this.colprogramada.Width = 64;
            // 
            // colentregada
            // 
            this.colentregada.Caption = "Ud. Entregado";
            this.colentregada.FieldName = "entregada";
            this.colentregada.MinWidth = 17;
            this.colentregada.Name = "colentregada";
            this.colentregada.OptionsColumn.AllowEdit = false;
            this.colentregada.Visible = true;
            this.colentregada.VisibleIndex = 4;
            this.colentregada.Width = 88;
            // 
            // colpendiente
            // 
            this.colpendiente.Caption = "Ud. Pendiente";
            this.colpendiente.FieldName = "pendiente";
            this.colpendiente.MinWidth = 17;
            this.colpendiente.Name = "colpendiente";
            this.colpendiente.OptionsColumn.AllowEdit = false;
            this.colpendiente.Visible = true;
            this.colpendiente.VisibleIndex = 5;
            this.colpendiente.Width = 72;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.MinWidth = 17;
            this.colenable.Name = "colenable";
            this.colenable.Width = 64;
            // 
            // colid_unidad_medida
            // 
            this.colid_unidad_medida.FieldName = "id_unidad_medida";
            this.colid_unidad_medida.MinWidth = 17;
            this.colid_unidad_medida.Name = "colid_unidad_medida";
            this.colid_unidad_medida.Width = 64;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad Medida";
            this.colunidad.FieldName = "unidad";
            this.colunidad.MinWidth = 17;
            this.colunidad.Name = "colunidad";
            this.colunidad.OptionsColumn.AllowEdit = false;
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 6;
            this.colunidad.Width = 72;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Cod. MP SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.MinWidth = 17;
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            this.colcode_sap.Width = 81;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnedit;
            this.gridColumn1.MinWidth = 17;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 69;
            // 
            // btnedit
            // 
            this.btnedit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnedit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnedit.Name = "btnedit";
            this.btnedit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // colasignado
            // 
            this.colasignado.Caption = "Ud. Asignado";
            this.colasignado.FieldName = "asignado";
            this.colasignado.MinWidth = 17;
            this.colasignado.Name = "colasignado";
            this.colasignado.Visible = true;
            this.colasignado.VisibleIndex = 3;
            this.colasignado.Width = 85;
            // 
            // colDespacho
            // 
            this.colDespacho.Caption = "Despacho";
            this.colDespacho.ColumnEdit = this.btndespacho;
            this.colDespacho.MinWidth = 17;
            this.colDespacho.Name = "colDespacho";
            this.colDespacho.Visible = true;
            this.colDespacho.VisibleIndex = 8;
            this.colDespacho.Width = 92;
            // 
            // btndespacho
            // 
            this.btndespacho.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btndespacho.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btndespacho.Name = "btndespacho";
            this.btndespacho.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btndespacho.Click += new System.EventHandler(this.btndespacho_Click);
            // 
            // frmRequesicionesDetalle_PT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 560);
            this.Controls.Add(this.grd_detalle);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRequesicionesDetalle_PT";
            this.Text = "frmRequesicionesDetalle_PT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndespacho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl grd_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colsolicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colprogramada;
        private DevExpress.XtraGrid.Columns.GridColumn colentregada;
        private DevExpress.XtraGrid.Columns.GridColumn colpendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidad_medida;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colasignado;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnedit;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colDespacho;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btndespacho;
    }
}