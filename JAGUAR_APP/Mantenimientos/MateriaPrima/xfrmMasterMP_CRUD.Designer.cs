
namespace JAGUAR_APP.Mantenimientos.MateriaPrima
{
    partial class xfrmMasterMP_CRUD
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
            this.txtComercial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ceAplica = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreCorto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lueTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.mPTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento = new JAGUAR_APP.Mantenimientos.dsMantenimiento();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.mPEstadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.luePresentacion = new DevExpress.XtraEditors.LookUpEdit();
            this.tiposPresentacionesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAplica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCorto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPEstadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposPresentacionesDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComercial
            // 
            this.txtComercial.Location = new System.Drawing.Point(246, 69);
            this.txtComercial.Name = "txtComercial";
            this.txtComercial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComercial.Properties.Appearance.Options.UseFont = true;
            this.txtComercial.Size = new System.Drawing.Size(327, 26);
            this.txtComercial.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(107, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nombre Comercial:";
            // 
            // ceAplica
            // 
            this.ceAplica.Location = new System.Drawing.Point(246, 318);
            this.ceAplica.Name = "ceAplica";
            this.ceAplica.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceAplica.Properties.Appearance.Options.UseFont = true;
            this.ceAplica.Properties.Caption = "Aplica Costos";
            this.ceAplica.Size = new System.Drawing.Size(126, 24);
            this.ceAplica.TabIndex = 5;
            this.ceAplica.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(107, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(153, 20);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nombre Corto________:";
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Location = new System.Drawing.Point(246, 110);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCorto.Properties.Appearance.Options.UseFont = true;
            this.txtNombreCorto.Size = new System.Drawing.Size(327, 26);
            this.txtNombreCorto.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(106, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(155, 20);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Código_________________:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(246, 151);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(160, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // lueTipo
            // 
            this.lueTipo.Location = new System.Drawing.Point(246, 192);
            this.lueTipo.Name = "lueTipo";
            this.lueTipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueTipo.Properties.Appearance.Options.UseFont = true;
            this.lueTipo.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lueTipo.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueTipo.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueTipo.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Tipo MP", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueTipo.Properties.DataSource = this.mPTipoBindingSource;
            this.lueTipo.Properties.DisplayMember = "descripcion";
            this.lueTipo.Properties.NullText = "";
            this.lueTipo.Properties.ValueMember = "id";
            this.lueTipo.Size = new System.Drawing.Size(327, 26);
            this.lueTipo.TabIndex = 3;
            // 
            // mPTipoBindingSource
            // 
            this.mPTipoBindingSource.DataMember = "MP_Tipo";
            this.mPTipoBindingSource.DataSource = this.dsMantenimiento;
            // 
            // dsMantenimiento
            // 
            this.dsMantenimiento.DataSetName = "dsMantenimiento";
            this.dsMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(107, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(149, 20);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Tipo___________________:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(107, 236);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 20);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Estado_______________";
            // 
            // lueEstado
            // 
            this.lueEstado.Location = new System.Drawing.Point(246, 233);
            this.lueEstado.Name = "lueEstado";
            this.lueEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueEstado.Properties.Appearance.Options.UseFont = true;
            this.lueEstado.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lueEstado.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueEstado.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lueEstado.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Estado", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueEstado.Properties.DataSource = this.mPEstadosBindingSource;
            this.lueEstado.Properties.DisplayMember = "descripcion";
            this.lueEstado.Properties.NullText = "";
            this.lueEstado.Properties.ValueMember = "id";
            this.lueEstado.Size = new System.Drawing.Size(229, 26);
            this.lueEstado.TabIndex = 4;
            // 
            // mPEstadosBindingSource
            // 
            this.mPEstadosBindingSource.DataMember = "MP_Estados";
            this.mPEstadosBindingSource.DataSource = this.dsMantenimiento;
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdNew.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.save_32x32;
            this.cmdNew.Location = new System.Drawing.Point(202, 361);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(139, 62);
            this.cmdNew.TabIndex = 5;
            this.cmdNew.Text = "Guardar";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.cancel;
            this.simpleButton1.Location = new System.Drawing.Point(373, 361);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 62);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(12, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(701, 25);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Materia Prima";
            // 
            // luePresentacion
            // 
            this.luePresentacion.Location = new System.Drawing.Point(246, 275);
            this.luePresentacion.Name = "luePresentacion";
            this.luePresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luePresentacion.Properties.Appearance.Options.UseFont = true;
            this.luePresentacion.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.luePresentacion.Properties.AppearanceDropDown.Options.UseFont = true;
            this.luePresentacion.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.luePresentacion.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.luePresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePresentacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Presentación", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luePresentacion.Properties.DataSource = this.tiposPresentacionesDataTableBindingSource;
            this.luePresentacion.Properties.DisplayMember = "descripcion";
            this.luePresentacion.Properties.NullText = "";
            this.luePresentacion.Properties.ValueMember = "id";
            this.luePresentacion.Size = new System.Drawing.Size(229, 26);
            this.luePresentacion.TabIndex = 12;
            // 
            // tiposPresentacionesDataTableBindingSource
            // 
            this.tiposPresentacionesDataTableBindingSource.DataMember = "TiposPresentacionesDataTable";
            this.tiposPresentacionesDataTableBindingSource.DataSource = this.dsMantenimiento;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(107, 278);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(163, 20);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Presentación____________";
            // 
            // xfrmMasterMP_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 445);
            this.Controls.Add(this.luePresentacion);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.lueEstado);
            this.Controls.Add(this.lueTipo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombreCorto);
            this.Controls.Add(this.ceAplica);
            this.Controls.Add(this.txtComercial);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmMasterMP_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materia Prima";
            this.Load += new System.EventHandler(this.xfrmMasterMP_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAplica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCorto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPEstadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposPresentacionesDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtComercial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ceAplica;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombreCorto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LookUpEdit lueTipo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lueEstado;
        private System.Windows.Forms.BindingSource mPEstadosBindingSource;
        private dsMantenimiento dsMantenimiento;
        private System.Windows.Forms.BindingSource mPTipoBindingSource;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit luePresentacion;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.BindingSource tiposPresentacionesDataTableBindingSource;
    }
}