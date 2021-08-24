using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DExposicionesPorReserva
    {
        public int idExposPorReserva { get; set; }
        public int reservasId { get; set; }
        public int exposicionId { get; set; }

        public DExposicionesPorReserva()
        {
        }

        public DExposicionesPorReserva(int idExposPorReserva, int reservasId, int exposicionId)
        {
            this.idExposPorReserva = idExposPorReserva;
            this.reservasId = reservasId;
            this.exposicionId = exposicionId;
        }

        public static void cargar(DExposicionesPorReserva exr)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Cn);
            SqlCommand agregar = new SqlCommand("insert into ExposicionesPorReserva values (@reservasId,@exposicionId)", cnn);
            cnn.Open();

            try
            {
                agregar.Parameters.Clear();

                agregar.Parameters.AddWithValue("@reservasId", Convert.ToInt32(exr.reservasId));
                agregar.Parameters.AddWithValue("@exposicionId", Convert.ToInt32(exr.exposicionId));

                agregar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cnn.Close();
            }

        }
    }
}
