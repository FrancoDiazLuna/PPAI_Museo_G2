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
            uc.mostrarEscuela();
            uc.mostrarSede();
            uc.mostrarTipoDeVisita();

            
        }

        public void showControl(Control control)
        {
            limpiarPanelPrincipal();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panelControlMain.Controls.Add(control);
        }

        private void limpiarPanelPrincipal()
        {
            panelControlMain.Controls.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            lblUsuario.Text = "LMessi";
            GestorDeReserva.usuarioEnSesion();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void panelControl4_Click(object sender, EventArgs e)
        {
            limpiarPanelPrincipal();
        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {
            limpiarPanelPrincipal();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UTN FRC - Cátedra de Diseño de Sistemas \n PPAI: Museo Pictórico " +
                "\n\n\t Grupo Nº 2 (Bazinga) \n\n 1° Entrega - Implementación del caso de uso modelado" +
                "\n Caso de Uso 92: Registrar Reserva de Visita Guiada", "Acerca del Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
