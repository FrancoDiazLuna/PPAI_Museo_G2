using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class AsignacionVisita
    {
        public int idAsignacionVisita { get; set; }
        public DateTime fechaHoraFin { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public int idGuiaAsignado { get; set; }


    }
}
