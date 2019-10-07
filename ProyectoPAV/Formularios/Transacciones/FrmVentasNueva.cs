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
        public string IdCliente { get; set; }
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
        }

       
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botonAsignarCliente_Click(object sender, EventArgs e)
        {
            IdCliente = "";
            FrmClienteTransaccion ventasCliente = new FrmClienteTransaccion();
            ventasCliente.FormularioPadre = "Ventas";
            AddOwnedForm(ventasCliente);
            ventasCliente.ShowDialog();
            if (IdCliente != "") recuperarDatos();
        }

        private void recuperarDatos()
        {
            ClientesABM cliente = new ClientesABM();
            DataTable tabla = new DataTable();
            tabla = cliente.RecuperarDatos(IdCliente);
            labeNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            labelApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            labelNumeroDoc.Text = tabla.Rows[0]["NumeroDocumento"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
