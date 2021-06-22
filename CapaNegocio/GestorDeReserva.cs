﻿using System;
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

        public static List<Cargo> guias { get; set; }

        public static DateTime fechaHoraActual { get; set; }

        public static int numeroUnico { get; set; }

        public static Sesion sesionActual { get; set; }



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

            return test;
        }

        public static string usuarioEnSesion()
        {
            DataTable sesion = new DSesion().buscar();

            List<Sesion> sesionList = new List<Sesion>();
            sesionList = (from DataRow dr in sesion.Rows
                                select new Sesion()
                                {
                                    idSesion = Convert.ToInt32(dr["idSesion"]),
                                    fechaFin = Convert.ToDateTime(dr["fechaFin"]),
                                    fechaInicio = Convert.ToDateTime(dr["fechaInicio"]),
                                    horaFin = Convert.ToDateTime(dr["horaFin"]),
                                    horaInicio = Convert.ToDateTime(dr["horaInicio"]),
                                    idUsuario = Convert.ToInt32(dr["idUsuario"])
                                }

                            ).ToList();
            foreach (var item in sesionList)
            {

            }

            string usrSesion = "Admin";


            return usrSesion;
        }
    }
}
