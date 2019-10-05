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

namespace ProyectoPAV.Formularios
{
    public partial class FrmVentasNueva : Form
    {
        public FrmVentasNueva()
        {
            InitializeComponent();
        }

        private void FrmVentasNueva_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaLocalidades = new DataTable();
            DataTable tablaEmpleado = new DataTable();

            tablaEmpleado = cargador.CargarComboEmpleados();

            ComboEmpleado.DataSource = tablaEmpleado;
            ComboEmpleado.DisplayMember = "Apellido";
            ComboEmpleado.ValueMember = "IdEmpleado";
            ComboEmpleado.SelectedIndex = -1;

            consultarClientes();
        }

        private void consultarClientes()
        {
            ClientesABM clientes = new ClientesABM();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            cadenaResultado = clientes.ConsultarClientes().ToString();
            tabla = clientes.tablaCliente;
            if (cadenaResultado == "correcto")
            {
               cargarGrilla(tabla);
            }
            else
            {
                MessageBox.Show(clientes.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected void cargarGrilla(DataTable tabla)
        {
            dgvClientes.DataSource = tabla;
            dgvClientes.DataSource = tabla;
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[3].Visible = false;
            dgvClientes.Columns[5].Visible = false;
            dgvClientes.Columns[11].Visible = false;
            dgvClientes.Columns[1].HeaderText = "Apellido";
            dgvClientes.Columns[2].HeaderText = "Nombre";
            dgvClientes.Columns[4].HeaderText = "Documento";
            dgvClientes.Columns[6].HeaderText = "Fecha de Nacimiento";
            dgvClientes.Columns[7].HeaderText = "Email";
            dgvClientes.Columns[8].HeaderText = "Telefono";
            dgvClientes.Columns[9].HeaderText = "Calle";
            dgvClientes.Columns[10].HeaderText = "Numero";
            dgvClientes.Columns[12].HeaderText = "Tipo Documento";
            dgvClientes.Columns[13].HeaderText = "Localidad";
            dgvClientes.Columns[13].HeaderText = "Sexo";
            dgvClientes.Columns[12].DisplayIndex = 0;
            dgvClientes.Columns[4].DisplayIndex = 1;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FrmClientesNuevo frmCliente = new FrmClientesNuevo();
            frmCliente.ShowDialog();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
