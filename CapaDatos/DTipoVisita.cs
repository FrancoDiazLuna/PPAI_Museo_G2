using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DTipoVisita
    {
        private int _idTipoVisita;
        private string _nombre;


        public DTipoVisita()
        {
        }

        public int IdTipoVisita { get => _idTipoVisita; set => _idTipoVisita = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }


        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("TipoVisita");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "TipoVisita_s";
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
