
namespace JAGUAR_APP.TransaccionesMP
{
    partial class frmLogKardex
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
            this.grdLogkardex = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_lote_alosy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega_destin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_consumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_consumo_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dsReportesInventario = new JAGUAR_APP.Reportes.dsReportesInventario();
            ((System.ComponentModel.ISupportInitialize)(this.grdLogkardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLogkardex
            // 
            this.grdLogkardex.DataMember = "LogKardex_MP";
            this.grdLogkardex.DataSource = this.dsReportesInventario;
            this.grdLogkardex.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdLogkardex.Location = new System.Drawing.Point(0, 78);
            this.grdLogkardex.MainView = this.gridView1;
            this.grdLogkardex.Name = "grdLogkardex";
            this.grdLogkardex.Size = new System.Drawing.Size(1308, 528);
            this.grdLogkardex.TabIndex = 0;
            this.grdLogkardex.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_operacion,
            this.coltipo_operacion,
            this.colentrada,
            this.colsalida,
            this.colfecha_transaccion,
            this.colid_lote_alosy,
            this.collote,
            this.colid_mp,
            this.colnombre_comercial,
            this.colitemcode,
            this.colid_bodega,
            this.colbodega_destin,
            this.coluser_id,
            this.colud_entrada,
            this.colud_salida,
            this.colusuario,
            this.colid_tipo_consumo,
            this.coltipo_consumo_name});
            this.gridView1.GridControl = this.grdLogkardex;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_operacion
            // 
            this.colid_operacion.FieldName = "id_operacion";
            this.colid_operacion.Name = "colid_operacion";
            // 
            // coltipo_operacion
            // 
            this.coltipo_operacion.Caption = "Tipo Operacion";
            this.coltipo_operacion.FieldName = "tipo_operacion";
            this.coltipo_operacion.Name = "coltipo_operacion";
            this.coltipo_operacion.OptionsColumn.AllowEdit = false;
            this.coltipo_operacion.Visible = true;
            this.coltipo_operacion.VisibleIndex = 0;
            this.coltipo_operacion.Width = 110;
            // 
            // colentrada
            // 
            this.colentrada.Caption = "Ingreso";
            this.colentrada.FieldName = "entrada";
            this.colentrada.Name = "colentrada";
            this.colentrada.OptionsColumn.AllowEdit = false;
            this.colentrada.Visible = true;
            this.colentrada.VisibleIndex = 1;
            this.colentrada.Width = 84;
            // 
            // colsalida
            // 
            this.colsalida.Caption = "Salida";
            this.colsalida.FieldName = "salida";
            this.colsalida.Name = "colsalida";
            this.colsalida.OptionsColumn.AllowEdit = false;
            this.colsalida.Visible = true;
            this.colsalida.VisibleIndex = 2;
            this.colsalida.Width = 120;
            // 
            // colfecha_transaccion
            // 
            this.colfecha_transaccion.Caption = "Fecha";
            this.colfecha_transaccion.DisplayFormat.FormatString = "G";
            this.colfecha_transaccion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_transaccion.FieldName = "fecha_transaccion";
            this.colfecha_transaccion.Name = "colfecha_transaccion";
            this.colfecha_transaccion.OptionsColumn.AllowEdit = false;
            this.colfecha_transaccion.Visible = true;
            this.colfecha_transaccion.VisibleIndex = 3;
            this.colfecha_transaccion.Width = 182;
            // 
            // colid_lote_alosy
            // 
            this.colid_lote_alosy.FieldName = "id_lote_alosy";
            this.colid_lote_alosy.Name = "colid_lote_alosy";
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 4;
            this.collote.Width = 111;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "Nombre Comercial";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 5;
            this.colnombre_comercial.Width = 111;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo SAP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 6;
            this.colitemcode.Width = 111;
            // 
            // colid_bodega
            // 
            this.colid_bodega.FieldName = "id_bodega";
            this.colid_bodega.Name = "colid_bodega";
            // 
            // colbodega_destin
            // 
            this.colbodega_destin.Caption = "Bodega";
            this.colbodega_destin.FieldName = "bodega_destin";
            this.colbodega_destin.Name = "colbodega_destin";
            this.colbodega_destin.OptionsColumn.AllowEdit = false;
            this.colbodega_destin.Visible = true;
            this.colbodega_destin.VisibleIndex = 7;
            this.colbodega_destin.Width = 111;
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            // 
            // colud_entrada
            // 
            this.colud_entrada.Caption = "Unidades Ingreso";
            this.colud_entrada.FieldName = "ud_entrada";
            this.colud_entrada.Name = "colud_entrada";
            this.colud_entrada.OptionsColumn.AllowEdit = false;
            this.colud_entrada.Visible = true;
            this.colud_entrada.VisibleIndex = 8;
            this.colud_entrada.Width = 111;
            // 
            // colud_salida
            // 
            this.colud_salida.Caption = "Unidades Salida";
            this.colud_salida.FieldName = "ud_salida";
            this.colud_salida.Name = "colud_salida";
            this.colud_salida.OptionsColumn.AllowEdit = false;
            this.colud_salida.Visible = true;
            this.colud_salida.VisibleIndex = 9;
            this.colud_salida.Width = 111;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 10;
            this.colusuario.Width = 128;
            // 
            // colid_tipo_consumo
            // 
            this.colid_tipo_consumo.FieldName = "id_tipo_consumo";
            this.colid_tipo_consumo.Name = "colid_tipo_consumo";
            // 
            // coltipo_consumo_name
            // 
            this.coltipo_consumo_name.FieldName = "tipo_consumo_name";
            this.coltipo_consumo_name.Name = "coltipo_consumo_name";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(464, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(375, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Registro de Entrada/Salida por Lote y Bodega";
            // 
            // dsReportesInventario
            // 
            this.dsReportesInventario.DataSetName = "dsReportesInventario";
            this.dsReportesInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmLogKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 606);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grdLogkardex);
            this.Name = "frmLogKardex";
            this.Text = "Entradas/Salidas ";
            ((System.ComponentModel.ISupportInitialize)(this.grdLogkardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLogkardex;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
  
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_operacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_operacion;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_lote_alosy;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega_destin;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colud_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colud_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_consumo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_consumo_name;
        private Reportes.dsReportesInventario dsReportesInventario;
    }
}