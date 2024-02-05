
namespace JAGUAR_APP.Facturacion.Notas
{
    partial class frmNotasSearchPDV
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
            this.luePDV = new DevExpress.XtraEditors.LookUpEdit();
            this.pDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientosFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientosFacturacion = new JAGUAR_APP.Facturacion.Mantenimientos.dsMantenimientosFacturacion();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.luePDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // luePDV
            // 
            this.luePDV.Location = new System.Drawing.Point(144, 42);
            this.luePDV.Name = "luePDV";
            this.luePDV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePDV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre_local", "nombre_local", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre_legal", "nombre_legal", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luePDV.Properties.DataSource = this.pDVBindingSource;
            this.luePDV.Properties.DisplayMember = "nombre_local";
            this.luePDV.Properties.ValueMember = "id";
            this.luePDV.Size = new System.Drawing.Size(255, 20);
            this.luePDV.TabIndex = 0;
            // 
            // pDVBindingSource
            // 
            this.pDVBindingSource.DataMember = "PDV";
            this.pDVBindingSource.DataSource = this.dsMantenimientosFacturacionBindingSource;
            // 
            // dsMantenimientosFacturacionBindingSource
            // 
            this.dsMantenimientosFacturacionBindingSource.DataSource = this.dsMantenimientosFacturacion;
            this.dsMantenimientosFacturacionBindingSource.Position = 0;
            // 
            // dsMantenimientosFacturacion
            // 
            this.dsMantenimientosFacturacion.DataSetName = "dsMantenimientosFacturacion";
            this.dsMantenimientosFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Punto de Venta:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(225, 88);
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
            this.simpleButton2.Location = new System.Drawing.Point(105, 88);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(114, 41);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Seleccionar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmNotasSearchPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 150);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.luePDV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotasSearchPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Punto de Venta";
            ((System.ComponentModel.ISupportInitialize)(this.luePDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit luePDV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource pDVBindingSource;
        private System.Windows.Forms.BindingSource dsMantenimientosFacturacionBindingSource;
        private Mantenimientos.dsMantenimientosFacturacion dsMantenimientosFacturacion;
    }
}