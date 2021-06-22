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

        public static void cantidadDeVisitantes(int valor)
        {
            cantidadVisitantes = valor;
        }
        public static List<Sede> buscarSedes()
        {
            DataTable sedes = new DSede().buscar();

            sedesTodasList = new Sede().getSedes();

            return sedesTodasList;
        }
        public static void seleccionDeSede(Sede sede)
        {
            sedeSeleccionada = sede;
        }

        public static List<TipoVisita> buscarTipoDeVisitas()
        {
            DataTable tiposDeVisita = new DTipoVisita().buscar();

            tiposDeVisitaTodasList = new TipoVisita().getTipoVisitas();

            return tiposDeVisitaTodasList;
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
            duracionEstimada = Sede.calcularDuracionEstimada();

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

            List<Empleado> empSede1 = new List<Empleado>();
            Empleado emp1 = new Empleado(1, "Ramirez", 2234, "35467898787", "5467", "Mitre 10", "22-05-2021", "31-12-1987", "robert@gmail.com", "Roberto", "Masculino", "3467567", "Guia", "08:00 - 20:00");
            Empleado emp2 = new Empleado(2, "Pereyra", 2234, "239487423423", "5467", "Mitre 10", "22-05-2021", "31-12-1987", "pereyra@gmail.com", "Tomas", "Masculino", "3467567", "Guia", "08:00 - 20:00");
            Empleado emp3 = new Empleado(3, "Sanchez", 2234, "2342374234", "5467", "Mitre 10", "22-05-2021", "31-12-1987", "sanchez@gmail.com", "Arnold", "Femenino", "3467567", "Guia", "08:00 - 20:00");
            Empleado emp4 = new Empleado(4, "Juna", 2234, "4593882343", "5467", "Mitre 10", "22-05-2021", "31-12-1987", "juna@gmail.com", "Roberto", "Masculino", "3467567", "Guia", "08:00 - 20:00");
            Empleado emp5 = new Empleado(5, "Arnold", 2234, "35467898787", "5467", "Calle 130", "22-05-2021", "31-12-1987", "arnold@gmail.com", "Josefa", "Femenino", "3467567", "Guia", "08:00 - 20:00");

            empSede1.Add(emp1);
            empSede1.Add(emp2);
            empSede1.Add(emp3);
            empSede1.Add(emp5);
            empSede1.Add(emp4);

            List<Empleado> empSede2 = new List<Empleado>();
            Empleado emp6 = new Empleado(6, "Gomez", 34, "40234534564", "35462543", "Colon", "15/5/2020", "12/3/2000", "gomez@gmail.com", "Pedro", "M", "43215625", "Guia", "08:00 - 20:00");
            Empleado emp7 = new Empleado(7, "Gimenez", 234, "452482424", "453434884", "Malvinas", "15/5/2020", "3/5/2019", "gimenez@gmail.com", "Maria", "F", "13245254", "Guia", "08:00 - 20:00");
            Empleado emp8 = new Empleado(8, "Guzman", 45344, "44834154564", "12015205", "GralPaz", "15/5/2020", "8/6/2000", "guzman@gmail.com", "Jorge", "M", "862354", "Guia", "08:00 - 20:00");
            Empleado emp9 = new Empleado(9, "Ramirez", 34566, "248245284", "45348323", "Rosario", "15/5/2020", "13/9/2001", "ramirez@gmail.com", "Martin", "M", "4125500", "Guia", "08:00 - 20:00");
            Empleado emp10 = new Empleado(10, "Rondo", 23425, "021045045", "8452045", "Maral", "15/5/2020", "12/3/2000", "rondo@gmail.com", "Esteban", "M", "45348485", "Guia", "08:00 - 20:00");

            empSede2.Add(emp6);
            empSede2.Add(emp7);
            empSede2.Add(emp8);
            empSede2.Add(emp9);
            empSede2.Add(emp10);
            List<Empleado> empSede3 = new List<Empleado>();
            Empleado emp11 = new Empleado(11, "Fernandez", 675567, "1235415342", "123543542", "Patria", "2/7/2019", "15/6/2021", "fernandez@gmail.com", "Maria", "F", "348354254", "Guia", "13:00");
            Empleado emp12 = new Empleado(12, "Paredes", 4334534, "47582424", "453434884", "Malvinas", "15/5/2020", "3/5/2019", "paredes@gmail.com", "Esequiel", "M", "14585254", "Guia", "8:00");
            Empleado emp13 = new Empleado(13, "Funes", 345346, "32154786", "12015205", "GralPaz", "15/5/2020", "8/6/2000", "funes@gmail.com", "Gaston", "M", "4384534", "Guia", "12:00");
            Empleado emp14 = new Empleado(14, "Muñoz", 345345, "32568578", "45348323", "Rosario", "15/5/2020", "13/9/2001", "muñoz@gmail.com", "Facundo", "M", "3785421", "Guia", "20:00");
            Empleado emp15 = new Empleado(15, "Rodriguez", 2342345, "38975425", "8452045", "Maral", "15/5/2020", "12/3/2000", "rodriguez@gmail.com", "Rafael", "M", "43853485", "Guia", "17:00");


            if (sedeSeleccionada.idSede == 1)
            {
                return empSede1;
            }
            else if (sedeSeleccionada.idSede == 2)
            {
                return empSede2;
            }
            else
            {
                return empSede3;
            }

        }

        public static void seleccionGuiasDisponiles(List<Empleado> lista)
        {

            guiaSeleccionado = lista;
            foreach (var item in lista)
            {

            }
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


            numeroUnico = cont;
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
