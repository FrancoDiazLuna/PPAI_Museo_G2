using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Museo_Pictórico.Logica
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
    }
}
