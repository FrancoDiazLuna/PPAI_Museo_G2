using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class TipoVisita
    {
        public int idTipoVisita { get; set; }
        public string nombre { get; set; }



        public  List<TipoVisita> getTipoVisitas()
        {
            DataTable tiposDeVisita = new DTipoVisita().buscar();
            List<TipoVisita> tiposDeVisitaTodasList = new List<TipoVisita>();

            tiposDeVisitaTodasList = (from DataRow dr in tiposDeVisita.Rows
                                      select new TipoVisita()
                                      {
                                          idTipoVisita = Convert.ToInt32(dr["idTipoVisita"]),
                                          nombre = dr["nombre"].ToString()
                                      }
            ).ToList();

            return tiposDeVisitaTodasList;
        }

    }
}
