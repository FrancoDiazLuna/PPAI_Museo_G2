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
    
