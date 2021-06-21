using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DObra
    {
         public int _idObra;
         public int _alto;
         public int _ancho;
         public int _codigoSensor;
         public string _descripcion;
         public int _duracionExtendida;
         public int _duracionResumida;
         public DateTime _fechaCreacion;
         public DateTime _fechaPrimerIngreso;
         public string _nombraObra;
         public int _peso;
         public int _valuacion;
         public int _idDonacion;
         public int _idPrestamoMuseo;
         public int _idSectorDeposito;
         public int _idArchivo;
         public int _idCambioEstado;
         public int _idEmpleadoCreo;
         public int _idArtistaQuePinto;
         public int _idCompra;
         public int _idRestauracionRealizada;
         public int _idTecnica;
         public int _idEstilo;
         public int _idTipoIngreso;
         public int _idTematica;
 
         public int idObra { get => _idObra; set => _idObra = value; }
         public int alto { get => _alto; set => _alto = value; }
         public int ancho { get => _ancho; set => _ancho = value; }
         public int codigoSensor { get => _codigoSensor; set => _codigoSensor = value; }
         public string descripcion { get => _descripcion; set => _descripcion = value; }
         public int duracionExtendida { get => _duracionExtendida; set => _duracionExtendida = value; }
         public int duracionResumida { get => _duracionResumida; set => _duracionResumida = value; }
         public DateTime fechaCreacion { get => _fechaCreacion; set => _fechaCreacion = value; }
         public DateTime fechaPrimerIngreso { get => _fechaPrimerIngreso; set => _fechaPrimerIngreso = value; }
         public string nombraObra { get => _nombraObra; set => _nombraObra = value; }
         public int peso { get => _peso; set => _peso = value; }
         public int valuacion { get => _valuacion; set => _valuacion = value; }
         public int idDonacion { get => _idDonacion; set => _idDonacion = value; }
         public int idPrestamoMuseo { get => _idPrestamoMuseo; set => _idPrestamoMuseo = value; }
         public int idSectorDeposito { get => _idSectorDeposito; set => _idSectorDeposito = value; }
         public int idArchivo { get => _idArchivo; set => _idArchivo = value; }
         public int idCambioEstado { get => _idCambioEstado; set => _idCambioEstado = value; }
         public int idEmpleadoCreo { get => _idEmpleadoCreo; set => _idEmpleadoCreo = value; }
         public int idArtistaQuePinto { get => _idArtistaQuePinto; set => _idArtistaQuePinto = value; }
         public int idCompra { get => _idCompra; set => _idCompra = value; }
         public int idRestauracionRealizada { get => _idRestauracionRealizada; set => _idRestauracionRealizada = value; }
         public int idTecnica { get => _idTecnica; set => _idTecnica = value; }
         public int idEstilo { get => _idEstilo; set => _idEstilo = value; }
         public int idTipoIngreso { get => _idTipoIngreso; set => _idTipoIngreso = value; }
         public int idTematica { get => _idTematica; set => _idTematica = value; }
 
         public DObra() { }
 
         public DataTable buscar()
         {
             DataTable dataTable = new DataTable("Obra");
             SqlConnection sqlConnection = new SqlConnection();
             try
             {
                 sqlConnection.ConnectionString = Conexion.Cn;
                 SqlCommand sqlCommand = new SqlCommand();
                 sqlCommand.Connection = sqlConnection;
                 sqlCommand.CommandText = "Obra_s";
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
