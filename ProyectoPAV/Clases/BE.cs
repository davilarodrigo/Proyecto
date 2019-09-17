using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProyectoPAV.Clases
{
    class BE
    {
        public enum estado_BE { correcto, error }
        string cadena_conexion = "";
        //CAMBIAR CADENA DE CONEXION
        //EJEMPLO DE CONEXION string cadena_conexion = "Provider=SQLNCLI11;Data Source=maquis;User ID=avisuales1;Initial Catalog=_TRATAMIENTO_ERRORES_3k3;password=avisuales1";
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        private void conectar()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable ejecutar_consulta(string sql)
        {
            conectar();
            DataTable tabla = new DataTable();
            cmd.CommandText = sql;
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
        public estado_BE insertar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }
    }
}
