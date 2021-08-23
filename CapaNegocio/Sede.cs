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


        public static DataTable calcularDuracionEstimada(Sede sedeSelecc)
        {
            List<Exposicion> exposList = buscarExposicionTemporalVigente(sedeSelecc);


            DataTable dt1 = new DataTable();
            dt1.Columns.Add("idExpo", typeof(int));
            dt1.Columns.Add("duracion", typeof(int));

            foreach (Exposicion item in exposList)
            {
                dt1.Rows.Add(item.idExposicion,Exposicion.calcularDuracionObrasExpuestas(item));
            }

            return dt1;

        }


        public static List<Empleado> buscarGuiasDisponibles()
        {
            DataTable empleadosTodos = new DEmpleado().buscar();

            List<Empleado> empleadosTodosList = new List<Empleado>();
            List<Empleado> guias = new List<Empleado>();

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
                                      idSede = Convert.ToInt32(dr["idSede"])

                                  }
                                    ).ToList();




            foreach (Empleado item in empleadosTodosList)
            {
                if (Empleado.conocerCargo(item) == 1)
                {
                    guias.Add(item);
                }
            }

                    return guias;

        }

        public static DataTable guiasDisponibles()
        {
            

            List<Empleado> guias = buscarGuiasDisponibles();



            DataTable dt1 = new DataTable();
            dt1.Columns.Add("idEmpleado", typeof(int));
            dt1.Columns.Add("idSede", typeof(int));
            dt1.Columns.Add("apellido", typeof(string));
            dt1.Columns.Add("nombre", typeof(string));
            dt1.Columns.Add("idDiaSemana", typeof(int));
            dt1.Columns.Add("horaIngreso", typeof(DateTime));
            dt1.Columns.Add("horaSalida", typeof(DateTime));
            dt1.Columns.Add("fechaHoraInicio", typeof(DateTime));
            dt1.Columns.Add("fechaHoraFin", typeof(DateTime));


            foreach (Empleado item in guias)
            {
                DataTable dt3 = Empleado.tieneAsignacionParaDiaYHora(item);

                foreach (DataRow row1 in dt3.Rows)
                {
                    DataTable dt2 = Empleado.trabajaEnDiaYHorario(item);
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        dt1.Rows.Add(item.idEmpleado, item.idSede, item.apellido, item.nombre,row2["idDiaSemana"],
                            row2["horaIngreso"],row2["horaSalida"],row1["fechaHoraInicio"],row1["fechaHoraFin"]);
                    }
                }
            }


            return dt1;

        }



    }
}
