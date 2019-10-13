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

            comboMarca = CargadorCombos.CargarComboMarca(comboMarca);
        }

        private void FrmProductosNuevo_Load(object sender, EventArgs e)
        {
            comboCategoria = CargadorCombos.CargarComboCategoria(comboCategoria);
            comboMarca = CargadorCombos.CargarComboMarca(comboMarca);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ControlDatos control = new ControlDatos();
            ProductosABM productos = new ProductosABM();

            if (control.validarIngresoTextBox(textBoxCodigo) && control.validarIngresoTextBox(textBoxNombre)
                && control.validarIngresoTextBox(textBoxCantidad) && control.validarIngresoTextBox(textBoxTalle)
                && control.validarIngresoComboBox(comboMarca)&& control.validarIngresoComboBox(comboCategoria))
            {
                string cadenaResultado;
            
                cadenaResultado = productos.InsertarProducto(this.textBoxCodigo.Text, Int32.Parse(this.textBoxTalle.Text), 
                    this.textBoxNombre.Text, Int32.Parse(this.comboMarca.SelectedValue.ToString()), 
                    Int32.Parse(this.comboCategoria.SelectedValue.ToString()), Int32.Parse(this.textBoxCantidad.Text)).ToString();
                MessageBox.Show(productos.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            comboMarca.SelectedIndex = -1;
            comboCategoria.SelectedIndex = -1;
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxCantidad.Clear();
            textBoxTalle.Clear();
        }
    
    }
}
