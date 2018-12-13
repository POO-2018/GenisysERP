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

namespace frmLogin.Compras
{
    public partial class frmMenuActualizar : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private string idUsuario;
        public frmMenuActualizar(string x)
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

        
        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            frmActualizarEstadoCompra actualizarEstado = new frmActualizarEstadoCompra();
            actualizarEstado.ShowDialog();
        }

        
        private void btnActualizarCompra_Click(object sender, EventArgs e)
        {
            frmActualizarCompra actualizarCompra = new frmActualizarCompra(idUsuario);
            actualizarCompra.ShowDialog();
        }
    }
}
