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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            CodigoABM categorias = new CodigoABM();
            DataTable tabla = new DataTable();
            tabla = categorias.ConsultarAuxiliares("Categoria");
            cargar_grilla(tabla);
        }

        private void cargar_grilla(DataTable tabla)
        {
            dataGridCategorias.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridCategorias.Rows.Add();
                dataGridCategorias.Rows[i].Cells[0].Value = tabla.Rows[i]["Nombre"].ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNuevaCategoria.Text == "")
            {
                MessageBox.Show("No cargó datos"
                    , "IMPORTANTE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNuevaCategoria.Focus();
                return;
            }
            if (this.textBoxNuevaCategoria.Text != "")
            {
                CodigoABM categoria = new CodigoABM();
                categoria.InsertarAuxiliares(this.textBoxNuevaCategoria.Text, "Categoria");

                consulta();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCategorias.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Confirmar Cancelar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    CodigoABM categoria = new CodigoABM();
                    string Nombre = dataGridCategorias.CurrentRow.Cells["ColumnaNombre"].Value.ToString();
                    categoria.EliminarAuxiliares(Nombre, "Categoria");
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
