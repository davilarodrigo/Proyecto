using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV.Clases;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPAV.Clases
{
    class AuxiliaresABM
    {
        public void InsertarAuxiliares(string Nombre, string Tabla)
        {
            string sql_insert = "";
            sql_insert = @"INSERT INTO "+ Tabla +" (Nombre) VALUES ('" + Nombre +"')";
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            if (gestor.Insertar(sql_insert) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                MessageBox.Show("Se cargaron correctamente los datos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO se cargaron correctamente los datos debido a: " + 
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ConsultarAuxiliares(string Tabla)
        {
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            string sql = @"SELECT *
                             FROM " + Tabla;

            DataTable dt = new DataTable();

            if (gestor.EjecutarConsulta(sql) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                dt = gestor.TablaResultado;
            }
            else
            {
                MessageBox.Show("No se consultaron correctamente los datos debido a: " + 
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public void EliminarAuxiliares(string Nombre, string Tabla)
        {
            string sql_delete = "";
            sql_delete = @"DELETE FROM "+ Tabla + " WHERE Nombre = '" + Nombre + "'";
            GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();
            if (gestor.Eliminar(sql_delete) ==
                GestorTransaccionesSQL.ResultadoTransaccion.correcto)
            {
                MessageBox.Show("Se eliminaron correctamente los datos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO se eliminaron correctamente los datos debido a: " + 
                    gestor.mensajeError, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarGrillaAuxiliares(DataTable tabla, DataGridView grilla)
        {
            grilla.DataSource = tabla;
            grilla.Columns[0].Visible = false;
            grilla.Columns[1].HeaderText = "Nombre";

        }
    }
}