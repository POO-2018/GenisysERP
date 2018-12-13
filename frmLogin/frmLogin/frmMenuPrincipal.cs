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
using frmLogin.Inventario;


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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaInventario abrir = new frmCategoriaInventario();
            abrir.Show();
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
    }
}
