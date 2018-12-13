using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos los namespace necesario
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frmLogin.Compras
{
    class Compra
    {
        // Propiedades
        public int idCompra { get; set; }
        public DateTime fechaCompra { get; set; }
        public string numeroFactura { get; set; }
        public int idProveedor { get; set; }
        public int idCategoria { get; set; }
        public string nombreCategoria { get; set; }
        public string nombreProveedor { get; set; }
        public decimal subTotal { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public string observaciones { get; set; }
        public string estadoCompra { get; set; }
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public int autorizadaPor { get; set; }
        public int idInventario { get; set; }
        public string nombreInventario { get; set; }
        public decimal PrecioCompra { set; get; }
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
            //cmd.Parameters.Add(new SqlParameter("@fechaCompra", SqlDbType.DateTime));
            //cmd.Parameters["@fechaCompra"].Value = laCompra.fechaCompra;

            //cmd.Parameters.Add(new SqlParameter("@numeroFactura", SqlDbType.NVarChar, 19));
            //cmd.Parameters["@numeroFactura"].Value = laCompra.numeroFactura;

            cmd.Parameters.Add(new SqlParameter("@idProveedor", SqlDbType.Int));
            cmd.Parameters["@idProveedor"].Value = laCompra.idProveedor;

            cmd.Parameters.Add(new SqlParameter("@subTotal", SqlDbType.Decimal));
            cmd.Parameters["@subTotal"].Value = laCompra.subTotal;

            cmd.Parameters.Add(new SqlParameter("@impuesto", SqlDbType.Decimal));
            cmd.Parameters["@impuesto"].Value = laCompra.impuesto;

            cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Decimal));
            cmd.Parameters["@total"].Value = laCompra.total;

            cmd.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 150));
            cmd.Parameters["@observaciones"].Value = laCompra.observaciones;

            cmd.Parameters.Add(new SqlParameter("@estadoCompra", SqlDbType.NVarChar, 50));
            cmd.Parameters["@estadoCompra"].Value = laCompra.estadoCompra;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = laCompra.idUsuario;

            //cmd.Parameters.Add(new SqlParameter("@autorizadaPor", SqlDbType.Int));
            //cmd.Parameters["@autorizadaPor"].Value = laCompra.autorizadaPor;

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
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Errors[0].ToString());
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

            //cmd.Parameters.Add(new SqlParameter("@fechaCompra", SqlDbType.DateTime));
            //cmd.Parameters["@fechaCompra"].Value = laCompra.fechaCompra;

            //cmd.Parameters.Add(new SqlParameter("@numeroFactura", SqlDbType.NVarChar, 19));
            //cmd.Parameters["@numeroFactura"].Value = laCompra.numeroFactura;

            //cmd.Parameters.Add(new SqlParameter("@idProveedor", SqlDbType.DateTime));
            //cmd.Parameters["@idProveedor"].Value = laCompra.idProveedor;

            cmd.Parameters.Add(new SqlParameter("@subTotal", SqlDbType.Decimal));
            cmd.Parameters["@subTotal"].Value = laCompra.subTotal;

            cmd.Parameters.Add(new SqlParameter("@impuesto", SqlDbType.Decimal));
            cmd.Parameters["@impuesto"].Value = laCompra.impuesto;

            cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Decimal));
            cmd.Parameters["@total"].Value = laCompra.total;

            cmd.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 150));
            cmd.Parameters["@observaciones"].Value = laCompra.observaciones;

            //cmd.Parameters.Add(new SqlParameter("@estadoCompra", SqlDbType.NVarChar, 50));
            //cmd.Parameters["@estadoCompra"].Value = laCompra.estadoCompra;

            cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.Int));
            cmd.Parameters["@Usuario"].Value = laCompra.idUsuario;

            //cmd.Parameters.Add(new SqlParameter("@autorizadaPor", SqlDbType.NVarChar, 50));
            //cmd.Parameters["@autorizadaPor"].Value = laCompra.autorizadaPor;

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
                MessageBox.Show(ex.Errors[0].ToString());
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

        /// <summary>
        /// Método para traer todo el inventario
        /// Por el filtro del proveedor y categgoria de producto
        /// </summary>
        /// <param name="proveedor"></param>
        /// <param name="categoria"></param>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataViewPorPrevedorCategoria(int proveedor, int categoria)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT          Inventario.Producto.idInventario            as Id,
                                    Inventario.Producto.idProducto              as Código,
                                    Inventario.Producto.nombre                  as Nombre,
                                --Inventario.Producto.cantidadExistencia      as Existencia,
                                --Inventario.Producto.cantidadMinima          as Minimo,
                                    Inventario.Producto.precioCompra            as Compra,
                                --Inventario.Producto.precioVenta             as Venta,
                                --Inventario.Producto.observaciones           as Observaciones,
                                Inventario.Impuesto.valor                   as Impuesto,
                                Inventario.Categoria.nombre                 as Categoria
                    FROM Inventario.Producto
                    INNER JOIN Inventario.Impuesto
                    ON Inventario.Impuesto.idImpuesto = Inventario.Producto.idImpuesto
                    INNER JOIN Inventario.Categoria
                    ON Inventario.Categoria.idCategoria = Inventario.Producto.idCategoria
                    WHERE Inventario.Producto.idProveedor = @idProveedor
                    AND Inventario.Producto.idCategoria = @idCategoria
                    AND Inventario.Producto.estado = 1";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                // Especificamos las varibles escalares
                cmd.Parameters.Add("@idProveedor", SqlDbType.Int).Value = proveedor;
                cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = categoria;

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
        /// Método para traer todo el inventario
        /// Por el filtro del proveedor 
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataViewProductosPorProveedor(string proveedor)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"  SELECT          Inventario.Producto.idInventario            as Id,
                                    Inventario.Producto.idProducto              as Código,
                                    Inventario.Producto.nombre                  as Nombre,
                                --Inventario.Producto.cantidadExistencia      as Existencia,
                                --Inventario.Producto.cantidadMinima          as Minimo,
                                    Inventario.Producto.precioCompra            as Compra,
                                --Inventario.Producto.precioVenta             as Venta,
                                --Inventario.Producto.observaciones           as Observaciones,
                                --Inventario.Impuesto.valor                   as Impuesto,
                                Inventario.Categoria.nombre                 as Categoria
                    FROM Inventario.Producto
                    INNER JOIN Inventario.Categoria
                    ON Inventario.Categoria.idCategoria = Inventario.Producto.idCategoria
                    WHERE Inventario.Producto.idProveedor=(SELECT Clientes.Proveedor.idProveedor FROM Clientes.Proveedor WHERE Clientes.Proveedor.nombreEmpresa= @idProveedor)
                    AND Inventario.Producto.estado = 1";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                // Especificamos las varibles escalares
                cmd.Parameters.Add("@idProveedor", SqlDbType.NVarChar,100).Value = proveedor;

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
        /// Método para traer todo el inventario
        /// Por el filtro del proveedor y categgoria de producto
        /// </summary>
        /// <param name="proveedor"></param>
        /// <param name="categoria"></param>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataViewPorPrevedorCategoriaNombre(int proveedor, int categoria, string nombre)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT      Inventario.Producto.idInventario            as Id,
                                Inventario.Producto.idProducto              as Código,
                                Inventario.Producto.nombre                  as Nombre,
                                --Inventario.Producto.cantidadExistencia      as Existencia,
                                --Inventario.Producto.cantidadMinima          as Minimo,
                                Inventario.Producto.precioCompra            as Compra,
                                --Inventario.Producto.precioVenta             as Venta,
                                --Inventario.Producto.observaciones           as Observaciones,
                                Inventario.Impuesto.valor                   as Impuesto,
                                Inventario.Categoria.nombre                 as Categoria
                        FROM Inventario.Producto
                        INNER JOIN Inventario.Impuesto
                        ON Inventario.Impuesto.idImpuesto = Inventario.Producto.idImpuesto
                        INNER JOIN Inventario.Categoria
                        ON Inventario.Categoria.idCategoria = Inventario.Producto.idCategoria
                        WHERE Inventario.Producto.idProveedor = @idProveedor
                        AND Inventario.Producto.idCategoria = @idCategoria
                        AND Inventario.Producto.nombre LIKE '%' + @nombre + '%'
                        AND Inventario.Producto.estado = 1";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                // Especificamos las varibles escalares
                cmd.Parameters.Add("@idProveedor", SqlDbType.Int).Value = proveedor;
                cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = categoria;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;


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
        /// Método para listar todos los Proveedores
        /// </summary>
        /// <returns>Una lista con todos los Proveedores</returns>
        public static List<Compra> LeerTodosProveedores()
        {
            // Instanciamos la clase Conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos una lista de tipo de cliente
            List<Compra> resultados = new List<Compra>();

            // Creamos el query
            string sql = @"SELECT idProveedor, nombreEmpresa
                            FROM Clientes.Proveedor
                            WHERE estado=1";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();

                // Ejecutamos el query vía un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Recorremos los elementos del Reader y los almacenamos
                // en la lista de Proveedor

                while (rdr.Read())
                {
                    Compra elProveedor = new Compra();

                    // Asignamos los valores del Reader al objeto
                    elProveedor.idProveedor = Convert.ToInt16(rdr[0]);
                    elProveedor.nombreProveedor = rdr.GetString(1);

                    // Agregamos El proveedor a la lista
                    resultados.Add(elProveedor);
                }

                // retornamos la lista de las Compra
                return resultados;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Errors[0].ToString());

                return resultados;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Método para listar todas las Categorias
        /// </summary>
        /// <returns>Una lista con todos los Proveedores</returns>
        public static List<Compra> LeerTodasCategorias()
        {
            // Instanciamos la clase Conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");

            // Creamos una lista de tipo de cliente
            List<Compra> resultados = new List<Compra>();

            // Creamos el query
            string sql = @"SELECT idCategoria, nombre
                            FROM Inventario.Categoria";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();

                // Ejecutamos el query vía un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Recorremos los elementos del Reader y los almacenamos
                // en la lista de Proveedor

                while (rdr.Read())
                {
                    Compra laCategoria = new Compra();

                    // Asignamos los valores del Reader al objeto
                    laCategoria.idCategoria = Convert.ToInt16(rdr[0]);
                    laCategoria.nombreCategoria = rdr.GetString(1);

                    // Agregamos El proveedor a la lista
                    resultados.Add(laCategoria);
                }

                // retornamos la lista de las Compra
                return resultados;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Errors[0].ToString());

                return resultados;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        /// <summary>
        /// Metodo para optener el codigo del proveedor
        /// </summary>
        /// <param name="nombreProveedor"></param>
        /// <returns></returns>
        public static Compra ObtenerInformacionProveedor(string nombreProveedor)
        {

            // Instanciamos la clase Conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");
            // Creamos la variable que contendrá el Query
            string sql;
            // Instanciamos la clase Compra
            Compra resultado = new Compra();

            // Query SQL
            sql = @"SELECT idProveedor, nombreEmpresa
                            FROM Clientes.Proveedor
                            WHERE nombreEmpresa=@nombre AND estado=1";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            // Crearemos la lectura
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 45).Value = nombreProveedor;
                    // Ejecutamos el query vía un ExecuteReader
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.idProveedor = Convert.ToInt16(rdr[0]);
                    resultado.nombreProveedor = rdr.GetString(1);
                }

                return resultado;
            }
            catch (Exception)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public static Compra ObtenerInformacionCategoria(string Categoria)
        {

            // Instanciamos la clase Conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");
            // Creamos la variable que contendrá el Query
            string sql;
            // Instanciamos la clase Compra
            Compra resultado = new Compra();

            // Query SQL
            sql = @"SELECT idCategoria, nombre
                            FROM Inventario.Categoria
                            WHERE nombre=@nombre";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            // Crearemos la lectura
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 45).Value = Categoria;
                    // Ejecutamos el query vía un ExecuteReader
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.idCategoria = Convert.ToInt16(rdr[0]);
                    resultado.nombreCategoria = rdr.GetString(1);
                }

                return resultado;
            }
            catch (Exception)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }



        public static Compra ObtenerInformacionInventario(int id)
        {

            // Instanciamos la clase Conexion
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");
            // Creamos la variable que contendrá el Query
            string sql;
            // Instanciamos la clase Compra
            Compra resultado = new Compra();

            // Query SQL
            sql = @"SELECT Inventario.Producto.idInventario, Inventario.Producto.nombre,Inventario.Producto.precioCompra, Inventario.Impuesto.valor
                    FROM Inventario.Producto
                    INNER JOIN Inventario.Impuesto
                    ON Inventario.Impuesto.idImpuesto = Inventario.Producto.idImpuesto
                            WHERE idInventario=@inventario";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            // Crearemos la lectura
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@inventario", SqlDbType.Int).Value = id;
                    // Ejecutamos el query vía un ExecuteReader
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.idInventario = Convert.ToInt16(rdr[0]);
                    resultado.nombreInventario = rdr.GetString(1);
                    resultado.PrecioCompra = Convert.ToDecimal(rdr[2]);
                    resultado.impuesto = Convert.ToDecimal(rdr[2]);
                }

                return resultado;
            }
            catch (Exception)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }



    }
}
