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

namespace ProyectoPAV.Formularios.Transacciones
{
    public partial class FrmCompraNueva : Form
    {
        public string IdProducto { get; set; }
        public FrmCompraNueva()
        {
            InitializeComponent();
        }

        private void FrmCompraNueva_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaEmpleado = new DataTable();

            tablaEmpleado = cargador.CargarComboEmpleados();

            ComboEmpleado.DataSource = tablaEmpleado;
            ComboEmpleado.DisplayMember = "Apellido";
            ComboEmpleado.ValueMember = "IdEmpleado";
            ComboEmpleado.SelectedIndex = -1;

            CargadorCombos cargador2 = new CargadorCombos();
            DataTable tablaProveedores = new DataTable();

            tablaProveedores = cargador.CargarComboProveedores();

            ComboProveedor.DataSource = tablaEmpleado;
            ComboProveedor.DisplayMember = "RazonSocial";
            ComboProveedor.ValueMember = "IdProveedor";
            ComboProveedor.SelectedIndex = -1;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            IdProducto = "";
            FrmProductosTransacciones comprasProducto = new FrmProductosTransacciones();
            comprasProducto.FormularioPadre = "Compras";
            AddOwnedForm(comprasProducto);
            comprasProducto.ShowDialog();

            DataTable tabla = new DataTable();
            ProductosABM productos = new ProductosABM();
            if (IdProducto != "")
            {
                tabla = productos.RecuperarDatos(IdProducto);
                CargarGrilla(tabla);
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            dataGridPedido.DataSource = tabla;
            dataGridPedido.Columns[0].Visible = false;
            dataGridPedido.Columns[1].HeaderText = "Codigo Producto";
            dataGridPedido.Columns[2].HeaderText = "Numero Talle";
            dataGridPedido.Columns[3].HeaderText = "Nombre";
            dataGridPedido.Columns[6].HeaderText = "StockDisponible";
            dataGridPedido.Columns[4].HeaderText = "Marca";
            dataGridPedido.Columns[5].HeaderText = "Categoria";
        }
    }
}
