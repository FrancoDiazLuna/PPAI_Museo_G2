using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DHorarioEmpleado
    {

        public int _idHorarioEmpleado;
        public int _idDiaSemana;
        public DateTime _horaIngreso;
        public DateTime _horaSalida;





        public DHorarioEmpleado()
        {
        }


        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("HorarioEmpleado");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "HorarioEmpleado_s";
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
