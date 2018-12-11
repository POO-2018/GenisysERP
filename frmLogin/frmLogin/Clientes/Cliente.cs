using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace frmLogin.Clientes
{
    class Cliente
    {
        public int id { get; set; }
        public string identidad { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int estado { get; set; }
        public int usuario { get; set; }
        public string m { get; set; }

        public static Cliente ObtenerCliente(string identidad)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ERP");
            string sql;
            Cliente resultado = new Cliente();

            // Query SQL
            sql = @"SELECT *
                    FROM Clientes.Cliente
                    WHERE identidad = @identidad";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@identidad", SqlDbType.Char, 15).Value = identidad;
                    rdr = cmd.ExecuteReader();
                }
                while (rdr.Read())
                {
                    resultado.id = Convert.ToInt32(rdr[0]);
                    resultado.identidad = rdr.GetString(1);
                    resultado.nombres = rdr.GetString(2);
                    resultado.apellidos = rdr.GetString(3);
                    resultado.direccion = rdr.GetString(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.correo = rdr.GetString(6);
                    resultado.estado = Convert.ToInt32(rdr[7]);
                    resultado.usuario = Convert.ToInt32(rdr[8]);
                }
                return resultado;
            }
            catch (SqlException ex)
            {
                return resultado;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        public static Cliente ObtenerCliente2(string nombress)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "ERP");
            string sql;
            Cliente resultado = new Cliente();

            // Query SQL
            sql = @"SELECT *
                    FROM Clientes.Cliente
                    WHERE nombres = @nombre";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = nombress;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = Convert.ToInt16(rdr[0]);
                    resultado.identidad = rdr.GetString(1);
                    resultado.nombres = rdr.GetString(2);
                    resultado.apellidos = rdr.GetString(3);
                    resultado.direccion = rdr.GetString(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.correo = rdr.GetString(6);
                    resultado.estado = Convert.ToInt16(rdr[7]);
                    resultado.usuario = Convert.ToInt32(rdr[8]);
                }

                return resultado;
            }
            catch (SqlException ex)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public static List<Cliente> ListarClienteTodosH()
        {
            // declarmos la lista de tipo cliente
            List<Cliente> losClientes = new List<Cliente>();

            // Establecemos la conexión
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ERP");

            // especificamos el query de consulta.
            string sql = "SELECT * FROM Clientes.Cliente WHERE estado = 1";

            //Especificamos el comando y el tipo de comando
            SqlCommand cmd = conn.EjecutarComando(sql);

            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Cliente elCliente = new Cliente();
                    elCliente.id = Convert.ToInt16(rdr[0]);
                    elCliente.identidad = rdr.GetString(1);
                    elCliente.nombres = rdr.GetString(2);
                    elCliente.apellidos = rdr.GetString(3);
                    elCliente.direccion = rdr.GetString(4);
                    elCliente.telefono = rdr.GetString(5);
                    elCliente.correo = rdr.GetString(6);
                    elCliente.estado = Convert.ToInt16(rdr[7]);

                    // agregamos los datos a la lista
                    losClientes.Add(elCliente);
                }
                return losClientes;

            }
            catch (Exception)
            {

                return losClientes;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        public static List<Cliente> ListarClienteTodosI()
        {
            // declarmos la lista de tipo cliente
            List<Cliente> losClientes = new List<Cliente>();

            // Establecemos la conexión
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ERP");

            // especificamos el query de consulta.
            string sql = "SELECT * FROM Clientes.Cliente WHERE estado = 0";

            //Especificamos el comando y el tipo de comando
            SqlCommand cmd = conn.EjecutarComando(sql);

            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Cliente elCliente = new Cliente();
                    elCliente.id = Convert.ToInt16(rdr[0]);
                    elCliente.identidad = rdr.GetString(1);
                    elCliente.nombres = rdr.GetString(2);
                    elCliente.apellidos = rdr.GetString(3);
                    elCliente.direccion = rdr.GetString(4);
                    elCliente.telefono = rdr.GetString(5);
                    elCliente.correo = rdr.GetString(6);
                    elCliente.estado = Convert.ToInt16(rdr[7]);

                    // agregamos los datos a la lista
                    losClientes.Add(elCliente);
                }
                return losClientes;

            }
            catch (Exception)
            {

                return losClientes;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        public static bool AgregarCliente(Cliente nuevoCliente)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "ERP");
            SqlCommand cmd = conn.EjecutarComando("sp_AgregarCliente");

            // Establecer el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Definir los parámetros necesarios
            cmd.Parameters.Add(new SqlParameter("@identidad", SqlDbType.Char, 15));
            cmd.Parameters["@identidad"].Value = nuevoCliente.identidad;
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombre"].Value = nuevoCliente.nombres;
            cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar, 100));
            cmd.Parameters["@apellido"].Value = nuevoCliente.apellidos;
            cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 2000));
            cmd.Parameters["@direccion"].Value = nuevoCliente.direccion;
            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Char, 9));
            cmd.Parameters["@telefono"].Value = nuevoCliente.telefono;
            cmd.Parameters.Add(new SqlParameter("@correo", SqlDbType.NVarChar, 100));
            cmd.Parameters["@correo"].Value = nuevoCliente.correo;
            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = nuevoCliente.usuario;
            try
            {
                // Se establece la conexión con la base de datos
                conn.EstablecerConexion();
                // Se ejecuta el comando
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
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
