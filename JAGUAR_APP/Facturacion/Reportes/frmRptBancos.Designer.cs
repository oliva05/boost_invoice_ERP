namespace JAGUAR_APP.Facturacion.Reportes
{
    partial class frmRptBancos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptBancos));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdTotalCuentas = new DevExpress.XtraGrid.GridControl();
            this.dsBancos1 = new JAGUAR_APP.BancosYTitulares.dsBancos();
            this.grdvTotalBancos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdDetalleCuentas = new DevExpress.XtraGrid.GridControl();
            this.grdvDetalleCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperacion_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_retiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colretiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPrintRpt = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTotalBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalleCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.grdTotalCuentas);
            this.groupControl1.Location = new System.Drawing.Point(3, 59);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(574, 693);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Seleccione la Cuenta";
            // 
            // grdTotalCuentas
            // 
            this.grdTotalCuentas.DataMember = "kardex_total_cuentas";
            this.grdTotalCuentas.DataSource = this.dsBancos1;
            this.grdTotalCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTotalCuentas.Location = new System.Drawing.Point(2, 23);
            this.grdTotalCuentas.MainView = this.grdvTotalBancos;
            this.grdTotalCuentas.Name = "grdTotalCuentas";
            this.grdTotalCuentas.Size = new System.Drawing.Size(570, 668);
            this.grdTotalCuentas.TabIndex = 0;
            this.grdTotalCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvTotalBancos});
            // 
            // dsBancos1
            // 
            this.dsBancos1.DataSetName = "dsBancos";
            this.dsBancos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvTotalBancos
            // 
            this.grdvTotalBancos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cuenta,
            this.coltitular,
            this.colbanco,
            this.colcuenta,
            this.coltotal});
            this.grdvTotalBancos.GridControl = this.grdTotalCuentas;
            this.grdvTotalBancos.Name = "grdvTotalBancos";
            this.grdvTotalBancos.OptionsView.ShowAutoFilterRow = true;
            this.grdvTotalBancos.OptionsView.ShowFooter = true;
            this.grdvTotalBancos.OptionsView.ShowGroupPanel = false;
            this.grdvTotalBancos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdvTotalBancos_RowClick);
            // 
            // colid_cuenta
            // 
            this.colid_cuenta.FieldName = "id_cuenta";
            this.colid_cuenta.Name = "colid_cuenta";
            this.colid_cuenta.OptionsColumn.AllowEdit = false;
            // 
            // coltitular
            // 
            this.coltitular.Caption = "Titular";
            this.coltitular.FieldName = "titular";
            this.coltitular.Name = "coltitular";
            this.coltitular.OptionsColumn.AllowEdit = false;
            this.coltitular.Visible = true;
            this.coltitular.VisibleIndex = 0;
            this.coltitular.Width = 148;
            // 
            // colbanco
            // 
            this.colbanco.Caption = "Banco";
            this.colbanco.FieldName = "banco";
            this.colbanco.Name = "colbanco";
            this.colbanco.OptionsColumn.AllowEdit = false;
            this.colbanco.Visible = true;
            this.colbanco.VisibleIndex = 1;
            this.colbanco.Width = 152;
            // 
            // colcuenta
            // 
            this.colcuenta.Caption = "Num. Cuenta";
            this.colcuenta.FieldName = "cuenta";
            this.colcuenta.Name = "colcuenta";
            this.colcuenta.OptionsColumn.AllowEdit = false;
            this.colcuenta.Visible = true;
            this.colcuenta.VisibleIndex = 2;
            this.colcuenta.Width = 143;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "Total={0:#,###,##0.00}")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 3;
            this.coltotal.Width = 104;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.grdDetalleCuentas);
            this.groupControl2.Location = new System.Drawing.Point(583, 59);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(752, 693);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Detalle de Transacciones";
            // 
            // grdDetalleCuentas
            // 
            this.grdDetalleCuentas.DataMember = "cuenta_detalle";
            this.grdDetalleCuentas.DataSource = this.dsBancos1;
            this.grdDetalleCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalleCuentas.Location = new System.Drawing.Point(2, 23);
            this.grdDetalleCuentas.MainView = this.grdvDetalleCuentas;
            this.grdDetalleCuentas.Name = "grdDetalleCuentas";
            this.grdDetalleCuentas.Size = new System.Drawing.Size(748, 668);
            this.grdDetalleCuentas.TabIndex = 1;
            this.grdDetalleCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDetalleCuentas});
            // 
            // grdvDetalleCuentas
            // 
            this.grdvDetalleCuentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coloperacion_id,
            this.coldescripcion,
            this.colid_cuenta1,
            this.colid_factura,
            this.colid_retiro,
            this.coldeposito,
            this.colretiro,
            this.colfecha,
            this.colusuario,
            this.colreferencia});
            this.grdvDetalleCuentas.GridControl = this.grdDetalleCuentas;
            this.grdvDetalleCuentas.Name = "grdvDetalleCuentas";
            this.grdvDetalleCuentas.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coloperacion_id
            // 
            this.coloperacion_id.FieldName = "operacion_id";
            this.coloperacion_id.Name = "coloperacion_id";
            this.coloperacion_id.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Operacion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 92;
            // 
            // colid_cuenta1
            // 
            this.colid_cuenta1.FieldName = "id_cuenta";
            this.colid_cuenta1.Name = "colid_cuenta1";
            this.colid_cuenta1.OptionsColumn.AllowEdit = false;
            // 
            // colid_factura
            // 
            this.colid_factura.Caption = "Factura";
            this.colid_factura.FieldName = "id_factura";
            this.colid_factura.Name = "colid_factura";
            this.colid_factura.OptionsColumn.AllowEdit = false;
            this.colid_factura.Visible = true;
            this.colid_factura.VisibleIndex = 3;
            // 
            // colid_retiro
            // 
            this.colid_retiro.Caption = "Retiro";
            this.colid_retiro.FieldName = "id_retiro";
            this.colid_retiro.Name = "colid_retiro";
            this.colid_retiro.OptionsColumn.AllowEdit = false;
            this.colid_retiro.Visible = true;
            this.colid_retiro.VisibleIndex = 2;
            // 
            // coldeposito
            // 
            this.coldeposito.Caption = "Entrada";
            this.coldeposito.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldeposito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldeposito.FieldName = "deposito";
            this.coldeposito.Name = "coldeposito";
            this.coldeposito.OptionsColumn.AllowEdit = false;
            this.coldeposito.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "deposito", "SUM={0:#,###,##0.00}")});
            this.coldeposito.Visible = true;
            this.coldeposito.VisibleIndex = 6;
            this.coldeposito.Width = 125;
            // 
            // colretiro
            // 
            this.colretiro.Caption = "Salida";
            this.colretiro.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colretiro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colretiro.FieldName = "retiro";
            this.colretiro.Name = "colretiro";
            this.colretiro.OptionsColumn.AllowEdit = false;
            this.colretiro.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "retiro", "SUM={0:#,###,##0.00}")});
            this.colretiro.Visible = true;
            this.colretiro.VisibleIndex = 7;
            this.colretiro.Width = 133;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            this.colfecha.Width = 125;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 5;
            this.colusuario.Width = 125;
            // 
            // colreferencia
            // 
            this.colreferencia.Caption = "# Referencia";
            this.colreferencia.FieldName = "referencia";
            this.colreferencia.Name = "colreferencia";
            this.colreferencia.OptionsColumn.AllowEdit = false;
            this.colreferencia.Visible = true;
            this.colreferencia.VisibleIndex = 1;
            this.colreferencia.Width = 125;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnActualizar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Appearance.Options.UseBackColor = true;
            this.btnActualizar.Appearance.Options.UseFont = true;
            this.btnActualizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(12, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 41);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.BackColor = System.Drawing.Color.Coral;
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseBackColor = true;
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdClose.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.cancel;
            this.cmdClose.Location = new System.Drawing.Point(1206, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(121, 41);
            this.cmdClose.TabIndex = 17;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdPrintRpt
            // 
            this.cmdPrintRpt.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdPrintRpt.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrintRpt.Appearance.Options.UseBackColor = true;
            this.cmdPrintRpt.Appearance.Options.UseFont = true;
            this.cmdPrintRpt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdPrintRpt.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.printarea_32x32;
            this.cmdPrintRpt.Location = new System.Drawing.Point(293, 12);
            this.cmdPrintRpt.Name = "cmdPrintRpt";
            this.cmdPrintRpt.Size = new System.Drawing.Size(167, 41);
            this.cmdPrintRpt.TabIndex = 18;
            this.cmdPrintRpt.Text = "Reporte General";
            this.cmdPrintRpt.Visible = false;
            this.cmdPrintRpt.Click += new System.EventHandler(this.cmdPrintRpt_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(153, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(121, 41);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Ajuste";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmRptBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 753);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdPrintRpt);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmRptBancos";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTotalBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalleCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grdTotalCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvTotalBancos;
        private DevExpress.XtraGrid.GridControl grdDetalleCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDetalleCuentas;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdPrintRpt;
        private BancosYTitulares.dsBancos dsBancos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coltitular;
        private DevExpress.XtraGrid.Columns.GridColumn colbanco;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coloperacion_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colid_retiro;
        private DevExpress.XtraGrid.Columns.GridColumn coldeposito;
        private DevExpress.XtraGrid.Columns.GridColumn colretiro;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}