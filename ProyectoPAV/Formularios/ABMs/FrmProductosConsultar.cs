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
    public partial class FrmProductosConsultar : Form
    {
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

        public FrmProductosConsultar()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductosNuevo nuevoProducto = new FrmProductosNuevo();
            nuevoProducto.ShowDialog();
            Consulta();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.CurrentRow != null)
            {
                FrmProductosModificar modificarProducto = new FrmProductosModificar();
                modificarProducto.IdProducto = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
                modificarProducto.ShowDialog();
                Consulta();
            }
            else
            {
                MessageBox.Show("Para modificar primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmProductosConsultar_Load(object sender, EventArgs e)
        {
            this.Consulta();

            comboCategorias = CargadorCombos.CargarComboCategoria(comboCategorias);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
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

        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            this.textBoxNombreProducto.Clear();
            this.textBoxMarca.Clear();
            this.comboCategorias.SelectedIndex = -1;
            this.Consulta();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.CurrentRow != null)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el Empleado?", "Importante!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ProductosABM producto = new ProductosABM();
                    int ID = Int32.Parse(dataGridProductos.CurrentRow.Cells[0].Value.ToString());
                    producto.EliminarProducto(ID);
                    MessageBox.Show(producto.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Consulta();
                }
            }
            else
            {
                MessageBox.Show("Para eliminar primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }
    }
}
