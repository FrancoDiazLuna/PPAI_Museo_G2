using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Exposicion
    {
        public int idExposicion { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaFinReplanificada { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaInicioReplanificada { get; set; }
        public DateTime horaApertura { get; set; }
        public DateTime horaCierre { get; set; }
        public string nombre { get; set; }
        public int idTipoExposicion { get; set; }
        public int idPublicoDestino { get; set; }
        public int idEmpleadoCreo { get; set; }





        public static bool esVigente(Exposicion expo)
        {
            if (expo.fechaInicio <= DateTime.Now | expo.fechaInicioReplanificada <= DateTime.Now
                   && expo.fechaFin >= DateTime.Now | expo.fechaFinReplanificada >= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool esTemporal(Exposicion expo)
        {
            if (expo.idTipoExposicion == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static DataRow getPublicoDestino(Exposicion exposicion, DataTable dt)
        {
            DataTable publicoDestino = new DPublicoDestino().buscar();

            List<PublicoDestino> publicoDestinoList = new List<PublicoDestino>();

            publicoDestinoList = (from DataRow dr in publicoDestino.Rows
                                  select new PublicoDestino()
                                  {
                                      idPublicoDestino = Convert.ToInt32(dr["idPublicoDestino"]),
                                      caracteristicas = dr["caracteristicas"].ToString(),
                                      nombre = dr["nombre"].ToString()
                                  }
                        ).ToList();

            DataRow row = dt.NewRow();

            row["Id Exposicion"] = exposicion.idExposicion;
            row["Fecha Fin"] = exposicion.fechaFin;
            row["Fecha Fin Replanificada"] = exposicion.fechaFinReplanificada;
            row["Fecha Inicio"] = exposicion.fechaInicio;
            row["Fecha Inicio Replanificada"] = exposicion.fechaInicioReplanificada;
            row["Hora Apertura"] = exposicion.horaApertura;
            row["Hora Cierre"] = exposicion.horaCierre;
            row["Nombre"] = exposicion.nombre;
            foreach (PublicoDestino publicoDestino1 in publicoDestinoList)
            {
                if (publicoDestino1.idPublicoDestino == exposicion.idPublicoDestino)
                {
                    row["Publico Destino"] = publicoDestino1.nombre;
                }
            }
            return row;
        }


        public static int calcularDuracionObrasExpuestas(int item)

        {
            DataTable detalleExpo = new DDetalleExposicion().buscar();
            List<DetalleExposicion> detalleExpoList = new List<DetalleExposicion>();

            int duracionObra = 0;

            detalleExpoList = (from DataRow dr in detalleExpo.Rows
                               select new DetalleExposicion()
                               {
                                   idDetalleExposicion = Convert.ToInt32(dr["idDetalleExposicion"]),
                                   lugarAsignado = Convert.ToInt32(dr["lugarAsignado"]),
                                   idPared = Convert.ToInt32(dr["idPared"]),
                                   idObra = Convert.ToInt32(dr["idObra"])
                               }
                                    ).ToList();

            List<DetalleExposicionPorExposicion> detalleExpoEnExpo = new DetalleExposicionPorExposicion().getDetalleExE();

            foreach (var item2 in detalleExpoEnExpo)
            {
                foreach (var item3 in detalleExpoList)
                {
                    if (item == item2.idExposicion && item3.idDetalleExposicion == item2.idDetalleExposicion)
                    {
                        duracionObra = duracionObra + DetalleExposicion.buscarDuracExtObra(item2.idDetalleExposicion);
                    }
                }

            }

            return duracionObra;
        }



    }
}
