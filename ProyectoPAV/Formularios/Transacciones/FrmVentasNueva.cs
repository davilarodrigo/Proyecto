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

        string idventa;
        PruebaGestorTransacciones gestor;
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

            gestor = new PruebaGestorTransacciones();
            gestor.inicio_transaccion();
            string sql = @"insert Venta values (1,1,GETDATE(),0);";


            

            //aca se genera una venta
            gestor.insertar(sql);

            //obtener id d la venta

            DataTable table = new DataTable();
            table=gestor.ejecutar_consulta(@"select max(IdVenta) from Venta;");
            labelIdVenta.Text = table.Rows[0][0].ToString();

            idventa = table.Rows[0][0].ToString();
            actualizarcarrito();


        }



        private void BtnSalir_Click(object sender, EventArgs e)
        {
            gestor.CancelarTransaccion();
            this.Dispose();
        }

        private void botonAsignarCliente_Click(object sender, EventArgs e)
        {
            IdCliente = "";
            FrmClienteTransaccion ventasCliente = new FrmClienteTransaccion();
            ventasCliente.FormularioPadre = "Ventas";
            AddOwnedForm(ventasCliente);
            ventasCliente.ShowDialog();
            if (IdCliente != "")
            {
                recuperarDatosCliente();
                gestor.modificar(@"UPDATE Venta SET IdCliente = " + IdCliente + " WHERE IdVenta = " + idventa + ";");
            }
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


        protected void actualizarcarrito()
        {

//            dataGridCarrito.DataSource = gestor.ejecutar_consulta(@"select IdProducto,Monto from DetalleVenta where IdVenta=" + idventa + " ;");
            //            dataGridCarrito.DataSource = gestor.ejecutar_consulta(@"select IdProducto,Monto from DetalleVenta where IdVenta=" + idventa + " ;");
            dataGridCarrito.DataSource = gestor.ejecutar_consulta(@"select dv.IdProducto,dv.Monto,p.Nombre,p.NumeroTalle,m.Nombre as Marca from DetalleVenta dv left join producto p on dv.IdProducto = p.IdProducto join marca m on p.IdMarca = m.IdMarca where dv.IdVenta =" + idventa + " ;");

            //            dataGridCarrito.DataSource = gestor.ejecutar_consulta(@"select dv.IdProducto,dv.Monto,p.Nombre,p.NumeroTalle,m.Nombre as Marca from DetalleVenta dv join producto p on dv.IdDetalleVenta=p.IdProducto join marca m on p.IdMarca = m.IdMarca where dv.IdVenta=" + idventa + " ;");
        }
        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

            FrmProductosTransacciones ventasProducto = new FrmProductosTransacciones(gestor,idventa);
            ventasProducto.ShowDialog();

            actualizarcarrito();


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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string idempleado = ComboEmpleado.SelectedValue.ToString();
            gestor.modificar(@"UPDATE Venta SET IdEmpleado = " + idempleado + " WHERE IdVenta = " + idventa + ";");
            gestor.modificar(@"UPDATE Venta SET MontoTotal = (SELECT SUM(D.Monto) FROM DetalleVenta D WHERE IdVenta = " + idventa + " GROUP BY IdVenta) WHERE IdVenta = " + idventa);
            gestor.cerrar_transaccion();
            this.Dispose();
        }
    }
}
