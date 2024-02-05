
namespace JAGUAR_APP.JaguarProduccion
{
    partial class frmAddOrderProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrderProduction));
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceRecetas = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogisticaJaguar1 = new JAGUAR_APP.LogisticaJaguar.dsLogisticaJaguar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEditProductoTerminado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourcePT = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditCantArrobas = new DevExpress.XtraEditors.SpinEdit();
            this.txtRecetaName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFML_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFML_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_formula_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_formula_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditProductoTerminado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantArrobas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecetaName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(640, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(108, 41);
            this.cmdCerrar.TabIndex = 56;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.ToolTipTitle = "Guardar Entrada de Factura";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // bindingSourceRecetas
            // 
            this.bindingSourceRecetas.DataMember = "Productos_terminados_Recetas";
            this.bindingSourceRecetas.DataSource = this.dsLogisticaJaguar1;
            // 
            // dsLogisticaJaguar1
            // 
            this.dsLogisticaJaguar1.DataSetName = "dsLogisticaJaguar";
            this.dsLogisticaJaguar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(134, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 20);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Receta";
            this.labelControl1.Visible = false;
            // 
            // gridLookUpEditProductoTerminado
            // 
            this.gridLookUpEditProductoTerminado.EditValue = "";
            this.gridLookUpEditProductoTerminado.Location = new System.Drawing.Point(276, 12);
            this.gridLookUpEditProductoTerminado.Name = "gridLookUpEditProductoTerminado";
            this.gridLookUpEditProductoTerminado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditProductoTerminado.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditProductoTerminado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditProductoTerminado.Properties.DataSource = this.bindingSourcePT;
            this.gridLookUpEditProductoTerminado.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditProductoTerminado.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditProductoTerminado.Properties.ValueMember = "id";
            this.gridLookUpEditProductoTerminado.Size = new System.Drawing.Size(327, 26);
            this.gridLookUpEditProductoTerminado.TabIndex = 52;
            this.gridLookUpEditProductoTerminado.EditValueChanged += new System.EventHandler(this.gridLookUpEditProductoTerminado_EditValueChanged);
            // 
            // bindingSourcePT
            // 
            this.bindingSourcePT.DataMember = "Productos_terminados_list";
            this.bindingSourcePT.DataSource = this.dsLogisticaJaguar1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(134, 17);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(136, 20);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "Producto Terminado";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(3, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 41);
            this.cmdGuardar.TabIndex = 55;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.ToolTipTitle = "Guardar Entrada de Factura";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(134, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 20);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Cant. Arroba(s)";
            // 
            // spinEditCantArrobas
            // 
            this.spinEditCantArrobas.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditCantArrobas.Location = new System.Drawing.Point(276, 44);
            this.spinEditCantArrobas.Name = "spinEditCantArrobas";
            this.spinEditCantArrobas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.spinEditCantArrobas.Properties.Appearance.Options.UseFont = true;
            this.spinEditCantArrobas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCantArrobas.Size = new System.Drawing.Size(100, 26);
            this.spinEditCantArrobas.TabIndex = 58;
            this.spinEditCantArrobas.EditValueChanged += new System.EventHandler(this.spinEditCantArrobas_EditValueChanged);
            // 
            // txtRecetaName
            // 
            this.txtRecetaName.Location = new System.Drawing.Point(276, 75);
            this.txtRecetaName.Name = "txtRecetaName";
            this.txtRecetaName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtRecetaName.Properties.Appearance.Options.UseFont = true;
            this.txtRecetaName.Properties.ReadOnly = true;
            this.txtRecetaName.Size = new System.Drawing.Size(287, 26);
            this.txtRecetaName.TabIndex = 59;
            this.txtRecetaName.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(569, 75);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(34, 26);
            this.simpleButton1.TabIndex = 60;
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "orden_produccion_detalle";
            this.gridControl1.DataSource = this.dsLogisticaJaguar1;
            this.gridControl1.Location = new System.Drawing.Point(3, 110);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(835, 555);
            this.gridControl1.TabIndex = 61;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_mp,
            this.colItemCode,
            this.colItemName,
            this.colCantidad,
            this.colnum_linea,
            this.coltipo_id,
            this.colTipoName,
            this.colFML_CODE,
            this.colFML_Name,
            this.colid_formula_detalle,
            this.colid_formula_h,
            this.colid_presentacion,
            this.coltipo,
            this.coltipo_name,
            this.colUnidadMedida});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 4;
            this.colItemCode.Width = 71;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 5;
            this.colItemName.Width = 161;
            // 
            // colCantidad
            // 
            this.colCantidad.DisplayFormat.FormatString = "n4";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.ReadOnly = true;
            this.colCantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "SUMA={0:#.##}")});
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 6;
            this.colCantidad.Width = 128;
            // 
            // colnum_linea
            // 
            this.colnum_linea.FieldName = "num_linea";
            this.colnum_linea.Name = "colnum_linea";
            this.colnum_linea.OptionsColumn.ReadOnly = true;
            this.colnum_linea.Visible = true;
            this.colnum_linea.VisibleIndex = 0;
            this.colnum_linea.Width = 60;
            // 
            // coltipo_id
            // 
            this.coltipo_id.FieldName = "tipo_id";
            this.coltipo_id.Name = "coltipo_id";
            this.coltipo_id.OptionsColumn.ReadOnly = true;
            // 
            // colTipoName
            // 
            this.colTipoName.Caption = "Tipo Ingrediente";
            this.colTipoName.FieldName = "TipoName";
            this.colTipoName.Name = "colTipoName";
            this.colTipoName.OptionsColumn.ReadOnly = true;
            this.colTipoName.Width = 77;
            // 
            // colFML_CODE
            // 
            this.colFML_CODE.FieldName = "FML_CODE";
            this.colFML_CODE.Name = "colFML_CODE";
            this.colFML_CODE.Visible = true;
            this.colFML_CODE.VisibleIndex = 1;
            this.colFML_CODE.Width = 64;
            // 
            // colFML_Name
            // 
            this.colFML_Name.FieldName = "FML_Name";
            this.colFML_Name.Name = "colFML_Name";
            this.colFML_Name.Visible = true;
            this.colFML_Name.VisibleIndex = 2;
            this.colFML_Name.Width = 84;
            // 
            // colid_formula_detalle
            // 
            this.colid_formula_detalle.FieldName = "id_formula_detalle";
            this.colid_formula_detalle.Name = "colid_formula_detalle";
            // 
            // colid_formula_h
            // 
            this.colid_formula_h.FieldName = "id_formula_h";
            this.colid_formula_h.Name = "colid_formula_h";
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            // 
            // coltipo
            // 
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            // 
            // coltipo_name
            // 
            this.coltipo_name.Caption = "Tipo";
            this.coltipo_name.FieldName = "tipo_name";
            this.coltipo_name.Name = "coltipo_name";
            this.coltipo_name.Visible = true;
            this.coltipo_name.VisibleIndex = 3;
            this.coltipo_name.Width = 62;
            // 
            // colUnidadMedida
            // 
            this.colUnidadMedida.FieldName = "UnidadMedida";
            this.colUnidadMedida.Name = "colUnidadMedida";
            this.colUnidadMedida.OptionsColumn.ReadOnly = true;
            this.colUnidadMedida.Visible = true;
            this.colUnidadMedida.VisibleIndex = 7;
            this.colUnidadMedida.Width = 110;
            // 
            // frmAddOrderProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 668);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtRecetaName);
            this.Controls.Add(this.spinEditCantArrobas);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridLookUpEditProductoTerminado);
            this.Controls.Add(this.labelControl4);
            this.Name = "frmAddOrderProduction";
            this.Text = "New Order Production";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditProductoTerminado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantArrobas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecetaName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditProductoTerminado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEditCantArrobas;
        private LogisticaJaguar.dsLogisticaJaguar dsLogisticaJaguar1;
        private System.Windows.Forms.BindingSource bindingSourcePT;
        private System.Windows.Forms.BindingSource bindingSourceRecetas;
        private DevExpress.XtraEditors.TextEdit txtRecetaName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_linea;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_id;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoName;
        private DevExpress.XtraGrid.Columns.GridColumn colFML_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colFML_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colid_formula_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colid_formula_h;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_name;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadMedida;
    }
}