using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class GestorDeReserva
    {
        public static List<Escuela> escuelasTodasList { get; set; }
        public static Escuela escuelaSeleccionada { get; set; }

        public static int cantidadVisitantes { get; set; }

        public static List<Sede> sedesTodasList { get; set; }
        public static Sede sedeSeleccionada { get; set; }

        public static List<TipoVisita> tiposDeVisitaTodasList { get; set; }
        public static TipoVisita tipoDeVisitaSeleccionada { get; set; }

        public static List<Exposicion> exposicionesTodasList { get; set; }
        public static List<Exposicion> exposicionSeleccionada { get; set; }

        public static DateTime fechaHoraReserva { get; set; }

        public static int duracionEstimada { get; set; }

        public static int visitantesSimultaneos { get; set; }

        public static List<Cargo> guias { get; set; }

        public static DateTime fechaHoraActual { get; set; }

        public static int numeroUnico { get; set; }

        public static Sesion sesionActual { get; set; }



        public static List<Escuela> buscarEscuelas()
        {
            DataTable escuelas = new DEscuela().buscar();

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



        public static void obtenerCantidadAlumnos(int valor)
        {
            cantidadVisitantes = valor;
        }


        //buscar la escuela a paartir de id?¿

        public static List<Sede> buscarSedes()
        {
            DataTable sedes = new DSede().buscar();

            sedesTodasList = (from DataRow dr in sedes.Rows
                              select new Sede()
                              {
                                  idSede = Convert.ToInt32(dr["idSede"]),
                                  cantidadMaximaVisitantes = Convert.ToInt32(dr["cantidadMaximaVisitantes"]),
                                  cantidadMaxPorGuia = Convert.ToInt32(dr["cantidadMaxPorGuia"]),
                                  nombre = dr["nombre"].ToString(),
                                  idDeposito = Convert.ToInt32(dr["idDeposito"]),
                                  idHorario = Convert.ToInt32(dr["idHorario"]),
                                  idColeccion = Convert.ToInt32(dr["idColeccion"]),
                                  idExposicion = Convert.ToInt32(dr["idExposicion"]),
                                  idTarifa = Convert.ToInt32(dr["idTarifa"]),
                              }                              
            ).ToList();

            return sedesTodasList;
        }

        public static List<TipoVisita> buscarVisitas()
        {
            DataTable tiposDeVisita = new DTipoVisita().buscar();

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
