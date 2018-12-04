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
    class DetalleCompra
    {
        // Propiedades

        public int idDetalle { get; set; }
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public decimal precioUnitario { get; set; }
        public int cantidad { get; set; }
        public decimal subTotal { get; set; }



    }
}
