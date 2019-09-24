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


namespace ProyectoPAV
{
    public partial class FrmEmpleadosConsultar : Form
    {
        public FrmEmpleadosConsultar()
        {
            InitializeComponent();
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEmpleadosNuevo nuevoEmpleado = new FrmEmpleadosNuevo();
            nuevoEmpleado.ShowDialog();
            Consulta();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridEmpleados.CurrentRow != null)
            {
                FrmEmpleadosModificar modificarEmpleado = new FrmEmpleadosModificar();
                modificarEmpleado.IdEmpleado = dataGridEmpleados.CurrentRow.Cells[0].Value.ToString();
                modificarEmpleado.ShowDialog();
                Consulta();
            }
            else
            {
                MessageBox.Show("Para modificar primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }

        private void Consulta()
        {
            EmpleadosABM empleados = new EmpleadosABM();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            cadenaResultado = empleados.ConsultarEmpleados().ToString();
            tabla = empleados.tablaEmpleado;
            if (cadenaResultado == "correcto")
            {
                this.CargarGrilla(tabla);
            }
            else
            {
                MessageBox.Show(empleados.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            EmpleadosABM empleados = new EmpleadosABM();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            if (this.textBoxNombre.Text != "" || this.textBoxApellido.Text != ""
                || this.comboTipoDocumento.SelectedIndex != -1 || this.textBoxDocumento.Text != "")
            {
                cadenaResultado = empleados.ConsultarEmpleadosFiltros(this.textBoxNombre.Text, this.textBoxApellido.Text,
                this.comboTipoDocumento.SelectedIndex.ToString(), this.textBoxDocumento.Text).ToString();
                if (cadenaResultado == "correcto")
                {
                    tabla = empleados.tablaEmpleado;
                    this.CargarGrilla(tabla);
                }
                else
                {
                    MessageBox.Show(empleados.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Consulta();
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            dataGridEmpleados.DataSource = tabla;
            dataGridEmpleados.Columns[0].Visible = false;
            dataGridEmpleados.Columns[1].Visible = false;
            dataGridEmpleados.Columns[5].Visible = false;
            dataGridEmpleados.Columns[9].Visible = false;
            dataGridEmpleados.Columns[2].HeaderText = "Documento";
            dataGridEmpleados.Columns[3].HeaderText = "Apellido";
            dataGridEmpleados.Columns[4].HeaderText = "Nombre";
            dataGridEmpleados.Columns[6].HeaderText = "Fecha de Nacimiento";
            dataGridEmpleados.Columns[7].HeaderText = "Email";
            dataGridEmpleados.Columns[8].HeaderText = "Telefono";
            dataGridEmpleados.Columns[10].HeaderText = "Fecha de Alta";
            dataGridEmpleados.Columns[11].HeaderText = "Fecha de Baja";
            dataGridEmpleados.Columns[12].HeaderText = "Tipo de Documento";
            dataGridEmpleados.Columns[13].HeaderText = "Cargo";
            dataGridEmpleados.Columns[14].HeaderText = "Sexo";
            dataGridEmpleados.Columns[12].DisplayIndex = 0;
        }

        private void FrmEmpleadosConsultar_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(600, 400);
            this.Consulta();

            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaTipoDocumento = new DataTable();

            tablaTipoDocumento = cargador.CargarComboTiposDocumentos();

            comboTipoDocumento.DataSource = tablaTipoDocumento;
            comboTipoDocumento.DisplayMember = "Nombre";
            comboTipoDocumento.ValueMember = "IdTipoDocumento";
            comboTipoDocumento.SelectedIndex = -1;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridEmpleados.CurrentRow != null)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el Empleado?", "Importante!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    EmpleadosABM empleado = new EmpleadosABM();
                    int ID = Int32.Parse(dataGridEmpleados.CurrentRow.Cells[0].Value.ToString());
                    empleado.EliminarEmpleado(ID);
                    MessageBox.Show(empleado.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Consulta();
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero una fila de la grilla, para eliminar"
                    , "Importante!", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }
    }
}
