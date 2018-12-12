using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos los namespaces necesarios
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frmLogin.Clientes
{
    class Contacto
    {
        Conexion cn = new Conexion();

        public DataTable CargarCombo()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress",
            "GenisysERP");
            SqlDataAdapter da = new
            SqlDataAdapter("sp_CargarProveedores", conexion.conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }


        public string m;

        //Propiedades
        public string idContacto { get; set; }
        public string idProveedor { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string cargo { get; set; }
        public int estado { get; set; } 
        public string nombreProveedor { get; set; }
        /// <summary>
        /// Obtiene un cliente desde la tabla Clientes.Contacto
        /// </summary>
        /// <param name="idContacto"></param>
        /// <returns>Un objeto de tipo Contacto</returns>
        public static Contacto ObtenerContacto(string idContacto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress",
            "GenisysERP");
            string sql;
            Contacto resultado = new Contacto();

            //Query SQL
            sql = @"SELECT *
                    FROM Clientes.Contacto
                    WHERE idContacto = @idContacto";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@idContacto", SqlDbType.Char, 15).Value
                    = idContacto;

                    rdr = cmd.ExecuteReader();
                }
                while (rdr.Read())
                {
                    resultado.idProveedor = rdr.GetString(0);
                    resultado.idContacto = rdr.GetString(1);
                    resultado.nombres = rdr.GetString(2);
                    resultado.apellidos = rdr.GetString(3);
                    resultado.direccion = rdr.GetString(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.correo = rdr.GetString(6);
                    resultado.cargo = rdr.GetString(7);
                    resultado.estado = Convert.ToInt16(rdr[8]);
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

        public static bool AgregarContacto(Contacto nuevoContacto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress",
            "GenisysERP");
            SqlCommand cmd = conexion.EjecutarComando("sp_AgregarContacto");

            //Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;


            // Parámetros del stored procedure
            cmd.Parameters.Add(new SqlParameter("@idContacto", SqlDbType.Char, 15));
            cmd.Parameters["@idContacto"].Value = nuevoContacto.idContacto;
            cmd.Parameters.Add(new SqlParameter("@idProveedor", SqlDbType.VarChar, 100));
            cmd.Parameters["@idProveedor"].Value = nuevoContacto.idProveedor;
            cmd.Parameters.Add(new SqlParameter("@nombres", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombres"].Value = nuevoContacto.nombres;
            cmd.Parameters.Add(new SqlParameter("@apellidos", SqlDbType.NVarChar, 100));
            cmd.Parameters["@apellidos"].Value = nuevoContacto.apellidos;
            cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 2000));
            cmd.Parameters["@direccion"].Value = nuevoContacto.direccion;
            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Char, 9));
            cmd.Parameters["@telefono"].Value = nuevoContacto.telefono;
            cmd.Parameters.Add(new SqlParameter("@correo", SqlDbType.NVarChar, 100));
            cmd.Parameters["@correo"].Value = nuevoContacto.correo;
            cmd.Parameters.Add(new SqlParameter("@cargo", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cargo"].Value = nuevoContacto.correo;

            // Intentamos ejecutar el procedimiento
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

        public static bool ActualizarContacto(Contacto elContacto)
        {
            // estabecer conexion
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            //define el comando
            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarContacto");

            //definir tipo comando
            cmd.CommandType = CommandType.StoredProcedure;

            // agregar los parametros necesarios

            cmd.Parameters.Add(new SqlParameter("@idContacto", SqlDbType.Char, 15));
            cmd.Parameters["@idContacto"].Value = elContacto.idContacto;
            cmd.Parameters.Add(new SqlParameter("@nombres", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombres"].Value = elContacto.nombres;
            cmd.Parameters.Add(new SqlParameter("@apellidos", SqlDbType.NVarChar, 100));
            cmd.Parameters["@apellidos"].Value = elContacto.apellidos;
            cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 2000));
            cmd.Parameters["@direccion"].Value = elContacto.direccion;
            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Char, 9));
            cmd.Parameters["@telefono"].Value = elContacto.telefono;
            cmd.Parameters.Add(new SqlParameter("@correo", SqlDbType.NVarChar, 100));
            cmd.Parameters["@correo"].Value = elContacto.correo;
            cmd.Parameters.Add(new SqlParameter("@cargo", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cargo"].Value = elContacto.cargo;

            // verificamos si el cliente yatiene un registro
            Contacto verifica = new Contacto();
            verifica = Contacto.ObtenerContacto(elContacto.idContacto);


            try
            {
                if (verifica.idContacto == "")
                {
                    MessageBox.Show("El contacto no existe, revise");
                    return false;
                }
                else
                {
                    conn.EstablecerConexion();
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
                conn.CerrarConexion();
            }
        }


        public static List<Contacto> ListarContactoTodosH()
        {
            // declaramos la lista de tipo cliente
            List<Contacto> losContactos = new List<Contacto>();

            //Establecemos la conexión
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // Especificamos el query de consulta
            string sql = "SELECT * FROM Clientes.Contacto WHERE estado = 1";

            //Especificamos el comando y el tipo de comando
            SqlCommand cmd = conn.EjecutarComando(sql);

            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Contacto elContacto = new Contacto();
                    elContacto.idProveedor = rdr.GetString(0);
                    elContacto.idContacto = rdr.GetString(1);
                    elContacto.nombres = rdr.GetString(2);
                    elContacto.apellidos = rdr.GetString(3);
                    elContacto.direccion = rdr.GetString(4);
                    elContacto.telefono = rdr.GetString(5);
                    elContacto.correo = rdr.GetString(6);
                    elContacto.cargo = rdr.GetString(7);
                    elContacto.estado = Convert.ToInt16(rdr[8]);

                    // Agregamos los datos a la lista
                    losContactos.Add(elContacto);

                }
                return losContactos;

            }
            catch (Exception)
            {
                return losContactos;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
        public static List<Contacto> ListarContactoTodosI()
        {
            // Declaramos la lista de tipo cliente
            List<Contacto> losContactos = new List<Contacto>();

            //Establecemos la conexión
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            // Especificamos el query de consulta
            string sql = "SELECT * FROM Clientes.Contacto WHERE estado = 0";

            // Especificamos el comando y el tipo de comando
            SqlCommand cmd = conn.EjecutarComando(sql);

            try
            {
                // Establecemos la conexión
                conn.EstablecerConexion();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Contacto elContacto = new Contacto();
                    elContacto.idProveedor = rdr.GetString(0);
                    elContacto.idContacto = rdr.GetString(1);
                    elContacto.nombres = rdr.GetString(2);
                    elContacto.apellidos = rdr.GetString(3);
                    elContacto.direccion = rdr.GetString(4);
                    elContacto.telefono = rdr.GetString(5);
                    elContacto.correo = rdr.GetString(6);
                    elContacto.cargo = rdr.GetString(7);
                    elContacto.estado = Convert.ToInt16(rdr[8]);

                    // Agregamos los datos a la lista
                    losContactos.Add(elContacto);
                }
                return losContactos;

            }
            catch(Exception)
            {
                return losContactos;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
        
        public static Contacto ObtenerContacto2(string nombress)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            Contacto resultado = new Contacto();

            // Query SQL
            sql = @"SELECT Contacto.idContacto, Proveedor.nombreEmpresa, Contacto.nombres, Contacto.apellidos, Contacto.direccion, Contacto.telefono, Contacto.correo, Contacto.cargo
FROM Clientes.Proveedor INNER JOIN Clientes.Contacto ON Proveedor.idProveedor = Contacto.idProveedor WHERE Clientes.Contacto.nombres = @nombres;";
            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombres", SqlDbType.NVarChar, 
                    100).Value = nombress;

                    rdr = cmd.ExecuteReader();
                }
                while (rdr.Read())
                {
                    resultado.idContacto = rdr.GetString(0);
                    resultado.nombreProveedor = rdr.GetString(1);
                    resultado.nombres = rdr.GetString(2);
                    resultado.apellidos = rdr.GetString(3);
                    resultado.direccion = rdr.GetString(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.correo = rdr.GetString(6);
                    resultado.cargo = rdr.GetString(7);
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

        public static Contacto ObtenerContacto3(string idContacto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress",
            "GenisysERP");
            string sql;
            Contacto resultado = new Contacto();

            //Query SQL
            sql = @"SELECT Clientes.Contacto.nombres, Clientes.Contacto.apellidos, Clientes.Contacto.direccion, Clientes.Contacto.telefono, Clientes.Contacto.correo, Clientes.Contacto.cargo, Clientes.Proveedor.nombreEmpresa
FROM Clientes.Proveedor INNER JOIN Clientes.Contacto ON Proveedor.idProveedor = Contacto.idProveedor WHERE Clientes.Contacto.idContacto = @idContacto;";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@idContacto", SqlDbType.Char, 15).Value
                    = idContacto;

                    rdr = cmd.ExecuteReader();
                }
                while (rdr.Read())
                {
                    resultado.nombres = rdr.GetString(0);
                    resultado.apellidos = rdr.GetString(1);
                    resultado.direccion = rdr.GetString(2);
                    resultado.telefono = rdr.GetString(3);
                    resultado.correo = rdr.GetString(4);
                    resultado.cargo = rdr.GetString(5);
                    resultado.nombreProveedor = rdr.GetString(6);
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
    }
}
