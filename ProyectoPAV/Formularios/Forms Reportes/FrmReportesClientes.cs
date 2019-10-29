using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Resources;
using System.Data.SqlClient;
using Microsoft.ReportingServices;
using Microsoft.Reporting.WinForms;
using System.Data.OleDb;

namespace ProyectoPAV.Formularios.Forms_Reportes
{
    public partial class FrmReportesClientes : Form
    {
        public string cadenaConexion = "Provider=SQLNCLI11;Data Source=DESKTOP-FHCPBI9" + "\u005C" + "SQLEXPRESS01;Integrated Security=SSPI;Initial Catalog=ProyectoPAV";
        public FrmReportesClientes()
        {
            InitializeComponent();
        }

        private void FrmReportesClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            int mes;
            mes = ValidarMes(textBoxMes.Text);
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT c.IdCliente as IdCliente, c.Apellido as Apellido,
                        c.Nombre as Nombre, s.Nombre as Sexo, c.FechaNacimiento as FechaNacimiento
                        FROM Cliente c JOIN Sexo s ON c.IdSexo = s.IdSexo
                        WHERE MONTH(c.FechaNacimiento) = " + mes;


            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            clientesBindingSource.DataSource = tabla;
            reportViewerClientes.RefreshReport();
            reportViewerClientes.ZoomMode = ZoomMode.PageWidth;
            conexion.Close();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT s.Nombre as Genero, COUNT(*) as Cantidad
                        FROM Cliente c JOIN Sexo s ON c.IdSexo = s.IdSexo
                        GROUP BY s.Nombre";

            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            EstadisticaBindingSource.DataSource = tabla;
            reportViewerEstadisticas.RefreshReport();
            conexion.Close();
        }

        private int ValidarMes(string mes)
        {
            if (mes == "Enero" || mes == "enero")
            {
                return 1;
            }
            if (mes == "Febrero" || mes == "febrero")
            {
                return 2;
            }
            if (mes == "Marzo" || mes == "marzo")
            {
                return 3;
            }
            if (mes == "Abril" || mes == "abril")
            {
                return 4;
            }
            if (mes == "Mayo" || mes == "mayo")
            {
                return 5;
            }
            if (mes == "Junio" || mes == "junio")
            {
                return 6;
            }
            if (mes == "Julio" || mes == "julio")
            {
                return 7;
            }
            if (mes == "Agosto" || mes == "agosto")
            {
                return 8;
            }
            if (mes == "Septiembre" || mes == "septiembre")
            {
                return 9;
            }
            if (mes == "Octubre" || mes == "octubre")
            {
                return 10;
            }
            if (mes == "Noviembre" || mes == "noviembre")
            {
                return 11;
            }
            if (mes == "Diciembre" || mes == "diciembre")
            {
                return 12;
            }
            return 0;
        }

        private void Reporte2_Click(object sender, EventArgs e)
        {
            int mes;
            mes = ValidarMes(textBoxMesCompra.Text);
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT DISTINCT c.IdCliente as IdCliente, c.Apellido as Apellido,
                        c.Nombre as Nombre, s.Nombre as Sexo, c.FechaNacimiento as FechaNacimiento
                        FROM Cliente c JOIN Sexo s ON c.IdSexo = s.IdSexo JOIN Venta v ON
                        c.IdCliente = v.IdCliente
                        WHERE MONTH(v.FechaVenta) = " + mes;


            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            clientesBindingSource1.DataSource = tabla;
            reportViewerReporte2.RefreshReport();
            reportViewerReporte2.ZoomMode = ZoomMode.PageWidth;
            conexion.Close();
        }

        private void Estadistica2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT CONCAT(c.Apellido,' ',c.Nombre) as Cliente, COUNT(*) as Cantidad
                        FROM Cliente c JOIN Venta v ON c.IdCliente = v.IdCliente
                        GROUP BY CONCAT(c.Apellido,' ',c.Nombre)";

            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            estadistica2BindingSource1.DataSource = tabla;
            reportViewerEstadistica2.RefreshReport();
            conexion.Close();
        }
    }
}
