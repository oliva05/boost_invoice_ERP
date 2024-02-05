namespace JAGUAR_APP.Mantenimientos
{
    partial class frmTipoPresentacionCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPresentacionCRUD));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.txtFactor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcionPresentacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchEnable = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEditTipoPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceTipoPresentacion = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento1 = new JAGUAR_APP.Mantenimientos.dsMantenimiento();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 21);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Descripción";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGuardar.Location = new System.Drawing.Point(3, 1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 50);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(428, 1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(147, 50);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtFactor
            // 
            this.txtFactor.EditValue = "0.0000";
            this.txtFactor.Location = new System.Drawing.Point(144, 152);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtFactor.Properties.Appearance.Options.UseFont = true;
            this.txtFactor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFactor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFactor.Properties.DisplayFormat.FormatString = "n4";
            this.txtFactor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFactor.Properties.EditFormat.FormatString = "n4";
            this.txtFactor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFactor.Properties.Mask.EditMask = "n4";
            this.txtFactor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFactor.Properties.NullText = "0";
            this.txtFactor.Size = new System.Drawing.Size(107, 26);
            this.txtFactor.TabIndex = 1;
            this.txtFactor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFactor_KeyDown);
            this.txtFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextEdit1_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 154);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 21);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Factor de Libra";
            // 
            // txtDescripcionPresentacion
            // 
            this.txtDescripcionPresentacion.Location = new System.Drawing.Point(144, 69);
            this.txtDescripcionPresentacion.Name = "txtDescripcionPresentacion";
            this.txtDescripcionPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPresentacion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionPresentacion.Size = new System.Drawing.Size(327, 26);
            this.txtDescripcionPresentacion.TabIndex = 0;
            this.txtDescripcionPresentacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcionPresentacion_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 21);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Habilitada";
            // 
            // toggleSwitchEnable
            // 
            this.toggleSwitchEnable.Location = new System.Drawing.Point(144, 107);
            this.toggleSwitchEnable.Name = "toggleSwitchEnable";
            this.toggleSwitchEnable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.toggleSwitchEnable.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchEnable.Properties.OffText = "No";
            this.toggleSwitchEnable.Properties.OnText = "Si";
            this.toggleSwitchEnable.Size = new System.Drawing.Size(123, 30);
            this.toggleSwitchEnable.TabIndex = 34;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 195);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 21);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "Tipo Presentación";
            // 
            // gridLookUpEditTipoPresentacion
            // 
            this.gridLookUpEditTipoPresentacion.EditValue = "";
            this.gridLookUpEditTipoPresentacion.Location = new System.Drawing.Point(144, 193);
            this.gridLookUpEditTipoPresentacion.Name = "gridLookUpEditTipoPresentacion";
            this.gridLookUpEditTipoPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEditTipoPresentacion.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditTipoPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditTipoPresentacion.Properties.DataSource = this.bindingSourceTipoPresentacion;
            this.gridLookUpEditTipoPresentacion.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditTipoPresentacion.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditTipoPresentacion.Properties.ValueMember = "id";
            this.gridLookUpEditTipoPresentacion.Size = new System.Drawing.Size(327, 26);
            this.gridLookUpEditTipoPresentacion.TabIndex = 2;
            this.gridLookUpEditTipoPresentacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridLookUpEditTipoPresentacion_KeyDown);
            // 
            // bindingSourceTipoPresentacion
            // 
            this.bindingSourceTipoPresentacion.DataMember = "Presentacion_tipo";
            this.bindingSourceTipoPresentacion.DataSource = this.dsMantenimiento1;
            // 
            // dsMantenimiento1
            // 
            this.dsMantenimiento1.DataSetName = "dsMantenimiento";
            this.dsMantenimiento1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // frmTipoPresentacionCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 234);
            this.Controls.Add(this.gridLookUpEditTipoPresentacion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.toggleSwitchEnable);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDescripcionPresentacion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtFactor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl3);
            this.Name = "frmTipoPresentacionCRUD";
            this.ShowIcon = false;
            this.Text = "Agregar Nueva Presentación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmTipoPresentacionCRUD_Activated);
            this.Load += new System.EventHandler(this.frmTipoPresentacionCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.TextEdit txtFactor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDescripcionPresentacion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchEnable;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditTipoPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private dsMantenimiento dsMantenimiento1;
        private System.Windows.Forms.BindingSource bindingSourceTipoPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
    }
}