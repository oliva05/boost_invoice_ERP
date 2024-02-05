
namespace JAGUAR_APP.JaguarProduccion
{
    partial class frmAddAvanceProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAvanceProduccion));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsLogisticaJaguar1 = new JAGUAR_APP.LogisticaJaguar.dsLogisticaJaguar();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_arrobas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_grupo_panaderos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoPanaderos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_latas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_bolsas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Column_Print = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSumarOne = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRestarOne = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRestarFive = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSumarFive = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRestarTen = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSumarTen = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAplicarCambios = new DevExpress.XtraEditors.SimpleButton();
            this.lblDescripcionCantidad = new DevExpress.XtraEditors.LabelControl();
            this.txtCantLatas = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colcant_latas_real = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantLatas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Home_Production_orders";
            this.gridControl1.DataSource = this.dsLogisticaJaguar1;
            this.gridControl1.Location = new System.Drawing.Point(1, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(819, 269);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsLogisticaJaguar1
            // 
            this.dsLogisticaJaguar1.DataSetName = "dsLogisticaJaguar";
            this.dsLogisticaJaguar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfecha,
            this.colid_pt,
            this.colItemCode,
            this.colItemName,
            this.colid_formula,
            this.colcant_arrobas,
            this.colid_grupo_panaderos,
            this.colGrupoPanaderos,
            this.collote,
            this.colenable,
            this.coldate_row,
            this.colid_user,
            this.colUsuarioNombre,
            this.colid_estado,
            this.colDocNum,
            this.colseleccionado,
            this.colEstado,
            this.colcant_latas,
            this.colcant_bolsas,
            this.Column_Print,
            this.colcant_latas_real});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            this.colfecha.Width = 67;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.ReadOnly = true;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 2;
            this.colItemCode.Width = 66;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 3;
            this.colItemName.Width = 159;
            // 
            // colid_formula
            // 
            this.colid_formula.FieldName = "id_formula";
            this.colid_formula.Name = "colid_formula";
            this.colid_formula.OptionsColumn.ReadOnly = true;
            // 
            // colcant_arrobas
            // 
            this.colcant_arrobas.DisplayFormat.FormatString = "n4";
            this.colcant_arrobas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_arrobas.FieldName = "cant_arrobas";
            this.colcant_arrobas.Name = "colcant_arrobas";
            this.colcant_arrobas.OptionsColumn.ReadOnly = true;
            this.colcant_arrobas.Width = 79;
            // 
            // colid_grupo_panaderos
            // 
            this.colid_grupo_panaderos.FieldName = "id_grupo_panaderos";
            this.colid_grupo_panaderos.Name = "colid_grupo_panaderos";
            this.colid_grupo_panaderos.OptionsColumn.ReadOnly = true;
            // 
            // colGrupoPanaderos
            // 
            this.colGrupoPanaderos.FieldName = "Grupo Panaderos";
            this.colGrupoPanaderos.Name = "colGrupoPanaderos";
            this.colGrupoPanaderos.OptionsColumn.ReadOnly = true;
            this.colGrupoPanaderos.Visible = true;
            this.colGrupoPanaderos.VisibleIndex = 6;
            this.colGrupoPanaderos.Width = 164;
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.ReadOnly = true;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // coldate_row
            // 
            this.coldate_row.FieldName = "date_row";
            this.coldate_row.Name = "coldate_row";
            this.coldate_row.OptionsColumn.ReadOnly = true;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.OptionsColumn.ReadOnly = true;
            // 
            // colUsuarioNombre
            // 
            this.colUsuarioNombre.FieldName = "Usuario Nombre";
            this.colUsuarioNombre.Name = "colUsuarioNombre";
            this.colUsuarioNombre.OptionsColumn.ReadOnly = true;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.ReadOnly = true;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 1;
            this.colDocNum.Width = 73;
            // 
            // colseleccionado
            // 
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 7;
            this.colseleccionado.Width = 86;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Width = 118;
            // 
            // colcant_latas
            // 
            this.colcant_latas.DisplayFormat.FormatString = "n4";
            this.colcant_latas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_latas.FieldName = "cant_latas";
            this.colcant_latas.Name = "colcant_latas";
            this.colcant_latas.OptionsColumn.ReadOnly = true;
            this.colcant_latas.Visible = true;
            this.colcant_latas.VisibleIndex = 4;
            this.colcant_latas.Width = 85;
            // 
            // colcant_bolsas
            // 
            this.colcant_bolsas.DisplayFormat.FormatString = "n4";
            this.colcant_bolsas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_bolsas.FieldName = "cant_bolsas";
            this.colcant_bolsas.Name = "colcant_bolsas";
            this.colcant_bolsas.OptionsColumn.ReadOnly = true;
            this.colcant_bolsas.Width = 71;
            // 
            // Column_Print
            // 
            this.Column_Print.Caption = "Imprimir";
            this.Column_Print.Name = "Column_Print";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(1, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(240, 34);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Ordenes de Fabricación";
            // 
            // cmdSumarOne
            // 
            this.cmdSumarOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSumarOne.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cmdSumarOne.Appearance.Options.UseFont = true;
            this.cmdSumarOne.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSumarOne.Location = new System.Drawing.Point(305, 325);
            this.cmdSumarOne.Name = "cmdSumarOne";
            this.cmdSumarOne.Size = new System.Drawing.Size(75, 46);
            this.cmdSumarOne.TabIndex = 40;
            this.cmdSumarOne.Text = "+1";
            this.cmdSumarOne.Click += new System.EventHandler(this.cmdSumarOne_Click);
            // 
            // cmdRestarOne
            // 
            this.cmdRestarOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRestarOne.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cmdRestarOne.Appearance.Options.UseFont = true;
            this.cmdRestarOne.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRestarOne.Location = new System.Drawing.Point(305, 377);
            this.cmdRestarOne.Name = "cmdRestarOne";
            this.cmdRestarOne.Size = new System.Drawing.Size(75, 46);
            this.cmdRestarOne.TabIndex = 41;
            this.cmdRestarOne.Text = "-1";
            this.cmdRestarOne.Click += new System.EventHandler(this.cmdRestarOne_Click);
            // 
            // cmdRestarFive
            // 
            this.cmdRestarFive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRestarFive.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cmdRestarFive.Appearance.Options.UseFont = true;
            this.cmdRestarFive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRestarFive.Location = new System.Drawing.Point(386, 377);
            this.cmdRestarFive.Name = "cmdRestarFive";
            this.cmdRestarFive.Size = new System.Drawing.Size(75, 46);
            this.cmdRestarFive.TabIndex = 43;
            this.cmdRestarFive.Text = "-5";
            this.cmdRestarFive.Click += new System.EventHandler(this.cmdRestarFive_Click);
            // 
            // cmdSumarFive
            // 
            this.cmdSumarFive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSumarFive.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cmdSumarFive.Appearance.Options.UseFont = true;
            this.cmdSumarFive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSumarFive.Location = new System.Drawing.Point(386, 325);
            this.cmdSumarFive.Name = "cmdSumarFive";
            this.cmdSumarFive.Size = new System.Drawing.Size(75, 46);
            this.cmdSumarFive.TabIndex = 42;
            this.cmdSumarFive.Text = "+5";
            this.cmdSumarFive.Click += new System.EventHandler(this.cmdSumarFive_Click);
            // 
            // cmdRestarTen
            // 
            this.cmdRestarTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRestarTen.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cmdRestarTen.Appearance.Options.UseFont = true;
            this.cmdRestarTen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRestarTen.Location = new System.Drawing.Point(467, 377);
            this.cmdRestarTen.Name = "cmdRestarTen";
            this.cmdRestarTen.Size = new System.Drawing.Size(75, 46);
            this.cmdRestarTen.TabIndex = 45;
            this.cmdRestarTen.Text = "-10";
            this.cmdRestarTen.Click += new System.EventHandler(this.cmdRestarTen_Click);
            // 
            // cmdSumarTen
            // 
            this.cmdSumarTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSumarTen.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cmdSumarTen.Appearance.Options.UseFont = true;
            this.cmdSumarTen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSumarTen.Location = new System.Drawing.Point(467, 325);
            this.cmdSumarTen.Name = "cmdSumarTen";
            this.cmdSumarTen.Size = new System.Drawing.Size(75, 46);
            this.cmdSumarTen.TabIndex = 44;
            this.cmdSumarTen.Text = "+10";
            this.cmdSumarTen.Click += new System.EventHandler(this.cmdSumarTen_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(706, 346);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 46);
            this.simpleButton1.TabIndex = 46;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdAplicarCambios
            // 
            this.cmdAplicarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAplicarCambios.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdAplicarCambios.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmdAplicarCambios.Appearance.Options.UseBackColor = true;
            this.cmdAplicarCambios.Appearance.Options.UseFont = true;
            this.cmdAplicarCambios.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicarCambios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAplicarCambios.ImageOptions.Image")));
            this.cmdAplicarCambios.Location = new System.Drawing.Point(595, 346);
            this.cmdAplicarCambios.Name = "cmdAplicarCambios";
            this.cmdAplicarCambios.Size = new System.Drawing.Size(105, 46);
            this.cmdAplicarCambios.TabIndex = 47;
            this.cmdAplicarCambios.Text = "Aplicar";
            this.cmdAplicarCambios.Click += new System.EventHandler(this.cmdAplicarCambios_Click);
            // 
            // lblDescripcionCantidad
            // 
            this.lblDescripcionCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescripcionCantidad.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionCantidad.Appearance.Options.UseFont = true;
            this.lblDescripcionCantidad.Appearance.Options.UseTextOptions = true;
            this.lblDescripcionCantidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblDescripcionCantidad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblDescripcionCantidad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDescripcionCantidad.Location = new System.Drawing.Point(5, 355);
            this.lblDescripcionCantidad.Name = "lblDescripcionCantidad";
            this.lblDescripcionCantidad.Size = new System.Drawing.Size(196, 34);
            this.lblDescripcionCantidad.TabIndex = 38;
            this.lblDescripcionCantidad.Text = "Cantidad de Latas:";
            // 
            // txtCantLatas
            // 
            this.txtCantLatas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantLatas.Location = new System.Drawing.Point(189, 356);
            this.txtCantLatas.Name = "txtCantLatas";
            this.txtCantLatas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtCantLatas.Properties.Appearance.Options.UseFont = true;
            this.txtCantLatas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantLatas.Size = new System.Drawing.Size(100, 36);
            this.txtCantLatas.TabIndex = 48;
            this.txtCantLatas.EditValueChanged += new System.EventHandler(this.txtCantLatas_EditValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // colcant_latas_real
            // 
            this.colcant_latas_real.DisplayFormat.FormatString = "n4";
            this.colcant_latas_real.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_latas_real.FieldName = "cant_latas_real";
            this.colcant_latas_real.Name = "colcant_latas_real";
            this.colcant_latas_real.OptionsColumn.ReadOnly = true;
            this.colcant_latas_real.Visible = true;
            this.colcant_latas_real.VisibleIndex = 5;
            this.colcant_latas_real.Width = 101;
            // 
            // frmAddAvanceProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 433);
            this.Controls.Add(this.txtCantLatas);
            this.Controls.Add(this.cmdAplicarCambios);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdRestarTen);
            this.Controls.Add(this.cmdSumarTen);
            this.Controls.Add(this.cmdRestarFive);
            this.Controls.Add(this.cmdSumarFive);
            this.Controls.Add(this.cmdRestarOne);
            this.Controls.Add(this.cmdSumarOne);
            this.Controls.Add(this.lblDescripcionCantidad);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmAddAvanceProduccion";
            this.Text = "Agregar Latas";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantLatas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private LogisticaJaguar.dsLogisticaJaguar dsLogisticaJaguar1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_formula;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_arrobas;
        private DevExpress.XtraGrid.Columns.GridColumn colid_grupo_panaderos;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoPanaderos;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_row;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_latas;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_bolsas;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn Column_Print;
        private DevExpress.XtraEditors.SimpleButton cmdSumarOne;
        private DevExpress.XtraEditors.SimpleButton cmdRestarOne;
        private DevExpress.XtraEditors.SimpleButton cmdRestarFive;
        private DevExpress.XtraEditors.SimpleButton cmdSumarFive;
        private DevExpress.XtraEditors.SimpleButton cmdRestarTen;
        private DevExpress.XtraEditors.SimpleButton cmdSumarTen;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraEditors.SimpleButton cmdAplicarCambios;
        private DevExpress.XtraEditors.LabelControl lblDescripcionCantidad;
        private DevExpress.XtraEditors.TextEdit txtCantLatas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_latas_real;
    }
}