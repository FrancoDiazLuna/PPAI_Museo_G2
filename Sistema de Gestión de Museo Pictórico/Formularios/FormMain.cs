using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnRegistrarReserva_Click(object sender, EventArgs e)
        {
            ucReservaVisitaGuiada uc = new ucReservaVisitaGuiada();
            showControl(uc);
            uc.mostrar();
        }

        public void showControl(Control control)
        {
            panelControlMain.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panelControlMain.Controls.Add(control);
        }

        private void panelControl5_Click(object sender, EventArgs e)
        {
            panelControlMain.Controls.Clear();
        }

        private void panelControl4_Click(object sender, EventArgs e)
        {
            panelControlMain.Controls.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
