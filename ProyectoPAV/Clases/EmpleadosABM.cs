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
        public enum ResultadoEmpleados { correcto, error }
        public DataTable tablaEmpleado;
        public string mensajeRetorno;
        public ResultadoEmpleados ConsultarEmpleadosFiltros(string nombre, string apellido, string tipoDoc, string numeroDoc)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoEmpleados resultado = new ResultadoEmpleados();
            string sql = @"SELECT E.*, TD.Nombre, C.Nombre, S.Nombre
                           FROM Empleado E JOIN TipoDocumento TD ON E.IdTipoDocumento = TD.IdTipoDocumento
                           JOIN Cargo C ON E.IdCargo = C.IdCargo JOIN Sexo S ON E.IdSexo = S.IdSexo ";
                            
            string where = @"WHERE ";
            if (nombre != "")
            {
                where =  where + "E.Nombre like '%" + nombre + "%' AND ";
            }

            if (apellido != "")
            {
                where = where + "E.Apellido like '%" + apellido + "%' AND ";
            }

            if (tipoDoc != "0")     
            {
                where = where + "E.IdTipoDocumento = " + tipoDoc + " AND ";
            }

            if (numeroDoc != "")
            {
                where = where + "E.NumeroDocumento = " + numeroDoc + " AND ";
            }

            int largoCadena = where.Length -5;
            string whereFinal = "";
            whereFinal = where.Substring(0, largoCadena);
            sql = sql + whereFinal;

            DataTable dt = new DataTable();
            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaEmpleado = gestor.TablaResultado;
                resultado = ResultadoEmpleados.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoEmpleados.error;
            }

            return resultado;
        }

        public ResultadoEmpleados ConsultarEmpleados()
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoEmpleados resultado = new ResultadoEmpleados();
            string sql = @"SELECT E.*, TD.Nombre, C.Nombre, S.Nombre
                             FROM Empleado E JOIN TipoDocumento TD ON E.IdTipoDocumento = TD.IdTipoDocumento
                                JOIN Cargo C ON E.IdCargo = C.IdCargo JOIN Sexo S ON E.IdSexo = S.IdSexo";
            
            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaEmpleado = gestor.TablaResultado;
                resultado = ResultadoEmpleados.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoEmpleados.error;
            }

            return resultado;
        }

        public ResultadoEmpleados InsertarEmpleado(int idTipoDoc, int numeroDoc, string apellido, string nombre, 
                                    int idSexo, string fechaNacimiento, string email, int telefono, 
                                    int idCargo)
        {
            string sql_insert = "";
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoEmpleados resultado = new ResultadoEmpleados();
            
            sql_insert = @"INSERT INTO Empleado VALUES (" + idTipoDoc + "," + " " + numeroDoc + "," +
                                                        " '" + apellido + "'," + " '" + nombre + "'," +
                                                        " " + idSexo + "," + " '" + fechaNacimiento + "'," +
                                                        " '" + email + "'," + " " + telefono + "," +
                                                        " " + idCargo + ", "+ "GETDATE()" + ", NULL)";
            if (gestor.Insertar(sql_insert) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se cargaron correctamente los datos";
                resultado = ResultadoEmpleados.correcto;
            }
            else
            {
                mensajeRetorno = "NO se cargaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoEmpleados.error;
            }
            return resultado;
        }

        public ResultadoEmpleados EliminarEmpleado(int IdEmpleado)
        {
            string sql_delete = "";
            sql_delete = @"DELETE FROM Empleado WHERE IdEmpleado = " + IdEmpleado;
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoEmpleados resultado = new ResultadoEmpleados();
            if (gestor.Eliminar(sql_delete) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se eliminaron correctamente los datos";
                resultado = ResultadoEmpleados.correcto;
            }
            else
            {
                mensajeRetorno = "NO se eliminaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoEmpleados.error;
            }
            return resultado;
        }

        public DataTable RecuperarDatos(string id)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            string sql = "SELECT * FROM Empleado WHERE IdEmpleado = " + id;
            tablaEmpleado = gestor.TablaResultado;
            gestor.EjecutarConsulta(sql);
            
            return tablaEmpleado;
           
        }

        public ResultadoEmpleados ModificarEmpleado(int idEmpleado,int idTipoDoc, int numeroDoc, string apellido, string nombre,
                                    int idSexo, string fechaNacimiento, string email, int telefono,
                                    int idCargo)
        {
            string sql_modificar = "";
            sql_modificar = @"UPDATE Empleado SET IdTipoDocumento = " + idTipoDoc + "," +
                                                        " NumeroDocumento = " + numeroDoc + "," +
                                                        " Apellido = '" + apellido + "'," +
                                                        " Nombre = '" + nombre + "'," +
                                                        " IdSexo = " + idSexo + "," +
                                                        " FechaNacimiento = '" + fechaNacimiento + "'," +
                                                        " Email = '" + email + "'," +
                                                        " Telefono = " + telefono + "," +
                                                        " IdCargo = " + idCargo +
                                                        " WHERE IdEmpleado = " + idEmpleado;
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoEmpleados resultado = new ResultadoEmpleados();
            if (gestor.Insertar(sql_modificar) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se cargaron correctamente los datos";
                resultado = ResultadoEmpleados.correcto;
            }
            else
            {
                mensajeRetorno = "NO se cargaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoEmpleados.error;
            }

            return resultado;
        }
    }
}
