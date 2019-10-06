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
using System.Data;
using ProyectoPAV.Formularios.Transacciones;

namespace ProyectoPAV.Formularios
{
    
    public partial class FrmClienteTransaccion : Form
    {

        public string FormularioPadre { get; set; }

        public FrmClienteTransaccion()
        {
            InitializeComponent();
            
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {

            ClientesABM clientes = new ClientesABM();
            string cadenaResultado;
            DataTable tabla = new DataTable();

            if (this.textBoxNombre.Text != "" || this.textBoxApellido.Text != "")
            {
                cadenaResultado = clientes.ConsultarClientesFiltros(this.textBoxNombre.Text, this.textBoxApellido.Text,
                "0", "").ToString();
                if (cadenaResultado == "correcto")
                {
                    tabla = clientes.tablaCliente;
                    this.cargarGrilla(tabla);
                }
                else
                {
                    MessageBox.Show(clientes.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.consultar();
            }
        }

        public void cargarGrilla(DataTable tabla)
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

        private void FrmClienteTransaccion_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void consultar()
        {   ClientesABM clientes = new ClientesABM();
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

        private void botonNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmClientesNuevo frmCliente = new FrmClientesNuevo();
            frmCliente.ShowDialog();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                if (FormularioPadre == "Ventas")
                {
                    FrmVentasNueva nuevaVenta = Owner as FrmVentasNueva;
                    nuevaVenta.IdCliente = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                }
                if (FormularioPadre == "Reservas")
                {
                    FrmReservaNueva nuevaReservas = Owner as FrmReservaNueva;
                    nuevaReservas.IdCliente = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                }
                this.Dispose();
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
