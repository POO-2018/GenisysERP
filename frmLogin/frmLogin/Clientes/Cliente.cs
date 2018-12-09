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

    }
}
