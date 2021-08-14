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
        public int idSede { get; set; }


        //public Empleado(int idEmpleado, string apellido, int codigoValidacion, string cuit, int dni, string domicilio,
        //    DateTime fechaIngreso, DateTime fechaNacimiento, string mail, string nombre, string sexo, string telefono, int idCargo, int idHorarioEmpleado)
        //{
        //    this.idEmpleado = idEmpleado;
        //    this.apellido = apellido;
        //    this.codigoValidacion = codigoValidacion;
        //    this.cuit = cuit;
        //    this.dni = dni;
        //    this.domicilio = domicilio;
        //    this.fechaIngreso = fechaIngreso;
        //    this.fechaNacimiento = fechaNacimiento;
        //    this.mail = mail;
        //    this.nombre = nombre;
        //    this.sexo = sexo;
        //    this.telefono = telefono;
        //    this.idCargo = idCargo;
        //    this.idHorarioEmpleado = idHorarioEmpleado;
        //}


        public static int conocerCargo(Empleado empleado)
        {
            return empleado.idCargo;
        }

        public static bool trabajaEnDiaYHorario(Empleado empleado)
        {
            //crear clase de horario empleadoo
            //Link de la solucion
            //https://social.msdn.microsoft.com/Forums/es-ES/ae24003b-397d-48e0-8800-f96348056810/fecha-dentro-de-un-rango-de-fecha-en-c?forum=vcses 
            return false;
        }

        public static bool tieneAsignacionParaDiaYHora(Empleado empleado)
        {
            return false;
        }




    }
}
