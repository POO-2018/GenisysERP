using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace frmLogin.Empleados
{
    public class empleados
    {
        public int id { get; set;}
        public int identidad { get; set;}
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int cargo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public int estado { get; set; }

        /// <summary>
        /// Insertar un nuevo empleado
        /// </summary>
        /// <param name="elEmpleado"></param>
        /// <returns></returns>
        public bool InsertarEmpleado(empleados elEmpleado)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("[Empleados].[sp_InsertarEmpleado]");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@identidad", SqlDbType.Int));
            cmd.Parameters["@identidad"].Value = elEmpleado.identidad;

            cmd.Parameters.Add(new SqlParameter("@nombreUsuario", SqlDbType.VarChar, 50));
            cmd.Parameters["@nombreUsuario"].Value = elEmpleado.nombre;

            cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar, 256));
            cmd.Parameters["@apellido"].Value = elEmpleado.apellido;

            cmd.Parameters.Add(new SqlParameter("@cargo", SqlDbType.Int));
            cmd.Parameters["@cargo"].Value = elEmpleado.cargo;

            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar, 256));
            cmd.Parameters["@telefono"].Value = elEmpleado.telefono;

            cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar, 256));
            cmd.Parameters["@direccion"].Value = elEmpleado.direccion;

            cmd.Parameters.Add(new SqlParameter("@correo", SqlDbType.VarChar, 256));
            cmd.Parameters["@correo"].Value = elEmpleado.correo;

            cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int));
            cmd.Parameters["@estado"].Value = elEmpleado.estado;


            // intentamos insertar al nuevo empleado
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
                return Lista;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
