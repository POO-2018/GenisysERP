using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frmLogin.Empleados
{
    public class Usuario
    {
        public int id { get; set; }
        public int idEmpleado { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }

        /// <summary>
        /// Insertar un nuevo usuario al sistema
        /// </summary>
        /// <param name="elUsuario"></param>
        /// <returns></returns>
        public bool InsertarUsuario(Usuario elUsuario)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("[Empleados].[sp_InsertarUsuario]");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos
            
            cmd.Parameters.Add(new SqlParameter("@idEmpleado", SqlDbType.Int));
            cmd.Parameters["@idEmpleado"].Value = elUsuario.idEmpleado;

            cmd.Parameters.Add(new SqlParameter("@nombreUsuario", SqlDbType.VarChar, 50));
            cmd.Parameters["@nombreUsuario"].Value = elUsuario.nombreUsuario;

            cmd.Parameters.Add(new SqlParameter("@contrasena", SqlDbType.VarChar, 256));
            cmd.Parameters["@contrasena"].Value = elUsuario.contrasena;


            // intentamos insertar al nuevo Usuario
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

        public List<Usuario> ListarUsuario()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            List<Usuario> Lista = new List<Usuario>();

            // Query SQL
            sql = @"Select * From  [Empleados].[Usuario]";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Usuario resultado = new Usuario();
                    resultado.id = rdr.GetInt32(0);
                    resultado.idEmpleado = rdr.GetInt32(1);
                    resultado.nombreUsuario = rdr.GetString(2);
                    resultado.contrasena = "*******";
                    Lista.Add(resultado);
                    // Remover espacios
                }

                return Lista;
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

        public List<Usuario> ListarUsuarioUnico(string nick)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            List<Usuario> Lista = new List<Usuario>();

            // Query SQL
            sql = @"Select * From  [Empleados].[Usuario] WHERE nombreUsuario = @nick";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nick", SqlDbType.VarChar, 50).Value = nick;
                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Usuario resultado = new Usuario();
                    resultado.id = rdr.GetInt32(0);
                    resultado.idEmpleado = rdr.GetInt32(1);
                    resultado.nombreUsuario = rdr.GetString(2);
                    resultado.contrasena = "*******";
                    Lista.Add(resultado);
                    // Remover espacios
                }

                return Lista;
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

        public bool Eliminar(string Nick)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando(@"delete from Empleados.Usuario where nombreUsuario = @nick");



            // agregamos los parámetros que son requeridos
            using (cmd)
            {
                cmd.Parameters.Add("@nick", SqlDbType.VarChar, 50).Value = Nick;
            }
            
            

            // intentamos eliminar la cita
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
    }
}
