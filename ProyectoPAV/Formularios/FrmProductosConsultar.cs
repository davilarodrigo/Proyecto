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
    public partial class FrmProductosConsultar : Form
    {
        public FrmProductosConsultar()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductosNuevo NuevoProducto = new FrmProductosNuevo();
            NuevoProducto.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmProductosModificar ModificarProducto = new FrmProductosModificar();
            ModificarProducto.ShowDialog();
        }
    }
}
