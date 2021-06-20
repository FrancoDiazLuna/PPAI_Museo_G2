using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Escuela
    {
        public int idEscuela { get; set; }
        public string domicilio { get; set; }
        public string mail { get; set; }
        public string nombre { get; set; }
        public int telefCelular { get; set; }
        public int telefFijo { get; set; }

        public static DataTable mostrar()
        {
            return new DEscuela().mostrar();
        }


    }
}
