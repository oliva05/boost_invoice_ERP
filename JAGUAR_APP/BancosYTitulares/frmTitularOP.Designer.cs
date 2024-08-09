
namespace JAGUAR_APP.BancosYTitulares
{
    partial class frmTitularOP
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitularOP));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcCuentas = new DevExpress.XtraGrid.GridControl();
            this.dsBancos1 = new JAGUAR_APP.BancosYTitulares.dsBancos();
            this.gvCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposBancos = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.listabancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposComboMoneda = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.coltipo_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposTipoCuentas = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.listatipocuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentidad = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.TsActivo = new DevExpress.XtraEditors.ToggleSwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdAddDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddHeader = new DevExpress.XtraEditors.SimpleButton();
            this.btnCloseHeader = new DevExpress.XtraEditors.SimpleButton();
            this.repostDeleteMemory = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listabancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposComboMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposTipoCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listatipocuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TsActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repostDeleteMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCuentas
            // 
            this.gcCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCuentas.DataMember = "listados_cuentas_by_id";
            this.gcCuentas.DataSource = this.dsBancos1;
            this.gcCuentas.Location = new System.Drawing.Point(4, 318);
            this.gcCuentas.MainView = this.gvCuentas;
            this.gcCuentas.Name = "gcCuentas";
            this.gcCuentas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposBancos,
            this.reposTipoCuentas,
            this.reposComboMoneda,
            this.repostDeleteMemory});
            this.gcCuentas.Size = new System.Drawing.Size(819, 235);
            this.gcCuentas.TabIndex = 0;
            this.gcCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCuentas});
            // 
            // dsBancos1
            // 
            this.dsBancos1.DataSetName = "dsBancos";
            this.dsBancos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvCuentas
            // 
            this.gvCuentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cuenta,
            this.colid_banco,
            this.colnum_cuenta,
            this.colmoneda,
            this.coltipo_cuenta,
            this.colactivo,
            this.gridColumn1});
            this.gvCuentas.GridControl = this.gcCuentas;
            this.gvCuentas.Name = "gvCuentas";
            this.gvCuentas.OptionsView.ShowGroupPanel = false;
            // 
            // colid_cuenta
            // 
            this.colid_cuenta.FieldName = "id_cuenta";
            this.colid_cuenta.Name = "colid_cuenta";
            this.colid_cuenta.OptionsColumn.AllowEdit = false;
            // 
            // colid_banco
            // 
            this.colid_banco.Caption = "Banco";
            this.colid_banco.ColumnEdit = this.reposBancos;
            this.colid_banco.FieldName = "id_banco";
            this.colid_banco.Name = "colid_banco";
            this.colid_banco.Visible = true;
            this.colid_banco.VisibleIndex = 0;
            this.colid_banco.Width = 130;
            // 
            // reposBancos
            // 
            this.reposBancos.AutoHeight = false;
            this.reposBancos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposBancos.DataSource = this.listabancosBindingSource;
            this.reposBancos.DisplayMember = "descripcion_banco";
            this.reposBancos.Name = "reposBancos";
            this.reposBancos.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.reposBancos.ValueMember = "id";
            // 
            // listabancosBindingSource
            // 
            this.listabancosBindingSource.DataMember = "lista_bancos";
            this.listabancosBindingSource.DataSource = this.dsBancos1;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion_banco});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion_banco
            // 
            this.coldescripcion_banco.Caption = "Seleccione";
            this.coldescripcion_banco.FieldName = "descripcion_banco";
            this.coldescripcion_banco.Name = "coldescripcion_banco";
            this.coldescripcion_banco.OptionsColumn.AllowEdit = false;
            this.coldescripcion_banco.Visible = true;
            this.coldescripcion_banco.VisibleIndex = 0;
            // 
            // colnum_cuenta
            // 
            this.colnum_cuenta.Caption = "Numero de Cuenta";
            this.colnum_cuenta.FieldName = "num_cuenta";
            this.colnum_cuenta.Name = "colnum_cuenta";
            this.colnum_cuenta.Visible = true;
            this.colnum_cuenta.VisibleIndex = 1;
            this.colnum_cuenta.Width = 164;
            // 
            // colmoneda
            // 
            this.colmoneda.Caption = "Moneda";
            this.colmoneda.ColumnEdit = this.reposComboMoneda;
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 2;
            this.colmoneda.Width = 164;
            // 
            // reposComboMoneda
            // 
            this.reposComboMoneda.AutoHeight = false;
            this.reposComboMoneda.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposComboMoneda.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.reposComboMoneda.Items.AddRange(new object[] {
            "LPS",
            "USD",
            "EUR"});
            this.reposComboMoneda.Name = "reposComboMoneda";
            this.reposComboMoneda.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // coltipo_cuenta
            // 
            this.coltipo_cuenta.Caption = "Tipo de Cuenta";
            this.coltipo_cuenta.ColumnEdit = this.reposTipoCuentas;
            this.coltipo_cuenta.FieldName = "tipo_cuenta";
            this.coltipo_cuenta.Name = "coltipo_cuenta";
            this.coltipo_cuenta.Visible = true;
            this.coltipo_cuenta.VisibleIndex = 3;
            this.coltipo_cuenta.Width = 196;
            // 
            // reposTipoCuentas
            // 
            this.reposTipoCuentas.AutoHeight = false;
            this.reposTipoCuentas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposTipoCuentas.DataSource = this.listatipocuentaBindingSource;
            this.reposTipoCuentas.DisplayMember = "descripcion";
            this.reposTipoCuentas.Name = "reposTipoCuentas";
            this.reposTipoCuentas.PopupView = this.gridView1;
            this.reposTipoCuentas.ValueMember = "id";
            // 
            // listatipocuentaBindingSource
            // 
            this.listatipocuentaBindingSource.DataMember = "lista_tipo_cuenta";
            this.listatipocuentaBindingSource.DataSource = this.dsBancos1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Seleccione";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colactivo
            // 
            this.colactivo.Caption = "Activo";
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.Visible = true;
            this.colactivo.VisibleIndex = 4;
            this.colactivo.Width = 140;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(352, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(264, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nombre Completo______________________:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(352, 189);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Properties.Appearance.Options.UseFont = true;
            this.TxtTelefono.Size = new System.Drawing.Size(264, 26);
            this.TxtTelefono.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "Telefono___________________________:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(352, 227);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Properties.Appearance.Options.UseFont = true;
            this.txtCorreo.Size = new System.Drawing.Size(264, 26);
            this.txtCorreo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "Correo___________________________:";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(352, 116);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Properties.Appearance.Options.UseFont = true;
            this.txtIdentidad.Size = new System.Drawing.Size(264, 26);
            this.txtIdentidad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 19);
            this.label5.TabIndex = 81;
            this.label5.Text = "Num. Identidad______________________:";
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(352, 151);
            this.txtRTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Size = new System.Drawing.Size(264, 26);
            this.txtRTN.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 19);
            this.label6.TabIndex = 83;
            this.label6.Text = "Num. RTN______________________:";
            // 
            // TsActivo
            // 
            this.TsActivo.EditValue = true;
            this.TsActivo.Location = new System.Drawing.Point(435, 276);
            this.TsActivo.Name = "TsActivo";
            this.TsActivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TsActivo.Properties.Appearance.Options.UseFont = true;
            this.TsActivo.Properties.OffText = "No";
            this.TsActivo.Properties.OnText = "Si";
            this.TsActivo.Size = new System.Drawing.Size(95, 22);
            this.TsActivo.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 19);
            this.label7.TabIndex = 117;
            this.label7.Text = "Activo________________________:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(352, -1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 25);
            this.labelControl1.TabIndex = 118;
            this.labelControl1.Text = "Gestion de Titular";
            // 
            // cmdAddDetalle
            // 
            this.cmdAddDetalle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddDetalle.ImageOptions.Image")));
            this.cmdAddDetalle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdAddDetalle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAddDetalle.Location = new System.Drawing.Point(12, 278);
            this.cmdAddDetalle.Name = "cmdAddDetalle";
            this.cmdAddDetalle.Size = new System.Drawing.Size(111, 34);
            this.cmdAddDetalle.TabIndex = 7;
            this.cmdAddDetalle.Tag = "Agregar Item o Servicio";
            this.cmdAddDetalle.Text = "Agregar Cuenta";
            this.cmdAddDetalle.ToolTip = "Guardar";
            this.cmdAddDetalle.Click += new System.EventHandler(this.cmdAddDetalle_Click);
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHeader.Appearance.Options.UseFont = true;
            this.btnAddHeader.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHeader.ImageOptions.Image")));
            this.btnAddHeader.Location = new System.Drawing.Point(12, 8);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(111, 36);
            this.btnAddHeader.TabIndex = 120;
            this.btnAddHeader.Text = "Guardar";
            this.btnAddHeader.Click += new System.EventHandler(this.btnAddHeader_Click);
            // 
            // btnCloseHeader
            // 
            this.btnCloseHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCloseHeader.Appearance.Options.UseFont = true;
            this.btnCloseHeader.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCloseHeader.ImageOptions.SvgImage")));
            this.btnCloseHeader.Location = new System.Drawing.Point(722, 12);
            this.btnCloseHeader.Name = "btnCloseHeader";
            this.btnCloseHeader.Size = new System.Drawing.Size(93, 36);
            this.btnCloseHeader.TabIndex = 121;
            this.btnCloseHeader.Text = "Cerrar";
            this.btnCloseHeader.Click += new System.EventHandler(this.btnCloseHeader_Click);
            // 
            // repostDeleteMemory
            // 
            this.repostDeleteMemory.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repostDeleteMemory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repostDeleteMemory.Name = "repostDeleteMemory";
            this.repostDeleteMemory.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repostDeleteMemory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repostDeleteMemory_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.repostDeleteMemory;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // frmTitularOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 554);
            this.Controls.Add(this.btnCloseHeader);
            this.Controls.Add(this.btnAddHeader);
            this.Controls.Add(this.cmdAddDetalle);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TsActivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gcCuentas);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTitularOP";
            ((System.ComponentModel.ISupportInitialize)(this.gcCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listabancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposComboMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposTipoCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listatipocuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TsActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repostDeleteMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCuentas;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtTelefono;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtIdentidad;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ToggleSwitch TsActivo;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdAddDetalle;
        private DevExpress.XtraEditors.SimpleButton btnAddHeader;
        private DevExpress.XtraEditors.SimpleButton btnCloseHeader;
        private dsBancos dsBancos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_banco;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reposBancos;
        private System.Windows.Forms.BindingSource listabancosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_banco;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reposTipoCuentas;
        private System.Windows.Forms.BindingSource listatipocuentaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox reposComboMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repostDeleteMemory;
    }
}