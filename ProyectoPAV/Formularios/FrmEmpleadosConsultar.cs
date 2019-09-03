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
    public partial class FrmEmpleadosConsultar : Form
    {
        public FrmEmpleadosConsultar()
        {
            InitializeComponent();
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEmpleadosNuevo _nuevoEmpleado = new FrmEmpleadosNuevo();
            _nuevoEmpleado.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmEmpleadosModificar _modificarEmpleado = new FrmEmpleadosModificar();
            _modificarEmpleado.ShowDialog();
        }

        private void FrmClientesConsultar_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(600, 400);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
