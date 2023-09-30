using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AccesoADatos
{
    public class ComunDB
    {
        const string StringDeConexion = @"Data Source=DESKTOP-N2S1HJB;Initial Catalog=PruebaSorbeteria3;Integrated Security=True";

        private static SqlConnection ObtenerConexion()
        {
            SqlConnection _conexion = new SqlConnection(StringDeConexion);
            _conexion.Open();
            return _conexion;
        }

        public static int EjecutarComando(string pConsulta)
        {
            SqlConnection _conexion = ObtenerConexion();
            SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
            int resultado = _comando.ExecuteNonQuery();
            _conexion.Close();
            return resultado;
        }

        public static SqlDataReader EjecutarComandoReader(string pConsulta)
        {
            SqlConnection _conexion = ObtenerConexion();
            SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
            SqlDataReader _reader = _comando.ExecuteReader(CommandBehavior.CloseConnection);
            return _reader;
        }
    }
}
