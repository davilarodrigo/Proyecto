using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Formularios.Auxiliares;

namespace ProyectoPAV.Formularios
{
    public partial class FrmProductosNuevo : Form
    {
        public FrmProductosNuevo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnNuevaMarca_Click(object sender, EventArgs e)
        {
            FrmMarcas _marcas = new FrmMarcas();
            _marcas.ShowDialog();
        }
    }
}
