using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Sesion
    {
        public int idSesion { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public DateTime horaInicio { get; set; }
        public int idUsuario { get; set; }



        public string getEmpleadoEnSesion()
        {

            string empSesion = "Administrador";

            

            List<Usuario> usuarios = new Usuario().getUsuarios();


            foreach (Usuario item in usuarios)
            {
                if (item.idUsuario == 1)
                {
                    empSesion = item.nombre;
                }
            }

            return empSesion;
        }


    }
}
