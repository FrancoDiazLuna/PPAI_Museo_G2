using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEmpleado
    {
        public int _idEmpleado;
        public string _apellido;
        public int _codigoValidacion;
        public string _cuit;
        public int _dni;
        public string _domicilio;
        public DateTime _fechaIngreso;
        public DateTime _fechaNacimiento;
        public string _mail;
        public string _nombre;
        public string _sexo;
        public string _telefono;
        public int _idCargo;
        public int _idHorarioEmpleado;
        public int _idSede;



        public DEmpleado()
        {
        }




        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("Empleado");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Empleado_s";
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
