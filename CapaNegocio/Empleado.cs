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
        public string dni { get; set; }
        public string domicilio { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaNacimiento { get; set; }
        public string mail { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string idCargo { get; set; }
        public string idHorarioEmpleado { get; set; }

        public Empleado(int idEmpleado, string apellido, int codigoValidacion, string cuit, string dni, string domicilio, string fechaIngreso, string fechaNacimiento, string mail, string nombre, string sexo, string telefono, string idCargo, string idHorarioEmpleado)
        {
            this.idEmpleado = idEmpleado;
            this.apellido = apellido;
            this.codigoValidacion = codigoValidacion;
            this.cuit = cuit;
            this.dni = dni;
            this.domicilio = domicilio;
            this.fechaIngreso = fechaIngreso;
            this.fechaNacimiento = fechaNacimiento;
            this.mail = mail;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;
            this.idCargo = idCargo;
            this.idHorarioEmpleado = idHorarioEmpleado;
        }



        

        

        //public static List<Empleado> conocerCargo(List<Empleado> lista)
        //{
        //    List<Empleado> listaTemporales = new List<Empleado>();

        //    listaTemporales = Cargo.esGuia(lista, 2);

        //    return listaTemporales;
        //}

        //public static List<Empleado> trabajaEnDiaYHorarios(List<Empleado> lista)
        //{
        //    List<Empleado> listaTemporales = new List<Empleado>();

        //    listaTemporales = HorarioEmpleado.trabajaEnDiaYHorarios(lista, fechaInicio, );

        //    return listaTemporales;
        //}
    }
}
