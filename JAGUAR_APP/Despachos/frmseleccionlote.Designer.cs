namespace JAGUAR_APP.Despachos
{
    partial class frmseleccionlote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmseleccionlote));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_lote = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new JAGUAR_APP.Despachos.ds_despachos();
            this.grdv_lote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcants = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtitem = new DevExpress.XtraEditors.TextEdit();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnatras = new DevExpress.XtraEditors.SimpleButton();
            this.btnguardado = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblUnidad = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSolicitada = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAsignada = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadPendiente = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtitem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsignada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadPendiente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(179, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(464, 49);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Planificacion de Despacho";
            // 
            // grd_lote
            // 
            this.grd_lote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_lote.DataMember = "detalle_lote_pt";
            this.grd_lote.DataSource = this.ds_despachos;
            this.grd_lote.Location = new System.Drawing.Point(0, 266);
            this.grd_lote.MainView = this.grdv_lote;
            this.grd_lote.Name = "grd_lote";
            this.grd_lote.Size = new System.Drawing.Size(851, 423);
            this.grd_lote.TabIndex = 38;
            this.grd_lote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_lote});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_lote
            // 
            this.grdv_lote.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lote.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdv_lote.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lote.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.grdv_lote.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lote.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdv_lote.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_lote.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_lote.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_lote.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lote.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdv_lote.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lote.Appearance.Row.Options.UseFont = true;
            this.grdv_lote.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lote.Appearance.SelectedRow.Options.UseFont = true;
            this.grdv_lote.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grdv_lote.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grdv_lote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_proveedor,
            this.colNombre,
            this.colingreso,
            this.colvence,
            this.collote_mp,
            this.colpresentacion,
            this.colcantidad,
            this.colunidad,
            this.colpeso_total,
            this.colseleccionado,
            this.colcants});
            this.grdv_lote.GridControl = this.grd_lote;
            this.grdv_lote.Name = "grdv_lote";
            this.grdv_lote.OptionsCustomization.AllowFilter = false;
            this.grdv_lote.OptionsView.ShowAutoFilterRow = true;
            this.grdv_lote.OptionsView.ShowFooter = true;
            this.grdv_lote.OptionsView.ShowGroupPanel = false;
            this.grdv_lote.RowHeight = 20;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Proveedor";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "Fecha In.";
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.OptionsColumn.AllowEdit = false;
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 0;
            // 
            // colvence
            // 
            this.colvence.Caption = "Fecha Vence";
            this.colvence.FieldName = "vence";
            this.colvence.Name = "colvence";
            this.colvence.OptionsColumn.AllowEdit = false;
            this.colvence.Visible = true;
            this.colvence.VisibleIndex = 1;
            // 
            // collote_mp
            // 
            this.collote_mp.Caption = "Lote PT";
            this.collote_mp.FieldName = "lote_pt";
            this.collote_mp.Name = "collote_mp";
            this.collote_mp.OptionsColumn.AllowEdit = false;
            this.collote_mp.Visible = true;
            this.collote_mp.VisibleIndex = 2;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentación";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 3;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Unidades";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 4;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad Medida";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.OptionsColumn.AllowEdit = false;
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 5;
            // 
            // colpeso_total
            // 
            this.colpeso_total.Caption = "Peso tarima";
            this.colpeso_total.FieldName = "peso_total";
            this.colpeso_total.Name = "colpeso_total";
            this.colpeso_total.OptionsColumn.AllowEdit = false;
            this.colpeso_total.Visible = true;
            this.colpeso_total.VisibleIndex = 6;
            // 
            // colseleccionado
            // 
            this.colseleccionado.Caption = "Seleccionar";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 7;
            // 
            // colcants
            // 
            this.colcants.Caption = "Cant. a Enviar";
            this.colcants.FieldName = "cants";
            this.colcants.Name = "colcants";
            this.colcants.Visible = true;
            this.colcants.VisibleIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(246, 29);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Producto Terminado:";
            // 
            // txtitem
            // 
            this.txtitem.Enabled = false;
            this.txtitem.Location = new System.Drawing.Point(285, 73);
            this.txtitem.Name = "txtitem";
            this.txtitem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.Properties.Appearance.Options.UseFont = true;
            this.txtitem.Size = new System.Drawing.Size(443, 34);
            this.txtitem.TabIndex = 41;
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTodos.AutoSize = true;
            this.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(618, 157);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(222, 33);
            this.chkTodos.TabIndex = 46;
            this.chkTodos.Text = "Autoseleccionar";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // btnatras
            // 
            this.btnatras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnatras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnatras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Appearance.Options.UseBackColor = true;
            this.btnatras.Appearance.Options.UseFont = true;
            this.btnatras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnatras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.ImageOptions.Image")));
            this.btnatras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnatras.Location = new System.Drawing.Point(720, 8);
            this.btnatras.Margin = new System.Windows.Forms.Padding(4);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(118, 54);
            this.btnatras.TabIndex = 47;
            this.btnatras.Text = "Atras";
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnguardado
            // 
            this.btnguardado.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnguardado.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardado.Appearance.Options.UseBackColor = true;
            this.btnguardado.Appearance.Options.UseFont = true;
            this.btnguardado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnguardado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguardado.ImageOptions.Image")));
            this.btnguardado.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnguardado.Location = new System.Drawing.Point(13, 11);
            this.btnguardado.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardado.Name = "btnguardado";
            this.btnguardado.Size = new System.Drawing.Size(143, 55);
            this.btnguardado.TabIndex = 48;
            this.btnguardado.Text = "Guardar";
            this.btnguardado.Click += new System.EventHandler(this.btnguardado_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(598, 119);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(187, 30);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "Unidad Medida:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnidad.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Appearance.Options.UseFont = true;
            this.lblUnidad.Appearance.Options.UseTextOptions = true;
            this.lblUnidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblUnidad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUnidad.Location = new System.Drawing.Point(794, 119);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(46, 30);
            this.lblUnidad.TabIndex = 52;
            this.lblUnidad.Text = "Ud.";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 122);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(183, 29);
            this.labelControl5.TabIndex = 59;
            this.labelControl5.Text = "Cant. Solicitada";
            // 
            // txtSolicitada
            // 
            this.txtSolicitada.EditValue = "0.00";
            this.txtSolicitada.Enabled = false;
            this.txtSolicitada.Location = new System.Drawing.Point(285, 116);
            this.txtSolicitada.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolicitada.Name = "txtSolicitada";
            this.txtSolicitada.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitada.Properties.Appearance.Options.UseFont = true;
            this.txtSolicitada.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolicitada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSolicitada.Size = new System.Drawing.Size(189, 38);
            this.txtSolicitada.TabIndex = 58;
            this.txtSolicitada.EditValueChanged += new System.EventHandler(this.txtSolicitada_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 170);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(175, 29);
            this.labelControl4.TabIndex = 57;
            this.labelControl4.Text = "Cant. Asignada";
            // 
            // txtAsignada
            // 
            this.txtAsignada.EditValue = "0.00";
            this.txtAsignada.Enabled = false;
            this.txtAsignada.Location = new System.Drawing.Point(285, 165);
            this.txtAsignada.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsignada.Name = "txtAsignada";
            this.txtAsignada.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsignada.Properties.Appearance.Options.UseFont = true;
            this.txtAsignada.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsignada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAsignada.Size = new System.Drawing.Size(189, 38);
            this.txtAsignada.TabIndex = 56;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 217);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(186, 29);
            this.labelControl3.TabIndex = 55;
            this.labelControl3.Text = "Cant. Pendiente";
            // 
            // txtCantidadPendiente
            // 
            this.txtCantidadPendiente.EditValue = "0.00";
            this.txtCantidadPendiente.Enabled = false;
            this.txtCantidadPendiente.Location = new System.Drawing.Point(285, 211);
            this.txtCantidadPendiente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadPendiente.Name = "txtCantidadPendiente";
            this.txtCantidadPendiente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPendiente.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadPendiente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadPendiente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadPendiente.Size = new System.Drawing.Size(189, 38);
            this.txtCantidadPendiente.TabIndex = 54;
            // 
            // frmseleccionlote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSolicitada);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtAsignada);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCantidadPendiente);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.btnguardado);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grd_lote);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmseleccionlote";
            this.Text = "frmseleccionlote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtitem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsignada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadPendiente.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grd_lote;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_lote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtitem;
        private System.Windows.Forms.CheckBox chkTodos;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colvence;
        private DevExpress.XtraGrid.Columns.GridColumn collote_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_total;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colcants;
        private DevExpress.XtraEditors.SimpleButton btnatras;
        private DevExpress.XtraEditors.SimpleButton btnguardado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblUnidad;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSolicitada;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAsignada;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCantidadPendiente;
    }
}