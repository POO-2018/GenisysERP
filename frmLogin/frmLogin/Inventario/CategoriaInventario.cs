﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Métodos para la clase

        public static CategoriaInventario ObtenerCategoria(string idCategoria)
        {

            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisyERP");
            string sql;
            CategoriaInventario resultado = new CategoriaInventario();

            // Query SQL
            sql = @"SELECT *
                   FROM [Inventario].[Categoria]
                    WHERE idCategoria = @idCategoria";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.idCategoria = rdr.GetInt32(0);
                    resultado.idCodigoTipo = rdr.GetString(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.descripcion = rdr.GetString(3);
                    resultado.idCategoria = rdr.GetInt32(4);
                }

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

        // Listar las categorías de Inventario existentes 
        public List<CategoriaInventario> ListarCategorias()
        {
            Conexion conexion = new Conexion();
            string sql;
            List<CategoriaInventario> Lista = new List<CategoriaInventario>();

            // Query SQL
            sql = @"select  idCategoria, idCodigoTipo, nombre, descripcion, idUsuario FROM Inventario.Categoria Order by idCategoria";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CategoriaInventario resultado = new CategoriaInventario();
                    resultado.idCategoria = rdr.GetInt32(0);
                    resultado.idCodigoTipo = rdr.GetString(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.descripcion = rdr.GetString(3);
                    resultado.idCategoria = rdr.GetInt32(4);
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
        public bool InsertarCategoria(CategoriaInventario Categoria)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("Inventario.sp_InsertarCategoriaInventario");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            //cmd.Parameters.Add(new SqlParameter("@idCategoria", SqlDbType.Int));
            //cmd.Parameters["@idCategoria"].Value = Categoria.idCategoria;

            cmd.Parameters.Add(new SqlParameter("@idCodigoTipo", SqlDbType.Int));
            cmd.Parameters["@idCodigoTipo"].Value = Categoria.idCodigoTipo;

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 50));
            cmd.Parameters["@nombre"].Value = Categoria.nombre;

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar, 10));
            cmd.Parameters["@descripcion"].Value = Categoria.descripcion;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = Categoria.idUsuario;


            // intentamos insertar la nueva categoria
            try
            {

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
            cmd.Parameters.Add(new SqlParameter("@idCodigoTipo", SqlDbType.Char, 5));
            cmd.Parameters["@idCodigoTipo"].Value = Categoria.idCodigoTipo;

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 100));
            cmd.Parameters["@nombre"].Value = Categoria.nombre;

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar, 100));
            cmd.Parameters["@descripcion"].Value = Categoria.descripcion;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = Categoria.idUsuario;

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
            SqlCommand cmd = conn.EjecutarComando("Inventario.sp_EliminarCategoriaInevtario");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos
            cmd.Parameters.Add(new SqlParameter("@idCodigoTipo", SqlDbType.Char, 5));
            cmd.Parameters["@idCodigoTipo"].Value = Categoria.idCodigoTipo;

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 100));
            cmd.Parameters["@nombre"].Value = Categoria.nombre;

            //cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar, 10));
            //cmd.Parameters["@descripcion"].Value = Categoria.descripcion;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = Categoria.idUsuario;


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
