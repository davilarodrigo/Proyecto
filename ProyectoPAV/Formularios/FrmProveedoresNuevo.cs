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
using ProyectoPAV.Clases;

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CODIGOABM proveedor = new CODIGOABM();
            proveedor.InsertarProveedor(this.textBoxRazonSocial.Text
                            , this.textBoxEmail.Text
                            , this.textBoxTelefono.Text
                            , this.textBoxCalle.Text
                            , this.textBoxNumeroCalle.Text
                            , this.comboLocalidad.SelectedValue.ToString());
        }
    }
}
