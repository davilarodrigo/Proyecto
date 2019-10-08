using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoPAV.Clases
{
    class GestorCompras
    {
        public enum ResultadoCompras { correcto, error }
        public DataTable tablaCompras;
        public DataTable tablaDetallesCompras;
        public string mensajeRetorno;

        public ResultadoCompras ConsultarComprasFiltros(string razonSocial, string fechaDesde, string fechaHasta)
        {
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            ResultadoCompras resultado = new ResultadoCompras();
            string sql = @"SELECT c.IdCompra,
                           c.FechaCompra as Fecha,
                           p.RazonSocial as Proveedor,
                           c.MontoTotal as 'Monto Total'  
                           FROM Compra c JOIN Proveedor p on c.IdProveedor = p.IdProveedor ";

            string where = @"WHERE";
            if (razonSocial != "")
            {
                where = where + " p.Proveedor like '%" + razonSocial + "%' AND ";
            }
            if (fechaDesde != fechaHasta)
            {
                where = where + " c.FechaCompra BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "' AND ";
            }

            int largoCadena = where.Length - 5;
            string whereFinal = "";
            whereFinal = where.Substring(0, largoCadena);
            sql = sql + whereFinal;

            DataTable dt = new DataTable();
            if (gestor.EjecutarConsulta(sql) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                tablaCompras = gestor.TablaResultado;
                resultado = ResultadoCompras.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoCompras.error;
            }

            return resultado;
        }

        public ResultadoCompras ConsultarCompras()
        {
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            ResultadoCompras resultado = new ResultadoCompras();
            string sql = @"SELECT c.IdCompra,
                           c.FechaCompra as Fecha,
                           p.RazonSocial as Proveedor,
                           c.MontoTotal as 'Monto Total'  
                           FROM Compra c JOIN Proveedor p on c.IdProveedor = p.IdProveedor ";
            if (gestor.EjecutarConsulta(sql) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                tablaCompras = gestor.TablaResultado;
                resultado = ResultadoCompras.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoCompras.error;
            }

            return resultado;
        }

        public ResultadoCompras ConsultarDetallesCompra(int idCompra)
        {
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            ResultadoCompras resultado = new ResultadoCompras();
            string sql = @"SELECT c.IdCompra, p.Nombre as Producto,
                           p.NumeroTalle as 'Numero Talle',
                           dc.Cantidad as Cantidad,
                           dc.PrecioUnitario as 'Precio Unitario'
                           FROM Compra c JOIN DetalleCompra dc on c.IdCompra = dc.IdCompra 
                           JOIN Producto p on p.IdProducto = dc.IdProducto
                           WHERE dc.IdCompra = " + idCompra + ";";
            if (gestor.EjecutarConsulta(sql) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                tablaDetallesCompras = gestor.TablaResultado;
                resultado = ResultadoCompras.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoCompras.error;
            }

            return resultado;
        }

    }
}
