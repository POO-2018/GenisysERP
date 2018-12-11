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
using frmLogin.Clientes;

namespace frmLogin
{
    public partial class frmContacto : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public frmContacto()
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

        private void lstHabilitado_Click(object sender, EventArgs e)
        {

        }

        private void lstInhabilitado_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            cmbProveedor.Items.Clear();
            mskIdentidad.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            mskTelefono.Text = "";
            txtCorreo.Text = "";
            txtCargo.Text = "";
            btnAgregar.Visible = true;
            btnActualizar.Visible = false;
            btnInhabilitarHabilitar.Visible = false;
            btnRegresar.Visible = true;
            btnHabilitados.Visible = true;
            btnInhabilitados.Visible = true;
            lstHabilitado.Visible = false;
            lstInhabilitado.Visible = false;
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
