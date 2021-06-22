using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Exposicion
    {
        public int idExposicion { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaFinReplanificada { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaInicioReplanificada { get; set; }
        public DateTime horaApertura { get; set; }
        public DateTime horaCierre { get; set; }
        public string nombre { get; set; }
        public int idTipoExposicion { get; set; }
        public int idPublicoDestino { get; set; }
        public int idEmpleadoCreo { get; set; }


        //(List<int> idExposiciones)


        public static List<Exposicion> esVigente(List<Exposicion> expoTodas)
        {
            List<Exposicion> expoVigente = new List<Exposicion>();

            var filtrado = expoTodas.Where(expo => expo.fechaInicio <= DateTime.Now | expo.fechaInicioReplanificada <= DateTime.Now 
                                                && expo.fechaFin >= DateTime.Now | expo.fechaFinReplanificada >= DateTime.Now);
            foreach (Exposicion expo in filtrado)
            {
                //if (expo.fechaInicio <= DateTime.Now | expo.fechaInicioReplanificada <= DateTime.Now)
                    expoVigente.Add(expo);
            }

            return expoVigente;
        }


        public static List<Exposicion> esTemporal(List<Exposicion> lista)
        {
            List<Exposicion> listaTemporales = new List<Exposicion>();

            listaTemporales = TipoExposicion.tipoExpoEs(lista, 1);

            return listaTemporales;
        } 


        public static int calcularDuracionObrasExpuestas()
        {
            List<Obra> obras = new DetalleExposicion().buscarObras();

            List<DetalleExposicionPorExposicion> obrasEnExpo = new DetalleExposicionPorExposicion().getDetalleExE();

            List<Exposicion> exposicionesSeleccionadas = GestorDeReserva.exposicionSeleccionada;

            List<Obra> obrasDeExposSelecc = new List<Obra>();

            foreach (Exposicion item in exposicionesSeleccionadas)
            {
                foreach (var item2 in obrasEnExpo)
                {
                    if (item.idExposicion == item2.idExposicion)
                    {
                        foreach (var item3 in obras)
                        {
                            if (item3.idObra == item2.idDetalleExposicion)
                            {
                                obrasDeExposSelecc.Add(item3);
                            }
                        }
                    }
                }
            }

            int duracionMinutos = 0;

            foreach (var item in obrasDeExposSelecc)
            {
                duracionMinutos = duracionMinutos + item.duracionExtendida;
            }

            return duracionMinutos;

        }



    }
}
