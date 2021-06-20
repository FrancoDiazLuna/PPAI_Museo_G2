using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DetalleExposicion
    {
        public int idDetalleExposicion { get; set; }
        public int lugarAsignado { get; set; }
        public int idPared { get; set; }
        public int idObra { get; set; }

        public DetalleExposicion(int idDetalleExposicion, int lugarAsignado, int idPared, int idObra)
        {
            this.idDetalleExposicion = idDetalleExposicion;
            this.lugarAsignado = lugarAsignado;
            this.idPared = idPared;
            this.idObra = idObra;
        }
    }
}
