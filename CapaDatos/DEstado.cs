using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEstado
    {
        private int _idEstado;
        private string _ambito;
        private string _descripcion;
        private string _nombre;

        public int IdEstado { get => _idEstado; set => _idEstado = value; }
        public string Ambito { get => _ambito; set => _ambito = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public DEstado()
        {
        }

        public DEstado(int idEstado, string ambito, string descripcion, string nombre, int telefCelular, int telefFijo)
        {
            this.IdEstado = idEstado;
            this.Ambito = ambito;
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }
        public DataTable Buscar()
        {
            DataTable dataTable = new DataTable("Estado");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Estado_s";
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
