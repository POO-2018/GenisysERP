using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin
{
    public partial class frmCategoriaInventario : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public frmCategoriaInventario()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);

            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        
        }
    }
}
