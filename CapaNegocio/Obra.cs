using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Obra(int idObra, int alto, int ancho, int codigoSensor, string descripcion, int duracionExtendida, int duracionResumida, 
            DateTime fechaCreacion, DateTime fechaPrimerIngreso, string nombraObra, int peso, int valuacion, int idDonacion, int idPrestamoMuseo, 
            int idSectorDeposito, int idArchivo, int idCambioEstado, int idEmpleadoCreo, int idArtistaQuePinto, int idCompra, int idRestauracionRealizada, 
            int idTecnica, int idEstilo, int idTipoIngreso, int idTematica)
        {
            this.idObra = idObra;
            this.alto = alto;
            this.ancho = ancho;
            this.codigoSensor = codigoSensor;
            this.descripcion = descripcion;
            this.duracionExtendida = duracionExtendida;
            this.duracionResumida = duracionResumida;
            this.fechaCreacion = fechaCreacion;
            this.fechaPrimerIngreso = fechaPrimerIngreso;
            this.nombreObra = nombraObra;
            this.peso = peso;
            this.valuacion = valuacion;
            this.idDonacion = idDonacion;
            this.idPrestamoMuseo = idPrestamoMuseo;
            this.idSectorDeposito = idSectorDeposito;
            this.idArchivo = idArchivo;
            this.idCambioEstado = idCambioEstado;
            this.idEmpleadoCreo = idEmpleadoCreo;
            this.idArtistaQuePinto = idArtistaQuePinto;
            this.idCompra = idCompra;
            this.idRestauracionRealizada = idRestauracionRealizada;
            this.idTecnica = idTecnica;
            this.idEstilo = idEstilo;
            this.idTipoIngreso = idTipoIngreso;
            this.idTematica = idTematica;
        }

        public Obra()
        {
        }
    }
}
