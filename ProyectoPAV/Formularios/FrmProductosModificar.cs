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
    public partial class FrmProductosModificar : Form
    {
        public string IdProducto { get; set; }
        ProductosABM productos = new ProductosABM();

        public FrmProductosModificar()
        {
            InitializeComponent();
        }
        private void RecuperarDatos(string idProducto)
        {

            DataTable tabla = new DataTable();
            tabla = productos.RecuperarDatos(idProducto);
            this.textBoxNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            this.textBoxCodigo.Text = tabla.Rows[0]["CodigoProducto"].ToString();
            this.textBoxCantidad.Text = tabla.Rows[0]["StockDisponible"].ToString();
            this.textBoxTalle.Text = tabla.Rows[0]["NumeroTalle"].ToString();
            this.comboMarca.SelectedValue = int.Parse(tabla.Rows[0]["IdMarca"].ToString());
            this.comboCategoria.SelectedValue = int.Parse(tabla.Rows[0]["IdCategoria"].ToString());
            
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

        private void FrmProductosModificar_Load(object sender, EventArgs e)
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

            this.RecuperarDatos(IdProducto);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ControlDatos control = new ControlDatos();
            ProductosABM producto = new ProductosABM();

            if (control.validarIngresoTextBox(textBoxCodigo) && control.validarIngresoTextBox(textBoxNombre)
                && control.validarIngresoTextBox(textBoxCantidad) && control.validarIngresoTextBox(textBoxTalle)
                && control.validarIngresoComboBox(comboMarca) && control.validarIngresoComboBox(comboCategoria))
            {

               
                producto.ModificarProducto(Int32.Parse(this.IdProducto)
                                , this.textBoxCodigo.Text
                                , Int32.Parse(this.textBoxTalle.Text.ToString())
                                , this.textBoxNombre.Text
                                , Int32.Parse(this.comboMarca.SelectedValue.ToString())
                                , Int32.Parse(this.comboCategoria.SelectedValue.ToString())
                                , Int32.Parse(this.textBoxCantidad.Text));
                MessageBox.Show(producto.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
