using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Formularios;
using ProyectoPAV.Clases;
using System.Data.SqlClient;

namespace ProyectoPAV
{
    public partial class FrmClientesConsultar : Form
    {
        private void Consulta()
        {
            ClientesABM clientes = new ClientesABM();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            cadenaResultado = clientes.ConsultarClientes().ToString();
            tabla = clientes.tablaCliente; //aca se llena una tabla 
            if (cadenaResultado == "correcto")
            {
                this.CargarGrilla(tabla);
            }
            else
            {
                MessageBox.Show(clientes.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       /* public static DataTable select(string comando, bool informe = true)
        {//ejecuta comandos solo de tipo select, porque devuelve una tabla, que es el resultado de la consulta select

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter;
            SqlCommand sqlCommand;

            if (conectar(informe))
            {
                sqlDataAdapter = new SqlDataAdapter();
                sqlCommand = new SqlCommand(comando, conexion);

                try
                {
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    sqlDataAdapter.Fill(dataTable);

                }
                catch (Exception ex)
                {
                    if (informe) MessageBox.Show("No se pudo realizar la consulta a la base de datos. Mas informacion: " + ex.ToString());
                }
            }

            return dataTable;
        }
        */

        private void CargarGrilla(DataTable tabla)
        {
            dataGridClientes.DataSource = tabla;
            dataGridClientes.Columns[0].Visible = false;
            dataGridClientes.Columns[3].Visible = false;
            dataGridClientes.Columns[5].Visible = false;
            dataGridClientes.Columns[11].Visible = false;
            dataGridClientes.Columns[1].HeaderText = "Apellido";
            dataGridClientes.Columns[2].HeaderText = "Nombre";
            dataGridClientes.Columns[4].HeaderText = "Documento";
            dataGridClientes.Columns[6].HeaderText = "Fecha de Nacimiento";
            dataGridClientes.Columns[7].HeaderText = "Email";
            dataGridClientes.Columns[8].HeaderText = "Telefono";
            dataGridClientes.Columns[9].HeaderText = "Calle";
            dataGridClientes.Columns[10].HeaderText = "Numero";
            dataGridClientes.Columns[12].HeaderText = "Tipo Documento";
            dataGridClientes.Columns[13].HeaderText = "Localidad";
            dataGridClientes.Columns[13].HeaderText = "Sexo";
            dataGridClientes.Columns[12].DisplayIndex = 0;
            dataGridClientes.Columns[4].DisplayIndex = 1;
        }
        public FrmClientesConsultar()
        {
            InitializeComponent();
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmClientesNuevo _nuevoCliente = new FrmClientesNuevo();
            _nuevoCliente.ShowDialog();
            Consulta();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null)
            {
                FrmClientesModificar modificarCliente = new FrmClientesModificar();
                modificarCliente.IdCliente = dataGridClientes.CurrentRow.Cells[0].Value.ToString();
                modificarCliente.ShowDialog();
                Consulta();
            }
            else
            {
                MessageBox.Show("Para modificar primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmClientesConsultar_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(600, 400);

            comboTipoDocumento = CargadorCombos.CargarComboDocumento(comboTipoDocumento);
            
            Consulta();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClientesABM clientes = new ClientesABM();
            string cadenaResultado;
            string selectedValue = "";
            DataTable tabla = new DataTable();

            if (comboTipoDocumento.SelectedValue == null)
            {
                selectedValue = "0";
            }
            else
            {
                selectedValue = this.comboTipoDocumento.SelectedValue.ToString();
            }

            if (this.textBoxNombre.Text != "" || this.textBoxApellido.Text != ""
                || selectedValue != "0" || this.textBoxDocumento.Text != "")
            {

                cadenaResultado = clientes.ConsultarClientesFiltros(this.textBoxNombre.Text, this.textBoxApellido.Text,
                selectedValue, this.textBoxDocumento.Text).ToString();
                if (cadenaResultado == "correcto")
                {
                    tabla = clientes.tablaCliente;
                    this.CargarGrilla(tabla);
                }
                else
                {
                    MessageBox.Show(clientes.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Consulta();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el Cliente?", "Importante!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ClientesABM clientes = new ClientesABM();
                    int ID = Int32.Parse(dataGridClientes.CurrentRow.Cells[0].Value.ToString());
                    clientes.EliminarCliente(ID);
                    MessageBox.Show(clientes.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            this.textBoxNombre.Clear();
            this.textBoxApellido.Clear();
            this.comboTipoDocumento.SelectedIndex = -1;
            this.textBoxDocumento.Clear();
            this.Consulta();
        }

        private void groupBoxFiltros_Enter(object sender, EventArgs e)
        {

        }
    }
}
