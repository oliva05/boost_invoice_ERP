
namespace JAGUAR_APP.AlmacenesExterno
{
    partial class frmTipoIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoIngreso));
            this.btnGranel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_IngresoNormal = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnGranel
            // 
            this.btnGranel.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGranel.Appearance.Options.UseFont = true;
            this.btnGranel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGranel.ImageOptions.Image")));
            this.btnGranel.Location = new System.Drawing.Point(95, 104);
            this.btnGranel.Name = "btnGranel";
            this.btnGranel.Size = new System.Drawing.Size(302, 59);
            this.btnGranel.TabIndex = 0;
            this.btnGranel.Text = "Ingreso de granel";
            // 
            // btn_IngresoNormal
            // 
            this.btn_IngresoNormal.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IngresoNormal.Appearance.Options.UseFont = true;
            this.btn_IngresoNormal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_IngresoNormal.ImageOptions.Image")));
            this.btn_IngresoNormal.Location = new System.Drawing.Point(95, 37);
            this.btn_IngresoNormal.Name = "btn_IngresoNormal";
            this.btn_IngresoNormal.Size = new System.Drawing.Size(302, 59);
            this.btn_IngresoNormal.TabIndex = 1;
            this.btn_IngresoNormal.Text = "Ingreso de sacos";
            // 
            // frmTipoIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 201);
            this.Controls.Add(this.btn_IngresoNormal);
            this.Controls.Add(this.btnGranel);
            this.Name = "frmTipoIngreso";
            this.Text = "Seleccionar tipo de ingreso.";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGranel;
        private DevExpress.XtraEditors.SimpleButton btn_IngresoNormal;
    }
}