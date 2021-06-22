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
        
        public void mostrarEscuela()
        {
            escuelaBindingSource.DataSource = GestorDeReserva.buscarEscuelas();
        }

        private void tomarSeleccionDeEscuela(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Escuela esc = (Escuela)gridEscuelas.GetFocusedRow();
            lblEscSel.Text = esc.nombre;
            GestorDeReserva.seleccionDeEscuela(esc);
        }

        //tomarCantidadDeVisitantes
        private void spinCantVisitantes_EditValueChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(spinCantVisitantes.Text);
            GestorDeReserva.obtenerCantidadAlumnos(valor);
        }

        public void mostrarSede()
        {
            sedeBindingSource.DataSource = GestorDeReserva.buscarSedes();
        }

        public DataTable dt;
        public DataTable llenarGridExpoPublico()
        {
            dt = new DataTable();

            dt.Columns.Add("Id Exposicion");
            dt.Columns.Add("Fecha Fin", typeof(DateTime));
            dt.Columns.Add("Fecha Fin Replanificada", typeof(DateTime));
            dt.Columns.Add("Fecha Inicio", typeof(DateTime));
            dt.Columns.Add("Fecha Inicio Replanificada", typeof(DateTime));
            dt.Columns.Add("Hora Apertura", typeof(DateTime));
            dt.Columns.Add("Hora Cierre", typeof(DateTime));
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Publico Destino");

            List<Exposicion> exposicionesList = GestorDeReserva.buscarExposicionesTemporalesVigentes();
            List<PublicoDestino> publicoDestinoList = GestorDeReserva.buscarPublicoDestino();

            foreach (Exposicion exposicion in exposicionesList)
            {
                DataRow row = dt.NewRow();

                row["Id Exposicion"] = exposicion.idExposicion;
                row["Fecha Fin"] = exposicion.fechaFin;
                row["Fecha Fin Replanificada"] = exposicion.fechaFinReplanificada;
                row["Fecha Inicio"] = exposicion.fechaInicio;
                row["Fecha Inicio Replanificada"] = exposicion.fechaInicioReplanificada;
                row["Hora Apertura"] = exposicion.horaApertura;
                row["Hora Cierre"] = exposicion.horaCierre;
                row["Nombre"] = exposicion.nombre;
                foreach (PublicoDestino publicoDestino in publicoDestinoList)
                {
                    if (publicoDestino.idPublicoDestino == exposicion.idPublicoDestino)
                    {
                        row["Publico Destino"] = publicoDestino.nombre;
                    }
                }

                dt.Rows.Add(row);
            }

            return dt;
        }

        private void tomarSeleccionDeSede(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Sede sede = (Sede)gridSedes.GetFocusedRow();
            lblSedeSel.Text = sede.nombre;
            GestorDeReserva.obtenerSedeSeleccionada(sede);
            //exposicionBindingSource.DataSource = GestorDeReserva.buscarExposicionesTemporalesVigentes();
            //bindingSourceExpoPorSede.DataSource = llenarGridExpoPublico();
        }

        public void mostrarTipoDeVisita()
        {
            List<TipoVisita> vi = GestorDeReserva.buscarVisitas();
            foreach (TipoVisita item in vi)
            {
                this.cmbTipoVisita.Items.Add(item.nombre);
            }
            //exposicionBindingSource.DataSource = Sede.buscarExposicionesTemporalesVigentes();
            //empleadoBindingSource.DataSource = GestorDeReserva.buscarGuias();
        }

        //tomarSeleccionTipoDeVisita
        private void cmbTipoVisita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVisita.SelectedIndex == 0)
            {
                bindingSourceExpoPorSede.DataSource = null;
                MessageBox.Show("No existen exposiciones para el tipo de visita seleccionado.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //bindingSourceExpoPorSede.DataSource = llenarGridExpoPublico();
                refrescarGridExposiciones();
            }
        }

        public void refrescarGridExposiciones()
        {
            bindingSourceExpoPorSede.DataSource = llenarGridExpoPublico();
        }

        public void mostrarGuias()
        {
            empleadoBindingSource.DataSource = GestorDeReserva.buscarGuias();
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

            if (pag == tabNav3_Visita_Exposiciones)
            {
                if (sedeFlag && expoFlag)
                    refrescarGridExposiciones();
                sedeFlag = false;
                expoFlag = true;
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

        bool sedeFlag = false;
        bool expoFlag = false;
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            tabPane1.SelectPrevPage();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            var pag = tabPane1.SelectedPage;
            if (pag == tabNav1_Escuelas)
            {
                if (lblEscSel.Text == "")
                {
                    MessageBox.Show("Debe seleccionar la escuela que realizará la visita.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (spinCantVisitantes.Value <= 0)
                {
                    MessageBox.Show("Debe ingresar una cantidad de visitantes válida.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tabPane1.SelectNextPage();
                }
            }
            else if (pag == tabNav2_Sedes)
            {
                if (lblSedeSel.Text == "")
                {
                    MessageBox.Show("Debe seleccionar una sede a visitar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sedeFlag = true;
                    tabPane1.SelectNextPage();
                }
            }
            else if (pag == tabNav3_Visita_Exposiciones)
            {
                if (cmbTipoVisita.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de visita a realizar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tabPane1.SelectNextPage();
                }
            }
            else if (pag == tabNav4_DiaVisita)
            {
                solicitarFechaHora();
            }
            else
            {
                tabPane1.SelectNextPage();
            }

        }

        private void solicitarFechaHora()
        {
            if (lblFechaSel.Text == "")
            {
                MessageBox.Show("Debe seleccionar una fecha para realizar la visita.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbHorarioSel.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un horario para realizar la visita.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabPane1.SelectNextPage();
                //aca manda la fecha y hora
                var fechaHora = DateTime.Parse(lblFechaSel.Text + " " + cmbHorarioSel.Text);
                GestorDeReserva.seleccionFechaHora(fechaHora);
            }
        }

        private void calendarControl1_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(calendarControl1.SelectionStart.ToLongDateString());
            DateTime actual = DateTime.Now;
            if (fecha.CompareTo(actual) >= 0) 
            {
                lblFechaSel.Enabled = false;
                lblFechaSel.Text = calendarControl1.SelectionStart.ToLongDateString();
            } else
            {
                lblFechaSel.Text = "";
            }
        }

        private void btn_confirmarReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La reserva se registró con exito. \nEl estado actual de la misma es ahora Pendiente de Confirmación", "Confirmación de reserva de visita guiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabPane1.Visible = false;
        }

        public List<Exposicion> exposicionesSeleccionadas()
        {
            int bandera = 0;

            List<Exposicion> exposicionesSeleccionadas = new List<Exposicion>();

            List<Exposicion> expoDeGrid = GestorDeReserva.exposicionesSedeList;

            List<int> indices = gridExposiciones.GetSelectedRows().ToList();

            foreach (var item in expoDeGrid)
            {
                if (indices.Contains(bandera))
                {
                    exposicionesSeleccionadas.Add(item);
                    MessageBox.Show("Si");
                }
                bandera = bandera + 1;
            }
            return exposicionesSeleccionadas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exposicionesSeleccionadas();
        }
    }
}
