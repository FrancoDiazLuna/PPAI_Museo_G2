using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace Sistema_de_Gestión_de_Museo_Pictórico
{
    public partial class ucReservaVisitaGuiada : UserControl
    {
        public ucReservaVisitaGuiada()
        {
            InitializeComponent();
        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {
            ucReservaVisitaGuiada uc = new ucReservaVisitaGuiada();
            showControl(uc);
        }

        public void showControl(Control control)
        {
            tabPane1.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            tabPane1.Controls.Add(control);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro desea descartar la reserva de la visita guiada?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        public void mostrar()
        {
            this.dgvEscuelas.DataSource = NEscuela.mostrar();
        }
    }
    
}
