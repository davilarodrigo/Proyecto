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
    public partial class FrmProveedoresModificar : Form
    {
        ProveedoresABM proveedor = new ProveedoresABM();
        public string IdProveedor { get; set; }

        public FrmProveedoresModificar()
        {
            InitializeComponent();
        }

        private void FrmProveedoresModificar_Load(object sender, EventArgs e)
        {

            comboLocalidad = CargadorCombos.CargarComboLocalidad(comboLocalidad);
            RecuperarDatos(IdProveedor);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnNuevaLocalidad_Click(object sender, EventArgs e)
        {
            FrmLocalidades localidades = new FrmLocalidades();
            localidades.ShowDialog();
            comboLocalidad = CargadorCombos.CargarComboLocalidad(comboLocalidad);
        }

        private void RecuperarDatos(string id_usuario)
        {
            DataTable tabla = new DataTable();
            tabla = proveedor.RecuperarDatos(id_usuario);
            this.textBoxRazonSocial.Text = tabla.Rows[0]["RazonSocial"].ToString();
            this.textBoxCalle.Text = tabla.Rows[0]["Calle"].ToString();
            this.textBoxNumeroCalle.Text = tabla.Rows[0]["NumeroCalle"].ToString();
            this.comboLocalidad.SelectedValue = Int32.Parse(tabla.Rows[0]["IdLocalidad"].ToString());
            this.textBoxEmail.Text = tabla.Rows[0]["Email"].ToString();
            this.textBoxTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            ControlDatos control = new ControlDatos();
            ProveedoresABM proveedor = new ProveedoresABM();

            if (control.validarIngresoTextBox(textBoxRazonSocial) && control.validarIngresoTextBox(textBoxEmail)
                && control.validarIngresoTextBox(textBoxNumeroCalle) && control.validarIngresoTextBox(textBoxCalle)
                && control.validarIngresoComboBox(comboLocalidad) && control.validarIngresoTextBox(textBoxTelefono))
            {
                proveedor.ModificarProveedor(Int32.Parse(this.IdProveedor)
                                , this.textBoxRazonSocial.Text
                                , this.textBoxCalle.Text
                                , Int32.Parse(this.textBoxNumeroCalle.Text)
                                , Int32.Parse(this.comboLocalidad.SelectedValue.ToString())
                                , this.textBoxEmail.Text
                                , Int32.Parse(this.textBoxTelefono.Text));
                MessageBox.Show(proveedor.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }


    }
}
