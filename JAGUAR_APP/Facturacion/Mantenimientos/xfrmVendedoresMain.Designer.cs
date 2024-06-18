
namespace JAGUAR_APP.Facturacion.Mantenimientos
{
    partial class xfrmVendedoresMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmVendedoresMain));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject25 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject26 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject27 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject28 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject29 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject30 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject31 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject32 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions9 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject33 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject34 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject35 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject36 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcClientes = new DevExpress.XtraGrid.GridControl();
            this.dsMantenimientosFacturacion1 = new JAGUAR_APP.Facturacion.Mantenimientos.dsMantenimientosFacturacion();
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomision_porcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_modi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdContact = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tsActivo = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsActivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnActualizar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Appearance.Options.UseBackColor = true;
            this.btnActualizar.Appearance.Options.UseFont = true;
            this.btnActualizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(836, 59);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 47);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.BackColor = System.Drawing.Color.Coral;
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseBackColor = true;
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdClose.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.cancel;
            this.cmdClose.Location = new System.Drawing.Point(976, 59);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(114, 47);
            this.cmdClose.TabIndex = 15;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdNew.ImageOptions.SvgImage")));
            this.cmdNew.Location = new System.Drawing.Point(12, 59);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(114, 47);
            this.cmdNew.TabIndex = 14;
            this.cmdNew.Text = "Nuevo";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1154, 25);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Vendedores";
            // 
            // gcClientes
            // 
            this.gcClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcClientes.DataMember = "Vendedores";
            this.gcClientes.DataSource = this.dsMantenimientosFacturacion1;
            this.gcClientes.Location = new System.Drawing.Point(1, 134);
            this.gcClientes.MainView = this.gvClientes;
            this.gcClientes.Name = "gcClientes";
            this.gcClientes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEdit,
            this.cmdDelete,
            this.cmdContact});
            this.gcClientes.Size = new System.Drawing.Size(1089, 398);
            this.gcClientes.TabIndex = 13;
            this.gcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // dsMantenimientosFacturacion1
            // 
            this.dsMantenimientosFacturacion1.DataSetName = "dsMantenimientosFacturacion";
            this.dsMantenimientosFacturacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvClientes
            // 
            this.gvClientes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gvClientes.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvClientes.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gvClientes.Appearance.Row.Options.UseFont = true;
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnombre,
            this.coltelefono,
            this.colemail,
            this.colcomision_porcentaje,
            this.colusuario_creador,
            this.colfecha_creacion,
            this.colusuario_modi,
            this.gridColumn1,
            this.gridColumn2});
            this.gvClientes.GridControl = this.gcClientes;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsEditForm.PopupEditFormWidth = 686;
            this.gvClientes.OptionsView.ShowAutoFilterRow = true;
            this.gvClientes.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Codigo";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 122;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 122;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.AllowEdit = false;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 2;
            this.coltelefono.Width = 122;
            // 
            // colemail
            // 
            this.colemail.Caption = "Correo";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 3;
            this.colemail.Width = 122;
            // 
            // colcomision_porcentaje
            // 
            this.colcomision_porcentaje.Caption = "% Comision";
            this.colcomision_porcentaje.FieldName = "comision_porcentaje";
            this.colcomision_porcentaje.Name = "colcomision_porcentaje";
            this.colcomision_porcentaje.OptionsColumn.AllowEdit = false;
            this.colcomision_porcentaje.Width = 114;
            // 
            // colusuario_creador
            // 
            this.colusuario_creador.Caption = "Creador por:";
            this.colusuario_creador.FieldName = "usuario_creador";
            this.colusuario_creador.Name = "colusuario_creador";
            this.colusuario_creador.OptionsColumn.AllowEdit = false;
            this.colusuario_creador.Visible = true;
            this.colusuario_creador.VisibleIndex = 5;
            this.colusuario_creador.Width = 118;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha Creacion";
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.OptionsColumn.AllowEdit = false;
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 6;
            this.colfecha_creacion.Width = 118;
            // 
            // colusuario_modi
            // 
            this.colusuario_modi.Caption = "Modificado por:";
            this.colusuario_modi.FieldName = "usuario_modi";
            this.colusuario_modi.Name = "colusuario_modi";
            this.colusuario_modi.OptionsColumn.AllowEdit = false;
            this.colusuario_modi.Visible = true;
            this.colusuario_modi.VisibleIndex = 7;
            this.colusuario_modi.Width = 107;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.cmdEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 94;
            // 
            // cmdEdit
            // 
            this.cmdEdit.AutoHeight = false;
            editorButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions7.Image")));
            this.cmdEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions7, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject25, serializableAppearanceObject26, serializableAppearanceObject27, serializableAppearanceObject28, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEdit_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "RTN";
            this.gridColumn2.FieldName = "RTN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 139;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoHeight = false;
            editorButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions8.Image")));
            this.cmdDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions8, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject29, serializableAppearanceObject30, serializableAppearanceObject31, serializableAppearanceObject32, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdContact
            // 
            this.cmdContact.AutoHeight = false;
            editorButtonImageOptions9.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions9.SvgImage")));
            this.cmdContact.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions9, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject33, serializableAppearanceObject34, serializableAppearanceObject35, serializableAppearanceObject36, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdContact.Name = "cmdContact";
            this.cmdContact.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // tsActivo
            // 
            this.tsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsActivo.EditValue = true;
            this.tsActivo.Location = new System.Drawing.Point(561, 80);
            this.tsActivo.Name = "tsActivo";
            this.tsActivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsActivo.Properties.Appearance.Options.UseFont = true;
            this.tsActivo.Properties.OffText = "No";
            this.tsActivo.Properties.OnText = "Si";
            this.tsActivo.Size = new System.Drawing.Size(128, 26);
            this.tsActivo.TabIndex = 18;
            this.tsActivo.Toggled += new System.EventHandler(this.tsActivo_Toggled);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(451, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 25);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Ver Activos";
            // 
            // xfrmVendedoresMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 535);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tsActivo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcClientes);
            this.Name = "xfrmVendedoresMain";
            this.Text = "xfrmVendedoresMain";
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsActivo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdContact;
        private dsMantenimientosFacturacion dsMantenimientosFacturacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colcomision_porcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_modi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.ToggleSwitch tsActivo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}