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
    public partial class FrmEmpleadosModificar : Form
    {
        EmpleadosABM empleados = new EmpleadosABM();
        public string IdEmpleado { get; set; }
        public FrmEmpleadosModificar()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void RecuperarDatos(string idEmpleado)
        {
            
            DataTable tabla = new DataTable();
            tabla = empleados.RecuperarDatos(idEmpleado);
            this.textBoxNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            this.textBoxApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            this.textBoxEmail.Text = tabla.Rows[0]["Email"].ToString();
            this.textBoxDocumento.Text = tabla.Rows[0]["NumeroDocumento"].ToString();
            this.textBoxTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            //this.dateTimePickerNacimiento.Value = tabla.Rows[0][6];
            this.comboCargo.SelectedValue = int.Parse(tabla.Rows[0]["IdCargo"].ToString());
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

        private void FrmEmpleadosModificar_Load(object sender, EventArgs e)
        {
            

            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaTipoDocumento = new DataTable();

            tablaTipoDocumento = cargador.CargarComboTiposDocumentos();

            comboTipoDoc.DataSource = tablaTipoDocumento;
            comboTipoDoc.DisplayMember = "Nombre";
            comboTipoDoc.ValueMember = "IdTipoDocumento";
            comboTipoDoc.SelectedIndex = -1;

            CargadorCombos cargador2 = new CargadorCombos();
            DataTable tablaCargos = new DataTable();

            tablaCargos = cargador2.CargarComboCargos();

            comboCargo.DataSource = tablaCargos;
            comboCargo.DisplayMember = "Nombre";
            comboCargo.ValueMember= "IdCargo";
            comboCargo.SelectedIndex = -1;

            this.RecuperarDatos(IdEmpleado);
        }

        private void BtnNuevoCargo_Click(object sender, EventArgs e)
        {
            FrmCargos _cargos = new FrmCargos();
            _cargos.ShowDialog();
            CargadorCombos cargador2 = new CargadorCombos();
            DataTable tablaCargos = new DataTable();

            tablaCargos = cargador2.CargarComboCargos();

            comboCargo.DataSource = tablaCargos;
            comboCargo.DisplayMember = "Nombre";
            comboCargo.ValueMember = "IdCargo";
        }

        private void BtnGardar_Click(object sender, EventArgs e)
        {

            EmpleadosABM empleado = new EmpleadosABM();

            int ValorRadioButton;
            if (radioHombre.Checked)
            {
                ValorRadioButton = 1;

            }
            else
            {
                ValorRadioButton = 2;
            }
            empleado.ModificarEmpleado(Int32.Parse(this.IdEmpleado)
                            , Int32.Parse(this.comboTipoDoc.SelectedValue.ToString())
                            , Int32.Parse(this.textBoxDocumento.Text)
                            , this.textBoxApellido.Text
                            , this.textBoxNombre.Text
                            , ValorRadioButton
                            , "GETDATE(), "
                            , this.textBoxEmail.Text
                            , Int32.Parse(this.textBoxTelefono.Text)
                            , Int32.Parse(this.comboCargo.SelectedValue.ToString()));
            MessageBox.Show(empleado.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
            
        }
    }
}
