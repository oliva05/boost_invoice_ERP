
namespace JAGUAR_APP.AlmacenesExterno
{
    partial class xfrmMovimientoStockMain
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmMovimientoStockMain));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcTransferencia = new DevExpress.XtraGrid.GridControl();
            this.dsSalidasAlmacenesExternos1 = new JAGUAR_APP.AlmacenesExterno.dsSalidasAlmacenesExternos();
            this.gvTransferencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryVerDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrintIngresoPlanta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPrintIngresado = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.btnTransferencia = new DevExpress.XtraEditors.SimpleButton();
            this.colfactura = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVerDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintIngresado)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTransferencia
            // 
            this.gcTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransferencia.DataMember = "Salida_Almacen_Header";
            this.gcTransferencia.DataSource = this.dsSalidasAlmacenesExternos1;
            this.gcTransferencia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTransferencia.Location = new System.Drawing.Point(2, 77);
            this.gcTransferencia.MainView = this.gvTransferencia;
            this.gcTransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTransferencia.Name = "gcTransferencia";
            this.gcTransferencia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryVerDetalle,
            this.repositoryPrint,
            this.cmdPrintIngresado});
            this.gcTransferencia.Size = new System.Drawing.Size(1299, 448);
            this.gcTransferencia.TabIndex = 36;
            this.gcTransferencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransferencia});
            // 
            // dsSalidasAlmacenesExternos1
            // 
            this.dsSalidasAlmacenesExternos1.DataSetName = "dsSalidasAlmacenesExternos";
            this.dsSalidasAlmacenesExternos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTransferencia
            // 
            this.gvTransferencia.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTransferencia.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTransferencia.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTransferencia.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTransferencia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTransferencia.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTransferencia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTransferencia.Appearance.Row.Options.UseFont = true;
            this.gvTransferencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colbodega_in,
            this.colbodega_out,
            this.colfecha,
            this.colenable,
            this.colDocEntry,
            this.coluser_creador,
            this.colnumero_transaccion,
            this.colitemcode,
            this.colmp,
            this.colid_ingreso,
            this.gridColumn1,
            this.gridColumn2,
            this.colusuario,
            this.colDocNum,
            this.colPrintIngresoPlanta,
            this.colfactura});
            this.gvTransferencia.CustomizationFormBounds = new System.Drawing.Rectangle(-759, 386, 260, 272);
            this.gvTransferencia.DetailHeight = 284;
            this.gvTransferencia.GridControl = this.gcTransferencia;
            this.gvTransferencia.Name = "gvTransferencia";
            this.gvTransferencia.OptionsView.ShowAutoFilterRow = true;
            this.gvTransferencia.OptionsView.ShowFooter = true;
            this.gvTransferencia.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "# Transaccion";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 88;
            // 
            // colbodega_in
            // 
            this.colbodega_in.Caption = "Bodega Origen";
            this.colbodega_in.FieldName = "bodega_in";
            this.colbodega_in.Name = "colbodega_in";
            this.colbodega_in.OptionsColumn.AllowEdit = false;
            this.colbodega_in.Visible = true;
            this.colbodega_in.VisibleIndex = 1;
            this.colbodega_in.Width = 109;
            // 
            // colbodega_out
            // 
            this.colbodega_out.Caption = "Bodega Destino";
            this.colbodega_out.FieldName = "bodega_out";
            this.colbodega_out.Name = "colbodega_out";
            this.colbodega_out.OptionsColumn.AllowEdit = false;
            this.colbodega_out.Visible = true;
            this.colbodega_out.VisibleIndex = 2;
            this.colbodega_out.Width = 109;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            this.colfecha.Width = 96;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colDocEntry
            // 
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.OptionsColumn.AllowEdit = false;
            this.colDocEntry.Width = 83;
            // 
            // coluser_creador
            // 
            this.coluser_creador.FieldName = "user_creador";
            this.coluser_creador.Name = "coluser_creador";
            this.coluser_creador.OptionsColumn.AllowEdit = false;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "# Ingreso";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 9;
            this.colnumero_transaccion.Width = 74;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo SAP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 4;
            this.colitemcode.Width = 93;
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 5;
            this.colmp.Width = 124;
            // 
            // colid_ingreso
            // 
            this.colid_ingreso.FieldName = "id_ingreso";
            this.colid_ingreso.Name = "colid_ingreso";
            this.colid_ingreso.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver Detalle";
            this.gridColumn1.ColumnEdit = this.repositoryVerDetalle;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 84;
            // 
            // repositoryVerDetalle
            // 
            this.repositoryVerDetalle.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryVerDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryVerDetalle.Name = "repositoryVerDetalle";
            this.repositoryVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryVerDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryVerDetalle_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Imprimir Plan";
            this.gridColumn2.ColumnEdit = this.repositoryPrint;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 11;
            this.gridColumn2.Width = 87;
            // 
            // repositoryPrint
            // 
            this.repositoryPrint.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryPrint.Name = "repositoryPrint";
            this.repositoryPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryPrint_ButtonClick);
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario ";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 8;
            this.colusuario.Width = 77;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "Orden de Compra SAP";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 6;
            this.colDocNum.Width = 125;
            // 
            // colPrintIngresoPlanta
            // 
            this.colPrintIngresoPlanta.Caption = "Imprimir Ingresado";
            this.colPrintIngresoPlanta.ColumnEdit = this.cmdPrintIngresado;
            this.colPrintIngresoPlanta.Name = "colPrintIngresoPlanta";
            this.colPrintIngresoPlanta.Visible = true;
            this.colPrintIngresoPlanta.VisibleIndex = 12;
            this.colPrintIngresoPlanta.Width = 121;
            // 
            // cmdPrintIngresado
            // 
            this.cmdPrintIngresado.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.cmdPrintIngresado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPrintIngresado.Name = "cmdPrintIngresado";
            this.cmdPrintIngresado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdPrintIngresado.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdPrintIngresado_ButtonClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.cancel;
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1148, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 47);
            this.btnAtras.TabIndex = 44;
            this.btnAtras.Text = "Cancelar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnTransferencia.Appearance.Options.UseFont = true;
            this.btnTransferencia.Appearance.Options.UseTextOptions = true;
            this.btnTransferencia.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnTransferencia.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTransferencia.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.logout;
            this.btnTransferencia.Location = new System.Drawing.Point(2, 3);
            this.btnTransferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(182, 47);
            this.btnTransferencia.TabIndex = 45;
            this.btnTransferencia.Text = "Transf. de Almacénes";
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // colfactura
            // 
            this.colfactura.Caption = "Factura";
            this.colfactura.FieldName = "factura";
            this.colfactura.Name = "colfactura";
            this.colfactura.OptionsColumn.AllowEdit = false;
            this.colfactura.Visible = true;
            this.colfactura.VisibleIndex = 7;
            this.colfactura.Width = 94;
            // 
            // xfrmMovimientoStockMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 523);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcTransferencia);
            this.Name = "xfrmMovimientoStockMain";
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVerDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintIngresado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTransferencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransferencia;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private dsSalidasAlmacenesExternos dsSalidasAlmacenesExternos1;
        private DevExpress.XtraEditors.SimpleButton btnTransferencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryVerDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_in;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_out;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintIngresoPlanta;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPrintIngresado;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura;
    }
}