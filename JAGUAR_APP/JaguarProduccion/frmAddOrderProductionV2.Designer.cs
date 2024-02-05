
namespace JAGUAR_APP.JaguarProduccion
{
    partial class frmAddOrderProductionV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrderProductionV2));
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
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceRecetas = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogisticaJaguar1 = new JAGUAR_APP.LogisticaJaguar.dsLogisticaJaguar();
            this.bindingSourcePT = new System.Windows.Forms.BindingSource(this.components);
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.dsPedidosPRD1 = new JAGUAR_APP.LogisticaJaguar.Pedidos.dsPedidosPRD();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridLookUpEdit_PT = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpt_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookupEditPresentacionPT = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_arrobas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_latas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_a_producir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_arrobas_asignadas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_medida_a_produccir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAsignarArrobas = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RGridLookUpE_UdMedidaFactura = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RGridLookUpE_MateriaPrimaList = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.R_GridLookUpEdit_Ud_medida_Jaguar = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridLookUpE_Bodega = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ver_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerPage2 = new DevExpress.XtraEditors.SimpleButton();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsProduccion1 = new JAGUAR_APP.JaguarProduccion.dsProduccion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_panadero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpanadero_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_arrobas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmd_eliminar_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btx_eliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdVerPage1 = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblCompletado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosPRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookupEditPresentacionPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarArrobas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGridLookUpE_UdMedidaFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGridLookUpE_MateriaPrimaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_GridLookUpEdit_Ud_medida_Jaguar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpE_Bodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btx_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(818, 3);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(108, 42);
            this.cmdCerrar.TabIndex = 56;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.ToolTipTitle = "Guardar Entrada de Factura";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // bindingSourceRecetas
            // 
            this.bindingSourceRecetas.DataMember = "Productos_terminados_Recetas";
            this.bindingSourceRecetas.DataSource = this.dsLogisticaJaguar1;
            // 
            // dsLogisticaJaguar1
            // 
            this.dsLogisticaJaguar1.DataSetName = "dsLogisticaJaguar";
            this.dsLogisticaJaguar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourcePT
            // 
            this.bindingSourcePT.DataMember = "Productos_terminados_list";
            this.bindingSourcePT.DataSource = this.dsLogisticaJaguar1;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(2, 3);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 42);
            this.cmdGuardar.TabIndex = 55;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.ToolTipTitle = "Guardar Entrada de Factura";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(1016, 66);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(34, 26);
            this.simpleButton1.TabIndex = 60;
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Location = new System.Drawing.Point(2, 49);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(924, 500);
            this.navigationFrame1.TabIndex = 62;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.gridControl2);
            this.navigationPage1.Controls.Add(this.gridControl3);
            this.navigationPage1.Controls.Add(this.cmdVerPage2);
            this.navigationPage1.Controls.Add(this.dtHasta);
            this.navigationPage1.Controls.Add(this.dtDesde);
            this.navigationPage1.Controls.Add(this.CargarDatos);
            this.navigationPage1.Controls.Add(this.labelControl3);
            this.navigationPage1.Controls.Add(this.labelControl5);
            this.navigationPage1.Controls.Add(this.labelControl6);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(924, 500);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "detalle_pedido";
            this.gridControl2.DataSource = this.dsPedidosPRD1;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl2.Location = new System.Drawing.Point(8, 248);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RGridLookUpE_UdMedidaFactura,
            this.RGridLookUpE_MateriaPrimaList,
            this.R_GridLookUpEdit_Ud_medida_Jaguar,
            this.GridLookUpE_Bodega,
            this.cmdEliminar,
            this.gridLookupEditPresentacionPT,
            this.GridLookUpEdit_PT,
            this.cmdAsignarArrobas});
            this.gridControl2.Size = new System.Drawing.Size(914, 249);
            this.gridControl2.TabIndex = 59;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsPedidosPRD1
            // 
            this.dsPedidosPRD1.DataSetName = "DataSet1";
            this.dsPedidosPRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colid_pt,
            this.colpt_name,
            this.gridColumn2,
            this.colenable,
            this.colid_h,
            this.gridColumn3,
            this.colpresentacion_name,
            this.colcant_arrobas,
            this.gridColumn5,
            this.colcant_latas,
            this.colcant_inv,
            this.colcant_pedido,
            this.gridColumn6,
            this.colcant_a_producir,
            this.colcant_arrobas_asignadas,
            this.colud_medida_a_produccir,
            this.gridColumn11});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.LevelIndent = 0;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.PreviewIndent = 0;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.MinWidth = 19;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 74;
            // 
            // colid_pt
            // 
            this.colid_pt.Caption = "ItemName";
            this.colid_pt.ColumnEdit = this.GridLookUpEdit_PT;
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.MinWidth = 19;
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.Width = 106;
            // 
            // GridLookUpEdit_PT
            // 
            this.GridLookUpEdit_PT.AutoHeight = false;
            this.GridLookUpEdit_PT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEdit_PT.DisplayMember = "descripcion";
            this.GridLookUpEdit_PT.Name = "GridLookUpEdit_PT";
            this.GridLookUpEdit_PT.PopupView = this.gridView6;
            this.GridLookUpEdit_PT.ValueMember = "id";
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid6,
            this.coldescripcion5});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.LevelIndent = 0;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.PreviewIndent = 0;
            // 
            // colid6
            // 
            this.colid6.FieldName = "id";
            this.colid6.MinWidth = 19;
            this.colid6.Name = "colid6";
            this.colid6.Width = 74;
            // 
            // coldescripcion5
            // 
            this.coldescripcion5.Caption = "Descripción";
            this.coldescripcion5.FieldName = "descripcion";
            this.coldescripcion5.MinWidth = 19;
            this.coldescripcion5.Name = "coldescripcion5";
            this.coldescripcion5.Visible = true;
            this.coldescripcion5.VisibleIndex = 0;
            this.coldescripcion5.Width = 74;
            // 
            // colpt_name
            // 
            this.colpt_name.FieldName = "pt_name";
            this.colpt_name.MinWidth = 19;
            this.colpt_name.Name = "colpt_name";
            this.colpt_name.OptionsColumn.ReadOnly = true;
            this.colpt_name.Visible = true;
            this.colpt_name.VisibleIndex = 1;
            this.colpt_name.Width = 151;
            // 
            // gridColumn2
            // 
            this.gridColumn2.DisplayFormat.FormatString = "n4";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "cantidad";
            this.gridColumn2.MinWidth = 19;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 77;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.MinWidth = 19;
            this.colenable.Name = "colenable";
            this.colenable.Width = 74;
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.MinWidth = 19;
            this.colid_h.Name = "colid_h";
            this.colid_h.Width = 74;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Presentación";
            this.gridColumn3.ColumnEdit = this.gridLookupEditPresentacionPT;
            this.gridColumn3.FieldName = "id_presentacion";
            this.gridColumn3.MinWidth = 19;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 109;
            // 
            // gridLookupEditPresentacionPT
            // 
            this.gridLookupEditPresentacionPT.AutoHeight = false;
            this.gridLookupEditPresentacionPT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookupEditPresentacionPT.DisplayMember = "descripcion";
            this.gridLookupEditPresentacionPT.Name = "gridLookupEditPresentacionPT";
            this.gridLookupEditPresentacionPT.PopupView = this.gridView3;
            this.gridLookupEditPresentacionPT.ValueMember = "id";
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid5,
            this.gridColumn4});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.LevelIndent = 0;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.PreviewIndent = 0;
            // 
            // colid5
            // 
            this.colid5.FieldName = "id";
            this.colid5.MinWidth = 19;
            this.colid5.Name = "colid5";
            this.colid5.Width = 74;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "descripcion";
            this.gridColumn4.MinWidth = 19;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 74;
            // 
            // colpresentacion_name
            // 
            this.colpresentacion_name.FieldName = "presentacion_name";
            this.colpresentacion_name.MinWidth = 19;
            this.colpresentacion_name.Name = "colpresentacion_name";
            this.colpresentacion_name.OptionsColumn.ReadOnly = true;
            this.colpresentacion_name.Visible = true;
            this.colpresentacion_name.VisibleIndex = 2;
            this.colpresentacion_name.Width = 134;
            // 
            // colcant_arrobas
            // 
            this.colcant_arrobas.Caption = "Cantidad a Producir";
            this.colcant_arrobas.DisplayFormat.FormatString = "n4";
            this.colcant_arrobas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_arrobas.FieldName = "cant_arrobas";
            this.colcant_arrobas.MinWidth = 19;
            this.colcant_arrobas.Name = "colcant_arrobas";
            this.colcant_arrobas.Visible = true;
            this.colcant_arrobas.VisibleIndex = 5;
            this.colcant_arrobas.Width = 79;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "ItemCode";
            this.gridColumn5.MinWidth = 19;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Width = 74;
            // 
            // colcant_latas
            // 
            this.colcant_latas.Caption = "Cant Latas";
            this.colcant_latas.DisplayFormat.FormatString = "n4";
            this.colcant_latas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_latas.FieldName = "cant_latas";
            this.colcant_latas.MinWidth = 19;
            this.colcant_latas.Name = "colcant_latas";
            this.colcant_latas.OptionsColumn.ReadOnly = true;
            this.colcant_latas.Visible = true;
            this.colcant_latas.VisibleIndex = 8;
            this.colcant_latas.Width = 61;
            // 
            // colcant_inv
            // 
            this.colcant_inv.Caption = "Cant. Inventario";
            this.colcant_inv.DisplayFormat.FormatString = "n4";
            this.colcant_inv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_inv.FieldName = "cant_inv";
            this.colcant_inv.MinWidth = 19;
            this.colcant_inv.Name = "colcant_inv";
            this.colcant_inv.OptionsColumn.ReadOnly = true;
            this.colcant_inv.Visible = true;
            this.colcant_inv.VisibleIndex = 4;
            this.colcant_inv.Width = 61;
            // 
            // colcant_pedido
            // 
            this.colcant_pedido.Caption = "Cant. Pedido";
            this.colcant_pedido.DisplayFormat.FormatString = "n4";
            this.colcant_pedido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_pedido.FieldName = "cant_pedido";
            this.colcant_pedido.MinWidth = 19;
            this.colcant_pedido.Name = "colcant_pedido";
            this.colcant_pedido.Visible = true;
            this.colcant_pedido.VisibleIndex = 3;
            this.colcant_pedido.Width = 61;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "# Linea";
            this.gridColumn6.FieldName = "num_linea";
            this.gridColumn6.MinWidth = 19;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 42;
            // 
            // colcant_a_producir
            // 
            this.colcant_a_producir.FieldName = "cant_a_producir";
            this.colcant_a_producir.MinWidth = 19;
            this.colcant_a_producir.Name = "colcant_a_producir";
            this.colcant_a_producir.Width = 98;
            // 
            // colcant_arrobas_asignadas
            // 
            this.colcant_arrobas_asignadas.DisplayFormat.FormatString = "n4";
            this.colcant_arrobas_asignadas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_arrobas_asignadas.FieldName = "cant_arrobas_asignadas";
            this.colcant_arrobas_asignadas.MinWidth = 19;
            this.colcant_arrobas_asignadas.Name = "colcant_arrobas_asignadas";
            this.colcant_arrobas_asignadas.OptionsColumn.ReadOnly = true;
            this.colcant_arrobas_asignadas.Visible = true;
            this.colcant_arrobas_asignadas.VisibleIndex = 7;
            this.colcant_arrobas_asignadas.Width = 118;
            // 
            // colud_medida_a_produccir
            // 
            this.colud_medida_a_produccir.FieldName = "ud_medida_a_produccir";
            this.colud_medida_a_produccir.MinWidth = 19;
            this.colud_medida_a_produccir.Name = "colud_medida_a_produccir";
            this.colud_medida_a_produccir.OptionsColumn.ReadOnly = true;
            this.colud_medida_a_produccir.Visible = true;
            this.colud_medida_a_produccir.VisibleIndex = 6;
            this.colud_medida_a_produccir.Width = 73;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Asignar";
            this.gridColumn11.ColumnEdit = this.cmdAsignarArrobas;
            this.gridColumn11.MinWidth = 19;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            this.gridColumn11.Width = 71;
            // 
            // cmdAsignarArrobas
            // 
            this.cmdAsignarArrobas.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdAsignarArrobas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAsignarArrobas.Name = "cmdAsignarArrobas";
            this.cmdAsignarArrobas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAsignarArrobas.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdAsignarArrobas_ButtonClick);
            // 
            // RGridLookUpE_UdMedidaFactura
            // 
            this.RGridLookUpE_UdMedidaFactura.AutoHeight = false;
            this.RGridLookUpE_UdMedidaFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RGridLookUpE_UdMedidaFactura.DisplayMember = "descripcion";
            this.RGridLookUpE_UdMedidaFactura.Name = "RGridLookUpE_UdMedidaFactura";
            this.RGridLookUpE_UdMedidaFactura.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.RGridLookUpE_UdMedidaFactura.ValueMember = "id";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.coldescripcion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.LevelIndent = 0;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 685;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.PreviewIndent = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "id";
            this.gridColumn7.MinWidth = 19;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 74;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.MinWidth = 19;
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 74;
            // 
            // RGridLookUpE_MateriaPrimaList
            // 
            this.RGridLookUpE_MateriaPrimaList.AutoHeight = false;
            this.RGridLookUpE_MateriaPrimaList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RGridLookUpE_MateriaPrimaList.DisplayMember = "descripcion";
            this.RGridLookUpE_MateriaPrimaList.Name = "RGridLookUpE_MateriaPrimaList";
            this.RGridLookUpE_MateriaPrimaList.PopupView = this.gridView4;
            this.RGridLookUpE_MateriaPrimaList.ValueMember = "id";
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.coldescripcion2});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.LevelIndent = 0;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.PreviewIndent = 0;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.MinWidth = 19;
            this.colid2.Name = "colid2";
            this.colid2.Width = 74;
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.Caption = "Descripción";
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.MinWidth = 19;
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.OptionsColumn.ReadOnly = true;
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 0;
            this.coldescripcion2.Width = 74;
            // 
            // R_GridLookUpEdit_Ud_medida_Jaguar
            // 
            this.R_GridLookUpEdit_Ud_medida_Jaguar.AutoHeight = false;
            this.R_GridLookUpEdit_Ud_medida_Jaguar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.R_GridLookUpEdit_Ud_medida_Jaguar.DisplayMember = "descripcion";
            this.R_GridLookUpEdit_Ud_medida_Jaguar.Name = "R_GridLookUpEdit_Ud_medida_Jaguar";
            this.R_GridLookUpEdit_Ud_medida_Jaguar.PopupView = this.gridView5;
            this.R_GridLookUpEdit_Ud_medida_Jaguar.ValueMember = "id";
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.coldescripcion3});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.LevelIndent = 0;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.PreviewIndent = 0;
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.MinWidth = 19;
            this.colid3.Name = "colid3";
            this.colid3.Width = 74;
            // 
            // coldescripcion3
            // 
            this.coldescripcion3.Caption = "Descripción";
            this.coldescripcion3.FieldName = "descripcion";
            this.coldescripcion3.MinWidth = 19;
            this.coldescripcion3.Name = "coldescripcion3";
            this.coldescripcion3.OptionsColumn.ReadOnly = true;
            this.coldescripcion3.Visible = true;
            this.coldescripcion3.VisibleIndex = 0;
            this.coldescripcion3.Width = 74;
            // 
            // GridLookUpE_Bodega
            // 
            this.GridLookUpE_Bodega.AutoHeight = false;
            this.GridLookUpE_Bodega.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpE_Bodega.DisplayMember = "descripcion";
            this.GridLookUpE_Bodega.Name = "GridLookUpE_Bodega";
            this.GridLookUpE_Bodega.PopupView = this.gridView7;
            this.GridLookUpE_Bodega.ValueMember = "id";
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid4,
            this.coldescripcion4});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.LevelIndent = 0;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            this.gridView7.PreviewIndent = 0;
            // 
            // colid4
            // 
            this.colid4.FieldName = "id";
            this.colid4.MinWidth = 19;
            this.colid4.Name = "colid4";
            this.colid4.Width = 74;
            // 
            // coldescripcion4
            // 
            this.coldescripcion4.Caption = "Descripción";
            this.coldescripcion4.FieldName = "descripcion";
            this.coldescripcion4.MinWidth = 19;
            this.coldescripcion4.Name = "coldescripcion4";
            this.coldescripcion4.OptionsColumn.ReadOnly = true;
            this.coldescripcion4.Visible = true;
            this.coldescripcion4.VisibleIndex = 0;
            this.coldescripcion4.Width = 74;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.AutoHeight = false;
            this.cmdEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataMember = "lista_pedidos";
            this.gridControl3.DataSource = this.dsPedidosPRD1;
            this.gridControl3.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl3.Location = new System.Drawing.Point(8, 49);
            this.gridControl3.MainView = this.gridView8;
            this.gridControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(914, 196);
            this.gridControl3.TabIndex = 60;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView8});
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.colfecha,
            this.colfecha_row,
            this.colid_user,
            this.gridColumn9,
            this.colcomentario,
            this.colDocNum,
            this.coluser_name,
            this.colRowN,
            this.col_ver_detalle,
            this.gridColumn10,
            this.colestado_name});
            this.gridView8.GridControl = this.gridControl3;
            this.gridView8.LevelIndent = 0;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView8.OptionsView.ShowAutoFilterRow = true;
            this.gridView8.PreviewIndent = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "id";
            this.gridColumn8.MinWidth = 19;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Width = 74;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 19;
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            this.colfecha.Width = 77;
            // 
            // colfecha_row
            // 
            this.colfecha_row.FieldName = "fecha_row";
            this.colfecha_row.MinWidth = 19;
            this.colfecha_row.Name = "colfecha_row";
            this.colfecha_row.OptionsColumn.ReadOnly = true;
            this.colfecha_row.Width = 74;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.MinWidth = 19;
            this.colid_user.Name = "colid_user";
            this.colid_user.OptionsColumn.ReadOnly = true;
            this.colid_user.Width = 74;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "enable";
            this.gridColumn9.MinWidth = 19;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Width = 74;
            // 
            // colcomentario
            // 
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.MinWidth = 19;
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.ReadOnly = true;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 6;
            this.colcomentario.Width = 377;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.MinWidth = 19;
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 1;
            this.colDocNum.Width = 60;
            // 
            // coluser_name
            // 
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 19;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.ReadOnly = true;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 4;
            this.coluser_name.Width = 113;
            // 
            // colRowN
            // 
            this.colRowN.FieldName = "RowN";
            this.colRowN.MinWidth = 19;
            this.colRowN.Name = "colRowN";
            this.colRowN.OptionsColumn.ReadOnly = true;
            this.colRowN.Visible = true;
            this.colRowN.VisibleIndex = 0;
            this.colRowN.Width = 36;
            // 
            // col_ver_detalle
            // 
            this.col_ver_detalle.Caption = "Ver Detalle";
            this.col_ver_detalle.MinWidth = 19;
            this.col_ver_detalle.Name = "col_ver_detalle";
            this.col_ver_detalle.OptionsColumn.ReadOnly = true;
            this.col_ver_detalle.Width = 82;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Cliente";
            this.gridColumn10.FieldName = "cliente";
            this.gridColumn10.MinWidth = 19;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 156;
            // 
            // colestado_name
            // 
            this.colestado_name.FieldName = "estado_name";
            this.colestado_name.MinWidth = 19;
            this.colestado_name.Name = "colestado_name";
            this.colestado_name.OptionsColumn.ReadOnly = true;
            this.colestado_name.Visible = true;
            this.colestado_name.VisibleIndex = 5;
            this.colestado_name.Width = 74;
            // 
            // cmdVerPage2
            // 
            this.cmdVerPage2.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdVerPage2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerPage2.Appearance.Options.UseBackColor = true;
            this.cmdVerPage2.Appearance.Options.UseFont = true;
            this.cmdVerPage2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdVerPage2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdVerPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdVerPage2.ImageOptions.SvgImage")));
            this.cmdVerPage2.Location = new System.Drawing.Point(104, 6);
            this.cmdVerPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdVerPage2.Name = "cmdVerPage2";
            this.cmdVerPage2.Size = new System.Drawing.Size(143, 34);
            this.cmdVerPage2.TabIndex = 68;
            this.cmdVerPage2.Text = "Ver Asignaciones";
            this.cmdVerPage2.ToolTipTitle = "Ver Asignaciones";
            this.cmdVerPage2.Click += new System.EventHandler(this.cmdVerPage2_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(566, 16);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 66;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(350, 16);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 65;
            // 
            // CargarDatos
            // 
            this.CargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarDatos.Appearance.Options.UseFont = true;
            this.CargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.ImageOptions.Image")));
            this.CargarDatos.Location = new System.Drawing.Point(701, 3);
            this.CargarDatos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 39);
            this.CargarDatos.TabIndex = 63;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(488, 21);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Fecha Hasta:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(266, 21);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(8, 6);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 34);
            this.labelControl6.TabIndex = 67;
            this.labelControl6.Text = "Pedidos";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.gridControl1);
            this.navigationPage2.Controls.Add(this.cmdVerPage1);
            this.navigationPage2.Controls.Add(this.simpleButton1);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(924, 500);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Distribucion_ordenes_panaderos";
            this.gridControl1.DataSource = this.dsProduccion1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl1.Location = new System.Drawing.Point(8, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btx_eliminar});
            this.gridControl1.Size = new System.Drawing.Size(908, 495);
            this.gridControl1.TabIndex = 70;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.colnombre_pt,
            this.colid_presentacion,
            this.colpresentacion_name1,
            this.colid_panadero,
            this.colpanadero_name,
            this.colcantidad_arrobas,
            this.cmd_eliminar_row});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 685;
            this.gridView1.PreviewIndent = 0;
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.MinWidth = 19;
            this.colid_pt1.Name = "colid_pt1";
            this.colid_pt1.OptionsColumn.ReadOnly = true;
            this.colid_pt1.Width = 74;
            // 
            // colnombre_pt
            // 
            this.colnombre_pt.FieldName = "nombre_pt";
            this.colnombre_pt.MinWidth = 19;
            this.colnombre_pt.Name = "colnombre_pt";
            this.colnombre_pt.OptionsColumn.ReadOnly = true;
            this.colnombre_pt.Visible = true;
            this.colnombre_pt.VisibleIndex = 0;
            this.colnombre_pt.Width = 233;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.MinWidth = 19;
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.OptionsColumn.ReadOnly = true;
            this.colid_presentacion.Width = 74;
            // 
            // colpresentacion_name1
            // 
            this.colpresentacion_name1.FieldName = "presentacion_name";
            this.colpresentacion_name1.MinWidth = 19;
            this.colpresentacion_name1.Name = "colpresentacion_name1";
            this.colpresentacion_name1.OptionsColumn.ReadOnly = true;
            this.colpresentacion_name1.Visible = true;
            this.colpresentacion_name1.VisibleIndex = 1;
            this.colpresentacion_name1.Width = 157;
            // 
            // colid_panadero
            // 
            this.colid_panadero.FieldName = "id_panadero";
            this.colid_panadero.MinWidth = 19;
            this.colid_panadero.Name = "colid_panadero";
            this.colid_panadero.OptionsColumn.ReadOnly = true;
            this.colid_panadero.Width = 74;
            // 
            // colpanadero_name
            // 
            this.colpanadero_name.FieldName = "panadero_name";
            this.colpanadero_name.MinWidth = 19;
            this.colpanadero_name.Name = "colpanadero_name";
            this.colpanadero_name.OptionsColumn.ReadOnly = true;
            this.colpanadero_name.Visible = true;
            this.colpanadero_name.VisibleIndex = 2;
            this.colpanadero_name.Width = 270;
            // 
            // colcantidad_arrobas
            // 
            this.colcantidad_arrobas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_arrobas.FieldName = "cantidad_arrobas";
            this.colcantidad_arrobas.MinWidth = 19;
            this.colcantidad_arrobas.Name = "colcantidad_arrobas";
            this.colcantidad_arrobas.OptionsColumn.ReadOnly = true;
            this.colcantidad_arrobas.Visible = true;
            this.colcantidad_arrobas.VisibleIndex = 3;
            this.colcantidad_arrobas.Width = 274;
            // 
            // cmd_eliminar_row
            // 
            this.cmd_eliminar_row.Caption = "Eliminar";
            this.cmd_eliminar_row.ColumnEdit = this.btx_eliminar;
            this.cmd_eliminar_row.MinWidth = 19;
            this.cmd_eliminar_row.Name = "cmd_eliminar_row";
            this.cmd_eliminar_row.Visible = true;
            this.cmd_eliminar_row.VisibleIndex = 4;
            this.cmd_eliminar_row.Width = 74;
            // 
            // btx_eliminar
            // 
            this.btx_eliminar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btx_eliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btx_eliminar.Name = "btx_eliminar";
            this.btx_eliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btx_eliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btx_eliminar_ButtonClick);
            // 
            // cmdVerPage1
            // 
            this.cmdVerPage1.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdVerPage1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerPage1.Appearance.Options.UseBackColor = true;
            this.cmdVerPage1.Appearance.Options.UseFont = true;
            this.cmdVerPage1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdVerPage1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdVerPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdVerPage1.ImageOptions.SvgImage")));
            this.cmdVerPage1.Location = new System.Drawing.Point(8, 6);
            this.cmdVerPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdVerPage1.Name = "cmdVerPage1";
            this.cmdVerPage1.Size = new System.Drawing.Size(143, 34);
            this.cmdVerPage1.TabIndex = 69;
            this.cmdVerPage1.Text = "Ver Pedidos";
            this.cmdVerPage1.ToolTipTitle = "Ver Asignaciones";
            this.cmdVerPage1.Click += new System.EventHandler(this.cmdVerPage1_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl1.Location = new System.Drawing.Point(704, 25);
            this.progressBarControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(110, 19);
            this.progressBarControl1.TabIndex = 69;
            this.progressBarControl1.Visible = false;
            // 
            // lblCompletado
            // 
            this.lblCompletado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompletado.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletado.Appearance.Options.UseFont = true;
            this.lblCompletado.Location = new System.Drawing.Point(608, 25);
            this.lblCompletado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblCompletado.Name = "lblCompletado";
            this.lblCompletado.Size = new System.Drawing.Size(95, 17);
            this.lblCompletado.TabIndex = 70;
            this.lblCompletado.Text = "Completado (%)";
            this.lblCompletado.Visible = false;
            // 
            // frmAddOrderProductionV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 552);
            this.Controls.Add(this.lblCompletado);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.cmdGuardar);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAddOrderProductionV2";
            this.Text = "New Order Production";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogisticaJaguar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidosPRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookupEditPresentacionPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAsignarArrobas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGridLookUpE_UdMedidaFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGridLookUpE_MateriaPrimaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_GridLookUpEdit_Ud_medida_Jaguar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpE_Bodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btx_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private LogisticaJaguar.dsLogisticaJaguar dsLogisticaJaguar1;
        private System.Windows.Forms.BindingSource bindingSourcePT;
        private System.Windows.Forms.BindingSource bindingSourceRecetas;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEdit_PT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colid6;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion5;
        private DevExpress.XtraGrid.Columns.GridColumn colpt_name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gridLookupEditPresentacionPT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colid5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_arrobas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_latas;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_pedido;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_a_producir;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RGridLookUpE_UdMedidaFactura;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RGridLookUpE_MateriaPrimaList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit R_GridLookUpEdit_Ud_medida_Jaguar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpE_Bodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn colid4;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminar;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private LogisticaJaguar.Pedidos.dsPedidosPRD dsPedidosPRD1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_row;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraGrid.Columns.GridColumn colRowN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn col_ver_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_arrobas_asignadas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAsignarArrobas;
        private DevExpress.XtraEditors.SimpleButton cmdVerPage2;
        private DevExpress.XtraEditors.SimpleButton cmdVerPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private dsProduccion dsProduccion1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_panadero;
        private DevExpress.XtraGrid.Columns.GridColumn colpanadero_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_arrobas;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_name;
        private DevExpress.XtraGrid.Columns.GridColumn cmd_eliminar_row;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btx_eliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colud_medida_a_produccir;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblCompletado;
    }
}