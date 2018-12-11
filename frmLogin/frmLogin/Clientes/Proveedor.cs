using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using frmLogin.Clientes;

namespace frmLogin.Clientes
{
    class Proveedor
    {
        public string m;

        // Propiedades
        public int idProveedor { get; set; }
        public string nombreEmpresa { get; set; }

        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int estado { get; set; }

        // Métodos
        /// <summary>
        /// Obtiene un proveedor desde la tabla Clientes.Proveedor
        /// </summary>
        /// <param name="nombre">La identidad </param>
        /// <returns>Un objeto de tipo Cliente.</returns>
        public static Proveedor ObtenerProveedor(string nombreEmpresa)
        {
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS", "GenisysERP");
            string sql;
            Proveedor resultado = new Proveedor();

            // Query SQL
            sql = @"SELECT *
                    FROM Clientes.Proveedor
                    WHERE nombreEmpresa = @nombreEmpresa";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombreEmpresa", SqlDbType.NVarChar, 100).Value = nombreEmpresa;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.nombreEmpresa = Convert.ToString(rdr[1]);
                    resultado.direccion = rdr.GetString(2);
                    resultado.telefono = rdr.GetString(3);
                    resultado.correo = rdr.GetString(4);
                    resultado.estado = Convert.ToInt32(rdr[5]);
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


        /// <summary>
        /// Método para la inserción de datos
        /// </summary>
        public static bool AgregarProveedor(Proveedor nuevoProveedor)
        {
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS", "GenisysERP");
            SqlCommand cmd = conexion.EjecutarComando("sp_AgregarProveedor");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;


            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@nombreEmpresa", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombreEmpresa"].Value = nuevoProveedor.nombreEmpresa;
            cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 2000));
            cmd.Parameters["@direccion"].Value = nuevoProveedor.direccion;
            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Char, 9));
            cmd.Parameters["@telefono"].Value = nuevoProveedor.telefono;
            cmd.Parameters.Add(new SqlParameter("@correo", SqlDbType.NVarChar, 100));
            cmd.Parameters["@correo"].Value = nuevoProveedor.correo;

            // intentamos ejecutar el procedimiento
            try
            {
                conexion.EstablecerConexion();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                // MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Errors[0].ToString());
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        public static bool ActualizarProveedor(Proveedor elProveedor)
        {
            // estabecer conexion
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS", "GenisysERP");

            //define el comando
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarProveedor");

            //definir tipo comando
            cmd.CommandType = CommandType.StoredProcedure;

            // agregar los parametros necesarios

            cmd.Parameters.Add(new SqlParameter("@idProveedor", SqlDbType.Int));
            cmd.Parameters["@idProveedor"].Value = elProveedor.idProveedor;

            cmd.Parameters.Add(new SqlParameter("@nombreEmpresa", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombreEmpresa"].Value = elProveedor.nombreEmpresa;
            cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 2000));
            cmd.Parameters["@direccion"].Value = elProveedor.direccion;
            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Char, 9));
            cmd.Parameters["@telefono"].Value = elProveedor.telefono;
            cmd.Parameters.Add(new SqlParameter("@correo", SqlDbType.NVarChar, 100));
            cmd.Parameters["@correo"].Value = elProveedor.correo;

            Proveedor verifica = new Proveedor();
            verifica = Proveedor.ObtenerProveedor(elProveedor.nombreEmpresa);


            try
            {
                if (verifica.nombreEmpresa == "")
                {
                    MessageBox.Show("El proveedor no existe, revise");
                    return false;
                }
                else
                {
                    conexion.EstablecerConexion();
                    cmd.ExecuteNonQuery();
                    return true;
                }

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

        public static bool Inhabilitar_Habilitar_Proveedor(Proveedor elProveedor)
        {
            // estabecer conexion
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS", "GenisysERP");

            //define el comando
            SqlCommand cmd = conexion.EjecutarComando("sp_Habilitar_Inhabilitar_Proveedor");

            //definir tipo comando
            cmd.CommandType = CommandType.StoredProcedure;

            // agregar los parametros necesarios
            cmd.Parameters.Add(new SqlParameter("@nombreEmpresa", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombreEmpresa"].Value = elProveedor.nombreEmpresa;

            cmd.Parameters.Add("@msj", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;



            // verificamos si el proveedor ya tiene un registro
            Proveedor verifica = new Proveedor();
            verifica = Proveedor.ObtenerProveedor(elProveedor.nombreEmpresa);


            try
            {
                if (verifica.nombreEmpresa == "")
                {
                    MessageBox.Show("El proveedor no existe, revise");
                    return false;
                }
                else
                {

                    conexion.EstablecerConexion();
                    cmd.ExecuteNonQuery();
                    elProveedor.m = cmd.Parameters["@msj"].Value.ToString();
                    return true;
                }

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

        public static List<Proveedor> ListarProveedorTodosH()
        {
            // declarmos la lista de tipo proveedor
            List<Proveedor> losproveedores = new List<Proveedor>();

            // Establecemos la conexión
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS", "GenisysERP");

            // especificamos el query de consulta.
            string sql = "SELECT * FROM Clientes.Proveedor WHERE estado = 1";

            //Especificamos el comando y el tipo de comando
            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // establecemos la conexión
                conexion.EstablecerConexion();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Proveedor elproveedor = new Proveedor();
                    elproveedor.idProveedor = Convert.ToInt16(rdr[0]);
                    elproveedor.nombreEmpresa = rdr.GetString(1);
                    elproveedor.direccion = rdr.GetString(2);
                    elproveedor.telefono = rdr.GetString(3);
                    elproveedor.correo = rdr.GetString(4);
                    elproveedor.estado = Convert.ToInt16(rdr[5]);

                    // agregamos los datos a la lista
                    losproveedores.Add(elproveedor);
                }
                return losproveedores;

            }
            catch (Exception)
            {

                return losproveedores;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public static List<Proveedor> ListarProveedorTodosI()
        {

            List<Proveedor> losProveedores = new List<Proveedor>();

            // Establecemos la conexión
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS", "GenisysERP");

            // especificamos el query de consulta.
            string sql = "SELECT * FROM Clientes.Proveedor WHERE estado = 0";

            //Especificamos el comando y el tipo de comando
            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // establecemos la conexión
                conexion.EstablecerConexion();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Proveedor elproveedor = new Proveedor();
                    elproveedor.idProveedor = Convert.ToInt16(rdr[0]);
                    elproveedor.nombreEmpresa = rdr.GetString(1);
                    elproveedor.direccion = rdr.GetString(2);
                    elproveedor.telefono = rdr.GetString(3);
                    elproveedor.correo = rdr.GetString(4);
                    elproveedor.estado = Convert.ToInt16(rdr[5]);

                    // agregamos los datos a la lista
                    losProveedores.Add(elproveedor);
                }
                return losProveedores;

            }
            catch (Exception)
            {

                return losProveedores;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public static Proveedor ObtenerProveedor2(string nombreEmpresa)
        {
            // Establecemos la conexión
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS", "GenisysERP");

            string sql;
            Proveedor resultado = new Proveedor();

            // Query SQL
            sql = @"SELECT *
                    FROM Clientes.Proveedor
                    WHERE nombreEmpresa = @nombreEmpresa";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombreEmpresa", SqlDbType.NVarChar, 100).Value = nombreEmpresa;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.idProveedor = Convert.ToInt16(rdr[0]);
                    resultado.nombreEmpresa = rdr.GetString(1);
                    resultado.direccion = rdr.GetString(2);
                    resultado.telefono = rdr.GetString(3);
                    resultado.correo = rdr.GetString(4);
                    resultado.estado = Convert.ToInt16(rdr[5]);
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
    }
}

