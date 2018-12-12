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
using System.Data.SqlClient;
// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;


namespace frmLogin.Empleados
{
    public partial class frmMantenimientoUsuarios : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public string x;
        public string id;
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

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM Empleados.Empleado WHERE estado = 1";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbEmpleado.Items.Add(rdr["nombre"].ToString());

                };

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            // se obtiene el id del combobox cmbEmpleado.Text;
            nuevo.idEmpleado = Convert.ToInt32(id);
            nuevo.nombreUsuario = txtNombreUsuario.Text;
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                nuevo.contrasena = procesarSha256Hash(txtContraseña.Text);
                if (nuevo.InsertarUsuario(nuevo))
                {
                    MessageBox.Show("Exito!");
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                
            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden!");
            }
            
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario listarUnico = new Usuario();
            dgvListarUsuarios.DataSource = listarUnico.ListarUsuarioUnico(txtNombreUsuarioBuscar.Text);
        }

        private void dgvListarUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            x = dgvListarUsuarios.CurrentRow.Cells["nombreUsuario"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario eliminar = new Usuario();
            if (eliminar.Eliminar(x))
            {
                MessageBox.Show("Exito!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void cmbEmpleado_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM Empleados.Empleado WHERE estado = 1";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id = rdr["id"].ToString();

                };

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
}
