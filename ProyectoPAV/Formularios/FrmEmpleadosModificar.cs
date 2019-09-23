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
            //DataTable tabla = new DataTable();
            //tabla = empleados.RecuperarDatos(idEmpleado);
            //this.textBoxApellido.Text = tabla.Rows[0][3].ToString();
            //this.textBoxNombre.Text = tabla.Rows[0][4].ToString();
            ////this.dateTimePickerNacimiento.Value = tabla.Rows[0][6];
            //this.comboLocalidad.SelectedValue = int.Parse(tabla.Rows[0]["IdLocalidad"].ToString());
            //this.textBoxEmail.Text = tabla.Rows[0]["Email"].ToString();
            //this.textBoxTelefono.Text = tabla.Rows[0]["Telefono"].ToString();

        }

        private void FrmEmpleadosModificar_Load(object sender, EventArgs e)
        {
            this.RecuperarDatos(IdEmpleado);
        }

        private void BtnNuevoCargo_Click(object sender, EventArgs e)
        {
            FrmCargos _cargos = new FrmCargos();
            _cargos.ShowDialog();
        }

        private void BtnGardar_Click(object sender, EventArgs e)
        {
            
            //empleados.ModificarEmpleado(Int32.Parse(this.IdEmpleado)
            //                , this.textBoxRazonSocial.Text
            //                , this.textBoxCalle.Text
            //                , Int32.Parse(this.textBoxNumeroCalle.Text)
            //                , 2
            //                , this.textBoxEmail.Text
            //                , Int32.Parse(this.textBoxTelefono.Text));
            this.Dispose();
        }
    }
}
