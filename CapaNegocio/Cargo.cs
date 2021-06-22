using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cargo
    {
        public int idCargo { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }

        public Cargo(int idCargo, string descripcion, string nombre)
        {
            this.idCargo = idCargo;
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        //public static List<Empleado> esGuia(List<Empleado> empTodos, int num)
        //{
        //    List<Empleado> listaDeGuias = new List<Empleado>();

        //    var filtrado = empTodos.Where(emp => emp.idCargo == num);
        //    foreach (Empleado emp in filtrado)
        //    {
        //        listaDeGuias.Add(emp);
        //    }

        //    return listaDeGuias;
        //}
    }
}
