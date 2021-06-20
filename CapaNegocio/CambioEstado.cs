using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CambioEstado
    {
        public int idCambioEstado { get; set; }
        public DateTime fechaHoraFin { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public int idEstado { get; set; }

        public CambioEstado(int idCambioEstado, DateTime fechaHoraFin, DateTime fechaHoraInicio, int idEstado)
        {
            this.idCambioEstado = idCambioEstado;
            this.fechaHoraFin = fechaHoraFin;
            this.fechaHoraInicio = fechaHoraInicio;
            this.idEstado = idEstado;
        }
    }
}
