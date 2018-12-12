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
    public partial class frmCliente : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public string idUsuario;
        public frmCliente(string x)
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            datosI();
            datosH();
            mskIdentidad.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            mskTelefono.Text = "";
            txtCorreo.Text = "";
            btnAgregar.Visible = true;
            btnActualizar.Visible = false;
            btnHa_In.Visible = false;
            lstHabilitados.Visible = false;
            lstInhabilitados.Visible = false;
            mskIdentidad.Focus();
        }

        public void datosH()
        {
            // cargamos los datos al listbox
             Cliente nuevo = new Cliente();

            // Creamos la lista
            List<Cliente> lista = Cliente.ListarClienteTodosH();

            // Limpiar el listBox
            lstHabilitados.Items.Clear();

            if (lista.Any())
            {
                lista.ForEach(cliente => lstHabilitados.Items.Add(cliente.nombres.ToString()));
            }
            else
            {
                lstHabilitados.Items.Add("No hay registros");
            }
        }

        public void datosI()
        {
            // cargamos los datos al listbox
            Cliente nuevo = new Cliente();

            // Creamos la lista
            List<Cliente> lista = Cliente.ListarClienteTodosI();

            // Limpiar el listBox
            lstInhabilitados.Items.Clear();

            if (lista.Any())
            {
                lista.ForEach(cliente => lstInhabilitados.Items.Add(cliente.nombres.ToString()));
            }
            else
            {
                lstInhabilitados.Items.Add("No hay registros");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.identidad = mskIdentidad.Text;
            nuevoCliente.nombres = txtNombres.Text;
            nuevoCliente.apellidos = txtApellidos.Text;
            nuevoCliente.direccion = txtDireccion.Text;
            nuevoCliente.telefono = mskTelefono.Text;
            nuevoCliente.correo = txtCorreo.Text;
            nuevoCliente.usuario = Convert.ToInt32(idUsuario);

            if (Cliente.AgregarCliente(nuevoCliente))
            {
                MessageBox.Show("Se han agregado los datos con éxito");
                limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un problema en la inserción de los datos");
                limpiar();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            limpiar();
        }
        


        private void lstHabilitados_Click(object sender, EventArgs e)
        {
            if (lstHabilitados.SelectedItem.ToString() == "No hay registros")
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
                Cliente elCliente = new Cliente();
                elCliente = Cliente.ObtenerCliente2(lstHabilitados.SelectedItem.ToString());
                mskIdentidad.Text = elCliente.identidad;
                txtNombres.Text = elCliente.nombres;
                txtApellidos.Text = elCliente.apellidos;
                txtDireccion.Text = elCliente.direccion;
                mskTelefono.Text = elCliente.telefono;
                txtCorreo.Text = elCliente.correo;
            }
        }

        private void lstInhabilitados_Click(object sender, EventArgs e)
        {
            if (lstInhabilitados.SelectedItem.ToString() == "No hay registros")
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
                Cliente elCliente = new Cliente();
                elCliente = Cliente.ObtenerCliente2(lstInhabilitados.SelectedItem.ToString());
                mskIdentidad.Text = elCliente.identidad;
                txtNombres.Text = elCliente.nombres;
                txtApellidos.Text = elCliente.apellidos;
                txtDireccion.Text = elCliente.direccion;
                mskTelefono.Text = elCliente.telefono;
                txtCorreo.Text = elCliente.correo;
            }
        }

        private void btnHabilitados_Click(object sender, EventArgs e)
        {
            lstHabilitados.Visible = true;
            lstInhabilitados.Visible = false;
        }

        private void btnInhabilitados_Click(object sender, EventArgs e)
        {
            lstHabilitados.Visible = false;
            lstInhabilitados.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente eCliente = new Cliente();
            eCliente.identidad = mskIdentidad.Text;
            eCliente.nombres = txtNombres.Text;
            eCliente.apellidos = txtApellidos.Text;
            eCliente.direccion = txtDireccion.Text;
            eCliente.telefono = mskTelefono.Text;
            eCliente.correo = txtCorreo.Text;
            eCliente.usuario = Convert.ToInt32(idUsuario);

            if (Cliente.ActualizarCliente(eCliente))
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

        private void btnHa_In_Click(object sender, EventArgs e)
        {
            Cliente eCliente = new Cliente();
            eCliente.identidad = mskIdentidad.Text;

            if (Cliente.Inhabilitar_Habilitar_Cliente(eCliente))
            {
                MessageBox.Show(eCliente.m);
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
            Cliente eCliente = Cliente.ObtenerCliente(mskIdentidad.Text);
            txtNombres.Text = eCliente.nombres;
            txtApellidos.Text = eCliente.apellidos;
            txtDireccion.Text = eCliente.direccion;
            mskTelefono.Text = eCliente.telefono;
            txtCorreo.Text = eCliente.correo;
            if (txtNombres.Text != "")
            {
                btnAgregar.Visible = false;
                btnActualizar.Visible = true;
                btnHa_In.Visible = true;
            }
            else
            {
                btnAgregar.Visible = true;
                btnActualizar.Visible = false;
                btnHa_In.Visible = false;
            }
        }
    }
}
