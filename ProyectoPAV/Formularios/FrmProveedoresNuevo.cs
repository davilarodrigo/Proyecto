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
    public partial class FrmProveedoresNuevo : Form
    {
        public FrmProveedoresNuevo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnNuevaLocalidad_Click(object sender, EventArgs e)
        {
            FrmLocalidades _localidades = new FrmLocalidades();
            _localidades.ShowDialog();
        }
    }
}
