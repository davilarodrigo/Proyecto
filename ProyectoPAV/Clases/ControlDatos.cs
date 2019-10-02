using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.Clases
{
    class ControlDatos
    {
        public static void SoloTexto(System.Windows.Forms.KeyPressEventArgs L)
        {


            if (Char.IsLetter(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (Char.IsSeparator(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsControl(L.KeyChar))
            {
                L.Handled = false;
            }
            else
            {
                L.Handled = true;
                MessageBox.Show("Solo ingrese letras", "Tipo de dato no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void SoloNumero(KeyPressEventArgs N)
        {
            if (Char.IsDigit(N.KeyChar))
            {
                N.Handled = false;
            }
            else if (Char.IsSeparator(N.KeyChar))
            {
                N.Handled = false;
            }
            else if (Char.IsControl(N.KeyChar))
            {
                N.Handled = false;
            }
            else
            {
                N.Handled = true;
                MessageBox.Show("Solo ingrese numeros", "Contenido no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool validarIngresoTextBox(TextBox texto)
        {
            if (texto.Text == "")
            {
                MessageBox.Show("El campo " + texto.Tag + " no debe estar vacio", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto.Focus();
                return false;
            }
            return true;
        }

        public bool validarIngresoComboBox(ComboBox combo)
        {
            if (combo.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("El desplegable " + combo.Tag + " no debe estar vacio", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo.Focus();
                return false;
            }
            return true;
        }

        public bool validarIngresoRadioButton(RadioButton radio1, RadioButton radio2)
        {
            if (radio1.Checked || radio2.Checked)
            {
                return true;

            }
            else
            {
                MessageBox.Show("Se debe seleccionar un " + radio1.Tag, "Datos faltantes", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool validarIngresoFecha(DateTime fechaElegida)
        {
            DateTime fechaHoy = DateTime.Now;
            int resultadoFecha = DateTime.Compare(fechaElegida, fechaHoy);
            if (resultadoFecha >= 0)
            {
                MessageBox.Show("La fecha elegida es mayor a la actual, por favor elegir otra", "Fecha erronea",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
