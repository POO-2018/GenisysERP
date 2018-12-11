using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

// Namespace para la conexion a SQL 
using System.Data;
using System.Data.SqlClient;

namespace frmLogin.Inventario
{
    class Impuesto
    {
        // Propiedades 
        // nota se ordenaron de la manera que aparecerán el el dgvImpuesto
        public string descripcion { get; set; }
        public decimal valor { get; set; }
        public string observacion { get; set; }
        public string idCodigoImpuesto { get; set; }
        public int idImpuesto { get; set; }       
        public DateTime fechaCreacion { get; set; }
        public int idUsuario { get; set; }
        public int estado { get; set; }

        // Constructor

        public Impuesto() { }



        /// <summary>
        /// Metodo para insertar un impuesto
        /// </summary>
        /// <param name="impuesto"></param>
        /// <returns></returns>
        public static bool InsertarImpuesto(Impuesto impuesto)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            SqlCommand cmd = conn.EjecutarComando("sp_InsertarImpuesto");
            cmd.CommandType = CommandType.StoredProcedure;



            // Parametros
            cmd.Parameters.Add(new SqlParameter("@idCodigoImpuesto", SqlDbType.Char, 5));
            cmd.Parameters["@idCodigoImpuesto"].Value = impuesto.idCodigoImpuesto;

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = impuesto.descripcion;

            cmd.Parameters.Add(new SqlParameter("@valor", SqlDbType.Decimal));
            cmd.Parameters["@valor"].Value = impuesto.valor;

            cmd.Parameters.Add(new SqlParameter("@fechaCreacion", SqlDbType.DateTime));
            cmd.Parameters["@fechaCreacion"].Value = impuesto.fechaCreacion;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = impuesto.idUsuario;

            cmd.Parameters.Add(new SqlParameter("@observacion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@observacion"].Value = impuesto.observacion;

            cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit));
            cmd.Parameters["@estado"].Value = impuesto.estado;

            try
            {
                conn.EstablecerConexion();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }


        /// <summary>
        /// Metodo para actulizar un immpuesto
        /// </summary>
        /// <param name="impuesto"></param>
        /// <returns></returns>
        public static bool ActualizarImpuesto(Impuesto impuesto)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarImpuesto");
            cmd.CommandType = CommandType.StoredProcedure;



            // Parametros

            cmd.Parameters.Add(new SqlParameter("@idImpuesto", SqlDbType.Int));
            cmd.Parameters["@idImpuesto"].Value = impuesto.idImpuesto;

            cmd.Parameters.Add(new SqlParameter("@idCodigoImpuesto", SqlDbType.Char, 5));
            cmd.Parameters["@idCodigoImpuesto"].Value = impuesto.idCodigoImpuesto;

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = impuesto.descripcion;

            cmd.Parameters.Add(new SqlParameter("@valor", SqlDbType.Decimal));
            cmd.Parameters["@valor"].Value = impuesto.valor;

            cmd.Parameters.Add(new SqlParameter("@fechaCreacion", SqlDbType.DateTime));
            cmd.Parameters["@fechaCreacion"].Value = impuesto.fechaCreacion;

            cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            cmd.Parameters["@idUsuario"].Value = impuesto.idUsuario;

            cmd.Parameters.Add(new SqlParameter("@observacion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@observacion"].Value = impuesto.observacion;

            cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit));
            cmd.Parameters["@estado"].Value = impuesto.estado;

            try
            {
                conn.EstablecerConexion();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Metodo para eliminar un impuesto
        /// </summary>
        /// <param name="impuesto"></param>
        /// <returns></returns>
        public static bool EliminarImpuesto(Impuesto impuesto)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");

            SqlCommand cmd = conn.EjecutarComando("sp_EliminarImpuesto");
            cmd.CommandType = CommandType.StoredProcedure;



            // Parametros

            cmd.Parameters.Add(new SqlParameter("@idImpuesto", SqlDbType.Int));
            cmd.Parameters["idImpuesto"].Value = impuesto.idImpuesto;

            try
            {
                conn.EstablecerConexion();

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

        /// <summary>
        /// Metodo para buscar un impuesto en la base de datos
        /// </summary>
        /// <param name="CodigoImpuesto"></param>
        /// <returns></returns>

        public static Impuesto BuscarImpuesto(string CodigoImpuesto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            Impuesto resultado = new Impuesto();

            sql = @"SELECT *FROM Inventario.Impuesto WHERE idCodigoImpuesto = @CodigoImpuesto";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@CodigoImpuesto", SqlDbType.Char, 5).Value = CodigoImpuesto;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.idImpuesto = rdr.GetInt32(0);
                    resultado.idCodigoImpuesto = rdr.GetString(1);
                    resultado.descripcion = rdr.GetString(2);
                    resultado.valor = rdr.GetDecimal(3);
                    resultado.fechaCreacion = rdr.GetDateTime(4);
                    resultado.idUsuario = rdr.GetInt32(5);
                    resultado.observacion = rdr.GetString(6);
                    resultado.estado = Convert.ToInt16(rdr.GetBoolean(7));




                    // Remover espacios
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

        public static List<Impuesto> LeerTodos()
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            List<Impuesto> Lista = new List<Impuesto>();

            sql = @"SELECT * FROM Inventario.Impuesto WHERE estado=1;";
            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;
            try
            {

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Impuesto resultado = new Impuesto();
                    resultado.idImpuesto = rdr.GetInt32(0);
                    resultado.idCodigoImpuesto = rdr.GetString(1);
                    resultado.descripcion = rdr.GetString(2);
                    resultado.valor = rdr.GetDecimal(3);
                    resultado.fechaCreacion = rdr.GetDateTime(4);
                    resultado.idUsuario = rdr.GetInt32(5);
                    resultado.observacion = rdr.GetString(6);
                    resultado.estado = Convert.ToInt16( rdr.GetBoolean(7));
                    Lista.Add(resultado);
                }

                //Retornamos los datos obtenidos
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

    }
}
