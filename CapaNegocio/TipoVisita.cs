﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TipoVisita
    {
        public int idTipoVisita { get; set; }
        public string nombre { get; set; }

        public TipoVisita(int idTipoVisita, string nombre)
        {
            this.idTipoVisita = idTipoVisita;
            this.nombre = nombre;
        }
    }
}
