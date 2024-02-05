
namespace JAGUAR_APP.Autorizaciones
{
    partial class frmSolicitudAutorizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudAutorizacion));
            this.label1 = new System.Windows.Forms.Label();
            this.lueUsuario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAutorizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAutorizaciones = new JAGUAR_APP.Autorizaciones.dsAutorizaciones();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lueUsuarioAprobador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lueDocumento = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.lueTipoSolicitu = new DevExpress.XtraEditors.LookUpEdit();
            this.tiposSolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.slueRuta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.rutasAprobacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuarioAprobador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipoSolicitu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposSolicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasAprobacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitud de Aprobación";
            // 
            // lueUsuario
            // 
            this.lueUsuario.Location = new System.Drawing.Point(222, 96);
            this.lueUsuario.Name = "lueUsuario";
            this.lueUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueUsuario.Properties.Appearance.Options.UseFont = true;
            this.lueUsuario.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueUsuario.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUsuario.Properties.DataSource = this.usuariosBindingSource;
            this.lueUsuario.Properties.DisplayMember = "nombre";
            this.lueUsuario.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueUsuario.Properties.ValueMember = "id";
            this.lueUsuario.Size = new System.Drawing.Size(352, 28);
            this.lueUsuario.TabIndex = 1;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dsAutorizacionesBindingSource;
            // 
            // dsAutorizacionesBindingSource
            // 
            this.dsAutorizacionesBindingSource.DataSource = this.dsAutorizaciones;
            this.dsAutorizacionesBindingSource.Position = 0;
            // 
            // dsAutorizaciones
            // 
            this.dsAutorizaciones.DataSetName = "dsAutorizaciones";
            this.dsAutorizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Usuario";
            this.gridColumn1.FieldName = "nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario Solicitante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario Aprobador:";
            // 
            // lueUsuarioAprobador
            // 
            this.lueUsuarioAprobador.Location = new System.Drawing.Point(222, 151);
            this.lueUsuarioAprobador.Name = "lueUsuarioAprobador";
            this.lueUsuarioAprobador.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueUsuarioAprobador.Properties.Appearance.Options.UseFont = true;
            this.lueUsuarioAprobador.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueUsuarioAprobador.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueUsuarioAprobador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUsuarioAprobador.Properties.DataSource = this.usuariosBindingSource;
            this.lueUsuarioAprobador.Properties.DisplayMember = "nombre";
            this.lueUsuarioAprobador.Properties.PopupView = this.gridView1;
            this.lueUsuarioAprobador.Properties.ValueMember = "id";
            this.lueUsuarioAprobador.Size = new System.Drawing.Size(352, 28);
            this.lueUsuarioAprobador.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Usuario";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Documento Solicitado:";
            // 
            // lueDocumento
            // 
            this.lueDocumento.Location = new System.Drawing.Point(222, 227);
            this.lueDocumento.Name = "lueDocumento";
            this.lueDocumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueDocumento.Properties.Appearance.Options.UseFont = true;
            this.lueDocumento.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueDocumento.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDocumento.Properties.PopupView = this.gridView2;
            this.lueDocumento.Size = new System.Drawing.Size(352, 28);
            this.lueDocumento.TabIndex = 5;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Usuario";
            this.gridColumn3.FieldName = "nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(222, 332);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(352, 96);
            this.txtComentario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comentario:";
            // 
            // lueTipoSolicitu
            // 
            this.lueTipoSolicitu.Location = new System.Drawing.Point(222, 282);
            this.lueTipoSolicitu.Name = "lueTipoSolicitu";
            this.lueTipoSolicitu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lueTipoSolicitu.Properties.Appearance.Options.UseFont = true;
            this.lueTipoSolicitu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTipoSolicitu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Tipo", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueTipoSolicitu.Properties.DataSource = this.tiposSolicitudBindingSource;
            this.lueTipoSolicitu.Properties.DisplayMember = "descripcion";
            this.lueTipoSolicitu.Properties.ValueMember = "id";
            this.lueTipoSolicitu.Size = new System.Drawing.Size(352, 28);
            this.lueTipoSolicitu.TabIndex = 9;
            // 
            // tiposSolicitudBindingSource
            // 
            this.tiposSolicitudBindingSource.DataMember = "Tipos Solicitud";
            this.tiposSolicitudBindingSource.DataSource = this.dsAutorizacionesBindingSource;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Solicitud:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ruta Aprobación:";
            // 
            // slueRuta
            // 
            this.slueRuta.EditValue = "";
            this.slueRuta.Location = new System.Drawing.Point(222, 482);
            this.slueRuta.Name = "slueRuta";
            this.slueRuta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueRuta.Properties.Appearance.Options.UseFont = true;
            this.slueRuta.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueRuta.Properties.AppearanceDropDown.Options.UseFont = true;
            this.slueRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueRuta.Properties.DataSource = this.rutasAprobacionBindingSource;
            this.slueRuta.Properties.DisplayMember = "descripcion";
            this.slueRuta.Properties.PopupView = this.gridView3;
            this.slueRuta.Properties.ValueMember = "id";
            this.slueRuta.Size = new System.Drawing.Size(352, 28);
            this.slueRuta.TabIndex = 11;
            // 
            // rutasAprobacionBindingSource
            // 
            this.rutasAprobacionBindingSource.DataMember = "Rutas Aprobacion";
            this.rutasAprobacionBindingSource.DataSource = this.dsAutorizacionesBindingSource;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Usuario";
            this.gridColumn4.FieldName = "nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(194, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 54);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(336, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 54);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSolicitudAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 606);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.slueRuta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lueTipoSolicitu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lueDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lueUsuarioAprobador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lueUsuario);
            this.Controls.Add(this.label1);
            this.Name = "frmSolicitudAutorizacion";
            this.Text = "Solicitud de Aprobacion";
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuarioAprobador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipoSolicitu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposSolicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasAprobacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit lueUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource dsAutorizacionesBindingSource;
        private dsAutorizaciones dsAutorizaciones;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit lueUsuarioAprobador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SearchLookUpEdit lueDocumento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.MemoEdit txtComentario;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lueTipoSolicitu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource tiposSolicitudBindingSource;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SearchLookUpEdit slueRuta;
        private System.Windows.Forms.BindingSource rutasAprobacionBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}