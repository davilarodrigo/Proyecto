using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Formularios.Auxiliares;
using ProyectoPAV.Clases;

namespace ProyectoPAV.Formularios
{
    public partial class FrmProductosNuevo : Form
    {
        public FrmProductosNuevo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnNuevaMarca_Click(object sender, EventArgs e)
        {
            FrmMarcas marcas = new FrmMarcas();
            marcas.ShowDialog();

            CargadorCombos cargador3 = new CargadorCombos();
            DataTable tablaMarcas = new DataTable();

            tablaMarcas = cargador3.CargarComboMarcas();

            comboMarca.DataSource = tablaMarcas;
            comboMarca.DisplayMember = "Nombre";
            comboMarca.ValueMember = "IdMarca";
            comboMarca.SelectedIndex = -1;
        }

        private void FrmProductosNuevo_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador4 = new CargadorCombos();
            DataTable tablaMarcas = new DataTable();
            DataTable tablaCategorias = new DataTable();

            tablaMarcas = cargador4.CargarComboMarcas();

            comboMarca.DataSource = tablaMarcas;
            comboMarca.DisplayMember = "Nombre";
            comboMarca.ValueMember = "IdMarca";
            comboMarca.SelectedIndex = -1;

            CargadorCombos cargador2 = new CargadorCombos();

            tablaCategorias = cargador2.CargarComboCategorias();

            comboCategoria.DataSource = tablaCategorias;
            comboCategoria.DisplayMember = "Nombre";
            comboCategoria.ValueMember = "IdCategoria";
            comboCategoria.SelectedIndex = -1;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string cadenaResultado;
            ProductosABM productos = new ProductosABM();
            cadenaResultado = productos.InsertarProducto(this.textBoxCodigo.Text, Int32.Parse(this.textBoxTalle.Text), 
                this.textBoxNombre.Text, Int32.Parse(this.comboMarca.SelectedValue.ToString()), 
                Int32.Parse(this.comboCategoria.SelectedValue.ToString()), Int32.Parse(this.textBoxCantidad.Text)).ToString();
            MessageBox.Show(productos.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
