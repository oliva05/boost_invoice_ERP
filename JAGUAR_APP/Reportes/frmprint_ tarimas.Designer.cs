namespace JAGUAR_APP.Reportes
{
    partial class frmprint__tarimas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprint__tarimas));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_tarimas = new DevExpress.XtraGrid.GridControl();
            this.dsReportes = new JAGUAR_APP.Reportes.dsReportes();
            this.grdv_tarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnprint_only1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.conImprimirIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrintIngreso = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTodas = new DevExpress.XtraEditors.SimpleButton();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_tarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_tarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint_only1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_tarimas
            // 
            this.grd_tarimas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_tarimas.DataMember = "tmprint";
            this.grd_tarimas.DataSource = this.dsReportes;
            this.grd_tarimas.Location = new System.Drawing.Point(-1, 136);
            this.grd_tarimas.MainView = this.grdv_tarimas;
            this.grd_tarimas.Name = "grd_tarimas";
            this.grd_tarimas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnprint_only1,
            this.btnPrintIngreso});
            this.grd_tarimas.Size = new System.Drawing.Size(834, 507);
            this.grd_tarimas.TabIndex = 0;
            this.grd_tarimas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_tarimas});
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "dsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_tarimas
            // 
            this.grdv_tarimas.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.grdv_tarimas.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_tarimas.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.grdv_tarimas.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_tarimas.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.grdv_tarimas.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_tarimas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_tarimas.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_tarimas.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.grdv_tarimas.Appearance.Row.Options.UseFont = true;
            this.grdv_tarimas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colmaterial,
            this.colfecha_ingreso,
            this.colnumero_transaccion,
            this.collote,
            this.colfecha_vencimiento,
            this.colcodigo_barra,
            this.colcantidad,
            this.colpresentacion,
            this.colprint,
            this.conImprimirIngreso});
            this.grdv_tarimas.GridControl = this.grd_tarimas;
            this.grdv_tarimas.Name = "grdv_tarimas";
            this.grdv_tarimas.OptionsView.ShowAutoFilterRow = true;
            this.grdv_tarimas.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 94;
            // 
            // colmaterial
            // 
            this.colmaterial.Caption = "Materia Prima";
            this.colmaterial.FieldName = "material";
            this.colmaterial.MinWidth = 25;
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.OptionsColumn.AllowEdit = false;
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 1;
            this.colmaterial.Width = 81;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "Ingreso #";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.MinWidth = 25;
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 3;
            this.colnumero_transaccion.Width = 110;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.MinWidth = 25;
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 4;
            this.collote.Width = 79;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.MinWidth = 25;
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 5;
            this.colfecha_vencimiento.Width = 92;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Codigo";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.MinWidth = 25;
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 0;
            this.colcodigo_barra.Width = 81;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Unidades";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 25;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            this.colcantidad.Width = 54;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.MinWidth = 25;
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 7;
            this.colpresentacion.Width = 54;
            // 
            // colprint
            // 
            this.colprint.Caption = "Imprimir";
            this.colprint.ColumnEdit = this.btnprint_only1;
            this.colprint.MinWidth = 25;
            this.colprint.Name = "colprint";
            this.colprint.Visible = true;
            this.colprint.VisibleIndex = 8;
            this.colprint.Width = 54;
            // 
            // btnprint_only1
            // 
            this.btnprint_only1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnprint_only1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnprint_only1.Name = "btnprint_only1";
            this.btnprint_only1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnprint_only1.Click += new System.EventHandler(this.btnprint_only1_Click);
            // 
            // conImprimirIngreso
            // 
            this.conImprimirIngreso.Caption = "Imprimir Ingreso";
            this.conImprimirIngreso.ColumnEdit = this.btnPrintIngreso;
            this.conImprimirIngreso.MinWidth = 25;
            this.conImprimirIngreso.Name = "conImprimirIngreso";
            this.conImprimirIngreso.Visible = true;
            this.conImprimirIngreso.VisibleIndex = 9;
            this.conImprimirIngreso.Width = 65;
            // 
            // btnPrintIngreso
            // 
            this.btnPrintIngreso.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnPrintIngreso.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnPrintIngreso.Name = "btnPrintIngreso";
            this.btnPrintIngreso.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnPrintIngreso.Click += new System.EventHandler(this.btnPrintIngreso_Click);
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
            this.cmdHome.Location = new System.Drawing.Point(572, 13);
            this.cmdHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(249, 87);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Atras";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(793, 62);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Impresion de Tarimas";
            // 
            // btnTodas
            // 
            this.btnTodas.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodas.Appearance.Options.UseFont = true;
            this.btnTodas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTodas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTodas.ImageOptions.Image")));
            this.btnTodas.Location = new System.Drawing.Point(12, 21);
            this.btnTodas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(233, 87);
            this.btnTodas.TabIndex = 12;
            this.btnTodas.Text = "Imprimir todas\r\n   las tarimas";
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha de Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.MinWidth = 25;
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 2;
            this.colfecha_ingreso.Width = 144;
            // 
            // frmprint__tarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 642);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_tarimas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmprint__tarimas";
            this.Text = "frmprint__tarimas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_tarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_tarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint_only1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_tarimas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_tarimas;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTodas;
        private dsReportes dsReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colprint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnprint_only1;
        private DevExpress.XtraGrid.Columns.GridColumn conImprimirIngreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPrintIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
    }
}