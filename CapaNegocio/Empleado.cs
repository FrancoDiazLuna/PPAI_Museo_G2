using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string apellido { get; set; }
        public int codigoValidacion { get; set; }
        public string cuit { get; set; }
        public int dni { get; set; }
        public string domicilio { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string mail { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public int idCargo { get; set; }
        public int idHorarioEmpleado { get; set; }

        public static List<Empleado> conocerCargo(List<Empleado> lista)
        {
            List<Empleado> listaTemporales = new List<Empleado>();

            listaTemporales = Cargo.esGuia(lista, 2);

            return listaTemporales;
        }

        //public static List<Empleado> trabajaEnDiaYHorarios(List<Empleado> lista)
        //{
        //    List<Empleado> listaTemporales = new List<Empleado>();

        //    listaTemporales = HorarioEmpleado.trabajaEnDiaYHorarios(lista, fechaInicio, );

        //    return listaTemporales;
        //}
    }
}
