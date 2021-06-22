using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static List<Obra> obrasTodasList { get; set; }



        public List<Obra> buscarObras()
         {
            List<Obra> obras = new List<Obra>();

            obras = new Obra().getObras();

            return obras;
         }
   }
}
