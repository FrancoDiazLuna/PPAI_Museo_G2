
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDetalleExposicionPorExposicion
    {
        public int _idDetalleExposicioPorExposicion;
        public int _idExposicion;
        public int _idDetalleExposicion;

        public int idDetalleExposicioPorExposicion { get => _idDetalleExposicion; set => _idDetalleExposicion = value; }
        public int idExposiciono { get => _idExposicion; set => _idExposicion = value; }
        public int idDetalleExposicion { get => _idDetalleExposicion; set => _idDetalleExposicion = value; }

        public DDetalleExposicionPorExposicion()
        {

        }
        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("DetalleExposicionPorExposicion");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DetalleExposicionPorExposicion_s";
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