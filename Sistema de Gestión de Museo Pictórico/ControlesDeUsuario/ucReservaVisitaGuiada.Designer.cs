
namespace CapaNegocio
{
    partial class ucReservaVisitaGuiada
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_confirmarReserva = new DevExpress.XtraEditors.SimpleButton();
            this.btn_anterior = new DevExpress.XtraEditors.SimpleButton();
            this.btn_siguiente = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNav1_Escuelas = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblEscSel = new DevExpress.XtraEditors.LabelControl();
            this.lblEscuelaText = new DevExpress.XtraEditors.LabelControl();
            this.spinCantVisitantes = new DevExpress.XtraEditors.SpinEdit();
            this.dgvEscuelas = new DevExpress.XtraGrid.GridControl();
            this.escuelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridEscuelas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idEscuela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabNav2_Sedes = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblSedeSel = new DevExpress.XtraEditors.LabelControl();
            this.lblSedeText = new DevExpress.XtraEditors.LabelControl();
            this.dgvSede = new DevExpress.XtraGrid.GridControl();
            this.sedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridSedes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidadMaximaVisitantes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidadMaxPorGuia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tabNav3_Visita_Exposiciones = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cmbTipoVisita = new System.Windows.Forms.ComboBox();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceExpoPorSede = new System.Windows.Forms.BindingSource(this.components);
            this.gridExposiciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidExposicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaFinReplanificada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaInicioReplanificada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoraApertura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoraCierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPublicoDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tabNav4_DiaVisita = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblFechaSel = new System.Windows.Forms.Label();
            this.cmbHorarioSel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.tabNav5_Guia = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.Dgv_Guias = new DevExpress.XtraGrid.GridControl();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridGuias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coIIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreGuia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorarioEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_CantGuias = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tabNav6_DetalleReserva = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupCtrConfirmacion = new DevExpress.XtraEditors.GroupControl();
            this.lblConfGuiasSel = new DevExpress.XtraEditors.LabelControl();
            this.lblConfGuias = new DevExpress.XtraEditors.LabelControl();
            this.lblConfHoraSel = new DevExpress.XtraEditors.LabelControl();
            this.lblConfHora = new DevExpress.XtraEditors.LabelControl();
            this.lblConfDiaSel = new DevExpress.XtraEditors.LabelControl();
            this.lblConfDiaVisita = new DevExpress.XtraEditors.LabelControl();
            this.lblConfExposicionesSel = new DevExpress.XtraEditors.LabelControl();
            this.lblConfExpo = new DevExpress.XtraEditors.LabelControl();
            this.lblConfTipoVisitaSel = new DevExpress.XtraEditors.LabelControl();
            this.lblTipoVisita = new DevExpress.XtraEditors.LabelControl();
            this.lblConfSedeSel = new DevExpress.XtraEditors.LabelControl();
            this.lblSede = new DevExpress.XtraEditors.LabelControl();
            this.lblConfEscSel = new DevExpress.XtraEditors.LabelControl();
            this.lblEsc = new DevExpress.XtraEditors.LabelControl();
            this.exposicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNav1_Escuelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantVisitantes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEscuelas)).BeginInit();
            this.tabNav2_Sedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSedes)).BeginInit();
            this.tabNav3_Visita_Exposiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceExpoPorSede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExposiciones)).BeginInit();
            this.tabNav4_DiaVisita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.tabNav5_Guia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Guias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGuias)).BeginInit();
            this.tabNav6_DetalleReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrConfirmacion)).BeginInit();
            this.groupCtrConfirmacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exposicionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.tabPane1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1203, 681);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_confirmarReserva);
            this.panelControl3.Controls.Add(this.btn_anterior);
            this.panelControl3.Controls.Add(this.btn_siguiente);
            this.panelControl3.Controls.Add(this.btn_cancelar);
            this.panelControl3.Location = new System.Drawing.Point(0, 604);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1203, 77);
            this.panelControl3.TabIndex = 1;
            // 
            // btn_confirmarReserva
            // 
            this.btn_confirmarReserva.Location = new System.Drawing.Point(1051, 29);
            this.btn_confirmarReserva.Name = "btn_confirmarReserva";
            this.btn_confirmarReserva.Size = new System.Drawing.Size(115, 23);
            this.btn_confirmarReserva.TabIndex = 3;
            this.btn_confirmarReserva.Text = "Confirmar Reserva";
            this.btn_confirmarReserva.Visible = false;
            this.btn_confirmarReserva.Click += new System.EventHandler(this.btn_confirmarReserva_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(944, 29);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 2;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.Visible = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(1091, 29);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 1;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(40, 29);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNav1_Escuelas);
            this.tabPane1.Controls.Add(this.tabNav2_Sedes);
            this.tabPane1.Controls.Add(this.tabNav3_Visita_Exposiciones);
            this.tabPane1.Controls.Add(this.tabNav4_DiaVisita);
            this.tabPane1.Controls.Add(this.tabNav5_Guia);
            this.tabPane1.Controls.Add(this.tabNav6_DetalleReserva);
            this.tabPane1.Location = new System.Drawing.Point(14, 15);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNav1_Escuelas,
            this.tabNav2_Sedes,
            this.tabNav3_Visita_Exposiciones,
            this.tabNav4_DiaVisita,
            this.tabNav5_Guia,
            this.tabNav6_DetalleReserva});
            this.tabPane1.RegularSize = new System.Drawing.Size(1174, 573);
            this.tabPane1.SelectedPage = this.tabNav1_Escuelas;
            this.tabPane1.Size = new System.Drawing.Size(1174, 573);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane1_SelectedPageChanged);
            // 
            // tabNav1_Escuelas
            // 
            this.tabNav1_Escuelas.Caption = "Escuelas";
            this.tabNav1_Escuelas.Controls.Add(this.lblEscSel);
            this.tabNav1_Escuelas.Controls.Add(this.lblEscuelaText);
            this.tabNav1_Escuelas.Controls.Add(this.spinCantVisitantes);
            this.tabNav1_Escuelas.Controls.Add(this.dgvEscuelas);
            this.tabNav1_Escuelas.Controls.Add(this.labelControl2);
            this.tabNav1_Escuelas.Controls.Add(this.labelControl1);
            this.tabNav1_Escuelas.Name = "tabNav1_Escuelas";
            this.tabNav1_Escuelas.Size = new System.Drawing.Size(1174, 544);
            this.tabNav1_Escuelas.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNavigationPage1_Paint);
            // 
            // lblEscSel
            // 
            this.lblEscSel.Location = new System.Drawing.Point(266, 66);
            this.lblEscSel.Name = "lblEscSel";
            this.lblEscSel.Size = new System.Drawing.Size(0, 13);
            this.lblEscSel.TabIndex = 8;
            // 
            // lblEscuelaText
            // 
            this.lblEscuelaText.Location = new System.Drawing.Point(132, 66);
            this.lblEscuelaText.Name = "lblEscuelaText";
            this.lblEscuelaText.Size = new System.Drawing.Size(104, 13);
            this.lblEscuelaText.TabIndex = 7;
            this.lblEscuelaText.Text = "Escuela seleccionada:";
            // 
            // spinCantVisitantes
            // 
            this.spinCantVisitantes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCantVisitantes.Location = new System.Drawing.Point(207, 502);
            this.spinCantVisitantes.Name = "spinCantVisitantes";
            this.spinCantVisitantes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinCantVisitantes.Properties.IsFloatValue = false;
            this.spinCantVisitantes.Properties.Mask.EditMask = "N00";
            this.spinCantVisitantes.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinCantVisitantes.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinCantVisitantes.Size = new System.Drawing.Size(100, 20);
            this.spinCantVisitantes.TabIndex = 6;
            this.spinCantVisitantes.EditValueChanged += new System.EventHandler(this.spinCantVisitantes_EditValueChanged);
            // 
            // dgvEscuelas
            // 
            this.dgvEscuelas.DataSource = this.escuelaBindingSource;
            this.dgvEscuelas.Location = new System.Drawing.Point(27, 116);
            this.dgvEscuelas.MainView = this.gridEscuelas;
            this.dgvEscuelas.Name = "dgvEscuelas";
            this.dgvEscuelas.Size = new System.Drawing.Size(1120, 365);
            this.dgvEscuelas.TabIndex = 5;
            this.dgvEscuelas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridEscuelas});
            // 
            // escuelaBindingSource
            // 
            this.escuelaBindingSource.DataSource = typeof(CapaNegocio.Escuela);
            // 
            // gridEscuelas
            // 
            this.gridEscuelas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.coldomicilio,
            this.colmail,
            this.coltelefFijo,
            this.coltelefCelular,
            this.idEscuela});
            this.gridEscuelas.GridControl = this.dgvEscuelas;
            this.gridEscuelas.Name = "gridEscuelas";
            this.gridEscuelas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridEscuelas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridEscuelas.OptionsBehavior.Editable = false;
            this.gridEscuelas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridEscuelas.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridEscuelas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.tomarSeleccionDeEscuela);
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // coldomicilio
            // 
            this.coldomicilio.Caption = "Domicilio";
            this.coldomicilio.FieldName = "domicilio";
            this.coldomicilio.Name = "coldomicilio";
            this.coldomicilio.OptionsColumn.AllowEdit = false;
            this.coldomicilio.Visible = true;
            this.coldomicilio.VisibleIndex = 1;
            // 
            // colmail
            // 
            this.colmail.Caption = "Mail";
            this.colmail.FieldName = "mail";
            this.colmail.Name = "colmail";
            this.colmail.OptionsColumn.AllowEdit = false;
            this.colmail.Visible = true;
            this.colmail.VisibleIndex = 2;
            // 
            // coltelefFijo
            // 
            this.coltelefFijo.Caption = "Telefono";
            this.coltelefFijo.FieldName = "telefFijo";
            this.coltelefFijo.Name = "coltelefFijo";
            this.coltelefFijo.OptionsColumn.AllowEdit = false;
            this.coltelefFijo.Visible = true;
            this.coltelefFijo.VisibleIndex = 3;
            // 
            // coltelefCelular
            // 
            this.coltelefCelular.Caption = "Celular";
            this.coltelefCelular.FieldName = "telefCelular";
            this.coltelefCelular.Name = "coltelefCelular";
            this.coltelefCelular.OptionsColumn.AllowEdit = false;
            this.coltelefCelular.Visible = true;
            this.coltelefCelular.VisibleIndex = 4;
            // 
            // idEscuela
            // 
            this.idEscuela.Caption = "idEscuela";
            this.idEscuela.FieldName = "idEscuela";
            this.idEscuela.Name = "idEscuela";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 502);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ingrese la cantidad de visitantes";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Listado de Escuelas Disponibles";
            // 
            // tabNav2_Sedes
            // 
            this.tabNav2_Sedes.Caption = "Sede";
            this.tabNav2_Sedes.Controls.Add(this.lblSedeSel);
            this.tabNav2_Sedes.Controls.Add(this.lblSedeText);
            this.tabNav2_Sedes.Controls.Add(this.dgvSede);
            this.tabNav2_Sedes.Controls.Add(this.labelControl3);
            this.tabNav2_Sedes.Name = "tabNav2_Sedes";
            this.tabNav2_Sedes.Size = new System.Drawing.Size(1174, 544);
            // 
            // lblSedeSel
            // 
            this.lblSedeSel.Location = new System.Drawing.Point(249, 72);
            this.lblSedeSel.Name = "lblSedeSel";
            this.lblSedeSel.Size = new System.Drawing.Size(0, 13);
            this.lblSedeSel.TabIndex = 9;
            // 
            // lblSedeText
            // 
            this.lblSedeText.Location = new System.Drawing.Point(128, 72);
            this.lblSedeText.Name = "lblSedeText";
            this.lblSedeText.Size = new System.Drawing.Size(92, 13);
            this.lblSedeText.TabIndex = 8;
            this.lblSedeText.Text = "Sede seleccionada:";
            // 
            // dgvSede
            // 
            this.dgvSede.DataSource = this.sedeBindingSource;
            this.dgvSede.Location = new System.Drawing.Point(27, 116);
            this.dgvSede.MainView = this.gridSedes;
            this.dgvSede.Name = "dgvSede";
            this.dgvSede.Size = new System.Drawing.Size(1120, 403);
            this.dgvSede.TabIndex = 4;
            this.dgvSede.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSedes});
            // 
            // sedeBindingSource
            // 
            this.sedeBindingSource.DataSource = typeof(CapaNegocio.Sede);
            // 
            // gridSedes
            // 
            this.gridSedes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre1,
            this.colcantidadMaximaVisitantes,
            this.colcantidadMaxPorGuia});
            this.gridSedes.GridControl = this.dgvSede;
            this.gridSedes.Name = "gridSedes";
            this.gridSedes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridSedes.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridSedes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.tomarSeleccionDeSede);
            // 
            // colnombre1
            // 
            this.colnombre1.Caption = "Nombre";
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.OptionsColumn.AllowEdit = false;
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 0;
            // 
            // colcantidadMaximaVisitantes
            // 
            this.colcantidadMaximaVisitantes.Caption = "Cant. max. visitantes";
            this.colcantidadMaximaVisitantes.FieldName = "cantidadMaximaVisitantes";
            this.colcantidadMaximaVisitantes.Name = "colcantidadMaximaVisitantes";
            this.colcantidadMaximaVisitantes.OptionsColumn.AllowEdit = false;
            this.colcantidadMaximaVisitantes.Visible = true;
            this.colcantidadMaximaVisitantes.VisibleIndex = 1;
            // 
            // colcantidadMaxPorGuia
            // 
            this.colcantidadMaxPorGuia.Caption = "Cant. max. por guia";
            this.colcantidadMaxPorGuia.FieldName = "cantidadMaxPorGuia";
            this.colcantidadMaxPorGuia.Name = "colcantidadMaxPorGuia";
            this.colcantidadMaxPorGuia.OptionsColumn.AllowEdit = false;
            this.colcantidadMaxPorGuia.Visible = true;
            this.colcantidadMaxPorGuia.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(186, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Listado de Sedes Disponibles";
            // 
            // tabNav3_Visita_Exposiciones
            // 
            this.tabNav3_Visita_Exposiciones.Caption = "Visita y Exposiciones";
            this.tabNav3_Visita_Exposiciones.Controls.Add(this.cmbTipoVisita);
            this.tabNav3_Visita_Exposiciones.Controls.Add(this.gridControl3);
            this.tabNav3_Visita_Exposiciones.Controls.Add(this.labelControl11);
            this.tabNav3_Visita_Exposiciones.Controls.Add(this.labelControl5);
            this.tabNav3_Visita_Exposiciones.Controls.Add(this.labelControl4);
            this.tabNav3_Visita_Exposiciones.Name = "tabNav3_Visita_Exposiciones";
            this.tabNav3_Visita_Exposiciones.Size = new System.Drawing.Size(1174, 544);
            // 
            // cmbTipoVisita
            // 
            this.cmbTipoVisita.DisplayMember = "idTipoVisita";
            this.cmbTipoVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVisita.FormattingEnabled = true;
            this.cmbTipoVisita.Location = new System.Drawing.Point(213, 56);
            this.cmbTipoVisita.Name = "cmbTipoVisita";
            this.cmbTipoVisita.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVisita.TabIndex = 8;
            this.cmbTipoVisita.ValueMember = "idTipoVisita";
            this.cmbTipoVisita.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVisita_SelectedIndexChanged);
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.bindingSourceExpoPorSede;
            this.gridControl3.Location = new System.Drawing.Point(27, 116);
            this.gridControl3.MainView = this.gridExposiciones;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(1120, 403);
            this.gridControl3.TabIndex = 7;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridExposiciones});
            // 
            // gridExposiciones
            // 
            this.gridExposiciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidExposicion,
            this.colfechaFin,
            this.colfechaFinReplanificada,
            this.colfechaInicio,
            this.colfechaInicioReplanificada,
            this.colhoraApertura,
            this.colhoraCierre,
            this.colnombre2,
            this.colidPublicoDestino});
            this.gridExposiciones.GridControl = this.gridControl3;
            this.gridExposiciones.Name = "gridExposiciones";
            this.gridExposiciones.OptionsSelection.MultiSelect = true;
            this.gridExposiciones.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colidExposicion
            // 
            this.colidExposicion.FieldName = "Id Exposicion";
            this.colidExposicion.Name = "colidExposicion";
            this.colidExposicion.OptionsColumn.AllowEdit = false;
            // 
            // colfechaFin
            // 
            this.colfechaFin.FieldName = "Fecha Fin";
            this.colfechaFin.Name = "colfechaFin";
            this.colfechaFin.OptionsColumn.AllowEdit = false;
            this.colfechaFin.Visible = true;
            this.colfechaFin.VisibleIndex = 1;
            // 
            // colfechaFinReplanificada
            // 
            this.colfechaFinReplanificada.FieldName = "Fecha Fin Replanificada";
            this.colfechaFinReplanificada.Name = "colfechaFinReplanificada";
            this.colfechaFinReplanificada.OptionsColumn.AllowEdit = false;
            this.colfechaFinReplanificada.Visible = true;
            this.colfechaFinReplanificada.VisibleIndex = 2;
            // 
            // colfechaInicio
            // 
            this.colfechaInicio.FieldName = "Fecha Inicio";
            this.colfechaInicio.Name = "colfechaInicio";
            this.colfechaInicio.OptionsColumn.AllowEdit = false;
            this.colfechaInicio.Visible = true;
            this.colfechaInicio.VisibleIndex = 3;
            // 
            // colfechaInicioReplanificada
            // 
            this.colfechaInicioReplanificada.FieldName = "Fecha Inicio Replanificada";
            this.colfechaInicioReplanificada.Name = "colfechaInicioReplanificada";
            this.colfechaInicioReplanificada.OptionsColumn.AllowEdit = false;
            this.colfechaInicioReplanificada.Visible = true;
            this.colfechaInicioReplanificada.VisibleIndex = 4;
            // 
            // colhoraApertura
            // 
            this.colhoraApertura.DisplayFormat.FormatString = "HH:mm";
            this.colhoraApertura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhoraApertura.FieldName = "Hora Apertura";
            this.colhoraApertura.Name = "colhoraApertura";
            this.colhoraApertura.OptionsColumn.AllowEdit = false;
            this.colhoraApertura.Visible = true;
            this.colhoraApertura.VisibleIndex = 5;
            // 
            // colhoraCierre
            // 
            this.colhoraCierre.DisplayFormat.FormatString = "HH:mm";
            this.colhoraCierre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhoraCierre.FieldName = "Hora Cierre";
            this.colhoraCierre.Name = "colhoraCierre";
            this.colhoraCierre.OptionsColumn.AllowEdit = false;
            this.colhoraCierre.Visible = true;
            this.colhoraCierre.VisibleIndex = 6;
            // 
            // colnombre2
            // 
            this.colnombre2.FieldName = "Nombre";
            this.colnombre2.Name = "colnombre2";
            this.colnombre2.OptionsColumn.AllowEdit = false;
            this.colnombre2.Visible = true;
            this.colnombre2.VisibleIndex = 7;
            // 
            // colidPublicoDestino
            // 
            this.colidPublicoDestino.FieldName = "Publico Destino";
            this.colidPublicoDestino.Name = "colidPublicoDestino";
            this.colidPublicoDestino.OptionsColumn.AllowEdit = false;
            this.colidPublicoDestino.Visible = true;
            this.colidPublicoDestino.VisibleIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(63, 59);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(63, 13);
            this.labelControl11.TabIndex = 6;
            this.labelControl11.Text = "Tipo de visita";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Exposiciones disponibles";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(34, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(154, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Seleccione la exposicion";
            // 
            // tabNav4_DiaVisita
            // 
            this.tabNav4_DiaVisita.Caption = "Día y Horario de Visita";
            this.tabNav4_DiaVisita.Controls.Add(this.lblFechaSel);
            this.tabNav4_DiaVisita.Controls.Add(this.cmbHorarioSel);
            this.tabNav4_DiaVisita.Controls.Add(this.label2);
            this.tabNav4_DiaVisita.Controls.Add(this.labelControl8);
            this.tabNav4_DiaVisita.Controls.Add(this.labelControl6);
            this.tabNav4_DiaVisita.Controls.Add(this.calendarControl1);
            this.tabNav4_DiaVisita.Name = "tabNav4_DiaVisita";
            this.tabNav4_DiaVisita.Size = new System.Drawing.Size(1174, 544);
            // 
            // lblFechaSel
            // 
            this.lblFechaSel.AutoSize = true;
            this.lblFechaSel.Location = new System.Drawing.Point(177, 504);
            this.lblFechaSel.Name = "lblFechaSel";
            this.lblFechaSel.Size = new System.Drawing.Size(0, 13);
            this.lblFechaSel.TabIndex = 10;
            // 
            // cmbHorarioSel
            // 
            this.cmbHorarioSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioSel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbHorarioSel.FormattingEnabled = true;
            this.cmbHorarioSel.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00"});
            this.cmbHorarioSel.Location = new System.Drawing.Point(854, 85);
            this.cmbHorarioSel.Name = "cmbHorarioSel";
            this.cmbHorarioSel.Size = new System.Drawing.Size(96, 21);
            this.cmbHorarioSel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha seleccionada:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(854, 65);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Hora:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(34, 22);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(167, 16);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Seleccione el día y la hora";
            // 
            // calendarControl1
            // 
            this.calendarControl1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.calendarControl1.Appearance.Options.UseBackColor = true;
            this.calendarControl1.AutoSize = false;
            this.calendarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.calendarControl1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.calendarControl1.Location = new System.Drawing.Point(54, 65);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.RowCount = 1;
            this.calendarControl1.Size = new System.Drawing.Size(615, 403);
            this.calendarControl1.TabIndex = 0;
            this.calendarControl1.Click += new System.EventHandler(this.calendarControl1_Click);
            // 
            // tabNav5_Guia
            // 
            this.tabNav5_Guia.Caption = "Guía";
            this.tabNav5_Guia.Controls.Add(this.Dgv_Guias);
            this.tabNav5_Guia.Controls.Add(this.txt_CantGuias);
            this.tabNav5_Guia.Controls.Add(this.labelControl10);
            this.tabNav5_Guia.Controls.Add(this.labelControl9);
            this.tabNav5_Guia.Name = "tabNav5_Guia";
            this.tabNav5_Guia.Size = new System.Drawing.Size(1174, 544);
            // 
            // Dgv_Guias
            // 
            this.Dgv_Guias.DataSource = this.empleadoBindingSource;
            this.Dgv_Guias.Location = new System.Drawing.Point(27, 116);
            this.Dgv_Guias.MainView = this.gridGuias;
            this.Dgv_Guias.Name = "Dgv_Guias";
            this.Dgv_Guias.Size = new System.Drawing.Size(1120, 403);
            this.Dgv_Guias.TabIndex = 7;
            this.Dgv_Guias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGuias});
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(CapaNegocio.Empleado);
            // 
            // gridGuias
            // 
            this.gridGuias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coIIdEmpleado,
            this.colApellido,
            this.colNombreGuia,
            this.colHorarioEmpleado});
            this.gridGuias.GridControl = this.Dgv_Guias;
            this.gridGuias.Name = "gridGuias";
            this.gridGuias.OptionsSelection.MultiSelect = true;
            this.gridGuias.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // coIIdEmpleado
            // 
            this.coIIdEmpleado.Caption = "idEmpleado";
            this.coIIdEmpleado.FieldName = "idEmpleado";
            this.coIIdEmpleado.Name = "coIIdEmpleado";
            this.coIIdEmpleado.Width = 94;
            // 
            // colApellido
            // 
            this.colApellido.Caption = "Apellido";
            this.colApellido.FieldName = "apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 1;
            this.colApellido.Width = 280;
            // 
            // colNombreGuia
            // 
            this.colNombreGuia.Caption = "Nombre";
            this.colNombreGuia.FieldName = "nombre";
            this.colNombreGuia.Name = "colNombreGuia";
            this.colNombreGuia.Visible = true;
            this.colNombreGuia.VisibleIndex = 2;
            this.colNombreGuia.Width = 314;
            // 
            // colHorarioEmpleado
            // 
            this.colHorarioEmpleado.Caption = "Horario Empleado";
            this.colHorarioEmpleado.FieldName = "idHorarioEmpleado";
            this.colHorarioEmpleado.Name = "colHorarioEmpleado";
            this.colHorarioEmpleado.Visible = true;
            this.colHorarioEmpleado.VisibleIndex = 3;
            this.colHorarioEmpleado.Width = 332;
            // 
            // txt_CantGuias
            // 
            this.txt_CantGuias.Enabled = false;
            this.txt_CantGuias.Location = new System.Drawing.Point(224, 62);
            this.txt_CantGuias.Name = "txt_CantGuias";
            this.txt_CantGuias.ReadOnly = true;
            this.txt_CantGuias.Size = new System.Drawing.Size(32, 21);
            this.txt_CantGuias.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(43, 65);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(159, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Cantidad de guias recomendados";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(34, 22);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(128, 16);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "Seleccione los guias";
            // 
            // tabNav6_DetalleReserva
            // 
            this.tabNav6_DetalleReserva.Caption = "Confirmación";
            this.tabNav6_DetalleReserva.Controls.Add(this.groupCtrConfirmacion);
            this.tabNav6_DetalleReserva.Name = "tabNav6_DetalleReserva";
            this.tabNav6_DetalleReserva.Size = new System.Drawing.Size(1174, 544);
            // 
            // groupCtrConfirmacion
            // 
            this.groupCtrConfirmacion.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCtrConfirmacion.AppearanceCaption.Options.UseFont = true;
            this.groupCtrConfirmacion.Controls.Add(this.lblConfGuiasSel);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfGuias);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfHoraSel);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfHora);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfDiaSel);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfDiaVisita);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfExposicionesSel);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfExpo);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfTipoVisitaSel);
            this.groupCtrConfirmacion.Controls.Add(this.lblTipoVisita);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfSedeSel);
            this.groupCtrConfirmacion.Controls.Add(this.lblSede);
            this.groupCtrConfirmacion.Controls.Add(this.lblConfEscSel);
            this.groupCtrConfirmacion.Controls.Add(this.lblEsc);
            this.groupCtrConfirmacion.Location = new System.Drawing.Point(26, 28);
            this.groupCtrConfirmacion.Name = "groupCtrConfirmacion";
            this.groupCtrConfirmacion.Size = new System.Drawing.Size(1126, 509);
            this.groupCtrConfirmacion.TabIndex = 0;
            this.groupCtrConfirmacion.Text = "Detalle de la Reserva";
            // 
            // lblConfGuiasSel
            // 
            this.lblConfGuiasSel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfGuiasSel.Appearance.Options.UseFont = true;
            this.lblConfGuiasSel.Location = new System.Drawing.Point(168, 273);
            this.lblConfGuiasSel.Name = "lblConfGuiasSel";
            this.lblConfGuiasSel.Size = new System.Drawing.Size(37, 19);
            this.lblConfGuiasSel.TabIndex = 13;
            this.lblConfGuiasSel.Text = "guías";
            // 
            // lblConfGuias
            // 
            this.lblConfGuias.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfGuias.Appearance.Options.UseFont = true;
            this.lblConfGuias.Location = new System.Drawing.Point(99, 273);
            this.lblConfGuias.Name = "lblConfGuias";
            this.lblConfGuias.Size = new System.Drawing.Size(51, 19);
            this.lblConfGuias.TabIndex = 12;
            this.lblConfGuias.Text = "Guías:";
            // 
            // lblConfHoraSel
            // 
            this.lblConfHoraSel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfHoraSel.Appearance.Options.UseFont = true;
            this.lblConfHoraSel.Location = new System.Drawing.Point(704, 213);
            this.lblConfHoraSel.Name = "lblConfHoraSel";
            this.lblConfHoraSel.Size = new System.Drawing.Size(32, 19);
            this.lblConfHoraSel.TabIndex = 11;
            this.lblConfHoraSel.Text = "hora";
            // 
            // lblConfHora
            // 
            this.lblConfHora.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfHora.Appearance.Options.UseFont = true;
            this.lblConfHora.Location = new System.Drawing.Point(555, 213);
            this.lblConfHora.Name = "lblConfHora";
            this.lblConfHora.Size = new System.Drawing.Size(139, 19);
            this.lblConfHora.TabIndex = 10;
            this.lblConfHora.Text = "Hora de la visita:";
            // 
            // lblConfDiaSel
            // 
            this.lblConfDiaSel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfDiaSel.Appearance.Options.UseFont = true;
            this.lblConfDiaSel.Location = new System.Drawing.Point(168, 213);
            this.lblConfDiaSel.Name = "lblConfDiaSel";
            this.lblConfDiaSel.Size = new System.Drawing.Size(21, 19);
            this.lblConfDiaSel.TabIndex = 9;
            this.lblConfDiaSel.Text = "dia";
            // 
            // lblConfDiaVisita
            // 
            this.lblConfDiaVisita.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfDiaVisita.Appearance.Options.UseFont = true;
            this.lblConfDiaVisita.Location = new System.Drawing.Point(23, 213);
            this.lblConfDiaVisita.Name = "lblConfDiaVisita";
            this.lblConfDiaVisita.Size = new System.Drawing.Size(127, 19);
            this.lblConfDiaVisita.TabIndex = 8;
            this.lblConfDiaVisita.Text = "Día de la visita:";
            // 
            // lblConfExposicionesSel
            // 
            this.lblConfExposicionesSel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfExposicionesSel.Appearance.Options.UseFont = true;
            this.lblConfExposicionesSel.Location = new System.Drawing.Point(168, 148);
            this.lblConfExposicionesSel.Name = "lblConfExposicionesSel";
            this.lblConfExposicionesSel.Size = new System.Drawing.Size(89, 19);
            this.lblConfExposicionesSel.TabIndex = 7;
            this.lblConfExposicionesSel.Text = "exposiciones";
            // 
            // lblConfExpo
            // 
            this.lblConfExpo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfExpo.Appearance.Options.UseFont = true;
            this.lblConfExpo.Location = new System.Drawing.Point(40, 148);
            this.lblConfExpo.Name = "lblConfExpo";
            this.lblConfExpo.Size = new System.Drawing.Size(110, 19);
            this.lblConfExpo.TabIndex = 6;
            this.lblConfExpo.Text = "Exposiciones:";
            // 
            // lblConfTipoVisitaSel
            // 
            this.lblConfTipoVisitaSel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfTipoVisitaSel.Appearance.Options.UseFont = true;
            this.lblConfTipoVisitaSel.Location = new System.Drawing.Point(168, 89);
            this.lblConfTipoVisitaSel.Name = "lblConfTipoVisitaSel";
            this.lblConfTipoVisitaSel.Size = new System.Drawing.Size(63, 19);
            this.lblConfTipoVisitaSel.TabIndex = 5;
            this.lblConfTipoVisitaSel.Text = "tipovisita";
            // 
            // lblTipoVisita
            // 
            this.lblTipoVisita.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVisita.Appearance.Options.UseFont = true;
            this.lblTipoVisita.Location = new System.Drawing.Point(32, 89);
            this.lblTipoVisita.Name = "lblTipoVisita";
            this.lblTipoVisita.Size = new System.Drawing.Size(118, 19);
            this.lblTipoVisita.TabIndex = 4;
            this.lblTipoVisita.Text = "Tipo de Visita:";
            // 
            // lblConfSedeSel
            // 
            this.lblConfSedeSel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSedeSel.Appearance.Options.UseFont = true;
            this.lblConfSedeSel.Location = new System.Drawing.Point(704, 39);
            this.lblConfSedeSel.Name = "lblConfSedeSel";
            this.lblConfSedeSel.Size = new System.Drawing.Size(32, 19);
            this.lblConfSedeSel.TabIndex = 3;
            this.lblConfSedeSel.Text = "sede";
            // 
            // lblSede
            // 
            this.lblSede.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Appearance.Options.UseFont = true;
            this.lblSede.Location = new System.Drawing.Point(648, 39);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(46, 19);
            this.lblSede.TabIndex = 2;
            this.lblSede.Text = "Sede:";
            // 
            // lblConfEscSel
            // 
            this.lblConfEscSel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfEscSel.Appearance.Options.UseFont = true;
            this.lblConfEscSel.Location = new System.Drawing.Point(168, 39);
            this.lblConfEscSel.Name = "lblConfEscSel";
            this.lblConfEscSel.Size = new System.Drawing.Size(51, 19);
            this.lblConfEscSel.TabIndex = 1;
            this.lblConfEscSel.Text = "escuela";
            // 
            // lblEsc
            // 
            this.lblEsc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsc.Appearance.Options.UseFont = true;
            this.lblEsc.Location = new System.Drawing.Point(83, 39);
            this.lblEsc.Name = "lblEsc";
            this.lblEsc.Size = new System.Drawing.Size(67, 19);
            this.lblEsc.TabIndex = 0;
            this.lblEsc.Text = "Escuela:";
            // 
            // exposicionBindingSource
            // 
            this.exposicionBindingSource.DataSource = typeof(CapaNegocio.Exposicion);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ucReservaVisitaGuiada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucReservaVisitaGuiada";
            this.Size = new System.Drawing.Size(1203, 681);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNav1_Escuelas.ResumeLayout(false);
            this.tabNav1_Escuelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantVisitantes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEscuelas)).EndInit();
            this.tabNav2_Sedes.ResumeLayout(false);
            this.tabNav2_Sedes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSedes)).EndInit();
            this.tabNav3_Visita_Exposiciones.ResumeLayout(false);
            this.tabNav3_Visita_Exposiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceExpoPorSede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExposiciones)).EndInit();
            this.tabNav4_DiaVisita.ResumeLayout(false);
            this.tabNav4_DiaVisita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.tabNav5_Guia.ResumeLayout(false);
            this.tabNav5_Guia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Guias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGuias)).EndInit();
            this.tabNav6_DetalleReserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrConfirmacion)).EndInit();
            this.groupCtrConfirmacion.ResumeLayout(false);
            this.groupCtrConfirmacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exposicionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNav1_Escuelas;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNav2_Sedes;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNav3_Visita_Exposiciones;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNav4_DiaVisita;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNav5_Guia;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNav6_DetalleReserva;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_anterior;
        private DevExpress.XtraEditors.SimpleButton btn_siguiente;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupCtrConfirmacion;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TextBox txt_CantGuias;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btn_confirmarReserva;
        private DevExpress.XtraGrid.GridControl dgvEscuelas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridEscuelas;
        private DevExpress.XtraGrid.GridControl dgvSede;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSedes;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridExposiciones;
        private System.Windows.Forms.ComboBox cmbTipoVisita;
        private System.Windows.Forms.BindingSource escuelaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldomicilio;
        private DevExpress.XtraGrid.Columns.GridColumn colmail;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefFijo;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefCelular;
        private System.Windows.Forms.BindingSource sedeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidadMaximaVisitantes;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidadMaxPorGuia;
        private System.Windows.Forms.BindingSource exposicionBindingSource;
        private DevExpress.XtraEditors.SpinEdit spinCantVisitantes;
        private DevExpress.XtraEditors.LabelControl lblEscSel;
        private DevExpress.XtraEditors.LabelControl lblEscuelaText;
        private DevExpress.XtraEditors.LabelControl lblSedeSel;
        private DevExpress.XtraEditors.LabelControl lblSedeText;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbHorarioSel;
        private System.Windows.Forms.Label lblFechaSel;
        private System.Windows.Forms.BindingSource bindingSourceExpoPorSede;
        private DevExpress.XtraGrid.Columns.GridColumn colidExposicion;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaFinReplanificada;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaInicioReplanificada;
        private DevExpress.XtraGrid.Columns.GridColumn colhoraApertura;
        private DevExpress.XtraGrid.Columns.GridColumn colhoraCierre;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre2;
        private DevExpress.XtraGrid.Columns.GridColumn colidPublicoDestino;
        private DevExpress.XtraGrid.GridControl Dgv_Guias;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGuias;
        private DevExpress.XtraGrid.Columns.GridColumn coIIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreGuia;
        private DevExpress.XtraGrid.Columns.GridColumn colHorarioEmpleado;
        private DevExpress.XtraEditors.LabelControl lblConfGuiasSel;
        private DevExpress.XtraEditors.LabelControl lblConfGuias;
        private DevExpress.XtraEditors.LabelControl lblConfHoraSel;
        private DevExpress.XtraEditors.LabelControl lblConfHora;
        private DevExpress.XtraEditors.LabelControl lblConfDiaSel;
        private DevExpress.XtraEditors.LabelControl lblConfDiaVisita;
        private DevExpress.XtraEditors.LabelControl lblConfExposicionesSel;
        private DevExpress.XtraEditors.LabelControl lblConfExpo;
        private DevExpress.XtraEditors.LabelControl lblConfTipoVisitaSel;
        private DevExpress.XtraEditors.LabelControl lblTipoVisita;
        private DevExpress.XtraEditors.LabelControl lblConfSedeSel;
        private DevExpress.XtraEditors.LabelControl lblSede;
        private DevExpress.XtraEditors.LabelControl lblConfEscSel;
        private DevExpress.XtraEditors.LabelControl lblEsc;
        private DevExpress.XtraGrid.Columns.GridColumn idEscuela;
    }
}
