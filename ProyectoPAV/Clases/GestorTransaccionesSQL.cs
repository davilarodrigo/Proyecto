using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProyectoPAV.Clases
{
    class GestorTransaccionesSQL
    {
        public enum ResultadoTransaccion { correcto, error }
        public enum FormaConexion { simple, transaccion }
        //+ "\u005C" +
        //RODO
        static string cadenaConexion = "Provider=SQLNCLI11;Data Source=DESKTOP-FHCPBI9" + "\u005C" + "SQLEXPRESS01;Integrated Security=SSPI;Initial Catalog=ProyectoPAV";


        //intento de cadena de conexion universal (a lucas no le funciona)
        //static string cadenaConexion = "Provider=SQLNCLI11;Data Source=.;Integrated Security=SSPI;Initial Catalog=ProyectoPAV";
        OleDbConnection conexion = new OleDbConnection(cadenaConexion);
        OleDbCommand comando = new OleDbCommand();
        OleDbTransaction transaccion;

        // LUCAS 
        //static string cadenaConexion = "server = DESKTOP-0B3JQNF\\SQLEXPRESS; database = TP PAV; integrated security = true";
        //SqlConnection conexion = new SqlConnection(cadenaConexion);
        //SqlCommand comando = new SqlCommand();

        public string mensajeErrorTransaccion;
        public DataTable TablaResultado = new DataTable();
        private void Conectar(bool modoTransaccion = false)
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

        public DataTable consultarTabla(string sql, bool informarError =true)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = sql;
            try
            {
                tabla.Load(comando.ExecuteReader());
            }
            catch(Exception x)
            {
                MessageBox.Show("No se pudo cargar la tabla: " + x);
            }
            Desconectar();
            return tabla;
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
