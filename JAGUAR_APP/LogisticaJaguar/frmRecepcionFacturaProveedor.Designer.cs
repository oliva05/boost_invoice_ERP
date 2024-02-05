
namespace JAGUAR_APP.LogisticaJaguar
{
    partial class frmRecepcionFacturaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcionFacturaProveedor));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsLogisticaJaguar1 = new JAGUAR_APP.LogisticaJaguar.dsLogisticaJaguar();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedorNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_recibido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioRecibio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistroCancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado_por_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado_por_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado_por_hora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado_por_telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_revisado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioRevisado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_revisado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Print = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPrintFromGrid = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.column_Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVer_Editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.toggleSwitchVerTodas = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintFromGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVer_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchVerTodas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(159, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(334, 34);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Recepción de Factura de Compra";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(9, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 44);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(922, 41);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(145, 44);
            this.btnAtras.TabIndex = 34;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "home_list_fact_in";
            this.gridControl1.DataSource = this.dsLogisticaJaguar1;
            this.gridControl1.Location = new System.Drawing.Point(2, 92);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPrintFromGrid,
            this.cmdVer_Editar});
            this.gridControl1.Size = new System.Drawing.Size(1078, 443);
            this.gridControl1.TabIndex = 37;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsLogisticaJaguar1
            // 
            this.dsLogisticaJaguar1.DataSetName = "dsLogisticaJaguar";
            this.dsLogisticaJaguar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_proveedor,
            this.colProveedorNombre,
            this.colid_usuario_recibido,
            this.colUsuarioRecibio,
            this.colcai,
            this.colfactura,
            this.colfecha_factura,
            this.colfecha_registro,
            this.colenable,
            this.colRegistroCancelado,
            this.colentregado_por_nombre,
            this.colentregado_por_identidad,
            this.colentregado_por_hora,
            this.colentregado_por_telefono,
            this.colid_usuario_revisado,
            this.colUsuarioRevisado,
            this.colhora_revisado,
            this.colobservaciones,
            this.colDocNum,
            this.col_Print,
            this.column_Editar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
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
            this.colid_proveedor.OptionsColumn.ReadOnly = true;
            // 
            // colProveedorNombre
            // 
            this.colProveedorNombre.FieldName = "Proveedor Nombre";
            this.colProveedorNombre.Name = "colProveedorNombre";
            this.colProveedorNombre.OptionsColumn.ReadOnly = true;
            this.colProveedorNombre.Visible = true;
            this.colProveedorNombre.VisibleIndex = 2;
            this.colProveedorNombre.Width = 144;
            // 
            // colid_usuario_recibido
            // 
            this.colid_usuario_recibido.FieldName = "id_usuario_recibido";
            this.colid_usuario_recibido.Name = "colid_usuario_recibido";
            this.colid_usuario_recibido.OptionsColumn.ReadOnly = true;
            // 
            // colUsuarioRecibio
            // 
            this.colUsuarioRecibio.FieldName = "Usuario Recibio";
            this.colUsuarioRecibio.Name = "colUsuarioRecibio";
            this.colUsuarioRecibio.OptionsColumn.ReadOnly = true;
            this.colUsuarioRecibio.Visible = true;
            this.colUsuarioRecibio.VisibleIndex = 1;
            this.colUsuarioRecibio.Width = 92;
            // 
            // colcai
            // 
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            this.colcai.OptionsColumn.ReadOnly = true;
            this.colcai.Visible = true;
            this.colcai.VisibleIndex = 3;
            this.colcai.Width = 117;
            // 
            // colfactura
            // 
            this.colfactura.FieldName = "factura";
            this.colfactura.Name = "colfactura";
            this.colfactura.OptionsColumn.ReadOnly = true;
            this.colfactura.Visible = true;
            this.colfactura.VisibleIndex = 4;
            this.colfactura.Width = 158;
            // 
            // colfecha_factura
            // 
            this.colfecha_factura.FieldName = "fecha_factura";
            this.colfecha_factura.Name = "colfecha_factura";
            this.colfecha_factura.OptionsColumn.ReadOnly = true;
            this.colfecha_factura.Visible = true;
            this.colfecha_factura.VisibleIndex = 5;
            this.colfecha_factura.Width = 81;
            // 
            // colfecha_registro
            // 
            this.colfecha_registro.FieldName = "fecha_registro";
            this.colfecha_registro.Name = "colfecha_registro";
            this.colfecha_registro.OptionsColumn.ReadOnly = true;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colRegistroCancelado
            // 
            this.colRegistroCancelado.FieldName = "Registro Cancelado";
            this.colRegistroCancelado.Name = "colRegistroCancelado";
            this.colRegistroCancelado.OptionsColumn.ReadOnly = true;
            this.colRegistroCancelado.Visible = true;
            this.colRegistroCancelado.VisibleIndex = 6;
            this.colRegistroCancelado.Width = 100;
            // 
            // colentregado_por_nombre
            // 
            this.colentregado_por_nombre.FieldName = "entregado_por_nombre";
            this.colentregado_por_nombre.Name = "colentregado_por_nombre";
            this.colentregado_por_nombre.OptionsColumn.ReadOnly = true;
            // 
            // colentregado_por_identidad
            // 
            this.colentregado_por_identidad.FieldName = "entregado_por_identidad";
            this.colentregado_por_identidad.Name = "colentregado_por_identidad";
            this.colentregado_por_identidad.OptionsColumn.ReadOnly = true;
            // 
            // colentregado_por_hora
            // 
            this.colentregado_por_hora.FieldName = "entregado_por_hora";
            this.colentregado_por_hora.Name = "colentregado_por_hora";
            this.colentregado_por_hora.OptionsColumn.ReadOnly = true;
            // 
            // colentregado_por_telefono
            // 
            this.colentregado_por_telefono.FieldName = "entregado_por_telefono";
            this.colentregado_por_telefono.Name = "colentregado_por_telefono";
            this.colentregado_por_telefono.OptionsColumn.ReadOnly = true;
            // 
            // colid_usuario_revisado
            // 
            this.colid_usuario_revisado.FieldName = "id_usuario_revisado";
            this.colid_usuario_revisado.Name = "colid_usuario_revisado";
            this.colid_usuario_revisado.OptionsColumn.ReadOnly = true;
            // 
            // colUsuarioRevisado
            // 
            this.colUsuarioRevisado.FieldName = "Usuario Revisado";
            this.colUsuarioRevisado.Name = "colUsuarioRevisado";
            this.colUsuarioRevisado.OptionsColumn.ReadOnly = true;
            // 
            // colhora_revisado
            // 
            this.colhora_revisado.FieldName = "hora_revisado";
            this.colhora_revisado.Name = "colhora_revisado";
            this.colhora_revisado.OptionsColumn.ReadOnly = true;
            // 
            // colobservaciones
            // 
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.Name = "colobservaciones";
            this.colobservaciones.OptionsColumn.ReadOnly = true;
            this.colobservaciones.Visible = true;
            this.colobservaciones.VisibleIndex = 7;
            this.colobservaciones.Width = 141;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 68;
            // 
            // col_Print
            // 
            this.col_Print.Caption = "Imprimir";
            this.col_Print.ColumnEdit = this.cmdPrintFromGrid;
            this.col_Print.Name = "col_Print";
            this.col_Print.Visible = true;
            this.col_Print.VisibleIndex = 9;
            // 
            // cmdPrintFromGrid
            // 
            this.cmdPrintFromGrid.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdPrintFromGrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPrintFromGrid.Name = "cmdPrintFromGrid";
            this.cmdPrintFromGrid.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdPrintFromGrid.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdPrintFromGrid_ButtonClick);
            // 
            // column_Editar
            // 
            this.column_Editar.Caption = "Ver";
            this.column_Editar.ColumnEdit = this.cmdVer_Editar;
            this.column_Editar.Name = "column_Editar";
            this.column_Editar.Visible = true;
            this.column_Editar.VisibleIndex = 8;
            // 
            // cmdVer_Editar
            // 
            this.cmdVer_Editar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdVer_Editar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVer_Editar.Name = "cmdVer_Editar";
            this.cmdVer_Editar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVer_Editar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVer_Editar_ButtonClick);
            // 
            // toggleSwitchVerTodas
            // 
            this.toggleSwitchVerTodas.Location = new System.Drawing.Point(607, 58);
            this.toggleSwitchVerTodas.Name = "toggleSwitchVerTodas";
            this.toggleSwitchVerTodas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.toggleSwitchVerTodas.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchVerTodas.Properties.OffText = "No";
            this.toggleSwitchVerTodas.Properties.OnText = "Si";
            this.toggleSwitchVerTodas.Size = new System.Drawing.Size(109, 28);
            this.toggleSwitchVerTodas.TabIndex = 38;
            this.toggleSwitchVerTodas.Toggled += new System.EventHandler(this.toggleSwitchVerTodas_Toggled);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(540, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 17);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Ver Todos";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.excel32px;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(771, 41);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 44);
            this.simpleButton1.TabIndex = 40;
            this.simpleButton1.Text = "Exportar a Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmRecepcionFacturaProveedor
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 535);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.toggleSwitchVerTodas);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecepcionFacturaProveedor";
            this.Text = "Recepción de Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintFromGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVer_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchVerTodas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsLogisticaJaguar dsLogisticaJaguar1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedorNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_recibido;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioRecibio;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistroCancelado;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado_por_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado_por_identidad;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado_por_hora;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado_por_telefono;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_revisado;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioRevisado;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_revisado;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn col_Print;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPrintFromGrid;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchVerTodas;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn column_Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVer_Editar;
    }
}