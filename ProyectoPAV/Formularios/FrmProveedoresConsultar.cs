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
using ProyectoPAV.Formularios;

namespace ProyectoPAV.Formularios
{
    public partial class FrmProveedoresConsultar : Form
    {
        public FrmProveedoresConsultar()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProveedoresNuevo _nuevoProveedor = new FrmProveedoresNuevo();
            _nuevoProveedor.ShowDialog();
            consulta();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedores.CurrentRow != null)
            {
                FrmProveedoresModificar _modificarProveedor = new FrmProveedoresModificar();
                _modificarProveedor.IdProveedor = dataGridProveedores.CurrentRow.Cells[0].Value.ToString();
                _modificarProveedor.ShowDialog();
                consulta();
            }
            else
            {
                MessageBox.Show("Seleccione primero una fila de la grilla, para modificar"
                    , "Importante", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
            

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void FrmProveedoresConsultar_Load(object sender, EventArgs e)
        {
            this.consulta();
        }
        public void consulta()
        {
            ProveedoresABM proveedores = new ProveedoresABM();
            DataTable tabla = new DataTable();
            tabla = proveedores.ConsultarProveedores();
            this.cargarGrilla(tabla);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProveedoresABM proveedores = new ProveedoresABM();
            DataTable tabla = new DataTable();
            if (this.textBoxRazonSocial.Text != "")
            {
                tabla = proveedores.ConsultarProveedoresRazonSocial(this.textBoxRazonSocial.Text);
                this.cargarGrilla(tabla);
            }
            else
            {
                this.consulta();
            }
        }

       private void cargarGrilla(DataTable tabla)
        {
            dataGridProveedores.DataSource = tabla;
            dataGridProveedores.Columns[0].Visible = false;
            dataGridProveedores.Columns[4].Visible = false;
            dataGridProveedores.Columns[1].HeaderText = "Razon Social";
            dataGridProveedores.Columns[2].HeaderText = "Calle";
            dataGridProveedores.Columns[3].HeaderText = "Número";
            dataGridProveedores.Columns[5].HeaderText = "Email";
            dataGridProveedores.Columns[6].HeaderText = "Teléfono";
            dataGridProveedores.Columns[7].HeaderText = "Localidad";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedores.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Confirmar Cancelar",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ProveedoresABM proveedor = new ProveedoresABM();
                    int ID = Int32.Parse(dataGridProveedores.CurrentRow.Cells[0].Value.ToString());
                    proveedor.EliminarProveedores(ID);
                    consulta();
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero una fila de la grilla, para eliminar"
                    , "IMPORTANTE", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }
    }
}
