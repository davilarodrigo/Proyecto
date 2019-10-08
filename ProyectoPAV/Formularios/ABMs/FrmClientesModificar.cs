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
    public partial class FrmClientesModificar : Form
    {
        ClientesABM clientes = new ClientesABM();
        public string IdCliente { get; set; }
        public FrmClientesModificar()
        {
            InitializeComponent();
        }

        private void RecuperarDatos(string idCliente)
        {

            DataTable tabla = new DataTable();
            tabla = clientes.RecuperarDatos(idCliente);
            this.textBoxNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            this.textBoxApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            this.textBoxEmail.Text = tabla.Rows[0]["Email"].ToString();
            this.textBoxDocumento.Text = tabla.Rows[0]["NumeroDocumento"].ToString();
            this.textBoxTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            this.textBoxCalle.Text = tabla.Rows[0]["Calle"].ToString();
            this.textBoxNumeroCalle.Text = tabla.Rows[0]["NumeroCalle"].ToString();
            this.dateTimePickerNacimiento.Value = Convert.ToDateTime(tabla.Rows[0]["FechaNacimiento"].ToString());
            this.comboLocalidad.SelectedValue = int.Parse(tabla.Rows[0]["IdLocalidad"].ToString());
            this.comboTipoDoc.SelectedValue = int.Parse(tabla.Rows[0]["IdTipoDocumento"].ToString());
            if (int.Parse(tabla.Rows[0]["IdSexo"].ToString()) == 1)
            {
                radioHombre.Checked = true;

            }
            else
            {
                radioMujer.Checked = true; ;
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnNuevaLocalidad_Click(object sender, EventArgs e)
        {
            FrmLocalidades localidades = new FrmLocalidades();
            localidades.ShowDialog();
            CargadorCombos cargador4 = new CargadorCombos();
            DataTable tablaLocalidades = new DataTable();

            tablaLocalidades = cargador4.CargarComboLocalidades();

            comboLocalidad.DataSource = tablaLocalidades;
            comboLocalidad.DisplayMember = "Nombre";
            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.SelectedIndex = -1;
        }

        private void FrmClientesModificar_Load(object sender, EventArgs e)
        {
            
            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaTipoDocumento = new DataTable();

            tablaTipoDocumento = cargador.CargarComboTiposDocumentos();

            comboTipoDoc.DataSource = tablaTipoDocumento;
            comboTipoDoc.DisplayMember = "Nombre";
            comboTipoDoc.ValueMember = "IdTipoDocumento";
            comboTipoDoc.SelectedIndex = -1;

            CargadorCombos cargador2 = new CargadorCombos();
            DataTable tablaLocalidades = new DataTable();

            tablaLocalidades = cargador2.CargarComboLocalidades();

            comboLocalidad.DataSource = tablaLocalidades;
            comboLocalidad.DisplayMember = "Nombre";
            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.SelectedIndex = -1;
            
            RecuperarDatos(IdCliente);

       
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClientesABM clientes = new ClientesABM();
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
                if (radioHombre.Checked)
                {
                    ValorRadioButton = 1;

                }
                else
                {
                    ValorRadioButton = 2;
                }
                clientes.ModificarCliente(Int32.Parse(this.IdCliente)
                                , this.textBoxApellido.Text
                                , this.textBoxNombre.Text
                                , Int32.Parse(this.comboTipoDoc.SelectedValue.ToString())
                                , Int32.Parse(this.textBoxDocumento.Text)
                                , ValorRadioButton
                                , fechaElegida.ToString("MM-dd-yyyy")
                                , this.textBoxEmail.Text
                                , Int32.Parse(this.textBoxTelefono.Text)
                                , this.textBoxCalle.Text
                                , Int32.Parse(this.textBoxNumeroCalle.Text)
                                , Int32.Parse(this.comboLocalidad.SelectedValue.ToString()));
                MessageBox.Show(clientes.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
