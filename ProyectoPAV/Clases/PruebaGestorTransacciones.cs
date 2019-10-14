using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.Clases
{
    public class PruebaGestorTransacciones
    {

        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        string cadena_conexion = "Provider=SQLNCLI11;Data Source=.;Integrated Security=SSPI;Initial Catalog=ProyectoPAV";
        //static string cadena_conexion = "Provider=SQLNCLI11;Data Source=DESKTOP-FHCPBI9" + "\u005C" + "SQLEXPRESS01;Integrated Security=SSPI;Initial Catalog=ProyectoPAV";

        OleDbTransaction transaccion;
        
        public void confirmar()
        {
            transaccion.Commit();
            desconectar();
        }

        public void CancelarTransaccion()
        {
            transaccion.Rollback();
            desconectar();
        }
               
        private void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadena_conexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;

                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadUncommitted);
                    cmd.Transaction = transaccion;                
            }
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
            try
            {
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error con la Base de Datos" + "\n"
                  + "En el comando:" + "\n"
                  + sql + "\n"
                  + "El mensaje es:" + "\n"
                  + e.Message);
            }
            return tabla;
        }

        public void ejecutar_no_select(string sql)
        {
            conectar();
            cmd.CommandText = sql;

            try
            {
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error con la Base de Datos" + "\n"
                  + "En el comando:" + "\n"
                  + sql + "\n"
                  + "El mensaje es:" + "\n"
                  + e.Message);
            }
        }
    }
}
