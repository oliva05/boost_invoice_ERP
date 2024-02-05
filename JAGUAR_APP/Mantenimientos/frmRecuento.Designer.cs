namespace JAGUAR_APP.Mantenimientos
{
    partial class frmRecuento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuento));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grd_recuento = new DevExpress.XtraGrid.GridControl();
            this.dsMantenimiento = new JAGUAR_APP.Mantenimientos.dsMantenimiento();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCantt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesotm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUdTarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDescargar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_recuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(551, 13);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(265, 87);
            this.simpleButton2.TabIndex = 35;
            this.simpleButton2.Text = "Home";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(173, 33);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(496, 48);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Recuento de inventario";
            // 
            // grd_recuento
            // 
            this.grd_recuento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_recuento.DataMember = "Ajuste";
            this.grd_recuento.DataSource = this.dsMantenimiento;
            this.grd_recuento.Location = new System.Drawing.Point(1, 176);
            this.grd_recuento.MainView = this.gridView1;
            this.grd_recuento.Name = "grd_recuento";
            this.grd_recuento.Size = new System.Drawing.Size(828, 466);
            this.grd_recuento.TabIndex = 37;
            this.grd_recuento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMantenimiento
            // 
            this.dsMantenimiento.DataSetName = "dsMantenimiento";
            this.dsMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCantt,
            this.colpesotm,
            this.colUdTarima,
            this.colingreso,
            this.colidmp,
            this.colUnidades,
            this.colMp,
            this.colid_presentacion});
            this.gridView1.GridControl = this.grd_recuento;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCantt
            // 
            this.colCantt.Caption = "Cantidad Tarimas";
            this.colCantt.FieldName = "Cantt";
            this.colCantt.MinWidth = 25;
            this.colCantt.Name = "colCantt";
            this.colCantt.Visible = true;
            this.colCantt.VisibleIndex = 0;
            this.colCantt.Width = 94;
            // 
            // colpesotm
            // 
            this.colpesotm.Caption = "Peso por Tarima";
            this.colpesotm.FieldName = "pesotm";
            this.colpesotm.MinWidth = 25;
            this.colpesotm.Name = "colpesotm";
            this.colpesotm.Visible = true;
            this.colpesotm.VisibleIndex = 1;
            this.colpesotm.Width = 94;
            // 
            // colUdTarima
            // 
            this.colUdTarima.Caption = "Unidades Por tarima";
            this.colUdTarima.FieldName = "UdTarima";
            this.colUdTarima.MinWidth = 25;
            this.colUdTarima.Name = "colUdTarima";
            this.colUdTarima.Visible = true;
            this.colUdTarima.VisibleIndex = 2;
            this.colUdTarima.Width = 94;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "N Ingreso";
            this.colingreso.FieldName = "ingreso";
            this.colingreso.MinWidth = 25;
            this.colingreso.Name = "colingreso";
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 3;
            this.colingreso.Width = 94;
            // 
            // colidmp
            // 
            this.colidmp.Caption = "ID Mp";
            this.colidmp.FieldName = "idmp";
            this.colidmp.MinWidth = 25;
            this.colidmp.Name = "colidmp";
            this.colidmp.Visible = true;
            this.colidmp.VisibleIndex = 4;
            this.colidmp.Width = 94;
            // 
            // colUnidades
            // 
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.MinWidth = 25;
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.Width = 94;
            // 
            // colMp
            // 
            this.colMp.Caption = "Materia Prima";
            this.colMp.FieldName = "Mp";
            this.colMp.MinWidth = 25;
            this.colMp.Name = "colMp";
            this.colMp.Visible = true;
            this.colMp.VisibleIndex = 5;
            this.colMp.Width = 94;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.Caption = "Presentacion";
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.MinWidth = 25;
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.Visible = true;
            this.colid_presentacion.VisibleIndex = 6;
            this.colid_presentacion.Width = 94;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(11, 11);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(265, 87);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Agregar";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.Appearance.Options.UseFont = true;
            this.btnDescargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDescargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.ImageOptions.Image")));
            this.btnDescargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDescargar.Location = new System.Drawing.Point(13, 106);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(384, 63);
            this.btnDescargar.TabIndex = 39;
            this.btnDescargar.Text = "Descargar Inventario";
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Appearance.Options.UseFont = true;
            this.btnCargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.Image")));
            this.btnCargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCargar.Location = new System.Drawing.Point(417, 106);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(399, 63);
            this.btnCargar.TabIndex = 40;
            this.btnCargar.Text = "Cargar Inventario";
            // 
            // frmRecuento
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 641);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.grd_recuento);
            this.Controls.Add(this.labelControl3);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruento de inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_recuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grd_recuento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnDescargar;
        private DevExpress.XtraEditors.SimpleButton btnCargar;
        private dsMantenimiento dsMantenimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colCantt;
        private DevExpress.XtraGrid.Columns.GridColumn colpesotm;
        private DevExpress.XtraGrid.Columns.GridColumn colUdTarima;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colidmp;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colMp;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
    }
}