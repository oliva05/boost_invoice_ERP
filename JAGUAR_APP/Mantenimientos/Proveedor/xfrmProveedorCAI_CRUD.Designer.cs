
namespace JAGUAR_APP.Mantenimientos.Proveedor
{
    partial class xfrmProveedorCAI_CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmProveedorCAI_CRUD));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtCAI = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtLeyenda = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.lueProveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.jAGUARProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento = new JAGUAR_APP.Mantenimientos.dsMantenimiento();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seCorrelativoInicia = new DevExpress.XtraEditors.TextEdit();
            this.seCorrelativoTermina = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeyenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jAGUARProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCorrelativoInicia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCorrelativoTermina.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(22, 230);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(128, 17);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Proveedor:____________";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(0, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(498, 25);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "CAI";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(242, 303);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 42);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdNew.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.save_32x32;
            this.cmdNew.Location = new System.Drawing.Point(86, 303);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(139, 42);
            this.cmdNew.TabIndex = 21;
            this.cmdNew.Text = "Guardar";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(150, 62);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCAI.Properties.Appearance.Options.UseFont = true;
            this.txtCAI.Size = new System.Drawing.Size(327, 24);
            this.txtCAI.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 196);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(203, 17);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Correlativo Termina:_______________";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(208, 17);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Correlativo Inicia:___________________:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "CAI:_________________________";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // deFechaInicio
            // 
            this.deFechaInicio.EditValue = null;
            this.deFechaInicio.Location = new System.Drawing.Point(150, 95);
            this.deFechaInicio.Name = "deFechaInicio";
            this.deFechaInicio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.deFechaInicio.Properties.Appearance.Options.UseFont = true;
            this.deFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaInicio.Size = new System.Drawing.Size(160, 24);
            this.deFechaInicio.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 17);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Fecha Inicio:__________";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(22, 130);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(128, 17);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "Fecha Fin:_____________";
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Location = new System.Drawing.Point(150, 260);
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLeyenda.Properties.Appearance.Options.UseFont = true;
            this.txtLeyenda.Size = new System.Drawing.Size(327, 24);
            this.txtLeyenda.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 262);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(151, 17);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Leyenda:___________________";
            // 
            // deFechaFin
            // 
            this.deFechaFin.EditValue = null;
            this.deFechaFin.Location = new System.Drawing.Point(150, 128);
            this.deFechaFin.Name = "deFechaFin";
            this.deFechaFin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.deFechaFin.Properties.Appearance.Options.UseFont = true;
            this.deFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFin.Size = new System.Drawing.Size(160, 24);
            this.deFechaFin.TabIndex = 2;
            // 
            // lueProveedor
            // 
            this.lueProveedor.Location = new System.Drawing.Point(150, 228);
            this.lueProveedor.Name = "lueProveedor";
            this.lueProveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lueProveedor.Properties.Appearance.Options.UseFont = true;
            this.lueProveedor.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lueProveedor.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProveedor.Properties.DataSource = this.jAGUARProveedorBindingSource;
            this.lueProveedor.Properties.DisplayMember = "nombre";
            this.lueProveedor.Properties.NullText = "";
            this.lueProveedor.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueProveedor.Properties.ValueMember = "id";
            this.lueProveedor.Size = new System.Drawing.Size(327, 24);
            this.lueProveedor.TabIndex = 5;
            // 
            // jAGUARProveedorBindingSource
            // 
            this.jAGUARProveedorBindingSource.DataMember = "JAGUAR_Proveedor";
            this.jAGUARProveedorBindingSource.DataSource = this.dsMantenimiento;
            // 
            // dsMantenimiento
            // 
            this.dsMantenimiento.DataSetName = "dsMantenimiento";
            this.dsMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Proveedor";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // seCorrelativoInicia
            // 
            this.seCorrelativoInicia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seCorrelativoInicia.Location = new System.Drawing.Point(150, 161);
            this.seCorrelativoInicia.Name = "seCorrelativoInicia";
            this.seCorrelativoInicia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.seCorrelativoInicia.Properties.Appearance.Options.UseFont = true;
            this.seCorrelativoInicia.Properties.Appearance.Options.UseTextOptions = true;
            this.seCorrelativoInicia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.seCorrelativoInicia.Properties.Mask.EditMask = "d";
            this.seCorrelativoInicia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.seCorrelativoInicia.Size = new System.Drawing.Size(160, 24);
            this.seCorrelativoInicia.TabIndex = 3;
            // 
            // seCorrelativoTermina
            // 
            this.seCorrelativoTermina.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seCorrelativoTermina.Location = new System.Drawing.Point(150, 194);
            this.seCorrelativoTermina.Name = "seCorrelativoTermina";
            this.seCorrelativoTermina.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.seCorrelativoTermina.Properties.Appearance.Options.UseFont = true;
            this.seCorrelativoTermina.Properties.Appearance.Options.UseTextOptions = true;
            this.seCorrelativoTermina.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.seCorrelativoTermina.Properties.Mask.EditMask = "d";
            this.seCorrelativoTermina.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.seCorrelativoTermina.Size = new System.Drawing.Size(160, 24);
            this.seCorrelativoTermina.TabIndex = 4;
            // 
            // xfrmProveedorCAI_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 355);
            this.Controls.Add(this.seCorrelativoInicia);
            this.Controls.Add(this.seCorrelativoTermina);
            this.Controls.Add(this.txtLeyenda);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.txtCAI);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.deFechaInicio);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deFechaFin);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lueProveedor);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmProveedorCAI_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAI";
            this.Load += new System.EventHandler(this.xfrmProveedorCAI_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeyenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jAGUARProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCorrelativoInicia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCorrelativoTermina.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.TextEdit txtCAI;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deFechaInicio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtLeyenda;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit deFechaFin;
        private System.Windows.Forms.BindingSource jAGUARProveedorBindingSource;
        private dsMantenimiento dsMantenimiento;
        private DevExpress.XtraEditors.SearchLookUpEdit lueProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit seCorrelativoInicia;
        private DevExpress.XtraEditors.TextEdit seCorrelativoTermina;
    }
}