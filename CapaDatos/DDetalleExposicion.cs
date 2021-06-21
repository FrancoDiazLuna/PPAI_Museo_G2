using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDetalleExposicion
    {
        public int _idDetalleExposicion;
        public int _lugarAsignado;
        public int _idPared;
        public int _idObra;



        public int idDetalleExposicion { get => _idDetalleExposicion; set => _idDetalleExposicion = value; }
        public int lugarAsignado { get => _lugarAsignado; set => _lugarAsignado = value; }
        public int idPared { get => _idPared; set => _idPared = value; }
        public int idObra { get => _idObra; set => _idObra = value; }

        public DDetalleExposicion()
        {
        }


        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("DetalleExposicion");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DetalleExposicion_s";
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

