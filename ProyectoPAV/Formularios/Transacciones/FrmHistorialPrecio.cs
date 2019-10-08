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
using System.Windows.Forms;
using ProyectoPAV.Clases;
using ProyectoPAV.Formularios;
using ProyectoPAV.Formularios.Transacciones;

namespace ProyectoPAV.Formularios.Auxiliares
{
    public partial class FrmHistorialPrecio : Form
    {
        string cadenaResultado;
       
        public FrmHistorialPrecio()
        {
            InitializeComponent();
        }

        private void FrmHistorialPrecio_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador = new CargadorCombos();
            DataTable tabla = new DataTable();

            tabla = cargador.CargarComboProductos();

            ComboProductos.DataSource = tabla;
            ComboProductos.DisplayMember = "CodigoProducto";
            ComboProductos.ValueMember = "IdProducto";
            ComboProductos.SelectedIndex = -1;
            consulta();
        }

        public void consulta()
        {
            ProductosABM historiales = new ProductosABM();
            string selectedValue;
            DataTable tabla = new DataTable();
            if (ComboProductos.SelectedValue == null)
            {
                selectedValue = "0";
            }
            else
            {
                selectedValue = this.ComboProductos.SelectedValue.ToString();
            }
            cadenaResultado = historiales.consultarPrecio(selectedValue).ToString();
            if (cadenaResultado == "correcto")
            {
                tabla = historiales.tablaProducto;
                this.CargarGrilla(tabla);
            }
            else
            {
                MessageBox.Show(historiales.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            dataGridHisotiralPrecio.DataSource = tabla;
            dataGridHisotiralPrecio.Columns[0].Visible = false;
            dataGridHisotiralPrecio.Columns[1].Visible = false;
            dataGridHisotiralPrecio.Columns[2].HeaderText = "Numero Talle";
            dataGridHisotiralPrecio.Columns[3].HeaderText = "Fecha Inicio";
            dataGridHisotiralPrecio.Columns[4].HeaderText = "Fecha Fin";
            dataGridHisotiralPrecio.Columns[5].HeaderText = "Precio Proveedor";
            dataGridHisotiralPrecio.Columns[6].HeaderText = "Precio Publico";
            dataGridHisotiralPrecio.Columns[7].HeaderText = "Codigo Producto";
            dataGridHisotiralPrecio.Columns[7].DisplayIndex = 1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmNuevoHistorialPrecio precio = new FrmNuevoHistorialPrecio();
            precio.ShowDialog();
            consulta();
        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
