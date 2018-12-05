using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

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
                nuevo.contrasena = procesarSha256Hash(txtContraseña.Text);
            }
            nuevo.InsertarUsuario(nuevo);
        }

        static string procesarSha256Hash(string laCadena)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(laCadena));

                // Convert byte array to a string   
                StringBuilder constructor = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    constructor.Append(bytes[i].ToString("x2"));
                }
                return constructor.ToString();
            }
        }

        private void frmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            Usuario listar = new Usuario();
            dgvListarUsuarios.DataSource = listar.ListarUsuario();
        }

    }
}
