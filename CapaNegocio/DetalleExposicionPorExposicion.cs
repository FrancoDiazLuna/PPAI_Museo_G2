using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocio;

namespace CapaNegocio
{
    public class DetalleExposicionPorExposicion
    {
        public int idDetalleExposicioPorExposicion { get; set; }
        public int idExposicion { get; set; }
        public int idDetalleExposicion { get; set; }



        public List<DetalleExposicionPorExposicion> getDetalleExE()
        {
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

            return expTodasList;
        }
    }
}
