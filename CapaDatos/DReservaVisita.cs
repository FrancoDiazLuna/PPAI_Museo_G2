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

        public DReservaVisita(int idReservaVisita, int cantidadAlumno, int cantidadAlumnoConfirmada, int duracionEstimada, DateTime fechaHoraCreacion, DateTime fechaHoraReserva, string horaFinReal, string horaInicioReal, int idEscuela, int idSede, int idExposicion, int idCambioEstado, int idAsignacionGuia, int idEmpleadoCreo)
        {
            this.idReservaVisita = idReservaVisita;
            this.cantidadAlumno = cantidadAlumno;
            this.cantidadAlumnoConfirmada = cantidadAlumnoConfirmada;
            this.duracionEstimada = duracionEstimada;
            this.fechaHoraCreacion = fechaHoraCreacion;
            this.fechaHoraReserva = fechaHoraReserva;
            this.horaFinReal = horaFinReal;
            this.horaInicioReal = horaInicioReal;
            this.idEscuela = idEscuela;
            this.idSede = idSede;
            this.idExposicion = idExposicion;
            this.idCambioEstado = idCambioEstado;
            this.idAsignacionGuia = idAsignacionGuia;
            this.idEmpleadoCreo = idEmpleadoCreo;
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
