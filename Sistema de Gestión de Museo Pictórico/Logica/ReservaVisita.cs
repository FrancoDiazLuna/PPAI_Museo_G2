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
    }
}
