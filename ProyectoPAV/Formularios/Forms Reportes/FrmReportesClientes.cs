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
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand comando = new OleDbCommand();
            DataTable tabla = new DataTable();
            string sql = @"SELECT c.IdCliente as IdCliente, c.Apellido as Apellido,
                        c.Nombre as Nombre, s.Nombre as Sexo, c.FechaNacimiento as FechaNacimiento
                        FROM Cliente c JOIN Sexo s ON c.IdSexo = s.IdSexo";


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
    }
}
