using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class GestorDeReserva
    {
        private List<NEscuela> escuelas { get; set; }
        private NEscuela escuelaSeleccionada { get; set; }

        private int cantidadVisitantes { get; set; }

        //private List<Sede> sedes { get; set; }
        //private Sede sedeSeleccionada { get; set; }

        //private List<TipoVisita> tiposDeVisita { get; set; }
        //private TipoVisita tipoDeVisitaSeleccionada { get; set; }

        //private List<Exposicion> exposiciones { get; set; }
        //private List<Exposicion> exposicionSeleccionada { get; set; }

        private DateTime fechaHoraReserva { get; set; }

        private int duracionEstimada { get; set; }

        private int visitantesSimultaneos { get; set; }

        //private List<Cargo> guias { get; set; }

        private DateTime fechaHoraActual { get; set; }

        private int numeroUnico { get; set; }

        //private Sesion sesionActual { get; set; }


    }
}
