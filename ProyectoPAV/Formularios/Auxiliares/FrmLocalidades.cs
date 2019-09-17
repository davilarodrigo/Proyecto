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
                CODIGOABM localidad = new CODIGOABM();
                localidad.InsertarLocalidad(this.textBoxNuevaLocalidad.Text);

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
            CODIGOABM localidades = new CODIGOABM();
            DataTable tabla = new DataTable();
            tabla = localidades.ConsultarLocalidades();
            cargar_grilla(tabla);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridLocalidades.CurrentRow != null)
            {
                CODIGOABM localidad = new CODIGOABM();
                string Nombre = dataGridLocalidades.CurrentRow.Cells["ColumnaNombre"].Value.ToString();
                localidad.EliminarLocalidad(Nombre);
                consulta();
            }
            else
            {
                MessageBox.Show("Seleccione primero una fila de la grilla, para modificar"
                    , "Importante", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }
    }
}

