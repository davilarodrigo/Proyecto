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
        public enum ResultadoProveedores { correcto, error }
        public DataTable tablaProveedor;
        public string mensajeRetorno;
        public ResultadoProveedores ConsultarProveedoresFiltros(string razonsocial)
        {
            ResultadoProveedores resultado = new ResultadoProveedores();
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            string sql = @"SELECT P.*, L.Nombre
                             FROM Proveedor P JOIN Localidad L ON P.IdLocalidad = L.IdLocalidad
                            WHERE P.RazonSocial LIKE '%" + razonsocial + "%'";

            if (gestor.EjecutarConsulta(sql) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                tablaProveedor = gestor.TablaResultado;
                resultado = ResultadoProveedores.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProveedores.error;

            }

            return resultado;
        }

        public ResultadoProveedores ConsultarProveedores()
        {
            ResultadoProveedores resultado = new ResultadoProveedores();
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            string sql = "SELECT P.*, L.Nombre FROM Proveedor P JOIN Localidad L ON P.IdLocalidad = L.IdLocalidad";

            if (gestor.EjecutarConsulta(sql) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                tablaProveedor = gestor.TablaResultado;
                resultado = ResultadoProveedores.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProveedores.error;

            }

            return resultado;
        }

        public ResultadoProveedores InsertarProveedor(string razonSocial, string calle, int numeroCalle, int idLocalidad, string email, int telefono)
        {
            ResultadoProveedores resultado = new ResultadoProveedores();
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            string sql_insert = "";
            sql_insert = @"INSERT INTO Proveedor VALUES ('" + razonSocial + "'," +
                                                        " '" + calle + "'," +
                                                        " " + numeroCalle + "," +
                                                        " " + idLocalidad + "," +
                                                        " '" + email + "'," +
                                                        " " + telefono + ")";
            if (gestor.Insertar(sql_insert) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se cargaron correctamente los datos";
                resultado = ResultadoProveedores.correcto;
            }
            else
            {
                mensajeRetorno = "NO se cargaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProveedores.error;
            }

            return resultado;
        }

        public ResultadoProveedores EliminarProveedor(int IdProveedor)
        {
            string sql_delete = "";
            sql_delete = @"DELETE FROM Proveedor WHERE IdProveedor = " + IdProveedor;
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            ResultadoProveedores resultado = new ResultadoProveedores();
            if (gestor.Eliminar(sql_delete) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se eliminaron correctamente los datos";
                resultado = ResultadoProveedores.correcto;
            }
            else
            {
                mensajeRetorno = "NO se eliminaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProveedores.error;
            }
            return resultado;
        }

        public DataTable RecuperarDatos(string id)
        {
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            string sql = "SELECT * FROM Proveedor WHERE IdProveedor = " + id;
            tablaProveedor = gestor.TablaResultado;
            gestor.EjecutarConsulta(sql);
            //if (gestor.EjecutarConsulta(sql) ==
            //    GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            //{
            //    dt = gestor.TablaResultado;
            //}
            //else
            //{
            //    MessageBox.Show("No se consultaron correctamente los datos debido a: " +
            //        gestor.mensajeErrorTransaccion, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            return tablaProveedor;
            //GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            //return gestor.EjecutarConsulta("SELECT * FROM Proveedor WHERE IdProveedor = " + id);

        }

        public ResultadoProveedores ModificarProveedor(int idProveedor,  string razonSocial, string calle, int numeroCalle, int idLocalidad, string email, int telefono)
        {
            string sql_modificar = "";
            sql_modificar = @"UPDATE Proveedor SET RazonSocial = '" + razonSocial + "'," +
                                                        "Calle = '" + calle + "'," +
                                                        "NumeroCalle = " + numeroCalle + "," +
                                                        "IdLocalidad = " + idLocalidad + "," +
                                                        "Email = '" + email + "'," +
                                                        "Telefono = " + telefono +
                                                        " WHERE IdProveedor = " + idProveedor;
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            ResultadoProveedores resultado = new ResultadoProveedores();
            if (gestor.Insertar(sql_modificar) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se cargaron correctamente los datos";
                resultado = ResultadoProveedores.correcto;
            }
            else
            {
                mensajeRetorno = "NO se cargaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProveedores.error;
            }

            return resultado;
        }
    }
}
