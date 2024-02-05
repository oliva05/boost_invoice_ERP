
namespace JAGUAR_APP.Formulas
{
    partial class frmAddLataPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLataPT));
            this.spinEditFactor = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitchEnableFormula = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblToggleSwitchEnable = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblTituloFormula = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnableFormula.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spinEditFactor
            // 
            this.spinEditFactor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditFactor.Location = new System.Drawing.Point(186, 94);
            this.spinEditFactor.Name = "spinEditFactor";
            this.spinEditFactor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditFactor.Properties.Appearance.Options.UseFont = true;
            this.spinEditFactor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditFactor.Size = new System.Drawing.Size(177, 22);
            this.spinEditFactor.TabIndex = 64;
            // 
            // spinEditCantidad
            // 
            this.spinEditCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCantidad.Location = new System.Drawing.Point(186, 65);
            this.spinEditCantidad.Name = "spinEditCantidad";
            this.spinEditCantidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditCantidad.Properties.Appearance.Options.UseFont = true;
            this.spinEditCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCantidad.Size = new System.Drawing.Size(177, 22);
            this.spinEditCantidad.TabIndex = 63;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(52, 162);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(157, 42);
            this.cmdGuardar.TabIndex = 57;
            this.cmdGuardar.Text = "Guardar";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Pink;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(224, 162);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(157, 42);
            this.cmdCerrar.TabIndex = 58;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // toggleSwitchEnableFormula
            // 
            this.toggleSwitchEnableFormula.EditValue = true;
            this.toggleSwitchEnableFormula.Location = new System.Drawing.Point(186, 121);
            this.toggleSwitchEnableFormula.Name = "toggleSwitchEnableFormula";
            this.toggleSwitchEnableFormula.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleSwitchEnableFormula.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchEnableFormula.Properties.OffText = "No";
            this.toggleSwitchEnableFormula.Properties.OnText = "Si";
            this.toggleSwitchEnableFormula.Size = new System.Drawing.Size(115, 26);
            this.toggleSwitchEnableFormula.TabIndex = 62;
            // 
            // lblToggleSwitchEnable
            // 
            this.lblToggleSwitchEnable.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleSwitchEnable.Appearance.Options.UseFont = true;
            this.lblToggleSwitchEnable.Location = new System.Drawing.Point(78, 130);
            this.lblToggleSwitchEnable.Name = "lblToggleSwitchEnable";
            this.lblToggleSwitchEnable.Size = new System.Drawing.Size(144, 15);
            this.lblToggleSwitchEnable.TabIndex = 61;
            this.lblToggleSwitchEnable.Text = "Habilitada__________________";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(78, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 15);
            this.labelControl1.TabIndex = 60;
            this.labelControl1.Text = "Factor__________________";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(78, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(128, 15);
            this.labelControl5.TabIndex = 59;
            this.labelControl5.Text = "Cantidad________________";
            // 
            // lblTituloFormula
            // 
            this.lblTituloFormula.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormula.Appearance.Options.UseFont = true;
            this.lblTituloFormula.Appearance.Options.UseTextOptions = true;
            this.lblTituloFormula.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloFormula.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloFormula.Location = new System.Drawing.Point(5, 12);
            this.lblTituloFormula.Name = "lblTituloFormula";
            this.lblTituloFormula.Size = new System.Drawing.Size(404, 21);
            this.lblTituloFormula.TabIndex = 56;
            this.lblTituloFormula.Text = "Gestión de Latas";
            // 
            // frmAddLataPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 213);
            this.Controls.Add(this.spinEditFactor);
            this.Controls.Add(this.spinEditCantidad);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.toggleSwitchEnableFormula);
            this.Controls.Add(this.lblToggleSwitchEnable);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblTituloFormula);
            this.Name = "frmAddLataPT";
            this.Text = "Gestión de Lata";
            ((System.ComponentModel.ISupportInitialize)(this.spinEditFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnableFormula.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinEditFactor;
        private DevExpress.XtraEditors.SpinEdit spinEditCantidad;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchEnableFormula;
        private DevExpress.XtraEditors.LabelControl lblToggleSwitchEnable;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblTituloFormula;
    }
}