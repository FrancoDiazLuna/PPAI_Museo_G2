using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaNegocio;

namespace CapaNegocio
{
    public class Obra
    {
        public int idObra { get; set; }
        public int alto { get; set; }
        public int ancho { get; set; }
        public int codigoSensor { get; set; }
        public string descripcion { get; set; }
        public int duracionExtendida { get; set; }
        public int duracionResumida { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaPrimerIngreso { get; set; }
        public string nombreObra { get; set; }
        public int peso { get; set; }
        public int valuacion { get; set; }
        public int idDonacion { get; set; }
        public int idPrestamoMuseo { get; set; }
        public int idSectorDeposito { get; set; }
        public int idArchivo { get; set; }
        public int idCambioEstado { get; set; }
        public int idEmpleadoCreo { get; set; }
        public int idArtistaQuePinto { get; set; }
        public int idCompra { get; set; }
        public int idRestauracionRealizada { get; set; }
        public int idTecnica { get; set; }
        public int idEstilo { get; set; }
        public int idTipoIngreso { get; set; }
        public int idTematica { get; set; }


        public int getDuracionExtendida()
        {
            return duracionExtendida;
        }

    }
}

