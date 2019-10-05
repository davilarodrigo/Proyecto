using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Clases
{
    class GestorVentas
    {
        public enum ResultadoClientes { correcto, error }
        public DataTable tablaCliente;
        public string mensajeRetorno;
        public ResultadoClientes ConsultarVentas(string nombre="", string apellido = "", string tipoDoc = "", string numeroDoc = "")
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoClientes resultado = new ResultadoClientes();
            string sql = @"select v.FechaVenta as Fecha,
                           concat(e.Nombre, ' ', e.Apellido) as Empleado,
                           concat(c.Nombre, ' ', c.Apellido) as Cliente,
                           v.MontoTotal as 'Monto Total'  
                           from Venta v join Empleado e on v.IdEmpleado = e.IdEmpleado 
                           join Cliente c on c.IdCliente = v.IdCliente;";

            string where = @"WHERE ";
            if (nombre != "")
            {
                where = where + "C.Nombre like '%" + nombre + "%' AND ";
            }

            if (apellido != "")
            {
                where = where + "C.Apellido like '%" + apellido + "%' AND ";
            }

            if (tipoDoc != "0")
            {
                where = where + "C.IdTipoDocumento = " + tipoDoc + " AND ";
            }

            if (numeroDoc != "")
            {
                where = where + "C.NumeroDocumento = " + numeroDoc + " AND ";
            }

            int largoCadena = where.Length - 5;
            string whereFinal = "";
            whereFinal = where.Substring(0, largoCadena);
            sql = sql + whereFinal;

            DataTable dt = new DataTable();
            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaCliente = gestor.TablaResultado;
                resultado = ResultadoClientes.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoClientes.error;
            }

            return resultado;
        }

        public ResultadoClientes ConsultarClientes()
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoClientes resultado = new ResultadoClientes();
            string sql = @"SELECT C.*, TD.Nombre, L.Nombre, S.Nombre
                           FROM Cliente C JOIN TipoDocumento TD ON C.IdTipoDocumento = TD.IdTipoDocumento
                           JOIN Localidad L ON C.IdLocalidad = L.IdLocalidad JOIN Sexo S ON C.IdSexo = S.IdSexo";

            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaCliente = gestor.TablaResultado;
                resultado = ResultadoClientes.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoClientes.error;
            }

            return resultado;
        }

        public ResultadoClientes InsertarCliente(string apellido, string nombre, int idTipoDoc, int numeroDoc,
                                    int idSexo, string fechaNacimiento, string email, int telefono,
                                    string calle, int numeroCalle, int idLocalidad)
        {
            string sql_insert = "";
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoClientes resultado = new ResultadoClientes();

            sql_insert = @"INSERT INTO Cliente VALUES ('" + apellido + "'," + " '" + nombre + "'," +
                                                        " " + idTipoDoc + "," + " " + numeroDoc + "," +
                                                        " " + idSexo + "," + " '" + fechaNacimiento + "'," +
                                                        " '" + email + "'," + " " + telefono + "," +
                                                        " '" + calle + "', " + " " + numeroCalle + "," +
                                                        " " + idLocalidad + ")";
            if (gestor.Insertar(sql_insert) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se cargaron correctamente los datos";
                resultado = ResultadoClientes.correcto;
            }
            else
            {
                mensajeRetorno = "NO se cargaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoClientes.error;
            }
            return resultado;
        }

        public ResultadoClientes EliminarCliente(int IdCliente)
        {
            string sql_delete = "";
            sql_delete = @"DELETE FROM Cliente WHERE IdCliente = " + IdCliente;
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoClientes resultado = new ResultadoClientes();
            if (gestor.Eliminar(sql_delete) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se eliminaron correctamente los datos";
                resultado = ResultadoClientes.correcto;
            }
            else
            {
                mensajeRetorno = "NO se eliminaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoClientes.error;
            }
            return resultado;
        }

        public DataTable RecuperarDatos(string id)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            string sql = "SELECT * FROM Cliente WHERE IdCliente = " + id;
            tablaCliente = gestor.TablaResultado;
            gestor.EjecutarConsulta(sql);

            return tablaCliente;

        }

        public ResultadoClientes ModificarCliente(int idCliente, string apellido, string nombre, int idTipoDoc, int numeroDoc,
                                    int idSexo, string fechaNacimiento, string email, int telefono,
                                    string calle, int numeroCalle, int idLocalidad)
        {
            string sql_modificar = "";
            sql_modificar = @"UPDATE Cliente SET Apellido = '" + apellido + "'," +
                                                        " Nombre = '" + nombre + "'," +
                                                        " IdTipoDocumento = " + idTipoDoc + "," +
                                                        " NumeroDocumento = " + numeroDoc + "," +
                                                        " IdSexo = " + idSexo + "," +
                                                        " FechaNacimiento = '" + fechaNacimiento + "'," +
                                                        " Email = '" + email + "'," +
                                                        " Telefono = " + telefono + "," +
                                                        " Calle = '" + calle + "'," +
                                                        " NumeroCalle = " + numeroCalle + "," +
                                                        " IdLocalidad = " + idLocalidad +
                                                        " WHERE IdCliente = " + idCliente;
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoClientes resultado = new ResultadoClientes();
            if (gestor.Insertar(sql_modificar) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se cargaron correctamente los datos";
                resultado = ResultadoClientes.correcto;
            }
            else
            {
                mensajeRetorno = "NO se cargaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoClientes.error;
            }

            return resultado;
        }
    }
}
