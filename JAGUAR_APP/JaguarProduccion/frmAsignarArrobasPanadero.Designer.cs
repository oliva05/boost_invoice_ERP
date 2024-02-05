
namespace JAGUAR_APP.JaguarProduccion
{
    partial class frmAsignarArrobasPanadero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarArrobasPanadero));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductoTerminado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPresentacionNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadInicial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsProduccion1 = new JAGUAR_APP.JaguarProduccion.dsProduccion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductoTerminado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacionNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(24, 5);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(495, 66);
            this.labelControl6.TabIndex = 68;
            this.labelControl6.Text = "Distribución de Arrobas";
            // 
            // txtProductoTerminado
            // 
            this.txtProductoTerminado.Location = new System.Drawing.Point(321, 74);
            this.txtProductoTerminado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProductoTerminado.Name = "txtProductoTerminado";
            this.txtProductoTerminado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtProductoTerminado.Properties.Appearance.Options.UseFont = true;
            this.txtProductoTerminado.Properties.ReadOnly = true;
            this.txtProductoTerminado.Size = new System.Drawing.Size(653, 54);
            this.txtProductoTerminado.TabIndex = 70;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 80);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(261, 40);
            this.labelControl2.TabIndex = 69;
            this.labelControl2.Text = "Producto Terminado";
            // 
            // txtPresentacionNombre
            // 
            this.txtPresentacionNombre.Location = new System.Drawing.Point(321, 137);
            this.txtPresentacionNombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPresentacionNombre.Name = "txtPresentacionNombre";
            this.txtPresentacionNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPresentacionNombre.Properties.Appearance.Options.UseFont = true;
            this.txtPresentacionNombre.Properties.ReadOnly = true;
            this.txtPresentacionNombre.Size = new System.Drawing.Size(653, 54);
            this.txtPresentacionNombre.TabIndex = 72;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 141);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(162, 40);
            this.labelControl1.TabIndex = 71;
            this.labelControl1.Text = "Presentación";
            // 
            // txtCantidadInicial
            // 
            this.txtCantidadInicial.Location = new System.Drawing.Point(321, 198);
            this.txtCantidadInicial.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCantidadInicial.Name = "txtCantidadInicial";
            this.txtCantidadInicial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCantidadInicial.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadInicial.Properties.ReadOnly = true;
            this.txtCantidadInicial.Size = new System.Drawing.Size(653, 54);
            this.txtCantidadInicial.TabIndex = 74;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 202);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(271, 40);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "Pendiente de Asignar";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "panaderos_list";
            this.gridControl1.DataSource = this.dsProduccion1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gridControl1.Location = new System.Drawing.Point(14, 314);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(960, 556);
            this.gridControl1.TabIndex = 75;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnombre,
            this.colcantidad,
            this.colseleccionado});
            this.gridView1.DetailHeight = 673;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 39;
            this.colid.Name = "colid";
            this.colid.Width = 149;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 39;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 641;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 39;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUMA={0:#.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 1;
            this.colcantidad.Width = 269;
            // 
            // colseleccionado
            // 
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.MinWidth = 39;
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Width = 149;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 262);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(276, 40);
            this.labelControl4.TabIndex = 76;
            this.labelControl4.Text = "Detalle la distribución";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAplicar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Appearance.Options.UseFont = true;
            this.btnAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAplicar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicar.ImageOptions.Image")));
            this.btnAplicar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAplicar.Location = new System.Drawing.Point(21, 887);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(288, 84);
            this.btnAplicar.TabIndex = 77;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdCancelar.Location = new System.Drawing.Point(321, 887);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(288, 84);
            this.cmdCancelar.TabIndex = 78;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmAsignarArrobasPanadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 997);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtCantidadInicial);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPresentacionNombre);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtProductoTerminado);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl6);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAsignarArrobasPanadero";
            ((System.ComponentModel.ISupportInitialize)(this.txtProductoTerminado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacionNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtProductoTerminado;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPresentacionNombre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCantidadInicial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private dsProduccion dsProduccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
    }
}