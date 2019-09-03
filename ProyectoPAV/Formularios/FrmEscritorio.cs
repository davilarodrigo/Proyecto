using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Formularios;
using ProyectoPAV.Formularios.Auxiliares;

namespace ProyectoPAV
{
    public partial class FrmEscritorio : Form
    {
        public FrmEscritorio()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmClientesConsultar ConnsultarClientes = new FrmClientesConsultar();
            this.Hide();
            ConnsultarClientes.ShowDialog();
            this.Show();

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductosConsultar ConsultarProductos = new FrmProductosConsultar();
            this.Hide();
            ConsultarProductos.ShowDialog();
            this.Show();

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesConsultar ConnsultarClientes = new FrmClientesConsultar();
            this.Hide();
            ConnsultarClientes.ShowDialog();
            this.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductosConsultar ConsultarProductos = new FrmProductosConsultar();
            this.Hide();
            ConsultarProductos.ShowDialog();
            this.Show();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedoresConsultar ConsultarProveedores = new FrmProveedoresConsultar();
            this.Hide();
            ConsultarProveedores.ShowDialog();
            this.Show();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleadosConsultar ConsultarEmpleados = new FrmEmpleadosConsultar();
            this.Hide();
            ConsultarEmpleados.ShowDialog();
            this.Show();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedoresConsultar ConsultarProveedores = new FrmProveedoresConsultar();
            this.Hide();
            ConsultarProveedores.ShowDialog();
            this.Show();
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadosConsultar ConsultarEmpleados = new FrmEmpleadosConsultar();
            this.Hide();
            ConsultarEmpleados.ShowDialog();
            this.Show();
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca Marcas = new FrmMarca();
            this.Hide();
            Marcas.ShowDialog();
            this.Show();
        }

        private void LocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalidades Localidades = new FrmLocalidades();
            this.Hide();
            Localidades.ShowDialog();
            this.Show();
        }

        private void TiposDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumentos TipoDocumentos = new FrmTipoDocumentos();
            this.Hide();
            TipoDocumentos.ShowDialog();
            this.Show();
        }

        private void CategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias Categorias = new FrmCategorias();
            this.Hide();
            Categorias.ShowDialog();
            this.Show();
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargos Cargos = new FrmCargos();
            this.Hide();
            Cargos.ShowDialog();
            this.Show();
        }
    }
    
}
