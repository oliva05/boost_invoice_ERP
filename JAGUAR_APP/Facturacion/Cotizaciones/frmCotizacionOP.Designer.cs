
namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    partial class frmCotizacionOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizacionOP));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFactCotizacion1 = new JAGUAR_APP.Facturacion.Cotizaciones.dsFactCotizacion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio_original = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento_unitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio_unitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.cmdAbrirBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelec = new DevExpress.XtraEditors.SimpleButton();
            this.cmdFacturar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumCoti = new DevExpress.XtraEditors.TextEdit();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtSubTotalBruto = new DevExpress.XtraEditors.TextEdit();
            this.txtISV = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtDescuento = new DevExpress.XtraEditors.TextEdit();
            this.txtSubTotalNeto = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtContacto = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactCotizacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCoti.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotalBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotalNeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_cotizacion";
            this.gridControl1.DataSource = this.dsFactCotizacion1;
            this.gridControl1.Location = new System.Drawing.Point(2, 186);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposDelete});
            this.gridControl1.Size = new System.Drawing.Size(1226, 400);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsFactCotizacion1
            // 
            this.dsFactCotizacion1.DataSetName = "dsFactCotizacion";
            this.dsFactCotizacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_h,
            this.colcodigo,
            this.coldescripcion,
            this.colcantidad,
            this.colprecio_original,
            this.coldescuento_unitario,
            this.colprecio_unitario,
            this.colDataColumn3,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            this.colid_h.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 200;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 200;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            this.colcantidad.Width = 200;
            // 
            // colprecio_original
            // 
            this.colprecio_original.Caption = "Precio Unitario";
            this.colprecio_original.DisplayFormat.FormatString = "n2";
            this.colprecio_original.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio_original.FieldName = "precio_original";
            this.colprecio_original.Name = "colprecio_original";
            this.colprecio_original.Visible = true;
            this.colprecio_original.VisibleIndex = 3;
            this.colprecio_original.Width = 200;
            // 
            // coldescuento_unitario
            // 
            this.coldescuento_unitario.Caption = "Descuento";
            this.coldescuento_unitario.DisplayFormat.FormatString = "n2";
            this.coldescuento_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento_unitario.FieldName = "descuento_unitario";
            this.coldescuento_unitario.Name = "coldescuento_unitario";
            // 
            // colprecio_unitario
            // 
            this.colprecio_unitario.Caption = "Impuesto";
            this.colprecio_unitario.DisplayFormat.FormatString = "n2";
            this.colprecio_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio_unitario.FieldName = "isv";
            this.colprecio_unitario.Name = "colprecio_unitario";
            this.colprecio_unitario.OptionsColumn.ReadOnly = true;
            this.colprecio_unitario.Visible = true;
            this.colprecio_unitario.VisibleIndex = 4;
            this.colprecio_unitario.Width = 211;
            // 
            // colDataColumn3
            // 
            this.colDataColumn3.Caption = "Total";
            this.colDataColumn3.DisplayFormat.FormatString = "n2";
            this.colDataColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDataColumn3.FieldName = "total";
            this.colDataColumn3.Name = "colDataColumn3";
            this.colDataColumn3.OptionsColumn.AllowEdit = false;
            this.colDataColumn3.OptionsColumn.ReadOnly = true;
            this.colDataColumn3.Visible = true;
            this.colDataColumn3.VisibleIndex = 5;
            this.colDataColumn3.Width = 190;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.reposDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // reposDelete
            // 
            this.reposDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.reposDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposDelete.Name = "reposDelete";
            this.reposDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposDelete_ButtonClick);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(89, 108);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.NullValuePrompt = "Direcci del Cliente";
            this.txtDireccion.Size = new System.Drawing.Size(346, 26);
            this.txtDireccion.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(2, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Dirección";
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(89, 76);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.NullValuePrompt = "RTN Cliente";
            this.txtRTN.Size = new System.Drawing.Size(346, 26);
            this.txtRTN.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(2, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "RTN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(89, 44);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreCliente.Properties.Appearance.Options.UseFont = true;
            this.txtNombreCliente.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(346, 26);
            this.txtNombreCliente.TabIndex = 37;
            // 
            // cmdAbrirBusqueda
            // 
            this.cmdAbrirBusqueda.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.cmdAbrirBusqueda.Appearance.Options.UseFont = true;
            this.cmdAbrirBusqueda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAbrirBusqueda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbrirBusqueda.ImageOptions.Image")));
            this.cmdAbrirBusqueda.Location = new System.Drawing.Point(441, 40);
            this.cmdAbrirBusqueda.Name = "cmdAbrirBusqueda";
            this.cmdAbrirBusqueda.Size = new System.Drawing.Size(146, 34);
            this.cmdAbrirBusqueda.TabIndex = 43;
            this.cmdAbrirBusqueda.Text = "&Buscar Cliente";
            this.cmdAbrirBusqueda.Click += new System.EventHandler(this.cmdAbrirBusqueda_Click);
            // 
            // btnSelec
            // 
            this.btnSelec.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnSelec.Appearance.Options.UseFont = true;
            this.btnSelec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSelec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelec.ImageOptions.Image")));
            this.btnSelec.Location = new System.Drawing.Point(9, 150);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(159, 33);
            this.btnSelec.TabIndex = 44;
            this.btnSelec.Text = "&Buscar Producto";
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // cmdFacturar
            // 
            this.cmdFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFacturar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFacturar.Appearance.Options.UseFont = true;
            this.cmdFacturar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdFacturar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdFacturar.ImageOptions.Image")));
            this.cmdFacturar.Location = new System.Drawing.Point(403, 700);
            this.cmdFacturar.Name = "cmdFacturar";
            this.cmdFacturar.Size = new System.Drawing.Size(143, 38);
            this.cmdFacturar.TabIndex = 45;
            this.cmdFacturar.Text = "Guardar";
            this.cmdFacturar.Click += new System.EventHandler(this.cmdFacturar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(618, 700);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(143, 38);
            this.cmdSalir.TabIndex = 46;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(962, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Sub-Total Bruto:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(962, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Descuento:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(962, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Sub-Total Neto:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(962, 691);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "ISV:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(962, 724);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(2, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Cotizacion";
            // 
            // txtNumCoti
            // 
            this.txtNumCoti.Enabled = false;
            this.txtNumCoti.Location = new System.Drawing.Point(89, 12);
            this.txtNumCoti.Name = "txtNumCoti";
            this.txtNumCoti.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtNumCoti.Properties.Appearance.Options.UseFont = true;
            this.txtNumCoti.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtNumCoti.Size = new System.Drawing.Size(101, 26);
            this.txtNumCoti.TabIndex = 58;
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.ImageOptions.Image")));
            this.cmdNew.Location = new System.Drawing.Point(39, 700);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(143, 38);
            this.cmdNew.TabIndex = 59;
            this.cmdNew.Text = "&Nuevo";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(655, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(739, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.NullValuePrompt = "E-Mail Cliente";
            this.txtEmail.Size = new System.Drawing.Size(220, 26);
            this.txtEmail.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(655, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "Telefono ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(739, 76);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.NullValuePrompt = "Telefono";
            this.txtTelefono.Size = new System.Drawing.Size(220, 26);
            this.txtTelefono.TabIndex = 63;
            // 
            // txtSubTotalBruto
            // 
            this.txtSubTotalBruto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubTotalBruto.EditValue = "0.00";
            this.txtSubTotalBruto.Enabled = false;
            this.txtSubTotalBruto.Location = new System.Drawing.Point(1100, 592);
            this.txtSubTotalBruto.Name = "txtSubTotalBruto";
            this.txtSubTotalBruto.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSubTotalBruto.Properties.Appearance.Options.UseFont = true;
            this.txtSubTotalBruto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubTotalBruto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubTotalBruto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubTotalBruto.Properties.MaskSettings.Set("mask", "n");
            this.txtSubTotalBruto.Properties.NullText = "0.00";
            this.txtSubTotalBruto.Properties.UseMaskAsDisplayFormat = true;
            this.txtSubTotalBruto.Size = new System.Drawing.Size(119, 26);
            this.txtSubTotalBruto.TabIndex = 80;
            // 
            // txtISV
            // 
            this.txtISV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtISV.EditValue = "0.00";
            this.txtISV.Enabled = false;
            this.txtISV.Location = new System.Drawing.Point(1100, 688);
            this.txtISV.Name = "txtISV";
            this.txtISV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtISV.Properties.Appearance.Options.UseFont = true;
            this.txtISV.Properties.Appearance.Options.UseTextOptions = true;
            this.txtISV.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtISV.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtISV.Properties.MaskSettings.Set("mask", "n");
            this.txtISV.Properties.NullText = "0.00";
            this.txtISV.Properties.UseMaskAsDisplayFormat = true;
            this.txtISV.Size = new System.Drawing.Size(119, 26);
            this.txtISV.TabIndex = 81;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.EditValue = "0.00";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1100, 721);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("mask", "n");
            this.txtTotal.Properties.NullText = "0.00";
            this.txtTotal.Properties.UseMaskAsDisplayFormat = true;
            this.txtTotal.Size = new System.Drawing.Size(119, 26);
            this.txtTotal.TabIndex = 82;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescuento.EditValue = "0.00";
            this.txtDescuento.Location = new System.Drawing.Point(1100, 624);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDescuento.Properties.Appearance.Options.UseFont = true;
            this.txtDescuento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDescuento.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDescuento.Properties.MaskSettings.Set("mask", "n");
            this.txtDescuento.Properties.NullText = "0.00";
            this.txtDescuento.Properties.UseMaskAsDisplayFormat = true;
            this.txtDescuento.Size = new System.Drawing.Size(119, 26);
            this.txtDescuento.TabIndex = 83;
            this.txtDescuento.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtDescuento_EditValueChanging);
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtSubTotalNeto
            // 
            this.txtSubTotalNeto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubTotalNeto.EditValue = "0.00";
            this.txtSubTotalNeto.Enabled = false;
            this.txtSubTotalNeto.Location = new System.Drawing.Point(1100, 656);
            this.txtSubTotalNeto.Name = "txtSubTotalNeto";
            this.txtSubTotalNeto.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSubTotalNeto.Properties.Appearance.Options.UseFont = true;
            this.txtSubTotalNeto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubTotalNeto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubTotalNeto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubTotalNeto.Properties.MaskSettings.Set("mask", "n");
            this.txtSubTotalNeto.Properties.NullText = "0.00";
            this.txtSubTotalNeto.Properties.UseMaskAsDisplayFormat = true;
            this.txtSubTotalNeto.Size = new System.Drawing.Size(119, 26);
            this.txtSubTotalNeto.TabIndex = 84;
            // 
            // dtFechaRegistro
            // 
            this.dtFechaRegistro.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRegistro.Location = new System.Drawing.Point(739, 11);
            this.dtFechaRegistro.Name = "dtFechaRegistro";
            this.dtFechaRegistro.Size = new System.Drawing.Size(189, 27);
            this.dtFechaRegistro.TabIndex = 85;
            this.dtFechaRegistro.ValueChanged += new System.EventHandler(this.dtFechaRegistro_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label12.Location = new System.Drawing.Point(655, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 86;
            this.label12.Text = "Fecha ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.Location = new System.Drawing.Point(655, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 88;
            this.label13.Text = "Fecha ";
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(739, 43);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(189, 27);
            this.dtFechaVencimiento.TabIndex = 87;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(739, 140);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtContacto.Properties.Appearance.Options.UseFont = true;
            this.txtContacto.Properties.NullValuePrompt = "E-Mail Cliente";
            this.txtContacto.Size = new System.Drawing.Size(220, 26);
            this.txtContacto.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(655, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 90;
            this.label14.Text = "Contacto";
            // 
            // frmCotizacionOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 777);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtFechaVencimiento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtFechaRegistro);
            this.Controls.Add(this.txtSubTotalNeto);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtISV);
            this.Controls.Add(this.txtSubTotalBruto);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.txtNumCoti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdFacturar);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.cmdAbrirBusqueda);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCotizacionOP";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactCotizacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCoti.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotalBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotalNeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.SimpleButton cmdAbrirBusqueda;
        private DevExpress.XtraEditors.SimpleButton btnSelec;
        private DevExpress.XtraEditors.SimpleButton cmdFacturar;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        //private dsCotizaciones dsCotizaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio_original;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento_unitario;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio_unitario;
        private DevExpress.XtraGrid.Columns.GridColumn colDataColumn3;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtNumCoti;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtSubTotalBruto;
        private DevExpress.XtraEditors.TextEdit txtISV;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtDescuento;
        private DevExpress.XtraEditors.TextEdit txtSubTotalNeto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDelete;
        private dsFactCotizacion dsFactCotizacion1;
        private System.Windows.Forms.DateTimePicker dtFechaRegistro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        private DevExpress.XtraEditors.TextEdit txtContacto;
        private System.Windows.Forms.Label label14;
    }
}