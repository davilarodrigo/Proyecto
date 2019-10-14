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
using ProyectoPAV.Formularios;

namespace ProyectoPAV.Formularios.Transacciones
{
    public partial class FrmReservaNueva : Form
    {
        public string IdCliente { get; set; }
        public FrmReservaNueva()
        {
            InitializeComponent();
        }

        private void FrmReservaNueva_Load(object sender, EventArgs e)
        {
            this.Consulta();

            comboCategorias = CargadorCombos.CargarComboCategoria(comboCategorias);
            comboEmpleado = CargadorCombos.CargarComboEmpleado(comboEmpleado);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botonAsignarCliente_Click(object sender, EventArgs e)
        {
            IdCliente = "";
            FrmClienteTransaccion reservaCliente = new FrmClienteTransaccion();
            reservaCliente.FormularioPadre = "Reservas";
            AddOwnedForm(reservaCliente);
            reservaCliente.ShowDialog();
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

        private void Consulta()
        {
            ProductosABM productos = new ProductosABM();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            cadenaResultado = productos.ConsultarProductos().ToString();
            tabla = productos.tablaProducto;
            if (cadenaResultado == "correcto")
            {
                this.CargarGrilla(tabla);
            }
            else
            {
                MessageBox.Show(productos.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarGrilla(DataTable tabla)
        {
            dataGridProductos.DataSource = tabla;
            dataGridProductos.Columns[0].Visible = false;
            dataGridProductos.Columns[4].Visible = false;
            dataGridProductos.Columns[5].Visible = false;
            dataGridProductos.Columns[1].HeaderText = "Codigo Producto";
            dataGridProductos.Columns[2].HeaderText = "Numero Talle";
            dataGridProductos.Columns[3].HeaderText = "Nombre";
            dataGridProductos.Columns[6].HeaderText = "StockDisponible";
            dataGridProductos.Columns[7].HeaderText = "Marca";
            dataGridProductos.Columns[8].HeaderText = "Categoria";
        }

        private void botonBuscarProducto_Click(object sender, EventArgs e)
        {
            ProductosABM productos = new ProductosABM();
            string cadenaResultado;
            string selectedValue = "";
            DataTable tabla = new DataTable();

            if (comboCategorias.SelectedValue == null)
            {
                selectedValue = "0";
            }
            else
            {
                selectedValue = this.comboCategorias.SelectedValue.ToString();
            }

            if (this.textBoxNombreProducto.Text != "" || this.textBoxMarca.Text != ""
                || selectedValue != "0")
            {

                cadenaResultado = productos.ConsultarProductosFiltros(this.textBoxNombreProducto.Text, this.textBoxMarca.Text,
                selectedValue).ToString();
                if (cadenaResultado == "correcto")
                {
                    tabla = productos.tablaProducto;
                    this.CargarGrilla(tabla);
                }
                else
                {
                    MessageBox.Show(productos.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Consulta();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.CurrentRow != null)
            {
                MessageBox.Show("aca va la transaccion"
                    , "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
