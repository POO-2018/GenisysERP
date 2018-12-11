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

namespace frmLogin.Inventario
{
    public partial class frmProducto : MaterialForm
    {
        public string idUsuario;
        private MaterialSkinManager materialSkinManager;
        public frmProducto(string x)
        {
            InitializeComponent();
            idUsuario = x;
            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
        }

        private void materialSingleLineTextField10_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
