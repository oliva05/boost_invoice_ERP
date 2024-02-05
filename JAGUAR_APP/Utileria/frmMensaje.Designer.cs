namespace JAGUAR_APP.Utileria
{
    partial class frmMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensaje));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBoxInfomation = new System.Windows.Forms.PictureBox();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.msjBoxIcon = new System.Windows.Forms.PictureBox();
            this.cmdAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfomation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msjBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(98, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(438, 164);
            this.labelControl1.TabIndex = 0;
            // 
            // pictureBoxInfomation
            // 
            this.pictureBoxInfomation.Image = global::JAGUAR_APP.Properties.Resources.Status_dialog_information_icon72px;
            this.pictureBoxInfomation.Location = new System.Drawing.Point(113, 106);
            this.pictureBoxInfomation.Name = "pictureBoxInfomation";
            this.pictureBoxInfomation.Size = new System.Drawing.Size(95, 70);
            this.pictureBoxInfomation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfomation.TabIndex = 2;
            this.pictureBoxInfomation.TabStop = false;
            this.pictureBoxInfomation.Visible = false;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Image = global::JAGUAR_APP.Properties.Resources.delete_1_icon72px;
            this.pictureBoxError.Location = new System.Drawing.Point(12, 106);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(95, 70);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 1;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            // 
            // msjBoxIcon
            // 
            this.msjBoxIcon.Image = global::JAGUAR_APP.Properties.Resources.delete_1_icon72px;
            this.msjBoxIcon.Location = new System.Drawing.Point(0, 30);
            this.msjBoxIcon.Name = "msjBoxIcon";
            this.msjBoxIcon.Size = new System.Drawing.Size(95, 70);
            this.msjBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.msjBoxIcon.TabIndex = 3;
            this.msjBoxIcon.TabStop = false;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Appearance.Options.UseFont = true;
            this.cmdAceptar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAceptar.ImageOptions.Image")));
            this.cmdAceptar.Location = new System.Drawing.Point(315, 182);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(221, 81);
            this.cmdAceptar.TabIndex = 4;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMensaje
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 275);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.msjBoxIcon);
            this.Controls.Add(this.pictureBoxInfomation);
            this.Controls.Add(this.pictureBoxError);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMensaje";
            this.Text = "frmMensaje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfomation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msjBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.PictureBox pictureBoxInfomation;
        private System.Windows.Forms.PictureBox msjBoxIcon;
        private DevExpress.XtraEditors.SimpleButton cmdAceptar;
        private System.Windows.Forms.Timer timer1;
    }
}