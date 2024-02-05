using DevExpress.XtraEditors;

namespace JAGUAR_APP.TransaccionesPT
{
    partial class frmLotePT_Cost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotePT_Cost));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoteAutomatico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLotePropio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chk_Auto = new DevExpress.XtraEditors.CheckEdit();
            this.chk_lote_propio = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoteAutomatico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotePropio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Auto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_lote_propio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(333, 17);
            this.labelControl1.TabIndex = 144;
            this.labelControl1.Text = "Puede usar un lote por defecto o generar uno nuevo";
            // 
            // txtLoteAutomatico
            // 
            this.txtLoteAutomatico.EditValue = "";
            this.txtLoteAutomatico.Location = new System.Drawing.Point(187, 65);
            this.txtLoteAutomatico.Name = "txtLoteAutomatico";
            this.txtLoteAutomatico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtLoteAutomatico.Properties.Appearance.Options.UseFont = true;
            this.txtLoteAutomatico.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoteAutomatico.Properties.ReadOnly = true;
            this.txtLoteAutomatico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoteAutomatico.Size = new System.Drawing.Size(266, 26);
            this.txtLoteAutomatico.TabIndex = 143;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(405, 24);
            this.labelControl2.TabIndex = 146;
            this.labelControl2.Text = "Generación de Lote PT para ajuste de inventario";
            // 
            // txtLotePropio
            // 
            this.txtLotePropio.EditValue = "";
            this.txtLotePropio.Location = new System.Drawing.Point(187, 97);
            this.txtLotePropio.Name = "txtLotePropio";
            this.txtLotePropio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtLotePropio.Properties.Appearance.Options.UseFont = true;
            this.txtLotePropio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLotePropio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLotePropio.Size = new System.Drawing.Size(266, 26);
            this.txtLotePropio.TabIndex = 145;
            this.txtLotePropio.EditValueChanged += new System.EventHandler(this.txtLotePropio_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 24);
            this.labelControl3.TabIndex = 147;
            this.labelControl3.Text = "Lote Automático";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(120, 24);
            this.labelControl4.TabIndex = 148;
            this.labelControl4.Text = "Mi propio Lote";
            // 
            // chk_Auto
            // 
            this.chk_Auto.EditValue = true;
            this.chk_Auto.Location = new System.Drawing.Point(460, 68);
            this.chk_Auto.Name = "chk_Auto";
            this.chk_Auto.Properties.Caption = "";
            this.chk_Auto.Size = new System.Drawing.Size(24, 20);
            this.chk_Auto.TabIndex = 149;
            this.chk_Auto.EditValueChanged += new System.EventHandler(this.chk_Auto_EditValueChanged);
            // 
            // chk_lote_propio
            // 
            this.chk_lote_propio.Location = new System.Drawing.Point(460, 102);
            this.chk_lote_propio.Name = "chk_lote_propio";
            this.chk_lote_propio.Properties.Caption = "";
            this.chk_lote_propio.Size = new System.Drawing.Size(24, 20);
            this.chk_lote_propio.TabIndex = 150;
            this.chk_lote_propio.CheckedChanged += new System.EventHandler(this.chk_lote_propio_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(146, 24);
            this.labelControl5.TabIndex = 152;
            this.labelControl5.Text = "Costo por Unidad";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(95, 182);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(167, 49);
            this.cmdGuardar.TabIndex = 153;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(268, 182);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 49);
            this.btnAtras.TabIndex = 154;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(187, 139);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.EditFormat.FormatString = "n2";
            this.spinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Size = new System.Drawing.Size(266, 26);
            this.spinEdit1.TabIndex = 155;
            // 
            // frmLotePT_Cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 235);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.chk_lote_propio);
            this.Controls.Add(this.chk_Auto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtLotePropio);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtLoteAutomatico);
            this.Name = "frmLotePT_Cost";
            this.Text = "Ingrese los datos del Lote";
            ((System.ComponentModel.ISupportInitialize)(this.txtLoteAutomatico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotePropio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Auto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_lote_propio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLoteAutomatico;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLotePropio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chk_Auto;
        private DevExpress.XtraEditors.CheckEdit chk_lote_propio;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private SpinEdit spinEdit1;
    }
}