using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string apellido { get; set; }
        public int codigoValidacion { get; set; }
        public string cuit { get; set; }
        public int dni { get; set; }
        public string domicilio { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string mail { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public int idCargo { get; set; }
        public int idHorarioEmpleado { get; set; }
        public int idSede { get; set; }




        public static int conocerCargo(Empleado empleado)
        {
            return empleado.idCargo;
        }

        public static DataTable trabajaEnDiaYHorario(Empleado empleado)
        {
            DataTable horarios = new DHorarioEmpleado().buscar();


            List<HorarioEmpleado> horariosLista = new List<HorarioEmpleado>();

            horariosLista = (from DataRow dr in horarios.Rows
                                  select new HorarioEmpleado()
                                  {
                                      idHorarioEmpleado = Convert.ToInt32(dr["idHorarioEmpleado"]),
                                      horaIngreso = Convert.ToDateTime(dr["horaIngreso"]),
                                      horaSalida = Convert.ToDateTime(dr["horaSalida"]),
                                      idDiaSemana = Convert.ToInt32(dr["idDiaSemana"])

                                  }
            ).ToList();


            DataTable dt = new DataTable();
            dt.Columns.Add("idDiaSemana", typeof(int));
            dt.Columns.Add("horaIngreso", typeof(DateTime));
            dt.Columns.Add("horaSalida", typeof(DateTime));

            DataRow row = dt.NewRow();


            foreach (HorarioEmpleado item in horariosLista)
            {

                if (item.idHorarioEmpleado == empleado.idHorarioEmpleado)
                {
                    row["idDiaSemana"] = item.idDiaSemana;
                    row["horaIngreso"] = item.horaIngreso;
                    row["horaSalida"] = item.horaSalida;

                    dt.Rows.Add(row);

                }
            }
            return dt;


        }

        public static DataTable tieneAsignacionParaDiaYHora(Empleado empleado)
        {
            DataTable asignaciones = new DAsignacionVisita().buscar();

            List<AsignacionVisita> asignacionesList = new List<AsignacionVisita>();

            asignacionesList = (from DataRow dr in asignaciones.Rows
                             select new AsignacionVisita()
                             {
                                 idAsignacionVisita = Convert.ToInt32(dr["idAsignacionVisita"]),
                                 fechaHoraFin = Convert.ToDateTime(dr["fechaHoraFin"]),
                                 fechaHoraInicio = Convert.ToDateTime(dr["fechaHoraInicio"]),
                                 idGuiaAsignado = Convert.ToInt32(dr["idGuiaAsignado"])

                             }
                             ).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("fechaHoraInicio", typeof(DateTime));
            dt.Columns.Add("fechaHoraFin", typeof(DateTime));


            foreach (AsignacionVisita item in asignacionesList)
            {
                if (item.idGuiaAsignado == empleado.idEmpleado)
                {
                    DataRow row = dt.NewRow();
                    row["fechaHoraInicio"] = item.fechaHoraInicio;
                    row["fechaHoraFin"] = item.fechaHoraFin;

                    dt.Rows.Add(row);
                }


            }

            return dt;

        }




    }
}
