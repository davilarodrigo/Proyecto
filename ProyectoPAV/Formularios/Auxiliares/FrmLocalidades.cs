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
                CodigoABM localidad = new CodigoABM();
                localidad.InsertarAuxiliares(this.textBoxNuevaLocalidad.Text, "Localidad");

                consulta();
            }
        }

        private void FrmLocalidades_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void cargar_grilla(DataTable tabla)
        {
            dataGridLocalidades.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridLocalidades.Rows.Add();
                dataGridLocalidades.Rows[i].Cells[0].Value = tabla.Rows[i]["Nombre"].ToString();
            }

        }

        public void consulta()
        {
            CodigoABM localidades = new CodigoABM();
            DataTable tabla = new DataTable();
            tabla = localidades.ConsultarAuxiliares("Localidad");
            cargar_grilla(tabla);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridLocalidades.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Confirmar Cancelar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    CodigoABM localidad = new CodigoABM();
                string Nombre = dataGridLocalidades.CurrentRow.Cells["ColumnaNombre"].Value.ToString();
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

