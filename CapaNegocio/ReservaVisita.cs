using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ReservaVisita
    {
        public int idReservaVisita { get; set; }
        public int cantidadAlumnos { get; set; }
        public int cantidadAlumnosConfirmada { get; set; }
        public int duracionEstimada { get; set; }
        public DateTime fechaHoraCreacion { get; set; }
        public DateTime fechaHoraReserva { get; set; }
        public DateTime horaFinReal { get; set; }
        public DateTime horaInicioReal { get; set; }
        public int idEscuela { get; set; }
        public int idSede { get; set; }
        public int idExposicion { get; set; }
        public int idCambioEstado { get; set; }
        public int idAsignacionGuia { get; set; }
        public int idEmpleadoCreo { get; set; }

        public List<ReservaVisita> getReservaVisitas()
        {
            DataTable reservasDT = new DReservaVisita().buscar();

            List<ReservaVisita> reservaVisitaTodasList = new List<ReservaVisita>();

            reservaVisitaTodasList = (from DataRow dr in reservasDT.Rows
                              select new ReservaVisita()
                              {
                                  idReservaVisita = Convert.ToInt32(dr["idReservaVisita"]),
                                  cantidadAlumnos = Convert.ToInt32(dr["cantidadAlumnos"]),
                                  cantidadAlumnosConfirmada = Convert.ToInt32(dr["cantidadAlumnosConfirmada"]),
                                  duracionEstimada = Convert.ToInt32(dr["duracionEstimada"]),
                                  fechaHoraCreacion = Convert.ToDateTime(dr["fechaHoraCreacion"]),
                                  fechaHoraReserva = Convert.ToDateTime(dr["fechaHoraReserva"]),
                                  horaFinReal = Convert.ToDateTime(dr["horaFinReal"]),
                                  horaInicioReal = Convert.ToDateTime(dr["horaInicioReal"]),
                                  idEscuela = Convert.ToInt32(dr["idEscuela"]),
                                  idSede = Convert.ToInt32(dr["idSede"]),
                                  idExposicion = Convert.ToInt32(dr["idExposicion"]),
                                  idCambioEstado = Convert.ToInt32(dr["idCambioEstado"]),
                                  idAsignacionGuia = Convert.ToInt32(dr["idAsignacionGuia"]),
                                  idEmpleadoCreo = Convert.ToInt32(dr["idEmpleadoCreo"])
                              }
            ).ToList();


            return reservaVisitaTodasList;
        }
    }
}
