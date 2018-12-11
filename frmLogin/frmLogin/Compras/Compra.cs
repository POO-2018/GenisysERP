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
    class Compra
    {
        // Propiedades
        public int idCompra { get; set; }
        public DateTime fechaCompra { get; set; }
        public string numeroFactura { get; set; }
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public decimal subTotal { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public string observaciones { get; set; }
        public string estadoCompra { get; set; }
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string autorizadaPor { get; set; }
        public int estado { get; set; }


        // Constructor 
        public Compra() { }

        // Métodos

        /// <summary>
        /// Método para insertar una compra
        /// </summary>
        /// <param name="laCompra"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool InsertarCompra(Compra laCompra)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarCompra");

            // Estableccer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@fechaCompra", SqlDbType.DateTime));
            cmd.Parameters["@fechaCompra"].Value = laCompra.fechaCompra;

            //cmd.Parameters.Add(new SqlParameter("@numeroFactura", SqlDbType.NVarChar, 19));
            //cmd.Parameters["@numeroFactura"].Value = laCompra.numeroFactura;

            cmd.Parameters.Add(new SqlParameter("@idProveedor", SqlDbType.DateTime));
            cmd.Parameters["@idProveedor"].Value = laCompra.idProveedor;

            cmd.Parameters.Add(new SqlParameter("@subtotal", SqlDbType.Decimal));
            cmd.Parameters["@subtotal"].Value = laCompra.subTotal;

            cmd.Parameters.Add(new SqlParameter("@impuesto", SqlDbType.Decimal));
            cmd.Parameters["@impuesto"].Value = laCompra.impuesto;

            cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Decimal));
            cmd.Parameters["@total"].Value = laCompra.total;

            cmd.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 50));
            cmd.Parameters["@observaciones"].Value = laCompra.observaciones;

            cmd.Parameters.Add(new SqlParameter("@estadoCompra", SqlDbType.NVarChar, 50));
            cmd.Parameters["@estadoCompra"].Value = laCompra.estadoCompra;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = laCompra.idUsuario;

            cmd.Parameters.Add(new SqlParameter("@autorizadaPor", SqlDbType.NVarChar, 50));
            cmd.Parameters["@autorizadaPor"].Value = laCompra.autorizadaPor;

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
        /// Método para actualizar una compra
        /// </summary>
        /// <param name="laCompra"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool ActualizarCompra(Compra laCompra)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarCompra");

            // Estableccer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure

            cmd.Parameters.Add(new SqlParameter("@idCompra", SqlDbType.Int));
            cmd.Parameters["@idCompra"].Value = laCompra.idCompra;

            cmd.Parameters.Add(new SqlParameter("@fechaCompra", SqlDbType.DateTime));
            cmd.Parameters["@fechaCompra"].Value = laCompra.fechaCompra;

            cmd.Parameters.Add(new SqlParameter("@numeroFactura", SqlDbType.NVarChar, 19));
            cmd.Parameters["@numeroFactura"].Value = laCompra.numeroFactura;

            cmd.Parameters.Add(new SqlParameter("@idProveedor", SqlDbType.DateTime));
            cmd.Parameters["@idProveedor"].Value = laCompra.idProveedor;

            cmd.Parameters.Add(new SqlParameter("@subtotal", SqlDbType.Decimal));
            cmd.Parameters["@subtotal"].Value = laCompra.subTotal;

            cmd.Parameters.Add(new SqlParameter("@impuesto", SqlDbType.Decimal));
            cmd.Parameters["@impuesto"].Value = laCompra.impuesto;

            cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Decimal));
            cmd.Parameters["@total"].Value = laCompra.total;

            cmd.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 50));
            cmd.Parameters["@observaciones"].Value = laCompra.observaciones;

            cmd.Parameters.Add(new SqlParameter("@estadoCompra", SqlDbType.NVarChar, 50));
            cmd.Parameters["@estadoCompra"].Value = laCompra.estadoCompra;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = laCompra.idUsuario;

            cmd.Parameters.Add(new SqlParameter("@autorizadaPor", SqlDbType.NVarChar, 50));
            cmd.Parameters["@autorizadaPor"].Value = laCompra.autorizadaPor;

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
        /// Método para actualizar el estado de una Compra
        /// </summary>
        /// <param name="laCompra"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool ActualizarEstadoCompra(Compra laCompra)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarEstadoCompra");

            // Estableccer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure

            cmd.Parameters.Add(new SqlParameter("@idCompra", SqlDbType.Int));
            cmd.Parameters["@idCompra"].Value = laCompra.idCompra;
                        
            cmd.Parameters.Add(new SqlParameter("@estadoCompra", SqlDbType.NVarChar, 50));
            cmd.Parameters["@estadoCompra"].Value = laCompra.estadoCompra;

            cmd.Parameters.Add(new SqlParameter("@autorizadaPor", SqlDbType.NVarChar, 50));
            cmd.Parameters["@autorizadaPor"].Value = laCompra.autorizadaPor;

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
        /// Método para inhabilitar el estado de una compra
        /// </summary>
        /// <param name="laCompra"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool InhabilitarCompra(Compra laCompra)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InhabilitarCompra");

            // Estableccer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure

            cmd.Parameters.Add(new SqlParameter("@idCompra", SqlDbType.Int));
            cmd.Parameters["@idCompra"].Value = laCompra.idCompra;

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
        /// Método para traer todas las compras
        /// Por el filtro de su estado
        /// </summary>
        /// <param name="estadoCompra"></param>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataViewPorEstado(string estadoCompra)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT		Compras.Compra.idCompra					as Código,
                                Compras.Compra.fechaCompra				as Fecha,
                                Compras.Compra.numeroFactura			as Factura,
                                Clientes.Proveedor.nombreEmpresa		as Proveedor,
                                Compras.Compra.subTotal					as SubTotal,
                                Compras.Compra.impuesto					as Impuesto,
                                Compras.Compra.total					as Total,
                                Compras.Compra.observaciones			as Observaciones,
                                Empleados.Usuario.nombreUsuario			as Usuario,
                                Compras.Compra.autorizadaPor			as Autorizado
                    FROM Compras.Compra
                    INNER JOIN Clientes.Proveedor
                    ON Clientes.Proveedor.idProveedor = Compras.Compra.idProveedor
                    INNER JOIN Empleados.Usuario
                    ON Empleados.Usuario.id = Compras.Compra.idUsuario
                    WHERE Compras.Compra.estado = 1
                    AND Compras.Compra.estadoCompra = @estadoCompra";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                // Especificamos las varibles escalares
                cmd.Parameters.Add("@estadoCompra", SqlDbType.NVarChar, 50).Value = estadoCompra;

                data.SelectCommand = cmd;

                DataSet ds = new DataSet();

                // La tabla con que vamos a llenar los datos
                data.Fill(ds, "Compras.Compra");
                DataTable dt = ds.Tables["Compras.Compra"];

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

        /// <summary>
        /// Método para traer todas las compras
        /// Por el filtro de su numero de factura
        /// </summary>
        /// <param name="factura"></param>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataViewPorFactura(string factura)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT		Compras.Compra.idCompra					as Código,
                                Compras.Compra.fechaCompra				as Fecha,
                                Compras.Compra.numeroFactura			as Factura,
                                Clientes.Proveedor.nombreEmpresa		as Proveedor,
                                Compras.Compra.subTotal					as SubTotal,
                                Compras.Compra.impuesto					as Impuesto,
                                Compras.Compra.total					as Total,
                                Compras.Compra.observaciones			as Observaciones,
                                Empleados.Usuario.nombreUsuario			as Usuario,
                                Compras.Compra.autorizadaPor			as Autorizado
                    FROM Compras.Compra
                    INNER JOIN Clientes.Proveedor
                    ON Clientes.Proveedor.idProveedor = Compras.Compra.idProveedor
                    INNER JOIN Empleados.Usuario
                    ON Empleados.Usuario.id = Compras.Compra.idUsuario
                    WHERE Compras.Compra.estado = 1
                    AND Compras.Compra.numeroFactura = @factura";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                // Especificamos las varibles escalares
                cmd.Parameters.Add("@factura", SqlDbType.NVarChar, 50).Value = factura;

                data.SelectCommand = cmd;

                DataSet ds = new DataSet();

                // La tabla con que vamos a llenar los datos
                data.Fill(ds, "Compras.Compra");
                DataTable dt = ds.Tables["Compras.Compra"];

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

        /// <summary>
        /// /// Método para traer todas las compras
        /// Por el filtro de su proveedor
        /// </summary>
        /// <param name="nombreEmpresa"></param>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataViewPorProveedor(string nombreEmpresa)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT		Compras.Compra.idCompra					as Código,
                                Compras.Compra.fechaCompra				as Fecha,
                                Compras.Compra.numeroFactura			as Factura,
                                Clientes.Proveedor.nombreEmpresa		as Proveedor,
                                Compras.Compra.subTotal					as SubTotal,
                                Compras.Compra.impuesto					as Impuesto,
                                Compras.Compra.total					as Total,
                                Compras.Compra.observaciones			as Observaciones,
                                Empleados.Usuario.nombreUsuario			as Usuario,
                                Compras.Compra.autorizadaPor			as Autorizado
                    FROM Compras.Compra
                    INNER JOIN Clientes.Proveedor
                    ON Clientes.Proveedor.idProveedor = Compras.Compra.idProveedor
                    INNER JOIN Empleados.Usuario
                    ON Empleados.Usuario.id = Compras.Compra.idUsuario
                    WHERE Compras.Compra.estado = 1
                    AND Clientes.Proveedor.nombreEmpresa = @nombreEmpresa";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                // Especificamos las varibles escalares
                cmd.Parameters.Add("@nombreEmpresa", SqlDbType.NVarChar, 50).Value = nombreEmpresa;

                data.SelectCommand = cmd;

                DataSet ds = new DataSet();

                // La tabla con que vamos a llenar los datos
                data.Fill(ds, "Compras.Compra");
                DataTable dt = ds.Tables["Compras.Compra"];

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
