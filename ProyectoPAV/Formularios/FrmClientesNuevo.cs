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
    public partial class FrmClientesNuevo : Form
    {
        public FrmClientesNuevo()
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

            comboLocalidad = CargadorCombos.CargarComboLocalidad(comboLocalidad);
        }

        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            comboTipoDoc.SelectedIndex = -1;
            comboLocalidad.SelectedIndex = -1;
            textBoxTelefono.Clear();
            textBoxApellido.Clear();
            textBoxNombre.Clear();
            textBoxDocumento.Clear();
            textBoxEmail.Clear();
            textBoxCalle.Clear();
            textBoxNumeroCalle.Clear();
            radioHombre.Checked = false;
            radioMujer.Checked = false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ControlDatos control = new ControlDatos();
            DateTime fechaElegida = Convert.ToDateTime(dateTimePickerNacimiento.Value);

            if (control.validarIngresoTextBox(textBoxApellido) && control.validarIngresoTextBox(textBoxNombre)
                && control.validarIngresoTextBox(textBoxDocumento) && control.validarIngresoTextBox(textBoxEmail)
                && control.validarIngresoTextBox(textBoxTelefono) && control.validarIngresoTextBox(textBoxCalle)
                && control.validarIngresoTextBox(textBoxNumeroCalle) && control.validarIngresoComboBox(comboLocalidad)
                && control.validarIngresoComboBox(comboTipoDoc) && control.validarIngresoRadioButton(radioMujer, radioHombre)
                && control.validarIngresoFecha(fechaElegida))
            {
                
                int ValorRadioButton; 
                string cadenaResultado;
                if (radioHombre.Checked)
                {
                    ValorRadioButton = 1;

                }
                else
                {
                    ValorRadioButton = 2;
                }


                ClientesABM clientes = new ClientesABM();
                cadenaResultado = clientes.InsertarCliente(this.textBoxApellido.Text, this.textBoxNombre.Text,
                                        Int32.Parse(this.comboTipoDoc.SelectedValue.ToString()), Int32.Parse(this.textBoxDocumento.Text)
                                    , ValorRadioButton, fechaElegida.ToString("MM-dd-yyyy"), this.textBoxEmail.Text
                                    , Int32.Parse(this.textBoxTelefono.Text), this.textBoxCalle.Text,
                                        Int32.Parse(this.textBoxNumeroCalle.Text), Int32.Parse(comboLocalidad.SelectedValue.ToString())).ToString();
                MessageBox.Show(clientes.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                }
            }

        private void FrmClientesNuevo_Load(object sender, EventArgs e)
        {
            comboLocalidad = CargadorCombos.CargarComboLocalidad(comboLocalidad);
            comboTipoDoc = CargadorCombos.CargarComboDocumento(comboTipoDoc);
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlDatos.SoloTexto(e);
        }
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlDatos.SoloTexto(e);
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlDatos.SoloNumero(e);
        }
        private void textBoxCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlDatos.SoloTexto(e);
        }
        private void textBoxNumeroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlDatos.SoloNumero(e);
        }
        private void textBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlDatos.SoloNumero(e);
        }
    }
}
