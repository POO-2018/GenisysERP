using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmLogin.Inventario;
using frmLogin.Compras;
// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

// namespaces adicionales
using frmLogin.Empleados;



namespace frmLogin
{
    public partial class frmMenuPrincipal : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        protected string idUsuario;
        public frmMenuPrincipal(string x)
        {
            InitializeComponent();
            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
            idUsuario = x;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            frmMantenimientoUsuarios vista = new frmMantenimientoUsuarios();
            vista.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados.frmEmpleados vista = new frmEmpleados();
            vista.ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            frmAgregarCompra agregarCompra = new frmAgregarCompra("1");
            agregarCompra.ShowDialog();
        }

        private void btnActualizarCompra_Click(object sender, EventArgs e)
        {
            frmMenuActualizar menuActualizar = new frmMenuActualizar("1");
            menuActualizar.ShowDialog();
        }

        private void btnBusquedaCompra_Click(object sender, EventArgs e)
        {
            frmBuscarCompras buscarCompras = new frmBuscarCompras(0);
            buscarCompras.ShowDialog();
        }

        private void btnInhabilitarCompra_Click(object sender, EventArgs e)
        {
            frmInhabilitarCompra inhabilitarCompra = new frmInhabilitarCompra();
            inhabilitarCompra.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaInventario nuevo = new frmCategoriaInventario();
            nuevo.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmProducto nuevo = new frmProducto("1");
            nuevo.ShowDialog();
        }

        private void btnImpuestos_Click(object sender, EventArgs e)
        {
            frmImpuestoProducto nuevo = new frmImpuestoProducto();
            nuevo.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente vista = new frmCliente();
            vista.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedor vista = new frmProveedor();
            vista.ShowDialog();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            frmContacto vista = new frmContacto();
            vista.ShowDialog();
        }
    }
}
