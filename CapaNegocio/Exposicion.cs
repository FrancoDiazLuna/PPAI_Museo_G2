using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Exposicion
    {
        public int idExposicion { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaFinReplanificada { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaInicioReplanificada { get; set; }
        public string horaApertura { get; set; }
        public string horaCierre { get; set; }
        public string nombre { get; set; }
        public int idTipoExposicion { get; set; }
        public int idPublicoDestino { get; set; }
        public int idEmpleadoCreo { get; set; }

        public Exposicion(int idExposicion, DateTime fechaFin, DateTime fechaFinReplanificada, DateTime fechaInicio, 
            DateTime fechaInicioReplanificada, string horaApertura, string horaCierre, string nombre, int idTipoExposicion, 
            int idPublicoDestino, int idEmpleadoCreo)
        {
            this.idExposicion = idExposicion;
            this.fechaFin = fechaFin;
            this.fechaFinReplanificada = fechaFinReplanificada;
            this.fechaInicio = fechaInicio;
            this.fechaInicioReplanificada = fechaInicioReplanificada;
            this.horaApertura = horaApertura;
            this.horaCierre = horaCierre;
            this.nombre = nombre;
            this.idTipoExposicion = idTipoExposicion;
            this.idPublicoDestino = idPublicoDestino;
            this.idEmpleadoCreo = idEmpleadoCreo;
        }
    }
}
