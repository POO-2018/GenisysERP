using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos los namespace necesario
using System.Data;
using System.Data.SqlClient;

namespace frmLogin.Compras
{
    class Compra
    {
        // Propiedades
        public int idCompra { get; set; }
        public DateTime fechaCompra { get; set; }
        public string numeroFactura { get; set; }
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public decimal subTotal { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public string observaciones { get; set; }
        public string estadoCompra { get; set; }
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string autorizadaPor { get; set; }
        public int estado { get; set; }
    }
}
