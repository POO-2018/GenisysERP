﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace frmLogin
{
    class Conexion
    {
        // Propiedades
        private string servidor;
        private string baseDatos;
        public SqlConnection conn;
        public SqlCommand cmd;

        // Constructores
        public Conexion() { }
        public Conexion(string elServidor, string laBaseDatos)
        {
            servidor = elServidor;
            baseDatos = laBaseDatos;
            EstablecerConexion();
        }
        // Métodos

        /// <summary>
        /// Intenta realizar la conexión con la base de datos especificada.
        /// necesita el servidor, la instancia y el nombre de la base de datos.
        /// </summary>
        public void EstablecerConexion()
        {
            try
            {
                conn = new SqlConnection(@"server = " + servidor + ";" +
                    "integrated security = true; database = " + baseDatos + ";");

                // Establecer conexión
                conn.Open();
            }
            catch (Exception)
            {
                throw new CustomException("¡Servidor o base de datos no encontrados!");

            }
        }

        /// <summary>
        /// Ejecuta un comando SQL.
        /// </summary>
        /// <param name="elComando">El query SQL a ejecutar</param>
        public SqlCommand EjecutarComando(string elComando)
        {
            return cmd = new SqlCommand(elComando, conn);
        }

        /// <summary>
        /// Cierra la conexión al servidor SQL.
        /// </summary>
        public void CerrarConexion()
        {
            conn.Close();
        }
    }
}
