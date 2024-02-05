
namespace JAGUAR_APP.Formulas
{
    partial class frmAddIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddIngrediente));
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitchEnableFormula = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblToggleSwitchEnable = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblTituloFormula = new DevExpress.XtraEditors.LabelControl();
            this.spinEditCantidadMP = new DevExpress.XtraEditors.SpinEdit();
            this.gridLookUpEditMateriaPrima = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceMateriaPrima = new System.Windows.Forms.BindingSource(this.components);
            this.dsFormulasCRUD1 = new JAGUAR_APP.Formulas.dsFormulasCRUD();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEditPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourcePresentacion = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnableFormula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditMateriaPrima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFormulasCRUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(59, 195);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(157, 42);
            this.cmdGuardar.TabIndex = 47;
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
            this.cmdCerrar.Location = new System.Drawing.Point(231, 195);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(157, 42);
            this.cmdCerrar.TabIndex = 48;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // toggleSwitchEnableFormula
            // 
            this.toggleSwitchEnableFormula.EditValue = true;
            this.toggleSwitchEnableFormula.Location = new System.Drawing.Point(186, 150);
            this.toggleSwitchEnableFormula.Name = "toggleSwitchEnableFormula";
            this.toggleSwitchEnableFormula.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleSwitchEnableFormula.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchEnableFormula.Properties.OffText = "No";
            this.toggleSwitchEnableFormula.Properties.OnText = "Si";
            this.toggleSwitchEnableFormula.Size = new System.Drawing.Size(115, 26);
            this.toggleSwitchEnableFormula.TabIndex = 53;
            this.toggleSwitchEnableFormula.Visible = false;
            // 
            // lblToggleSwitchEnable
            // 
            this.lblToggleSwitchEnable.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleSwitchEnable.Appearance.Options.UseFont = true;
            this.lblToggleSwitchEnable.Location = new System.Drawing.Point(78, 159);
            this.lblToggleSwitchEnable.Name = "lblToggleSwitchEnable";
            this.lblToggleSwitchEnable.Size = new System.Drawing.Size(144, 15);
            this.lblToggleSwitchEnable.TabIndex = 52;
            this.lblToggleSwitchEnable.Text = "Habilitada__________________";
            this.lblToggleSwitchEnable.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(78, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 15);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Cantidad__________________";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(78, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(154, 15);
            this.labelControl5.TabIndex = 49;
            this.labelControl5.Text = "Materia Prima________________";
            // 
            // lblTituloFormula
            // 
            this.lblTituloFormula.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormula.Appearance.Options.UseFont = true;
            this.lblTituloFormula.Appearance.Options.UseTextOptions = true;
            this.lblTituloFormula.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloFormula.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTituloFormula.Location = new System.Drawing.Point(12, 12);
            this.lblTituloFormula.Name = "lblTituloFormula";
            this.lblTituloFormula.Size = new System.Drawing.Size(404, 21);
            this.lblTituloFormula.TabIndex = 46;
            this.lblTituloFormula.Text = "Gestión de Ingrediente";
            // 
            // spinEditCantidadMP
            // 
            this.spinEditCantidadMP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCantidadMP.Location = new System.Drawing.Point(186, 94);
            this.spinEditCantidadMP.Name = "spinEditCantidadMP";
            this.spinEditCantidadMP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditCantidadMP.Properties.Appearance.Options.UseFont = true;
            this.spinEditCantidadMP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCantidadMP.Properties.DisplayFormat.FormatString = "n4";
            this.spinEditCantidadMP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditCantidadMP.Size = new System.Drawing.Size(177, 22);
            this.spinEditCantidadMP.TabIndex = 55;
            // 
            // gridLookUpEditMateriaPrima
            // 
            this.gridLookUpEditMateriaPrima.EditValue = "";
            this.gridLookUpEditMateriaPrima.Location = new System.Drawing.Point(186, 65);
            this.gridLookUpEditMateriaPrima.Name = "gridLookUpEditMateriaPrima";
            this.gridLookUpEditMateriaPrima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditMateriaPrima.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditMateriaPrima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditMateriaPrima.Properties.DataSource = this.bindingSourceMateriaPrima;
            this.gridLookUpEditMateriaPrima.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditMateriaPrima.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditMateriaPrima.Properties.ValueMember = "id";
            this.gridLookUpEditMateriaPrima.Size = new System.Drawing.Size(177, 22);
            this.gridLookUpEditMateriaPrima.TabIndex = 56;
            // 
            // bindingSourceMateriaPrima
            // 
            this.bindingSourceMateriaPrima.DataMember = "materia_prima";
            this.bindingSourceMateriaPrima.DataSource = this.dsFormulasCRUD1;
            // 
            // dsFormulasCRUD1
            // 
            this.dsFormulasCRUD1.DataSetName = "dsFormulasCRUD";
            this.dsFormulasCRUD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gridLookUpEditPresentacion
            // 
            this.gridLookUpEditPresentacion.EditValue = "";
            this.gridLookUpEditPresentacion.Location = new System.Drawing.Point(186, 122);
            this.gridLookUpEditPresentacion.Name = "gridLookUpEditPresentacion";
            this.gridLookUpEditPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditPresentacion.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditPresentacion.Properties.DataSource = this.bindingSourcePresentacion;
            this.gridLookUpEditPresentacion.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditPresentacion.Properties.PopupView = this.gridView1;
            this.gridLookUpEditPresentacion.Properties.ValueMember = "id";
            this.gridLookUpEditPresentacion.Size = new System.Drawing.Size(177, 22);
            this.gridLookUpEditPresentacion.TabIndex = 58;
            // 
            // bindingSourcePresentacion
            // 
            this.bindingSourcePresentacion.DataMember = "presentacion_mp";
            this.bindingSourcePresentacion.DataSource = this.dsFormulasCRUD1;
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(78, 129);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(148, 15);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Presentación________________";
            // 
            // frmAddIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 243);
            this.Controls.Add(this.gridLookUpEditPresentacion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridLookUpEditMateriaPrima);
            this.Controls.Add(this.spinEditCantidadMP);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.toggleSwitchEnableFormula);
            this.Controls.Add(this.lblToggleSwitchEnable);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblTituloFormula);
            this.Name = "frmAddIngrediente";
            this.Text = "Gestión Ingrediente";
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnableFormula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditMateriaPrima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFormulasCRUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchEnableFormula;
        private DevExpress.XtraEditors.LabelControl lblToggleSwitchEnable;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblTituloFormula;
        private DevExpress.XtraEditors.SpinEdit spinEditCantidadMP;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.BindingSource bindingSourceMateriaPrima;
        private dsFormulasCRUD dsFormulasCRUD1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource bindingSourcePresentacion;
    }
}