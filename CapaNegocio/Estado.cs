using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Estado
    {
        public int idEstado { get; set; }
        public string ambito { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }

        public Estado(int idEstado, string ambito, string descripcion, string nombre)
        {
            this.idEstado = idEstado;
            this.ambito = ambito;
            this.descripcion = descripcion;
            this.nombre = nombre;
        }


        public Estado()
        {
        }

        //nuevo
        public static bool esAmbitoReserva(Estado estado)
        {
            if (estado.ambito == "Reserva")
            {
                return true;
            }
            return false;
        }

        public static bool esEstadoPendiente(Estado estado)
        {
            if (estado.nombre == "Pendiente")
            {
                return true;
            }
            return false;
        }
        
    }
}
