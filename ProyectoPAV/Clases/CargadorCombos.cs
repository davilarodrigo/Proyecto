using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoPAV.Clases
{
    class CargadorCombos
    {

        GestorSentenciasSimples gestor = new GestorSentenciasSimples();

        public DataTable CargarComboCargos()
        {
            string sql = "SELECT * FROM Cargo";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if(resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }
                        
            return tabla;
        }

        public DataTable CargarComboTiposDocumentos()
        {
            string sql = "SELECT * FROM TipoDocumento";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }

        public DataTable CargarComboSexos()
        {
            string sql = "SELECT * FROM Sexo";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }

        public DataTable CargarComboLocalidades()
        {
            string sql = "SELECT * FROM Localidad";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }

        public DataTable CargarComboCategorias()
        {
            string sql = "SELECT * FROM Categoria";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }

        public DataTable CargarComboMarcas()
        {
            string sql = "SELECT * FROM Marca";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }
        public DataTable CargarComboEmpleados()
        {
            string sql = "SELECT * FROM Empleado";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }
            return tabla;
        }
        public DataTable CargarComboProveedores()
        {
            string sql = "SELECT * FROM Proveedor";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }
    }
}
