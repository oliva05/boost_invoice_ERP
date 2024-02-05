
namespace JAGUAR_APP.Formulas
{
    partial class frmAddFormulaH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFormulaH));
            this.lblTituloFormula = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoFormula = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.gridLookUpEdit_EstadosFormula = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEditTipoFormula = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bindingSourceEstados = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTipos = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsFormulasCRUD1 = new JAGUAR_APP.Formulas.dsFormulasCRUD();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcionFormulaNombre = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblToggleSwitchEnable = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchEnableFormula = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_EstadosFormula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoFormula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFormulasCRUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnableFormula.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormula
            // 
            this.lblTituloFormula.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormula.Appearance.Options.UseFont = true;
            this.lblTituloFormula.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloFormula.Location = new System.Drawing.Point(12, 24);
            this.lblTituloFormula.Name = "lblTituloFormula";
            this.lblTituloFormula.Size = new System.Drawing.Size(462, 21);
            this.lblTituloFormula.TabIndex = 2;
            this.lblTituloFormula.Text = "Receta Producto Terminado";
            // 
            // txtCodigoFormula
            // 
            this.txtCodigoFormula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoFormula.Location = new System.Drawing.Point(186, 75);
            this.txtCodigoFormula.Name = "txtCodigoFormula";
            this.txtCodigoFormula.Size = new System.Drawing.Size(177, 23);
            this.txtCodigoFormula.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(78, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(119, 15);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Código________________";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(78, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 15);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Versión__________________";
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVersion.Location = new System.Drawing.Point(186, 104);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(177, 23);
            this.txtVersion.TabIndex = 0;
            // 
            // gridLookUpEdit_EstadosFormula
            // 
            this.gridLookUpEdit_EstadosFormula.EditValue = "";
            this.gridLookUpEdit_EstadosFormula.Location = new System.Drawing.Point(186, 183);
            this.gridLookUpEdit_EstadosFormula.Name = "gridLookUpEdit_EstadosFormula";
            this.gridLookUpEdit_EstadosFormula.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit_EstadosFormula.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_EstadosFormula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_EstadosFormula.Properties.DataSource = this.bindingSourceEstados;
            this.gridLookUpEdit_EstadosFormula.Properties.DisplayMember = "descripcion";
            this.gridLookUpEdit_EstadosFormula.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit_EstadosFormula.Properties.ValueMember = "id";
            this.gridLookUpEdit_EstadosFormula.Size = new System.Drawing.Size(177, 22);
            this.gridLookUpEdit_EstadosFormula.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(79, 190);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(155, 15);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Estado________________________";
            // 
            // gridLookUpEditTipoFormula
            // 
            this.gridLookUpEditTipoFormula.EditValue = "";
            this.gridLookUpEditTipoFormula.Location = new System.Drawing.Point(186, 211);
            this.gridLookUpEditTipoFormula.Name = "gridLookUpEditTipoFormula";
            this.gridLookUpEditTipoFormula.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditTipoFormula.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditTipoFormula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditTipoFormula.Properties.DataSource = this.bindingSourceTipos;
            this.gridLookUpEditTipoFormula.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditTipoFormula.Properties.PopupView = this.gridView1;
            this.gridLookUpEditTipoFormula.Properties.ValueMember = "id";
            this.gridLookUpEditTipoFormula.Size = new System.Drawing.Size(177, 22);
            this.gridLookUpEditTipoFormula.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(79, 218);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(143, 15);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Tipo________________________";
            // 
            // bindingSourceEstados
            // 
            this.bindingSourceEstados.DataMember = "EstadosTable";
            this.bindingSourceEstados.DataSource = this.dsFormulasCRUD1;
            // 
            // bindingSourceTipos
            // 
            this.bindingSourceTipos.DataMember = "TiposTable";
            this.bindingSourceTipos.DataSource = this.dsFormulasCRUD1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // dsFormulasCRUD1
            // 
            this.dsFormulasCRUD1.DataSetName = "dsFormulasCRUD";
            this.dsFormulasCRUD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(79, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(152, 15);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Descripción__________________";
            // 
            // txtDescripcionFormulaNombre
            // 
            this.txtDescripcionFormulaNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcionFormulaNombre.Location = new System.Drawing.Point(186, 134);
            this.txtDescripcionFormulaNombre.Multiline = true;
            this.txtDescripcionFormulaNombre.Name = "txtDescripcionFormulaNombre";
            this.txtDescripcionFormulaNombre.Size = new System.Drawing.Size(177, 42);
            this.txtDescripcionFormulaNombre.TabIndex = 1;
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComentario.Location = new System.Drawing.Point(186, 297);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(177, 42);
            this.txtComentario.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(79, 324);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(153, 15);
            this.labelControl6.TabIndex = 37;
            this.labelControl6.Text = "Comentario__________________";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(78, 248);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(160, 15);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "Disponible desde______________";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(186, 241);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(177, 22);
            this.dtDesde.TabIndex = 4;
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(186, 269);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(177, 22);
            this.dtHasta.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(78, 276);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(159, 15);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "Disponible Hasta______________";
            // 
            // lblToggleSwitchEnable
            // 
            this.lblToggleSwitchEnable.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleSwitchEnable.Appearance.Options.UseFont = true;
            this.lblToggleSwitchEnable.Location = new System.Drawing.Point(78, 357);
            this.lblToggleSwitchEnable.Name = "lblToggleSwitchEnable";
            this.lblToggleSwitchEnable.Size = new System.Drawing.Size(144, 15);
            this.lblToggleSwitchEnable.TabIndex = 43;
            this.lblToggleSwitchEnable.Text = "Habilitada__________________";
            // 
            // toggleSwitchEnableFormula
            // 
            this.toggleSwitchEnableFormula.EditValue = true;
            this.toggleSwitchEnableFormula.Location = new System.Drawing.Point(186, 348);
            this.toggleSwitchEnableFormula.Name = "toggleSwitchEnableFormula";
            this.toggleSwitchEnableFormula.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleSwitchEnableFormula.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchEnableFormula.Properties.OffText = "No";
            this.toggleSwitchEnableFormula.Properties.OnText = "Si";
            this.toggleSwitchEnableFormula.Size = new System.Drawing.Size(115, 26);
            this.toggleSwitchEnableFormula.TabIndex = 44;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(69, 380);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(157, 42);
            this.cmdGuardar.TabIndex = 7;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Pink;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(241, 380);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(157, 42);
            this.cmdCerrar.TabIndex = 8;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmAddFormulaH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 425);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.toggleSwitchEnableFormula);
            this.Controls.Add(this.lblToggleSwitchEnable);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDescripcionFormulaNombre);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridLookUpEditTipoFormula);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridLookUpEdit_EstadosFormula);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodigoFormula);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblTituloFormula);
            this.Name = "frmAddFormulaH";
            this.Text = "Gestión de Receta";
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_EstadosFormula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoFormula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFormulasCRUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnableFormula.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTituloFormula;
        private System.Windows.Forms.TextBox txtCodigoFormula;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtVersion;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_EstadosFormula;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditTipoFormula;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private dsFormulasCRUD dsFormulasCRUD1;
        private System.Windows.Forms.BindingSource bindingSourceEstados;
        private System.Windows.Forms.BindingSource bindingSourceTipos;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtDescripcionFormulaNombre;
        private System.Windows.Forms.TextBox txtComentario;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblToggleSwitchEnable;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchEnableFormula;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
    }
}