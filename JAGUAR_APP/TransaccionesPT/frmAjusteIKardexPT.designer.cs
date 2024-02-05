
using JAGUAR_APP.TransaccionesMP;

namespace JAGUAR_APP.TransaccionesPT
{
    partial class frmAjusteIKardexPT
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjusteIKardexPT));
            this.dtFechaDocumento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.bodegadestinoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTarima1 = new JAGUAR_APP.TransaccionesMP.dsTarima();
            this.bodegadestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaorigenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaorigenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPT_Name = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tsTipoTransaccion = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumLote = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gridLookUpEditPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.presentacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMP = new LOSA.RecepcionMP.dsRecepcionMP();
            this.gvLookUpEditPresentacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadUnidades = new DevExpress.XtraEditors.TextEdit();
            this.lblCostoUnitario = new DevExpress.XtraEditors.LabelControl();
            this.txtCostoUnitario = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegadestinoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarima1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegadestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaorigenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaorigenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPT_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTipoTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLookUpEditPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoUnitario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaDocumento
            // 
            this.dtFechaDocumento.EditValue = null;
            this.dtFechaDocumento.Location = new System.Drawing.Point(221, 166);
            this.dtFechaDocumento.Name = "dtFechaDocumento";
            this.dtFechaDocumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtFechaDocumento.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDocumento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDocumento.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.dtFechaDocumento.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaDocumento.Size = new System.Drawing.Size(355, 26);
            this.dtFechaDocumento.TabIndex = 135;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(22, 166);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(157, 24);
            this.labelControl12.TabIndex = 134;
            this.labelControl12.Text = "Fecha Documento";
            // 
            // bodegadestinoBindingSource1
            // 
            this.bodegadestinoBindingSource1.DataMember = "bodega_destino";
            this.bodegadestinoBindingSource1.DataSource = this.dsTarima1;
            // 
            // dsTarima1
            // 
            this.dsTarima1.DataSetName = "dsTarima";
            this.dsTarima1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodegaorigenBindingSource1
            // 
            this.bodegaorigenBindingSource1.DataMember = "bodega_origen";
            this.bodegaorigenBindingSource1.DataSource = this.dsTarima1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(174, 24);
            this.labelControl3.TabIndex = 128;
            this.labelControl3.Text = "Tipo de Transaccion";
            // 
            // txtPT_Name
            // 
            this.txtPT_Name.Location = new System.Drawing.Point(222, 130);
            this.txtPT_Name.Name = "txtPT_Name";
            this.txtPT_Name.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPT_Name.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = global::JAGUAR_APP.Properties.Resources.wheat;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Transparent;
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject2.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject2.Options.UseBackColor = true;
            serializableAppearanceObject3.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject3.Options.UseBackColor = true;
            serializableAppearanceObject4.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject4.Options.UseBackColor = true;
            this.txtPT_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtPT_Name.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtPT_Name.Properties.ReadOnly = true;
            this.txtPT_Name.Size = new System.Drawing.Size(355, 30);
            this.txtPT_Name.TabIndex = 123;
            this.txtPT_Name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtPT_Name_ButtonClick);
            this.txtPT_Name.EditValueChanged += new System.EventHandler(this.txtPT_Name_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(173, 24);
            this.labelControl2.TabIndex = 127;
            this.labelControl2.Text = "Producto Terminado";
            // 
            // tsTipoTransaccion
            // 
            this.tsTipoTransaccion.EditValue = true;
            this.tsTipoTransaccion.Location = new System.Drawing.Point(222, 96);
            this.tsTipoTransaccion.Name = "tsTipoTransaccion";
            this.tsTipoTransaccion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tsTipoTransaccion.Properties.Appearance.Options.UseFont = true;
            this.tsTipoTransaccion.Properties.OffText = "Salida";
            this.tsTipoTransaccion.Properties.OnText = "Entrada";
            this.tsTipoTransaccion.Size = new System.Drawing.Size(355, 28);
            this.tsTipoTransaccion.TabIndex = 122;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(24, 296);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 24);
            this.labelControl5.TabIndex = 137;
            this.labelControl5.Text = "# Lote";
            this.labelControl5.Visible = false;
            // 
            // txtNumLote
            // 
            this.txtNumLote.Location = new System.Drawing.Point(222, 294);
            this.txtNumLote.Name = "txtNumLote";
            this.txtNumLote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNumLote.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = global::JAGUAR_APP.Properties.Resources.wheat;
            serializableAppearanceObject5.BackColor = System.Drawing.Color.Transparent;
            serializableAppearanceObject5.Options.UseBackColor = true;
            serializableAppearanceObject6.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject6.Options.UseBackColor = true;
            serializableAppearanceObject7.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject7.Options.UseBackColor = true;
            serializableAppearanceObject8.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject8.Options.UseBackColor = true;
            this.txtNumLote.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtNumLote.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtNumLote.Properties.ReadOnly = true;
            this.txtNumLote.Size = new System.Drawing.Size(355, 30);
            this.txtNumLote.TabIndex = 138;
            this.txtNumLote.Visible = false;
            this.txtNumLote.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNumLote_ButtonClick);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(22, 29);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(167, 49);
            this.cmdGuardar.TabIndex = 125;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(515, 29);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 49);
            this.btnAtras.TabIndex = 126;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gridLookUpEditPresentacion
            // 
            this.gridLookUpEditPresentacion.EditValue = "";
            this.gridLookUpEditPresentacion.Enabled = false;
            this.gridLookUpEditPresentacion.Location = new System.Drawing.Point(221, 198);
            this.gridLookUpEditPresentacion.Name = "gridLookUpEditPresentacion";
            this.gridLookUpEditPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEditPresentacion.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditPresentacion.Properties.DataSource = this.presentacionesBindingSource;
            this.gridLookUpEditPresentacion.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditPresentacion.Properties.PopupView = this.gvLookUpEditPresentacion;
            this.gridLookUpEditPresentacion.Properties.ValueMember = "id";
            this.gridLookUpEditPresentacion.Size = new System.Drawing.Size(355, 26);
            this.gridLookUpEditPresentacion.TabIndex = 139;
            this.gridLookUpEditPresentacion.EditValueChanged += new System.EventHandler(this.gridLookUpEditPresentacion_EditValueChanged);
            // 
            // presentacionesBindingSource
            // 
            this.presentacionesBindingSource.DataMember = "presentaciones";
            this.presentacionesBindingSource.DataSource = this.dsRecepcionMP;
            // 
            // dsRecepcionMP
            // 
            this.dsRecepcionMP.DataSetName = "dsRecepcionMP";
            this.dsRecepcionMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLookUpEditPresentacion
            // 
            this.gvLookUpEditPresentacion.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLookUpEditPresentacion.Appearance.Row.Options.UseFont = true;
            this.gvLookUpEditPresentacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colFactor});
            this.gvLookUpEditPresentacion.DetailHeight = 284;
            this.gvLookUpEditPresentacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvLookUpEditPresentacion.Name = "gvLookUpEditPresentacion";
            this.gvLookUpEditPresentacion.OptionsEditForm.PopupEditFormWidth = 686;
            this.gvLookUpEditPresentacion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvLookUpEditPresentacion.OptionsView.ShowAutoFilterRow = true;
            this.gvLookUpEditPresentacion.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 17;
            this.colid.Name = "colid";
            this.colid.Width = 64;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Presentaciones";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.MinWidth = 17;
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 64;
            // 
            // colFactor
            // 
            this.colFactor.Caption = "gridColumn3";
            this.colFactor.FieldName = "factor";
            this.colFactor.MinWidth = 17;
            this.colFactor.Name = "colFactor";
            this.colFactor.Width = 64;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(24, 198);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(110, 24);
            this.labelControl11.TabIndex = 140;
            this.labelControl11.Text = "Presentación";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 230);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 24);
            this.labelControl1.TabIndex = 142;
            this.labelControl1.Text = "Unidades";
            // 
            // txtCantidadUnidades
            // 
            this.txtCantidadUnidades.EditValue = "0";
            this.txtCantidadUnidades.Location = new System.Drawing.Point(222, 230);
            this.txtCantidadUnidades.Name = "txtCantidadUnidades";
            this.txtCantidadUnidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCantidadUnidades.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadUnidades.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadUnidades.Properties.Mask.EditMask = "n";
            this.txtCantidadUnidades.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidadUnidades.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCantidadUnidades.Properties.MaskSettings.Set("mask", "n");
            this.txtCantidadUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadUnidades.Size = new System.Drawing.Size(355, 26);
            this.txtCantidadUnidades.TabIndex = 141;
            this.txtCantidadUnidades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidadUnidades_KeyDown);
            this.txtCantidadUnidades.Leave += new System.EventHandler(this.txtCantidadUnidades_Leave);
            // 
            // lblCostoUnitario
            // 
            this.lblCostoUnitario.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoUnitario.Appearance.Options.UseFont = true;
            this.lblCostoUnitario.Location = new System.Drawing.Point(23, 262);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(116, 24);
            this.lblCostoUnitario.TabIndex = 144;
            this.lblCostoUnitario.Text = "Costo Unitario";
            this.lblCostoUnitario.Visible = false;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.EditValue = "0";
            this.txtCostoUnitario.Location = new System.Drawing.Point(221, 262);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCostoUnitario.Properties.Appearance.Options.UseFont = true;
            this.txtCostoUnitario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCostoUnitario.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCostoUnitario.Properties.MaskSettings.Set("mask", "n");
            this.txtCostoUnitario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCostoUnitario.Size = new System.Drawing.Size(355, 26);
            this.txtCostoUnitario.TabIndex = 143;
            this.txtCostoUnitario.Visible = false;
            // 
            // frmAjusteIKardexPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 414);
            this.Controls.Add(this.lblCostoUnitario);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCantidadUnidades);
            this.Controls.Add(this.gridLookUpEditPresentacion);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dtFechaDocumento);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPT_Name);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tsTipoTransaccion);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtNumLote);
            this.Name = "frmAjusteIKardexPT";
            this.Text = "Ajuste de Inventario Por Lote PT";
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegadestinoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarima1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegadestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaorigenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaorigenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPT_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTipoTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLookUpEditPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoUnitario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtFechaDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit txtPT_Name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tsTipoTransaccion;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ButtonEdit txtNumLote;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditPresentacion;
        private System.Windows.Forms.BindingSource presentacionesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLookUpEditPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFactor;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.BindingSource bodegadestinoBindingSource;
        private System.Windows.Forms.BindingSource bodegaorigenBindingSource;
        private TransaccionesMP.dsTarima dsTarima1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCantidadUnidades;
        private System.Windows.Forms.BindingSource bodegadestinoBindingSource1;
        private System.Windows.Forms.BindingSource bodegaorigenBindingSource1;
        private LOSA.RecepcionMP.dsRecepcionMP dsRecepcionMP;
        private DevExpress.XtraEditors.LabelControl lblCostoUnitario;
        private DevExpress.XtraEditors.TextEdit txtCostoUnitario;
    }
}