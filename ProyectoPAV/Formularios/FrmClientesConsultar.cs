using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Formularios;

namespace ProyectoPAV
{
    public partial class FrmClientesConsultar : Form
    {
        public FrmClientesConsultar()
        {
            InitializeComponent();
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmClientesNuevo NuevoCliente = new FrmClientesNuevo();
            NuevoCliente.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmClientesModificar ModificarCliente = new FrmClientesModificar();
            ModificarCliente.ShowDialog();
        }

        private void FrmClientesConsultar_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(600, 400);
        }
    }
}
