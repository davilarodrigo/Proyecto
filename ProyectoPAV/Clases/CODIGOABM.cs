using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV.Clases;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPAV.Clases
{
    class CodigoABM
    {
        //public DataTable consultarClientes(string patron)
        //{
        //    BE BD = new BE();
        //    string sql = @"SELECT u.*, p.n_perfil
        //                     FROM users u join perfiles p ON u.id_perfil = p.id_perfil 
        //                     WHERE n_usuario like '%" + patron + "%'";
        //    return BD.ejecutar_consulta(sql);
        //}
        public DataTable ConsultarProveedores(string razonsocial)
        {
            BEConexionBaseDatos BD = new BEConexionBaseDatos();
            string sql = @"SELECT P.*, L.Nombre
                             FROM Proveedor P join Localidad L ON P.IdLocalidad = L.IdLocalidad
                            WHERE " + razonsocial + "= P.RazonSocial";
            return BD.ejecutar_consulta(sql);
        }

        public void InsertarLocalidad(string Nombre)
        {
            string sql_insert = "";
            sql_insert = @"INSERT INTO Localidad (Nombre) VALUES ('" + Nombre +"')";
            BEConexionBaseDatos _BD = new BEConexionBaseDatos();
            if (_BD.insertar(sql_insert) ==
                BEConexionBaseDatos.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente los datos");
            }
            else
            {
                MessageBox.Show("No se cargó correctamente los datos");
            }
        }

        public DataTable ConsultarLocalidades()
        {
            BEConexionBaseDatos BD = new BEConexionBaseDatos();
            string sql = @"SELECT *
                             FROM Localidad";
            return BD.ejecutar_consulta(sql);
        }

        public void EliminarLocalidad(string Nombre)
        {
            string sql_insert = "";
            sql_insert = @"DELETE FROM Localidad WHERE Nombre = '" + Nombre + "'";
            BEConexionBaseDatos _BD = new BEConexionBaseDatos();
            if (_BD.eliminar(sql_insert) ==
                BEConexionBaseDatos.estado_BE.correcto)
            {
                MessageBox.Show("Se elimino correctamente los datos");
            }
            else
            {
                MessageBox.Show("No se elimino correctamente los datos");
            }
        }
    }
}
