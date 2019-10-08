using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoPAV.Clases
{
    class GestorReservas
    {

        public enum ResultadoReservas { correcto, error }
        public DataTable tablaReservas;
        public string mensajeRetorno;

        public ResultadoReservas ConsultarReservasFiltros(string nombre, string apellido, string fechaDesde,
                                string fechaHasta, bool venceHoy, bool vencido)
        {
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            ResultadoReservas resultado = new ResultadoReservas();
            string sql = @"SELECT r.IdReserva,
                           r.FechaRealizacion as 'Fecha Realizacion',
                           r.FechaVencimiento as 'Fecha Vencimiento',
                           concat(c.Nombre, ' ', c.Apellido) as Cliente,
                           r.MontoReserva as 'Monto Reserva',
                           p.Nombre as Producto,
                           r.Canidad as Cantidad,
                           r.NumeroTalle as 'Numero Talle'
                           FROM Reserva r JOIN Producto p on r.IdProducto = p.IdProducto
                           JOIN Cliente c on c.IdCliente = r.IdCliente ";

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
                where = where + " r.FechaRealizacion BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "' AND ";
            }

            if (venceHoy)
            {
                where = where + " r.FechaVencimiento = GETDATE() AND ";
            }

            if (vencido)
            {
                where = where + " r.FechaVencimiento > GETDATE() AND ";
            }

            int largoCadena = where.Length - 5;
            string whereFinal = "";
            whereFinal = where.Substring(0, largoCadena);
            sql = sql + whereFinal;

            DataTable dt = new DataTable();
            if (gestor.EjecutarConsulta(sql) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                tablaReservas = gestor.TablaResultado;
                resultado = ResultadoReservas.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoReservas.error;
            }

            return resultado;
        }

        public ResultadoReservas ConsultarReservas()
        {
            GestorSentenciasSimples gestor = new GestorSentenciasSimples();
            ResultadoReservas resultado = new ResultadoReservas();
            string sql = @"SELECT r.IdReserva,
                           r.FechaRealizacion as 'Fecha Realizacion',
                           r.FechaVencimiento as 'Fecha Vencimiento',
                           concat(c.Nombre, ' ', c.Apellido) as Cliente,
                           r.MontoReserva as 'Monto Reserva',
                           p.Nombre as Producto,
                           r.Canidad as Cantidad,
                           r.NumeroTalle as 'Numero Talle'
                           FROM Reserva r JOIN Producto p on r.IdProducto = p.IdProducto
                           JOIN Cliente c on c.IdCliente = r.IdCliente ";

            if (gestor.EjecutarConsulta(sql) ==
                GestorSentenciasSimples.ResultadoTransaccion.correcto)
            {
                tablaReservas = gestor.TablaResultado;
                resultado = ResultadoReservas.correcto;
            }
            else
            {
                mensajeRetorno = "No se consultaron correctamente los datos debido a: " + gestor.mensajeErrorTransaccion;
                resultado = ResultadoReservas.error;
            }

            return resultado;
        }
    }
}
