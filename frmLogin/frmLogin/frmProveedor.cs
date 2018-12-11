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

namespace frmLogin
{
    public partial class frmProveedor : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public frmProveedor()
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

        private void frmProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Instancia de la Clase Cliente
            Clientes.Proveedor nuevoProveedor = new Clientes.Proveedor();
            nuevoProveedor.nombreEmpresa = txtNombreEmpresa.Text;
            nuevoProveedor.direccion = txtDireccion.Text;
            nuevoProveedor.telefono = mskTelefono.Text;
            nuevoProveedor.correo = txtCorreo.Text;


            if (Clientes.Proveedor.AgregarProveedor(nuevoProveedor))
            {
                MessageBox.Show("Se han agregado los datos con éxito");
                DialogResult res = MessageBox.Show("¿Desea registar contacto para este Proveedor?", "Control de proveedores", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    //Contacto nuevo = new Contacto();
                    //nuevo.ShowDialog();

                }
                else
                {
                    //Limpiar();
                }
                //limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un problema en la inserción de los datos");
            }
        }
    }
}
