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

namespace ProyectoPAV.Formularios.Transacciones
{
    public partial class FrmNuevoHistorialPrecio : Form
    {
        public FrmNuevoHistorialPrecio()
        {
            InitializeComponent();
        }

        private void FrmNuevoHistorialPrecio_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador = new CargadorCombos();
            DataTable tabla = new DataTable();

            tabla = cargador.CargarComboProductos();

            ComboProductos.DataSource = tabla;
            ComboProductos.DisplayMember = "CodigoProducto";
            ComboProductos.ValueMember = "IdProducto";
            ComboProductos.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ProductosABM historial = new ProductosABM();
            string cadenaResultado;
            string selectedValue;
            if (ComboProductos.SelectedValue == null)
            {
                selectedValue = "0";
            }
            else
            {
                selectedValue = this.ComboProductos.SelectedValue.ToString();
            }
            cadenaResultado = historial.InsertarPrecio(selectedValue, Int32.Parse(this.textBoxTalle.Text),
                Decimal.Parse(this.textBoxProv.Text), Decimal.Parse(this.textBoxPublic.Text)).ToString();
            MessageBox.Show(historial.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
