using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class TipoExposicion
    {
        public int idTipoExposicion { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }

        public static List<Exposicion> tipoExpoEs(List<Exposicion> expoTodas, int num)
        {
            List<Exposicion> listaDeExpos = new List<Exposicion>();

            var filtrado = expoTodas.Where(expo => expo.idTipoExposicion == num );
            foreach (Exposicion expo in filtrado)
            {
                listaDeExpos.Add(expo);
            }

            return listaDeExpos;
        }
    }
}
