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
            DataTable tabla = new DataTable();
            tabla = empleados.ConsultarEmpleados();
            this.CargarGrilla(tabla);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            EmpleadosABM empleados = new EmpleadosABM();
            DataTable tabla = new DataTable();
            if (this.textBoxNombre.Text != "" && this.textBoxApellido.Text != "" 
                && /*this.comboTipoDocumento.SelectedIndex == -1 &&*/ this.textBoxDocumento.Text != "")
            {
                tabla = empleados.ConsultarEmpleadosFiltros(this.textBoxNombre.Text, this.textBoxApellido.Text, 
                    this.comboTipoDocumento.SelectedValue.ToString(), Int32.Parse(this.textBoxDocumento.Text));
                this.CargarGrilla(tabla);
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

            //dataGridEmpleados.Columns[7].DisplayIndex = 4;          ESTO FUNCIONA???

        }

        private void FrmEmpleadosConsultar_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(600, 400);
            this.Consulta();
        }
    }
}
