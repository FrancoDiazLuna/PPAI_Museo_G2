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



        public int idEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public int codigoValidacion { get => _codigoValidacion; set => _codigoValidacion = value; }
        public string cuit { get => _cuit; set => _cuit = value; }
        public int dni { get => _dni; set => _dni = value; }
        public string domicilio { get => _domicilio; set => _domicilio = value; }
        public DateTime fechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public DateTime fechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string mail { get => _mail; set => _mail = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string sexo { get => _sexo; set => _sexo = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public int idCargo { get => _idCargo; set => _idCargo = value; }
        public int idHorarioEmpleado { get => _idHorarioEmpleado; set => _idHorarioEmpleado = value; }


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
