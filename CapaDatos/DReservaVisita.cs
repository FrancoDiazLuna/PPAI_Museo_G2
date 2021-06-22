using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;


namespace CapaDatos
{
    public class DReservaVisita
    {
        public int idReservaVisita;
        public int cantidadAlumno;
        public int cantidadAlumnoConfirmada;
        public int duracionEstimada;
        public DateTime fechaHoraCreacion;
        public DateTime fechaHoraReserva;
        public string horaFinReal;
        public string horaInicioReal;
        public int idEscuela;
        public int idSede;
        public int idExposicion;
        public int idCambioEstado;
        public int idAsignacionGuia;
        public int idEmpleadoCreo;

        public DReservaVisita()
        {
        }


        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("ReservaVisita");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "ReservaVisita_s";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

            }
            catch (Exception)
            {
                dataTable = null;
            }

            return dataTable;
        }
    }


}
