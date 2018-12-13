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

// namespaces adicionales
using frmLogin.Empleados;


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
            frmMantenimientoUsuarios vista = new frmMantenimientoUsuarios();
            vista.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados.frmEmpleados vista = new frmEmpleados();
            vista.ShowDialog();
        }
    }
}
