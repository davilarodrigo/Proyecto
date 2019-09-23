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
            FrmProveedoresNuevo nuevoProveedor = new FrmProveedoresNuevo();
            nuevoProveedor.ShowDialog();
            Consulta();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedores.CurrentRow != null)
            {
                FrmProveedoresModificar modificarProveedor = new FrmProveedoresModificar();
                modificarProveedor.IdProveedor = dataGridProveedores.CurrentRow.Cells[0].Value.ToString();
                modificarProveedor.ShowDialog();
                Consulta();
            }
            else
            {
                MessageBox.Show("Para modificar primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
            

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmProveedoresConsultar_Load(object sender, EventArgs e)
        {
            this.Consulta();
        }
        private void Consulta()
        {
            ProveedoresABM proveedores = new ProveedoresABM();
            DataTable tabla = new DataTable();
            string cadenaResultado;
            cadenaResultado = proveedores.ConsultarProveedores().ToString();
            tabla = proveedores.tablaProveedor;
            if (cadenaResultado == "correcto")
            {
                this.CargarGrilla(tabla);
            }
            else
            {
                MessageBox.Show(proveedores.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProveedoresABM proveedores = new ProveedoresABM();
            DataTable tabla = new DataTable();
            string cadenaResultado;
            if (this.textBoxRazonSocial.Text != "")
            {
                cadenaResultado = proveedores.ConsultarProveedoresFiltros(this.textBoxRazonSocial.Text).ToString();
                tabla = proveedores.tablaProveedor;
                if (cadenaResultado == "correcto")
                {
                    this.CargarGrilla(tabla);
                }
                else
                {
                    MessageBox.Show(proveedores.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Consulta();
            }
        }

       private void CargarGrilla(DataTable tabla)
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
            //dataGridProveedores.Columns[7].DisplayIndex = 4;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedores.CurrentRow != null)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el Proveedor?","Importante!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ProveedoresABM proveedor = new ProveedoresABM();
                    int ID = Int32.Parse(dataGridProveedores.CurrentRow.Cells[0].Value.ToString());
                    proveedor.EliminarProveedor(ID);
                    MessageBox.Show(proveedor.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
