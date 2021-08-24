using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAsignacionVisita
    {

        public int _idAsignacionVisita;
        public DateTime _fechaHoraFin;
        public DateTime _fechaHoraInicio;
        public int _idGuiaAsignado;


        public DAsignacionVisita()
        {

        }



        public DataTable buscar()
        {
            DataTable dataTable = new DataTable("AsignacionVisita");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexion.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "AsignacionVisita_s";
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

        public static void cargar(DAsignacionVisita AsigEmp)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Cn);
            SqlCommand agregar = new SqlCommand("insert into AsignacionVisita values (@fechaHoraFin,@fechaHoraInicio,@idGuiaAsignado)", cnn);
            
            cnn.Open();
            try
            {
                agregar.Parameters.Clear();

                agregar.Parameters.AddWithValue("@fechaHoraFin", Convert.ToDateTime(AsigEmp._fechaHoraFin.ToString("yyyy/MM/dd HH:mm:ss")));
                agregar.Parameters.AddWithValue("@fechaHoraInicio", Convert.ToDateTime(AsigEmp._fechaHoraInicio.ToString("yyyy/MM/dd HH:mm:ss")));
                agregar.Parameters.AddWithValue("@idGuiaAsignado", Convert.ToInt32(AsigEmp._idGuiaAsignado));

                agregar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cnn.Close();
            }
        }


        }
}
