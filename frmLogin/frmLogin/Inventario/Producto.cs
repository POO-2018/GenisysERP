using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregamos los namespaces que necesitamos
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frmLogin.Inventario
{
    class Producto
    {
        //Atributos de la clase
        public int idInvetario { get; set; }
        public string idProducto { get; set; }
        public string nombre { get; set; }
        public int cantidadExistencia { get; set; }
        public int cantidadMinima { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        DateTime fechaIngresa { get; set; }
        public int idUsuario { get; set; }
        public string observaciones { get; set; }
        public int idImpuesto { get; set; }
        public int IdCategoria { get; set; }
        public int idProveedor { get; set; }
        public int estado { get; set; }

        // Constructores de la clase
        //public Producto() { }

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
                    resultado.idInvetario = rdr.GetInt32(0);
                    resultado.idProducto = rdr.GetString(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.cantidadExistencia = rdr.GetInt32(3);
                    resultado.cantidadMinima = rdr.GetInt32(4);
                    resultado.precioCompra = rdr.GetDecimal(5);
                    resultado.precioVenta = rdr.GetDecimal(6);
                    resultado.fechaIngresa = rdr.GetDateTime(7);
                    resultado.idUsuario = rdr.GetInt32(8);
                    resultado.observaciones = rdr.GetString(9);
                    resultado.idImpuesto = rdr.GetInt32(10);
                    resultado.IdCategoria = rdr.GetInt32(11);
                    resultado.idProveedor = rdr.GetInt32(12);
                    resultado.estado = rdr.GetInt32(13);
                }

                //Retornamos los datos obtenidos
                return resultado;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
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
        public bool InsertarProducto(Producto elProducto)
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
            //cmd.Parameters.Add(new SqlParameter("fechaIngreso", SqlDbType.DateTime));
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
            //cmd.Parameters["fechaIngreso"].Value = elProducto.fechaIngresa;
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Método de inhabilitación de producto

        public bool InhabilitarProducto(string elProducto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            SqlCommand cmd = conexion.EjecutarComando("sp_InhabiliarProducto");

            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros
            cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
           
            cmd.Parameters["idInventario"].Value = elProducto;
            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        //UPDATE Inventario.Producto SET estado=0
        //WHERE idInventario = @idInventario;
        // metodo para habilitar un producto
        public bool HabilitarProducto(string elProducto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            SqlCommand cmd = conexion.EjecutarComando("UPDATE Inventario.Producto SET estado=0" +
                                "WHERE idInventario = @idInventario;");

            // Parámetros
            cmd.Parameters.Add("@idInventario", SqlDbType.Int).Value = elProducto;
            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<Producto>LeerTodos()
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
                    resultado.idInvetario = rdr.GetInt32(0);
                    resultado.idProducto = rdr.GetString(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.cantidadExistencia = rdr.GetInt32(3);
                    resultado.cantidadMinima = rdr.GetInt32(4);
                    resultado.precioCompra = rdr.GetDecimal(5);
                    resultado.precioVenta = rdr.GetDecimal(6);
                    resultado.fechaIngresa = rdr.GetDateTime(7);
                    resultado.idUsuario = rdr.GetInt32(8);
                    resultado.observaciones = rdr.GetString(9);
                    resultado.idImpuesto = rdr.GetInt32(10);
                    resultado.IdCategoria = rdr.GetInt32(11);
                    resultado.idProveedor = rdr.GetInt32(12);
                    resultado.estado = Convert.ToInt32(rdr.GetValue(13));
                    Lista.Add(resultado);
                }

                //Retornamos los datos obtenidos
                return Lista ;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return Lista;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
