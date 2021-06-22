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


        public List<Obra> getObras()
        {
            DataTable obras = new DObra().buscar();
            List<Obra> obrasTodasList = new List<Obra>();

            obrasTodasList = (from DataRow dr in obras.Rows
                              select new Obra()
                              {
                                  idObra = Convert.ToInt32(dr["idObra"]),
                                  alto = Convert.ToInt32(dr["alto"]),
                                  ancho = Convert.ToInt32(dr["ancho"]),
                                  codigoSensor = Convert.ToInt32(dr["codigoSensor"]),
                                  descripcion = dr["descripcion"].ToString(),
                                  duracionExtendida = Convert.ToInt32(dr["duracionExtendida"]),
                                  duracionResumida = Convert.ToInt32(dr["duracionResumida"]),
                                  fechaCreacion = Convert.ToDateTime(dr["fechaCreacion"]),
                                  fechaPrimerIngreso = Convert.ToDateTime(dr["fechaPrimerIngreso"]),
                                  nombreObra = dr["nombreObra"].ToString(),
                                  peso = Convert.ToInt32(dr["peso"]),
                                  valuacion = Convert.ToInt32(dr["valuacion"]),
                                  idDonacion = Convert.ToInt32(dr["idDonacion"]),
                                  idPrestamoMuseo = Convert.ToInt32(dr["idPrestamoMuseo"]),
                                  idSectorDeposito = Convert.ToInt32(dr["idSectorDeposito"]),
                                  idArchivo = Convert.ToInt32(dr["idArchivo"]),
                                  idCambioEstado = Convert.ToInt32(dr["idCambioEstado"]),
                                  idEmpleadoCreo = Convert.ToInt32(dr["idEmpleadoCreo"]),
                                  idArtistaQuePinto = Convert.ToInt32(dr["idArtistaQuePinto"]),
                                  idCompra = Convert.ToInt32(dr["idCompra"]),
                                  idRestauracionRealizada = Convert.ToInt32(dr["idRestauracionRealizada"]),
                                  idTecnica = Convert.ToInt32(dr["idTecnica"]),
                                  idEstilo = Convert.ToInt32(dr["idEstilo"]),
                                  idTipoIngreso = Convert.ToInt32(dr["idTipoIngreso"]),
                                  idTematica = Convert.ToInt32(dr["idTematica"]),
                              }
            ).ToList();

            return obrasTodasList;
        }

    }
}

