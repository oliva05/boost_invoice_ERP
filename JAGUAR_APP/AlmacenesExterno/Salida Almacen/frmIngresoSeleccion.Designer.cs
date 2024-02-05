
namespace JAGUAR_APP.AlmacenesExterno.Salida_Almacen
{
    partial class frmIngresoSeleccion
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
            this.btnTarimas = new DevExpress.XtraEditors.SimpleButton();
            this.btnGranel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnTarimas
            // 
            this.btnTarimas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarimas.Appearance.Options.UseFont = true;
            this.btnTarimas.Location = new System.Drawing.Point(84, 65);
            this.btnTarimas.Name = "btnTarimas";
            this.btnTarimas.Size = new System.Drawing.Size(227, 86);
            this.btnTarimas.TabIndex = 0;
            this.btnTarimas.Text = "Seleccion TM";
            this.btnTarimas.Click += new System.EventHandler(this.btnTarimas_Click);
            // 
            // btnGranel
            // 
            this.btnGranel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGranel.Appearance.Options.UseFont = true;
            this.btnGranel.Location = new System.Drawing.Point(341, 65);
            this.btnGranel.Name = "btnGranel";
            this.btnGranel.Size = new System.Drawing.Size(256, 86);
            this.btnGranel.TabIndex = 1;
            this.btnGranel.Text = "Entrada Granel";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(192, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Seleccion de tipo de ingreso";
            // 
            // frmIngresoSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 185);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGranel);
            this.Controls.Add(this.btnTarimas);
            this.Name = "frmIngresoSeleccion";
            this.Text = "Seleccion de ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTarimas;
        private DevExpress.XtraEditors.SimpleButton btnGranel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}