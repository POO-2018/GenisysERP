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
            lstHabilitado.Visible = false;
            lstInhabilitado.Visible = false;

            datosH();
            //datosI();
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

        private void txtNombreEmpresa_Leave(object sender, EventArgs e)
        {
            Clientes.Proveedor nuevoProveedor = Clientes.Proveedor.ObtenerProveedor(txtNombreEmpresa.Text);
            txtDireccion.Text = nuevoProveedor.direccion;
            mskTelefono.Text = nuevoProveedor.telefono;
            txtCorreo.Text = nuevoProveedor.correo;

            if (txtDireccion.Text != "")
            {
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = true;
                btnHa_In.Enabled = true;
            }
            else
            {
                btnActualizar.Enabled = false;
                btnHa_In.Enabled = false;
                btnAgregar.Enabled = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHa_In_Click(object sender, EventArgs e)
        {
            //instanciamos de la clase proveedor
            Clientes.Proveedor nuevoProveedor = new Clientes.Proveedor();
            nuevoProveedor.nombreEmpresa = txtNombreEmpresa.Text;

            if (Clientes.Proveedor.Inhabilitar_Habilitar_Proveedor(nuevoProveedor))
            {
                MessageBox.Show(nuevoProveedor.m);
                //limpiar();
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
            btnActualizar.Enabled = true; //actualizar
            btnHa_In.Enabled = true; //habilitar
            btnAgregar.Enabled = false; //agregar
            Clientes.Proveedor elProveedor = new Clientes.Proveedor();
            elProveedor = Clientes.Proveedor.ObtenerProveedor2(lstHabilitado.SelectedItem.ToString());
            mskTelefono.Text = elProveedor.telefono;
            txtNombreEmpresa.Text = elProveedor.nombreEmpresa;
            txtDireccion.Text = elProveedor.direccion;
            txtCorreo.Text = elProveedor.telefono;
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
                lstHabilitado.Items.Add("No hay registros");
            }
        }

    }
}
