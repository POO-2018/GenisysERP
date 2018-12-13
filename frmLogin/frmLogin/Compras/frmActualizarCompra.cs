using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace frmLogin.Compras
{
    public partial class frmActualizarCompra : MaterialForm
    {

        private MaterialSkinManager materialSkinManager;
        private string idUsuario;
        public frmActualizarCompra(string x)
        {
            idUsuario = x;
            InitializeComponent();
            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
        }
        //Variables globales 
        public static int idC;
        //public static decimal TotalC;
        //public static decimal ImpuestoC;
        //public static decimal SubC;
        public static string Proveedores;
        public int id3 = 0;
        public int idProducto1;
        private int idInv = 0;

        public int idDetalle;
        public int idProduc;
        public string nombre;
        public decimal precio;
        public int cantidad;
        public decimal subtotal;


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCompras frmBuscar = new frmBuscarCompras(1);
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                idC = frmBuscar.idCompraBusqueda;
                txtTotal.Text =Convert.ToString( frmBuscar.total);
                txtImpuesto.Text = Convert.ToString(frmBuscar.impuesto);
                txtSubTotal.Text = Convert.ToString(frmBuscar.subTotal);
                txtObservaciones.Text = Convert.ToString(frmBuscar.observaciones);
                Proveedores = frmBuscar.Proveedor;
                dgvProductos.DataSource = Compra.GetDataViewProductosPorProveedor(Proveedores);
                dgvProductos.Columns[0].Visible = false;

                CargarDetalle();
            }
        }

        private void frmActualizarCompra_Load(object sender, EventArgs e)
        {
           
            dgvDetalleCompra.Columns[0].Visible = false;
            dgvDetalleCompra.Columns[1].Visible = false;
            dgvDetalleCompra.Columns[2].Visible = false;
        }

        public void CargarDetalle()
        {
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");
            string sql = " SELECT		Compras.DetalleCompra.idDetalle	," +
                                    "Compras.DetalleCompra.idProducto,"+
                                    "Inventario.Producto.nombre , " +
                                    "Compras.DetalleCompra.precioUnitario," +
                                    "Compras.DetalleCompra.cantidad," +
                                    "Compras.DetalleCompra.subTotal FROM Compras.DetalleCompra" +
                                    " INNER JOIN Inventario.Producto " +
                                    " ON Inventario.Producto.idInventario = Compras.DetalleCompra.idProducto" +
                                    "   WHERE Compras.DetalleCompra.idCompra = " +idC+";";
            //SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                SqlCommand cmd = conexion.EjecutarComando(sql);

                SqlDataReader rdr = cmd.ExecuteReader();
                //MessageBox.Show(Convert.ToString(rdr[0]));
                while (rdr.Read())
                {
                    idDetalle = Convert.ToInt16(rdr[0]);
                    idProduc = Convert.ToInt16(rdr[1]);
                   nombre= rdr.GetString(2);
                   precio = Convert.ToDecimal(rdr[3]);
                    cantidad = Convert.ToInt32(rdr[4]);
                    subtotal = Convert.ToDecimal(rdr[5]);
                    Producto(idDetalle, idProduc, idProduc, nombre, precio, cantidad, subtotal);
                }
                foreach (DataGridViewColumn c in dgvDetalleCompra.Columns)
                    if (c.Name != "CantidadI") c.ReadOnly = true;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        public void Producto(int idDetalle,int idCompra,int producto,string nombre,decimal precio,int cantidad,decimal total)
        {
            dgvDetalleCompra.Rows.Add(idDetalle.ToString(), idCompra.ToString(), producto.ToString(), nombre, precio.ToString(), cantidad.ToString(),total.ToString());
        }

        private void dgvDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleCompra != null)
            {
                //DataGridViewRow fila = dgvDetalleCompra.Rows[e.RowIndex];
                id3 = e.RowIndex;
            }
        }

        /// <summary>
        /// Metodo que agrega el detalle de la compra uno por uno
        /// </summary>
        /// <param name="id"></param>
        public void DetalleProducto()
        {
           
             for (int i = 0; i < dgvDetalleCompra.Rows.Count; i++)
             {
                    if (dgvDetalleCompra.Rows[i].Cells["Detalle"].Value.ToString() == "")
                    {
                        try
                        {
                            // Instanciamos la clase Carreras
                            DetalleCompra Detalle = new DetalleCompra();
                            // Nuestro objeto adquiere los valores del formulario
                            // Verificamos si se realizó el método

                             Detalle.idCompra = idC;
                             Detalle.idProducto = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["Inventario"].Value.ToString());
                             Detalle.precioUnitario = Convert.ToDecimal(dgvDetalleCompra.Rows[i].Cells["PrecioU"].Value.ToString());
                             Detalle.cantidad = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["CantidadI"].Value.ToString());
                             Detalle.subTotal = Convert.ToDecimal(dgvDetalleCompra.Rows[i].Cells["Total"].Value.ToString());


                            if (DetalleCompra.InsertarDetalleCompra(Detalle) == true)
                            {
                            //MessageBox.Show("Detalle agregado", "Información");
                            //Limpiar();
                            }
                            else
                            {
                            MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                            }

                        // MessageBox.Show("Agregado");
                        }
                        catch (Exception ex)
                        {

                        throw ex;
                        }
                    }
                    else
                    {
                    try
                    {
                        // Instanciamos la clase DetalleCompra
                        DetalleCompra Detalle = new DetalleCompra();
                        // Nuestro objeto adquiere los valores del formulario
                        // Verificamos si se realizó el método

                        Detalle.idDetalle = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["Detalle"].Value.ToString());
                        Detalle.cantidad = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["CantidadI"].Value.ToString());
                        Detalle.subTotal = Convert.ToDecimal(dgvDetalleCompra.Rows[i].Cells["Total"].Value.ToString());


                        if (DetalleCompra.ActualizarDetalleCompra(Detalle) == true)
                        {
                            //MessageBox.Show("Detalle agregado", "Información");
                            //Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                        }

                        // MessageBox.Show("Agregado");
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
             }
        }
        /// <summary>
        /// Funcion que suma el importe en el grid de detalle Compra
        /// </summary>
        /// <param name="id"></param>
        /// <param name="op"></param>
        public void suma(int id, int op)
        {

            if (Convert.ToInt16(dgvDetalleCompra.Rows[id].Cells["CantidadI"].Value) == 1 && op <= -1)
            {
                MessageBox.Show("No se puede disminuir más la cantidad");
            }
            else
            {
                if (op != 1 && op != -1)
                {
                    dgvDetalleCompra.Rows[id].Cells["CantidadI"].Value = 0;
                }
                dgvDetalleCompra.Rows[id].Cells["CantidadI"].Value = Convert.ToInt16(dgvDetalleCompra.Rows[id].Cells["CantidadI"].Value.ToString()) + op;
                decimal cantidad = Convert.ToDecimal(dgvDetalleCompra.Rows[id].Cells["CantidadI"].Value.ToString());
                decimal importe = Convert.ToDecimal(dgvDetalleCompra.Rows[id].Cells["PrecioU"].Value.ToString());
                dgvDetalleCompra.Rows[id].Cells["Total"].Value = importe * cantidad;
                Total1();
            }
        }
        /// <summary>
        /// Funcion que hace el traslado de un grid a otro
        /// </summary>
        public void producto(int id, string nombre, decimal precio, int cantidad, decimal importe, decimal impuesto)
        {
            int igual = 0;
            for (int i = 0; i < dgvDetalleCompra.Rows.Count; i++)
            {
                if (Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["Inventario"].Value) == id)
                {
                    igual = 1;
                    int codigo = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["Inventario"].Value);
                    suma(i, 1);

                }
            }
            if (igual == 0)
            {

                dgvDetalleCompra.Rows.Add("","",id.ToString(), nombre, precio.ToString(), cantidad.ToString(), importe.ToString(), impuesto.ToString());
                Total1();
            }
        }

        /// <summary>
        /// Funcion que hace la suma del importe en el grid de pedido
        /// </summary>

        public void Total1()
        {
            decimal total = 0;
            for (int i = 0; i < dgvDetalleCompra.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgvDetalleCompra.Rows[i].Cells["Total"].Value);

            }
            txtTotal.Text = Convert.ToString(total);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int cantidad = 1;
                Compra inventario = new Compra();
                inventario = Compra.ObtenerInformacionInventario(Convert.ToInt32(
                        dgvProductos.Rows[e.RowIndex].Cells["Id"].Value.ToString()
                        ));
                dgvProductos.Select();
                this.idInv = inventario.idInventario;
                decimal importe = inventario.PrecioCompra * cantidad;
                producto(inventario.idInventario, inventario.nombreInventario, inventario.PrecioCompra, cantidad, importe, inventario.impuesto);

            }
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtImpuesto.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) * 0.15);
            txtSubTotal.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtImpuesto.Text));
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            suma(id3, -1);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            suma(id3, 1);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de quitar el Producto " , " Eliminar Detalle de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    if (dgvDetalleCompra != null)
                    {
                        dgvDetalleCompra.Rows.RemoveAt(id3);
                        DetalleCompra compra = new DetalleCompra();
                        //compra.numeroFactura = "";
                        compra.idDetalle = id3;
                        if (DetalleCompra.EliminarDetalleCompra(compra) == true)
                        {
                            MessageBox.Show("Detalle Eliminado", "Información");
                            
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                        }
                        Total1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede disminuir más la cantidad");
                    throw ex;
                }
            }
        }

        private void dgvDetalleCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            suma(id3, Convert.ToInt32(dgvDetalleCompra.Rows[e.RowIndex].Cells["CantidadI"].Value.ToString()));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            //compra.numeroFactura = "";
            compra.idCompra = idC;
            compra.subTotal = Convert.ToDecimal(txtSubTotal.Text);
            compra.impuesto = Convert.ToDecimal(txtImpuesto.Text);
            compra.total = Convert.ToDecimal(txtTotal.Text);
            compra.observaciones = txtObservaciones.Text;
            compra.idUsuario = Convert.ToInt32(idUsuario);

            if (Compra.ActualizarCompra(compra) == true)
            {
                MessageBox.Show("Compra agregada", "Información");
                DetalleProducto();
                //Limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
            }
        }
    }
}
