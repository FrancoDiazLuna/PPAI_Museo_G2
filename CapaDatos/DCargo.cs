using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCargo
    {
        public int _idCargo;
        public string _descripcion;
        public string _nombre;


        public int idCargo { get => _idCargo; set => _idCargo = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public string nombre { get => _nombre; set => _nombre = value; }


        public DCargo()
        {
        }

        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("Cargo");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Cargo_s";
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
