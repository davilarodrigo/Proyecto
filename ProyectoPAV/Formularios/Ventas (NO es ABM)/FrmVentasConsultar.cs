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
    public partial class FrmVentasConsultar : Form
    {
        public FrmVentasConsultar()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmVentasNueva frmVentas = new FrmVentasNueva();
            frmVentas.ShowDialog();
        }
    }
}
