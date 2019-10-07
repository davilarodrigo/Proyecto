using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoPAV.Clases
{
    public class DVenta
    {
        static string cadenaConexion = "server = DESKTOP-0B3JQNF\\SQLEXPRESS; database = TP PAV; integrated security = true";
        //Variables
        private int _Idventa;
        private int _Idempleado;
        private int _Idcliente;
        private DateTime _Fechaventa ;
		private decimal _Montototal;

        //Constructores 
        public DVenta()
        {
        }
        public DVenta(int idventa, int idempleado,int idcliente, DateTime fechaventa, decimal montototal)
        {
            this.Idventa = idventa;
            this.Idcliente = idcliente;
            this.Idempleado = idempleado;
            this.Fechaventa = fechaventa;
            this.Montototal = montototal;

        }
        //Metodos 
        public string DisminuirStock(int idproducto, int cantidad)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            
            try
            {
                // Codigo 
                SqlCon.ConnectionString = cadenaConexion;
                SqlCon.Open();
                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdisminuir_stock";

                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproducto = new SqlParameter();
                ParIdproducto.ParameterName = "@idproducto";

                ParIdproducto.SqlDbType = SqlDbType.Int;
                ParIdproducto.Value = idproducto;

                SqlCmd.Parameters.Add(ParIdproducto);


                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";

                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;

                SqlCmd.Parameters.Add(ParCantidad);

                //Ejecutamos 

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el stock";



            }

            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }


    //Insetar venta

    public string Insertar(DVenta Venta, List<DDetalle_Venta> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo
                SqlCon.ConnectionString = cadenaConexion;
                SqlCon.Open();
                //Establecer transaccion
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdventa);


                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado ";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Venta.Idempleado;

                SqlCmd.Parameters.Add(ParIdempleado);



                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente ";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Venta.Idcliente;

                SqlCmd.Parameters.Add(ParIdcliente);



                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fechaventa ";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Venta.Fechaventa;
                SqlCmd.Parameters.Add(ParFecha);

                //Ejecutamos 
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el registro";
                if (rpta.Equals("OK"))
                {
                    //Obtener el codigo de la venta generada
                    this.Idventa = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);

                    foreach (DDetalle_Venta det in Detalle)
                    {
                        det.IdVenta = this.Idventa;
                        //Llamar al metodo para insetar
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //Actualizar stock
                            rpta = DisminuirStock(det.IdProducto, det.Cantidad);
                            if (!rpta.Equals("Ok"))
                            {
                                break;
                            }
                        }
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
        //Eliminar Venta
        public string Eliminar(DVenta Venta)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo
                SqlCon.ConnectionString = cadenaConexion;
                SqlCon.Open();

                //Establecer Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spelminiar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa ";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Venta.Idventa;
                SqlCmd.Parameters.Add(ParIdventa);

                //Ejecutamos 
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
        //Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Venta");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = cadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrarVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        //BuscarFechas
        
        public int Idventa { get => _Idventa; set => _Idventa = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public int Idcliente { get => _Idcliente; set => _Idcliente = value; }
        public DateTime Fechaventa { get => _Fechaventa; set => _Fechaventa = value; }
        public decimal Montototal { get => _Montototal; set => _Montototal = value; }

        public DataTable BuscarFecha(String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Venta");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = cadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_venta_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;

                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;

                ParTextoBuscar2.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        //Mostrar Detalle 
        public DataTable MostrarDetalle(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_venta");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = cadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;

                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Mostrar Articulos por nombre
        public DataTable MostrarArticulo_Venta_Nombre(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("articulo");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = cadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscararticulo_venta_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;

                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        //Mostrar Articulo por Codigo
        public DataTable MostrarArticulo_Venta_Codigo(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("articulo");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = cadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscararticulo_venta_codigo_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;

                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
