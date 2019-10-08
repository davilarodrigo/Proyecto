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
        public enum ResultadoVentas { correcto, error }
        public DataTable tablaVentas;
        public DataTable tablaDetallesVentas;
        public string mensajeRetorno;

        public ResultadoVentas ConsultarVentasFiltros(string nombre, string apellido, string fechaDesde, string fechaHasta)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoVentas resultado = new ResultadoVentas();
            string sql = @"SELECT v.IdVenta,
                           v.FechaVenta as Fecha,
                           concat(e.Nombre, ' ', e.Apellido) as Empleado,
                           concat(c.Nombre, ' ', c.Apellido) as Cliente,
                           v.MontoTotal as 'Monto Total'  
                           FROM Venta v JOIN Empleado e on v.IdEmpleado = e.IdEmpleado 
                           JOIN Cliente c on c.IdCliente = v.IdCliente ";

            string where = @"WHERE";
            if (nombre != "")
            {
                where = where + " c.Nombre like '%" + nombre + "%' AND ";
            }

            if (apellido != "")
            {
                where = where + " c.Apellido like '%" + apellido + "%' AND ";
            }
            if (fechaDesde != fechaHasta)
            {
                where = where + " v.FechaVenta BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "' AND ";
            }

            int largoCadena = where.Length - 5;
            string whereFinal = "";
            whereFinal = where.Substring(0, largoCadena);
            sql = sql + whereFinal;

            DataTable dt = new DataTable();
            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaVentas = gestor.TablaResultado;
                resultado = ResultadoVentas.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoVentas.error;
            }

            return resultado;
        }

        public ResultadoVentas ConsultarVentas()
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoVentas resultado = new ResultadoVentas();
            string sql = @"SELECT v.IdVenta,
                           v.FechaVenta as Fecha,
                           concat(e.Nombre, ' ', e.Apellido) as Empleado,
                           concat(c.Nombre, ' ', c.Apellido) as Cliente,
                           v.MontoTotal as 'Monto Total'  
                           FROM Venta v JOIN Empleado e on v.IdEmpleado = e.IdEmpleado 
                           JOIN Cliente c on c.IdCliente = v.IdCliente ";
            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaVentas = gestor.TablaResultado;
                resultado = ResultadoVentas.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoVentas.error;
            }

            return resultado;
        }

        public ResultadoVentas ConsultarDetallesVenta(int idVenta)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            ResultadoVentas resultado = new ResultadoVentas();
            string sql = @"SELECT v.IdVenta, p.Nombre as Producto,
                           p.NumeroTalle as 'Numero Talle',
                           dv.Monto as 'Monto'  
                           FROM Venta v JOIN DetalleVenta dv on v.IdVenta = dv.IdVenta 
                           JOIN Producto p on p.IdProducto = dv.IdProducto
                           WHERE dv.IdVenta = " + idVenta+";";
            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                tablaDetallesVentas = gestor.TablaResultado;
                resultado = ResultadoVentas.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoVentas.error;
            }

            return resultado;
        }

    }
}
