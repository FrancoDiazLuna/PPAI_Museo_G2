using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DetalleExposicion
    {
        public int idDetalleExposicion { get; set; }
        public int lugarAsignado { get; set; }
        public int idPared { get; set; }
        public int idObra { get; set; }
        public static List<Obra> obrasTodasList { get; set; }

        public DetalleExposicion(int idDetalleExposicion, int lugarAsignado, int idPared, int idObra)
        {
            this.idDetalleExposicion = idDetalleExposicion;
            this.lugarAsignado = lugarAsignado;
            this.idPared = idPared;
            this.idObra = idObra;
        }

        public static List<Obra> buscarObras()
         {
             DataTable obras = new DObra().buscar();
 
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
 
             //var tiempo = 0;
             //foreach (var item in obrasTodasList)
             //{
             //    tiempo += item.duracionExtendida;
             //}
         }
   }
}
