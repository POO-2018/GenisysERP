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
        protected int nivelAcceso;
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
            Empleados.Usuario nivelacc = new Usuario();
            nivelAcceso =  nivelacc.nivelAcceso(idUsuario);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            if (nivelAcceso == 3)
            {
                frmMantenimientoUsuarios vista = new frmMantenimientoUsuarios();
                vista.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuentas con los suficientes permisos!", "Restriccion de seguridad");
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (nivelAcceso == 3)
            {
                Empleados.frmEmpleados vista = new frmEmpleados();
                vista.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuentas con los suficientes permisos!", "Restriccion de seguridad");
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            if (nivelAcceso == 3)
            {
                frmAgregarCompra agregarCompra = new frmAgregarCompra(idUsuario);
                agregarCompra.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuentas con los suficientes permisos!", "Restriccion de seguridad");
            }
            
        }

        private void btnActualizarCompra_Click(object sender, EventArgs e)
        {
            if (nivelAcceso >= 2)
            {
                frmMenuActualizar menuActualizar = new frmMenuActualizar(idUsuario);
                menuActualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuentas con los suficientes permisos!", "Restriccion de seguridad");
            }
        }

        private void btnBusquedaCompra_Click(object sender, EventArgs e)
        {
            frmBuscarCompras buscarCompras = new frmBuscarCompras(0);
            buscarCompras.ShowDialog();
        }

        private void btnInhabilitarCompra_Click(object sender, EventArgs e)
        {
            if (nivelAcceso == 3)
            {
                frmInhabilitarCompra inhabilitarCompra = new frmInhabilitarCompra();
                inhabilitarCompra.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuentas con los suficientes permisos!", "Restriccion de seguridad");
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaInventario nuevo = new frmCategoriaInventario();
            nuevo.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmProducto nuevo = new frmProducto(idUsuario);
            nuevo.ShowDialog();
        }

        private void btnImpuestos_Click(object sender, EventArgs e)
        {
            if (nivelAcceso == 3)
            {
                frmImpuestoProducto nuevo = new frmImpuestoProducto();
                nuevo.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuentas con los suficientes permisos!", "Restriccion de seguridad");
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente vista = new frmCliente(idUsuario);
            vista.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (nivelAcceso == 3)
            {
                frmProveedor vista = new frmProveedor();
                vista.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuentas con los suficientes permisos!", "Restriccion de seguridad");
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            if (nivelAcceso >= 2)
            {
                frmContacto vista = new frmContacto(idUsuario);
                vista.ShowDialog();
            }
            else
            {
                MessageBox.Show("No cuentas con los suficientes permisos!", "Restriccion de seguridad");
            }
        }

        private void Acercade_Click(object sender, EventArgs e)
        {
            frmAcercaDe vista = new frmAcercaDe();
            vista.ShowDialog();
        }
    }
}
