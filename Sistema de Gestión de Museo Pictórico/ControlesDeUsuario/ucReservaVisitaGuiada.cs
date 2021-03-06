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
        public DataTable dt;
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
            //escuelaBindingSource.DataSource = GestorDeReserva.buscarEscuelas();

            List<Escuela> lista = GestorDeReserva.buscarEscuelas();

            foreach (var item in lista)
            {
                gridEscuelas.AddNewRow();

                int rowHandle = gridEscuelas.GetRowHandle(gridEscuelas.DataRowCount);
                if (gridEscuelas.IsNewItemRow(rowHandle))
                {
                    gridEscuelas.SetRowCellValue(rowHandle, gridEscuelas.Columns[0], item.nombre); // Nombre
                    gridEscuelas.SetRowCellValue(rowHandle, gridEscuelas.Columns[1], item.domicilio); // Domicilio
                    gridEscuelas.SetRowCellValue(rowHandle, gridEscuelas.Columns[2], item.mail); // Mail
                    gridEscuelas.SetRowCellValue(rowHandle, gridEscuelas.Columns[3], item.telefFijo); // Teléfono
                    gridEscuelas.SetRowCellValue(rowHandle, gridEscuelas.Columns[4], item.telefCelular); // Celular
                    gridEscuelas.SetRowCellValue(rowHandle, gridEscuelas.Columns[5], item.idEscuela);
                }
            }
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
            GestorDeReserva.cantidadDeVisitantes(valor);
        }

        public void mostrarSede()
        {
            sedeBindingSource.DataSource = GestorDeReserva.buscarSedes();
        }

        private void tomarSeleccionDeSede(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Sede sede = (Sede)gridSedes.GetFocusedRow();
            lblSedeSel.Text = sede.nombre;
            GestorDeReserva.seleccionDeSede(sede);

        }

        public void mostrarTipoDeVisita()
        {
            List<TipoVisita> vi = GestorDeReserva.buscarTipoDeVisitas();
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
                //bindingSourceExpoPorSede.DataSource = mostrarExposicionesEemporalesVigentes();
                refrescarGridExposiciones();
                GestorDeReserva.seleccionTipoVisita("Por exposición");
            }
        }


        public void mostrarExposicionesEemporalesVigentes()
        {
            // acomodar
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
                }
                bandera = bandera + 1;
            }
            return exposicionesSeleccionadas;
        }


        private void tomarSeleccionExposicionesTemporalesVigentes()
        {
            List<Exposicion> exposSeleccionadas = exposicionesSeleccionadas();
            GestorDeReserva.seleccionExposicionesTemporalesVigentes(exposSeleccionadas);
            GestorDeReserva.calcularDuracionEstimada();
        }


        public List<Empleado> guiasSeleccionados()
        {
            int bandera = 0;

            List<Empleado> empleadoSeleccionadas = new List<Empleado>();

            List<Empleado> expoDeEmp = GestorDeReserva.buscarGuiasDisponibles();

            List<int> indices = gridGuias.GetSelectedRows().ToList();

            foreach (var item in expoDeEmp)
            {
                if (indices.Contains(bandera))
                {
                    empleadoSeleccionadas.Add(item);
                    //MessageBox.Show("Si");
                }
                bandera = bandera + 1;
            }
            return empleadoSeleccionadas;
        }

        private void tomarSeleccionGuias()
        {
            List<Empleado> empSeleccionadas = guiasSeleccionados();
            //MessageBox.Show(empSeleccionadas.Count.ToString());
            GestorDeReserva.seleccionGuiasDisponiles(empSeleccionadas);
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
                //tabPane1.SelectNextPage();
                //aca manda la fecha y hora
                var fechaHora = DateTime.Parse(lblFechaSel.Text + " " + cmbHorarioSel.Text);
                GestorDeReserva.seleccionFechaHora(fechaHora); 
                txt_CantGuias.Text = GestorDeReserva.calcularGuiasNecesarios().ToString();

                bool test = new GestorDeReserva().verificarCapacidadMaxima();
                
                //MessageBox.Show(test1.ToString());
                //MessageBox.Show(test.ToString());
                mostrarGuias();

                if (test)
                {
                    //tomarSeleccionGuias();
                    tabPane1.SelectNextPage();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha u horario distinto ya que la capacidad de la sede se excede.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        public void refrescarGridExposiciones()
        {
            bindingSourceExpoPorSede.DataSource = GestorDeReserva.buscarExposicionesTemporalesVigentes();
        }

        public void mostrarGuias()
        {
            empleadoBindingSource.DataSource = GestorDeReserva.buscarGuiasDisponibles();
            //List<Empleado> lista = GestorDeReserva.buscarGuiasDisponibles();

            //foreach (var item in lista)
            //{
            //    gridGuias.AddNewRow();

            //    int rowHandle = gridGuias.GetRowHandle(gridGuias.DataRowCount);
            //    if (gridGuias.IsNewItemRow(rowHandle))
            //    {
            //        gridGuias.SetRowCellValue(rowHandle, gridGuias.Columns[1], item.apellido);
            //        gridGuias.SetRowCellValue(rowHandle, gridGuias.Columns[2], item.nombre);
            //        gridGuias.SetRowCellValue(rowHandle, gridGuias.Columns[3], item.idHorarioEmpleado.ToString());
            //    }
            //}

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

                //cargo labels de confirmacion
                lblConfEscSel.Text = lblEscSel.Text;
                lblConfSedeSel.Text = lblSedeSel.Text;
                lblConfTipoVisitaSel.Text = cmbTipoVisita.SelectedItem.ToString();
                var lista = GestorDeReserva.exposicionSeleccionada;
                string expoSel = "";
                foreach (var item in lista)
                {
                    expoSel += item.nombre;
                    expoSel += "; ";
                }
                lblConfExposicionesSel.Text = expoSel;//"exposiciones listado (agregar)";
                lblConfDiaSel.Text = lblFechaSel.Text;
                lblConfHoraSel.Text = cmbHorarioSel.Text;
                var lista2 = GestorDeReserva.guiaSeleccionado; string guiasSel = ""; foreach (var item in lista2) { guiasSel += item.nombre; guiasSel += "; "; }
                lblConfGuiasSel.Text = guiasSel;

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
                else if (gridExposiciones.SelectedRowsCount == 0)
                {
                    MessageBox.Show("Debe ingresar al menos una exposicion.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tabPane1.SelectNextPage();
                    tomarSeleccionExposicionesTemporalesVigentes();
                }
            }
            else if (pag == tabNav4_DiaVisita)
            {
                solicitarFechaHora();
            }
            else if (pag == tabNav5_Guia)
            {
                
                if (gridGuias.SelectedRowsCount == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un guía para realizar la visita.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tomarSeleccionGuias();
                    tabPane1.SelectNextPage();
                }
            }
            else
            {
                tabPane1.SelectNextPage();
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
            GestorDeReserva.getFechaActual();
            GestorDeReserva.registrarReserva();
            MessageBox.Show("La reserva se registró con exito. \nEl estado actual de la misma es ahora Pendiente de Confirmación", "Confirmación de reserva de visita guiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabPane1.Visible = false;
            btn_cancelar.Visible = false;
            btn_anterior.Visible = false;
            btn_siguiente.Visible = false;
            btn_confirmarReserva.Visible = false;
        }


    }
}
