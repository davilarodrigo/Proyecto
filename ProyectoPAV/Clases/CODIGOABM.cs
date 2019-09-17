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
    class CODIGOABM
    {
        //public DataTable consultarClientes(string patron)
        //{
        //    BE BD = new BE();
        //    string sql = @"SELECT u.*, p.n_perfil
        //                     FROM users u join perfiles p ON u.id_perfil = p.id_perfil 
        //                     WHERE n_usuario like '%" + patron + "%'";
        //    return BD.ejecutar_consulta(sql);
        //}
        public DataTable consultarProveedores(string razonsocial)
        {
            BE BD = new BE();
            string sql = @"SELECT P.*, L.Nombre
                             FROM PROVEEDORES P join LOCALIDADES L ON P.IdLocalidad = L.IdLocalidad
                            WHERE " + razonsocial + "= P.RazonSocial";
            return BD.ejecutar_consulta(sql);
        }
        public void InsertarProveedor(string RazonSocial
                               , string Email
                               , string Telefono
                               , string Calle
                               , string NumeroCalle
                               , string IdLocalidad)
        {
            string sql_insert = "";
            sql_insert = @"INSERT INTO PROVEEDORES (
                         RazonSocial
                        , Email
                        , Telefono
                        , Calle
                        , NumeroCalle
                        , IdLocalidad) VALUES ("
                        + "'" + RazonSocial + "'"
                        + ",'" + Email + "'"
                        + ",'" + Telefono + "'"
                        + "," + Calle + "'"
                        + "," + NumeroCalle + "'"
                        + "," + IdLocalidad + ")";
            BE BD = new BE();
            if (BD.insertar(sql_insert) ==
                BE.estado_BE.correcto)
            {
                MessageBox.Show(@"Se cargó 
                    correctamente los datos");
            }
            else
            {
                MessageBox.Show(@"No se cargó 
                    correctamente los datos");
            }
        }
    }
}
