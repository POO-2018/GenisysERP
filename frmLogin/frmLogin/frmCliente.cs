﻿using System;
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

        public frmCliente()
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            datosI();
            datosH();
            txtIdentidad.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnHa_In.Enabled = false;
            lstHabilitados.Visible = false;
            lstInhabilitados.Visible = false;
            txtIdentidad.Focus();
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
            nuevoCliente.identidad = txtIdentidad.Text;
            nuevoCliente.nombres = txtNombres.Text;
            nuevoCliente.apellidos = txtApellidos.Text;
            nuevoCliente.direccion = txtDireccion.Text;
            nuevoCliente.telefono = txtTelefono.Text;
            nuevoCliente.correo = txtCorreo.Text;
            nuevoCliente.usuario = Convert.ToInt32(lblUsuario.Text);

            if (Cliente.AgregarCliente(nuevoCliente))
            {
                MessageBox.Show("Se han agregado los datos con éxito");
                limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un problema en la inserción de los datos");
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtIdentidad_Leave(object sender, EventArgs e)
        {
            Cliente eCliente = Cliente.ObtenerCliente(txtIdentidad.Text);
            txtNombres.Text = eCliente.nombres;
            txtApellidos.Text = eCliente.apellidos;
            txtDireccion.Text = eCliente.direccion;
            txtTelefono.Text = eCliente.telefono;
            txtCorreo.Text = eCliente.correo;
            if (txtNombres.Text != "")
            {
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = true;
                btnHa_In.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = true;
                btnActualizar.Enabled = false;
                btnHa_In.Enabled = false;
            }
        }
    }
}