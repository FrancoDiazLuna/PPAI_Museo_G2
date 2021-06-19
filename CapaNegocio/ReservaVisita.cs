using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Museo_Pictórico.Logica
{
    public class ReservaVisita
    {
        public int idReservaVisita { get; set; }
        public int cantidadAlumno { get; set; }
        public int cantidadAlumnoConfirmada { get; set; }
        public int duracionEstimada { get; set; }
        public DateTime fechaHoraCreacion { get; set; }
        public DateTime fechaHoraReserva { get; set; }
        public string horaFinReal { get; set; }
        public string horaInicioReal { get; set; }
        public int idEscuela { get; set; }
        public int idSede { get; set; }
        public int idExposicion { get; set; }
        public int idCambioEstado { get; set; }
        public int idAsignacionGuia { get; set; }
        public int idEmpleadoCreo { get; set; }

        public ReservaVisita(int idReservaVisita, int cantidadAlumno, int cantidadAlumnoConfirmada, int duracionEstimada, DateTime fechaHoraCreacion, 
            DateTime fechaHoraReserva, string horaFinReal, string horaInicioReal, int idEscuela, int idSede, int idExposicion, int idCambioEstado, 
            int idAsignacionGuia, int idEmpleadoCreo)
        {
            this.idReservaVisita = idReservaVisita;
            this.cantidadAlumno = cantidadAlumno;
            this.cantidadAlumnoConfirmada = cantidadAlumnoConfirmada;
            this.duracionEstimada = duracionEstimada;
            this.fechaHoraCreacion = fechaHoraCreacion;
            this.fechaHoraReserva = fechaHoraReserva;
            this.horaFinReal = horaFinReal;
            this.horaInicioReal = horaInicioReal;
            this.idEscuela = idEscuela;
            this.idSede = idSede;
            this.idExposicion = idExposicion;
            this.idCambioEstado = idCambioEstado;
            this.idAsignacionGuia = idAsignacionGuia;
            this.idEmpleadoCreo = idEmpleadoCreo;
        }
    }
}
