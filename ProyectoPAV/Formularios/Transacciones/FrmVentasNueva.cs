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

namespace ProyectoPAV.Formularios
{
    public partial class FrmVentasNueva : Form
    {
        public string IdCliente { get; set; }
        public string IdProducto { get; set; }
        List<string> Productos = new List<string>();
        public FrmVentasNueva()
        {
            InitializeComponent();
        }

        private void FrmVentasNueva_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaLocalidades = new DataTable();
            DataTable tablaEmpleado = new DataTable();

            tablaEmpleado = cargador.CargarComboEmpleados();

            ComboEmpleado.DataSource = tablaEmpleado;
            ComboEmpleado.DisplayMember = "Apellido";
            ComboEmpleado.ValueMember = "IdEmpleado";
            ComboEmpleado.SelectedIndex = -1;
        }

       
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botonAsignarCliente_Click(object sender, EventArgs e)
        {
            IdCliente = "";
            FrmClienteTransaccion ventasCliente = new FrmClienteTransaccion();
            ventasCliente.FormularioPadre = "Ventas";
            AddOwnedForm(ventasCliente);
            ventasCliente.ShowDialog();
            if (IdCliente != "") recuperarDatosCliente();
        }

        private void recuperarDatosCliente()
        {
            ClientesABM cliente = new ClientesABM();
            DataTable tabla = new DataTable();
            tabla = cliente.RecuperarDatos(IdCliente);
            labeNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            labelApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            labelNumeroDoc.Text = tabla.Rows[0]["NumeroDocumento"].ToString();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            IdProducto = "";
            FrmProductosTransacciones ventasProducto = new FrmProductosTransacciones();
            ventasProducto.FormularioPadre = "Ventas";
            AddOwnedForm(ventasProducto);
            ventasProducto.ShowDialog();

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
            dataGridCarrito.DataSource = tabla;
            dataGridCarrito.Columns[0].Visible = false;
            dataGridCarrito.Columns[4].Visible = false;
            dataGridCarrito.Columns[5].Visible = false;
            dataGridCarrito.Columns[1].HeaderText = "Codigo Producto";
            dataGridCarrito.Columns[2].HeaderText = "Numero Talle";
            dataGridCarrito.Columns[3].HeaderText = "Nombre";
            dataGridCarrito.Columns[6].HeaderText = "StockDisponible";
            dataGridCarrito.Columns[7].HeaderText = "Marca";
            dataGridCarrito.Columns[8].HeaderText = "Categoria";


            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCarrito.CurrentRow != null)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar este Producto?", "Importante!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    
                    DataTable tabla = new DataTable();
                    ProductosABM productos = new ProductosABM();

                    string ID;
                    ID = dataGridCarrito.CurrentRow.Cells[0].Value.ToString();

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
                    if (dataGridCarrito.Rows.Count != 2)
                    {
                        tabla = productos.RecuperarDatosLista(Productos);
                        CargarGrilla(tabla);
                    }
                    else
                    {
                        dataGridCarrito.Columns.Clear();
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
