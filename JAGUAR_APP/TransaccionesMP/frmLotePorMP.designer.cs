
namespace JAGUAR_APP.TransaccionesMP
{
    partial class frmLotePorMP
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcLotePorMP = new DevExpress.XtraGrid.GridControl();
            this.gvMP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidadmedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipoIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colunidad_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.lblMP = new DevExpress.XtraEditors.LabelControl();
            this.dsRecepcionMP = new JAGUAR_APP.TransaccionesMP.dsRecepcionMP();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotePorMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLotePorMP
            // 
            this.gcLotePorMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLotePorMP.DataMember = "MP_por_lotes";
            this.gcLotePorMP.DataSource = this.dsRecepcionMP;
            this.gcLotePorMP.Location = new System.Drawing.Point(-5, 69);
            this.gcLotePorMP.MainView = this.gvMP;
            this.gcLotePorMP.Name = "gcLotePorMP";
            this.gcLotePorMP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gcLotePorMP.Size = new System.Drawing.Size(730, 513);
            this.gcLotePorMP.TabIndex = 7;
            this.gcLotePorMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMP});
            // 
            // gvMP
            // 
            this.gvMP.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMP.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMP.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvMP.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMP.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.Row.Options.UseFont = true;
            this.gvMP.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMP.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMP.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_lote,
            this.collote,
            this.colnumero_ingreso,
            this.colid_unidadmedida,
            this.colid_mp,
            this.colid_tipoIngreso,
            this.gridColumn1,
            this.colunidad_medida});
            this.gvMP.CustomizationFormBounds = new System.Drawing.Rectangle(0, 394, 260, 312);
            this.gvMP.GridControl = this.gcLotePorMP;
            this.gvMP.Name = "gvMP";
            this.gvMP.OptionsCustomization.AllowFilter = false;
            this.gvMP.OptionsFilter.AllowFilterEditor = false;
            this.gvMP.OptionsView.ShowAutoFilterRow = true;
            this.gvMP.OptionsView.ShowGroupPanel = false;
            this.gvMP.DoubleClick += new System.EventHandler(this.gvMP_DoubleClick);
            // 
            // colid_lote
            // 
            this.colid_lote.Caption = "Codigo Lote";
            this.colid_lote.FieldName = "lote";
            this.colid_lote.Name = "colid_lote";
            this.colid_lote.OptionsColumn.AllowEdit = false;
            this.colid_lote.Width = 122;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            this.collote.Width = 252;
            // 
            // colnumero_ingreso
            // 
            this.colnumero_ingreso.Caption = "# Ingreso";
            this.colnumero_ingreso.FieldName = "numero_ingreso";
            this.colnumero_ingreso.Name = "colnumero_ingreso";
            this.colnumero_ingreso.OptionsColumn.AllowEdit = false;
            this.colnumero_ingreso.Width = 134;
            // 
            // colid_unidadmedida
            // 
            this.colid_unidadmedida.FieldName = "id_unidadmedida";
            this.colid_unidadmedida.Name = "colid_unidadmedida";
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // colid_tipoIngreso
            // 
            this.colid_tipoIngreso.FieldName = "id_tipoIngreso";
            this.colid_tipoIngreso.Name = "colid_tipoIngreso";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.btnSeleccionar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 117;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::JAGUAR_APP.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSeleccionar_ButtonClick);
            // 
            // colunidad_medida
            // 
            this.colunidad_medida.Caption = "Presentación";
            this.colunidad_medida.FieldName = "presentacion";
            this.colunidad_medida.Name = "colunidad_medida";
            this.colunidad_medida.OptionsColumn.AllowEdit = false;
            this.colunidad_medida.Visible = true;
            this.colunidad_medida.VisibleIndex = 1;
            this.colunidad_medida.Width = 343;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(559, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(149, 51);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblMP
            // 
            this.lblMP.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMP.Appearance.Options.UseFont = true;
            this.lblMP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMP.Location = new System.Drawing.Point(12, 23);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(510, 21);
            this.lblMP.TabIndex = 10;
            this.lblMP.Text = "labelControl1";
            // 
            // dsRecepcionMP
            // 
            this.dsRecepcionMP.DataSetName = "dsRecepcionMP";
            this.dsRecepcionMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmLotePorMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 571);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcLotePorMP);
            this.Name = "frmLotePorMP";
            this.Text = "Lotes por Materia Prima";
            this.Load += new System.EventHandler(this.frmLotePorMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLotePorMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcLotePorMP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMP;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_lote;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidadmedida;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipoIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad_medida;
        private DevExpress.XtraEditors.LabelControl lblMP;
        private dsRecepcionMP dsRecepcionMP;
    }
}