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

        public frmAgregarCompra()
        {
            InitializeComponent();
            // Implementado temas y colores
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
        }

/// <summary>
/// Metodo para llenar el Combo de Proveedores
/// </summary>
        private void ListarComboProveedores()
        {
            // Limpiamos los items existentes
            cmbProveedore.Items.Clear();

            // Instanciamos la clase Carreras
            Compra proveedores = new Compra();

            // Almacenamos todos los proveedores Existentes
            // y habilitadas en una lista
            List<Compra> listaProveedor = Compra.LeerTodosHabilitados();

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
            List<Compra> listaProveedor = Compra.LeerTodosHabilitados();

            // Si hay algún elemento en la lista
            // Lo agregamos al ComboBox
            if (listaProveedor.Any())
            {
                listaProveedor.ForEach(categoria => cmbCategoria.Items.Add(categoria.nombreCategoria.ToString()));
            }
            else
            {
                cmbCategoria.Items.Add("No hay Proveedores Disponibles");
            }
        }

        private void frmAgregarCompra_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn c in dgvDetalleCompra.Columns)
                if (c.Name != "Cantidad") c.ReadOnly = true;
        }
        /// <summary>
        /// Metodo para llenar  el inventario según la categoria o el Proveedor
        /// </summary>
        /// <param name="El Proveedor"></param>
        /// <returns>Retorna todos los datos del inventario al Grid</returns>   
        private void CargarDGWinventario()
        {
            try
            {
                dgvProductos.DataSource = Compra.GetDataViewPorPrevedorCategoria(1,1);
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnReducirProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
