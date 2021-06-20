using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TipoExposicion
    {
        public int idTipoExposicion { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }

        public TipoExposicion(int idTipoExposicion, string descripcion, string nombre)
        {
            this.idTipoExposicion = idTipoExposicion;
            this.descripcion = descripcion;
            this.nombre = nombre;
        }
    }
}
