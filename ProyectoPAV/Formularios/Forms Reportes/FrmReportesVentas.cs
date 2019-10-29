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
using System.Data.OleDb;
using Microsoft.ReportingServices;
using Microsoft.Reporting.WinForms;
using ProyectoPAV.Clases;

namespace ProyectoPAV.Formularios.Forms_Reportes
{
    public partial class FrmReportesVentas : Form
    {
        public string cadenaConexion = "Provider=SQLNCLI11;Data Source=DESKTOP-FHCPBI9" + "\u005C" + "SQLEXPRESS01;Integrated Security=SSPI;Initial Catalog=ProyectoPAV";
        public FrmReportesVentas()
        {
            InitializeComponent();
        }

        private void FrmReportesVentas_Load(object sender, EventArgs e)
        {
            comboBoxEmpleado = CargadorCombos.CargarComboEmpleado(comboBoxEmpleado);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT v.IdVenta as IdVenta, (CONCAT(e.Apellido,'  ', e.Nombre)) as NEmpleado,
                        (CONCAT(c.Apellido,'  ', c.Nombre)) as NCliente,
                        v.FechaVenta as FechaVenta, v.MontoTotal as MontoTotal
                        FROM Venta v JOIN Empleado e ON v.IdEmpleado = e.IdEmpleado JOIN Cliente c ON v.IdCliente = c.IdCliente
                        WHERE e.IdEmpleado = " + comboBoxEmpleado.SelectedValue;


            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            ventasBindingSource.DataSource = tabla;
            reportViewerVentas.RefreshReport();
            reportViewerVentas.ZoomMode = ZoomMode.PageWidth;
            conexion.Close();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT (CONCAT(e.Apellido,'  ', e.Nombre)) as NEmpleado, COUNT(*) as Cantidad
                        FROM Venta v JOIN Empleado e ON v.IdEmpleado = e.IdEmpleado
                        WHERE YEAR(v.FechaVenta) = " + textBoxAño.Text + " GROUP BY CONCAT(e.Apellido,'  ', e.Nombre)";



            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            Estadistica1BindingSource.DataSource = tabla;
            reportViewerEstadisticas.RefreshReport();
            conexion.Close();
        }

        private void Reporte2_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime fechaHasta = Convert.ToDateTime(dateTimePicker2.Value);

            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT v.IdVenta as IdVenta, (CONCAT(e.Apellido,'  ', e.Nombre)) as NEmpleado,
                        (CONCAT(c.Apellido,'  ', c.Nombre)) as NCliente,
                        v.FechaVenta as FechaVenta, v.MontoTotal as MontoTotal
                        FROM Venta v JOIN Empleado e ON v.IdEmpleado = e.IdEmpleado JOIN Cliente c ON v.IdCliente = c.IdCliente
                        WHERE v.FechaVenta BETWEEN '" + fechaDesde.ToString("MM-dd-yyyy") + "' AND '" + fechaHasta.ToString("MM-dd-yyyy")+ "'";


            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            ventasBindingSource1.DataSource = tabla;
            reportViewerReporte2.RefreshReport();
            reportViewerReporte2.ZoomMode = ZoomMode.PageWidth;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT MONTH(v.FechaVenta) as Mes, SUM(v.MontoTotal) as Ganancia
                        FROM Venta v JOIN Empleado e ON v.IdEmpleado = e.IdEmpleado
                        WHERE YEAR(v.FechaVenta) = YEAR(GETDATE())
                        GROUP BY MONTH(v.FechaVenta)";



            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            Estadistica2BindingSource.DataSource = tabla;
            reportViewerEstadistica2.RefreshReport();
            conexion.Close();
        }
    }
}
