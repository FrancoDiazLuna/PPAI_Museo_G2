﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Museo_Pictórico.Logica
{
    public class HorarioEmpleado
    {
        public int idHorarioEmpleado { get; set; }
        public string horaIngreso { get; set; }
        public string horaSalida { get; set; }
        public int idDiaSemana { get; set; }
    }
}