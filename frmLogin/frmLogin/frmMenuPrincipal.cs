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

using frmLogin.Compras;


namespace frmLogin
{
    public partial class frmMenuPrincipal : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {

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
    }
}
