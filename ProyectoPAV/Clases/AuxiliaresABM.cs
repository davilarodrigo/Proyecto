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
    class AuxiliaresABM
    {
        //public DataTable consultarClientes(string patron)
        //{
        //    BE BD = new BE();
        //    string sql = @"SELECT u.*, p.n_perfil
        //                     FROM users u join perfiles p ON u.id_perfil = p.id_perfil 
        //                     WHERE n_usuario like '%" + patron + "%'";
        //    return BD.ejecutar_consulta(sql);
        //}
        //public DataTable ConsultarProveedores(string razonsocial)
        //{
        //    BEConexionBaseDatos BD = new BEConexionBaseDatos();
        //    string sql = @"SELECT P.*, L.Nombre
        //                     FROM Proveedor P join Localidad L ON P.IdLocalidad = L.IdLocalidad
        //                    WHERE " + razonsocial + "= P.RazonSocial";
        //    return BD.ejecutar_consulta(sql);
        //}

        public void InsertarAuxiliares(string Nombre, string Tabla)
        {
            string sql_insert = "";
            sql_insert = @"INSERT INTO "+ Tabla +" (Nombre) VALUES ('" + Nombre +"')";
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

        public DataTable ConsultarAuxiliares(string Tabla)
        {
            BEConexionBaseDatos BD = new BEConexionBaseDatos();
            string sql = @"SELECT *
                             FROM " + Tabla;
            return BD.ejecutar_consulta(sql);
        }

        public void EliminarAuxiliares(string Nombre, string Tabla)
        {
            string sql_delete = "";
            sql_delete = @"DELETE FROM "+ Tabla + " WHERE Nombre = '" + Nombre + "'";
            BEConexionBaseDatos _BD = new BEConexionBaseDatos();
            if (_BD.eliminar(sql_delete) ==
                BEConexionBaseDatos.estado_BE.correcto)
            {
                MessageBox.Show("Se elimino correctamente los datos");
            }
            else
            {
                MessageBox.Show("No se elimino correctamente los datos");
            }
        }

        public void cargarGrillaAuxiliares(DataTable tabla, DataGridView grilla)
        {
            grilla.DataSource = tabla;
            grilla.Columns[0].Visible = false;
            grilla.Columns[1].HeaderText = "Nombre";

        }
    }
}