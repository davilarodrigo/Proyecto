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
    public partial class FrmLocalidades : Form
    {
        public FrmLocalidades()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNuevaLocalidad.Text == "")
            {
                MessageBox.Show("No cargó datos"
                    , "IMPORTANTE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNuevaLocalidad.Focus();
                return;
            }
            if (this.textBoxNuevaLocalidad.Text != "")
            {
                AuxiliaresABM localidad = new AuxiliaresABM();
                localidad.InsertarAuxiliares(this.textBoxNuevaLocalidad.Text, "Localidad");

                consulta();
            }
        }

        private void FrmLocalidades_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            AuxiliaresABM localidades = new AuxiliaresABM();
            DataTable tabla = new DataTable();
            tabla = localidades.ConsultarAuxiliares("Localidad");
            localidades.cargarGrillaAuxiliares(tabla, dataGridLocalidades);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridLocalidades.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Confirmar Cancelar",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    AuxiliaresABM localidad = new AuxiliaresABM();
                    string Nombre = dataGridLocalidades.CurrentRow.Cells[1].Value.ToString();
                    localidad.EliminarAuxiliares(Nombre, "Localidad");
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

