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
using ProyectoPAV.Formularios.Transacciones;

namespace ProyectoPAV.Formularios.Transacciones
{
    public partial class FrmProductosTransacciones : Form
    {
        public string FormularioPadre { get; set; }
        public FrmProductosTransacciones()
        {
            InitializeComponent();
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

                if (FormularioPadre == "Ventas")
                {
                    FrmVentasNueva nuevaVenta = Owner as FrmVentasNueva;
                    nuevaVenta.IdProducto = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
                }
                if (FormularioPadre == "Compras")
                {
                    FrmCompraNueva nuevaCompra= Owner as FrmCompraNueva;
                    nuevaCompra.IdProducto = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmProductosTransacciones_Load(object sender, EventArgs e)
        {

            this.Consulta();

            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaCategorias = new DataTable();

            tablaCategorias = cargador.CargarComboCategorias();

            comboCategorias.DataSource = tablaCategorias;
            comboCategorias.DisplayMember = "Nombre";
            comboCategorias.ValueMember = "IdCategoria";
            comboCategorias.SelectedIndex = -1;
        }

        private void botonNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmProductosNuevo nuevoProducto = new FrmProductosNuevo();
            nuevoProducto.ShowDialog();
        }
    }
}
