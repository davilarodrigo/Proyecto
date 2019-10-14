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
        List<string> Productos = new List<string>();
        public FrmCompraNueva()
        {
            InitializeComponent();
        }

        private void FrmCompraNueva_Load(object sender, EventArgs e)
        {
            comboProveedor = CargadorCombos.CargarComboProveedor(comboProveedor);
            comboEmpleado = CargadorCombos.CargarComboEmpleado(comboEmpleado);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

            PruebaGestorTransacciones gestor=new PruebaGestorTransacciones();
            IdProducto = "";
            FrmProductosTransacciones comprasProducto = new FrmProductosTransacciones(gestor);
            comprasProducto.FormularioPadre = "Compras";
            AddOwnedForm(comprasProducto);
            comprasProducto.ShowDialog();

            DataTable tabla = new DataTable();
            ProductosABM productos = new ProductosABM();
            if (IdProducto != "")
            {
                Productos.Add(IdProducto);


                tabla = productos.RecuperarDatosLista(Productos);
                CargarGrilla(tabla);

            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            dataGridPedido.DataSource = tabla;
            dataGridPedido.Columns[0].Visible = false;
            dataGridPedido.Columns[4].Visible = false;
            dataGridPedido.Columns[5].Visible = false;
            dataGridPedido.Columns[1].HeaderText = "Codigo Producto";
            dataGridPedido.Columns[2].HeaderText = "Numero Talle";
            dataGridPedido.Columns[3].HeaderText = "Nombre";
            dataGridPedido.Columns[6].HeaderText = "StockDisponible";
            dataGridPedido.Columns[7].HeaderText = "Marca";
            dataGridPedido.Columns[8].HeaderText = "Categoria";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridPedido.CurrentRow != null)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar este Producto?", "Importante!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    DataTable tabla = new DataTable();
                    ProductosABM productos = new ProductosABM();

                    string ID;
                    ID = dataGridPedido.CurrentRow.Cells[0].Value.ToString();

                    string borrar;
                    borrar = "0";


                    foreach (var IdProducto in Productos)
                    {
                        if (IdProducto == ID)
                        {
                            borrar = IdProducto;
                        }
                    }
                    Productos.Remove(borrar);
                    if (dataGridPedido.Rows.Count != 2)
                    {
                        tabla = productos.RecuperarDatosLista(Productos);
                        CargarGrilla(tabla);
                    }
                    else
                    {
                        dataGridPedido.Columns.Clear();
                    }
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
