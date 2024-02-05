namespace JAGUAR_APP.Despachos
{
    partial class frm_Reqresumen_pt
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reqresumen_pt));
            this.grd_reqPT = new DevExpress.XtraGrid.GridControl();
            this.grdv_reqPT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_solicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_a_producir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnver = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ds_despachos = new JAGUAR_APP.Despachos.ds_despachos();
            ((System.ComponentModel.ISupportInitialize)(this.grd_reqPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_reqPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_reqPT
            // 
            this.grd_reqPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_reqPT.DataMember = "requisiciones_h";
            this.grd_reqPT.DataSource = this.ds_despachos;
            this.grd_reqPT.Location = new System.Drawing.Point(1, 98);
            this.grd_reqPT.MainView = this.grdv_reqPT;
            this.grd_reqPT.Name = "grd_reqPT";
            this.grd_reqPT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnver});
            this.grd_reqPT.Size = new System.Drawing.Size(831, 546);
            this.grd_reqPT.TabIndex = 0;
            this.grd_reqPT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_reqPT});
            // 
            // grdv_reqPT
            // 
            this.grdv_reqPT.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_reqPT.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdv_reqPT.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_reqPT.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.grdv_reqPT.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_reqPT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdv_reqPT.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_reqPT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_reqPT.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_reqPT.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_reqPT.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdv_reqPT.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_reqPT.Appearance.Row.Options.UseFont = true;
            this.grdv_reqPT.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_reqPT.Appearance.SelectedRow.Options.UseFont = true;
            this.grdv_reqPT.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grdv_reqPT.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grdv_reqPT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_usuario,
            this.coluser_,
            this.colid_orden,
            this.colfecha_solicitada,
            this.colfecha_a_producir,
            this.colid_estado,
            this.colestado,
            this.colDocEntry,
            this.gridColumn1,
            this.colcomentario});
            this.grdv_reqPT.GridControl = this.grd_reqPT;
            this.grdv_reqPT.Name = "grdv_reqPT";
            this.grdv_reqPT.OptionsCustomization.AllowFilter = false;
            this.grdv_reqPT.OptionsView.ShowAutoFilterRow = true;
            this.grdv_reqPT.OptionsView.ShowFooter = true;
            this.grdv_reqPT.OptionsView.ShowGroupPanel = false;
            this.grdv_reqPT.RowHeight = 20;
            // 
            // colid
            // 
            this.colid.Caption = "Num.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 65;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.AllowEdit = false;
            // 
            // coluser_
            // 
            this.coluser_.Caption = "Usuario";
            this.coluser_.FieldName = "user_";
            this.coluser_.Name = "coluser_";
            this.coluser_.OptionsColumn.AllowEdit = false;
            this.coluser_.Visible = true;
            this.coluser_.VisibleIndex = 1;
            this.coluser_.Width = 85;
            // 
            // colid_orden
            // 
            this.colid_orden.FieldName = "id_orden";
            this.colid_orden.Name = "colid_orden";
            // 
            // colfecha_solicitada
            // 
            this.colfecha_solicitada.Caption = "Fecha";
            this.colfecha_solicitada.FieldName = "fecha_solicitada";
            this.colfecha_solicitada.Name = "colfecha_solicitada";
            this.colfecha_solicitada.OptionsColumn.AllowEdit = false;
            this.colfecha_solicitada.Visible = true;
            this.colfecha_solicitada.VisibleIndex = 2;
            this.colfecha_solicitada.Width = 85;
            // 
            // colfecha_a_producir
            // 
            this.colfecha_a_producir.Caption = "Fecha a Producir";
            this.colfecha_a_producir.FieldName = "fecha_a_producir";
            this.colfecha_a_producir.Name = "colfecha_a_producir";
            this.colfecha_a_producir.Width = 85;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 3;
            this.colestado.Width = 85;
            // 
            // colDocEntry
            // 
            this.colDocEntry.Caption = "DocEntry SAP";
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.OptionsColumn.AllowEdit = false;
            this.colDocEntry.Width = 90;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver";
            this.gridColumn1.ColumnEdit = this.btnver;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 43;
            // 
            // btnver
            // 
            this.btnver.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnver.Name = "btnver";
            this.btnver.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 4;
            this.colcomentario.Width = 79;
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
            this.btnAtras.Location = new System.Drawing.Point(623, 13);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(197, 58);
            this.btnAtras.TabIndex = 34;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            this.labelControl1.Location = new System.Drawing.Point(126, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(464, 49);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Requisiciones PT";
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_Reqresumen_pt
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 642);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.grd_reqPT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Reqresumen_pt";
            this.Text = "frm_Reqresumen_pt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_reqPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_reqPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_reqPT;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_reqPT;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_solicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_a_producir;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnver;
        private ds_despachos ds_despachos;
    }
}