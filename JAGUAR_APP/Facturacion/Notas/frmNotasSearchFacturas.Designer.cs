
namespace JAGUAR_APP.Facturacion.Notas
{
    partial class frmNotasSearchFacturas
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotasSearchFacturas));
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
            this.dsMantenimientosFacturacion = new JAGUAR_APP.Facturacion.Mantenimientos.dsMantenimientosFacturacion();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFacturasGestion = new JAGUAR_APP.Facturacion.CoreFacturas.dsFacturasGestion();
            this.gvFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_print = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_orden_compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_punto_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_numeracion_fiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsarioCreateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuntoVentaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPagoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_termino_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltermino_pago_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdPagarFactura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAutorizar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPagarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutorizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dsMantenimientosFacturacion
            // 
            this.dsMantenimientosFacturacion.DataSetName = "dsMantenimientosFacturacion";
            this.dsMantenimientosFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(876, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 41);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(756, 26);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(114, 41);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Seleccionar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dsMantenimientosFacturacion;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "HomeFacturas";
            this.gridControl1.DataSource = this.dsFacturasGestion;
            this.gridControl1.Location = new System.Drawing.Point(1, 73);
            this.gridControl1.MainView = this.gvFacturas;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnImprimir,
            this.cmdPagarFactura,
            this.btnAutorizar});
            this.gridControl1.Size = new System.Drawing.Size(1004, 320);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFacturas});
            // 
            // dsFacturasGestion
            // 
            this.dsFacturasGestion.DataSetName = "dsFacturasGestion";
            this.dsFacturasGestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvFacturas
            // 
            this.gvFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnumero_documento,
            this.colenable,
            this.colid_estado,
            this.colcant_print,
            this.colid_user,
            this.colfecha_row,
            this.colfecha_documento,
            this.colid_cliente,
            this.colRTN,
            this.colnum_orden_compra,
            this.colid_punto_venta,
            this.colid_numeracion_fiscal,
            this.colcliente_nombre,
            this.colid_tipo_pago,
            this.colTotalFactura,
            this.colEstadoName,
            this.colUsarioCreateName,
            this.colPuntoVentaName,
            this.colTipoPagoName,
            this.gridColumn3,
            this.colid_termino_pago,
            this.coltermino_pago_name});
            this.gvFacturas.GridControl = this.gridControl1;
            this.gvFacturas.Name = "gvFacturas";
            this.gvFacturas.OptionsView.ShowAutoFilterRow = true;
            this.gvFacturas.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colnumero_documento
            // 
            this.colnumero_documento.FieldName = "numero_documento";
            this.colnumero_documento.Name = "colnumero_documento";
            this.colnumero_documento.OptionsColumn.ReadOnly = true;
            this.colnumero_documento.Visible = true;
            this.colnumero_documento.VisibleIndex = 0;
            this.colnumero_documento.Width = 55;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            // 
            // colcant_print
            // 
            this.colcant_print.FieldName = "cant_print";
            this.colcant_print.Name = "colcant_print";
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            // 
            // colfecha_row
            // 
            this.colfecha_row.FieldName = "fecha_row";
            this.colfecha_row.Name = "colfecha_row";
            // 
            // colfecha_documento
            // 
            this.colfecha_documento.FieldName = "fecha_documento";
            this.colfecha_documento.Name = "colfecha_documento";
            this.colfecha_documento.OptionsColumn.ReadOnly = true;
            this.colfecha_documento.Visible = true;
            this.colfecha_documento.VisibleIndex = 1;
            this.colfecha_documento.Width = 77;
            // 
            // colid_cliente
            // 
            this.colid_cliente.FieldName = "id_cliente";
            this.colid_cliente.Name = "colid_cliente";
            // 
            // colRTN
            // 
            this.colRTN.FieldName = "RTN";
            this.colRTN.Name = "colRTN";
            this.colRTN.OptionsColumn.ReadOnly = true;
            this.colRTN.Visible = true;
            this.colRTN.VisibleIndex = 2;
            this.colRTN.Width = 63;
            // 
            // colnum_orden_compra
            // 
            this.colnum_orden_compra.FieldName = "num_orden_compra";
            this.colnum_orden_compra.Name = "colnum_orden_compra";
            // 
            // colid_punto_venta
            // 
            this.colid_punto_venta.FieldName = "id_punto_venta";
            this.colid_punto_venta.Name = "colid_punto_venta";
            // 
            // colid_numeracion_fiscal
            // 
            this.colid_numeracion_fiscal.FieldName = "id_numeracion_fiscal";
            this.colid_numeracion_fiscal.Name = "colid_numeracion_fiscal";
            // 
            // colcliente_nombre
            // 
            this.colcliente_nombre.FieldName = "cliente_nombre";
            this.colcliente_nombre.Name = "colcliente_nombre";
            this.colcliente_nombre.OptionsColumn.ReadOnly = true;
            this.colcliente_nombre.Visible = true;
            this.colcliente_nombre.VisibleIndex = 3;
            this.colcliente_nombre.Width = 86;
            // 
            // colid_tipo_pago
            // 
            this.colid_tipo_pago.FieldName = "id_tipo_pago";
            this.colid_tipo_pago.Name = "colid_tipo_pago";
            // 
            // colTotalFactura
            // 
            this.colTotalFactura.FieldName = "TotalFactura";
            this.colTotalFactura.Name = "colTotalFactura";
            this.colTotalFactura.OptionsColumn.ReadOnly = true;
            this.colTotalFactura.Visible = true;
            this.colTotalFactura.VisibleIndex = 4;
            this.colTotalFactura.Width = 82;
            // 
            // colEstadoName
            // 
            this.colEstadoName.FieldName = "EstadoName";
            this.colEstadoName.Name = "colEstadoName";
            this.colEstadoName.OptionsColumn.ReadOnly = true;
            this.colEstadoName.Visible = true;
            this.colEstadoName.VisibleIndex = 5;
            this.colEstadoName.Width = 65;
            // 
            // colUsarioCreateName
            // 
            this.colUsarioCreateName.FieldName = "UsarioCreateName";
            this.colUsarioCreateName.Name = "colUsarioCreateName";
            this.colUsarioCreateName.OptionsColumn.ReadOnly = true;
            this.colUsarioCreateName.Width = 43;
            // 
            // colPuntoVentaName
            // 
            this.colPuntoVentaName.FieldName = "PuntoVentaName";
            this.colPuntoVentaName.Name = "colPuntoVentaName";
            this.colPuntoVentaName.OptionsColumn.ReadOnly = true;
            this.colPuntoVentaName.Visible = true;
            this.colPuntoVentaName.VisibleIndex = 6;
            this.colPuntoVentaName.Width = 52;
            // 
            // colTipoPagoName
            // 
            this.colTipoPagoName.FieldName = "TipoPagoName";
            this.colTipoPagoName.Name = "colTipoPagoName";
            this.colTipoPagoName.OptionsColumn.ReadOnly = true;
            this.colTipoPagoName.Visible = true;
            this.colTipoPagoName.VisibleIndex = 7;
            this.colTipoPagoName.Width = 61;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Selecc.";
            this.gridColumn3.FieldName = "seleccionado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 34;
            // 
            // colid_termino_pago
            // 
            this.colid_termino_pago.FieldName = "id_termino_pago";
            this.colid_termino_pago.Name = "colid_termino_pago";
            this.colid_termino_pago.OptionsColumn.ReadOnly = true;
            this.colid_termino_pago.Width = 56;
            // 
            // coltermino_pago_name
            // 
            this.coltermino_pago_name.FieldName = "termino_pago_name";
            this.coltermino_pago_name.Name = "coltermino_pago_name";
            this.coltermino_pago_name.OptionsColumn.ReadOnly = true;
            this.coltermino_pago_name.Visible = true;
            this.coltermino_pago_name.VisibleIndex = 8;
            this.coltermino_pago_name.Width = 60;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdPagarFactura
            // 
            this.cmdPagarFactura.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdPagarFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPagarFactura.Name = "cmdPagarFactura";
            this.cmdPagarFactura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.AutoHeight = false;
            editorButtonImageOptions3.Image = global::JAGUAR_APP.Properties.Resources.shield_16X16;
            this.btnAutorizar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(290, 20);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Seleccionar las facturas a aplicar las notas";
            // 
            // frmNotasSearchFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 391);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotasSearchFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPagarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutorizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private Mantenimientos.dsMantenimientosFacturacion dsMantenimientosFacturacion;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_print;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_row;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colRTN;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_orden_compra;
        private DevExpress.XtraGrid.Columns.GridColumn colid_punto_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_numeracion_fiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_pago;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoName;
        private DevExpress.XtraGrid.Columns.GridColumn colUsarioCreateName;
        private DevExpress.XtraGrid.Columns.GridColumn colPuntoVentaName;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPagoName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colid_termino_pago;
        private DevExpress.XtraGrid.Columns.GridColumn coltermino_pago_name;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnImprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPagarFactura;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAutorizar;
        private CoreFacturas.dsFacturasGestion dsFacturasGestion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}