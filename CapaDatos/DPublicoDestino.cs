using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPublicoDestino
    {
        private int _idPublicoDestino;
        private string _caracteristicas;
        private string _nombre;

        public int IdPublicoDestino { get => _idPublicoDestino; set => _idPublicoDestino = value; }
        public string Caracteristicas { get => _caracteristicas; set => _caracteristicas = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public DPublicoDestino()
        {
        }

        public DPublicoDestino(int idPublicoDestino, string caracteristicas, string nombre)
        {
            IdPublicoDestino = idPublicoDestino;
            Caracteristicas = caracteristicas;
            Nombre = nombre;
        }

        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("PublicoDestino");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "PublicoDestino_s";
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
