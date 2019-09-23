using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPAV.Clases
{
    class EmpleadosABM
    {
        public DataTable ConsultarEmpleadosFiltros(string nombre, string apellido, string tipoDoc, int numeroDoc)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            string sql = @"SELECT E.*, TD.Nombre, C.Nombre, S.Nombre
                             FROM Empleado E JOIN TipoDocumento TD ON E.IdTipoDocumento = TD.IdTipoDocumento
                                JOIN Cargo C ON E.IdCargo = C.IdCargo JOIN Sexo S ON E.IdSexo = S.IdSexo
                            WHERE E.Nombre = '" + nombre + "' AND E.Apellido = '" + apellido + "' AND TD.Nombre = '" + 
                            tipoDoc + "' AND E.NumeroDocumento = " + numeroDoc;
            DataTable dt = new DataTable();

            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                dt = gestor.TablaResultado;
            }
            else
            {
                MessageBox.Show("No se consultaron correctamente los datos debido a: " +
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public DataTable ConsultarEmpleados()
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            string sql = @"SELECT E.*, TD.Nombre, C.Nombre, S.Nombre
                             FROM Empleado E JOIN TipoDocumento TD ON E.IdTipoDocumento = TD.IdTipoDocumento
                                JOIN Cargo C ON E.IdCargo = C.IdCargo JOIN Sexo S ON E.IdSexo = S.IdSexo";
            DataTable dt = new DataTable();

            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                dt = gestor.TablaResultado;
            }
            else
            {
                MessageBox.Show("No se consultaron correctamente los datos debido a: " +
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public void InsertarEmpleado(int idTipoDoc, int numeroDoc, string apellido, string nombre, 
                                    int idSexo, DateTime fechaNacimiento, string email, int telefono, 
                                    int idCargo)
        {
            string sql_insert = "";
            DateTime fechaAlta = DateTime.Now;
            sql_insert = @"INSERT INTO Empleado VALUES (" + idTipoDoc + "," + " " + numeroDoc + "," +
                                                        " '" + apellido + "'," + " '" + nombre + "'," +
                                                        " " + idSexo + "," + " " + fechaNacimiento + "," +
                                                        " '" + email + "'," + " " + telefono + "," +
                                                        " " + idCargo + ", "+ fechaAlta + ", NULL)";
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            if (gestor.Insertar(sql_insert) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                MessageBox.Show("Se cargaron correctamente los datos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO se cargaron correctamente los datos debido a: " +
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarEmpleado(int IdEmpleado)
        {
            string sql_delete = "";
            sql_delete = @"DELETE FROM Empleado WHERE IdEmpleado = " + IdEmpleado;
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            if (gestor.Eliminar(sql_delete) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                MessageBox.Show("Se eliminaron correctamente los datos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO se eliminaron correctamente los datos debido a: " +
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable RecuperarDatos(string id)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            string sql = "SELECT * FROM Empleado WHERE IdEmpleado = " + id;
            DataTable dt = new DataTable();

            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                dt = gestor.TablaResultado;
            }
            else
            {
                MessageBox.Show("No se consultaron correctamente los datos debido a: " +
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
            //GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            //return gestor.EjecutarConsulta("SELECT * FROM Proveedor WHERE IdProveedor = " + id);

        }

        public void ModificarEmpleado(int idEmpleado,int idTipoDoc, int numeroDoc, string apellido, string nombre,
                                    int idSexo, DateTime fechaNacimiento, string email, int telefono,
                                    int idCargo)
        {
            string sql_modificar = "";
            sql_modificar = @"UPDATE Proveedor SET IdTipoDocumento = " + idTipoDoc + "," +
                                                        "NumeroDocumento = " + numeroDoc + "," +
                                                        "Apellido = '" + apellido + "'," +
                                                        "Nombre = '" + nombre + "'," +
                                                        "IdSexo = " + idSexo + "," +
                                                        "FechaNacimiento = " + fechaNacimiento +
                                                        "Email = '" + email + "'," +
                                                        "Telefono = " + telefono +
                                                        "IdCargo = " + idCargo +
                                                        " WHERE IdEmpleado = " + idEmpleado;
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            if (gestor.Insertar(sql_modificar) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                MessageBox.Show("Se cargaron correctamente los datos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO se cargaron correctamente los datos debido a: " +
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
