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
    public class empleados
    {
        public int id { get; set;}
        public string identidad { get; set;}
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

            cmd.Parameters.Add(new SqlParameter("@identidad", SqlDbType.VarChar));
            cmd.Parameters["@identidad"].Value = elEmpleado.identidad;

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 50));
            cmd.Parameters["@nombre"].Value = elEmpleado.nombre;

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
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        public bool ActualizarEmpleado(empleados elEmpleado)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("[Empleados].[sp_ActualizarEmpleado]");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = elEmpleado.id;

            cmd.Parameters.Add(new SqlParameter("@identidad", SqlDbType.VarChar));
            cmd.Parameters["@identidad"].Value = elEmpleado.identidad;

            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 50));
            cmd.Parameters["@nombre"].Value = elEmpleado.nombre;

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
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        public bool InhabilitarEmpleado(string elEmpleado)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("Update Empleados.Empleado SET estado = 0 WHERE id = @id");

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = elEmpleado;

            // intentamos insertar al nuevo empleado
            try
            {

                // ejecutamos el comando
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
                conn.CerrarConexion();
            }
        }

        public bool habilitarEmpleado(string elEmpleado)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("Update Empleados.Empleado SET estado = 1 WHERE id = @id");
            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = elEmpleado;

            // intentamos insertar al nuevo empleado
            try
            {

                // ejecutamos el comando
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
                conn.CerrarConexion();
            }
        }

        public List<empleados> ListarEmpleados()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            List<empleados> Lista = new List<empleados>();

            // Query SQL
            sql = @"Select * From Empleados.Empleado";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    empleados resultado = new empleados();
                    resultado.id = rdr.GetInt32(0);
                    resultado.identidad = rdr.GetString(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.apellido = rdr.GetString(3);
                    resultado.cargo = rdr.GetInt32(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.direccion = rdr.GetString(6);
                    resultado.correo = rdr.GetString(7);
                    resultado.estado = Convert.ToInt32(rdr.GetValue(8));
                    Lista.Add(resultado);

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

        public List<empleados> ListarEmpleadosUnico(string nomb)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            List<empleados> Lista = new List<empleados>();

            // Query SQL
            sql = @"Select * From Empleados.Empleado WHERE nombre = @nomb";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nomb", SqlDbType.VarChar).Value = nomb;
                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    empleados resultado = new empleados();
                    resultado.id = rdr.GetInt32(0);
                    resultado.identidad = rdr.GetString(1);
                    resultado.nombre = rdr.GetString(2);
                    resultado.apellido = rdr.GetString(3);
                    resultado.cargo = rdr.GetInt32(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.direccion = rdr.GetString(6);
                    resultado.correo = rdr.GetString(7);
                    resultado.estado = Convert.ToInt32(rdr.GetValue(8));
                    Lista.Add(resultado);

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
    }
}
