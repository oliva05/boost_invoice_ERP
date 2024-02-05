
namespace JAGUAR_APP.AlmacenesExterno
{
    partial class xfrmSeleccionarTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSeleccionarTransferencia));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
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
            this.colid_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposSeleccionado = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(201, 21);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Seleccione la Transferencia:";
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
            this.btnAtras.Location = new System.Drawing.Point(1243, 23);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 47);
            this.btnAtras.TabIndex = 46;
            this.btnAtras.Text = "Cancelar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gcTransferencia
            // 
            this.gcTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransferencia.DataMember = "Salida_Almacen_H_Seleccion";
            this.gcTransferencia.DataSource = this.dsSalidasAlmacenesExternos1;
            this.gcTransferencia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTransferencia.Location = new System.Drawing.Point(3, 77);
            this.gcTransferencia.MainView = this.gvTransferencia;
            this.gcTransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTransferencia.Name = "gcTransferencia";
            this.gcTransferencia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposSeleccionado});
            this.gcTransferencia.Size = new System.Drawing.Size(1401, 522);
            this.gcTransferencia.TabIndex = 48;
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
            this.colid_ingreso,
            this.colusuario,
            this.colDocNum,
            this.colSeleccionado,
            this.colitemcode,
            this.colmp});
            this.gvTransferencia.CustomizationFormBounds = new System.Drawing.Rectangle(1200, 465, 260, 272);
            this.gvTransferencia.DetailHeight = 284;
            this.gvTransferencia.GridControl = this.gcTransferencia;
            this.gvTransferencia.Name = "gvTransferencia";
            this.gvTransferencia.OptionsView.ShowAutoFilterRow = true;
            this.gvTransferencia.OptionsView.ShowFooter = true;
            this.gvTransferencia.OptionsView.ShowGroupPanel = false;
            this.gvTransferencia.DoubleClick += new System.EventHandler(this.gvTransferencia_DoubleClick);
            // 
            // colid
            // 
            this.colid.Caption = "# de Transferencia";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colbodega_in
            // 
            this.colbodega_in.Caption = "Bodega IN";
            this.colbodega_in.FieldName = "bodega_in";
            this.colbodega_in.Name = "colbodega_in";
            this.colbodega_in.OptionsColumn.AllowEdit = false;
            this.colbodega_in.Visible = true;
            this.colbodega_in.VisibleIndex = 1;
            // 
            // colbodega_out
            // 
            this.colbodega_out.Caption = "Bodega OUT";
            this.colbodega_out.FieldName = "bodega_out";
            this.colbodega_out.Name = "colbodega_out";
            this.colbodega_out.OptionsColumn.AllowEdit = false;
            this.colbodega_out.Visible = true;
            this.colbodega_out.VisibleIndex = 2;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "G";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 5;
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
            this.colDocEntry.Visible = true;
            this.colDocEntry.VisibleIndex = 6;
            // 
            // coluser_creador
            // 
            this.coluser_creador.Caption = "id_user";
            this.coluser_creador.FieldName = "user_creador";
            this.coluser_creador.Name = "coluser_creador";
            this.coluser_creador.OptionsColumn.AllowEdit = false;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "Numero Transaccion";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 9;
            // 
            // colid_ingreso
            // 
            this.colid_ingreso.FieldName = "id_ingreso";
            this.colid_ingreso.Name = "colid_ingreso";
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 8;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "Orden de Compra SAP";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 7;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.Caption = "Seleccionar";
            this.colSeleccionado.ColumnEdit = this.reposSeleccionado;
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 10;
            // 
            // reposSeleccionado
            // 
            this.reposSeleccionado.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposSeleccionado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposSeleccionado.Name = "reposSeleccionado";
            this.reposSeleccionado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposSeleccionado.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposSeleccionado_ButtonClick);
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Cod. SAP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 3;
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 4;
            // 
            // xfrmSeleccionarTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 602);
            this.Controls.Add(this.gcTransferencia);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.Name = "xfrmSeleccionarTransferencia";
            this.Text = "xfrmSeleccionarTransferencia";
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcTransferencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransferencia;
        private dsSalidasAlmacenesExternos dsSalidasAlmacenesExternos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_in;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_out;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
    }
}