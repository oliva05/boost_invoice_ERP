
namespace JAGUAR_APP.Calidad.LoteConfConsumo
{
    partial class frmSearchMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchMP));
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDetalleMP = new DevExpress.XtraGrid.GridControl();
            this.dsReportesInventario = new JAGUAR_APP.Reportes.dsReportesInventario();
            this.gvMP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMP)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAplicar.ImageOptions.SvgImage")));
            this.cmdAplicar.Location = new System.Drawing.Point(457, 2);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(104, 47);
            this.cmdAplicar.TabIndex = 9;
            this.cmdAplicar.Text = "Aplicar";
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(567, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 47);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridControlDetalleMP
            // 
            this.gridControlDetalleMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDetalleMP.DataMember = "Kardex_BusquedaMP";
            this.gridControlDetalleMP.DataSource = this.dsReportesInventario;
            this.gridControlDetalleMP.Location = new System.Drawing.Point(2, 76);
            this.gridControlDetalleMP.MainView = this.gvMP;
            this.gridControlDetalleMP.Name = "gridControlDetalleMP";
            this.gridControlDetalleMP.Size = new System.Drawing.Size(664, 334);
            this.gridControlDetalleMP.TabIndex = 10;
            this.gridControlDetalleMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMP});
            // 
            // dsReportesInventario
            // 
            this.dsReportesInventario.DataSetName = "dsReportesInventario";
            this.dsReportesInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMP
            // 
            this.gvMP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMP.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMP.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMP.Appearance.Row.Options.UseFont = true;
            this.gvMP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colName,
            this.colSeleccionado,
            this.colconcat_});
            this.gvMP.GridControl = this.gridControlDetalleMP;
            this.gvMP.Name = "gvMP";
            this.gvMP.OptionsView.ShowAutoFilterRow = true;
            this.gvMP.OptionsView.ShowGroupPanel = false;
            this.gvMP.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gvMP.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Codigo";
            this.colItemCode.FieldName = "code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 78;
            // 
            // colName
            // 
            this.colName.Caption = "Meteria Prima";
            this.colName.FieldName = "nombre_comercial";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 441;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.FieldName = "seleccionar";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 2;
            this.colSeleccionado.Width = 105;
            // 
            // colconcat_
            // 
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(221, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(227, 21);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Seleccione una Materia Prima";
            // 
            // frmSearchMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 412);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlDetalleMP);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.btnClose);
            this.Name = "frmSearchMP";
            this.ShowIcon = false;
 
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl gridControlDetalleMP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
        private Reportes.dsReportesInventario dsReportesInventario;
    }
}