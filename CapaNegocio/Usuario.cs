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
            DataTable usr = new DUsuario().buscar();

            List<Usuario> usuariosList = new List<Usuario>();

            usuariosList = (from DataRow dr in usr.Rows
                            select new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                caducidad = Convert.ToDateTime(dr["caducidad"]),
                                contraseña = dr["contraseña"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                idEmpleado = Convert.ToInt32(dr["idEmpleado"])
                            }

            ).ToList();

            return usuariosList;
        }



    }
}
