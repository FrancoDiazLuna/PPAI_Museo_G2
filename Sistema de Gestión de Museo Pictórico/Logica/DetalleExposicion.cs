using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Museo_Pictórico.Logica
{
    public class DetalleExposicion
    {
        public int idDetalleExposicion { get; set; }
        public int lugarAsignado { get; set; }
        public int idPared { get; set; }
        public int idObra { get; set; }
    }
}
