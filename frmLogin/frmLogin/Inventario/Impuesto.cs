using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace para la conexion a SQL 
using System.Data;
using System.Data.SqlClient;

namespace frmLogin.Inventario
{
    class Impuesto
    {
        // Propiedades 
        public int idImpuesto { get; set; }
        public string idCodigoImpuesto { get; set; }
        public string descripcion { get; set; }
        public decimal valor { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idUsuario { get; set; }
        public string observacion { get; set; }
        public int estado { get; set; }

        // Constructor

        public Impuesto() { }



        /// <summary>
        /// Metodo para insertar un imouesto
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
            cmd.Parameters["idCodigoImpuesto"].Value = impuesto.idCodigoImpuesto;

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["descripcion"].Value = impuesto.descripcion;

            cmd.Parameters.Add(new SqlParameter("@valor", SqlDbType.Decimal));
            cmd.Parameters["valor"].Value = impuesto.valor;

            cmd.Parameters.Add(new SqlParameter("@fechaCreacion", SqlDbType.DateTime));
            cmd.Parameters["fechaCreacion"].Value = impuesto.fechaCreacion;

            cmd.Parameters.Add(new SqlParameter("@idUsario", SqlDbType.Int));
            cmd.Parameters["idUsuario"].Value = impuesto.idUsuario;

            cmd.Parameters.Add(new SqlParameter("@observacion", SqlDbType.NVarChar, 100));
            cmd.Parameters["observacion"].Value = impuesto.observacion;

            cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit));
            cmd.Parameters["estado"].Value = impuesto.estado;

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
            cmd.Parameters["idImpuesto"].Value = impuesto.idImpuesto;

            cmd.Parameters.Add(new SqlParameter("@idCodigoImpuesto", SqlDbType.Char, 5));
            cmd.Parameters["idCodigoImpuesto"].Value = impuesto.idCodigoImpuesto;

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["descripcion"].Value = impuesto.descripcion;

            cmd.Parameters.Add(new SqlParameter("@valor", SqlDbType.Decimal));
            cmd.Parameters["valor"].Value = impuesto.valor;

            cmd.Parameters.Add(new SqlParameter("@fechaCreacion", SqlDbType.DateTime));
            cmd.Parameters["fechaCreacion"].Value = impuesto.fechaCreacion;

            cmd.Parameters.Add(new SqlParameter("@idUsario", SqlDbType.Int));
            cmd.Parameters["idUsuario"].Value = impuesto.idUsuario;

            cmd.Parameters.Add(new SqlParameter("@observacion", SqlDbType.NVarChar, 100));
            cmd.Parameters["observacion"].Value = impuesto.observacion;

            cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit));
            cmd.Parameters["estado"].Value = impuesto.estado;

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

        public static bool InhabilitarImpuesto(Impuesto impuesto)
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
        /// 
        /// </summary>
        /// <param name="CodigoImpuesto"></param>
        /// <returns></returns>

        public static Impuesto BuscarImpuesto(string CodigoImpuesto)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            Impuesto resultado = new Impuesto();

            // Query SQL
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
                    resultado.idImpuesto = rdr.GetInt16(0);
                    resultado.idCodigoImpuesto = rdr.GetString(1);
                    resultado.descripcion = rdr.GetString(2);
                    resultado.valor = rdr.GetDecimal(3);
                    resultado.fechaCreacion = rdr.GetDateTime(4);
                    resultado.idUsuario = rdr.GetInt16(5);
                    resultado.observacion = rdr.GetString(6);
                    resultado.estado = rdr.GetByte(7);




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

    }
}
