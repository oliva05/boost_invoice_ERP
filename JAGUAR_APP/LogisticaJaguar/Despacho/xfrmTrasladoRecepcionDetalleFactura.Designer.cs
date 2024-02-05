
namespace JAGUAR_APP.LogisticaJaguar.Despacho
{
    partial class xfrmTrasladoRecepcionDetalleFactura
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmTrasladoRecepcionDetalleFactura));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem_code1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_ingresada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsDespacho1 = new JAGUAR_APP.LogisticaJaguar.Despacho.dsDespacho();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_recepcionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregar_todo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_a_entregar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumFactura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCopiarDesdeFactura = new DevExpress.XtraEditors.SimpleButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtClienteNombre = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespacho1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colid_detalle_factura,
            this.colitem_code1,
            this.coldescripcion1,
            this.colcantidad_ingresada,
            this.colid_user,
            this.colusuario,
            this.colfecha});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colid_detalle_factura
            // 
            this.colid_detalle_factura.FieldName = "id_detalle_factura";
            this.colid_detalle_factura.Name = "colid_detalle_factura";
            // 
            // colitem_code1
            // 
            this.colitem_code1.Caption = "Item Code";
            this.colitem_code1.FieldName = "item_code";
            this.colitem_code1.Name = "colitem_code1";
            this.colitem_code1.OptionsColumn.ReadOnly = true;
            this.colitem_code1.Visible = true;
            this.colitem_code1.VisibleIndex = 0;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Item Name";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.OptionsColumn.ReadOnly = true;
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 1;
            // 
            // colcantidad_ingresada
            // 
            this.colcantidad_ingresada.Caption = "Cant Ingresada";
            this.colcantidad_ingresada.DisplayFormat.FormatString = "n2";
            this.colcantidad_ingresada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_ingresada.FieldName = "cantidad_ingresada";
            this.colcantidad_ingresada.Name = "colcantidad_ingresada";
            this.colcantidad_ingresada.OptionsColumn.ReadOnly = true;
            this.colcantidad_ingresada.Visible = true;
            this.colcantidad_ingresada.VisibleIndex = 2;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.ReadOnly = true;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 3;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_factura";
            this.gridControl1.DataSource = this.dsDespacho1;
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "detalle_factura_detalle_transacciones";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(7, 108);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(968, 373);
            this.gridControl1.TabIndex = 63;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // dsDespacho1
            // 
            this.dsDespacho1.DataSetName = "dsDespacho";
            this.dsDespacho1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_pt,
            this.colitem_code,
            this.coldescripcion,
            this.colcantidad,
            this.colcant_recepcionado,
            this.colentregar_todo,
            this.colcant_a_entregar,
            this.coldiferencia});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            // 
            // colitem_code
            // 
            this.colitem_code.FieldName = "item_code";
            this.colitem_code.Name = "colitem_code";
            this.colitem_code.OptionsColumn.ReadOnly = true;
            this.colitem_code.Visible = true;
            this.colitem_code.VisibleIndex = 0;
            this.colitem_code.Width = 103;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 271;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.ReadOnly = true;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            this.colcantidad.Width = 129;
            // 
            // colcant_recepcionado
            // 
            this.colcant_recepcionado.FieldName = "cant_recepcionado";
            this.colcant_recepcionado.Name = "colcant_recepcionado";
            this.colcant_recepcionado.OptionsColumn.ReadOnly = true;
            this.colcant_recepcionado.Visible = true;
            this.colcant_recepcionado.VisibleIndex = 3;
            this.colcant_recepcionado.Width = 129;
            // 
            // colentregar_todo
            // 
            this.colentregar_todo.FieldName = "entregar_todo";
            this.colentregar_todo.Name = "colentregar_todo";
            this.colentregar_todo.Visible = true;
            this.colentregar_todo.VisibleIndex = 6;
            this.colentregar_todo.Width = 106;
            // 
            // colcant_a_entregar
            // 
            this.colcant_a_entregar.FieldName = "cant_a_entregar";
            this.colcant_a_entregar.Name = "colcant_a_entregar";
            this.colcant_a_entregar.Visible = true;
            this.colcant_a_entregar.VisibleIndex = 4;
            this.colcant_a_entregar.Width = 129;
            // 
            // coldiferencia
            // 
            this.coldiferencia.FieldName = "diferencia";
            this.coldiferencia.Name = "coldiferencia";
            this.coldiferencia.OptionsColumn.ReadOnly = true;
            this.coldiferencia.Visible = true;
            this.coldiferencia.VisibleIndex = 5;
            this.coldiferencia.Width = 180;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Codigo___________:";
            this.labelControl1.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(60, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(162, 24);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Location = new System.Drawing.Point(358, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 25);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "Recepcion  de Producto";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(805, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(170, 45);
            this.simpleButton1.TabIndex = 56;
            this.simpleButton1.Text = "Home";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pDVBindingSource
            // 
            this.pDVBindingSource.DataMember = "PDV";
            this.pDVBindingSource.DataSource = this.dsDespacho1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(161, 17);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "Destino/Cliente____________:";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(108, 50);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFactura.Properties.Appearance.Options.UseFont = true;
            this.txtNumFactura.Properties.ReadOnly = true;
            this.txtNumFactura.Size = new System.Drawing.Size(276, 24);
            this.txtNumFactura.TabIndex = 61;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(146, 17);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "No de Doc________________";
            // 
            // cmdCopiarDesdeFactura
            // 
            this.cmdCopiarDesdeFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCopiarDesdeFactura.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdCopiarDesdeFactura.Appearance.Options.UseFont = true;
            this.cmdCopiarDesdeFactura.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCopiarDesdeFactura.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdCopiarDesdeFactura.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCopiarDesdeFactura.ImageOptions.SvgImage")));
            this.cmdCopiarDesdeFactura.Location = new System.Drawing.Point(629, 3);
            this.cmdCopiarDesdeFactura.Name = "cmdCopiarDesdeFactura";
            this.cmdCopiarDesdeFactura.Size = new System.Drawing.Size(170, 45);
            this.cmdCopiarDesdeFactura.TabIndex = 62;
            this.cmdCopiarDesdeFactura.Text = "Copiar de Factura";
            this.cmdCopiarDesdeFactura.Click += new System.EventHandler(this.cmdCopiarDesdeFactura_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dsDespacho1;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(108, 78);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNombre.Properties.Appearance.Options.UseFont = true;
            this.txtClienteNombre.Properties.ReadOnly = true;
            this.txtClienteNombre.Size = new System.Drawing.Size(276, 24);
            this.txtClienteNombre.TabIndex = 64;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(628, 52);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(170, 45);
            this.cmdGuardar.TabIndex = 65;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // xfrmTrasladoRecepcionDetalleFactura
            // 
            this.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 483);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdCopiarDesdeFactura);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "xfrmTrasladoRecepcionDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepción de Producto";
            this.Load += new System.EventHandler(this.xfrmTrasladoRecepcionDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespacho1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private dsDespacho dsDespacho1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource pDVBindingSource;
        private DevExpress.XtraEditors.TextEdit txtNumFactura;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdCopiarDesdeFactura;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_code;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_recepcionado;
        private DevExpress.XtraGrid.Columns.GridColumn colentregar_todo;
        private DevExpress.XtraEditors.TextEdit txtClienteNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_a_entregar;
        private DevExpress.XtraGrid.Columns.GridColumn coldiferencia;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_code1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_ingresada;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}