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
        public static DataTable mostrar()
        {
            return new DEscuela().mostrar();
        }


    }
}
