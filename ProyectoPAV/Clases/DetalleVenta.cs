using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoPAV.Clases;

namespace ProyectoPAV.Clases
{
    public class DDetalle_Venta

    {
        GestorABMCs gestor = new GestorABMCs();
        static string cadenaConexion = "server = DESKTOP-0B3JQNF\\SQLEXPRESS; database = TP PAV; integrated security = true";
        SqlConnection conexion = new SqlConnection(cadenaConexion);
        SqlCommand comando = new SqlCommand();

        private int _Iddetalle_venta;
        private int _IdVenta;
        private int _IdProducto;
        private int _Cantidad;
        private int _NumeroTalle;
        private decimal _precioVenta;

        public int Iddetalle_venta
            {
                get { return _Iddetalle_venta; }
                set { _Iddetalle_venta = value; }
            }

        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public int NumeroTalle { get => _NumeroTalle; set => _NumeroTalle = value; }
        public decimal PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }


        public DDetalle_Venta()
        {
        }
        public DDetalle_Venta(int iddetalle_venta, int cantidad, int idproducto, int numerotalle,
                decimal precioventa, int idventa)
            {
                this.Iddetalle_venta = iddetalle_venta;
                this.IdProducto = idproducto;
                this.Cantidad = cantidad;
                this.NumeroTalle = numerotalle;
                this.PrecioVenta = precioventa;
                this.IdVenta = idventa;
            }
        public string Insertar(DDetalle_Venta Detalle_Venta, ref SqlConnection conexion , ref SqlTransaction SqlTra )
        {
            string rpta = "";
            try
            {
                
                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                
                SqlCmd.Connection = conexion;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Venta = new SqlParameter();
                ParIddetalle_Venta.ParameterName = "@iddetalle_venta";
                ParIddetalle_Venta.SqlDbType = SqlDbType.Int;
                ParIddetalle_Venta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Venta);

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Detalle_Venta.IdVenta;
                SqlCmd.Parameters.Add(ParIdventa);
        

                SqlParameter ParIdproducto = new SqlParameter();
                ParIdproducto.ParameterName = "@idproduto";
                ParIdproducto.SqlDbType = SqlDbType.Int;
                ParIdproducto.Value = Detalle_Venta.IdProducto;
                SqlCmd.Parameters.Add(ParIdproducto);
        
                SqlParameter ParNumerotalle = new SqlParameter();
                ParNumerotalle.ParameterName = "@numerotalle";
                ParNumerotalle.SqlDbType = SqlDbType.Int;
                ParNumerotalle.Value = Detalle_Venta.NumeroTalle;
                SqlCmd.Parameters.Add(ParNumerotalle);
        

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Detalle_Venta.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);
        

                SqlParameter ParPrecio_venta = new SqlParameter();
                ParPrecio_venta.ParameterName = "@precio_venta";
                ParPrecio_venta.SqlDbType = SqlDbType.Money;
                ParPrecio_venta.Value = Detalle_Venta.PrecioVenta;
                SqlCmd.Parameters.Add(ParPrecio_venta);

                // Ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
        catch (Exception ex)
            {
                rpta = ex.Message;
            }

         return rpta;

        }
    } 
}
