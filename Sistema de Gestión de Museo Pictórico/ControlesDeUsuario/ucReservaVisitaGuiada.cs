﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaNegocio
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
            if (MessageBox.Show("¿Está seguro desea descartar la reserva de la visita guiada?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
        
        public void mostrar()
        {
            escuelaBindingSource.DataSource = GestorDeReserva.buscarEscuelas();
            sedeBindingSource.DataSource = GestorDeReserva.buscarSedes();
            List<TipoVisita> vi = GestorDeReserva.buscarVisitas();
            foreach (TipoVisita item in vi)
            {
                this.cmbTipoVisita.Items.Add(item.nombre);
            }
            
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            tabPane1.SelectPrevPage() ;
            
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            var pag = tabPane1.SelectedPage;
            if (pag == tabNav1_Escuelas)
            {
                btn_anterior.Visible = false;
            }
            else
            {
                btn_anterior.Visible = true;
            }
                

            if (pag == tabNav6_DetalleReserva)
            {
                btn_siguiente.Visible = false;
                btn_confirmarReserva.Visible = true;
            }
            else
            {
                btn_siguiente.Visible = true;
                btn_confirmarReserva.Visible = false;
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            var pag = tabPane1.SelectedPage;
            if (pag == tabNav1_Escuelas)
            {
                if (lblEscSel.Text == "" )
                {
                    MessageBox.Show("Debe seleccionar la escuela que realizará la visita guiada.", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                } else if (spinCantVisitantes.Value <= 0) {
                    MessageBox.Show("Debe ingresar una cantidad de visitantes valida.", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                } else {
                    tabPane1.SelectNextPage();
                }
            } else if (pag == tabNav2_Sedes) {
                if (lblSedeSel.Text == "")
                {
                    MessageBox.Show("Debe seleccionar una sede a visitar.", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                } else
                {
                    tabPane1.SelectNextPage();
                }
            }
            else
            {
                tabPane1.SelectNextPage();
            }

        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(spinCantVisitantes.Text);
            GestorDeReserva.obtenerCantidadAlumnos(valor);
        }

        private void seleccionDeEscuela(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Escuela esc = (Escuela)gridEscuelas.GetFocusedRow();
            lblEscSel.Text = esc.nombre;
            GestorDeReserva.obtenerEscuelaSeleccionada(esc);
        }

        private void seleccionDeSede(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Sede sede = (Sede)gridSedes.GetFocusedRow();
            lblSedeSel.Text = sede.nombre;
            GestorDeReserva.obtenerSedeSeleccionada(sede);
        }

    }
    
}
