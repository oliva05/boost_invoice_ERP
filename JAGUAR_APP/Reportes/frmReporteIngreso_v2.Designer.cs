
namespace JAGUAR_APP.Reportes
{
    partial class frmReporteIngreso_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteIngreso_v2));
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.lblyear = new DevExpress.XtraEditors.LabelControl();
            this.grdYEAR = new DevExpress.XtraEditors.GridLookUpEdit();
            this.yearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes = new JAGUAR_APP.Reportes.dsReportes();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyeardate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colN_Ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfurgon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_Vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_consumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_final_consumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colantiguedad = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnclose.Location = new System.Drawing.Point(1198, 59);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(131, 44);
            this.btnclose.TabIndex = 36;
            this.btnclose.Text = "Home";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(12, 59);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(132, 44);
            this.btnExcel.TabIndex = 40;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblyear
            // 
            this.lblyear.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Appearance.Options.UseFont = true;
            this.lblyear.Location = new System.Drawing.Point(166, 77);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(38, 21);
            this.lblyear.TabIndex = 42;
            this.lblyear.Text = "Año: ";
            // 
            // grdYEAR
            // 
            this.grdYEAR.Location = new System.Drawing.Point(210, 73);
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
            this.grdYEAR.TabIndex = 41;
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
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "rpt_ingreso";
            this.grd_data.DataSource = this.dsReportes;
            this.grd_data.Location = new System.Drawing.Point(0, 117);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(1379, 404);
            this.grd_data.TabIndex = 43;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colN_Ingreso,
            this.colCodigoP,
            this.colProveedor,
            this.colF_registro,
            this.colcodigo_produccion,
            this.colf_produccion,
            this.colBoleta,
            this.colplaca,
            this.colfurgon,
            this.colFactura,
            this.colPeso,
            this.colUnidades,
            this.colExistencia,
            this.collote,
            this.colid_mp,
            this.colMP,
            this.colCodigo,
            this.colF_Vencimiento,
            this.colf_consumo,
            this.colf_final_consumo,
            this.colantiguedad});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colN_Ingreso
            // 
            this.colN_Ingreso.Caption = "N Ingreso";
            this.colN_Ingreso.FieldName = "N_Ingreso";
            this.colN_Ingreso.Name = "colN_Ingreso";
            this.colN_Ingreso.OptionsColumn.AllowEdit = false;
            this.colN_Ingreso.Visible = true;
            this.colN_Ingreso.VisibleIndex = 0;
            // 
            // colCodigoP
            // 
            this.colCodigoP.Caption = "Codigo P.";
            this.colCodigoP.FieldName = "CodigoP";
            this.colCodigoP.Name = "colCodigoP";
            this.colCodigoP.OptionsColumn.AllowEdit = false;
            this.colCodigoP.Visible = true;
            this.colCodigoP.VisibleIndex = 1;
            // 
            // colProveedor
            // 
            this.colProveedor.Caption = "Proveedor";
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.AllowEdit = false;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 2;
            // 
            // colF_registro
            // 
            this.colF_registro.Caption = "F. Ingreso";
            this.colF_registro.FieldName = "F_registro";
            this.colF_registro.Name = "colF_registro";
            this.colF_registro.OptionsColumn.AllowEdit = false;
            this.colF_registro.Visible = true;
            this.colF_registro.VisibleIndex = 3;
            // 
            // colcodigo_produccion
            // 
            this.colcodigo_produccion.Caption = "C. produccion";
            this.colcodigo_produccion.FieldName = "codigo_produccion";
            this.colcodigo_produccion.Name = "colcodigo_produccion";
            this.colcodigo_produccion.OptionsColumn.AllowEdit = false;
            this.colcodigo_produccion.Visible = true;
            this.colcodigo_produccion.VisibleIndex = 4;
            // 
            // colf_produccion
            // 
            this.colf_produccion.Caption = "F produccion";
            this.colf_produccion.FieldName = "f_produccion";
            this.colf_produccion.Name = "colf_produccion";
            this.colf_produccion.OptionsColumn.AllowEdit = false;
            this.colf_produccion.Visible = true;
            this.colf_produccion.VisibleIndex = 5;
            // 
            // colBoleta
            // 
            this.colBoleta.Caption = "Boleta";
            this.colBoleta.FieldName = "Boleta";
            this.colBoleta.Name = "colBoleta";
            this.colBoleta.OptionsColumn.AllowEdit = false;
            this.colBoleta.Visible = true;
            this.colBoleta.VisibleIndex = 6;
            // 
            // colplaca
            // 
            this.colplaca.Caption = "Placa";
            this.colplaca.FieldName = "placa";
            this.colplaca.Name = "colplaca";
            this.colplaca.OptionsColumn.AllowEdit = false;
            this.colplaca.Visible = true;
            this.colplaca.VisibleIndex = 7;
            // 
            // colfurgon
            // 
            this.colfurgon.Caption = "Furgon";
            this.colfurgon.FieldName = "furgon";
            this.colfurgon.Name = "colfurgon";
            this.colfurgon.OptionsColumn.AllowEdit = false;
            this.colfurgon.Visible = true;
            this.colfurgon.VisibleIndex = 8;
            // 
            // colFactura
            // 
            this.colFactura.Caption = "Factura";
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            this.colFactura.OptionsColumn.AllowEdit = false;
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 9;
            // 
            // colPeso
            // 
            this.colPeso.Caption = "Peso Kg.";
            this.colPeso.FieldName = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.OptionsColumn.AllowEdit = false;
            this.colPeso.Visible = true;
            this.colPeso.VisibleIndex = 10;
            // 
            // colUnidades
            // 
            this.colUnidades.Caption = "Unidades";
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.OptionsColumn.AllowEdit = false;
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 11;
            // 
            // colExistencia
            // 
            this.colExistencia.Caption = "Existencia Ud.";
            this.colExistencia.FieldName = "Existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.OptionsColumn.AllowEdit = false;
            this.colExistencia.Visible = true;
            this.colExistencia.VisibleIndex = 12;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 13;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.OptionsColumn.AllowEdit = false;
            // 
            // colMP
            // 
            this.colMP.Caption = "Material";
            this.colMP.FieldName = "MP";
            this.colMP.Name = "colMP";
            this.colMP.OptionsColumn.AllowEdit = false;
            this.colMP.Visible = true;
            this.colMP.VisibleIndex = 14;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "C. Material";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 15;
            // 
            // colF_Vencimiento
            // 
            this.colF_Vencimiento.Caption = "F. Vencimiento";
            this.colF_Vencimiento.FieldName = "F_Vencimiento";
            this.colF_Vencimiento.Name = "colF_Vencimiento";
            this.colF_Vencimiento.OptionsColumn.AllowEdit = false;
            this.colF_Vencimiento.Visible = true;
            this.colF_Vencimiento.VisibleIndex = 16;
            // 
            // colf_consumo
            // 
            this.colf_consumo.Caption = "Inicio Consumo";
            this.colf_consumo.FieldName = "f_consumo";
            this.colf_consumo.Name = "colf_consumo";
            this.colf_consumo.OptionsColumn.AllowEdit = false;
            this.colf_consumo.Visible = true;
            this.colf_consumo.VisibleIndex = 18;
            // 
            // colf_final_consumo
            // 
            this.colf_final_consumo.Caption = "Final Consumo";
            this.colf_final_consumo.FieldName = "f_final_consumo";
            this.colf_final_consumo.Name = "colf_final_consumo";
            this.colf_final_consumo.OptionsColumn.AllowEdit = false;
            this.colf_final_consumo.Visible = true;
            this.colf_final_consumo.VisibleIndex = 19;
            // 
            // colantiguedad
            // 
            this.colantiguedad.Caption = "Antiguedad";
            this.colantiguedad.FieldName = "antiguedad";
            this.colantiguedad.Name = "colantiguedad";
            this.colantiguedad.OptionsColumn.AllowEdit = false;
            this.colantiguedad.Visible = true;
            this.colantiguedad.VisibleIndex = 17;
            // 
            // frmReporteIngreso_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 522);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.grdYEAR);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteIngreso_v2";
            this.Text = "frmReporteIngreso_v2";
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
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.LabelControl lblyear;
        private DevExpress.XtraEditors.GridLookUpEdit grdYEAR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colyear;
        private DevExpress.XtraGrid.Columns.GridColumn colyeardate;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private System.Windows.Forms.BindingSource yearBindingSource;
        private dsReportes dsReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colN_Ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoP;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colF_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colplaca;
        private DevExpress.XtraGrid.Columns.GridColumn colfurgon;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colMP;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colF_Vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colantiguedad;
        private DevExpress.XtraGrid.Columns.GridColumn colf_consumo;
        private DevExpress.XtraGrid.Columns.GridColumn colf_final_consumo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn colf_produccion;
    }
}