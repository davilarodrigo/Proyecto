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

namespace ProyectoPAV.Formularios.Forms_Reportes
{
    public partial class FrmReportesCompras : Form
    {
        public FrmReportesCompras()
        {
            InitializeComponent();
        }

        private void FrmReportesCompras_Load(object sender, EventArgs e)
        {
            comboBoxProveedores = CargadorCombos.CargarComboProveedor(comboBoxProveedores);
        }
    }
}
