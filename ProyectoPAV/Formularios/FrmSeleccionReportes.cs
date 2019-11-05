using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Formularios.Forms_Reportes;

namespace ProyectoPAV.Formularios
{
    public partial class FrmSeleccionReportes : Form
    {
        public FrmSeleccionReportes()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmReporteProductos form = new FrmReporteProductos();
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmReportesClientes form = new FrmReportesClientes();
            form.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmReportesVentas form = new FrmReportesVentas();
            form.ShowDialog();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmReportesEmpleados form = new FrmReportesEmpleados();
            form.ShowDialog();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmReportesProveedores form = new FrmReportesProveedores();
            form.ShowDialog();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            FrmReportesCompras form = new FrmReportesCompras();
            form.ShowDialog();
        }
    }
}
