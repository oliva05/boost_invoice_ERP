namespace PRININ.Gestion_de_Usuarios
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkSuperUsuario = new System.Windows.Forms.CheckBox();
            this.chkUsuarioHabilitado = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSAve = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.lueGrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.accesoGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAccesos = new JAGUAR_APP.Accesos.dsAccesos();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lueTurno = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesoGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTurno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.Location = new System.Drawing.Point(128, 85);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '●';
            this.txtConfirmar.Size = new System.Drawing.Size(205, 26);
            this.txtConfirmar.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Confirmar:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(128, 50);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(205, 26);
            this.txtPass.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Contraseña:";
            // 
            // chkSuperUsuario
            // 
            this.chkSuperUsuario.AutoSize = true;
            this.chkSuperUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuperUsuario.Location = new System.Drawing.Point(31, 298);
            this.chkSuperUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSuperUsuario.Name = "chkSuperUsuario";
            this.chkSuperUsuario.Size = new System.Drawing.Size(138, 24);
            this.chkSuperUsuario.TabIndex = 32;
            this.chkSuperUsuario.Text = "Super Usuario";
            this.chkSuperUsuario.UseVisualStyleBackColor = true;
            // 
            // chkUsuarioHabilitado
            // 
            this.chkUsuarioHabilitado.AutoSize = true;
            this.chkUsuarioHabilitado.Checked = true;
            this.chkUsuarioHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsuarioHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsuarioHabilitado.Location = new System.Drawing.Point(31, 266);
            this.chkUsuarioHabilitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkUsuarioHabilitado.Name = "chkUsuarioHabilitado";
            this.chkUsuarioHabilitado.Size = new System.Drawing.Size(169, 24);
            this.chkUsuarioHabilitado.TabIndex = 31;
            this.chkUsuarioHabilitado.Text = "Usuario Habilitado";
            this.chkUsuarioHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(99, 118);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 26);
            this.txtNombre.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.Location = new System.Drawing.Point(99, 16);
            this.txtAlias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(234, 26);
            this.txtAlias.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Alias";
            // 
            // cmdSAve
            // 
            this.cmdSAve.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdSAve.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSAve.Appearance.Options.UseBackColor = true;
            this.cmdSAve.Appearance.Options.UseFont = true;
            this.cmdSAve.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSAve.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSAve.ImageOptions.Image")));
            this.cmdSAve.Location = new System.Drawing.Point(36, 348);
            this.cmdSAve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSAve.Name = "cmdSAve";
            this.cmdSAve.Size = new System.Drawing.Size(127, 49);
            this.cmdSAve.TabIndex = 38;
            this.cmdSAve.Text = "Guardar";
            this.cmdSAve.Click += new System.EventHandler(this.cmdSAve_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.BackColor = System.Drawing.Color.SandyBrown;
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseBackColor = true;
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.Location = new System.Drawing.Point(206, 348);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(127, 49);
            this.cmdClose.TabIndex = 39;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lueGrupo
            // 
            this.lueGrupo.Location = new System.Drawing.Point(99, 153);
            this.lueGrupo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lueGrupo.Name = "lueGrupo";
            this.lueGrupo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lueGrupo.Properties.Appearance.Options.UseFont = true;
            this.lueGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrupo.Properties.DataSource = this.accesoGrupoBindingSource;
            this.lueGrupo.Properties.DisplayMember = "grupo";
            this.lueGrupo.Properties.NullText = "";
            this.lueGrupo.Properties.ValueMember = "id";
            this.lueGrupo.Size = new System.Drawing.Size(234, 26);
            this.lueGrupo.TabIndex = 40;
            // 
            // accesoGrupoBindingSource
            // 
            this.accesoGrupoBindingSource.DataMember = "Acceso_Grupo";
            this.accesoGrupoBindingSource.DataSource = this.dsAccesos;
            // 
            // dsAccesos
            // 
            this.dsAccesos.DataSetName = "dsAccesos";
            this.dsAccesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Grupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Turno:";
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.dsAccesos;
            // 
            // lueTurno
            // 
            this.lueTurno.Location = new System.Drawing.Point(99, 191);
            this.lueTurno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lueTurno.Name = "lueTurno";
            this.lueTurno.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lueTurno.Properties.Appearance.Options.UseFont = true;
            this.lueTurno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTurno.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 37, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueTurno.Properties.DataSource = this.turnoBindingSource;
            this.lueTurno.Properties.DisplayMember = "descripcion";
            this.lueTurno.Properties.NullText = "";
            this.lueTurno.Properties.ValueMember = "Id";
            this.lueTurno.Size = new System.Drawing.Size(234, 26);
            this.lueTurno.TabIndex = 44;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 414);
            this.Controls.Add(this.lueTurno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lueGrupo);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdSAve);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkSuperUsuario);
            this.Controls.Add(this.chkUsuarioHabilitado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesoGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTurno.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSuperUsuario;
        private System.Windows.Forms.CheckBox chkUsuarioHabilitado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdSAve;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.LookUpEdit lueGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource accesoGrupoBindingSource;
        private JAGUAR_APP.Accesos.dsAccesos dsAccesos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lueTurno;
    }
}