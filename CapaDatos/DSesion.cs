using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class  DSesion
    {
        public int _idSesion;
        public DateTime _fechaFin;
        public DateTime _fechaInicio;
        public DateTime _horaFin;
        public DateTime _horaInicio;
        public int _idUsuari;




        public DSesion()
        {
        }

        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("Sesion");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Sesion_s";
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
