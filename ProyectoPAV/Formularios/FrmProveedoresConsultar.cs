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
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmProveedoresModificar _modificarProveedor = new FrmProveedoresModificar();
            _modificarProveedor.ShowDialog();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CODIGOABM proveedores = new CODIGOABM();
            DataTable tabla = new DataTable();

            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("No cargó datos"
                    , "IMPORTANTE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNombre.Focus();
                return;
            }

            if (textBoxNombre.Text != "")
            {
                tabla = proveedores.consultarProveedores(textBoxNombre.Text);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos encontrados");
                    return;
                }
                cargar_grilla(tabla);
                return;
            }
        }
        private void cargar_grilla(DataTable tabla)
        {
            dataGridProveedores.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridProveedores.Rows.Add();
                dataGridProveedores.Rows[i].Cells[0].Value = tabla.Rows[i]["RazonSocial"].ToString();
                dataGridProveedores.Rows[i].Cells[1].Value = tabla.Rows[i]["Telefono"].ToString();
                dataGridProveedores.Rows[i].Cells[2].Value = tabla.Rows[i]["Email"].ToString();
                dataGridProveedores.Rows[i].Cells[3].Value = tabla.Rows[i]["Calle"].ToString();
                dataGridProveedores.Rows[i].Cells[4].Value = tabla.Rows[i]["Numero"].ToString();
                dataGridProveedores.Rows[i].Cells[5].Value = tabla.Rows[i]["IdLocalidad"].ToString();
                dataGridProveedores.Rows[i].Cells["IdProveedor"].Value = tabla.Rows[i]["IdProveedor"].ToString();
            }

        }

      
    }
}
