using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace frmLogin.Inventario
{
    class CategoriaInventario
    {
        // Propiedades de la clase CategoriaInventario
        // Esta clase tambien hace uso de usuarios
        public int idCategoria { get; set; }
        public string idCodigoTipo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int idUsuario { get; set; }

        // Constructor
        public CategoriaInventario() { }

        // Métodos para la clase

        public static bool ObtenerCategoria(CategoriaInventario categoria)
        {

            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            SqlCommand cmd = conexion.EjecutarComando("Inventario.sp_ListarCategoriaInventario");

            cmd.CommandType = CommandType.StoredProcedure;

            // Parametros

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 100));
            cmd.Parameters["@Nombre"].Value = categoria.nombre;

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

        // Listar las categorías de Inventario existentes 
        public static List<CategoriaInventario> ListarCategorias()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            string sql;
            List<CategoriaInventario> Lista = new List<CategoriaInventario>();

            // Query SQL
            sql = @"select  idCategoria, idCodigoTipo, nombre, descripcion, idUsuario FROM Inventario.Categoria  
                    WHERE estado = 1 Order by idCategoria";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;
            DataGridView data = new DataGridView();
            try
            {

                conexion.EstablecerConexion();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                data.DataSource = dt;


                rdr = cmd.ExecuteReader();

            

                while (rdr.Read())
                {
                    CategoriaInventario resultado = new CategoriaInventario();
                    resultado.idCategoria = rdr.GetInt32(0);
                    resultado.idCodigoTipo = rdr.GetString(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.descripcion = rdr.GetString(3);
                    resultado.idUsuario = rdr.GetInt32(4);
   

                    Lista.Add(resultado);
                }
              
                return Lista;
            }
            catch (SqlException)
            {
                return Lista;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Insertar Categoria de Inventario
        // Según el tipo de usuario, se podrá insertar diferentes categorias
        public static bool InsertarCategoria(CategoriaInventario Categoria)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("Inventario.sp_InsertarCategoriaInventario");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            //cmd.Parameters.Add(new SqlParameter("@idCategoria", SqlDbType.Int));
            //cmd.Parameters["@idCategoria"].Value = Categoria.idCategoria;

            cmd.Parameters.Add(new SqlParameter("@IdCodigoTipo", SqlDbType.Char, 5));
            cmd.Parameters["@IdCodigoTipo"].Value = Categoria.idCodigoTipo;
            

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters["@Nombre"].Value = Categoria.nombre;

            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 100));
            cmd.Parameters["@Descripcion"].Value = Categoria.descripcion;

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int));
            cmd.Parameters["@IdUsuario"].Value = Categoria.idUsuario;


            // intentamos insertar la nueva categoria
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Actualiza los datos de una categoría 
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns></returns>
        public static bool ActualizarCategoria(CategoriaInventario Categoria)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("Inventario.sp_ActualizarCategoriaInventario");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos
            cmd.Parameters.Add(new SqlParameter("@IdCodigoTipo", SqlDbType.Char, 5));
            cmd.Parameters["@IdCodigoTipo"].Value = Categoria.idCodigoTipo;

            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
            cmd.Parameters["@Nombre"].Value = Categoria.nombre;

            cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar, 100));
            cmd.Parameters["@Descripcion"].Value = Categoria.descripcion;

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int));
            cmd.Parameters["@IdUsuario"].Value = Categoria.idUsuario;

            // intentamos insertar la categoria
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();
                 
                return true;

            }
            catch (SqlException)
            {

                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }

        }

        public static bool EliminarCategoria(CategoriaInventario Categoria)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("Inventario.sp_InhabilitarCategoriaInventario");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos
            cmd.Parameters.Add(new SqlParameter("@IdCodigoTipo", SqlDbType.Char, 5));
            cmd.Parameters["@IdCodigoTipo"].Value = Categoria.idCodigoTipo;

    


            // intentamos insertar al nuevo Paciente
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException)
            {

                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }

        }
    }
}

