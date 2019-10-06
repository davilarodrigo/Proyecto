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
    public partial class FrmComprasConsultar : Form
    {
        public FrmComprasConsultar()
        {
            InitializeComponent();
        }

        

        private void FrmComprasConsultar_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        private void Consulta()
        {
            GestorCompras compras = new GestorCompras();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            cadenaResultado = compras.ConsultarCompras().ToString();
            tabla = compras.tablaCompras;
            if (cadenaResultado == "correcto")
            {
                this.dataGridCompras.DataSource = tabla;
                dataGridCompras.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show(compras.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GestorCompras detalleCompras = new GestorCompras();
            string cadenaResultado;
            int idCompra;
            DataTable tabla = new DataTable();
            idCompra = Int32.Parse(dataGridCompras.CurrentRow.Cells[0].Value.ToString());
            cadenaResultado = detalleCompras.ConsultarDetallesCompra(idCompra).ToString();
            tabla = detalleCompras.tablaDetallesCompras;
            if (cadenaResultado == "correcto")
            {
                this.dataGridDetallesCompra.DataSource = tabla;
                dataGridDetallesCompra.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show(detalleCompras.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridDetallesCompra.Columns.Clear();
            GestorCompras compras = new GestorCompras();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            DateTime fechadesde = Convert.ToDateTime(TimePickerDesde.Value);
            DateTime fechahasta = Convert.ToDateTime(TimePickerHasta.Value);
            if (this.TextBoxRazonSocial.Text != "" || (fechadesde.ToString("MM-dd-yyyy")
                != fechahasta.ToString("MM-dd-yyyy")))
            {
                cadenaResultado = compras.ConsultarComprasFiltros(this.TextBoxRazonSocial.Text,
                fechadesde.ToString("MM-dd-yyyy"), fechahasta.ToString("MM-dd-yyyy")).ToString();
                if (cadenaResultado == "correcto")
                {
                    tabla = compras.tablaCompras;
                    this.dataGridCompras.DataSource = tabla;
                    dataGridCompras.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show(compras.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Consulta();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmCompraNueva nuevaCompra = new FrmCompraNueva();
            nuevaCompra.ShowDialog();
        }
    }
}
