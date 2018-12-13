using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos los namespace necesario
using System.Data;
using System.Data.SqlClient;

namespace frmLogin.Compras
{
    class DetalleCompra
    {
        // Propiedades

        public int idDetalle { get; set; }
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public decimal precioUnitario { get; set; }
        public int cantidad { get; set; }
        public decimal subTotal { get; set; }

        // Constructor
        public DetalleCompra() { }

        // Métodos

        /// <summary>
        /// Método para insertar un Detalle de Compra
        /// </summary>
        /// <param name="elDetalle"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool InsertarDetalleCompra(DetalleCompra elDetalle)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarDetalleCompra");

            // Estableccer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@idCompra", SqlDbType.Int));
            cmd.Parameters["@idCompra"].Value = elDetalle.idCompra;

            cmd.Parameters.Add(new SqlParameter("@idProducto", SqlDbType.Int));
            cmd.Parameters["@idProducto"].Value = elDetalle.idProducto;

            cmd.Parameters.Add(new SqlParameter("@precioUnitario", SqlDbType.Decimal));
            cmd.Parameters["@precioUnitario"].Value = elDetalle.precioUnitario;

            cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.SmallInt));
            cmd.Parameters["@cantidad"].Value = elDetalle.cantidad;

            cmd.Parameters.Add(new SqlParameter("@subTotal", SqlDbType.Decimal));
            cmd.Parameters["@subTotal"].Value = elDetalle.subTotal;

            // Intentamos ejecutar el procedimiento
            try
            {
                // Establecemos la conexión
                conexion.EstablecerConexion();

                // Ejecutamos el query vía un ExecuteNonQuery
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
        /// <summary>
        /// Método para eliminar un Detalle de Compra
        /// </summary>
        /// <param name="elDetalle"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool EliminarDetalleCompra(DetalleCompra elDetalle)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_EliminarDetalleCompra");

            // Estableccer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@idDetalle", SqlDbType.Int));
            cmd.Parameters["@idDetalle"].Value = elDetalle.idDetalle;

            // Intentamos ejecutar el procedimiento
            try
            {
                // Establecemos la conexión
                conexion.EstablecerConexion();

                // Ejecutamos el query vía un ExecuteNonQuery
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
        /// <summary>
        /// Método para Actualizar un Detalle de Compra
        /// </summary>
        /// <param name="elDetalle"></param>
        /// <returns></returns>
        public static bool ActualizarDetalleCompra(DetalleCompra elDetalle)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarDetalleCompra");

            // Estableccer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure

            cmd.Parameters.Add(new SqlParameter("@idDetalle", SqlDbType.Int));
            cmd.Parameters["@idDetalle"].Value = elDetalle.idDetalle;

            //cmd.Parameters.Add(new SqlParameter("@idCompra", SqlDbType.Int));
            //cmd.Parameters["@idCompra"].Value = elDetalle.idCompra;

            //cmd.Parameters.Add(new SqlParameter("@idProducto", SqlDbType.Int));
            //cmd.Parameters["@idProducto"].Value = elDetalle.idProducto;

            //cmd.Parameters.Add(new SqlParameter("@precioUnitario", SqlDbType.Decimal));
            //cmd.Parameters["@precioUnitario"].Value = elDetalle.precioUnitario;

            cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.SmallInt));
            cmd.Parameters["@cantidad"].Value = elDetalle.cantidad;

            cmd.Parameters.Add(new SqlParameter("@subTotal", SqlDbType.Decimal));
            cmd.Parameters["@subTotal"].Value = elDetalle.subTotal;

            // Intentamos ejecutar el procedimiento
            try
            {
                // Establecemos la conexión
                conexion.EstablecerConexion();

                // Ejecutamos el query vía un ExecuteNonQuery
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        /// <summary>
        /// Método para traer todos los detalles de las compras
        /// Por el filtro del id de la compra
        /// </summary>
        /// <param name="idCompra"></param>
        /// <returns></returns>
        public static DataView GetDataViewPorCompra(int idCompra)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT		Compras.DetalleCompra.idDetalle					as Código,
			                    Compras.DetalleCompra.idCompra					as Compra,
			                    Inventario.Producto.nombre						as Producto,
			                    Compras.DetalleCompra.precioUnitario			as PrecioU,
			                    Compras.DetalleCompra.cantidad					as Cantidad,
			                    Compras.DetalleCompra.subTotal					as SubTotal
                    FROM Compras.DetalleCompra
                    INNER JOIN Inventario.Producto
                    ON Inventario.Producto.idInventario = Compras.DetalleCompra.idProducto
                    WHERE Compras.DetalleCompra.idCompra = @idCompra";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                // Especificamos las varibles escalares
                cmd.Parameters.Add("@idCompra", SqlDbType.Int).Value = idCompra;

                data.SelectCommand = cmd;

                DataSet ds = new DataSet();

                // La tabla con que vamos a llenar los datos
                data.Fill(ds, "Compras.DetalleCompra");
                DataTable dt = ds.Tables["Compras.DetalleCompra"];

                DataView dv = new DataView(dt,
                    "", "Código",
                    DataViewRowState.Unchanged);
                return dv;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
