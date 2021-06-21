using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DExposicion
    {
        private int _idExposicion;
        private DateTime _fechaFin;
        private DateTime _fechaFinReplanificada;
        private DateTime _fechaInicio;
        private DateTime _fechaInicioReplanificada;
        private DateTime _horaApertura;
        private DateTime _horaCierre;
        private string _nombre;
        private int _idTipoExposicion;
        private int _idPublicoDestino;
        private int _idEmpleadoCreo;

        public int IdExposicion { get => _idExposicion; set => _idExposicion = value; }
        public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }
        public DateTime FechaFinReplanificada { get => _fechaFinReplanificada; set => _fechaFinReplanificada = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaInicioReplanificada { get => _fechaInicioReplanificada; set => _fechaInicioReplanificada = value; }
        public DateTime HoraApertura { get => _horaApertura; set => _horaApertura = value; }
        public DateTime HoraCierre { get => _horaCierre; set => _horaCierre = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int IdTipoExposicion { get => _idTipoExposicion; set => _idTipoExposicion = value; }
        public int IdPublicoDestino { get => _idPublicoDestino; set => _idPublicoDestino = value; }
        public int IdEmpleadoCreo { get => _idEmpleadoCreo; set => _idEmpleadoCreo = value; }

        public DExposicion()
        {
        }

        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("Exposicion");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Exposicion_s";
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
    
