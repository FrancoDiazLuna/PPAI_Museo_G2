using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PublicoDestino
    {
        public int idPublicoDestino { get; set; }
        public string caracteristicas { get; set; }
        public string nombre { get; set; }

        public PublicoDestino(int idPublicoDestino, string caracteristicas, string nombre)
        {
            this.idPublicoDestino = idPublicoDestino;
            this.caracteristicas = caracteristicas;
            this.nombre = nombre;
        }
    }
}
