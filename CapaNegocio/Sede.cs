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

        public List<Sede> getSedes()
        {
            DataTable sedes = new DSede().buscar();

            List<Sede> sedesTodasList = new List<Sede>();

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
                                  idTarifa = Convert.ToInt32(dr["idTarifa"]),
                              }
            ).ToList();

            return sedesTodasList;
        }

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

            expoVigente = Exposicion.esTemporal(expoVigente);



            return expoVigente;
            //return expoFiltradaSede;
        }


        public int buscarVisitantesSimultaneos(DateTime fechaReservaNueva)
        {
            int visitantes = 0;
            Sede sede = GestorDeReserva.sedeSeleccionada;

            int idSede = sede.idSede;

            List<ReservaVisita> reservasTodas = new ReservaVisita().getReservaVisitas();


            foreach (ReservaVisita item in reservasTodas)
            {
                if (fechaReservaNueva.CompareTo(item.fechaHoraReserva) >= 0 & fechaReservaNueva.CompareTo(item.horaFinReal) <= 0)
                {
                    if (item.idSede == idSede)
                    {
                        visitantes = visitantes + item.cantidadAlumnos;
                    }
                }

            }


            return visitantes;
        }


        public static int calcularDuracionEstimada()
        {
            int duracion = Exposicion.calcularDuracionObrasExpuestas();
            return duracion;
        }

    }
}
