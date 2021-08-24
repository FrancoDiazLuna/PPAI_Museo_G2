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
        public DateTime horaFinReal;
        public DateTime horaInicioReal;
        public int numeroReserva;
        public int idEscuela;
        public int idSede;
        public int idExposicion;
        public int idCambioEstado;
        public int idAsignacionGuia;
        public int idEmpleadoCreo;

        public DReservaVisita()
        {
        }

        public DReservaVisita(int idReservaVisita, int cantidadAlumno, int cantidadAlumnoConfirmada, int duracionEstimada, DateTime fechaHoraCreacion, DateTime fechaHoraReserva, DateTime horaFinReal, DateTime horaInicioReal, int numeroReserva,int idEscuela, int idSede, int idExposicion, int idCambioEstado, int idAsignacionGuia, int idEmpleadoCreo)
        {
            this.idReservaVisita = idReservaVisita;
            this.cantidadAlumno = cantidadAlumno;
            this.cantidadAlumnoConfirmada = cantidadAlumnoConfirmada;
            this.duracionEstimada = duracionEstimada;
            this.fechaHoraCreacion = fechaHoraCreacion;
            this.fechaHoraReserva = fechaHoraReserva;
            this.horaFinReal = horaFinReal;
            this.horaInicioReal = horaInicioReal;
            this.numeroReserva = numeroReserva;
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

        //opcion2
        public static void cargar2(DReservaVisita res)
        {

            SqlConnection cnn = new SqlConnection(Conexion.Cn);
            SqlCommand agregar = new SqlCommand("insert into ReservaVisita values (@cantidadAlumnos,@cantidadAlumnosConfirmada,@duracionEstimada,@fechaHoraCreacion," +
                "@fechaHoraReserva,@horaFinReal,@horaInicioReal,@numeroReserva,@idEscuela,@idSede,@idExposicion,@idCambioEstado,@idAsignacionGuia,@idEmpleadoCreo)", cnn);
            cnn.Open();

            //Para que no tire error en las fechas que no se cargan {"Desbordamiento de SqlDateTime. Debe estar entre 1/1/1753 12:00:00 AM y 12/31/9999 11:59:59 PM."}

            if (res.horaInicioReal == DateTime.MinValue)
            {
                //res.horaInicioReal = DBNull.Value;
                //res.horaFinReal = DBNull.Value;
                res.horaInicioReal = DateTime.MaxValue;
                res.horaFinReal = DateTime.MaxValue;
            }
            else
            {
                res.horaFinReal = DateTime.MaxValue;
            }

            try
            {
                agregar.Parameters.Clear();

                agregar.Parameters.AddWithValue("@cantidadAlumnos", Convert.ToInt32(res.cantidadAlumno));
                agregar.Parameters.AddWithValue("@cantidadAlumnosConfirmada", Convert.ToInt32(res.cantidadAlumnoConfirmada));
                agregar.Parameters.AddWithValue("@duracionEstimada", Convert.ToInt32(res.duracionEstimada));
                agregar.Parameters.AddWithValue("@fechaHoraCreacion", Convert.ToDateTime(res.fechaHoraCreacion.ToString("yyyy/MM/dd HH:mm:ss")));
                agregar.Parameters.AddWithValue("@fechaHoraReserva", Convert.ToDateTime(res.fechaHoraReserva.ToString("yyyy/MM/dd HH:mm:ss")));
                agregar.Parameters.AddWithValue("@horaFinReal", Convert.ToDateTime(res.horaFinReal.ToString("yyyy/MM/dd HH:mm:ss")));
                agregar.Parameters.AddWithValue("@horaInicioReal", Convert.ToDateTime(res.horaInicioReal.ToString("yyyy/MM/dd HH:mm:ss")));
                agregar.Parameters.AddWithValue("@numeroReserva", Convert.ToInt32(res.numeroReserva));
                agregar.Parameters.AddWithValue("@idEscuela", Convert.ToInt32(res.idEscuela));
                agregar.Parameters.AddWithValue("@idSede", Convert.ToInt32(res.idSede));
                agregar.Parameters.AddWithValue("@idExposicion", Convert.ToInt32(res.idExposicion));
                agregar.Parameters.AddWithValue("@idCambioEstado", Convert.ToInt32(res.idCambioEstado));
                agregar.Parameters.AddWithValue("@idAsignacionGuia", Convert.ToInt32(res.idAsignacionGuia));
                agregar.Parameters.AddWithValue("@idEmpleadoCreo", Convert.ToInt32(res.idEmpleadoCreo));

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
