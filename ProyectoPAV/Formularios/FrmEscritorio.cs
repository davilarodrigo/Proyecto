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
            FrmClientesConsultar _consultarClientes = new FrmClientesConsultar();
            this.Hide();
            _consultarClientes.ShowDialog();
            this.Show();

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductosConsultar _consultarProductos = new FrmProductosConsultar();
            this.Hide();
            _consultarProductos.ShowDialog();
            this.Show();

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesConsultar _consultarClientes = new FrmClientesConsultar();
            this.Hide();
            _consultarClientes.ShowDialog();
            this.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductosConsultar _consultarProductos = new FrmProductosConsultar();
            this.Hide();
            _consultarProductos.ShowDialog();
            this.Show();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedoresConsultar _consultarProveedores = new FrmProveedoresConsultar();
            this.Hide();
            _consultarProveedores.ShowDialog();
            this.Show();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleadosConsultar _consultarEmpleados = new FrmEmpleadosConsultar();
            this.Hide();
            _consultarEmpleados.ShowDialog();
            this.Show();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedoresConsultar _consultarProveedores = new FrmProveedoresConsultar();
            this.Hide();
            _consultarProveedores.ShowDialog();
            this.Show();
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadosConsultar _consultarEmpleados = new FrmEmpleadosConsultar();
            this.Hide();
            _consultarEmpleados.ShowDialog();
            this.Show();
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcas _marcas = new FrmMarcas();
            this.Hide();
            _marcas.ShowDialog();
            this.Show();
        }

        private void LocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalidades _localidades = new FrmLocalidades();
            this.Hide();
            _localidades.ShowDialog();
            this.Show();
        }

        private void TiposDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumentos _tipoDocumentos = new FrmTipoDocumentos();
            this.Hide();
            _tipoDocumentos.ShowDialog();
            this.Show();
        }

        private void CategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias _categorias = new FrmCategorias();
            this.Hide();
            _categorias.ShowDialog();
            this.Show();
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargos _cargos = new FrmCargos();
            this.Hide();
            _cargos.ShowDialog();
            this.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    
}
