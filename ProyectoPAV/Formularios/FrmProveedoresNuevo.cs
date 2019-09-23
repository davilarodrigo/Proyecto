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
            FrmLocalidades localidades = new FrmLocalidades();
            localidades.ShowDialog();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string cadenaResultado;
            ProveedoresABM proveedor = new ProveedoresABM();
            cadenaResultado = proveedor.InsertarProveedor(this.textBoxRazonSocial.Text
                            , this.textBoxCalle.Text
                            , Int32.Parse(this.textBoxNumeroCalle.Text)
                            , 2
                            , this.textBoxEmail.Text
                            , Int32.Parse(this.textBoxTelefono.Text)).ToString();
            MessageBox.Show(proveedor.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }
    }
    
}//Int32.Parse(this.comboLocalidad.SelectedValue.ToString())
