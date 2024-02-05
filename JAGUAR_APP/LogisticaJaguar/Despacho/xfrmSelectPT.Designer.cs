
namespace JAGUAR_APP.LogisticaJaguar.Despacho
{
    partial class xfrmSelectPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSelectPT));
            this.gcPT = new DevExpress.XtraGrid.GridControl();
            this.pTSeleccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDespacho = new JAGUAR_APP.LogisticaJaguar.Despacho.dsDespacho();
            this.gvPT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTSeleccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPT)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPT
            // 
            this.gcPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPT.DataSource = this.pTSeleccionBindingSource;
            this.gcPT.Location = new System.Drawing.Point(-1, 73);
            this.gcPT.MainView = this.gvPT;
            this.gcPT.Name = "gcPT";
            this.gcPT.Size = new System.Drawing.Size(956, 407);
            this.gcPT.TabIndex = 0;
            this.gcPT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPT});
            // 
            // pTSeleccionBindingSource
            // 
            this.pTSeleccionBindingSource.DataMember = "PT_Seleccion";
            this.pTSeleccionBindingSource.DataSource = this.dsDespacho;
            // 
            // dsDespacho
            // 
            this.dsDespacho.DataSetName = "dsDespacho";
            this.dsDespacho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvPT
            // 
            this.gvPT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gvPT.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPT.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gvPT.Appearance.Row.Options.UseFont = true;
            this.gvPT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt,
            this.colcode,
            this.colpt,
            this.collote,
            this.colid_presentacion,
            this.colpresentacion,
            this.colexistencia,
            this.colseleccion,
            this.gridColumn1});
            this.gvPT.GridControl = this.gcPT;
            this.gvPT.Name = "gvPT";
            this.gvPT.OptionsEditForm.PopupEditFormWidth = 686;
            this.gvPT.OptionsView.ShowAutoFilterRow = true;
            this.gvPT.OptionsView.ShowGroupPanel = false;
            this.gvPT.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPT_CellValueChanged);
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.ReadOnly = true;
            // 
            // colcode
            // 
            this.colcode.Caption = "Código";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.OptionsFilter.AllowFilter = false;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            this.colcode.Width = 133;
            // 
            // colpt
            // 
            this.colpt.Caption = "Producto";
            this.colpt.FieldName = "pt";
            this.colpt.Name = "colpt";
            this.colpt.OptionsColumn.ReadOnly = true;
            this.colpt.OptionsFilter.AllowFilter = false;
            this.colpt.Visible = true;
            this.colpt.VisibleIndex = 1;
            this.colpt.Width = 133;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.ReadOnly = true;
            this.collote.OptionsFilter.AllowFilter = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 2;
            this.collote.Width = 133;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.OptionsColumn.ReadOnly = true;
            // 
            // colpresentacion
            // 
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.ReadOnly = true;
            this.colpresentacion.OptionsFilter.AllowFilter = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 3;
            this.colpresentacion.Width = 299;
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia";
            this.colexistencia.DisplayFormat.FormatString = "{0:N2}";
            this.colexistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.ReadOnly = true;
            this.colexistencia.OptionsFilter.AllowFilter = false;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 4;
            this.colexistencia.Width = 74;
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Selección";
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 6;
            this.colseleccion.Width = 69;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.Caption = "Cant. Despachar";
            this.gridColumn1.DisplayFormat.FormatString = "{0:N2}";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "cant_despachar";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 90;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSeleccionar.Appearance.Options.UseFont = true;
            this.btnSeleccionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSeleccionar.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.marca_de_verificacion;
            this.btnSeleccionar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSeleccionar.Location = new System.Drawing.Point(658, 10);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(134, 44);
            this.btnSeleccionar.TabIndex = 51;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(812, 10);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(134, 44);
            this.btnAtras.TabIndex = 53;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 19);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "Seleccionar Lotes de PT";
            // 
            // xfrmSelectPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 478);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.gcPT);
            this.Name = "xfrmSelectPT";
            this.Text = "Seleccionar Producto Terminado";
            ((System.ComponentModel.ISupportInitialize)(this.gcPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTSeleccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPT;
        private dsDespacho dsDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colpt;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource pTSeleccionBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}