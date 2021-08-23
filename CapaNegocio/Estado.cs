using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Estado
    {
        public int idEstado { get; set; }
        public string ambito { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }

        public Estado(int idEstado, string ambito, string descripcion, string nombre)
        {
            this.idEstado = idEstado;
            this.ambito = ambito;
            this.descripcion = descripcion;
            this.nombre = nombre;
        }


        public Estado()
        {
        }

        //nuevo

        public static Estado esAmbitoReserva()
        {
            DataTable estados = new DEstado().Buscar();
            List<Estado> todosEstados = new List<Estado>();
            Estado e = new Estado();
            todosEstados = (from DataRow dr in estados.Rows
                            select new Estado()
                            {
                                idEstado = Convert.ToInt32(dr["idEstado"]),
                                ambito = dr["ambito"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                nombre = dr["nombre"].ToString(),
                            }).ToList();

            foreach (Estado dt in todosEstados)
            {
                if (dt.ambito == "Reserva" && dt.nombre == "Pendiente")
                {
                    e = new Estado(dt.idEstado, dt.ambito, dt.descripcion, dt.nombre);
                    break;
                }
            }

            return e;
        }
    }
}
