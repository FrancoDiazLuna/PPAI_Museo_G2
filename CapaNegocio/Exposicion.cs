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

            var filtrado = expoTodas.Where(expo => expo.fechaInicio <= DateTime.Now | expo.fechaInicioReplanificada <= DateTime.Now);
            foreach (Exposicion expo in filtrado)
            {
                //if (expo.fechaInicio <= DateTime.Now | expo.fechaInicioReplanificada <= DateTime.Now)
                    expoVigente.Add(expo);
            }

            return expoVigente;
        }

    }
}
