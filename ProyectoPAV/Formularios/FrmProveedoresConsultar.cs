using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
