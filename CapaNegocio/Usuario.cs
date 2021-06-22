using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaDatos
{
    class Usuario
    {
        public int idUsuario { get; set; }
        public DateTime caducidad { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public int idEmpleado { get; set; }


        public List<Usuario> getUsuarios()
        {
            DataTable sedes = new DUsuario().buscar();

            List<Usuario> usuariosList = new List<Usuario>();

            return usuariosList;
        }



    }
}
