using ProyectoPAV.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.Formularios
{
    public partial class FrmProbandoTransaccion : Form
    {

        public DataTable ConsultarEmpleados(string nombre = "", string apellido = "", string tipoDoc = "", string numeroDoc = "")
        {

            string sql = @"select * from Empleado;";

            return gestor.ejecutar_consulta(sql);



        }

        public void InsertarEmpleado()
        {
            string sql_insert = "";

            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            string randomDNI = randomNumber.ToString();

            sql_insert = @"INSERT INTO Empleado VALUES (1," + randomDNI + ",'pepe', 'aasd',1,'19750606','','',2,'20181212',null)";

            gestor.ejecutar_no_select(sql_insert);

        }


        PruebaGestorTransacciones gestor;

        public void refrescarDataGrid()
        {
            dgvEmpleados.DataSource = ConsultarEmpleados();
        }

        public FrmProbandoTransaccion()
        {
            InitializeComponent();
        }

        private void FrmProbandoTransaccion_Load(object sender, EventArgs e)
        {
            gestor = new PruebaGestorTransacciones();
            refrescarDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertarEmpleado();
            refrescarDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gestor.confirmar();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestor.CancelarTransaccion();
            this.Dispose(); 
        }
    }
}
