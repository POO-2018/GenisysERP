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


namespace frmLogin.Empleados
{
    public partial class frmMantenimientoUsuarios : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public frmMantenimientoUsuarios()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            // se obtiene el id del combobox cmbEmpleado.Text;
            nuevo.idEmpleado = 1;
            nuevo.nombreUsuario = txtNombreUsuario.Text;
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                nuevo.contrasena = txtContraseña.Text;
            }
            nuevo.InsertarUsuario(nuevo);
        }

        private void frmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            Usuario listar = new Usuario();
            dgvListarUsuarios.DataSource = listar.ListarUsuario();
        }
    }
}
