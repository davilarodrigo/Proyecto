﻿using System;
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
            FrmCargos _cargos = new FrmCargos();
            _cargos.ShowDialog();

            CargadorCombos cargador2 = new CargadorCombos();
            DataTable tablaCargos = new DataTable();

            tablaCargos = cargador2.CargarComboCargos();

            comboCargo.DataSource = tablaCargos;
            comboCargo.DisplayMember = "Nombre";
            comboCargo.ValueMember = "IdCargo";
            comboCargo.SelectedIndex = -1;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
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

            DateTime fecha_Elegida = Convert.ToDateTime(dateTimePickerNacimiento.Value);
            //nacimiento = dateTimePickerNacimiento.Value.ToShortDateString();

            EmpleadosABM empleados = new EmpleadosABM();
            cadenaResultado = empleados.InsertarEmpleado(Int32.Parse(this.comboTipoDoc.SelectedValue.ToString())
                            , Int32.Parse(this.TextBoxDocumento.Text), this.TextBoxApellido.Text, this.TextBoxNombre.Text
                            , ValorRadioButton, fecha_Elegida.ToString("MM-dd-yyyy"), this.TextBoxEmail.Text
                            , Int32.Parse(this.TextBoxTelefono.Text), Int32.Parse(comboCargo.SelectedValue.ToString())).ToString();
            MessageBox.Show(empleados.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void FrmEmpleadosNuevo_Load(object sender, EventArgs e)
        {
            CargadorCombos cargador = new CargadorCombos();
            DataTable tablaCargos = new DataTable();
            DataTable tablaTipoDocumento = new DataTable();

            tablaTipoDocumento = cargador.CargarComboTiposDocumentos();

            comboTipoDoc.DataSource = tablaTipoDocumento;
            comboTipoDoc.DisplayMember = "Nombre";
            comboTipoDoc.ValueMember = "IdTipoDocumento";
            comboTipoDoc.SelectedIndex = -1;

            CargadorCombos cargador2 = new CargadorCombos();

            tablaCargos = cargador2.CargarComboCargos();

            comboCargo.DataSource = tablaCargos;
            comboCargo.DisplayMember = "Nombre";
            comboCargo.ValueMember = "IdCargo";
            comboCargo.SelectedIndex = -1;

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
    }
}
