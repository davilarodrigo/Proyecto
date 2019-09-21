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
            ProveedoresABM proveedor = new ProveedoresABM();
            proveedor.InsertarProveedor(this.textBoxRazonSocial.Text
                            , this.textBoxCalle.Text
                            , Int32.Parse(this.textBoxNumeroCalle.Text)
                            , 2
                            , this.textBoxEmail.Text
                            , Int32.Parse(this.textBoxTelefono.Text));
            this.Dispose();
        }
    }
    
}//Int32.Parse(this.comboLocalidad.SelectedValue.ToString())
