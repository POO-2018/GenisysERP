using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;


namespace frmLogin
{
    public partial class frmLogin : MaterialForm
    {

        private MaterialSkinManager materialSkinManager;
        public frmLogin()
        {
            InitializeComponent();
            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
            txtContraseña.Text = "";
            txtContraseña.PasswordChar = '*';
        }

        private void cambiarFuente()
        {
            //lblErrorUsuarioContrasena.BackColor = Color.WhiteSmoke;
            lblErrorUsuarioContrasena.ForeColor = Color.Gold;
            lblErrorUsuarioContrasena.Font = new Font("Roboto", 8, FontStyle.Regular);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion(@"(local)\chrisfiallos", "GenisysERP");
            //Empleados.Encriptacion encriptacion = new Empleados.Encriptacion();
            Empleados.Usuario usuario = new Empleados.Usuario();
            string sql = @"SELECT contrasena FROM Empleados.Usuario WHERE nombreUsuario = @Usuario";
            SqlCommand cmd = conexion.EjecutarComando(sql);
            string laEncriptacion;
            laEncriptacion = Empleados.Encriptacion.procesarSha256Hash(txtContraseña.Text);

            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = txtUsuario.Text;
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    usuario.contrasena = rdr.GetString(0);

                    // Remover espacios
                }

                if (laEncriptacion == usuario.contrasena)
                {
                    //Cambiar al formulario de Menu Principal
                    Empleados.frmMantenimientoUsuarios mu = new Empleados.frmMantenimientoUsuarios();
                    mu.Show();
                }
                else
                {
                    cambiarFuente();
                    lblErrorUsuarioContrasena.Text = "El nombre de usuario o la contrasena no son correctos!";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
