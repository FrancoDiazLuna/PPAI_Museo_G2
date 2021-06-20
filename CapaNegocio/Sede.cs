using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Sede
    {
        public int idSede { get; set; }
        public int cantidadMaximaVisitantes { get; set; }
        public int cantidadMaxPorGuia { get; set; }
        public string nombre { get; set; }
        public int idDeposito { get; set; }
        public int idColeccion { get; set; }
        public int idExposicion { get; set; }
        public int idTarifa { get; set; }


        public Sede(int idSede, int cantidadMaximaVisitantes, int cantidadMaximaPorGuia, string nombre, int idDeposito, int idColeccion,
            int idExposicion, int idTarifa)
        {
            this.idSede = idSede;
            this.cantidadMaximaVisitantes = cantidadMaximaVisitantes;
            this.cantidadMaxPorGuia = cantidadMaximaPorGuia;
            this.nombre = nombre;
            this.idDeposito = idDeposito;
            this.idColeccion = idColeccion;
            this.idExposicion = idExposicion;
            this.idTarifa = idTarifa;

        }
    }
}
