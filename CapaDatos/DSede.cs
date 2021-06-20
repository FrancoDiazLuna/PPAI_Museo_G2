using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSede
    {
        private int _idSede;
        private int _cantidadMaximaVisitantes;
        private int _cantidadMaxPorGuia;
        private string _nombre;
        private int _idDeposito;
        private int _idHorario;
        private int _idColeccion;
        private int _idExposicion;
        private int _idTarifa;

        public int IdSede { get => _idSede; set => _idSede = value; }
        public int CantidadMaximaVisitantes { get => _cantidadMaximaVisitantes; set => _cantidadMaximaVisitantes = value; }
        public int CantidadMaxPorGuia { get => _cantidadMaxPorGuia; set => _cantidadMaxPorGuia = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int IdDeposito { get => _idDeposito; set => _idDeposito = value; }
        public int IdHorario { get => _idHorario; set => _idHorario = value; }
        public int IdColeccion { get => _idColeccion; set => _idColeccion = value; }
        public int IdExposicion { get => _idExposicion; set => _idExposicion = value; }
        public int IdTarifa { get => _idTarifa; set => _idTarifa = value; }

        public DSede()
        {
        }

        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("Sede");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Sede_s";
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

