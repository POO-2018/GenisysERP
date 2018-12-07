using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregamos los namespaces que necesitamos
using System.Data;
using System.Data.SqlClient;

namespace frmLogin.Inventario
{
    class Producto
    {
        //Atributos de la clase
        int idInvetario { get; set; }
        int idProducto { get; set; }
        string nombre { get; set; }
        int cantidadExistencia { get; set; }
        int cantidadMinima { get; set; }
        float precioCompra { get; set; }
        float precioVenta { get; set; }
        DateTime fechaIngresa { get; set; }
        int idUsuario { get; set; }
        string observaciones { get; set; }
        int idImpuesto { get; set; }
        int IdCategoria { get; set; }
        int idProveedor { get; set; }
        int estado { get; set; }

        // Constructores de la clase
        public Producto() { }

        // Métodos de la clase Producto.

            /// <summary>
            /// Método para listar las especificaciones
            /// de un producto en específico.
            /// </summary>
            /// <param name="CodigoProducto"></param>
            /// <returns></returns>
        public static Producto ObtenerProducto(int CodigoProducto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            Producto resultado = new Producto();

            sql = @"SELECT * FROM Inventario.Producto WHERE idProducto=@Producto;";
            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;
            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@Producto", SqlDbType.Char, 13).Value = CodigoProducto;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.idInvetario = rdr.GetInt16(0);
                    resultado.idProducto = rdr.GetInt16(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.cantidadExistencia = rdr.GetInt16(3);
                    resultado.cantidadMinima = rdr.GetInt16(4);
                    resultado.precioCompra = rdr.GetFloat(5);
                    resultado.precioVenta = rdr.GetFloat(6);
                    resultado.fechaIngresa = rdr.GetDateTime(7);
                    resultado.idUsuario = rdr.GetInt16(8);
                    resultado.observaciones = rdr.GetString(9);
                    resultado.idImpuesto = rdr.GetInt16(10);
                    resultado.IdCategoria = rdr.GetInt16(11);
                    resultado.idProveedor = rdr.GetInt16(12);
                    resultado.estado = rdr.GetInt16(13);
                }

                //Retornamos los datos obtenidos
                return resultado;
            }
            catch (SqlException)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Se encarga de la inserción de un nuevo producto en la base de datos
        /// 
        /// </summary>
        /// <param name="elProducto"></param>
        /// <returns>true si se insertó, false si ocurre un error</returns>
        public static bool InsertarProducto(Producto elProducto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarProducto");

            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros
            cmd.Parameters.Add(new SqlParameter("idProducto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar,100));
            cmd.Parameters.Add(new SqlParameter("cantidadExistencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("cantidadMinima", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("precioCompra", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("precioVenta", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("fechaIngreso", SqlDbType.DateTime2));
            cmd.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("observaciones", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("idImpuesto", SqlDbType.Int));                 
            cmd.Parameters.Add(new SqlParameter("idCategoria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.Bit));

            cmd.Parameters["idProducto"].Value = elProducto.idProducto;
            cmd.Parameters["nombre"].Value = elProducto.nombre;
            cmd.Parameters["cantidadExistencia"].Value = elProducto.cantidadExistencia;
            cmd.Parameters["cantidadMinima"].Value = elProducto.cantidadMinima;
            cmd.Parameters["precioCompra"].Value = elProducto.precioCompra;
            cmd.Parameters["precioVenta"].Value = elProducto.precioVenta;
            cmd.Parameters["fechaIngreso"].Value = elProducto.fechaIngresa;
            cmd.Parameters["idUsuario"].Value = elProducto.idUsuario;
            cmd.Parameters["observaciones"].Value = elProducto.observaciones;
            cmd.Parameters["idImpuesto"].Value = elProducto.idImpuesto;
            cmd.Parameters["idCategoria"].Value = elProducto.IdCategoria;
            cmd.Parameters["idProveedor"].Value = elProducto.idProveedor;
            cmd.Parameters["estado"].Value = elProducto.estado;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        public static bool ActualizarProducto(Producto elProducto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarProducto");

            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros
            cmd.Parameters.Add(new SqlParameter("idProducto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("cantidadExistencia", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("cantidadMinima", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("precioCompra", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("precioVenta", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("fechaIngreso", SqlDbType.DateTime2));
            cmd.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("observaciones", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("idImpuesto", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("idCategoria", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.Bit));

            cmd.Parameters["idProducto"].Value = elProducto.idProducto;
            cmd.Parameters["nombre"].Value = elProducto.nombre;
            cmd.Parameters["cantidadExistencia"].Value = elProducto.cantidadExistencia;
            cmd.Parameters["cantidadMinima"].Value = elProducto.cantidadMinima;
            cmd.Parameters["precioCompra"].Value = elProducto.precioCompra;
            cmd.Parameters["precioVenta"].Value = elProducto.precioVenta;
            cmd.Parameters["fechaIngreso"].Value = elProducto.fechaIngresa;
            cmd.Parameters["idUsuario"].Value = elProducto.idUsuario;
            cmd.Parameters["observaciones"].Value = elProducto.observaciones;
            cmd.Parameters["idImpuesto"].Value = elProducto.idImpuesto;
            cmd.Parameters["idCategoria"].Value = elProducto.IdCategoria;
            cmd.Parameters["idProveedor"].Value = elProducto.idProveedor;
            cmd.Parameters["estado"].Value = elProducto.estado;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Método de inhabilitación de producto

        public static bool ActualizarProducto(Producto elProducto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            SqlCommand cmd = conexion.EjecutarComando("sp_InhabiliarProducto");

            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros
            cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
           
            cmd.Parameters["idInventario"].Value = elProducto.idInvetario;
            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
 

        public static List<Producto>LeerTodos()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            List<Producto> Lista = new List<Producto>();

            sql = @"SELECT * FROM Inventario.Producto;";
            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;
            try
            {
                
                 rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                     Producto resultado = new Producto();
                    resultado.idInvetario = rdr.GetInt16(0);
                    resultado.idProducto = rdr.GetInt16(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.cantidadExistencia = rdr.GetInt16(3);
                    resultado.cantidadMinima = rdr.GetInt16(4);
                    resultado.precioCompra = rdr.GetFloat(5);
                    resultado.precioVenta = rdr.GetFloat(6);
                    resultado.fechaIngresa = rdr.GetDateTime(7);
                    resultado.idUsuario = rdr.GetInt16(8);
                    resultado.observaciones = rdr.GetString(9);
                    resultado.idImpuesto = rdr.GetInt16(10);
                    resultado.IdCategoria = rdr.GetInt16(11);
                    resultado.idProveedor = rdr.GetInt16(12);
                    resultado.estado = rdr.GetInt16(13);
                }

                //Retornamos los datos obtenidos
                return resultado;
            }
            catch (SqlException)
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
