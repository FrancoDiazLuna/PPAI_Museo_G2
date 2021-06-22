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


        public List<Escuela> getEscuelas()
        {
            DataTable escuelas = new DEscuela().buscar();

            List<Escuela> escuelasTodasList = new List<Escuela>();

            escuelasTodasList = (from DataRow dr in escuelas.Rows
                                 select new Escuela()
                                 {
                                     idEscuela = Convert.ToInt32(dr["idEscuela"]),
                                     domicilio = dr["domicilio"].ToString(),
                                     mail = dr["mail"].ToString(),
                                     nombre = dr["nombre"].ToString(),
                                     telefCelular = Convert.ToInt32(dr["telefCelular"]),
                                     telefFijo = Convert.ToInt32(dr["telefFijo"]),
                                 }
            ).ToList();

            return escuelasTodasList;
        }




    }
}
