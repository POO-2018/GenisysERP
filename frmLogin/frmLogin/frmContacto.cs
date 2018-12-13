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
using System.Text.RegularExpressions;

namespace frmLogin
{
    public partial class frmContacto : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public frmContacto(string text)
        {
            InitializeComponent();
            cmbProveedor.Text = text;
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
            try
            {
                if (lstHabilitado.SelectedItem.ToString() == "No hay registros")
                {
                    btnActualizar.Visible = false;
                    btnInhabilitarHabilitar.Visible = false;
                    btnAgregar.Visible = true;
                }
                else
                {
                    btnActualizar.Visible = true;
                    btnInhabilitarHabilitar.Visible = true;
                    btnAgregar.Visible = false;
                    Contacto elContacto = new Contacto();
                    elContacto = Contacto.ObtenerContacto2(lstHabilitado.SelectedItem.ToString());
                    mskIdentidad.Text = elContacto.idContacto;
                    txtNombres.Text = elContacto.nombres;
                    txtApellidos.Text = elContacto.apellidos;
                    txtDireccion.Text = elContacto.direccion;
                    mskTelefono.Text = elContacto.telefono;
                    txtCorreo.Text = elContacto.correo;
                    txtCargo.Text = elContacto.cargo;
                    cmbProveedor.Text = elContacto.idProveedor;
                    cmbProveedor.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Acción invalida");
            }
            
        }

        private void lstInhabilitado_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstInhabilitado.SelectedItem.ToString() == "No hay registros")
                {
                    btnActualizar.Visible = false;
                    btnInhabilitarHabilitar.Visible = false;
                    btnAgregar.Visible = true;
                }
                else
                {
                    btnActualizar.Visible = true;
                    btnInhabilitarHabilitar.Visible = true;
                    btnAgregar.Visible = false;
                    Contacto elContacto = new Contacto();
                    elContacto = Contacto.ObtenerContacto2(lstInhabilitado.SelectedItem.ToString());
                    mskIdentidad.Text = elContacto.idContacto;
                    txtNombres.Text = elContacto.nombres;
                    txtApellidos.Text = elContacto.apellidos;
                    txtDireccion.Text = elContacto.direccion;
                    mskTelefono.Text = elContacto.telefono;
                    txtCorreo.Text = elContacto.correo;
                    txtCargo.Text = elContacto.cargo;
                    cmbProveedor.Text = elContacto.idProveedor;
                    cmbProveedor.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Acción invalida");
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            datosH();
            datosI();
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
            cmbProveedor.Enabled = true;
        }

        Clientes.Contacto cargar = new Clientes.Contacto();

        private void frmContacto_Load(object sender, EventArgs e)
        {
            limpiar();
            if (cmbProveedor.Text != "")
            {
                //cmbIdProveedor.Enabled = true;
            }
            else
            {
                cmbProveedor.DataSource = cargar.CargarCombo();
                cmbProveedor.DisplayMember = "nombreEmpresa";
                cmbProveedor.ValueMember = "idProveedor";
                cmbProveedor.SelectedIndex = -1;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contacto nContacto = new Contacto();
            nContacto.idContacto = mskIdentidad.Text;
            nContacto.idProveedor = cmbProveedor.Text;
            nContacto.nombres = txtNombres.Text;
            nContacto.apellidos = txtApellidos.Text;
            nContacto.direccion = txtDireccion.Text;
            nContacto.telefono = mskTelefono.Text;
            nContacto.correo = txtCorreo.Text;
            nContacto.cargo = txtCargo.Text;
            if (Contacto.AgregarContacto(nContacto))
            {
                MessageBox.Show("Dato ingresado correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error en la inserción");
                limpiar();
            }
        }

        private void btnHabilitados_Click(object sender, EventArgs e)
        {
            lstHabilitado.Visible = true;
            lstInhabilitado.Visible = false;
        }

        private void btnInhabilitados_Click(object sender, EventArgs e)
        {
            lstHabilitado.Visible = false;
            lstInhabilitado.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Contacto eContacto = new Contacto();
            eContacto.idContacto = mskIdentidad.Text;
            eContacto.nombres = txtNombres.Text;
            eContacto.apellidos = txtApellidos.Text;
            eContacto.direccion = txtDireccion.Text;
            eContacto.telefono = mskTelefono.Text;
            eContacto.correo = txtCorreo.Text;
            eContacto.cargo = txtCargo.Text;
            if (Contacto.ActualizarContacto(eContacto))
            {
                MessageBox.Show("Se han actualizado los datos");
                limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la actualización");
                limpiar();
            }
        }

        private void mskIdentidad_Leave(object sender, EventArgs e)
        {
            Contacto eContacto = Contacto.ObtenerContacto3(mskIdentidad.Text);
            txtNombres.Text = eContacto.nombres;
            txtApellidos.Text = eContacto.apellidos;
            txtDireccion.Text = eContacto.direccion;
            mskTelefono.Text = eContacto.telefono;
            txtCorreo.Text = eContacto.correo;
            txtCargo.Text = eContacto.cargo;
            cmbProveedor.Text = eContacto.nombreProveedor;
            if (txtNombres.Text != "")
            {
                btnAgregar.Visible = false;
                btnActualizar.Visible = true;
                btnInhabilitarHabilitar.Visible = true;
                cmbProveedor.Enabled = false;
            }
            else
            {
                btnAgregar.Visible = true;
                btnActualizar.Visible = false;
                btnInhabilitarHabilitar.Visible = false;
                cmbProveedor.Enabled = true;
            }
        }

        public void datosH()
        {
            // Cargar los datos al listbox
            Contacto nuevo = new Contacto();

            // Creamos la lista
            List<Contacto> lista = Contacto.ListarContactoTodosH();

            // Limpiar el listbox
            lstHabilitado.Items.Clear();

            if (lista.Any())
            {
                lista.ForEach(contacto => lstHabilitado.Items.Add(contacto.nombres.ToString()));
            }
            else
            {
                lstHabilitado.Items.Add("No hay registros");
            }
        }

        public void datosI()
        {
            // Cargar los datos al listbox
            Contacto nuevo = new Contacto();

            // Creamos la lista
            List<Contacto> lista = Contacto.ListarContactoTodosI();

            // Limpiar el listbox
            lstInhabilitado.Items.Clear();

            if (lista.Any())
            {
                lista.ForEach(contacto => lstInhabilitado.Items.Add(contacto.nombres.ToString()));
            }
            else
            {
                lstInhabilitado.Items.Add("No hay registros");
            }
        }

        private void btnInhabilitarHabilitar_Click(object sender, EventArgs e)
        {
            Contacto eContacto = new Contacto();
            eContacto.idContacto = mskIdentidad.Text;
            if (Contacto.Inhabilitar_Habilitar_Contacto(eContacto))
            {
                MessageBox.Show(eContacto.m);
                limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la actualización");
                limpiar();
            }
        }

        /// <summary>
        /// Propiedad encargada de validar el formato de un correo válido
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
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
            if (!email_bien_escrito(txtCorreo.Text))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido con el siguiente formato: nombre@dominio.com," +
                   "Intente nuevamente con un registro válido", "Control de correo electrónico", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtCorreo.SelectAll();
                txtCorreo.Focus();
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
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
