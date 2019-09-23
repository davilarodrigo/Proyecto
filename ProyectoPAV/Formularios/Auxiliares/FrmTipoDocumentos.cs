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
    public partial class FrmTipoDocumentos : Form
    {
        public FrmTipoDocumentos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmTipoDocumentos_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            AuxiliaresABM tiposdocumento = new AuxiliaresABM();
            DataTable tabla = new DataTable();
            tabla = tiposdocumento.ConsultarAuxiliares("TipoDocumento");
            tiposdocumento.CargarGrillaAuxiliares(tabla, dataGridTipoDoc);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNuevoTipoDoc.Text == "")
            {
                MessageBox.Show("No cargó datos"
                    , "IMPORTANTE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNuevoTipoDoc.Focus();
                return;
            }
            if (this.textBoxNuevoTipoDoc.Text != "")
            {
                AuxiliaresABM tipodocumento = new AuxiliaresABM();
                tipodocumento.InsertarAuxiliares(this.textBoxNuevoTipoDoc.Text, "TipoDocumento");

                consulta();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridTipoDoc.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Confirmar Cancelar",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    AuxiliaresABM tipodocumento = new AuxiliaresABM();
                    string Nombre = dataGridTipoDoc.CurrentRow.Cells[1].Value.ToString();
                    tipodocumento.EliminarAuxiliares(Nombre, "TipoDocumento");
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
