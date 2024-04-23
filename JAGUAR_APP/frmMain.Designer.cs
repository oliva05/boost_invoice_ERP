using DevExpress.XtraEditors;

namespace JAGUAR_APP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdAbrirTeclado = new DevExpress.XtraEditors.SimpleButton();
            this.cmdIngresarAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkVerClave = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(325, 228);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(199, 59);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdLogin.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Appearance.Options.UseBackColor = true;
            this.cmdLogin.Appearance.Options.UseBorderColor = true;
            this.cmdLogin.Appearance.Options.UseFont = true;
            this.cmdLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdLogin.ImageOptions.SvgImage")));
            this.cmdLogin.Location = new System.Drawing.Point(122, 228);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(199, 59);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Ingresar";
            this.cmdLogin.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtClave
            // 
            this.txtClave.EditValue = "";
            this.txtClave.Location = new System.Drawing.Point(196, 159);
            this.txtClave.Name = "txtClave";
            this.txtClave.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtClave.Properties.Appearance.Options.UseFont = true;
            this.txtClave.Properties.ContextImageOptions.Image = global::JAGUAR_APP.Properties.Resources.key;
            this.txtClave.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtClave.Properties.UseSystemPasswordChar = true;
            this.txtClave.Size = new System.Drawing.Size(222, 30);
            this.txtClave.TabIndex = 1;
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(196, 101);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.ContextImageOptions.Image = global::JAGUAR_APP.Properties.Resources.user;
            this.txtUsuario.Size = new System.Drawing.Size(222, 30);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(126, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 24);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Usuario";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(129, 162);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 24);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Clave";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(141, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 27);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Bienvenido";
            this.labelControl3.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(119, 355);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(47, 13);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Ninguna";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAGUAR_APP.Properties.Resources.Users_Group_icon64px;
            this.pictureBox1.Location = new System.Drawing.Point(424, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdAbrirTeclado
            // 
            this.cmdAbrirTeclado.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdAbrirTeclado.Appearance.Options.UseBackColor = true;
            this.cmdAbrirTeclado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAbrirTeclado.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.cmdAbrirTeclado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAbrirTeclado.ImageOptions.SvgImage")));
            this.cmdAbrirTeclado.Location = new System.Drawing.Point(529, 154);
            this.cmdAbrirTeclado.Name = "cmdAbrirTeclado";
            this.cmdAbrirTeclado.Size = new System.Drawing.Size(54, 35);
            this.cmdAbrirTeclado.TabIndex = 19;
            this.cmdAbrirTeclado.Click += new System.EventHandler(this.cmdAbrirTeclado_Click);
            // 
            // cmdIngresarAdmin
            // 
            this.cmdIngresarAdmin.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdIngresarAdmin.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdIngresarAdmin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresarAdmin.Appearance.Options.UseBackColor = true;
            this.cmdIngresarAdmin.Appearance.Options.UseBorderColor = true;
            this.cmdIngresarAdmin.Appearance.Options.UseFont = true;
            this.cmdIngresarAdmin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdIngresarAdmin.Location = new System.Drawing.Point(122, 293);
            this.cmdIngresarAdmin.Name = "cmdIngresarAdmin";
            this.cmdIngresarAdmin.Size = new System.Drawing.Size(199, 59);
            this.cmdIngresarAdmin.TabIndex = 20;
            this.cmdIngresarAdmin.Text = "Ingresar Admin";
            this.cmdIngresarAdmin.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JAGUAR_APP.Properties.Resources.Papirus_Team_Papirus_Apps_Flow_128;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // chkVerClave
            // 
            this.chkVerClave.AutoSize = true;
            this.chkVerClave.Location = new System.Drawing.Point(196, 196);
            this.chkVerClave.Name = "chkVerClave";
            this.chkVerClave.Size = new System.Drawing.Size(72, 17);
            this.chkVerClave.TabIndex = 22;
            this.chkVerClave.Text = "Ver Clave";
            this.chkVerClave.UseVisualStyleBackColor = true;
            this.chkVerClave.CheckedChanged += new System.EventHandler(this.chkVerClave_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 376);
            this.ControlBox = false;
            this.Controls.Add(this.chkVerClave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdIngresarAdmin);
            this.Controls.Add(this.cmdAbrirTeclado);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmMain";
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdLogin;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label lblVersion;
        private SimpleButton cmdAbrirTeclado;
        private SimpleButton cmdIngresarAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkVerClave;
    }
}

