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
        public static DataTable exposicionesSedePublicoDT { get; set; }
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

        public static DataTable buscarExposicionesTemporalesVigentes()
        {
            
            exposicionesSedeList = Sede.buscarExposicionTemporalVigente(sedeSeleccionada);
            
            DataTable dt = Sede.obtenerPublicoDestino(exposicionesSedeList);
            exposicionesSedePublicoDT = dt;
            
            return dt;
        }

        public static void seleccionExposicionesTemporalesVigentes(List<Exposicion> lista)
        {
            exposicionSeleccionada = lista;
        }

        public static void seleccionFechaHora(DateTime valor)
        {
            fechaHoraReserva = valor;
        }


        // falta llamar a este metodo despues de que elige las exposiciones
        public static void  calcularDuracionEstimada()
        {
            int durEstimada = 0;

            DataTable duracionExpos = Sede.calcularDuracionEstimada(sedeSeleccionada);

            foreach (Exposicion item in exposicionSeleccionada)
            {
                foreach (DataRow row in duracionExpos.Rows)
                {
                    int idExpo = Convert.ToInt32(row["idExpo"]);
                    if (item.idExposicion == idExpo)
                    {
                        int duracion = Convert.ToInt32(row["duracion"]);

                        durEstimada = durEstimada + duracion;
                    }
                }
            }

            duracionEstimada = durEstimada;
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



        public static List<Empleado> buscarGuiasDisponibles()
        {
            List<Empleado> guiasTodos = Sede.buscarGuiasDisponibles();
            DataTable guiasHorarios = Sede.guiasDisponibles();
            List<Empleado> guiasDeSedeDisponibles = new List<Empleado>();

            List<DataRow> guiasConHorarios = new List<DataRow>();

            foreach (DataRow dr in guiasHorarios.Rows)
            {
                guiasConHorarios.Add(dr);
            }



            foreach (Empleado item in guiasTodos)
            {
                int bandera = 0;
                foreach (DataRow row in guiasHorarios.Rows)
                {
                    if (row["idSede"].Equals(sedeSeleccionada.idSede))
                    {

                        DateTime ingreso = Convert.ToDateTime(row["horaIngreso"].ToString());
                        DateTime salida = Convert.ToDateTime(row["horaSalida"].ToString());
                        if (ingreso.Hour < fechaHoraReserva.Hour && fechaHoraReserva.Hour < salida.Hour)
                        {
                            int dia = Convert.ToInt32(row["idDiaSemana"].ToString());
                            if ((int)fechaHoraReserva.DayOfWeek <= 5 && dia == 1 || (int)fechaHoraReserva.DayOfWeek >= 5 && dia == 2)
                            {
                                DateTime inicio = Convert.ToDateTime(row["fechaHoraInicio"].ToString());
                                DateTime fin = Convert.ToDateTime(row["fechaHoraFin"].ToString());
                                if (inicio.Date == fechaHoraReserva.Date)
                                {

                                    DateTime dEst = fechaHoraReserva.AddMinutes(duracionEstimada); 
                                    if (inicio.TimeOfDay < fechaHoraReserva.TimeOfDay && fechaHoraReserva.TimeOfDay < fin.TimeOfDay ||
                                        inicio.TimeOfDay < dEst.TimeOfDay && dEst.TimeOfDay < fin.TimeOfDay)
                                    {
                                        bandera = bandera + 1;
                                    }

                                    if (guiasDeSedeDisponibles.Contains(item) && bandera == 0)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        if (bandera == 0)
                                        {
                                            guiasDeSedeDisponibles.Add(item);
                                        }
                                        else
                                        {
                                            guiasDeSedeDisponibles.Remove(item);
                                        }

                                    }
                                }
                                else
                                {
                                    if (bandera == 0)
                                    {
                                        guiasDeSedeDisponibles.Add(item);
                                        bandera = bandera + 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                //if (item.idSede == sedeSeleccionada.idSede)
                //{
                //    guiasDeSedeDisponibles.Add(item);
                //}
            }


            guiasDeLaSede = guiasDeSedeDisponibles;

            return guiasDeSedeDisponibles;

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



        





 










    }
}
