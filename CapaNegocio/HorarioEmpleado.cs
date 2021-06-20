using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class HorarioEmpleado
    {
        public int idHorarioEmpleado { get; set; }
        public string horaIngreso { get; set; }
        public string horaSalida { get; set; }
        public int idDiaSemana { get; set; }

        public HorarioEmpleado(int idHorarioEmpleado, string horaIngreso, string horaSalida, int idDiaSemana)
        {
            this.idHorarioEmpleado = idHorarioEmpleado;
            this.horaIngreso = horaIngreso;
            this.horaSalida = horaSalida;
            this.idDiaSemana = idDiaSemana;
        }


    }
}
