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
    public partial class FrmEscritorio : Form
    {
        public FrmEscritorio()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmClientesConsultar ConnsultarClientes = new FrmClientesConsultar();
            this.Hide();
            ConnsultarClientes.ShowDialog();
            this.Show();

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductosConsultar ConsultarProductos = new FrmProductosConsultar();
            this.Hide();
            ConsultarProductos.ShowDialog();
            this.Show();

        }
    }
}
