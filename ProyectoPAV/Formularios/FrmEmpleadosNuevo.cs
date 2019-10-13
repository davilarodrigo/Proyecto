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
    public partial class FrmEmpleadosNuevo : Form
    {
        public FrmEmpleadosNuevo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnNuevoCargo_Click(object sender, EventArgs e)
        {
            FrmCargos frmCargos = new FrmCargos();
            frmCargos.ShowDialog();


            comboCargo = CargadorCombos.CargarComboCargo(comboCargo);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ControlDatos control = new ControlDatos();
            DateTime fechaElegida = Convert.ToDateTime(dateTimePickerNacimiento.Value);
            EmpleadosABM empleados = new EmpleadosABM();

            if (control.validarIngresoTextBox(TextBoxApellido) && control.validarIngresoTextBox(TextBoxNombre)
                && control.validarIngresoTextBox(TextBoxDocumento) && control.validarIngresoTextBox(TextBoxEmail)
                && control.validarIngresoTextBox(TextBoxTelefono) &&  control.validarIngresoComboBox(comboCargo)
                && control.validarIngresoComboBox(comboTipoDoc) && control.validarIngresoRadioButton(RadioMujer, RadioHombre)
                && control.validarIngresoFecha(fechaElegida))
            {
                int ValorRadioButton;
                string cadenaResultado;
                if (RadioHombre.Checked)
                {
                    ValorRadioButton = 1;

                }
                else
                {
                    ValorRadioButton = 2;
                }

                cadenaResultado = empleados.InsertarEmpleado(Int32.Parse(this.comboTipoDoc.SelectedValue.ToString())
                                , Int32.Parse(this.TextBoxDocumento.Text), this.TextBoxApellido.Text, this.TextBoxNombre.Text
                                , ValorRadioButton, fechaElegida.ToString("MM-dd-yyyy"), this.TextBoxEmail.Text
                                , Int32.Parse(this.TextBoxTelefono.Text), Int32.Parse(comboCargo.SelectedValue.ToString())).ToString();
                MessageBox.Show(empleados.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void FrmEmpleadosNuevo_Load(object sender, EventArgs e)
        {
            
            comboTipoDoc = CargadorCombos.CargarComboDocumento(comboTipoDoc);

            comboCargo = CargadorCombos.CargarComboCargo(comboCargo);

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            comboTipoDoc.SelectedIndex = -1;
            comboCargo.SelectedIndex = -1;
            TextBoxTelefono.Clear();
            TextBoxApellido.Clear();
            TextBoxNombre.Clear();
            TextBoxDocumento.Clear();
            TextBoxEmail.Clear();
            RadioHombre.Checked = false;
            RadioMujer.Checked = false;
        }

        private void TextBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }

        private void TextBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
