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
            CargadorCombos cargador5 = new CargadorCombos();
            DataTable tablaTipoDocumentos = new DataTable();

            tablaTipoDocumentos = cargador5.CargarComboLocalidades();

            comboLocalidad.DataSource = tablaTipoDocumentos;
            comboLocalidad.DisplayMember = "Nombre";
            comboLocalidad.ValueMember = "IdLocalidad";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ControlDatos control = new ControlDatos();
            ProveedoresABM proveedor = new ProveedoresABM();

            if (control.validarIngresoTextBox(textBoxRazonSocial) && control.validarIngresoTextBox(textBoxEmail)
                && control.validarIngresoTextBox(textBoxNumeroCalle) && control.validarIngresoTextBox(textBoxCalle)
                && control.validarIngresoComboBox(comboLocalidad) && control.validarIngresoTextBox(textBoxTelefono))
                
            {
                string cadenaResultado;
                cadenaResultado = proveedor.InsertarProveedor(this.textBoxRazonSocial.Text
                                , this.textBoxCalle.Text
                                , Int32.Parse(this.textBoxNumeroCalle.Text)
                                , Int32.Parse(this.comboLocalidad.SelectedValue.ToString())
                                , this.textBoxEmail.Text
                                , Int32.Parse(this.textBoxTelefono.Text)).ToString();
                MessageBox.Show(proveedor.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void FrmProveedoresNuevo_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador5 = new CargadorCombos();
            DataTable tablaTipoDocumentos = new DataTable();

            tablaTipoDocumentos = cargador5.CargarComboLocalidades();

            comboLocalidad.DataSource = tablaTipoDocumentos;
            comboLocalidad.DisplayMember = "Nombre";
            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.SelectedIndex = -1;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            comboLocalidad.SelectedIndex = -1;
            textBoxTelefono.Clear();
            textBoxRazonSocial.Clear();
            textBoxCalle.Clear();
            textBoxNumeroCalle.Clear();
            textBoxEmail.Clear();
            
        }
    }  
}
