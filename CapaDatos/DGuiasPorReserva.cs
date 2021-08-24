using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DGuiasPorReserva
    {
        public int idGuiasPorReserva { get; set; }
        public int empleadoId { get; set; }
        public int reservaId { get; set; }

        public DGuiasPorReserva()
        {
        }

        public DGuiasPorReserva(int idGuiasPorReserva, int empleadoId, int reservaId)
        {
            this.idGuiasPorReserva = idGuiasPorReserva;
            this.empleadoId = empleadoId;
            this.reservaId = reservaId;
        }

        public static void cargar(DGuiasPorReserva gxr)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Cn);
            SqlCommand agregar = new SqlCommand("insert into GuiasPorReserva values (@empleadoId,@reservaId)", cnn);
            cnn.Open();

            try
            {
                agregar.Parameters.Clear();

                agregar.Parameters.AddWithValue("@empleadoId", Convert.ToInt32(gxr.empleadoId));
                agregar.Parameters.AddWithValue("@reservaId", Convert.ToInt32(gxr.reservaId));

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
