using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DExposicionesPorSede
    {
        private int _idExposicionxSede;
        private int _idSede;
        private int _idExposicion;

        public DExposicionesPorSede()
        {
        }

        public int IdExposicion { get => _idExposicion; set => _idExposicion = value; }
        public int IdSede { get => _idSede; set => _idSede = value; }
        public int IdExposicionxSede { get => _idExposicionxSede; set => _idExposicionxSede = value; }

        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("ExposicionPorSede");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "ExposicionPorSede_s";
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
