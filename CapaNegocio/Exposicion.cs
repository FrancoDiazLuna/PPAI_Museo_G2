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


        public static List<PublicoDestino> getPublicoDestino()
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

            return publicoDestinoList;
        }


        public static int calcularDuracionObrasExpuestas(Exposicion expo)
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

            DataTable detalleExp = new DDetalleExposicionPorExposicion().buscar();
            List<DetalleExposicionPorExposicion> expTodasList = new List<DetalleExposicionPorExposicion>();

            expTodasList = (from DataRow dr in detalleExp.Rows
                            select new DetalleExposicionPorExposicion()
                            {
                                idDetalleExposicioPorExposicion = Convert.ToInt32(dr["idDetalleExposicioPorExposicion"]),
                                idExposicion = Convert.ToInt32(dr["idExposicion"]),
                                idDetalleExposicion = Convert.ToInt32(dr["idDetalleExposicion"]),

                            }
             ).ToList();



            foreach (DetalleExposicionPorExposicion item1 in expTodasList)
            {
                foreach (DetalleExposicion item2 in detalleExpoList)
                {
                    if (expo.idExposicion == item1.idExposicion && item2.idDetalleExposicion == item1.idDetalleExposicion)
                    {
                        duracionObra = duracionObra + DetalleExposicion.buscarDuracExtObra(item2);
                    }
                }
            }

            return duracionObra;
        }



    }
}
