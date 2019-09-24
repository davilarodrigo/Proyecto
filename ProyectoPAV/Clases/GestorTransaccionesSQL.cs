using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ProyectoPAV.Clases
{
    class GestorTransaccionesSQL
    {
        public enum ResultadoTransaccion { correcto, error }
        //+ "\u005C" +
        //RODO
        //static string cadenaConexion = "Provider=SQLNCLI11;Data Source=DESKTOP-FHCPBI9" + "\u005C" + "SQLEXPRESS01;Integrated Security=SSPI;Initial Catalog=ProyectoPAV";
        //OleDbConnection conexion = new OleDbConnection(cadenaConexion);
        //OleDbCommand comando = new OleDbCommand();

        // LUCAS 
        static string cadenaConexion = "server = DESKTOP-0B3JQNF\\SQLEXPRESS; database = TP PAV; integrated security = true";
        SqlConnection conexion = new SqlConnection(cadenaConexion);
        SqlCommand comando = new SqlCommand();

        public string mensajeErrorTransaccion;
        public DataTable TablaResultado = new DataTable();
        private void Conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public ResultadoTransaccion EjecutarConsulta(string sql)
        {
            this.Conectar();
            TablaResultado.Clear();
            this.comando.CommandText = sql;
            ResultadoTransaccion resultado = ResultadoTransaccion.correcto;

            try
            {
                TablaResultado.Load(comando.ExecuteReader());
            }
            catch(Exception excepcion)
            {
                mensajeErrorTransaccion = excepcion.Message;
                resultado = ResultadoTransaccion.error;
            }

           //tabla.Load(comando.ExecuteReader());
            Desconectar();
            return resultado;
        }
        public ResultadoTransaccion Insertar(string sql)
        {
            this.Conectar();
            this.comando.CommandText = sql;
            ResultadoTransaccion resultado = ResultadoTransaccion.correcto;

            try
            {
                this.comando.ExecuteNonQuery();
            }
            catch (Exception excepcion)
            {
                mensajeErrorTransaccion = excepcion.Message;
                resultado = ResultadoTransaccion.error;
            }

            this.Desconectar();
            return resultado;

        }
        public ResultadoTransaccion Eliminar(string sql)
        {
            this.Conectar();
            this.comando.CommandText = sql;
            ResultadoTransaccion resultado = ResultadoTransaccion.correcto;
            try
            {
                this.comando.ExecuteNonQuery();
            }
            catch (Exception excepcion)
            {
                mensajeErrorTransaccion = excepcion.Message;
                resultado = ResultadoTransaccion.error;
            }

            this.Desconectar();
            return resultado;
        }
    }
}
