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
    public partial class FrmReportesEmpleados : Form
    {
        public FrmReportesEmpleados()
        {
            InitializeComponent();
        }

        private void FrmReportesEmpleados_Load(object sender, EventArgs e)
        {
            comboBoxCargos = CargadorCombos.CargarComboCargo(comboBoxCargos);
            comboBoxSexos = CargadorCombos.CargarComboSexo(comboBoxSexos);
        }
    }
}
