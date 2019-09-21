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

namespace ProyectoPAV.Formularios.Auxiliares
{
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            CodigoABM marcas = new CodigoABM();
            DataTable tabla = new DataTable();
            tabla = marcas.ConsultarAuxiliares("Marca");
            marcas.cargarGrillaAuxiliares(tabla, dataGridMarcas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNuevaMarca.Text == "")
            {
                MessageBox.Show("No cargó datos"
                    , "IMPORTANTE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNuevaMarca.Focus();
                return;
            }
            if (this.textBoxNuevaMarca.Text != "")
            {
                CodigoABM marca = new CodigoABM();
                marca.InsertarAuxiliares(this.textBoxNuevaMarca.Text, "Marca");

                consulta();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridMarcas.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Confirmar Cancelar",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    CodigoABM marca = new CodigoABM();
                    string Nombre = dataGridMarcas.CurrentRow.Cells[1].Value.ToString();
                    marca.EliminarAuxiliares(Nombre, "Marca");
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
