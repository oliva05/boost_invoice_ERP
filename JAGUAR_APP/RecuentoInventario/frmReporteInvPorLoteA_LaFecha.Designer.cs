
namespace JAGUAR_APP.RecuentoInventario
{
    partial class frmReporteInvPorLoteA_LaFecha
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesRecuentosINV1 = new JAGUAR_APP.RecuentoInventario.dsReportesRecuentosINV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentradas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtFechaHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGenerarReporte = new System.Windows.Forms.Button();
            this.cmdExcel = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesRecuentosINV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "InventarioA_LaFecha";
            this.gridControl1.DataSource = this.dsReportesRecuentosINV1;
            this.gridControl1.Location = new System.Drawing.Point(1, 92);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(928, 451);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesRecuentosINV1
            // 
            this.dsReportesRecuentosINV1.DataSetName = "dsReportesRecuentosINV";
            this.dsReportesRecuentosINV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colexistencia,
            this.colnombre_comercial,
            this.colid_mp,
            this.collote,
            this.colcode_sap,
            this.colentradas,
            this.colsalidas,
            this.colrow,
            this.colbodega});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colexistencia
            // 
            this.colexistencia.DisplayFormat.FormatString = "n2";
            this.colexistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 7;
            this.colexistencia.Width = 92;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 2;
            this.colnombre_comercial.Width = 92;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.OptionsColumn.AllowEdit = false;
            this.colid_mp.Width = 92;
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 3;
            this.collote.Width = 92;
            // 
            // colcode_sap
            // 
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 1;
            this.colcode_sap.Width = 92;
            // 
            // colentradas
            // 
            this.colentradas.DisplayFormat.FormatString = "n2";
            this.colentradas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colentradas.FieldName = "entradas";
            this.colentradas.Name = "colentradas";
            this.colentradas.OptionsColumn.AllowEdit = false;
            this.colentradas.Visible = true;
            this.colentradas.VisibleIndex = 5;
            this.colentradas.Width = 92;
            // 
            // colsalidas
            // 
            this.colsalidas.DisplayFormat.FormatString = "n2";
            this.colsalidas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsalidas.FieldName = "salidas";
            this.colsalidas.Name = "colsalidas";
            this.colsalidas.OptionsColumn.AllowEdit = false;
            this.colsalidas.Visible = true;
            this.colsalidas.VisibleIndex = 6;
            this.colsalidas.Width = 99;
            // 
            // colrow
            // 
            this.colrow.FieldName = "row";
            this.colrow.Name = "colrow";
            this.colrow.OptionsColumn.AllowEdit = false;
            this.colrow.Visible = true;
            this.colrow.VisibleIndex = 0;
            this.colrow.Width = 45;
            // 
            // colbodega
            // 
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.OptionsColumn.AllowEdit = false;
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 4;
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.EditValue = null;
            this.dtFechaHasta.Location = new System.Drawing.Point(183, 59);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtFechaHasta.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Properties.DisplayFormat.FormatString = "g";
            this.dtFechaHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaHasta.Properties.EditFormat.FormatString = "g";
            this.dtFechaHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaHasta.Size = new System.Drawing.Size(218, 24);
            this.dtFechaHasta.TabIndex = 1;
            this.dtFechaHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCerrar_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Generar Inventario a la Fecha____";
            // 
            // cmdGenerarReporte
            // 
            this.cmdGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdGenerarReporte.Image = global::JAGUAR_APP.Properties.Resources.refresh_button32px;
            this.cmdGenerarReporte.Location = new System.Drawing.Point(407, 46);
            this.cmdGenerarReporte.Name = "cmdGenerarReporte";
            this.cmdGenerarReporte.Size = new System.Drawing.Size(169, 44);
            this.cmdGenerarReporte.TabIndex = 3;
            this.cmdGenerarReporte.Text = "Generar Reporte";
            this.cmdGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGenerarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdGenerarReporte.UseVisualStyleBackColor = true;
            this.cmdGenerarReporte.Click += new System.EventHandler(this.cmdGenerarReporte_Click);
            this.cmdGenerarReporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCerrar_KeyDown);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdExcel.Image = global::JAGUAR_APP.Properties.Resources.excel32px;
            this.cmdExcel.Location = new System.Drawing.Point(582, 46);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(169, 44);
            this.cmdExcel.TabIndex = 4;
            this.cmdExcel.Text = "Exportar a Excel";
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdExcel.UseVisualStyleBackColor = true;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            this.cmdExcel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCerrar_KeyDown);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdCerrar.Image = global::JAGUAR_APP.Properties.Resources.close32px;
            this.cmdCerrar.Location = new System.Drawing.Point(757, 46);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(169, 44);
            this.cmdCerrar.TabIndex = 5;
            this.cmdCerrar.Text = "Cerrar [ESC]";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            this.cmdCerrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCerrar_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(336, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(240, 21);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Resumen de Inventario a la fecha";
            // 
            // frmReporteInvPorLoteA_LaFecha
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 544);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.cmdGenerarReporte);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmReporteInvPorLoteA_LaFecha";
            this.Text = "Reporte de Inventario por Lote a la fecha";
            this.Activated += new System.EventHandler(this.frmReporteInvPorLoteA_LaFecha_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdCerrar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesRecuentosINV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsReportesRecuentosINV dsReportesRecuentosINV1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colentradas;
        private DevExpress.XtraGrid.Columns.GridColumn colsalidas;
        private DevExpress.XtraGrid.Columns.GridColumn colrow;
        private DevExpress.XtraEditors.DateEdit dtFechaHasta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button cmdGenerarReporte;
        private System.Windows.Forms.Button cmdExcel;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
    }
}