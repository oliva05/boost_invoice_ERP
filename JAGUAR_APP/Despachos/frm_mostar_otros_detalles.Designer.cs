namespace JAGUAR_APP.Despachos
{
    partial class frm_mostar_otros_detalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mostar_otros_detalles));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnatras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.plandespachoBindingSource = new System.Windows.Forms.BindingSource();
            this.ds_despachos = new JAGUAR_APP.Despachos.ds_despachos();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidventa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDscription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityTm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_Sacos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_Peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_plafinificada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_selected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliddetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnviado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrestante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colutilizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plandespachoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnatras
            // 
            this.btnatras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnatras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnatras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Appearance.Options.UseBackColor = true;
            this.btnatras.Appearance.Options.UseFont = true;
            this.btnatras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnatras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.ImageOptions.Image")));
            this.btnatras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnatras.Location = new System.Drawing.Point(618, 3);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(109, 44);
            this.btnatras.TabIndex = 48;
            this.btnatras.Text = "Atras";
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(148, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(398, 40);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Productos para esta orden";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.plandespachoBindingSource;
            this.grd_data.Location = new System.Drawing.Point(0, 119);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.grd_data.Size = new System.Drawing.Size(727, 441);
            this.grd_data.TabIndex = 50;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // plandespachoBindingSource
            // 
            this.plandespachoBindingSource.DataMember = "plan_despacho";
            this.plandespachoBindingSource.DataSource = this.ds_despachos;
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colidventa,
            this.colCardCode,
            this.colCardName,
            this.colDocNum,
            this.colItemCode,
            this.colDscription,
            this.colQuantityTm,
            this.colQuantityKg,
            this.colU_Sacos,
            this.colU_Peso,
            this.coldate_plafinificada,
            this.colprioridad,
            this.colcant_selected,
            this.coliddetalle,
            this.colEnviado,
            this.colrestante,
            this.colutilizar});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.DoubleClick += new System.EventHandler(this.grdv_data_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colidventa
            // 
            this.colidventa.FieldName = "idventa";
            this.colidventa.Name = "colidventa";
            // 
            // colCardCode
            // 
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            // 
            // colCardName
            // 
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Codigo";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // colDscription
            // 
            this.colDscription.Caption = "Producto";
            this.colDscription.FieldName = "Dscription";
            this.colDscription.Name = "colDscription";
            this.colDscription.OptionsColumn.AllowEdit = false;
            this.colDscription.Visible = true;
            this.colDscription.VisibleIndex = 1;
            // 
            // colQuantityTm
            // 
            this.colQuantityTm.FieldName = "QuantityTm";
            this.colQuantityTm.Name = "colQuantityTm";
            // 
            // colQuantityKg
            // 
            this.colQuantityKg.Caption = "Cantidad Kg";
            this.colQuantityKg.FieldName = "QuantityKg";
            this.colQuantityKg.Name = "colQuantityKg";
            this.colQuantityKg.OptionsColumn.AllowEdit = false;
            this.colQuantityKg.Visible = true;
            this.colQuantityKg.VisibleIndex = 2;
            // 
            // colU_Sacos
            // 
            this.colU_Sacos.Caption = "Ud.";
            this.colU_Sacos.FieldName = "U_Sacos";
            this.colU_Sacos.Name = "colU_Sacos";
            this.colU_Sacos.OptionsColumn.AllowEdit = false;
            this.colU_Sacos.Visible = true;
            this.colU_Sacos.VisibleIndex = 3;
            // 
            // colU_Peso
            // 
            this.colU_Peso.Caption = "Presentacion";
            this.colU_Peso.FieldName = "U_Peso";
            this.colU_Peso.Name = "colU_Peso";
            this.colU_Peso.OptionsColumn.AllowEdit = false;
            this.colU_Peso.Visible = true;
            this.colU_Peso.VisibleIndex = 4;
            // 
            // coldate_plafinificada
            // 
            this.coldate_plafinificada.FieldName = "date_plafinificada";
            this.coldate_plafinificada.Name = "coldate_plafinificada";
            // 
            // colprioridad
            // 
            this.colprioridad.FieldName = "prioridad";
            this.colprioridad.Name = "colprioridad";
            // 
            // colcant_selected
            // 
            this.colcant_selected.Caption = "Planificado";
            this.colcant_selected.FieldName = "cant_selected";
            this.colcant_selected.Name = "colcant_selected";
            this.colcant_selected.OptionsColumn.AllowEdit = false;
            this.colcant_selected.Visible = true;
            this.colcant_selected.VisibleIndex = 5;
            // 
            // coliddetalle
            // 
            this.coliddetalle.FieldName = "iddetalle";
            this.coliddetalle.Name = "coliddetalle";
            // 
            // colEnviado
            // 
            this.colEnviado.Caption = "Enviado";
            this.colEnviado.FieldName = "Enviado";
            this.colEnviado.Name = "colEnviado";
            this.colEnviado.Visible = true;
            this.colEnviado.VisibleIndex = 6;
            // 
            // colrestante
            // 
            this.colrestante.Caption = "Pendiente";
            this.colrestante.FieldName = "restante";
            this.colrestante.Name = "colrestante";
            this.colrestante.OptionsColumn.AllowEdit = false;
            this.colrestante.Visible = true;
            this.colrestante.VisibleIndex = 7;
            // 
            // colutilizar
            // 
            this.colutilizar.Caption = "Utilizar";
            this.colutilizar.ColumnEdit = this.btnSeleccionar;
            this.colutilizar.Name = "colutilizar";
            this.colutilizar.Visible = true;
            this.colutilizar.VisibleIndex = 8;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::JAGUAR_APP.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frm_mostar_otros_detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 560);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnatras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_mostar_otros_detalles";
            this.Text = "frm_mostar_otros_detalles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plandespachoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnatras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private System.Windows.Forms.BindingSource plandespachoBindingSource;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colidventa;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDscription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityTm;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityKg;
        private DevExpress.XtraGrid.Columns.GridColumn colU_Sacos;
        private DevExpress.XtraGrid.Columns.GridColumn colU_Peso;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_plafinificada;
        private DevExpress.XtraGrid.Columns.GridColumn colprioridad;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_selected;
        private DevExpress.XtraGrid.Columns.GridColumn coliddetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colEnviado;
        private DevExpress.XtraGrid.Columns.GridColumn colrestante;
        private DevExpress.XtraGrid.Columns.GridColumn colutilizar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
    }
}