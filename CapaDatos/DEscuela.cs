using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEscuela
    {
        private int _idEscuela;
        private string _domicilio;
        private string _mail;
        private string _nombre;
        private int _telefCelular;
        private int _telefFijo;

        public int IdEscuela { get => _idEscuela; set => _idEscuela = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int TelefCelular { get => _telefCelular; set => _telefCelular = value; }
        public int TelefFijo { get => _telefFijo; set => _telefFijo = value; }

        public DEscuela()
        {
        }

        public DEscuela(int idEscuela, string domicilio, string mail, string nombre, int telefCelular, int telefFijo)
        {
            this.IdEscuela = idEscuela;
            this.Domicilio = domicilio;
            this.Mail = mail;
            this.Nombre = nombre;
            this.TelefCelular = telefCelular;
            this.TelefFijo = telefFijo;
        }

        public DataTable mostrar()
        {
            DataTable dataTable = new DataTable("Escuela");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Escuela_s";
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
