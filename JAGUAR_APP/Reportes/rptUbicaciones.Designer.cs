namespace JAGUAR_APP.Reportes
{
    partial class rptUbicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptUbicaciones));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_bodegas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bodegasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes = new JAGUAR_APP.Reportes.dsReportes();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grd_ubicaciones = new DevExpress.XtraGrid.GridControl();
            this.grdv_ubicaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUb1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUb2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDivision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colver1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnrpt1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colver2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnrpt2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantTM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantTM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_bodegas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ubicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ubicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrpt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrpt2)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_bodegas
            // 
            this.grd_bodegas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_bodegas.EditValue = "Se";
            this.grd_bodegas.Location = new System.Drawing.Point(143, 63);
            this.grd_bodegas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_bodegas.Name = "grd_bodegas";
            this.grd_bodegas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_bodegas.Properties.Appearance.Options.UseFont = true;
            this.grd_bodegas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_bodegas.Properties.DataSource = this.bodegasBindingSource;
            this.grd_bodegas.Properties.DisplayMember = "descripcion";
            this.grd_bodegas.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_bodegas.Properties.ValueMember = "id";
            this.grd_bodegas.Size = new System.Drawing.Size(379, 34);
            this.grd_bodegas.TabIndex = 0;
            this.grd_bodegas.EditValueChanged += new System.EventHandler(this.grd_bodegas_EditValueChanged);
            // 
            // bodegasBindingSource
            // 
            this.bodegasBindingSource.DataMember = "bodegas";
            this.bodegasBindingSource.DataSource = this.dsReportes;
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "dsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Bodega";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(10, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(680, 50);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Reporte de Ubicaciones";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 69);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 27);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Bodega:";
            // 
            // grd_ubicaciones
            // 
            this.grd_ubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_ubicaciones.DataMember = "Ubicaciones";
            this.grd_ubicaciones.DataSource = this.dsReportes;
            this.grd_ubicaciones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_ubicaciones.Location = new System.Drawing.Point(0, 116);
            this.grd_ubicaciones.MainView = this.grdv_ubicaciones;
            this.grd_ubicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_ubicaciones.Name = "grd_ubicaciones";
            this.grd_ubicaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnrpt1,
            this.btnrpt2});
            this.grd_ubicaciones.Size = new System.Drawing.Size(698, 367);
            this.grd_ubicaciones.TabIndex = 11;
            this.grd_ubicaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_ubicaciones});
            // 
            // grdv_ubicaciones
            // 
            this.grdv_ubicaciones.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_ubicaciones.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_ubicaciones.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_ubicaciones.Appearance.Row.Options.UseFont = true;
            this.grdv_ubicaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidUb1,
            this.colDescripcion1,
            this.colidUb2,
            this.colDescripcion2,
            this.colDivision,
            this.colver1,
            this.colver2,
            this.colnombre1,
            this.colnombre2,
            this.colCantTM2,
            this.colCantTM1});
            this.grdv_ubicaciones.DetailHeight = 284;
            this.grdv_ubicaciones.GridControl = this.grd_ubicaciones;
            this.grdv_ubicaciones.Name = "grdv_ubicaciones";
            this.grdv_ubicaciones.OptionsView.ShowAutoFilterRow = true;
            this.grdv_ubicaciones.OptionsView.ShowGroupPanel = false;
            // 
            // colidUb1
            // 
            this.colidUb1.FieldName = "idUb1";
            this.colidUb1.MinWidth = 21;
            this.colidUb1.Name = "colidUb1";
            this.colidUb1.Width = 81;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Código Barra";
            this.colDescripcion1.FieldName = "Descripcion1";
            this.colDescripcion1.MinWidth = 21;
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.OptionsColumn.AllowEdit = false;
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 2;
            this.colDescripcion1.Width = 57;
            // 
            // colidUb2
            // 
            this.colidUb2.FieldName = "idUb2";
            this.colidUb2.MinWidth = 21;
            this.colidUb2.Name = "colidUb2";
            this.colidUb2.OptionsColumn.AllowEdit = false;
            this.colidUb2.Width = 81;
            // 
            // colDescripcion2
            // 
            this.colDescripcion2.Caption = "Código Barra";
            this.colDescripcion2.FieldName = "Descripcion2";
            this.colDescripcion2.MinWidth = 21;
            this.colDescripcion2.Name = "colDescripcion2";
            this.colDescripcion2.OptionsColumn.AllowEdit = false;
            this.colDescripcion2.Visible = true;
            this.colDescripcion2.VisibleIndex = 5;
            this.colDescripcion2.Width = 73;
            // 
            // colDivision
            // 
            this.colDivision.AppearanceHeader.Options.UseTextOptions = true;
            this.colDivision.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDivision.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDivision.Caption = " ";
            this.colDivision.FieldName = "Division";
            this.colDivision.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.colDivision.MinWidth = 21;
            this.colDivision.Name = "colDivision";
            this.colDivision.OptionsColumn.AllowEdit = false;
            this.colDivision.Visible = true;
            this.colDivision.VisibleIndex = 4;
            this.colDivision.Width = 52;
            // 
            // colver1
            // 
            this.colver1.Caption = "Detalle";
            this.colver1.ColumnEdit = this.btnrpt1;
            this.colver1.MinWidth = 21;
            this.colver1.Name = "colver1";
            this.colver1.Visible = true;
            this.colver1.VisibleIndex = 0;
            this.colver1.Width = 73;
            // 
            // btnrpt1
            // 
            this.btnrpt1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnrpt1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnrpt1.Name = "btnrpt1";
            this.btnrpt1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnrpt1.Click += new System.EventHandler(this.btnrpt1_Click);
            // 
            // colver2
            // 
            this.colver2.Caption = "Detalle";
            this.colver2.ColumnEdit = this.btnrpt2;
            this.colver2.MinWidth = 21;
            this.colver2.Name = "colver2";
            this.colver2.Visible = true;
            this.colver2.VisibleIndex = 8;
            this.colver2.Width = 80;
            // 
            // btnrpt2
            // 
            this.btnrpt2.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnrpt2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnrpt2.Name = "btnrpt2";
            this.btnrpt2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnrpt2.Click += new System.EventHandler(this.btnrpt2_Click);
            // 
            // colnombre1
            // 
            this.colnombre1.Caption = "UB-Rack Nombre";
            this.colnombre1.FieldName = "nombre1";
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.OptionsColumn.AllowEdit = false;
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 3;
            this.colnombre1.Width = 108;
            // 
            // colnombre2
            // 
            this.colnombre2.Caption = "UB-Rack Nombre";
            this.colnombre2.FieldName = "nombre2";
            this.colnombre2.Name = "colnombre2";
            this.colnombre2.OptionsColumn.AllowEdit = false;
            this.colnombre2.Visible = true;
            this.colnombre2.VisibleIndex = 6;
            this.colnombre2.Width = 114;
            // 
            // colCantTM2
            // 
            this.colCantTM2.Caption = "Cantidad TM";
            this.colCantTM2.FieldName = "CantTM2";
            this.colCantTM2.Name = "colCantTM2";
            this.colCantTM2.OptionsColumn.AllowEdit = false;
            this.colCantTM2.Visible = true;
            this.colCantTM2.VisibleIndex = 7;
            this.colCantTM2.Width = 62;
            // 
            // colCantTM1
            // 
            this.colCantTM1.Caption = "Cantidad TM";
            this.colCantTM1.FieldName = "CantTM1";
            this.colCantTM1.Name = "colCantTM1";
            this.colCantTM1.OptionsColumn.AllowEdit = false;
            this.colCantTM1.Visible = true;
            this.colCantTM1.VisibleIndex = 1;
            this.colCantTM1.Width = 61;
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(552, 2);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(146, 108);
            this.cmdHome.TabIndex = 12;
            this.cmdHome.Text = "Atras";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // rptUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 483);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.grd_ubicaciones);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_bodegas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rptUbicaciones";
            this.Text = "rptUbicaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_bodegas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ubicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ubicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrpt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrpt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit grd_bodegas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grd_ubicaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_ubicaciones;
        private System.Windows.Forms.BindingSource bodegasBindingSource;
        private dsReportes dsReportes;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidUb1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUb2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colDivision;
        private DevExpress.XtraGrid.Columns.GridColumn colver1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnrpt1;
        private DevExpress.XtraGrid.Columns.GridColumn colver2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnrpt2;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantTM2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantTM1;
    }
}