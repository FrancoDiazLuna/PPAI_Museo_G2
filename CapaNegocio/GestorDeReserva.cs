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
        public static string tipoDeVisitaSeleccionada { get; set; }

        public static List<Exposicion> exposicionesTodasList { get; set; }

        public static List<Exposicion> exposicionesSedeList { get; set; }
        public static List<Exposicion> exposicionSeleccionada { get; set; }

        public static DateTime fechaHoraReserva { get; set; }

        public static int duracionEstimada { get; set; }

        public static int visitantesSimultaneos { get; set; }

        public static List<Empleado> guiasTodosList { get; set; }

        public static List<Empleado> guiaSeleccionado { get; set; }

        public static DateTime fechaHoraActual { get; set; }

        public static int numeroUnico { get; set; }

        public static string sesionActual { get; set; }



        public static List<Escuela> buscarEscuelas()
        {
            DataTable escuelas = new DEscuela().buscar();

            escuelasTodasList = new Escuela().getEscuelas();

            return escuelasTodasList;
        }

        public static void seleccionDeEscuela(Escuela escuela)
        {
            escuelaSeleccionada = escuela;
        }

        public static void obtenerCantidadAlumnos(int valor)
        {
            cantidadVisitantes = valor;
        }

        public static List<Sede> buscarSedes()
        {
            DataTable sedes = new DSede().buscar();

            sedesTodasList = new Sede().getSedes();

            return sedesTodasList;
        }

        public static void obtenerSedeSeleccionada(Sede sede)
        {
            sedeSeleccionada = sede;
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

        public static List<PublicoDestino> buscarPublicoDestino()
        {
            DataTable publicoDestino = new DPublicoDestino().buscar();

            List<PublicoDestino> publicoDestinoList = new List<PublicoDestino>();

            publicoDestinoList = (from DataRow dr in publicoDestino.Rows
                                  select new PublicoDestino()
                                  {
                                      idPublicoDestino = Convert.ToInt32(dr["idPublicoDestino"]),
                                      caracteristicas = dr["caracteristicas"].ToString(),
                                      nombre = dr["nombre"].ToString()
                                  }
                        ).ToList();

            return publicoDestinoList;
        }

        public static List<Exposicion> buscarExposicionesTemporalesVigentes()
        {
            //Busca el DT de la BD
            DataTable exposPorSede = new DExposicionesPorSede().buscar();

            //lista de exposiciones si estan vigentes y si son temporales
            List<Exposicion> expoTemporalesVigentes = Sede.buscarExposicionesTemporalesVigentes();

            //lista para los objetos de ExS, que voy a filtrar para hacer una lista de solo Expos con el id de Sede selecc
            List<ExposicionPorSede> listExposPorSede = new List<ExposicionPorSede>();

            //lista con id de las expo que cumplieron la condicion anterior
            List<int> listExposPorSedeSeleccionada = new List<int>();

            //Pasa a lista el DT
            listExposPorSede = (from DataRow dr in exposPorSede.Rows
                                select new ExposicionPorSede()
                                {
                                    idExposicionPorSede = Convert.ToInt32(dr["idExposicionPorSede"]),
                                    idSede = Convert.ToInt32(dr["idSede"]),
                                    idExposicion = Convert.ToInt32(dr["idExposicion"])
                                }

                            ).ToList();



            var filtrado = listExposPorSede.Where(expo => expo.idSede == sedeSeleccionada.idSede);
            foreach (ExposicionPorSede expo in filtrado)
            {
                listExposPorSedeSeleccionada.Add(expo.idExposicion);
            }


            //Estos de aca abajo hacen lo mismo, no los probe. Pero creo q funcionan

            //var filtradoDos = expoTemporalesVigentes.Where(expo => listExposPorSedeSeleccionada.Contains(expo.idExposicion));
            //foreach (Exposicion expo in filtradoDos)
            //{
            //    exposicionesSedeList.Add(expo);
            //}






            List<Exposicion> test = new List<Exposicion>();

            foreach (Exposicion expo in expoTemporalesVigentes)
            {
                foreach (var item in listExposPorSedeSeleccionada)
                {
                    if (expo.idExposicion == item)
                    {
                        test.Add(expo);
                    }
                }
            }


            exposicionesSedeList = test;

            return test;
        }

        public static string usuarioEnSesion()
        {

            string usrSesion = new Sesion().getEmpleadoEnSesion();

            return usrSesion;
        }

        public static List<Empleado> buscarGuias()
        {
            DataTable empleados = new DEmpleado().buscar();

            List<Empleado> guiasDisponibles = new List<Empleado>();

            guiasTodosList = (from DataRow dr in empleados.Rows
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

                              }
                                ).ToList();

            guiasDisponibles = Empleado.conocerCargo(guiasTodosList);

            //guiasDisponibles = Empleado.trabajaEnDiaYHorario(guiasDisponibles);

            return guiasDisponibles;
        }


        public void buscarVisitantesSimultaneosEnSede()
        {
            visitantesSimultaneos = new Sede().buscarVisitantesSimultaneos();
        }

        public bool verificarCapacidadMaxima()
        {
            if (visitantesSimultaneos + cantidadVisitantes > sedeSeleccionada.cantidadMaximaVisitantes)
            {
                return false;
            }
            return true;
        }



    }
}
