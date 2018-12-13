using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace frmLogin.Empleados
{
    class Encriptacion
    {

        public string laCadena { get; set; }

        static string procesarSha256Hash(Encriptacion cadena)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(cadena.laCadena));

                // Convert byte array to a string   
                StringBuilder constructor = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    constructor.Append(bytes[i].ToString("x2"));
                }
                return constructor.ToString();
            }
        }
    }
}
