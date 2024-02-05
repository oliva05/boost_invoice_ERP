namespace JAGUAR_APP.Despachos
{
    partial class fromdespacho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromdespacho));
            this.grd_lotes = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new JAGUAR_APP.Despachos.ds_despachos();
            this.grdv_lotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle_requisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_entregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colse_despacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.boletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCardCode = new DevExpress.XtraEditors.TextEdit();
            this.txtCardName = new DevExpress.XtraEditors.TextEdit();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.txtcantidad = new DevExpress.XtraEditors.TextEdit();
            this.txtcantidadEnviar = new DevExpress.XtraEditors.TextEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.btnguardado = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtboleta = new DevExpress.XtraEditors.TextEdit();
            this.btnboleta = new DevExpress.XtraEditors.SimpleButton();
            this.btnactualizar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidadEnviar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboleta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_lotes
            // 
            this.grd_lotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_lotes.DataMember = "lote_entregado";
            this.grd_lotes.DataSource = this.ds_despachos;
            this.grd_lotes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_lotes.Location = new System.Drawing.Point(-1, 257);
            this.grd_lotes.MainView = this.grdv_lotes;
            this.grd_lotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_lotes.Name = "grd_lotes";
            this.grd_lotes.Size = new System.Drawing.Size(700, 227);
            this.grd_lotes.TabIndex = 0;
            this.grd_lotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_lotes});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_lotes
            // 
            this.grdv_lotes.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_lotes.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_lotes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_lotes.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_lotes.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_lotes.Appearance.Row.Options.UseFont = true;
            this.grdv_lotes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_detalle_requisicion,
            this.colcantidad_entregada,
            this.colfecha,
            this.colpresentacion,
            this.colid_tarima,
            this.collote_producto_termiado,
            this.coliduser,
            this.colse_despacho});
            this.grdv_lotes.DetailHeight = 284;
            this.grdv_lotes.GridControl = this.grd_lotes;
            this.grdv_lotes.Name = "grdv_lotes";
            this.grdv_lotes.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 17;
            this.colid.Name = "colid";
            this.colid.Width = 97;
            // 
            // colid_detalle_requisicion
            // 
            this.colid_detalle_requisicion.FieldName = "id_detalle_requisicion";
            this.colid_detalle_requisicion.MinWidth = 17;
            this.colid_detalle_requisicion.Name = "colid_detalle_requisicion";
            this.colid_detalle_requisicion.Width = 64;
            // 
            // colcantidad_entregada
            // 
            this.colcantidad_entregada.Caption = "Entregado";
            this.colcantidad_entregada.FieldName = "cantidad_entregada";
            this.colcantidad_entregada.MinWidth = 17;
            this.colcantidad_entregada.Name = "colcantidad_entregada";
            this.colcantidad_entregada.Visible = true;
            this.colcantidad_entregada.VisibleIndex = 1;
            this.colcantidad_entregada.Width = 120;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha ";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 17;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 92;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.MinWidth = 17;
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 3;
            this.colpresentacion.Width = 92;
            // 
            // colid_tarima
            // 
            this.colid_tarima.Caption = "Tarima";
            this.colid_tarima.FieldName = "id_tarima";
            this.colid_tarima.MinWidth = 17;
            this.colid_tarima.Name = "colid_tarima";
            this.colid_tarima.Width = 92;
            // 
            // collote_producto_termiado
            // 
            this.collote_producto_termiado.Caption = "Lote";
            this.collote_producto_termiado.FieldName = "lote_producto_termiado";
            this.collote_producto_termiado.MinWidth = 17;
            this.collote_producto_termiado.Name = "collote_producto_termiado";
            this.collote_producto_termiado.Visible = true;
            this.collote_producto_termiado.VisibleIndex = 0;
            this.collote_producto_termiado.Width = 99;
            // 
            // coliduser
            // 
            this.coliduser.FieldName = "iduser";
            this.coliduser.MinWidth = 17;
            this.coliduser.Name = "coliduser";
            this.coliduser.Width = 64;
            // 
            // colse_despacho
            // 
            this.colse_despacho.Caption = "Despachado";
            this.colse_despacho.FieldName = "se_despacho";
            this.colse_despacho.MinWidth = 17;
            this.colse_despacho.Name = "colse_despacho";
            this.colse_despacho.Width = 92;
            // 
            // boletaBindingSource
            // 
            this.boletaBindingSource.DataMember = "boleta";
            this.boletaBindingSource.DataSource = this.ds_despachos;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 184);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Boleta:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Cliente:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(28, 86);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Producto:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(28, 117);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 19);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Cantidad Solicitada:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(28, 147);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(129, 19);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Cantidad a enviar:";
            // 
            // txtCardCode
            // 
            this.txtCardCode.Enabled = false;
            this.txtCardCode.Location = new System.Drawing.Point(227, 57);
            this.txtCardCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardCode.Properties.Appearance.Options.UseFont = true;
            this.txtCardCode.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtCardCode.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtCardCode.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtCardCode.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtCardCode.Size = new System.Drawing.Size(86, 26);
            this.txtCardCode.TabIndex = 7;
            // 
            // txtCardName
            // 
            this.txtCardName.Enabled = false;
            this.txtCardName.Location = new System.Drawing.Point(318, 57);
            this.txtCardName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.Properties.Appearance.Options.UseFont = true;
            this.txtCardName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtCardName.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtCardName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtCardName.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtCardName.Size = new System.Drawing.Size(351, 26);
            this.txtCardName.TabIndex = 8;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(318, 86);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Properties.Appearance.Options.UseFont = true;
            this.txtItemName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtItemName.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtItemName.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtItemName.Size = new System.Drawing.Size(351, 26);
            this.txtItemName.TabIndex = 10;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Location = new System.Drawing.Point(227, 86);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtItemCode.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtItemCode.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtItemCode.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtItemCode.Size = new System.Drawing.Size(86, 26);
            this.txtItemCode.TabIndex = 9;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Enabled = false;
            this.txtcantidad.Location = new System.Drawing.Point(227, 115);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Properties.Appearance.Options.UseFont = true;
            this.txtcantidad.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtcantidad.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtcantidad.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtcantidad.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcantidad.Size = new System.Drawing.Size(441, 26);
            this.txtcantidad.TabIndex = 11;
            // 
            // txtcantidadEnviar
            // 
            this.txtcantidadEnviar.Enabled = false;
            this.txtcantidadEnviar.Location = new System.Drawing.Point(227, 145);
            this.txtcantidadEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidadEnviar.Name = "txtcantidadEnviar";
            this.txtcantidadEnviar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadEnviar.Properties.Appearance.Options.UseFont = true;
            this.txtcantidadEnviar.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtcantidadEnviar.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtcantidadEnviar.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtcantidadEnviar.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcantidadEnviar.Size = new System.Drawing.Size(248, 26);
            this.txtcantidadEnviar.TabIndex = 12;
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
            this.btnAtras.Location = new System.Drawing.Point(561, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(129, 46);
            this.btnAtras.TabIndex = 38;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnguardado
            // 
            this.btnguardado.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnguardado.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardado.Appearance.Options.UseBackColor = true;
            this.btnguardado.Appearance.Options.UseFont = true;
            this.btnguardado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnguardado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguardado.ImageOptions.Image")));
            this.btnguardado.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnguardado.Location = new System.Drawing.Point(11, 6);
            this.btnguardado.Name = "btnguardado";
            this.btnguardado.Size = new System.Drawing.Size(123, 45);
            this.btnguardado.TabIndex = 49;
            this.btnguardado.Text = "Guardar";
            this.btnguardado.Click += new System.EventHandler(this.btnguardado_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(152, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(389, 40);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "Orden de Carga";
            // 
            // txtboleta
            // 
            this.txtboleta.Enabled = false;
            this.txtboleta.Location = new System.Drawing.Point(227, 181);
            this.txtboleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboleta.Name = "txtboleta";
            this.txtboleta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboleta.Properties.Appearance.Options.UseFont = true;
            this.txtboleta.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtboleta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtboleta.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtboleta.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtboleta.Size = new System.Drawing.Size(248, 26);
            this.txtboleta.TabIndex = 51;
            // 
            // btnboleta
            // 
            this.btnboleta.Appearance.BackColor = System.Drawing.Color.White;
            this.btnboleta.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboleta.Appearance.Options.UseBackColor = true;
            this.btnboleta.Appearance.Options.UseFont = true;
            this.btnboleta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnboleta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnboleta.ImageOptions.Image")));
            this.btnboleta.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnboleta.Location = new System.Drawing.Point(492, 184);
            this.btnboleta.Name = "btnboleta";
            this.btnboleta.Size = new System.Drawing.Size(177, 37);
            this.btnboleta.TabIndex = 52;
            this.btnboleta.Text = "Buscar ";
            this.btnboleta.Click += new System.EventHandler(this.btnboleta_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnactualizar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Appearance.Options.UseBackColor = true;
            this.btnactualizar.Appearance.Options.UseFont = true;
            this.btnactualizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnactualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.ImageOptions.Image")));
            this.btnactualizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnactualizar.Location = new System.Drawing.Point(492, 145);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(177, 32);
            this.btnactualizar.TabIndex = 53;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // fromdespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 483);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnboleta);
            this.Controls.Add(this.txtboleta);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnguardado);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtcantidadEnviar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.txtCardCode);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_lotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fromdespacho";
            this.Text = "fromdespacho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fromdespacho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_lotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidadEnviar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboleta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_lotes;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_lotes;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_requisicion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_entregada;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn coliduser;
        private DevExpress.XtraGrid.Columns.GridColumn colse_despacho;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_termiado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCardCode;
        private DevExpress.XtraEditors.TextEdit txtCardName;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.TextEdit txtcantidad;
        private DevExpress.XtraEditors.TextEdit txtcantidadEnviar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private System.Windows.Forms.BindingSource boletaBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnguardado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtboleta;
        private DevExpress.XtraEditors.SimpleButton btnboleta;
        private DevExpress.XtraEditors.SimpleButton btnactualizar;
    }
}