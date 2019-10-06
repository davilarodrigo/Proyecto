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

namespace ProyectoPAV.Formularios
{
    public partial class FrmVentasConsultar : Form
    {
        public FrmVentasConsultar()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmVentasNueva frmVentas = new FrmVentasNueva();
            frmVentas.ShowDialog();
        }

        private void FrmVentasConsultar_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        private void Consulta()
        {
            GestorVentas ventas = new GestorVentas();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            cadenaResultado = ventas.ConsultarVentas().ToString();
            tabla = ventas.tablaVentas;
            if (cadenaResultado == "correcto")
            {
                this.dataGridVentas.DataSource = tabla;
                dataGridVentas.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show(ventas.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GestorVentas detalleVentas = new GestorVentas();
            string cadenaResultado;
            int idVenta;
            DataTable tabla = new DataTable();
            idVenta = Int32.Parse(dataGridVentas.CurrentRow.Cells[0].Value.ToString());
            cadenaResultado = detalleVentas.ConsultarDetallesVenta(idVenta).ToString();
            tabla = detalleVentas.tablaDetallesVentas;
            if (cadenaResultado == "correcto")
            {
                this.dataGridDetallesVenta.DataSource = tabla;
                dataGridDetallesVenta.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show(detalleVentas.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GestorVentas ventas = new GestorVentas();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            DateTime fechadesde = Convert.ToDateTime(TimePickerDesde.Value);
            DateTime fechahasta = Convert.ToDateTime(TimePickerHasta.Value);
            if (this.TextBoxNombre.Text != "" || this.TextBoxApellido.Text != ""
                || (fechadesde.ToString("MM-dd-yyyy") != fechahasta.ToString("MM-dd-yyyy")))
            {

                cadenaResultado = ventas.ConsultarVentasFiltros(this.TextBoxNombre.Text, this.TextBoxApellido.Text,
                fechadesde.ToString("MM-dd-yyyy"), fechahasta.ToString("MM-dd-yyyy")).ToString();
                if (cadenaResultado == "correcto")
                {
                    tabla = ventas.tablaVentas;
                    this.dataGridVentas.DataSource = tabla;
                    dataGridVentas.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show(ventas.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Consulta();
            }
        }
    }
}

