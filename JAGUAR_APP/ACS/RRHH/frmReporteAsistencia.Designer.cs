
namespace JAGUAR_APP.ACS.RRHH
{
    partial class frmReporteAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteAsistencia));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsRRHH_reportes1 = new JAGUAR_APP.ACS.RRHH.dsRRHH_reportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dt_final = new DevExpress.XtraEditors.DateEdit();
            this.dt_inicial = new DevExpress.XtraEditors.DateEdit();
            this.lblFechas = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnexport = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_martes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_martes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_miercoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_miercoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_jueves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_jueves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_viernes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_viernes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_sabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_sabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_domingo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_domingo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartOfWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndOfWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_emp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomingo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLunes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMartes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiercoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJueves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViernes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartOfWeek1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndOfWeek1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRRHH_reportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "resumen_asistencia";
            this.gridControl1.DataSource = this.dsRRHH_reportes1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1123, 397);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsRRHH_reportes1
            // 
            this.dsRRHH_reportes1.DataSetName = "dsRRHH_reportes";
            this.dsRRHH_reportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_emp,
            this.colcodigo,
            this.colnombre,
            this.colturno_id,
            this.colturno_name,
            this.colsemana,
            this.colentrada_1,
            this.colsalida_1,
            this.colentrada_martes,
            this.colsalida_martes,
            this.colentrada_miercoles,
            this.colsalida_miercoles,
            this.colentrada_jueves,
            this.colsalida_jueves,
            this.colentrada_viernes,
            this.colsalida_viernes,
            this.colentrada_sabado,
            this.colsalida_sabado,
            this.colentrada_domingo,
            this.colsalida_domingo,
            this.colStartOfWeek,
            this.colEndOfWeek,
            this.coldepartamento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // dt_final
            // 
            this.dt_final.EditValue = null;
            this.dt_final.Location = new System.Drawing.Point(119, 47);
            this.dt_final.Name = "dt_final";
            this.dt_final.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dt_final.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_final.Properties.Appearance.Options.UseFont = true;
            this.dt_final.Properties.Appearance.Options.UseForeColor = true;
            this.dt_final.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_final.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_final.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_final.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_final.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_final.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_final.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_final.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_final.Size = new System.Drawing.Size(212, 26);
            this.dt_final.TabIndex = 18;
            // 
            // dt_inicial
            // 
            this.dt_inicial.EditValue = null;
            this.dt_inicial.Location = new System.Drawing.Point(119, 19);
            this.dt_inicial.Name = "dt_inicial";
            this.dt_inicial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dt_inicial.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_inicial.Properties.Appearance.Options.UseFont = true;
            this.dt_inicial.Properties.Appearance.Options.UseForeColor = true;
            this.dt_inicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_inicial.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_inicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_inicial.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_inicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_inicial.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_inicial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_inicial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_inicial.Size = new System.Drawing.Size(212, 26);
            this.dt_inicial.TabIndex = 17;
            // 
            // lblFechas
            // 
            this.lblFechas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechas.Appearance.Options.UseFont = true;
            this.lblFechas.Location = new System.Drawing.Point(7, 25);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(123, 21);
            this.lblFechas.TabIndex = 14;
            this.lblFechas.Text = "Fecha Inicial_____";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 21);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Fecha Final_____";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(337, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 53);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Generar reporte";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnexport
            // 
            this.btnexport.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Appearance.Options.UseFont = true;
            this.btnexport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.ImageOptions.Image")));
            this.btnexport.Location = new System.Drawing.Point(486, 20);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(146, 53);
            this.btnexport.TabIndex = 19;
            this.btnexport.Text = "Exportar a excel";
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 90);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1129, 425);
            this.xtraTabControl1.TabIndex = 20;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1123, 397);
            this.xtraTabPage1.Text = "Asistencia Resumen con Hora";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1123, 397);
            this.xtraTabPage2.Text = "Marcas de Entrada por día";
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "resumen_asistenciaEntradas";
            this.gridControl2.DataSource = this.dsRRHH_reportes1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1123, 397);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_emp1,
            this.colcodigo1,
            this.colnombre1,
            this.colsemana1,
            this.colDomingo,
            this.colLunes,
            this.colMartes,
            this.colMiercoles,
            this.colJueves,
            this.colViernes,
            this.colSabado,
            this.colStartOfWeek1,
            this.colEndOfWeek1,
            this.coldepartamento1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // colid_emp
            // 
            this.colid_emp.FieldName = "id_emp";
            this.colid_emp.Name = "colid_emp";
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // colturno_id
            // 
            this.colturno_id.FieldName = "turno_id";
            this.colturno_id.Name = "colturno_id";
            this.colturno_id.OptionsColumn.AllowEdit = false;
            // 
            // colturno_name
            // 
            this.colturno_name.FieldName = "turno_name";
            this.colturno_name.Name = "colturno_name";
            this.colturno_name.OptionsColumn.AllowEdit = false;
            // 
            // colsemana
            // 
            this.colsemana.FieldName = "semana";
            this.colsemana.Name = "colsemana";
            this.colsemana.OptionsColumn.AllowEdit = false;
            this.colsemana.Visible = true;
            this.colsemana.VisibleIndex = 3;
            // 
            // colentrada_1
            // 
            this.colentrada_1.FieldName = "entrada_1";
            this.colentrada_1.Name = "colentrada_1";
            this.colentrada_1.OptionsColumn.AllowEdit = false;
            this.colentrada_1.Visible = true;
            this.colentrada_1.VisibleIndex = 8;
            // 
            // colsalida_1
            // 
            this.colsalida_1.FieldName = "salida_1";
            this.colsalida_1.Name = "colsalida_1";
            this.colsalida_1.OptionsColumn.AllowEdit = false;
            this.colsalida_1.Visible = true;
            this.colsalida_1.VisibleIndex = 9;
            // 
            // colentrada_martes
            // 
            this.colentrada_martes.FieldName = "entrada_martes";
            this.colentrada_martes.Name = "colentrada_martes";
            this.colentrada_martes.OptionsColumn.AllowEdit = false;
            this.colentrada_martes.Visible = true;
            this.colentrada_martes.VisibleIndex = 10;
            // 
            // colsalida_martes
            // 
            this.colsalida_martes.FieldName = "salida_martes";
            this.colsalida_martes.Name = "colsalida_martes";
            this.colsalida_martes.OptionsColumn.AllowEdit = false;
            this.colsalida_martes.Visible = true;
            this.colsalida_martes.VisibleIndex = 11;
            // 
            // colentrada_miercoles
            // 
            this.colentrada_miercoles.FieldName = "entrada_miercoles";
            this.colentrada_miercoles.Name = "colentrada_miercoles";
            this.colentrada_miercoles.OptionsColumn.AllowEdit = false;
            this.colentrada_miercoles.Visible = true;
            this.colentrada_miercoles.VisibleIndex = 12;
            // 
            // colsalida_miercoles
            // 
            this.colsalida_miercoles.FieldName = "salida_miercoles";
            this.colsalida_miercoles.Name = "colsalida_miercoles";
            this.colsalida_miercoles.OptionsColumn.AllowEdit = false;
            this.colsalida_miercoles.Visible = true;
            this.colsalida_miercoles.VisibleIndex = 13;
            // 
            // colentrada_jueves
            // 
            this.colentrada_jueves.FieldName = "entrada_jueves";
            this.colentrada_jueves.Name = "colentrada_jueves";
            this.colentrada_jueves.OptionsColumn.AllowEdit = false;
            this.colentrada_jueves.Visible = true;
            this.colentrada_jueves.VisibleIndex = 14;
            // 
            // colsalida_jueves
            // 
            this.colsalida_jueves.FieldName = "salida_jueves";
            this.colsalida_jueves.Name = "colsalida_jueves";
            this.colsalida_jueves.OptionsColumn.AllowEdit = false;
            this.colsalida_jueves.Visible = true;
            this.colsalida_jueves.VisibleIndex = 15;
            // 
            // colentrada_viernes
            // 
            this.colentrada_viernes.FieldName = "entrada_viernes";
            this.colentrada_viernes.Name = "colentrada_viernes";
            this.colentrada_viernes.OptionsColumn.AllowEdit = false;
            this.colentrada_viernes.Visible = true;
            this.colentrada_viernes.VisibleIndex = 16;
            // 
            // colsalida_viernes
            // 
            this.colsalida_viernes.FieldName = "salida_viernes";
            this.colsalida_viernes.Name = "colsalida_viernes";
            this.colsalida_viernes.OptionsColumn.AllowEdit = false;
            this.colsalida_viernes.Visible = true;
            this.colsalida_viernes.VisibleIndex = 17;
            // 
            // colentrada_sabado
            // 
            this.colentrada_sabado.FieldName = "entrada_sabado";
            this.colentrada_sabado.Name = "colentrada_sabado";
            this.colentrada_sabado.OptionsColumn.AllowEdit = false;
            this.colentrada_sabado.Visible = true;
            this.colentrada_sabado.VisibleIndex = 18;
            // 
            // colsalida_sabado
            // 
            this.colsalida_sabado.FieldName = "salida_sabado";
            this.colsalida_sabado.Name = "colsalida_sabado";
            this.colsalida_sabado.OptionsColumn.AllowEdit = false;
            this.colsalida_sabado.Visible = true;
            this.colsalida_sabado.VisibleIndex = 19;
            // 
            // colentrada_domingo
            // 
            this.colentrada_domingo.FieldName = "entrada_domingo";
            this.colentrada_domingo.Name = "colentrada_domingo";
            this.colentrada_domingo.OptionsColumn.AllowEdit = false;
            this.colentrada_domingo.Visible = true;
            this.colentrada_domingo.VisibleIndex = 6;
            // 
            // colsalida_domingo
            // 
            this.colsalida_domingo.FieldName = "salida_domingo";
            this.colsalida_domingo.Name = "colsalida_domingo";
            this.colsalida_domingo.OptionsColumn.AllowEdit = false;
            this.colsalida_domingo.Visible = true;
            this.colsalida_domingo.VisibleIndex = 7;
            // 
            // colStartOfWeek
            // 
            this.colStartOfWeek.FieldName = "StartOfWeek";
            this.colStartOfWeek.Name = "colStartOfWeek";
            this.colStartOfWeek.OptionsColumn.AllowEdit = false;
            this.colStartOfWeek.Visible = true;
            this.colStartOfWeek.VisibleIndex = 4;
            // 
            // colEndOfWeek
            // 
            this.colEndOfWeek.FieldName = "EndOfWeek";
            this.colEndOfWeek.Name = "colEndOfWeek";
            this.colEndOfWeek.OptionsColumn.AllowEdit = false;
            this.colEndOfWeek.Visible = true;
            this.colEndOfWeek.VisibleIndex = 5;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Turno";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.AllowEdit = false;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 2;
            // 
            // colid_emp1
            // 
            this.colid_emp1.FieldName = "id_emp";
            this.colid_emp1.Name = "colid_emp1";
            // 
            // colcodigo1
            // 
            this.colcodigo1.FieldName = "codigo";
            this.colcodigo1.Name = "colcodigo1";
            this.colcodigo1.OptionsColumn.AllowEdit = false;
            this.colcodigo1.Visible = true;
            this.colcodigo1.VisibleIndex = 0;
            this.colcodigo1.Width = 47;
            // 
            // colnombre1
            // 
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.OptionsColumn.AllowEdit = false;
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 1;
            this.colnombre1.Width = 142;
            // 
            // colsemana1
            // 
            this.colsemana1.FieldName = "semana";
            this.colsemana1.Name = "colsemana1";
            this.colsemana1.OptionsColumn.AllowEdit = false;
            this.colsemana1.Visible = true;
            this.colsemana1.VisibleIndex = 3;
            this.colsemana1.Width = 57;
            // 
            // colDomingo
            // 
            this.colDomingo.AppearanceCell.Options.UseTextOptions = true;
            this.colDomingo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDomingo.FieldName = "Domingo";
            this.colDomingo.Name = "colDomingo";
            this.colDomingo.OptionsColumn.AllowEdit = false;
            this.colDomingo.Visible = true;
            this.colDomingo.VisibleIndex = 6;
            this.colDomingo.Width = 82;
            // 
            // colLunes
            // 
            this.colLunes.AppearanceCell.Options.UseTextOptions = true;
            this.colLunes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLunes.FieldName = "Lunes";
            this.colLunes.Name = "colLunes";
            this.colLunes.OptionsColumn.AllowEdit = false;
            this.colLunes.Visible = true;
            this.colLunes.VisibleIndex = 7;
            this.colLunes.Width = 82;
            // 
            // colMartes
            // 
            this.colMartes.AppearanceCell.Options.UseTextOptions = true;
            this.colMartes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMartes.FieldName = "Martes";
            this.colMartes.Name = "colMartes";
            this.colMartes.OptionsColumn.AllowEdit = false;
            this.colMartes.Visible = true;
            this.colMartes.VisibleIndex = 8;
            this.colMartes.Width = 82;
            // 
            // colMiercoles
            // 
            this.colMiercoles.AppearanceCell.Options.UseTextOptions = true;
            this.colMiercoles.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMiercoles.FieldName = "Miercoles";
            this.colMiercoles.Name = "colMiercoles";
            this.colMiercoles.OptionsColumn.AllowEdit = false;
            this.colMiercoles.Visible = true;
            this.colMiercoles.VisibleIndex = 9;
            this.colMiercoles.Width = 82;
            // 
            // colJueves
            // 
            this.colJueves.AppearanceCell.Options.UseTextOptions = true;
            this.colJueves.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJueves.FieldName = "Jueves";
            this.colJueves.Name = "colJueves";
            this.colJueves.OptionsColumn.AllowEdit = false;
            this.colJueves.Visible = true;
            this.colJueves.VisibleIndex = 10;
            this.colJueves.Width = 82;
            // 
            // colViernes
            // 
            this.colViernes.AppearanceCell.Options.UseTextOptions = true;
            this.colViernes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colViernes.FieldName = "Viernes";
            this.colViernes.Name = "colViernes";
            this.colViernes.OptionsColumn.AllowEdit = false;
            this.colViernes.Visible = true;
            this.colViernes.VisibleIndex = 11;
            this.colViernes.Width = 82;
            // 
            // colSabado
            // 
            this.colSabado.AppearanceCell.Options.UseTextOptions = true;
            this.colSabado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSabado.FieldName = "Sabado";
            this.colSabado.Name = "colSabado";
            this.colSabado.OptionsColumn.AllowEdit = false;
            this.colSabado.Visible = true;
            this.colSabado.VisibleIndex = 12;
            this.colSabado.Width = 121;
            // 
            // colStartOfWeek1
            // 
            this.colStartOfWeek1.FieldName = "StartOfWeek";
            this.colStartOfWeek1.Name = "colStartOfWeek1";
            this.colStartOfWeek1.OptionsColumn.AllowEdit = false;
            this.colStartOfWeek1.Visible = true;
            this.colStartOfWeek1.VisibleIndex = 4;
            this.colStartOfWeek1.Width = 82;
            // 
            // colEndOfWeek1
            // 
            this.colEndOfWeek1.FieldName = "EndOfWeek";
            this.colEndOfWeek1.Name = "colEndOfWeek1";
            this.colEndOfWeek1.OptionsColumn.AllowEdit = false;
            this.colEndOfWeek1.Visible = true;
            this.colEndOfWeek1.VisibleIndex = 5;
            this.colEndOfWeek1.Width = 82;
            // 
            // coldepartamento1
            // 
            this.coldepartamento1.Caption = "Turno";
            this.coldepartamento1.FieldName = "departamento";
            this.coldepartamento1.Name = "coldepartamento1";
            this.coldepartamento1.OptionsColumn.AllowEdit = false;
            this.coldepartamento1.Visible = true;
            this.coldepartamento1.VisibleIndex = 2;
            this.coldepartamento1.Width = 82;
            // 
            // frmReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 514);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.dt_final);
            this.Controls.Add(this.dt_inicial);
            this.Controls.Add(this.lblFechas);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmReporteAsistencia";
            this.Text = "Resumen Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRRHH_reportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsRRHH_reportes dsRRHH_reportes1;
        private DevExpress.XtraEditors.DateEdit dt_final;
        private DevExpress.XtraEditors.DateEdit dt_inicial;
        private DevExpress.XtraEditors.LabelControl lblFechas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnexport;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid_emp;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colturno_id;
        private DevExpress.XtraGrid.Columns.GridColumn colturno_name;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_1;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_1;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_martes;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_martes;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_miercoles;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_miercoles;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_jueves;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_jueves;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_viernes;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_viernes;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_sabado;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_sabado;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_domingo;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_domingo;
        private DevExpress.XtraGrid.Columns.GridColumn colStartOfWeek;
        private DevExpress.XtraGrid.Columns.GridColumn colEndOfWeek;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_emp1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana1;
        private DevExpress.XtraGrid.Columns.GridColumn colDomingo;
        private DevExpress.XtraGrid.Columns.GridColumn colLunes;
        private DevExpress.XtraGrid.Columns.GridColumn colMartes;
        private DevExpress.XtraGrid.Columns.GridColumn colMiercoles;
        private DevExpress.XtraGrid.Columns.GridColumn colJueves;
        private DevExpress.XtraGrid.Columns.GridColumn colViernes;
        private DevExpress.XtraGrid.Columns.GridColumn colSabado;
        private DevExpress.XtraGrid.Columns.GridColumn colStartOfWeek1;
        private DevExpress.XtraGrid.Columns.GridColumn colEndOfWeek1;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento1;
    }
}