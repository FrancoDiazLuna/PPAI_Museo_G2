
namespace CapaNegocio
{
    partial class FormMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnRegistrarReserva = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_BuscarEscuela = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RegistrarEscuela = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BuscarReserva = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.tileNavCategory1 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.toolStripFormMain = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.toolStripFormMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.Text = "Barra de estado";
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Menú principal";
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Herramientas";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.btnRegistrarReserva);
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.btn_BuscarEscuela);
            this.panelControl2.Controls.Add(this.btn_RegistrarEscuela);
            this.panelControl2.Controls.Add(this.btn_BuscarReserva);
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(396, 566);
            this.panelControl2.TabIndex = 0;
            // 
            // btnRegistrarReserva
            // 
            this.btnRegistrarReserva.Location = new System.Drawing.Point(12, 76);
            this.btnRegistrarReserva.Name = "btnRegistrarReserva";
            this.btnRegistrarReserva.Size = new System.Drawing.Size(263, 54);
            this.btnRegistrarReserva.TabIndex = 1;
            this.btnRegistrarReserva.Text = "Registrar Reserva de Visita Guiada";
            this.btnRegistrarReserva.Click += new System.EventHandler(this.btnRegistrarReserva_Click);
            // 
            // panelControl5
            // 
            this.panelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl5.Location = new System.Drawing.Point(2, 389);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(280, 177);
            this.panelControl5.TabIndex = 1;
            this.panelControl5.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl5_Paint);
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.Location = new System.Drawing.Point(2, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(280, 70);
            this.panelControl4.TabIndex = 0;
            this.panelControl4.Click += new System.EventHandler(this.panelControl4_Click);
            // 
            // btn_BuscarEscuela
            // 
            this.btn_BuscarEscuela.Location = new System.Drawing.Point(12, 329);
            this.btn_BuscarEscuela.Name = "btn_BuscarEscuela";
            this.btn_BuscarEscuela.Size = new System.Drawing.Size(263, 54);
            this.btn_BuscarEscuela.TabIndex = 3;
            this.btn_BuscarEscuela.Text = "Buscar Escuela";
            // 
            // btn_RegistrarEscuela
            // 
            this.btn_RegistrarEscuela.Location = new System.Drawing.Point(12, 243);
            this.btn_RegistrarEscuela.Name = "btn_RegistrarEscuela";
            this.btn_RegistrarEscuela.Size = new System.Drawing.Size(263, 54);
            this.btn_RegistrarEscuela.TabIndex = 2;
            this.btn_RegistrarEscuela.Text = "Registrar Escuela";
            // 
            // btn_BuscarReserva
            // 
            this.btn_BuscarReserva.Location = new System.Drawing.Point(12, 159);
            this.btn_BuscarReserva.Name = "btn_BuscarReserva";
            this.btn_BuscarReserva.Size = new System.Drawing.Size(263, 54);
            this.btn_BuscarReserva.TabIndex = 2;
            this.btn_BuscarReserva.Text = "Buscar Reservas";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.lblTime);
            this.panelControl3.Controls.Add(this.lblDate);
            this.panelControl3.Controls.Add(this.lblUsuario);
            this.panelControl3.Controls.Add(this.svgImageBox1);
            this.panelControl3.Location = new System.Drawing.Point(2, 597);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(280, 114);
            this.panelControl3.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(137, 68);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(20, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "time";
            this.lblTime.ToolTip = "Hora actual";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(137, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(22, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "date";
            this.lblDate.ToolTip = "Fecha actual";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(137, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "usernameUser";
            this.lblUsuario.ToolTip = "Nombre del usuario con la sesion iniciada";
            this.lblUsuario.UseMnemonic = false;

            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.svgImageBox1.Location = new System.Drawing.Point(5, 5);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(111, 100);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 0;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // panelControlMain
            // 
            this.panelControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlMain.Location = new System.Drawing.Point(281, 30);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1203, 681);
            this.panelControlMain.TabIndex = 2;
            // 
            // tileNavCategory1
            // 
            this.tileNavCategory1.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Main Menu";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.toolStripFormMain);
            this.panelControl1.Controls.Add(this.panelControlMain);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1484, 711);
            this.panelControl1.TabIndex = 0;
            // 
            // toolStripFormMain
            // 
            this.toolStripFormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1});
            this.toolStripFormMain.Location = new System.Drawing.Point(2, 2);
            this.toolStripFormMain.Name = "toolStripFormMain";
            this.toolStripFormMain.Size = new System.Drawing.Size(1480, 25);
            this.toolStripFormMain.TabIndex = 3;
            this.toolStripFormMain.Text = "toolStripFormMain";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Ayuda";
            this.toolStripLabel1.ToolTipText = "Acerca de";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Museo Pictórico";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.toolStripFormMain.ResumeLayout(false);
            this.toolStripFormMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_BuscarEscuela;
        private DevExpress.XtraEditors.SimpleButton btn_RegistrarEscuela;
        private DevExpress.XtraEditors.SimpleButton btn_BuscarReserva;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ToolStrip toolStripFormMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnRegistrarReserva;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}