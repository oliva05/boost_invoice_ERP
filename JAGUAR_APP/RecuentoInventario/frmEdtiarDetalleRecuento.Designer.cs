
namespace JAGUAR_APP.RecuentoInventario
{
    partial class frmEdtiarDetalleRecuento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdtiarDetalleRecuento));
            this.spinExistenciaSistema = new DevExpress.XtraEditors.SpinEdit();
            this.spinExistenciaFisica = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spinNuevaCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.spinDiferencia = new DevExpress.XtraEditors.SpinEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtMatriaPr = new System.Windows.Forms.TextBox();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spinExistenciaSistema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinExistenciaFisica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNuevaCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiferencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spinExistenciaSistema
            // 
            this.spinExistenciaSistema.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinExistenciaSistema.Enabled = false;
            this.spinExistenciaSistema.Location = new System.Drawing.Point(208, 137);
            this.spinExistenciaSistema.Name = "spinExistenciaSistema";
            this.spinExistenciaSistema.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinExistenciaSistema.Properties.Appearance.Options.UseFont = true;
            this.spinExistenciaSistema.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinExistenciaSistema.Properties.EditFormat.FormatString = "n2";
            this.spinExistenciaSistema.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinExistenciaSistema.Size = new System.Drawing.Size(145, 28);
            this.spinExistenciaSistema.TabIndex = 0;
            // 
            // spinExistenciaFisica
            // 
            this.spinExistenciaFisica.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinExistenciaFisica.Location = new System.Drawing.Point(208, 175);
            this.spinExistenciaFisica.Name = "spinExistenciaFisica";
            this.spinExistenciaFisica.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinExistenciaFisica.Properties.Appearance.Options.UseFont = true;
            this.spinExistenciaFisica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinExistenciaFisica.Size = new System.Drawing.Size(145, 28);
            this.spinExistenciaFisica.TabIndex = 1;
            this.spinExistenciaFisica.EditValueChanged += new System.EventHandler(this.spinExistenciaFisica_EditValueChanged);
            this.spinExistenciaFisica.Enter += new System.EventHandler(this.spinExistenciaFisica_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edicion de Recuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Existencia Sistema:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia Toma Fisica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Diferencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nueva Cantidad:";
            // 
            // spinNuevaCantidad
            // 
            this.spinNuevaCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinNuevaCantidad.Enabled = false;
            this.spinNuevaCantidad.Location = new System.Drawing.Point(208, 260);
            this.spinNuevaCantidad.Name = "spinNuevaCantidad";
            this.spinNuevaCantidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinNuevaCantidad.Properties.Appearance.Options.UseFont = true;
            this.spinNuevaCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNuevaCantidad.Size = new System.Drawing.Size(145, 28);
            this.spinNuevaCantidad.TabIndex = 8;
            // 
            // spinDiferencia
            // 
            this.spinDiferencia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiferencia.Enabled = false;
            this.spinDiferencia.Location = new System.Drawing.Point(208, 218);
            this.spinDiferencia.Name = "spinDiferencia";
            this.spinDiferencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinDiferencia.Properties.Appearance.Options.UseFont = true;
            this.spinDiferencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinDiferencia.Size = new System.Drawing.Size(145, 28);
            this.spinDiferencia.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(94, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 47);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(228, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 47);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMatriaPr
            // 
            this.txtMatriaPr.Enabled = false;
            this.txtMatriaPr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMatriaPr.Location = new System.Drawing.Point(206, 65);
            this.txtMatriaPr.Name = "txtMatriaPr";
            this.txtMatriaPr.Size = new System.Drawing.Size(159, 29);
            this.txtMatriaPr.TabIndex = 11;
            // 
            // txtBodega
            // 
            this.txtBodega.Enabled = false;
            this.txtBodega.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBodega.Location = new System.Drawing.Point(206, 97);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(159, 29);
            this.txtBodega.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Materia Prima:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bodega:";
            // 
            // frmEdtiarDetalleRecuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 387);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBodega);
            this.Controls.Add(this.txtMatriaPr);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.spinNuevaCantidad);
            this.Controls.Add(this.spinDiferencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinExistenciaFisica);
            this.Controls.Add(this.spinExistenciaSistema);
            this.Name = "frmEdtiarDetalleRecuento";
            ((System.ComponentModel.ISupportInitialize)(this.spinExistenciaSistema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinExistenciaFisica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNuevaCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiferencia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinExistenciaSistema;
        private DevExpress.XtraEditors.SpinEdit spinExistenciaFisica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit spinNuevaCantidad;
        private DevExpress.XtraEditors.SpinEdit spinDiferencia;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.TextBox txtMatriaPr;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}