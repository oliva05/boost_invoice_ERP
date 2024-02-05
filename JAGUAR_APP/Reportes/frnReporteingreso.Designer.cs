namespace JAGUAR_APP.Reportes
{
    partial class frnReporteingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnReporteingreso));
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.grdYEAR = new DevExpress.XtraEditors.GridLookUpEdit();
            this.yearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes = new JAGUAR_APP.Reportes.dsReportes();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyeardate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblyear = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprovedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmateriaprima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcartilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_produccion_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechainicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechafinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colantiguedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdYEAR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Appearance.Options.UseFont = true;
            this.btnclose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(506, 9);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(199, 71);
            this.btnclose.TabIndex = 35;
            this.btnclose.Text = "Home";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // grdYEAR
            // 
            this.grdYEAR.Location = new System.Drawing.Point(50, 90);
            this.grdYEAR.Name = "grdYEAR";
            this.grdYEAR.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdYEAR.Properties.Appearance.Options.UseFont = true;
            this.grdYEAR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdYEAR.Properties.DataSource = this.yearBindingSource;
            this.grdYEAR.Properties.DisplayMember = "year";
            this.grdYEAR.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdYEAR.Properties.ValueMember = "yeardate";
            this.grdYEAR.Size = new System.Drawing.Size(313, 28);
            this.grdYEAR.TabIndex = 36;
            this.grdYEAR.EditValueChanged += new System.EventHandler(this.grdYEAR_EditValueChanged);
            // 
            // yearBindingSource
            // 
            this.yearBindingSource.DataMember = "year";
            this.yearBindingSource.DataSource = this.dsReportes;
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "dsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.GroupFooter.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colyear,
            this.colyeardate});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colyear
            // 
            this.colyear.Caption = "Año";
            this.colyear.FieldName = "year";
            this.colyear.Name = "colyear";
            this.colyear.Visible = true;
            this.colyear.VisibleIndex = 0;
            // 
            // colyeardate
            // 
            this.colyeardate.FieldName = "yeardate";
            this.colyeardate.Name = "colyeardate";
            // 
            // lblyear
            // 
            this.lblyear.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Appearance.Options.UseFont = true;
            this.lblyear.Location = new System.Drawing.Point(6, 97);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(38, 21);
            this.lblyear.TabIndex = 37;
            this.lblyear.Text = "Año: ";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "ingreso_lm";
            this.grd_data.DataSource = this.dsReportes;
            this.grd_data.Location = new System.Drawing.Point(0, 124);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(715, 399);
            this.grd_data.TabIndex = 38;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha_ingreso,
            this.colcodigo,
            this.colprovedor,
            this.colmateriaprima,
            this.colcantidad,
            this.colcategoria,
            this.colcartilla,
            this.collote_materia_prima,
            this.colfecha_produccion_materia_prima,
            this.colfecha_vencimiento,
            this.colfechainicio,
            this.colfechafinal,
            this.colantiguedad,
            this.colBoleta,
            this.colnumero_transaccion,
            this.colf_factura,
            this.colOc,
            this.colpeso,
            this.colplaca});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 0;
            this.colfecha_ingreso.Width = 36;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 36;
            // 
            // colprovedor
            // 
            this.colprovedor.Caption = "Proveedor";
            this.colprovedor.FieldName = "provedor";
            this.colprovedor.Name = "colprovedor";
            this.colprovedor.Visible = true;
            this.colprovedor.VisibleIndex = 2;
            this.colprovedor.Width = 36;
            // 
            // colmateriaprima
            // 
            this.colmateriaprima.Caption = "Materia Prima";
            this.colmateriaprima.FieldName = "materiaprima";
            this.colmateriaprima.Name = "colmateriaprima";
            this.colmateriaprima.Visible = true;
            this.colmateriaprima.VisibleIndex = 3;
            this.colmateriaprima.Width = 36;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "# Sacos/TM";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 4;
            this.colcantidad.Width = 36;
            // 
            // colcategoria
            // 
            this.colcategoria.Caption = "Categoria MP";
            this.colcategoria.FieldName = "categoria";
            this.colcategoria.Name = "colcategoria";
            this.colcategoria.Visible = true;
            this.colcategoria.VisibleIndex = 5;
            this.colcategoria.Width = 36;
            // 
            // colcartilla
            // 
            this.colcartilla.Caption = "# Cartilla";
            this.colcartilla.FieldName = "cartilla";
            this.colcartilla.Name = "colcartilla";
            this.colcartilla.Visible = true;
            this.colcartilla.VisibleIndex = 6;
            this.colcartilla.Width = 36;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "# lote de La MP";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 7;
            this.collote_materia_prima.Width = 36;
            // 
            // colfecha_produccion_materia_prima
            // 
            this.colfecha_produccion_materia_prima.Caption = "F. Elab";
            this.colfecha_produccion_materia_prima.FieldName = "fecha_produccion_materia_prima";
            this.colfecha_produccion_materia_prima.Name = "colfecha_produccion_materia_prima";
            this.colfecha_produccion_materia_prima.Visible = true;
            this.colfecha_produccion_materia_prima.VisibleIndex = 8;
            this.colfecha_produccion_materia_prima.Width = 36;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "F. Venc";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 9;
            this.colfecha_vencimiento.Width = 36;
            // 
            // colfechainicio
            // 
            this.colfechainicio.Caption = "Fecha Inicio # Cartilla";
            this.colfechainicio.FieldName = "fechainicio";
            this.colfechainicio.Name = "colfechainicio";
            this.colfechainicio.Visible = true;
            this.colfechainicio.VisibleIndex = 10;
            this.colfechainicio.Width = 36;
            // 
            // colfechafinal
            // 
            this.colfechafinal.Caption = "Fecha Final # Cartilla";
            this.colfechafinal.FieldName = "fechafinal";
            this.colfechafinal.Name = "colfechafinal";
            this.colfechafinal.Visible = true;
            this.colfechafinal.VisibleIndex = 11;
            this.colfechafinal.Width = 34;
            // 
            // colantiguedad
            // 
            this.colantiguedad.Caption = "Antigüedad";
            this.colantiguedad.FieldName = "antiguedad";
            this.colantiguedad.Name = "colantiguedad";
            this.colantiguedad.OptionsColumn.AllowEdit = false;
            this.colantiguedad.Visible = true;
            this.colantiguedad.VisibleIndex = 12;
            this.colantiguedad.Width = 61;
            // 
            // colBoleta
            // 
            this.colBoleta.Caption = "# Boleta Bascula";
            this.colBoleta.FieldName = "Boleta";
            this.colBoleta.Name = "colBoleta";
            this.colBoleta.OptionsColumn.AllowEdit = false;
            this.colBoleta.Visible = true;
            this.colBoleta.VisibleIndex = 13;
            this.colBoleta.Width = 29;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "No.  Ingreso";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 14;
            this.colnumero_transaccion.Width = 29;
            // 
            // colf_factura
            // 
            this.colf_factura.Caption = "# De Factura";
            this.colf_factura.FieldName = "f_factura";
            this.colf_factura.Name = "colf_factura";
            this.colf_factura.OptionsColumn.AllowEdit = false;
            this.colf_factura.Visible = true;
            this.colf_factura.VisibleIndex = 15;
            this.colf_factura.Width = 44;
            // 
            // colOc
            // 
            this.colOc.Caption = "# Orden de Compra";
            this.colOc.FieldName = "Oc";
            this.colOc.Name = "colOc";
            this.colOc.OptionsColumn.AllowEdit = false;
            this.colOc.Visible = true;
            this.colOc.VisibleIndex = 16;
            this.colOc.Width = 29;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso Producto";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 17;
            this.colpeso.Width = 29;
            // 
            // colplaca
            // 
            this.colplaca.Caption = "Placa  Vehículo";
            this.colplaca.FieldName = "placa";
            this.colplaca.Name = "colplaca";
            this.colplaca.OptionsColumn.AllowEdit = false;
            this.colplaca.Visible = true;
            this.colplaca.VisibleIndex = 18;
            this.colplaca.Width = 46;
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(12, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(199, 71);
            this.btnExcel.TabIndex = 39;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frnReporteingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 522);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.grdYEAR);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frnReporteingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frnReporteingreso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdYEAR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.GridLookUpEdit grdYEAR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblyear;
        private System.Windows.Forms.BindingSource yearBindingSource;
        private dsReportes dsReportes;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colyear;
        private DevExpress.XtraGrid.Columns.GridColumn colyeardate;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colantiguedad;
        private DevExpress.XtraGrid.Columns.GridColumn colBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colf_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colOc;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colplaca;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colprovedor;
        private DevExpress.XtraGrid.Columns.GridColumn colmateriaprima;
        private DevExpress.XtraGrid.Columns.GridColumn colcategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colcartilla;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_produccion_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colfechainicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfechafinal;
    }
}