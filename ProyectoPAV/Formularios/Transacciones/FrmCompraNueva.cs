using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Clases;

namespace ProyectoPAV.Formularios.Transacciones
{
    public partial class FrmCompraNueva : Form
    {
        public FrmCompraNueva()
        {
            InitializeComponent();
        }

        private void FrmCompraNueva_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaEmpleado = new DataTable();

            tablaEmpleado = cargador.CargarComboEmpleados();

            ComboEmpleado.DataSource = tablaEmpleado;
            ComboEmpleado.DisplayMember = "Apellido";
            ComboEmpleado.ValueMember = "IdEmpleado";
            ComboEmpleado.SelectedIndex = -1;

            CargadorCombos cargador2 = new CargadorCombos();
            DataTable tablaProveedores = new DataTable();

            tablaProveedores = cargador.CargarComboProveedores();

            ComboProveedor.DataSource = tablaEmpleado;
            ComboProveedor.DisplayMember = "RazonSocial";
            ComboProveedor.ValueMember = "IdProveedor";
            ComboProveedor.SelectedIndex = -1;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
