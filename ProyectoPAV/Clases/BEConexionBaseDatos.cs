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
    class BEConexionBaseDatos
    {
        public enum estado_BE { correcto, error }
        //+ "\u005C" +
        static string cadenaConexion = "Provider=SQLNCLI11;Data Source=DESKTOP-FHCPBI9" + "\u005C" + "SQLEXPRESS01;Integrated Security=SSPI;Initial Catalog=ProyectoPAV";
        // LUCAS static string cadenaConexion = "server = DESKTOP-0B3JQNF\\SQLEXPRESS; database = TP PAV; integrated security = true";
        OleDbConnection conexion = new OleDbConnection(cadenaConexion);
        OleDbCommand comando = new OleDbCommand();
        //SqlConnection conexion = new SqlConnection(cadenaConexion);
        //SqlCommand comando = new SqlCommand();
        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable ejecutar_consulta(string sql)
        {
            conectar();
            DataTable tabla = new DataTable();
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public estado_BE insertar(string sql)
        {
            this.conectar();
            this.comando.CommandText = sql;
            this.comando.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }
        public estado_BE eliminar(string sql)
        {
            this.conectar();
            this.comando.CommandText = sql;
            this.comando.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }
    }
}
