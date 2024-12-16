namespace JAGUAR_APP.Facturacion.Reportes
{
    partial class frmRptBancosAjuste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptBancosAjuste));
            this.cmdFacturar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.label22 = new System.Windows.Forms.Label();
            this.grdCuentas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spindValor = new DevExpress.XtraEditors.SpinEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.tsTipoTra = new DevExpress.XtraEditors.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dsRegistroPagos1 = new JAGUAR_APP.Facturacion.CoreFacturas.dsRegistroPagos();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdCuentas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spindValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTipoTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegistroPagos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFacturar
            // 
            this.cmdFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdFacturar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFacturar.Appearance.Options.UseFont = true;
            this.cmdFacturar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdFacturar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdFacturar.ImageOptions.Image")));
            this.cmdFacturar.Location = new System.Drawing.Point(59, 320);
            this.cmdFacturar.Name = "cmdFacturar";
            this.cmdFacturar.Size = new System.Drawing.Size(125, 38);
            this.cmdFacturar.TabIndex = 8;
            this.cmdFacturar.Text = "&Guardar";
            this.cmdFacturar.Click += new System.EventHandler(this.cmdFacturar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(261, 320);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(125, 38);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(36, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 21);
            this.label22.TabIndex = 44;
            this.label22.Text = "Cuenta";
            // 
            // grdCuentas
            // 
            this.grdCuentas.Location = new System.Drawing.Point(106, 46);
            this.grdCuentas.Name = "grdCuentas";
            this.grdCuentas.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.grdCuentas.Properties.Appearance.Options.UseFont = true;
            this.grdCuentas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdCuentas.Properties.DataSource = this.cuentasBindingSource;
            this.grdCuentas.Properties.DisplayMember = "cuenta";
            this.grdCuentas.Properties.NullText = "";
            this.grdCuentas.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdCuentas.Properties.ValueMember = "id_cuenta";
            this.grdCuentas.Size = new System.Drawing.Size(342, 30);
            this.grdCuentas.TabIndex = 43;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cuenta,
            this.colid_banco,
            this.colcuenta,
            this.coltitular,
            this.colnum_cuenta,
            this.colmoneda});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_cuenta
            // 
            this.colid_cuenta.FieldName = "id_cuenta";
            this.colid_cuenta.Name = "colid_cuenta";
            // 
            // colid_banco
            // 
            this.colid_banco.FieldName = "id_banco";
            this.colid_banco.Name = "colid_banco";
            // 
            // colcuenta
            // 
            this.colcuenta.Caption = "Cuenta";
            this.colcuenta.FieldName = "cuenta";
            this.colcuenta.Name = "colcuenta";
            this.colcuenta.Visible = true;
            this.colcuenta.VisibleIndex = 0;
            // 
            // coltitular
            // 
            this.coltitular.Caption = "Titular";
            this.coltitular.FieldName = "titular";
            this.coltitular.Name = "coltitular";
            this.coltitular.Visible = true;
            this.coltitular.VisibleIndex = 1;
            // 
            // colnum_cuenta
            // 
            this.colnum_cuenta.FieldName = "num_cuenta";
            this.colnum_cuenta.Name = "colnum_cuenta";
            // 
            // colmoneda
            // 
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            // 
            // spindValor
            // 
            this.spindValor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spindValor.Location = new System.Drawing.Point(221, 183);
            this.spindValor.Name = "spindValor";
            this.spindValor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.spindValor.Properties.Appearance.Options.UseFont = true;
            this.spindValor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spindValor.Size = new System.Drawing.Size(216, 32);
            this.spindValor.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Valor de Transferencia";
            // 
            // tsTipoTra
            // 
            this.tsTipoTra.EditValue = true;
            this.tsTipoTra.Location = new System.Drawing.Point(218, 111);
            this.tsTipoTra.Name = "tsTipoTra";
            this.tsTipoTra.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsTipoTra.Properties.Appearance.Options.UseFont = true;
            this.tsTipoTra.Properties.OffText = "Salida";
            this.tsTipoTra.Properties.OnText = "Entrada";
            this.tsTipoTra.Size = new System.Drawing.Size(230, 26);
            this.tsTipoTra.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tipo de Transaccion";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(221, 249);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(216, 29);
            this.txtReferencia.TabIndex = 50;
            this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 21);
            this.label17.TabIndex = 49;
            this.label17.Text = "Referencia";
            // 
            // dsRegistroPagos1
            // 
            this.dsRegistroPagos1.DataSetName = "dsRegistroPagos";
            this.dsRegistroPagos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataMember = "cuentas";
            this.cuentasBindingSource.DataSource = this.dsRegistroPagos1;
            // 
            // frmRptBancosAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 407);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsTipoTra);
            this.Controls.Add(this.spindValor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.grdCuentas);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdFacturar);
            this.Name = "frmRptBancosAjuste";
            ((System.ComponentModel.ISupportInitialize)(this.grdCuentas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spindValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTipoTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegistroPagos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdFacturar;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.GridLookUpEdit grdCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_banco;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coltitular;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraEditors.SpinEdit spindValor;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.ToggleSwitch tsTipoTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private CoreFacturas.dsRegistroPagos dsRegistroPagos1;
    }
}