
namespace JAGUAR_APP.Facturacion.Cotizaciones
{
    partial class frmSearchCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCotizaciones));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject25 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject26 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject27 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject28 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject29 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject30 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject31 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject32 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions9 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject33 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject34 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject35 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject36 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdRefreshDisponibles = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaHastaDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesdeDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grdCotizaciones = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_emision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.reposEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.reposPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsFactCotizacion1 = new JAGUAR_APP.Facturacion.Cotizaciones.dsFactCotizacion();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactCotizacion1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRefreshDisponibles
            // 
            this.cmdRefreshDisponibles.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.cmdRefreshDisponibles.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdRefreshDisponibles.Appearance.Options.UseBackColor = true;
            this.cmdRefreshDisponibles.Appearance.Options.UseFont = true;
            this.cmdRefreshDisponibles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefreshDisponibles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefreshDisponibles.ImageOptions.Image")));
            this.cmdRefreshDisponibles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefreshDisponibles.Location = new System.Drawing.Point(523, 0);
            this.cmdRefreshDisponibles.Name = "cmdRefreshDisponibles";
            this.cmdRefreshDisponibles.Size = new System.Drawing.Size(106, 39);
            this.cmdRefreshDisponibles.TabIndex = 116;
            this.cmdRefreshDisponibles.Text = "Refresh";
            this.cmdRefreshDisponibles.Click += new System.EventHandler(this.cmdRefreshDisponibles_Click);
            // 
            // dtFechaHastaDisponibles
            // 
            this.dtFechaHastaDisponibles.EditValue = null;
            this.dtFechaHastaDisponibles.Location = new System.Drawing.Point(362, 9);
            this.dtFechaHastaDisponibles.Name = "dtFechaHastaDisponibles";
            this.dtFechaHastaDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaHastaDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHastaDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaHastaDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaHastaDisponibles.Size = new System.Drawing.Size(142, 22);
            this.dtFechaHastaDisponibles.TabIndex = 114;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(276, 13);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 16);
            this.labelControl9.TabIndex = 115;
            this.labelControl9.Text = "Fecha Hasta:";
            // 
            // dtFechaDesdeDisponibles
            // 
            this.dtFechaDesdeDisponibles.EditValue = null;
            this.dtFechaDesdeDisponibles.Location = new System.Drawing.Point(115, 9);
            this.dtFechaDesdeDisponibles.Name = "dtFechaDesdeDisponibles";
            this.dtFechaDesdeDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaDesdeDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesdeDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaDesdeDisponibles.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesdeDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaDesdeDisponibles.Size = new System.Drawing.Size(142, 22);
            this.dtFechaDesdeDisponibles.TabIndex = 112;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(24, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(85, 16);
            this.labelControl8.TabIndex = 113;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // grdCotizaciones
            // 
            this.grdCotizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCotizaciones.DataMember = "ListaCotizaciones";
            this.grdCotizaciones.DataSource = this.dsFactCotizacion1;
            this.grdCotizaciones.Location = new System.Drawing.Point(2, 56);
            this.grdCotizaciones.MainView = this.gridView1;
            this.grdCotizaciones.Name = "grdCotizaciones";
            this.grdCotizaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposEditar,
            this.reposEliminar,
            this.reposPrint});
            this.grdCotizaciones.Size = new System.Drawing.Size(1124, 351);
            this.grdCotizaciones.TabIndex = 117;
            this.grdCotizaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcliente,
            this.colrtn,
            this.colcontacto,
            this.coltelefono,
            this.colfecha_emision,
            this.colfecha_vencimiento,
            this.coluser_creador,
            this.colestado,
            this.coltotal,
            this.gridColumn4});
            this.gridView1.GridControl = this.grdCotizaciones;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid
            // 
            this.colid.Caption = "id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 53;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.AllowEdit = false;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 1;
            this.colcliente.Width = 98;
            // 
            // colrtn
            // 
            this.colrtn.Caption = "RTN";
            this.colrtn.FieldName = "rtn";
            this.colrtn.Name = "colrtn";
            this.colrtn.OptionsColumn.AllowEdit = false;
            this.colrtn.Visible = true;
            this.colrtn.VisibleIndex = 2;
            this.colrtn.Width = 98;
            // 
            // colcontacto
            // 
            this.colcontacto.Caption = "Contacto";
            this.colcontacto.FieldName = "contacto";
            this.colcontacto.Name = "colcontacto";
            this.colcontacto.OptionsColumn.AllowEdit = false;
            this.colcontacto.Visible = true;
            this.colcontacto.VisibleIndex = 3;
            this.colcontacto.Width = 98;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.AllowEdit = false;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 4;
            this.coltelefono.Width = 98;
            // 
            // colfecha_emision
            // 
            this.colfecha_emision.Caption = "Fecha";
            this.colfecha_emision.FieldName = "fecha_emision";
            this.colfecha_emision.Name = "colfecha_emision";
            this.colfecha_emision.OptionsColumn.AllowEdit = false;
            this.colfecha_emision.Visible = true;
            this.colfecha_emision.VisibleIndex = 5;
            this.colfecha_emision.Width = 98;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "F. Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 6;
            this.colfecha_vencimiento.Width = 98;
            // 
            // coluser_creador
            // 
            this.coluser_creador.Caption = "Usuario";
            this.coluser_creador.FieldName = "user_creador";
            this.coluser_creador.Name = "coluser_creador";
            this.coluser_creador.OptionsColumn.AllowEdit = false;
            this.coluser_creador.Visible = true;
            this.coluser_creador.VisibleIndex = 7;
            this.coluser_creador.Width = 98;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 8;
            this.colestado.Width = 98;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Monto Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 9;
            this.coltotal.Width = 98;
            // 
            // reposEditar
            // 
            this.reposEditar.AutoHeight = false;
            editorButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions7.Image")));
            this.reposEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions7, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject25, serializableAppearanceObject26, serializableAppearanceObject27, serializableAppearanceObject28, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEditar.Name = "reposEditar";
            this.reposEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // reposEliminar
            // 
            this.reposEliminar.AutoHeight = false;
            editorButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions8.Image")));
            this.reposEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions8, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject29, serializableAppearanceObject30, serializableAppearanceObject31, serializableAppearanceObject32, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEliminar.Name = "reposEliminar";
            this.reposEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // reposPrint
            // 
            this.reposPrint.AutoHeight = false;
            editorButtonImageOptions9.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions9.Image")));
            this.reposPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions9, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject33, serializableAppearanceObject34, serializableAppearanceObject35, serializableAppearanceObject36, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposPrint.Name = "reposPrint";
            this.reposPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "# Cotizacion";
            this.gridColumn4.FieldName = "num_cotizacion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 87;
            // 
            // dsFactCotizacion1
            // 
            this.dsFactCotizacion1.DataSetName = "dsFactCotizacion";
            this.dsFactCotizacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmSearchCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 408);
            this.Controls.Add(this.grdCotizaciones);
            this.Controls.Add(this.cmdRefreshDisponibles);
            this.Controls.Add(this.dtFechaHastaDisponibles);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaDesdeDisponibles);
            this.Controls.Add(this.labelControl8);
            this.Name = "frmSearchCotizaciones";
            this.Text = "Doble Click para seleccionar";
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactCotizacion1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdRefreshDisponibles;
        private DevExpress.XtraEditors.DateEdit dtFechaHastaDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaDesdeDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl grdCotizaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colrtn;
        private DevExpress.XtraGrid.Columns.GridColumn colcontacto;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_emision;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposPrint;
        private dsFactCotizacion dsFactCotizacion1;
    }
}