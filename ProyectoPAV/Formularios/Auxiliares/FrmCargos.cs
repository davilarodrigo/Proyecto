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
            Consulta();
        }

        public void Consulta()
        {
            AuxiliaresABM cargos = new AuxiliaresABM();
            DataTable tabla = new DataTable();
            tabla = cargos.ConsultarAuxiliares("Cargo");
            cargos.CargarGrillaAuxiliares(tabla, dataGridCargos);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (this.textBoxNuevoCargo.Text == "")
            {
                MessageBox.Show("No cargó datos"
                    , "Importante!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNuevoCargo.Focus();
                return;
            }
            if (this.textBoxNuevoCargo.Text != "")
            {
                AuxiliaresABM cargo = new AuxiliaresABM();
                cargo.InsertarAuxiliares(this.textBoxNuevoCargo.Text, "Cargo");

                Consulta();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCargos.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Importante!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    AuxiliaresABM cargo = new AuxiliaresABM();
                    string Nombre = dataGridCargos.CurrentRow.Cells[1].Value.ToString();
                    cargo.EliminarAuxiliares(Nombre, "Cargo");
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
    }
}
