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

        public static List<Exposicion> exposicionesSedeList { get; set; }
        public static List<Exposicion> exposicionSeleccionada { get; set; }

        public static DateTime fechaHoraReserva { get; set; }

        public static int duracionEstimada { get; set; }

        public static int visitantesSimultaneos { get; set; }

        public static List<Empleado> guiasDeLaSede { get; set; }

        public static List<Empleado> guiaSeleccionado { get; set; }

        public static DateTime fechaHoraActual { get; set; }

        public static int numeroUnico { get; set; }

        public static string sesionActual { get; set; }















        public static List<Escuela> buscarEscuelas()
        {

                DataTable escuelas = new DEscuela().buscar();

                List<Escuela> escuelasTodasLista = new List<Escuela>();

                escuelasTodasLista = (from DataRow dr in escuelas.Rows
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

                escuelasTodasList = escuelasTodasLista;
                return escuelasTodasLista;
            
        }

        public static void seleccionDeEscuela(Escuela escuela)
        {
            escuelaSeleccionada = escuela;
        }

        public static void cantidadDeVisitantes(int valor)
        {
            cantidadVisitantes = valor;
        }

        public static List<Sede> buscarSedes()
        {
            DataTable sedes = new DSede().buscar();

            List<Sede> sedesTodasLista = new List<Sede>();

            sedesTodasLista = (from DataRow dr in sedes.Rows
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


            sedesTodasList = sedesTodasLista;
            return sedesTodasLista;
        }
        public static void seleccionDeSede(Sede sede)
        {
            sedeSeleccionada = sede;
        }

        public static List<TipoVisita> buscarTipoDeVisitas()
        {
            DataTable tiposDeVisita = new DTipoVisita().buscar();
            List<TipoVisita> tiposDeVisitaTodasLista = new List<TipoVisita>();

            tiposDeVisitaTodasLista = (from DataRow dr in tiposDeVisita.Rows
                                      select new TipoVisita()
                                      {
                                          idTipoVisita = Convert.ToInt32(dr["idTipoVisita"]),
                                          nombre = dr["nombre"].ToString()
                                      }
            ).ToList();


            tiposDeVisitaTodasList = tiposDeVisitaTodasLista;
            return tiposDeVisitaTodasLista;
        }

        public static void seleccionTipoVisita(string tipoVdisita)
        {
            tipoDeVisitaSeleccionada = tipoVdisita;
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


            List<Exposicion> exposicionesSedeLista = new List<Exposicion>();

            foreach (Exposicion expo in expoTemporalesVigentes)
            {
                foreach (var item in listExposPorSedeSeleccionada)
                {
                    if (expo.idExposicion == item)
                    {
                        exposicionesSedeLista.Add(expo);
                    }
                }
            }


            exposicionesSedeList = exposicionesSedeLista;

            return exposicionesSedeLista;
        }

        public static void seleccionExposicionesTemporalesVigentes(List<Exposicion> lista)
        {
            exposicionSeleccionada = lista;
        }

        public static void seleccionFechaHora(DateTime valor)
        {
            fechaHoraReserva = valor;
        }












        public void  calcularDuracionEstimada()
        {
            duracionEstimada = Sede.calcularDuracionEstimada(exposicionSeleccionada);

        }


        public static void buscarVisitantesSimultaneosEnSede()
        {
            visitantesSimultaneos = new Sede().buscarVisitantesSimultaneos(fechaHoraReserva);
        }

        public bool verificarCapacidadMaxima()
        {
            buscarVisitantesSimultaneosEnSede();

            if (visitantesSimultaneos + cantidadVisitantes > sedeSeleccionada.cantidadMaximaVisitantes)
            {
                return false;
            }
            return true;
        }

        //buscarGuiasDisponibles

        public static List<Empleado> buscarGuiasDisponibles()
        {
            List<Empleado> guiasTodos = Sede.guiasDisponibles();

            List<Empleado> guiasDeSede = new List<Empleado>();


            foreach (Empleado item in guiasTodos)
            {
                if (item.idSede == sedeSeleccionada.idSede)
                {
                    guiasDeSede.Add(item);
                }
            }


            guiasDeLaSede = guiasDeSede;

            return guiasDeSede;

        }

        public static void seleccionGuiasDisponiles(List<Empleado> lista)
        {

            guiaSeleccionado = lista;
           
        }

        public static int calcularGuiasNecesarios()
        {
            int resto = (cantidadVisitantes % sedeSeleccionada.cantidadMaxPorGuia);
            int cantidad = (cantidadVisitantes / sedeSeleccionada.cantidadMaxPorGuia);
            if (resto != 0)
            {
                cantidad += 1;
            }
            return cantidad;
        }


        public static void registrarReserva()
        {
            //DateTime hoy = DateTime.ParseExact(fechaHoraActual, "dd/MM/yyyy", null);

            DReservaVisita actual = new DReservaVisita(numeroUnico, cantidadVisitantes, cantidadVisitantes, duracionEstimada, fechaHoraActual, fechaHoraReserva, "08:00", "12:00", escuelaSeleccionada.idEscuela, sedeSeleccionada.idSede, 1, 1, 1, 1);
        }


        public static string usuarioEnSesion()
        {

            string usrSesion = new Sesion().getEmpleadoEnSesion();
            sesionActual = usrSesion;

            return usrSesion;
        }

        public void getFechaActual()
        {

            fechaHoraActual = DateTime.Today;

            //DateTime dateTime = DateTime.UtcNow.Date;
            //Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));

        }

        public void generarNumeroUnico()
        {
            List<ReservaVisita> reservas = new List<ReservaVisita>();

            int cont = 0;


            foreach (var item in reservas)
            {
                cont = cont + 1;
            }


            numeroUnico = cont+1;
        }


        //este metodo no va aca XD
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





 










    }
}
