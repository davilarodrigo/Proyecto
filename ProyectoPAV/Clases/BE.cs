using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoPAV.Clases
{
    class BE
    {
        public enum estado_BE { correcto, error }
        static string conexion = "server = DESKTOP-0B3JQNF\\SQLEXPRESS; database = TP PAV; integrated security = true";
        SqlConnection conex = new SqlConnection(conexion);
        SqlCommand comando = new SqlCommand();

        private void conectar()
        {
            conex.ConnectionString = conexion;
            conex.Open();
            comando.Connection = conex;
            comando.CommandType = CommandType.Text;
        }

        private void desconectar()
        {
            conex.Close();
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
