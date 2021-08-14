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




        public static List<Exposicion> buscarExposicionTemporalVigente(Sede sedeSelecc)
        {
            DataTable exposicionesTodas = new DExposicion().buscar();
            DataTable exposPorSede = new DExposicionesPorSede().buscar();


            List<Exposicion> exposicionesTodasList = new List<Exposicion>();


            //lista de exposiciones si estan vigentes y si son temporales
            List<Exposicion> expoVigenteYTemporal = new List<Exposicion>();


            //lista para los objetos de ExS, que voy a filtrar para hacer una lista de solo Expos con el id de Sede selecc
            List<ExposicionPorSede> listExposPorSede = new List<ExposicionPorSede>();

            //lista con id de las expo que cumplieron la condicion anterior
            List<int> listExposPorSedeSeleccionada = new List<int>();

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



            foreach (Exposicion item in exposicionesTodasList)
            {
                if (Exposicion.esVigente(item) && Exposicion.esTemporal(item))
                {
                    expoVigenteYTemporal.Add(item);
                }
            }


            listExposPorSede = (from DataRow dr in exposPorSede.Rows
                                select new ExposicionPorSede()
                                {
                                    idExposicionPorSede = Convert.ToInt32(dr["idExposicionPorSede"]),
                                    idSede = Convert.ToInt32(dr["idSede"]),
                                    idExposicion = Convert.ToInt32(dr["idExposicion"])
                                }

                            ).ToList();



            var filtrado = listExposPorSede.Where(expo => expo.idSede == sedeSelecc.idSede);
            foreach (ExposicionPorSede expo in filtrado)
            {
                listExposPorSedeSeleccionada.Add(expo.idExposicion);
            }


            List<Exposicion> exposicionesSedeLista = new List<Exposicion>();

            foreach (Exposicion expo in expoVigenteYTemporal)
            {
                foreach (var item in listExposPorSedeSeleccionada)
                {
                    if (expo.idExposicion == item)
                    {
                        exposicionesSedeLista.Add(expo);
                    }
                }
            }

            return exposicionesSedeLista;

        }


        public static DataTable obtenerPublicoDestino(List<Exposicion> exposicionesSedeList)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id Exposicion");
            dt.Columns.Add("Fecha Fin", typeof(DateTime));
            dt.Columns.Add("Fecha Fin Replanificada", typeof(DateTime));
            dt.Columns.Add("Fecha Inicio", typeof(DateTime));
            dt.Columns.Add("Fecha Inicio Replanificada", typeof(DateTime));
            dt.Columns.Add("Hora Apertura", typeof(DateTime));
            dt.Columns.Add("Hora Cierre", typeof(DateTime));
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Publico Destino");

            foreach (Exposicion exposicion in exposicionesSedeList)
            {
                dt.Rows.Add(Exposicion.getPublicoDestino(exposicion, dt));
            }

            return dt;

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


        public static int calcularDuracionEstimada(List<Exposicion> exposicionSeleccionada)
        {

            int duracion = 0;


            foreach (Exposicion item in exposicionSeleccionada)
            {
                duracion = duracion + Exposicion.calcularDuracionObrasExpuestas(item.idExposicion);
            }

            return duracion;
        }

        public static List<Empleado> guiasDisponibles()
        {
            DataTable empleadosTodos = new DEmpleado().buscar();

            List<Empleado> empleadosTodosList = new List<Empleado>();

            empleadosTodosList = (from DataRow dr in empleadosTodos.Rows
                                  select new Empleado()
                                  {
                                      idEmpleado = Convert.ToInt32(dr["idEmpleado"]),
                                      apellido = dr["apellido"].ToString(),
                                      codigoValidacion = Convert.ToInt32(dr["codigoValidacion"]),
                                      cuit = dr["cuit"].ToString(),
                                      dni = Convert.ToInt32(dr["dni"]),
                                      domicilio = dr["domicilio"].ToString(),
                                      fechaIngreso = Convert.ToDateTime(dr["fechaIngreso"]),
                                      fechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"]),
                                      mail = dr["mail"].ToString(),
                                      nombre = dr["nombre"].ToString(),
                                      sexo = dr["sexo"].ToString(),
                                      telefono = dr["telefono"].ToString(),
                                      idCargo = Convert.ToInt32(dr["idCargo"]),
                                      idHorarioEmpleado = Convert.ToInt32(dr["idHorarioEmpleado"]),
                                      idSede = Convert.ToInt32(dr["idEmpleadoCreo"])

                                  }
                                    ).ToList();



            List<Empleado> guiasDisponibles = new List<Empleado>();

            foreach (Empleado item in empleadosTodosList)
            {
                if (Empleado.conocerCargo(item)==1 && 
                    Empleado.trabajaEnDiaYHorario(item) == false 
                    && Empleado.tieneAsignacionParaDiaYHora(item) == false)   //si es guia - si trabaja en dia y horario - si no tiene asignacion
                {
                    guiasDisponibles.Add(item);
                }
                
            }

            return guiasDisponibles;

        }



    }
}
