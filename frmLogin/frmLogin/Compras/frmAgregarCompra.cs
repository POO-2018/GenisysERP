using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin.Compras
{
    public partial class frmAgregarCompra : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private string idUsuario;
        public frmAgregarCompra(string x)
        {
            InitializeComponent();
            idUsuario = x;
            // Implementado temas y colores
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
        }
        ///Variables Globales
        ///
        public int idCategoria;
        public int idProveedor;
        public int id3 = 0;
        public int idProducto1;
        private int idInv = 0;
        public double impuesto;
        public static decimal total1;
        /// <summary>
        /// Metodo para llenar el Combo de Proveedores
        /// </summary>
        private void ListarComboProveedores()
        {
            // Limpiamos los items existentes
            cmbProveedore.Items.Clear();

            // Instanciamos la clase Compra
            Compra proveedores = new Compra();

            // Almacenamos todos los proveedores Existentes
            // y habilitadas en una lista
            List<Compra> listaProveedor = Compra.LeerTodosProveedores();

            // Si hay algún elemento en la lista
            // Lo agregamos al ComboBox
            if (listaProveedor.Any())
            {
                listaProveedor.ForEach(proveedor => cmbProveedore.Items.Add(proveedor.nombreProveedor.ToString()));
            }
            else
            {
                cmbProveedore.Items.Add("No hay Proveedores Disponibles");
            }
        }
        /// <summary>
        /// Metodo paa llenar el combo categoria
        /// </summary>
        private void ListarComboCategoria()
        {
            // Limpiamos los items existentes
            cmbCategoria.Items.Clear();

            // Instanciamos la clase Carreras
            Compra categorias = new Compra();

            // Almacenamos todos los proveedores Existentes
            // y habilitadas en una lista
            List<Compra> listaCategoria = Compra.LeerTodasCategorias();

            // Si hay algún elemento en la lista
            // Lo agregamos al ComboBox
            if (listaCategoria.Any())
            {
                listaCategoria.ForEach(categoria => cmbCategoria.Items.Add(categoria.nombreCategoria.ToString()));
            }
            else
            {
                cmbCategoria.Items.Add("No hay Proveedores Disponibles");
            }
        }

        private void frmAgregarCompra_Load(object sender, EventArgs e)
        {
            ListarComboCategoria();
            ListarComboProveedores();
            foreach (DataGridViewColumn c in dgvDetalleCompra.Columns)
                if (c.Name != "Cantidad") c.ReadOnly = true;
        }
        /// <summary>
        /// Metodo para llenar  el inventario según la categoria o el Proveedor
        /// </summary>
        /// <returns>Retorna todos los datos del inventario al Grid</returns>   
        private void CargarDGWinventario()
        {

            try
            {
                dgvProductos.DataSource = Compra.GetDataViewPorPrevedorCategoria(idProveedor, idCategoria);
                dgvProductos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo para saber cual fue la ultima compra ingresada
        /// </summary>
        public void Detalle()
        {
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");
            string sql = "SELECT MAX(idCompra) FROM Compras.Compra";
            //SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                SqlCommand cmd = conexion.EjecutarComando(sql);

                SqlDataReader rdr = cmd.ExecuteReader();
                //MessageBox.Show(Convert.ToString(rdr[0]));
                while (rdr.Read())
                {
                    idProducto1 = Convert.ToInt16(rdr[0]);
                }
                Producto(idProducto1);
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
        /// <summary>
        /// Metodo que agrega el detalle de la compra uno por uno
        /// </summary>
        /// <param name="id"></param>
        public void Producto(int idingresado)
        {
            if (idingresado != 0)
            {
                for (int i = 0; i < dgvDetalleCompra.Rows.Count; i++)
                {

                    try
                    {
                        // Instanciamos la clase Carreras
                        DetalleCompra Detalle = new DetalleCompra();
                        // Nuestro objeto adquiere los valores del formulario


                        // Verificamos si se realizó el método

                        Detalle.idCompra = idingresado;
                        Detalle.idProducto = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["idProducto"].Value.ToString());
                        Detalle.precioUnitario = Convert.ToDecimal(dgvDetalleCompra.Rows[i].Cells["Precio"].Value.ToString());
                        Detalle.cantidad = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["Cantidad"].Value.ToString());
                        Detalle.subTotal = Convert.ToDecimal(dgvDetalleCompra.Rows[i].Cells["SubTotal"].Value.ToString());


                        if (DetalleCompra.InsertarDetalleCompra(Detalle) == true)
                        {
                            MessageBox.Show("Detalle agregado", "Información");
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

            if (Convert.ToInt16(dgvDetalleCompra.Rows[id].Cells["Cantidad"].Value) == 1 && op <= -1)
            {
                MessageBox.Show("No se puede disminuir más la cantidad");
            }
            else
            {
                if (op!=1 && op!=-1)
                {
                    dgvDetalleCompra.Rows[id].Cells["Cantidad"].Value = 0;
                }
                dgvDetalleCompra.Rows[id].Cells["Cantidad"].Value = Convert.ToInt16(dgvDetalleCompra.Rows[id].Cells["Cantidad"].Value.ToString()) + op;
                decimal cantidad = Convert.ToDecimal(dgvDetalleCompra.Rows[id].Cells["Cantidad"].Value.ToString());
                decimal importe = Convert.ToDecimal(dgvDetalleCompra.Rows[id].Cells["Precio"].Value.ToString());
                dgvDetalleCompra.Rows[id].Cells["SubTotal"].Value = importe * cantidad;
                Total();
            }
        }
        /// <summary>
        /// Funcion que hace el traslado de un grid a otro
        /// </summary>
        public void producto(int id, string nombre, decimal precio, int cantidad, decimal importe,decimal impuesto)
        {
            int igual = 0;
            for (int i = 0; i < dgvDetalleCompra.Rows.Count; i++)
            {
                if (Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["idProducto"].Value) == id)
                {
                    igual = 1;
                    int codigo = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["idProducto"].Value);
                    suma(i, 1);

                }
            }
            if (igual == 0)
            {

                dgvDetalleCompra.Rows.Add(id.ToString(), nombre, precio.ToString(), cantidad.ToString(), importe.ToString(),impuesto.ToString());
                Total();
            }
        }

        /// <summary>
        /// Funcion que hace la suma del importe en el grid de pedido
        /// </summary>
       
        public void Total()
        {
          decimal total = 0;
            for (int i = 0; i < dgvDetalleCompra.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgvDetalleCompra.Rows[i].Cells["SubTotal"].Value);

            }
            txtTotal.Text = Convert.ToString(total);
        }
        /// <summary>
        /// Metodo para sumar la cantidad de una fila seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            suma(id3, 1);
        }
        /// <summary>
        /// Metodo para reducir la cantidad de una fila seleccionada en el grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReducirProducto_Click(object sender, EventArgs e)
        {
            suma(id3, -1);
        }
        /// <summary>
        /// Es para Quitar un detalle de compra del Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
       
        }
        /// <summary>
        /// El metodo del grid de inventario donde seleccionamos los campos que ocupamos para la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                producto(inventario.idInventario, inventario.nombreInventario, inventario.PrecioCompra, cantidad, importe,inventario.impuesto);

            }
        }

        private void cmbProveedore_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.DataSource = Compra.GetDataViewPorPrevedorCategoriaNombre(idProveedor, idCategoria, txtNombre.Text);
            dgvProductos.Columns[0].Visible = false;
        }

        private void dgvDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleCompra != null)
            {
                //DataGridViewRow fila = dgvDetalleCompra.Rows[e.RowIndex];
                id3 = e.RowIndex;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            //compra.numeroFactura = "";
            compra.idProveedor = idProveedor;
            compra.subTotal =Convert.ToDecimal( txtSubTotal.Text);
            compra.impuesto = Convert.ToDecimal(txtImpuesto.Text);
            compra.total = Convert.ToDecimal(txtTotal.Text);
            compra.observaciones = txtObservaciones.Text;
            compra.estadoCompra = txtCotizacion.Text;
            compra.idUsuario = Convert.ToInt32(idUsuario);
           // compra.autorizadaPor =

            if (Compra.InsertarCompra(compra) == true)
            {
                MessageBox.Show("Compra agregada", "Información");
                Detalle();
                //Limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
            }
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
            txtImpuesto.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) * 0.15);
            txtSubTotal.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtImpuesto.Text) );
        }

        private void dgvDetalleCompra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem != null)
            {
                // Creamos un objeto de tipo Compra
                Compra categoria = new Compra();

                // Obtenemos la informacion de las Compra, enviando su nombre
                categoria = Compra.ObtenerInformacionCategoria(cmbCategoria.SelectedItem.ToString());
                idCategoria = categoria.idCategoria;
                CargarDGWinventario();
            }
        }

        private void cmbProveedore_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProveedore.SelectedItem != null)
            {
                // Creamos un objeto de tipo Compra
                Compra proveedor = new Compra();

                // Obtenemos la informacion de las Compra, enviando su nombre
                proveedor = Compra.ObtenerInformacionProveedor(cmbProveedore.SelectedItem.ToString());
                idProveedor = proveedor.idProveedor;
            }
        }

        private void dgvDetalleCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            suma(id3, Convert.ToInt32(dgvDetalleCompra.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString()));
        }
    }
}
