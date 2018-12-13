using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace frmLogin.Empleados
{
    public partial class frmCambiarContrasena : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public frmCambiarContrasena()
        {
            InitializeComponent();

            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);

            txtUsuario.Text = frmMantenimientoUsuarios.x;
        }

        private void btnConfirmarCambioContrasena_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion(@"(local)\chrisfiallos", "GenisysERP");
            //Empleados.Encriptacion encriptacion = new Empleados.Encriptacion();
            Empleados.Usuario usuario = new Empleados.Usuario();
            string sql = @"SELECT contrasena FROM Empleados.Usuario WHERE nombreUsuario = @Usuario";
            SqlCommand cmd = conexion.EjecutarComando(sql);
            string laEncriptacion;
            string segundaEncriptacion;
            string otraEncriptacion;
            laEncriptacion = Empleados.Encriptacion.procesarSha256Hash(txtContrasenaActual.Text);
            segundaEncriptacion = Empleados.Encriptacion.procesarSha256Hash(txtNuevaContraseña.Text);
            otraEncriptacion = Empleados.Encriptacion.procesarSha256Hash(txtConfirmarNuevaContraseña.Text);

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
                    if (segundaEncriptacion == otraEncriptacion)
                    {
                        MessageBox.Show("Contraseña actualizada", "Confirmacion");
                        this.Close();
                    }
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
    }
}
