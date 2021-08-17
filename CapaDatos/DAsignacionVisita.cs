using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAsignacionVisita
    {

        public int _idAsignacionVisita;
        public DateTime _fechaHoraFin;
        public DateTime _fechaHoraInicio;
        public int _idGuiaAsignado;


        public DAsignacionVisita()
        {

        }



        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("AsignacionVisita");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "AsignacionVisita_s";
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
