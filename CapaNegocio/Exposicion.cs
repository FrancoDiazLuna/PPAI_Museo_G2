using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Exposicion
    {
        public int idExposicion { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaFinReplanificada { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaInicioReplanificada { get; set; }
        public DateTime horaApertura { get; set; }
        public DateTime horaCierre { get; set; }
        public string nombre { get; set; }
        public int idTipoExposicion { get; set; }
        public int idPublicoDestino { get; set; }
        public int idEmpleadoCreo { get; set; }






        public static List<Exposicion> buscarExposicionesTemporalesVigentes(List<int> idExposiciones)
        {
            DataTable exposicionesTodas = new DExposicion().buscar();

            List<Exposicion> exposicionesTodasList = new List<Exposicion>();

            List<Exposicion> expoFiltradaSede = new List<Exposicion>();

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


            foreach (int idE in idExposiciones)
            {
                

            }

            



            return expoFiltradaSede;
        }

    }
}
