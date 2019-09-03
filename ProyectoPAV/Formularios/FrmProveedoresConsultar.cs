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
            FrmProveedoresNuevo NuevoProveedor = new FrmProveedoresNuevo();
            NuevoProveedor.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmProveedoresModificar ModificarProveedor = new FrmProveedoresModificar();
            ModificarProveedor.ShowDialog();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
