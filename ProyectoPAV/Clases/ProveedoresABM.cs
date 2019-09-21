using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPAV.Clases
{
    class ProveedoresABM
    {
        public DataTable ConsultarProveedoresRazonSocial(string razonsocial)
        {
            BEConexionBaseDatos BD = new BEConexionBaseDatos();
            string sql = @"SELECT P.*, L.Nombre
                             FROM Proveedor P JOIN Localidad L ON P.IdLocalidad = L.IdLocalidad
                            WHERE P.RazonSocial = '" + razonsocial + "'";
            return BD.ejecutar_consulta(sql);
        }

        public DataTable ConsultarProveedores()
        {
            BEConexionBaseDatos BD = new BEConexionBaseDatos();
            string sql = @"SELECT P.*, L.Nombre
                             FROM Proveedor P JOIN Localidad L ON P.IdLocalidad = L.IdLocalidad";
            return BD.ejecutar_consulta(sql);
        }

        public void InsertarProveedor(string razonSocial, string calle, int numeroCalle, int idLocalidad, string email, int telefono)
        {
            string sql_insert = "";
            sql_insert = @"INSERT INTO Proveedor VALUES ('" + razonSocial + "'," +
                                                        " '" + calle + "'," +
                                                        " " + numeroCalle + "," +
                                                        " " + idLocalidad + "," +
                                                        " '" + email + "'," +
                                                        " " + telefono + ")";
            BEConexionBaseDatos BD = new BEConexionBaseDatos();
            if (BD.insertar(sql_insert) ==
                BEConexionBaseDatos.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente los datos");
            }
            else
            {
                MessageBox.Show("No se cargó correctamente los datos");
            }
        }

        public void EliminarProveedores(int IdProveedor)
        {
            string sql_delete = "";
            sql_delete = @"DELETE FROM Proveedor WHERE IdProveedor = " + IdProveedor;
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

        public DataTable recuperarDatos(string id)
        {
            BEConexionBaseDatos BD = new BEConexionBaseDatos();
            return BD.ejecutar_consulta("SELECT * FROM Proveedor WHERE IdProveedor = " + id);

        }

        public void ModificarProveedor(string idProveedor,  string razonSocial, string calle, int numeroCalle, int idLocalidad, string email, int telefono)
        {
            string sql_modificar = "";
            sql_modificar = @"UPDATE Proveedor SET RazonSocial = '" + razonSocial + "'," +
                                                        "Calle = '" + calle + "'," +
                                                        "NumeroCalle = " + numeroCalle + "," +
                                                        "IdLocalidad = " + idLocalidad + "," +
                                                        "Email = '" + email + "'," +
                                                        "Telefono = " + telefono +
                                                        " WHERE IdProveedor = " + idProveedor;
            BEConexionBaseDatos BD = new BEConexionBaseDatos();
            if (BD.insertar(sql_modificar) ==
                BEConexionBaseDatos.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente los datos");
            }
            else
            {
                MessageBox.Show("No se cargó correctamente los datos");
            }
        }
    }
}
