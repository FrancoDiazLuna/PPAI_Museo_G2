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
        //public static List<Escuela> escuelas { get; set; }
        public static DataTable escuelas { get; set; }
        private Escuela escuelaSeleccionada { get; set; }

        private int cantidadVisitantes { get; set; }

        private List<Sede> sedes { get; set; }
        private Sede sedeSeleccionada { get; set; }

        private List<TipoVisita> tiposDeVisita { get; set; }
        private TipoVisita tipoDeVisitaSeleccionada { get; set; }

        private List<Exposicion> exposiciones { get; set; }
        private List<Exposicion> exposicionSeleccionada { get; set; }

        private DateTime fechaHoraReserva { get; set; }

        private int duracionEstimada { get; set; }

        private int visitantesSimultaneos { get; set; }

        private List<Cargo> guias { get; set; }

        private DateTime fechaHoraActual { get; set; }

        private int numeroUnico { get; set; }

        private Sesion sesionActual { get; set; }


        

        //public static List<Escuela> buscarEscuelas()
        //{

        //    DataTable escuelasBD = new DEscuela().mostrar();
        //    foreach (DataRow row in escuelasBD.Rows)
        //    {
        //        escuelas.Add(new Escuela()
        //        {
        //            idEscuela = int.Parse(row["idEscuela"].ToString()),
        //            domicilio = row["domicilio"].ToString(),
        //            mail = row["mail"].ToString(),
        //            nombre = row["nombre"].ToString(),
        //            telefCelular = int.Parse(row["telefCelular"].ToString()),
        //            telefFijo = int.Parse(row["telefFijo"].ToString())
        //        });
        //    }

        //    return escuelas;
        //}

        public static DataTable buscarEscuelas()
        {
            DataTable escuelas = new DEscuela().mostrar();
            return escuelas;
        }
    }
}
