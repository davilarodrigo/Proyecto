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
    public partial class FrmCargos : Form
    {
        public FrmCargos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmCargos_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            CodigoABM cargos = new CodigoABM();
            DataTable tabla = new DataTable();
            tabla = cargos.ConsultarAuxiliares("Cargo");
            cargos.cargarGrillaAuxiliares(tabla, dataGridCargos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (this.textBoxNuevoCargo.Text == "")
            {
                MessageBox.Show("No cargó datos"
                    , "IMPORTANTE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNuevoCargo.Focus();
                return;
            }
            if (this.textBoxNuevoCargo.Text != "")
            {
                CodigoABM cargo = new CodigoABM();
                cargo.InsertarAuxiliares(this.textBoxNuevoCargo.Text, "Cargo");

                consulta();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCargos.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Confirmar Cancelar",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    CodigoABM cargo = new CodigoABM();
                    string Nombre = dataGridCargos.CurrentRow.Cells[1].Value.ToString();
                    cargo.EliminarAuxiliares(Nombre, "Cargo");
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
