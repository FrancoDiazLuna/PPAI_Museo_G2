using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Sede
    {
        public int idSede { get; set; }
        public int cantidadMaximaVisitantes { get; set; }
        public int cantidadMaxPorGuia { get; set; }
        public string nombre { get; set; }
        public int idDeposito { get; set; }
        public int idHorario { get; set; }
        public int idColeccion { get; set; }
        public int idTarifa { get; set; }

        public static List<Exposicion> buscarExposicionesTemporalesVigentes()
        {
            DataTable exposicionesTodas = new DExposicion().buscar();

            List<Exposicion> exposicionesTodasList = new List<Exposicion>();

            List<Exposicion> expoVigente = new List<Exposicion>();

            //List<Exposicion> expoFiltradaSede = new List<Exposicion>();

            exposicionesTodasList = (from DataRow dr in exposicionesTodas.Rows
                                     select new Exposicion()
                                     {
                                         idExposicion = Convert.ToInt32(dr["idExposicion"]),
                                         fechaFin = Convert.ToDateTime(dr["fechaFin"]),
                                         fechaFinReplanificada = Convert.ToDateTime(dr["fechaFinReplanificada"]),
                                         fechaInicio = Convert.ToDateTime(dr["fechaInicio"]),
                                         fechaInicioReplanificada = Convert.ToDateTime(dr["fechaInicioReplanificada"]),
                                         horaApertura = Convert.ToDateTime(dr["horaApertura"]),
                                         horaCierre = Convert.ToDateTime(dr["horaCierre"]),
                                         nombre = dr["nombre"].ToString(),
                                         idTipoExposicion = Convert.ToInt32(dr["idTipoExposicion"]),
                                         idPublicoDestino = Convert.ToInt32(dr["idPublicoDestino"]),
                                         idEmpleadoCreo = Convert.ToInt32(dr["idEmpleadoCreo"])
                                     }
                                    ).ToList();


            expoVigente = Exposicion.esVigente(exposicionesTodasList);

            return expoVigente;
            //return expoFiltradaSede;
        }

    }
}
