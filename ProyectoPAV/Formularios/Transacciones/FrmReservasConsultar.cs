using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Clases;

namespace ProyectoPAV.Formularios.Transacciones
{
    public partial class FrmReservasConsultar : Form
    {
        public FrmReservasConsultar()
        {
            InitializeComponent();
        }
              
        private void FrmReservasConsultar_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        private void Consulta()
        {
            GestorReservas reservas = new GestorReservas();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            cadenaResultado = reservas.ConsultarReservas().ToString();
            tabla = reservas.tablaReservas;
            if (cadenaResultado == "correcto")
            {
                this.dataGridReservas.DataSource = tabla;
                dataGridReservas.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show(reservas.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GestorReservas reservas = new GestorReservas();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            DateTime fechadesde = Convert.ToDateTime(TimePickerDesde.Value);
            DateTime fechahasta = Convert.ToDateTime(TimePickerHasta.Value);
            if (this.TextBoxNombre.Text != "" || this.TextBoxApellido.Text != "" 
                || (fechadesde.ToString("MM-dd-yyyy") != fechahasta.ToString("MM-dd-yyyy"))
                || this.checkVencimientoHoy.Checked == true || this.checkVencido.Checked == true)
            {

                cadenaResultado = reservas.ConsultarReservasFiltros(this.TextBoxNombre.Text, this.TextBoxApellido.Text,
                fechadesde.ToString("MM-dd-yyyy"), fechahasta.ToString("MM-dd-yyyy"), this.checkVencimientoHoy.Checked,
                this.checkVencido.Checked).ToString();

                if (cadenaResultado == "correcto")
                {
                    tabla = reservas.tablaReservas;
                    this.dataGridReservas.DataSource = tabla;
                    dataGridReservas.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show(reservas.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Consulta();
            }
        }

        private void checkVencido_Click(object sender, EventArgs e)
        {
            checkVencimientoHoy.Checked = false;
           
        }

        private void checkVencimientoHoy_Click(object sender, EventArgs e)
        {
            checkVencido.Checked = false;
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmReservaNueva reservaNueva = new FrmReservaNueva();
            reservaNueva.ShowDialog();
        }
    }
}
