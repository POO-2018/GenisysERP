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
using System.Text.RegularExpressions;
using frmLogin;

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
            limpiar();
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
                    string texto = txtNombreEmpresa.Text;
                    frmContacto nuevo = new frmContacto(texto);
                    nuevo.ShowDialog();

                }
                else
                {
                   limpiar();
                }
                limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un problema en la inserción de los datos");
            }
        }

        private void txtNombreEmpresa_Leave(object sender, EventArgs e)
        {
            Clientes.Proveedor nuevoProveedor = Clientes.Proveedor.ObtenerProveedor(txtNombreEmpresa.Text);
            txtDireccion.Text = nuevoProveedor.direccion;
            mskTelefono.Text = nuevoProveedor.telefono;
            txtCorreo.Text = nuevoProveedor.correo;

            if (txtDireccion.Text != "")
            {
                btnAgregar.Visible = false;
                btnActualizar.Visible = true;
                btnHa_In.Visible = true;
            }
            else
            {
                btnActualizar.Visible = false;
                btnHa_In.Visible = false;
                btnAgregar.Visible = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiar();
        }

        private void btnHa_In_Click(object sender, EventArgs e)
        {
            //instanciamos de la clase proveedor
            Clientes.Proveedor nuevoProveedor = new Clientes.Proveedor();
            nuevoProveedor.nombreEmpresa = txtNombreEmpresa.Text;

            if (Clientes.Proveedor.Inhabilitar_Habilitar_Proveedor(nuevoProveedor))
            {
                MessageBox.Show(nuevoProveedor.m);
                limpiar();
            }
            else
            {
                MessageBox.Show("ha ocurrido un  error en la actualización", "Control de proveedores", MessageBoxButtons.OK);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            lstHabilitado.Visible = true;
            lstInhabilitado.Visible = false;
        }

        private void btnInhabilitado_Click(object sender, EventArgs e)
        {
            lstHabilitado.Visible = false;
            lstInhabilitado.Visible = true;
        }

        private void lstInhabilitado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstHabilitado_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstHabilitado.SelectedItem.ToString() == "No hay registros habilitados")
                {
                    btnActualizar.Visible = false;
                    btnHa_In.Visible = false;
                    btnAgregar.Visible = true;
                }
                else
                {
                    btnActualizar.Visible = true;
                    btnHa_In.Visible = true;
                    btnAgregar.Visible = false;
                    Clientes.Proveedor elproveedor = new Clientes.Proveedor();
                    elproveedor = Clientes.Proveedor.ObtenerProveedor2(lstHabilitado.SelectedItem.ToString());

                    txtNombreEmpresa.Text = elproveedor.nombreEmpresa;
                    txtDireccion.Text = elproveedor.direccion;
                    txtCorreo.Text = elproveedor.correo;
                    mskTelefono.Text = elproveedor.telefono;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Acción a realizar es invalida");
            }
        }


        public void datosH()
        {
            // cargamos los datos al listbox
            Clientes.Proveedor nuevo = new Clientes.Proveedor();

            // Creamos la lista
            List<Clientes.Proveedor> lista = Clientes.Proveedor.ListarProveedorTodosH();

            // Limpiar el listBox
            lstHabilitado.Items.Clear();

            if (lista.Any())
            {
                lista.ForEach(Proveedor => lstHabilitado.Items.Add(Proveedor.nombreEmpresa.ToString()));
            }
            else
            {
                lstHabilitado.Items.Add("No hay registros habilitados");
            }
        }

        public void datosI()
        {
            // cargamos los datos al listbox
            Clientes.Proveedor nuevo = new Clientes.Proveedor();

            // Creamos la lista
            List<Clientes.Proveedor> lista = Clientes.Proveedor.ListarProveedorTodosI();

            // Limpiar el listBox
            lstInhabilitado.Items.Clear();

            if (lista.Any())
            {
                lista.ForEach(Proveedor => lstInhabilitado.Items.Add(Proveedor.nombreEmpresa.ToString()));
            }
            else
            {
                lstInhabilitado.Items.Add("No hay registros inhabilitados");
            }
        }

        private void lstInhabilitado_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstInhabilitado.SelectedItem.ToString() == "No hay registros inhabilitados")
                {
                    btnActualizar.Visible = false;
                    btnHa_In.Visible = false;
                    btnAgregar.Visible = true;
                }
                else
                {
                    btnActualizar.Visible = true;
                    btnHa_In.Visible = true;
                    btnAgregar.Visible = false;
                    Clientes.Proveedor elproveedor = new Clientes.Proveedor();
                    elproveedor = Clientes.Proveedor.ObtenerProveedor2(lstInhabilitado.SelectedItem.ToString());

                    txtNombreEmpresa.Text = elproveedor.nombreEmpresa;
                    txtDireccion.Text = elproveedor.direccion;
                    txtCorreo.Text = elproveedor.correo;
                    mskTelefono.Text = elproveedor.telefono;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Acción a realizar es invalida");
            }
        }

        public void limpiar()
        {
            //limpiando métodos
            datosH();
            datosI();

            //limpiando objetos
            txtNombreEmpresa.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            mskTelefono.Text = "";

            //reestableciendo los valores por defecto
            btnAgregar.Visible = true;
            btnActualizar.Visible = false;
            btnHa_In.Visible = false;
            lstHabilitado.Visible = false;
            lstInhabilitado.Visible = false;

            //reestableciendo valor de focus
            //txtNombreEmpresa.Focus();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //instanciamos de la clase cliente
            Clientes.Proveedor nuevoProveedor = new Clientes.Proveedor();
            nuevoProveedor.nombreEmpresa = txtNombreEmpresa.Text;
            nuevoProveedor.direccion = txtDireccion.Text;
            nuevoProveedor.telefono = mskTelefono.Text;
            nuevoProveedor.correo = txtCorreo.Text;

            if (Clientes.Proveedor.ActualizarProveedor(nuevoProveedor))
            {
                MessageBox.Show("Se ha actualizado el registro", "Control de proveedores", MessageBoxButtons.OK);
                limpiar();
            }
            else
            {
                MessageBox.Show("ha ocurrido un  error en la actualización", "Control de proveedores", MessageBoxButtons.OK);
            }
        }

        public static bool email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (email_bien_escrito(txtCorreo.Text))
            {

            }
            else
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido con el siguiente formato: nombre@dominio.com," +
                   "Intente nuevamente con un registro válido", "Control de correo electrónico", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtCorreo.SelectAll();
                txtCorreo.Focus();
            }
        }

        private void txtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // para solo ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //nos permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Sólo se admiten letras", "Validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
