using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoPAV.Clases
{
    class ProductosABM
    {
        public enum ResultadoProductos { correcto, error }
        public DataTable tablaProducto;
        public string mensajeRetorno;

        public ResultadoProductos ConsultarProductosFiltros(string nombre, string marca, string categoria)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoProductos resultado = new ResultadoProductos();
            string sql = @"SELECT P.*, M.Nombre, C.Nombre
                             FROM Producto P JOIN Marca M ON P.IdMarca = M.IdMarca
                                JOIN Categoria C ON P.IdCategoria = C.IdCategoria ";

            string where = @"WHERE ";
            if (nombre != "")
            {
                where = where + "P.Nombre like '%" + nombre + "%' AND ";
            }

            if (marca != "")
            {
                where = where + "M.Nombre like '%" + marca + "%' AND ";
            }

            if (categoria != "0")
            {
                where = where + "C.IdCategoria = " + categoria + " AND ";
            }

            int largoCadena = where.Length - 5;
            string whereFinal = "";
            whereFinal = where.Substring(0, largoCadena);
            sql = sql + whereFinal;

            DataTable dt = new DataTable();
            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaProducto = gestor.TablaResultado;
                resultado = ResultadoProductos.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProductos.error;
            }

            return resultado;
        }

        public ResultadoProductos ConsultarProductos()
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoProductos resultado = new ResultadoProductos();
            string sql = @"SELECT P.*, M.Nombre, C.Nombre
                             FROM Producto P JOIN Marca M ON P.IdMarca = M.IdMarca
                                JOIN Categoria C ON P.IdCategoria = C.IdCategoria";

            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaProducto = gestor.TablaResultado;
                resultado = ResultadoProductos.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProductos.error;
            }

            return resultado;
        }

        public ResultadoProductos InsertarProducto(string codigoProducto, int talle, string nombre, int idMarca,
                                    int idCategoria, int stock, int precio=1500)
        {
            string sql_insert = "";
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoProductos resultado = new ResultadoProductos();

            sql_insert = @"INSERT INTO Producto VALUES ('" + codigoProducto + "'," + " " + talle + "," +
                                                        " '" + nombre + "'," + " " + idMarca + "," +
                                                        " " + idCategoria + ", " + stock + ", " + precio + ")";
            if (gestor.Insertar(sql_insert) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se cargaron correctamente los datos";
                resultado = ResultadoProductos.correcto;
            }
            else
            {
                mensajeRetorno = "NO se cargaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProductos.error;
            }
            return resultado;
        }

        public ResultadoProductos EliminarProducto(int IdProducto)
        {
            string sql_delete = "";
            sql_delete = @"DELETE FROM Producto WHERE IdProducto = " + IdProducto;
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoProductos resultado = new ResultadoProductos();
            if (gestor.Eliminar(sql_delete) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se eliminaron correctamente los datos";
                resultado = ResultadoProductos.correcto;
            }
            else
            {
                mensajeRetorno = "NO se eliminaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProductos.error;
            }
            return resultado;
        }

        public DataTable RecuperarDatos(string id)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            string sql = "SELECT * FROM Producto WHERE IdProducto = " + id;
            tablaProducto = gestor.TablaResultado;
            gestor.EjecutarConsulta(sql);

            return tablaProducto;

        }
        public ResultadoProductos ModificarProducto(int idProduto, string codigo, int talle, string nombre, 
                                            int idMarca, int idCategoria, int stockDisponible)
        {
            string sql_modificar = "";
            sql_modificar = @"UPDATE Producto SET CodigoProducto = '" + codigo + "'," +
                                                        " NumeroTalle = " + talle + "," +
                                                        " Nombre = '" + nombre + "'," +
                                                        " IdMarca = " + idMarca + "," +
                                                        " IdCategoria = " + idCategoria + "," +
                                                        " StockDisponible = " + stockDisponible +
                                                        " WHERE IdProducto = " + idProduto;
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoProductos resultado = new ResultadoProductos();
            if (gestor.Insertar(sql_modificar) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                mensajeRetorno = "Se cargaron correctamente los datos";
                resultado = ResultadoProductos.correcto;
            }
            else
            {
                mensajeRetorno = "NO se cargaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoProductos.error;
            }

            return resultado;
        }

        public DataTable RecuperarDatosLista(List<string> Productos)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            string sql = @"SELECT P.*, M.Nombre, C.Nombre FROM Producto P
                JOIN Marca M ON P.IdMarca = M.IdMarca JOIN Categoria C ON
                P.IdCategoria = C.IdCategoria WHERE    P.IdProducto =";
            tablaProducto = gestor.TablaResultado;

            foreach (var IdProducto in Productos)
            {
                sql += " " + IdProducto + " OR P.IdProducto =";
            }

            int largoCadena = sql.Length - 17;
            string whereFinal = "";
            whereFinal = sql.Substring(0, largoCadena);
            gestor.EjecutarConsulta(whereFinal);

            return tablaProducto;
        }
    }
}
