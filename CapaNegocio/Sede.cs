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


        public static DataTable obtenerPublicoDestino(Sede sedeSelecc)
        {

            List<PublicoDestino> publicoDestLista = Exposicion.getPublicoDestino();

            List<Exposicion> ExposPorSedeList = buscarExposicionTemporalVigente(sedeSelecc);



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

            foreach (Exposicion exposicion in ExposPorSedeList)
            {
                DataRow row = dt.NewRow();

                row["Id Exposicion"] = exposicion.idExposicion;
                row["Fecha Fin"] = exposicion.fechaFin;
                row["Fecha Fin Replanificada"] = exposicion.fechaFinReplanificada;
                row["Fecha Inicio"] = exposicion.fechaInicio;
                row["Fecha Inicio Replanificada"] = exposicion.fechaInicioReplanificada;
                row["Hora Apertura"] = exposicion.horaApertura;
                row["Hora Cierre"] = exposicion.horaCierre;
                row["Nombre"] = exposicion.nombre;
                foreach (PublicoDestino publicoDestino1 in publicoDestLista)
                {
                    if (publicoDestino1.idPublicoDestino == exposicion.idPublicoDestino)
                    {
                        row["Publico Destino"] = publicoDestino1.nombre;
                    }
                }

                dt.Rows.Add(row);
            }


            return dt;

        }


        public static List<ReservaVisita> buscarVisitantesSimultaneos(Sede selecc)
        {
            DataTable reservasDT = new DReservaVisita().buscar();

            List<ReservaVisita> reservaVisitaTodasList = new List<ReservaVisita>();
            List<ReservaVisita> reservasDeLaSede = new List<ReservaVisita>();
            reservaVisitaTodasList = (from DataRow dr in reservasDT.Rows
                                      select new ReservaVisita()
                                      {
                                          idReservaVisita = Convert.ToInt32(dr["idReservaVisita"]),
                                          cantidadAlumnos = Convert.ToInt32(dr["cantidadAlumnos"]),
                                          cantidadAlumnosConfirmada = Convert.ToInt32(dr["cantidadAlumnosConfirmada"]),
                                          duracionEstimada = Convert.ToInt32(dr["duracionEstimada"]),
                                          fechaHoraCreacion = Convert.ToDateTime(dr["fechaHoraCreacion"]),
                                          fechaHoraReserva = Convert.ToDateTime(dr["fechaHoraReserva"]),
                                          horaFinReal = Convert.ToDateTime(dr["horaFinReal"]),
                                          horaInicioReal = Convert.ToDateTime(dr["horaInicioReal"]),
                                          idEscuela = Convert.ToInt32(dr["idEscuela"]),
                                          idSede = Convert.ToInt32(dr["idSede"]),
                                          idExposicion = Convert.ToInt32(dr["idExposicion"]),
                                          idCambioEstado = Convert.ToInt32(dr["idCambioEstado"]),
                                          idAsignacionGuia = Convert.ToInt32(dr["idAsignacionGuia"]),
                                          idEmpleadoCreo = Convert.ToInt32(dr["idEmpleadoCreo"])
                                      }
            ).ToList();


            foreach (ReservaVisita item in reservaVisitaTodasList)
            {
                if (item.idSede == selecc.idSede)
                {
                    reservasDeLaSede.Add(item);
                }
            }


            return reservasDeLaSede;


        }


        public static DataTable calcularDuracionEstimada(Sede sedeSelecc)
        {
            List<Exposicion> exposList = buscarExposicionTemporalVigente(sedeSelecc);


            DataTable dt1 = new DataTable();
            dt1.Columns.Add("idExpo", typeof(int));
            dt1.Columns.Add("duracion", typeof(int));

            foreach (Exposicion item in exposList)
            {
                dt1.Rows.Add(item.idExposicion, Exposicion.calcularDuracionObrasExpuestas(item));
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
                if (Empleado.conocerCargo(item) == 2)
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
            dt1.Columns.Add("idGuiaAsignado", typeof(int));



            foreach (Empleado item in guias)
            {
                DataTable dt3 = Empleado.tieneAsignacionParaDiaYHora(item);

                foreach (DataRow row1 in dt3.Rows)
                {
                    int idEmp = Convert.ToInt32(row1["idGuiaAsignado"]);
                    if (item.idEmpleado == idEmp)
                    {

                        DataTable dt2 = Empleado.trabajaEnDiaYHorario(item);
                        foreach (DataRow row2 in dt2.Rows)
                        {
                            DataRow row = dt1.NewRow();
                            row[0] = item.idEmpleado;
                            row[1] = item.idSede;
                            row[2] = item.apellido;
                            row[3] = item.nombre;
                            row[4] = row2[0];
                            row[5] = row2[1];
                            row[6] = row2[2];
                            row[7] = row1[0];
                            row[8] = row1[1];
                            row[9] = row1[2];

                            dt1.Rows.Add(row);
                        }

                    }
                }
            }


            return dt1;

        }



    }
}
